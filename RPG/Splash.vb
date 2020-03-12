Public Class Splash
    Dim conn As New ADODB.Connection
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")

        Difficulty.Hide()
        Start.Hide()
        Back.Hide()
        Difficulty.SelectedIndex = 0
        Call checkLoadBtn()
    End Sub

    Sub checkLoadBtn()
        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM [Day]", conn, ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic)
        If rs.RecordCount = 0 Then 'disable load if no game in db
            loadGame.Enabled = False
        End If
        rs.Close()
    End Sub

    Sub startGame()
        Dim mainWindow As New main
        main.Show()
        Me.Hide()
    End Sub
    Private Sub loadGame_Click(sender As Object, e As EventArgs) Handles loadGame.Click
        Call startGame()
    End Sub

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click
        loadGame.Hide()
        newGame.Hide()

        Difficulty.Show()
        Start.Show()
        Back.Show()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Difficulty.Hide()
        Start.Hide()
        Back.Hide()
        loadGame.Show()
        newGame.Show()
        Call checkLoadBtn()
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
        Call startGame()
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

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Dim confirm As DialogResult
        confirm = MessageBox.Show("Durch starten eines neuen Spiels wird jeder vohandene Spielstand gelöscht. Neues Spiel?",
                                     "",
                                     MessageBoxButtons.YesNo)
        If (confirm = DialogResult.Yes) Then
            Call createNewGame()
        End If
        'skills = newSkills(Difficulty.SelectedIndex)
    End Sub
End Class