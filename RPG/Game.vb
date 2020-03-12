Public Class Game
    Dim conn As New ADODB.Connection
    Dim foodDist(3) As Boolean 'array determines who gets rations
    Dim dayCountVal As Int16
    Dim rationCountVal As Int16
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
            rs.MoveFirst()
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
        Dim TEST As String
        rs.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        'update Character Values
        If rs.RecordCount > 0 Then
            rs.MoveFirst()
            Dim i = 0 'counter val to cycle through character specific textboxes
            Dim k As Int16 'counter val to cycle through skills in db
            Dim skillNames = New String() {"Stärke", "Intelligenz", "Geschicklichkeit", "Mental", "Wahrnehmung"}
            Do While Not rs.EOF
                'TabControl.TabPages(3).Controls("name" & i).Text = (CStr(rs.Fields("fullName").Value))
                TabControl.TabPages(3).Controls("healthBar" & i).Text = (getBar(rs.Fields("health").Value, "DEAD"))
                If rs.Fields("health").Value = 0 Then
                    killChar(i)
                End If
                TabControl.TabPages(3).Controls("hungerBar" & i).Text = (getBar(rs.Fields("hunger").Value, "STARVING"))
                For x = 0 To 2
                    k = 4
                    DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Clear()
                    For Each elem In skillNames
                        DirectCast(TabControl.TabPages(3).Controls("charSkills" & i), ListBox).Items.Add(elem & ": " & skillWords(rs.Fields(k).Value))
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
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        rs.MoveLast()
        dayCountVal = rs.Fields("counter").Value
        rationCountVal = rs.Fields("rations").Value
        'dayCounter.Text = "Tag " & CStr(dayCountVal)
        'foodCounter.Text = "Rationen: " & CStr(rationCountVal)
        rs.Close()
        For i = 0 To 2
            DirectCast(TabControl.TabPages(3).Controls("task" & i), ComboBox).SelectedIndex = 1
            DirectCast(TabControl.TabPages(3).Controls("hungerBar" & i), TextBox).ForeColor = Color.White
        Next
        rs.Open("SELECT SUM(health) FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        If rs.Fields(0).Value = 0 Then
            rs.Close()
            'Call endGame()
        Else
            rs.Close()
        End If
    End Sub
    Private Function getBar(ByRef value, ByRef zeroWord)
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
    Sub killChar(ByVal index)
        index = CStr(index)
        For Each elem In Controls
            If elem.Name(elem.Name.length - 1) = index Then
                elem.enabled = False
            End If
        Next
    End Sub
    Sub checkLoadBtn()
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Day]", conn, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic)
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
            rs_char.Fields(1).Value = "NONAME"
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
    Private Sub charPic0_Leave(sender As Object, e As EventArgs) Handles charPic0.MouseLeave
        charSkills0.Hide()
    End Sub
    Private Sub charPic1_Hover(sender As Object, e As EventArgs) Handles charPic1.MouseEnter
        charSkills1.Show()
    End Sub
    Private Sub charPic1_Leave(sender As Object, e As EventArgs) Handles charPic1.MouseLeave
        charSkills1.Hide()
    End Sub
    Private Sub charPic2_Hover(sender As Object, e As EventArgs) Handles charPic2.MouseEnter
        charSkills2.Show()
    End Sub
    Private Sub charPic2_Leave(sender As Object, e As EventArgs) Handles charPic2.MouseLeave
        charSkills2.Hide()
    End Sub

End Class