Public Class Game
    Dim conn As New ADODB.Connection
    Dim foodDist(3) As Boolean 'array determines who gets rations
    Dim dayCountVal As Int16
    Dim rationCountVal As Int16
    Dim eventID As Int16
    Dim eventCharID As Int16
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Try
            'get possible Tasks
            rs.Open("SELECT * FROM [Task]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
            Do While Not rs.EOF
                For k = 0 To 2
                    DirectCast(TabControl.TabPages(3).Controls("task" & k), ComboBox).Items.Add(CStr(rs.Fields("taskName").Value))
                Next
                rs.MoveNext()
            Loop
            rs.Close()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
        foodDist = {False, False, False}
    End Sub

    Private Sub updateFields() 'update the main menu fields
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        rs.MoveFirst()
        'update Character Values
        If rs.RecordCount > 0 Then
            'rs.MoveFirst()
            Dim i = 0 'counter val to cycle through character specific textboxes
            Dim k As Int16 'counter val to cycle through skills in db
            Dim skillNames = New String() {"Intelligenz", "Geschick", "Stärke", "Wahrnehmung", "Mental"}
            Do While Not rs.EOF
                TabControl.TabPages(3).Controls("name" & i).Text = (CStr(rs.Fields("fullName").Value))
                TabControl.TabPages(3).Controls("healthBar" & i).Text = (getBar(rs.Fields("health").Value, "DEAD"))
                If rs.Fields("health").Value = 0 Then
                    killChar(i)
                End If
                TabControl.TabPages(3).Controls("hungerBar" & i).Text = (getBar(rs.Fields("hunger").Value, "STARVING"))
                For x = 0 To 2
                    k = 4
                    DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Clear()
                    For Each elem In skillNames
                        DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add(padText(elem, 10) & ": " & (rs.Fields(k).Value))
                        DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add("---------------")
                        'DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add(skillWords(rs.Fields(k).Value))
                        k += 1
                    Next
                Next
                rs.MoveNext()
                i += 1
            Loop
        Else
            MsgBox("No Data")
        End If
        rs.Close()
        'update Day and Rations

        rs.Open("SELECT * FROM [Day]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        rs.MoveLast()
        dayCountVal = rs.Fields("counter").Value
        rationCountVal = rs.Fields("rations").Value
        'TabControl.TabPages(3).Controls.
        dayCounter.Text = "Tag " & CStr(dayCountVal)
        'TabControl.TabPages(3).Controls.
        foodCounter.Text = CStr(rationCountVal) & " Rationen"
        rs.Close()
        For i = 0 To 2
            If DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex < 0 Then 'prevent combobox from being empty
                DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex = 1
            End If
            DirectCast(TabControl.TabPages(3).Controls("hungerBar" & i), TextBox).ForeColor = Color.White
        Next
        rs.Open("SELECT SUM(health) FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        If rs.Fields(0).Value = 0 Then
            rs.Close()
            Call endGame()
        Else
            rs.Close()
        End If
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
        Dim rs As New ADODB.Recordset
        Call calcTasks()
        Call updateHunger()
        Call updateHealth()
        rs.Open("SELECT * FROM [Day]", conn,
                   ADODB.CursorTypeEnum.adOpenKeyset,
                   ADODB.LockTypeEnum.adLockOptimistic
           )

        rs.AddNew()
        rs.Fields("rations").Value = calcRations()
        rs.Fields("counter").Value = (dayCountVal + 1)
        rs.Update()
        rs.Close()
        foodDist = {False, False, False}
        Call updateFields()
    End Sub

    Private Sub updateHunger()
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT hunger FROM [Character]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
        'update hunger
        rs.MoveFirst()
        For Each elem In foodDist
            If elem Then
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
    End Sub
    Private Sub updateHealth()
        Dim rs As New ADODB.Recordset
        Dim i As Int16
        rs.Open("SELECT hunger, health FROM [Character]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
        rs.MoveFirst()
        i = 0
        Do While Not rs.EOF
            If rs.Fields("hunger").Value = 0 Then
                rs.Fields("health").Value -= 30
            End If
            If rs.Fields("health").Value < 0 Then
                rs.Fields("health").Value = 0
                'Call killChar(i)
            End If
            If rs.Fields("health").Value > 100 Then
                rs.Fields("health").Value = 100
            End If
            i += 1
            rs.MoveNext()
        Loop
        rs.Close()
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
        Console.WriteLine("Rations: " & rationCountVal)
        Console.WriteLine("Getsfood? " & foodDist(i))
        If foodDist(i) Then
            foodDist(i) = Not foodDist(i)
            sender.ForeColor = Color.White
        ElseIf sumArray(foodDist) < rationCountVal And Not foodDist(i) Then
            foodDist(i) = Not foodDist(i)
            sender.ForeColor = Color.Lime
        End If
    End Sub
    Function calcRations()
        Dim rs As New ADODB.Recordset
        Dim num As Int16
        num = 0
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
        calcRations = (rs.Fields("rations").Value - num)
        rs.Close()
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

    Sub killChar(ByVal index)
        index = CStr(index)
        For Each elem In TabControl.TabPages(3).Controls
            If elem.Name(elem.Name.length - 1) = index Then
                elem.enabled = False
            End If
        Next
    End Sub

    Sub calcTasks()
        Dim rs_tasks As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        Dim rs_strings As New ADODB.Recordset
        Dim taskInd As Long
        Dim relSkill As String
        Dim skillLevel As Int16
        Dim result As Int16
        Dim msgString As String
        Dim resultList(3) As String
        resultList = {"", "", ""}
        rs_char.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenDynamic,
                    ADODB.LockTypeEnum.adLockOptimistic
            )
        rs_tasks.Open("SELECT * FROM [Task]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockReadOnly
            )
        For i = 0 To 2
            taskInd = DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex 'get index of assigned task
            If taskInd <> -1 And rs_char.Fields("health").Value > 0 Then
                Console.WriteLine(taskInd)
                moveAbsolute(rs_tasks, taskInd)
                relSkill = rs_tasks.Fields("relevantSkill").Value
                Console.WriteLine("Relevantskill: " & relSkill)
                skillLevel = rs_char.Fields(relSkill).Value
                Console.WriteLine("Skilllevel: " & skillLevel)
                result = getOutcome(skillLevel)
                Console.WriteLine("Result: " & result)
                Console.WriteLine("SQL-String:" & "SELECT * FROM [TaskResultStrings] WHERE taskID = " & taskInd + 1 & " AND outcome = " & result)
                rs_strings.Open("SELECT * FROM [TaskResultStrings] WHERE taskID = " & taskInd + 1 & " AND outcome = " & result, conn,
                                ADODB.CursorTypeEnum.adOpenStatic
                ) 'open recordset with relevant stings
                randomRecord(rs_strings)
                msgString = rs_char.Fields("fullName").Value & " " & rs_strings.Fields("string").Value
                eventCharID = rs_char.Fields(0).Value
                If rs_tasks.Fields("outcome" & result).Value = "event" Then
                    Call openEvent(rs_tasks.Fields(0).Value, rs_char)
                Else
                    parseOutcome(rs_tasks.Fields("outcome" & result).Value, rs_char)
                    resultList(i) = msgString
                End If
                rs_strings.Close()
            End If
            rs_char.MoveNext()
        Next
        MsgBox(arrToStr(resultList, vbLf))
        'rs_tasks.Update()
        'rs_char.Update()
        rs_tasks.Close()
        rs_char.Close()
    End Sub

    Function arrToStr(ByRef arr, ByVal sep)
        Dim str As String
        str = ""
        For Each elem In arr
            str = str & elem & sep

        Next
        arrToStr = str
    End Function
    Sub parseOutcome(ByVal outString As String, ByRef rs_char As ADODB.Recordset)
        Dim arr(2) As String
        Dim rs As New ADODB.Recordset
        Dim num As Int16
        Dim str As String
        'splitter
        Console.WriteLine("Outcome: " & outString)
        arr = outString.Split(":")
        str = arr(0)
        num = CInt(arr(1))
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
        End Select
    End Sub

    Sub openEvent(ByVal taskID As Integer, ByRef rs_char As ADODB.Recordset)
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Event] WHERE [taskID]=" & taskID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockReadOnly
          )
        randomRecord(rs)
        eventID = rs.Fields(0).Value
        eventTextBox.Text = rs_char.Fields("fullName").Value & " " & rs.Fields("eventString").Value
        eventAction0.Text = rs.Fields("option0").Value
        eventAction1.Text = rs.Fields("option1").Value
        TabControl.SelectedIndex = 4
        eventGoBack.Hide()
        eventAction0.Show()
        eventAction1.Show()
        eventOutcomeBox.Text = ""
        rs.Close()
    End Sub
    Sub eventCalcOutcome(ByVal action As Integer)
        Console.WriteLine("ActionID: " & action)
        Dim rs_event As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        Dim rs_string As New ADODB.Recordset
        Dim outcome As New Int16
        Dim relSkill As String
        rs_event.Open("SELECT * FROM [Event] WHERE [ID]=" & eventID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockReadOnly
          )
        rs_char.Open("SELECT * FROM [Character] WHERE [ID]=" & eventCharID, conn,
                  ADODB.CursorTypeEnum.adOpenStatic,
                  ADODB.LockTypeEnum.adLockPessimistic
          )

        relSkill = rs_event.Fields("relevantSkill" & action).Value
        outcome = (getOutcome(rs_char.Fields(relSkill).Value) \ 4) 'outcome 0-3 = 0, 4-5=1
        outcome = outcome + (action * 2)
        Console.WriteLine("Outcome: " & outcome)
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
    End Sub

    Function getOutcome(ByVal skill)
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
        Console.WriteLine("getOutcome Outcome: " & out)
        getOutcome = out
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
    Sub randomRecord(ByRef rs) 'this doesnt work, i dont know why
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
        conn.Execute("DELETE FROM [Day]") 'clear db
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
            Dim skills(5) As Int16
            Dim x As Int16
            x = 4
            skills = newSkills(Difficulty.SelectedIndex)
            rs_char.AddNew()
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
        For Each elem In TabControl.TabPages(3).Controls
            elem.Enabled = True
        Next
        TabControl.SelectedIndex = 3
        Call updateFields()
    End Sub
    Function newSkills(ByVal diff)
        Dim difficulties(4) As Int16 ' total amount of skill points per character
        difficulties = {75, 50, 25, 0}

        Dim tmpSkill As Int16 'newly calulated Skill
        Dim total As Int16 'max skillpoints
        Dim i As Int16 'counter for array index
        Dim skillArray(5) As Int16
        skillArray = {0, 0, 0, 0, 0}
        total = difficulties(diff)

        While total > 0
            i = 0
            For Each elem In skillArray
                If total > 20 Then
                    Console.WriteLine("calculating skil 0-20")
                    tmpSkill = CInt(Math.Ceiling(Rnd() * (20))) 'random num 0 -> 20 (inclusive)
                Else
                    Console.WriteLine("calulating skil 0-total")
                    tmpSkill = CInt(Math.Ceiling(Rnd() * total))
                End If
                If Not elem > (20 - tmpSkill) Then 'treat edge case where skill might become >20
                    Console.WriteLine("Elem: " & elem)
                    Console.WriteLine("Temp: " & tmpSkill)
                    skillArray(i) += tmpSkill
                    total -= tmpSkill
                    Console.WriteLine(String.Join(", ", skillArray))
                End If
                i += 1
            Next
        End While
        Shuffle(skillArray) 'shuffling is mandatory because otherwise last numbers in Array are alwas smaller
        newSkills = skillArray
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
        TabControl.SelectedIndex = 3
        Call updateFields()
    End Sub

End Class