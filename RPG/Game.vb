Public Class Game
    Dim conn As New ADODB.Connection
    Dim foodDist(3) As Boolean 'array determines who gets rations
    Dim dayCountVal As Int16 'counter for game days since starting the game
    Dim rationCountVal As Int16 'counter for rations
    Dim eventID As Short = 0 'ID of event, 0 = no event
    Dim eventCharID As Int16
    Dim eventActionTaken As Boolean = False
    Dim inventoryIDs As New List(Of Short) 'Ids of items in inventory
    Dim charItemIDs As New Dictionary(Of Short, Short) 'IDs of chracters carying items 1. is chracterID 2. is ItemID

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Game_Load: Start of Sub")
        'generic
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")
        'hide the tab control bar
        TabControl.Appearance = TabAppearance.FlatButtons
        TabControl.ItemSize = New Size(0, 1)
        TabControl.SizeMode = TabSizeMode.Fixed
        For Each elem In TabControl.TabPages
            elem.Text = ""
        Next
        'end hide

        'main menu
        Difficulty.SelectedIndex = 0
        Call checkLoadBtn() 'hide loadbutton if no game save present

        'main game
        charSkills0.Hide() 'hide skillBoxes
        charSkills1.Hide()
        charSkills2.Hide()

        dayCountVal = 1
        foodDist = {False, False, False}
        Dim rs As New ADODB.Recordset
        Dim taskString As String
        Try
            'get possible Tasks
            rs.Open("SELECT * FROM [Task]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
            Console.WriteLine("Game_Load: DB Connection successful")

            For k = 0 To 2 'cycle thorugh task selection comboboxes
                rs.MoveFirst()
                Do While Not rs.EOF 'get all tasks out of db
                    taskString = CStr(rs.Fields("taskName").Value)
                    DirectCast(TabControl.TabPages(3).Controls("task" & k), ComboBox).Items.Add(taskString)
                    Console.WriteLine("Game_Load: Added Task '" & taskString & "' to 'task" & k & "'")
                    rs.MoveNext()
                Loop
            Next
            rs.Close()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
            TabControl.SelectedIndex = 0 'go back to start screen if no db connection
        End Try
        foodDist = {False, False, False}
        Console.WriteLine("Game_Load: End of Sub")
    End Sub

    Private Sub updateFields() 'update the main menu fields
        Console.WriteLine("updateFields: Start of Sub")
        Dim skillNames = New String() {"Intelligenz", "Geschick", "Stärke", "Wahrnehmung", "Mental"} 'human readable names for skills
        Dim rs As New ADODB.Recordset
        Dim rs_items As New ADODB.Recordset
        'update Character Values
        Dim k As Int16 'counter val to cycle through skills in rs
        charItemIDs.Clear()
        For i = 0 To 2
            Console.WriteLine("update_Fields: Updating for Character " & i)
            rs.Open("SELECT * FROM [Character] WHERE ID=" & i, conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
            rs_items.Open("SELECT * FROM [Items] WHERE ID=" & rs.Fields("itemID").Value, conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
            TabControl.TabPages(3).Controls("name" & i).Text = (CStr(rs.Fields("fullName").Value)) 'fill name boxes with names
            TabControl.TabPages(3).Controls("healthBar" & i).Text = (getBar(rs.Fields("health").Value, "DEAD")) 'fill healthbar
            TabControl.TabPages(3).Controls("item" & i).Text = (rs_items.Fields("itemName").Value) 'fill item field
            charItemIDs.Add(i, rs.Fields("itemID").Value)

            If rs.Fields("health").Value = 0 Then
                killChar(i) 'self explanatory
            Else
                TabControl.TabPages(3).Controls("hungerBar" & i).Text = (getBar(rs.Fields("hunger").Value, "STARVING"))
            End If
            Console.WriteLine("update_Fields: Updating Skills for Character " & i)
            k = 4
            DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Clear() 'clear skill info box
            For Each elem In skillNames 'fill skill info boxes
                DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add(padText(elem, 10) & ": " & (rs.Fields(k).Value))
                DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add("---------------") '
                k += 1
            Next
            rs_items.Close()
            rs.Close()
        Next


        'update Day and Rations
        rs.Open("SELECT * FROM [Day]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        rs.MoveLast() 'go to most recent entry
        dayCountVal = rs.Fields("counter").Value
        rationCountVal = rs.Fields("rations").Value
        dayCounter.Text = "Tag " & CStr(dayCountVal) 'set fields
        foodCounter.Text = CStr(rationCountVal) & "Rationen" 'set fields
        rs.Close()

        For i = 0 To 2
            If DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex < 0 Then 'prevent combobox from being empty
                DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex = 1
            End If
            DirectCast(TabControl.TabPages(3).Controls("hungerBar" & i), TextBox).ForeColor = Color.White 'reset hungerbar
        Next

        rs.Open("SELECT SUM(health) FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        If rs.Fields(0).Value = 0 Then 'check if all Characters are dead
            rs.Close()
            Call endGame()
        Else
            rs.Close()
        End If

        'get Inventory from DB
        rs.Open("SELECT [Inventory].ID, [Inventory].itemID, [Items].itemName FROM [Inventory] LEFT JOIN [Items] ON [Inventory].itemID =[Items].ID", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        inventoryBox.Items.Clear()
        inventoryIDs.Clear()
        While Not rs.EOF
            inventoryBox.Items.Add(rs.Fields("itemName").Value)
            inventoryIDs.Add(rs.Fields("itemID").Value)
            rs.MoveNext()
        End While
        rs.Close()
        Console.WriteLine("update_Fields: inventoryIDs: " & String.Join(", ", inventoryIDs))

        Console.WriteLine("update_Fields: End of Sub")
    End Sub
    Sub endGame()
        MsgBox("Alle sind tot. Du hast " & dayCountVal & " Tage geschafft")
        TabControl.SelectedIndex = 0
    End Sub
    Private Function padText(ByVal str As String, ByVal len As Integer)
        While str.Length() <= len
            str &= " "
        End While
        padText = str
    End Function
    Private Function getBar(ByVal value, ByVal zeroWord)
        Dim num As Int16
        Dim str As String
        str = "░"
        num = (value / 100) * 15
        If num = 0 Then
            getBar = zeroWord
        Else
            getBar = Replace(Space(num), " ", str)
        End If
    End Function

    Private Function skillWords(ByRef value)
        Dim words(20) As String
        words = {
        "unfähig",
        "grauenhaft",
        "furchtbar",
        "sehr schlecht",
        "schlecht",
        "gering",
        "mangelhaft",
        "unterdurchschnittlich",
        "mittelmäßig",
        "durchschnittlich",
        "gut",
        "sehr gut",
        "außergewöhnlich",
        "beeindruckend",
        "exzellent",
        "fantastisch",
        "unglaublich",
        "übermenschlich",
        "episch",
        "legendär",
        "gottgleich"}
        skillWords = words(value)
    End Function
    Private Sub calcDay()
        Console.WriteLine("calcDay: Start of Sub")
        Dim rs As New ADODB.Recordset
        eventID = 0
        Call calcTasks()
        Call updateHunger()
        Call updateHealth()

        rs.Open("SELECT * FROM [Day]", conn,
                   ADODB.CursorTypeEnum.adOpenKeyset,
                   ADODB.LockTypeEnum.adLockOptimistic
           )
        rs.AddNew() 'add new Day with updated Values
        rs.Fields("rations").Value = calcRations()
        rs.Fields("counter").Value = (dayCountVal + 1)
        rs.Update()
        rs.Close()
        foodDist = {False, False, False} 'reset foodDist
        Call updateFields()
        Console.WriteLine("calcDay: End of Sub")
    End Sub

    Private Sub updateHunger()
        Console.WriteLine("updateHunger: Start of Sub")
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT hunger FROM [Character]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
        'update hunger
        rs.MoveFirst()
        For Each elem In foodDist
            If elem Then 'increase Hunger if getting ration
                rs.Fields("hunger").Value += 25
            Else
                rs.Fields("hunger").Value -= 25
            End If
            If rs.Fields("hunger").Value < 0 Then
                rs.Fields("hunger").Value = 0
            End If
            If rs.Fields("hunger").Value > 100 Then
                rs.Fields("hunger").Value = 100
            End If
            rs.MoveNext()
        Next
        rs.Close()
        Console.WriteLine("updateHunger: End of Sub")
    End Sub
    Private Sub updateHealth()
        Console.WriteLine("updateHealth: Start of Sub")
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT hunger, health FROM [Character]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
        rs.MoveFirst()
        Do While Not rs.EOF
            If rs.Fields("hunger").Value = 0 Then 'decrease health if starving
                rs.Fields("health").Value -= 30
            End If
            If rs.Fields("health").Value < 0 Then 'treat sub zero value
                rs.Fields("health").Value = 0
            End If
            If rs.Fields("health").Value > 100 Then 'treat >100 value
                rs.Fields("health").Value = 100
            End If
            rs.MoveNext()
        Loop
        rs.Close()
        Console.WriteLine("updateHealth: End of Sub")
    End Sub
    Private Sub hungerBar0_click(sender As Object, e As EventArgs) Handles hungerBar0.Click
        Call hungerBar_click_helper(0, sender)
    End Sub
    Private Sub hungerBar1_click(sender As Object, e As EventArgs) Handles hungerBar1.Click
        Call hungerBar_click_helper(1, sender)
    End Sub
    Private Sub hungerBar2_click(sender As Object, e As EventArgs) Handles hungerbar2.Click
        Call hungerBar_click_helper(2, sender)
    End Sub

    Private Sub hungerBar_click_helper(ByVal i, ByRef sender)
        Console.WriteLine("hungerBar_click_helper: Start of Sub")
        Console.WriteLine("hungerBar_click_helper: Rations: " & rationCountVal)
        Console.WriteLine("hungerBar_click_helper: Getsfood? " & foodDist(i))
        If foodDist(i) Then
            foodDist(i) = Not foodDist(i)
            sender.ForeColor = Color.White
        ElseIf sumArray(foodDist) < rationCountVal And Not foodDist(i) Then
            foodDist(i) = Not foodDist(i)
            sender.ForeColor = Color.Lime
        End If
        Console.WriteLine("hungerBar_click_helper: End of Sub")
    End Sub
    Function calcRations()
        Console.WriteLine("calcRations: Start of Sub")
        Dim rs As New ADODB.Recordset
        Dim num As Int16
        num = 0 'count how many rations are consumed
        For Each elem In foodDist
            If elem Then
                num += 1
            End If
        Next
        rs.Open("SELECT rations FROM [Day]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        rs.MoveLast()
        Console.WriteLine("calcRations: Rations consumed :" & num)
        calcRations = (rs.Fields("rations").Value - num)
        rs.Close()
        Console.WriteLine("calcRations: End of Sub")
    End Function

    Function sumArray(ByVal arr)
        Dim num As Int16
        num = 0
        For Each elem In arr
            If elem Then
                num += 1
            End If
        Next
        Console.WriteLine("Sum of Array: " & num)
        sumArray = num
    End Function

    Sub killChar(ByVal index) 'disables Character fields if dead
        index = CStr(index)
        For Each elem In TabControl.TabPages(3).Controls
            If elem.Name(elem.Name.length - 1) = index Then
                elem.enabled = False
            End If
        Next
    End Sub

    Sub calcTasks()
        Console.WriteLine("calcTasks: Start of Sub")
        Dim rs_tasks As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        Dim rs_strings As New ADODB.Recordset
        Dim taskID As Int16 'index of selected task
        Dim relSkill As String 'relevant skill
        Dim skillLevel As Int16
        Dim result As Int16
        Dim msgString As String 'displayed string for result of task
        Dim resultList As String() = {"", "", ""} 'list for output
        rs_char.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenDynamic,
                    ADODB.LockTypeEnum.adLockOptimistic
            )


        For i = 0 To 2
            eventActionTaken = False
            taskID = DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex + 1 'get ID of assigned task
            Console.WriteLine("calcTasks: task" & i & " selected Index: " & taskID)

            If taskID > 0 And rs_char.Fields("health").Value > 0 Then 'true if selection not null and character alive
                Console.WriteLine("calcTasks: SQL-String: & SELECT * FROM [Task] WHERE [ID]=" & taskID)
                rs_tasks.Open("SELECT * FROM [Task] WHERE [ID]=" & taskID, conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
                relSkill = rs_tasks.Fields("relevantSkill").Value
                skillLevel = rs_char.Fields(relSkill).Value
                Console.WriteLine("calcTasks: relevant skill: " & relSkill)
                Console.WriteLine("calcTasks skilllevel: " & skillLevel)

                result = getOutcome(skillLevel) 'calculate outcome
                Console.WriteLine("calcTasks: result: " & result)

                Console.WriteLine("calcTasks: SQL-String:" & "SELECT * FROM [TaskResultStrings] WHERE taskID = " & taskID & " AND outcome = " & result)
                rs_strings.Open("SELECT * FROM [TaskResultStrings] WHERE taskID = " & taskID & " AND outcome = " & result, conn,
                                ADODB.CursorTypeEnum.adOpenStatic
                ) 'open recordset with relevant stings

                randomRecord(rs_strings) 'randomize which string is displayed
                msgString = rs_char.Fields("fullName").Value & " " & rs_strings.Fields("string").Value

                If rs_tasks.Fields("outcome" & result).Value = "event" Then
                    Console.WriteLine("calcTasks: the outcome is 'event'")
                    eventCharID = rs_char.Fields(0).Value
                    Call openEvent(rs_tasks.Fields(0).Value, rs_char)
                    Do 'wait for the user react to event
                        If eventActionTaken = True Then
                            Exit Do
                        End If
                        Application.DoEvents()
                    Loop
                Else
                    Console.WriteLine("calcTasks: the outcome is NOT 'event'")
                    parseOutcome(rs_tasks.Fields("outcome" & result).Value, rs_char)
                    resultList(i) = msgString
                End If

                rs_strings.Close()
                rs_tasks.Close()
            End If

            rs_char.MoveNext()
        Next

        displayOutcome(arrToStr(resultList, vbLf))
        rs_char.Close()
        Console.WriteLine("calcTasks: End of Sub")
    End Sub

    Function arrToStr(ByRef arr, ByVal sep) 'convert array to string
        Dim str As String
        str = ""
        For Each elem In arr
            str = str & elem & sep

        Next
        arrToStr = str
    End Function

    Sub displayOutcome(ByVal message As String)
        outcomeBox.Text = message
        TabControl.SelectedIndex = 5
    End Sub
    Sub parseOutcome(ByVal outString As String, ByRef rs_char As ADODB.Recordset)
        Console.WriteLine("parseOutcome: Start of Sub")
        Dim rs As New ADODB.Recordset
        Dim num As Int16
        Dim str As String
        'splitter
        Console.WriteLine("Outcome: " & outString)
        Dim arr As String() = outString.Split(":") 'split outcome to array
        str = arr(0)
        num = CInt(arr(1))
        Console.WriteLine("parseOutcome: string: " & str)
        Console.WriteLine("parseOutcome: num: " & num)
        'change values
        Select Case str
            Case "food"
                rs.Open("SELECT rations FROM [Day]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
                rs.MoveLast()
                rs.Fields("rations").Value += num
                rs.Update()
                rs.Close()
            Case "health"
                rs_char.Fields("health").Value += num
                If rs_char.Fields("health").Value < 0 Then
                    rs_char.Fields("health").Value = 0
                End If
                If rs_char.Fields("health").Value > 100 Then
                    rs_char.Fields("health").Value = 100
                End If
            Case "intelligence", "agility", "strength", "perception", "mental"
                rs_char.Fields(str).Value += num
                If rs_char.Fields(str).Value > 20 Then
                    rs_char.Fields(str).Value = 20
                End If
        End Select
        rs_char.Update()
        Console.WriteLine("parseOutcome: End of Sub")
    End Sub

    Sub openEvent(ByVal taskID As Integer, ByRef rs_char As ADODB.Recordset)
        Console.WriteLine("openEvent: Start of Sub")
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Event] WHERE [taskID]=" & taskID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockReadOnly
          )
        randomRecord(rs)

        eventID = rs.Fields(0).Value
        'fill textboxes in event screen
        eventTextBox.Text = rs_char.Fields("fullName").Value & " " & rs.Fields("eventString").Value
        eventAction0.Text = rs.Fields("option0").Value
        eventAction1.Text = rs.Fields("option1").Value
        TabControl.SelectedIndex = 4
        eventGoBack.Hide()
        eventAction0.Show()
        eventAction1.Show()
        eventOutcomeBox.Text = ""

        rs.Close()
        Console.WriteLine("openEvent: End of Sub")
    End Sub
    Sub eventCalcOutcome(ByVal action As Integer)
        Console.WriteLine("eventCalcOutcome: Start of Sub")
        Console.WriteLine("eventCalcOutcome: ActionID: " & action)
        Console.WriteLine("eventCalcOutcome: eventID: " & eventID)
        Dim rs_event As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        Dim rs_string As New ADODB.Recordset
        Dim outcome As New Int16
        Dim relSkill As String 'relevant Skill
        rs_event.Open("SELECT * FROM [Event] WHERE [ID]=" & eventID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockReadOnly
          )
        rs_char.Open("SELECT * FROM [Character] WHERE [ID]=" & eventCharID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockPessimistic
          )

        relSkill = rs_event.Fields("relevantSkill" & action).Value
        Console.WriteLine("eventCalcOutcome: relevant Skill: " & relSkill)

        outcome = (getOutcome(rs_char.Fields(relSkill).Value) \ 4) 'outcome 0-3 = 0, 4-5=1
        outcome = outcome + (action * 2)
        Console.WriteLine("eventCalcOutcome: Outcome: " & outcome)

        rs_string.Open("SELECT * FROM [EventResultString] WHERE [eventID]=" & eventID & "AND [outcome]=" & outcome, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockReadOnly
          )
        randomRecord(rs_string)

        eventOutcomeBox.Text = rs_char.Fields("fullName").Value & " " & rs_string.Fields("string").Value
        parseOutcome(rs_event.Fields("outcome" & outcome).Value, rs_char)

        With rs_event
            .CancelUpdate()
            .Close()
        End With
        rs_string.Close()
        With rs_char
            .Update()
            .Close()
        End With
        eventGoBack.Show()
        Console.WriteLine("eventCalcOutcome: End of Sub")
    End Sub

    Function getOutcome(ByVal skill)
        Console.WriteLine("getOutcome: Start of Sub")
        Randomize()
        'gets outcome determined by binomial dist higher skill = higher p
        Dim p As Single
        Dim out As Int16
        out = 0
        p = ((0.045 * skill) + 0.05)
        For i = 0 To 4
            If p < Rnd() Then
                out += 1
            End If
        Next
        Console.WriteLine("getOutcome: Outcome: " & out)
        getOutcome = out
        Console.WriteLine("getOutcome: End of Sub")
    End Function

    Sub moveAbsolute(ByRef rs, ByVal pos) 'this function only exists because Recordset.moveabsolute is very unreliable
        rs.MoveFirst()
        If pos > rs.RecordCount - 1 Then
            rs.MoveLast()
        Else
            For i = 1 To pos
                rs.MoveNext()
            Next
        End If
    End Sub
    Sub randomRecord(ByRef rs) 'moves rs cursor to a random position (excluding BOF and EOF)
        Dim numOfRecords As Long
        Dim recordPos As Int16
        Randomize()
        numOfRecords = rs.RecordCount
        recordPos = Int(numOfRecords * Rnd()) 'calculate a random pos in rs
        If recordPos = numOfRecords And recordPos > 0 Then 'treat out of range edge case
            recordPos -= 1
        End If
        moveAbsolute(rs, recordPos)
    End Sub
    Sub checkLoadBtn()
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Day]", conn, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly)
        If rs.RecordCount = 0 Then 'disable load if no game in db
            loadGameBtn.Enabled = False
        End If
        rs.Close()
    End Sub

    Private Sub createNewGame()
        Console.WriteLine("createNewGame: Start of Sub")

        'clear db
        conn.Execute("DELETE FROM [Day]")
        conn.Execute("DELETE FROM [Character]")

        Dim rs_day As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        rs_day.Open("SELECT * FROM [Day]", conn, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic)
        rs_char.Open("SELECT * FROM [Character]", conn, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic)

        rs_day.AddNew()
        rs_day.Fields("rations").Value = 5
        rs_day.Fields("counter").Value = 1
        rs_day.Update()

        For i = 0 To 2
            Dim x As Short = 4
            Dim skills As Int16() = newSkills(Difficulty.SelectedIndex)
            rs_char.AddNew()
            rs_char.Fields(0).Value = i
            rs_char.Fields(1).Value = "NONAME " & i
            rs_char.Fields(2).Value = 100
            rs_char.Fields(3).Value = 100
            For Each elem In skills
                rs_char.Fields(x).Value = elem
                x += 1
            Next
            rs_char.Update()
        Next
        rs_char.Close()
        rs_day.Close()
        For Each elem In TabControl.TabPages(3).Controls 'enable all character fields. They might be disabled if chracter died in previous game
            elem.Enabled = True
        Next
        TabControl.SelectedIndex = 3
        Call updateFields()
        Console.WriteLine("createNewGame: End of Sub")
    End Sub
    Function newSkills(ByVal diff)
        Console.WriteLine("newSkills: Start of Sub")
        Dim difficulties As Short() = {75, 50, 25, 0} ' total amount of skill points per character

        Dim tmpSkill As Int16 'newly calulated Skill
        Dim total As Short = difficulties(diff) 'max skillpoints
        Dim i As Int16 'counter for array index
        Dim skillArray() As Short = {0, 0, 0, 0, 0}

        While total > 0 'while limit for skillPoints is not reached
            i = 0
            For Each elem In skillArray
                If total > 20 Then
                    Console.WriteLine("newSkills: calculating skil 0-20")
                    tmpSkill = CInt(Math.Ceiling(Rnd() * (20))) 'random num 0 -> 20 (inclusive)
                Else
                    Console.WriteLine("newSkills: calulating skil 0-total")
                    tmpSkill = CInt(Math.Ceiling(Rnd() * total))
                End If
                If Not elem > (20 - tmpSkill) Then 'treat edge case where skill might become >20
                    Console.WriteLine("newSkills: Elem: " & elem)
                    Console.WriteLine("newSkills: Temp: " & tmpSkill)
                    skillArray(i) += tmpSkill
                    total -= tmpSkill
                    Console.WriteLine(String.Join(", ", skillArray))
                End If
                i += 1
            Next
        End While
        Shuffle(skillArray) 'shuffling is mandatory because otherwise last numbers in Array are alwas smaller
        newSkills = skillArray
        Console.WriteLine("newSkills: End of Sub")
    End Function

    Private Sub Shuffle(items As Int16())
        Dim rnd As New Random()
        Dim j As Int32
        Dim temp As Int16

        For n As Int32 = items.Length - 1 To 0 Step -1
            j = rnd.Next(0, n + 1)
            ' Swap them.
            temp = items(n)
            items(n) = items(j)
            items(j) = temp
        Next n
    End Sub
    Private Sub newGameBtn_click(sender As Object, e As EventArgs) Handles newGameBtn.Click
        TabControl.SelectedIndex = 1
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        TabControl.SelectedIndex = 0
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim confirm As DialogResult
        confirm = MessageBox.Show("Durch starten eines neuen Spiels wird jeder vohandene Spielstand gelöscht. Neues Spiel?",
                                     "",
                                     MessageBoxButtons.YesNo)
        If (confirm = DialogResult.Yes) Then
            Call createNewGame()
        End If
    End Sub

    Private Sub loadGameBtn_Click(sender As Object, e As EventArgs) Handles loadGameBtn.Click
        TabControl.SelectedIndex = 3
        Call updateFields()
    End Sub

    Private Sub charPic0_Hover(sender As Object, e As EventArgs) Handles charPic0.MouseEnter
        charSkills0.Show()
    End Sub
    Private Sub charSkills0_Leave(sender As Object, e As EventArgs) Handles charSkills0.MouseLeave
        charSkills0.Hide()
    End Sub
    Private Sub charPic1_Hover(sender As Object, e As EventArgs) Handles charPic1.MouseEnter
        charSkills1.Show()
    End Sub
    Private Sub charSkills1_Leave(sender As Object, e As EventArgs) Handles charSkills1.MouseLeave
        charSkills1.Hide()
    End Sub
    Private Sub charPic2_Hover(sender As Object, e As EventArgs) Handles charPic2.MouseEnter
        charSkills2.Show()
    End Sub
    Private Sub charSkills2_Leave(sender As Object, e As EventArgs) Handles charSkills2.MouseLeave
        charSkills2.Hide()
    End Sub

    Private Sub GO_Click(sender As Object, e As EventArgs) Handles GO.Click
        Call calcDay()
    End Sub

    Private Sub main_MouseEnter(sender As Object, e As EventArgs) Handles main.MouseEnter
        charSkills0.Hide() 'this treats bug where listbox would sometimes not hide correctly
        charSkills1.Hide()
        charSkills2.Hide()
    End Sub

    Private Sub manualBtn_Click(sender As Object, e As EventArgs) Handles manualBtn.Click
        TabControl.SelectedIndex = 2
    End Sub

    Private Sub eventAction0_Click(sender As Object, e As EventArgs) Handles eventAction0.Click
        eventAction_ClickHelper(0)
    End Sub
    Private Sub eventAction1_Click(sender As Object, e As EventArgs) Handles eventAction1.Click
        eventAction_ClickHelper(1)
    End Sub
    Private Sub eventAction_ClickHelper(ByVal i As Integer)
        eventAction0.Hide()
        eventAction1.Hide()
        eventCalcOutcome(i)
    End Sub

    Private Sub eventGoBack_Click(sender As Object, e As EventArgs) Handles eventGoBack.Click
        Call updateFields()
        eventActionTaken = True
    End Sub

    Private Sub outcomeGoBack_Click(sender As Object, e As EventArgs) Handles outcomeGoBack.Click
        TabControl.SelectedIndex = 3
    End Sub

    Private Sub inventoryBtn_Click(sender As Object, e As EventArgs)
        TabControl.SelectedIndex = 6
    End Sub

    'Inventory Drag and Drop
    Dim dragdrop_source As Object 'control from which item is being dragged
    Private Sub inventoryBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles inventoryBox.MouseDown
        dragdrop_source = sender
        sender.DoDragDrop(sender.SelectedItem, DragDropEffects.Copy)
    End Sub
    Private Sub item_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles item0.MouseDown, item1.MouseDown, item2.MouseDown
        dragdrop_source = sender
        If sender.Text <> "" Then 'prevent drag and drop of nothing
            sender.DoDragDrop(sender.Text, DragDropEffects.Copy)
        End If
    End Sub
    Private Sub inventoryBox_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles inventoryBox.DragDrop
        Dim sourceID As Short = Integer.Parse(dragdrop_source.Name(dragdrop_source.Name.Length - 1))
        If dragdrop_source.Name <> sender.Name Then 'prevent self drop
            'add Item to Inventory
            sender.Items.Add(e.Data.GetData(DataFormats.Text).ToString)
            inventoryIDs.Add(charItemIDs(sourceID))
            addToInv(charItemIDs(sourceID))

            'remove Item from Sender
            dragdrop_source.Text = "" 'clear Textbox
            removeItemFromChar(sourceID)
            charItemIDs(sourceID) = 0
        End If
    End Sub
    Private Sub item_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles item0.DragDrop, item1.DragDrop, item2.DragDrop
        Console.WriteLine("sender.name: " & sender.name)
        Console.WriteLine("sender.name last char: " & sender.Name(sender.Name.Length - 1))
        Dim targetID As Short = Integer.Parse(sender.Name(sender.Name.Length - 1)) 'ID of character recieving object
        Console.WriteLine("targetID: " & targetID)

        If dragdrop_source.Name <> sender.Name Then 'prevent self drop
            If sender.Text <> "" Then 'if already item in textbox put back into inventory
                If TypeOf (dragdrop_source) Is ListBox Then
                    'add to Inventory
                    dragdrop_source.Items.Add(sender.Text)
                    addToInv(charItemIDs(targetID))
                    'add to Character
                    addItemToChar(targetID, inventoryIDs(inventoryBox.SelectedIndex))
                End If
            End If

            If TypeOf (dragdrop_source) Is TextBox Then 'treat exchange between textboxes
                Dim sourceID As Short = Integer.Parse(dragdrop_source.Name(dragdrop_source.Name.Length - 1)) 'ID of character giving object
                dragdrop_source.Text = sender.Text
                'add item to source character
                addItemToChar(sourceID, charItemIDs(targetID))
                'add item to target character
                addItemToChar(targetID, charItemIDs(sourceID))
            End If

            If TypeOf (dragdrop_source) Is ListBox Then
                'add to character
                addItemToChar(targetID, inventoryIDs(inventoryBox.SelectedIndex))
                'remove from Inventory
                removeFromInv(inventoryBox.SelectedIndex)
                inventoryBox.Items.RemoveAt(inventoryBox.SelectedIndex) 'remove item from Inventory
                inventoryBox.SelectedIndex = -1
            End If

            sender.Text = e.Data.GetData(DataFormats.Text).ToString
        End If
    End Sub
    Private Sub item_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles item0.DragEnter, item1.DragEnter, item2.DragEnter, inventoryBox.DragEnter
        e.Effect = e.AllowedEffect And DragDropEffects.Copy
    End Sub

    Sub removeFromInv(index) 'remove item form inventory in db
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Inventory] WHERE itemID=" & inventoryIDs.Item(index), conn,
            ADODB.CursorTypeEnum.adOpenStatic,
            ADODB.LockTypeEnum.adLockPessimistic
    )
        rs.Delete()
        rs.Update()
        inventoryIDs.RemoveAt(index)
    End Sub
    Sub removeItemFromChar(ByVal characterID) 'remove item from a character
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Character] WHERE ID=" & characterID, conn,
            ADODB.CursorTypeEnum.adOpenStatic,
            ADODB.LockTypeEnum.adLockPessimistic
    )
        rs.Fields("itemID").Value = 0
        rs.Update()
        rs.Close()
    End Sub
    Sub addToInv(ByVal itemID) 'add item to inventory
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Inventory] ", conn,
            ADODB.CursorTypeEnum.adOpenStatic,
            ADODB.LockTypeEnum.adLockPessimistic
    )
        rs.AddNew()
        rs.Fields("itemID").Value = itemID
        rs.Update()
        rs.Close()
        inventoryIDs.Add(itemID)
    End Sub
    Sub addItemToChar(ByVal characterID, ByVal itemID) 'remove item from a character
        Console.WriteLine("addItemToChar: characterID= " & characterID & " itemID=" & itemID)
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Character] WHERE ID=" & characterID, conn,
            ADODB.CursorTypeEnum.adOpenStatic,
            ADODB.LockTypeEnum.adLockPessimistic
    )
        rs.Fields("itemID").Value = itemID
        rs.Update()
        rs.Close()
        charItemIDs(characterID) = itemID
    End Sub
End Class
