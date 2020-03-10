Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Difficulty.Hide()
        Start.Hide()
        Back.Hide()
        Difficulty.SelectedIndex = 0
    End Sub
    Private Sub loadGame_Click(sender As Object, e As EventArgs) Handles loadGame.Click
        Dim mainWindow As New main
        main.Show()
        Me.Hide()
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
    End Sub

    Private Sub createNewGame()
        Dim conn As New ADODB.Connection
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")

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
    End Sub

    Function newSkills(ByVal diff)
        Dim difficulties(4) As Int16 ' total amount of skill points per character
        difficulties = {75, 50, 25, 0}

        Dim tmpSkill As Int16 'newly calulated Skill
        Dim total As Int16
        Dim skillArray(5) As Int16
        Dim i As Int16
        skillArray = {0, 0, 0, 0, 0}
        total = difficulties(diff)
        i = 0

        While total > 0
            If i > (skillArray.Length - 1) Then
                i = 0
            End If
            If total > 20 Then
                tmpSkill = CInt(Math.Ceiling(Rnd() * (20))) 'random num 0 -> 20 (inclusive)
            Else
                tmpSkill = CInt(Math.Ceiling(Rnd() * total))
            End If
            If Not skillArray(i) > (20 - tmpSkill) Then
                skillArray(i) += tmpSkill
                total -= tmpSkill
            End If
            i += 1
            Console.WriteLine(String.Join(", ", skillArray))
            Console.WriteLine("Total: " & total)
        End While

        newSkills = skillArray
    End Function

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        'Dim skills(5) As Int16
        Call createNewGame()
        'skills = newSkills(Difficulty.SelectedIndex)
    End Sub
End Class