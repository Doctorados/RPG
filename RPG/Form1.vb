﻿Public Class Form1
    Dim conn As ADODB.Connection
    Dim foodDist(3) As Boolean 'array determines who gets rations
    Dim dayCountVal As Int16
    Dim rationCountVal As Int16
    Private Sub Class_Initialize()
        dayCountVal = 1
        foodDist = {False, False, False}
    End Sub
    Private Sub updateFields() 'update the main menu fields
        Dim rs As New ADODB.Recordset
        Try
            rs.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
            'update Character Values
            If rs.RecordCount > 0 Then
                rs.MoveFirst()
                Dim i = 0
                Dim skillNames = New String() {"strength", "intelligence", "agility", "social", "perception"}
                Do While Not rs.EOF
                    Me.Controls("name" & i).Text = (CStr(rs.Fields("fullName").Value))
                    Me.Controls("healthBar" & i).Text = (getBar(rs.Fields("health").Value, "DEAD"))
                    Me.Controls("hungerBar" & i).Text = (getBar(rs.Fields("hunger").Value, "STARVING"))
                    For Each elem As String In skillNames
                        Me.Controls(elem & i).Text = (skillWords(rs.Fields(elem).Value))
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
            dayCounter.Text = "Day " & CStr(dayCountVal)
            foodCounter.Text = "Rations: " & CStr(rationCountVal)
            rs.Close()
            hungerBar0.ForeColor = Color.White
            hungerBar1.ForeColor = Color.White
            hungerBar2.ForeColor = Color.White
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call calcDay()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New ADODB.Connection
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")

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
                    DirectCast(Me.Controls("task" & k), ComboBox).Items.Add(CStr(rs.Fields("taskName").Value))
                Next
                rs.MoveNext()
            Loop
            rs.Close()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
        foodDist = {False, False, False}
        Call updateFields()
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
        "incapable",
        "horrible",
        "awful",
        "very bad",
        "bad",
        "poor",
        "lacking",
        "basic",
        "mediocre",
        "average",
        "good",
        "very good",
        "slightly impressive",
        "impressive",
        "excellent",
        "incredible",
        "exceptional",
        "epic",
        "legendary",
        "godlike"}
        skillWords = words(value)
    End Function

    Private Sub calcDay()
        Dim rs As New ADODB.Recordset
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
        rs.Open("SELECT hunger, health FROM [Character]", conn,
                   ADODB.CursorTypeEnum.adOpenStatic,
                   ADODB.LockTypeEnum.adLockPessimistic
           )
        rs.MoveFirst()
        Do While Not rs.EOF
            If rs.Fields("hunger").Value = 0 Then
                rs.Fields("health").Value -= 30
            End If
            If rs.Fields("health").Value < 0 Then
                rs.Fields("health").Value = 0
            End If
            If rs.Fields("health").Value > 100 Then
                rs.Fields("health").Value = 100
            End If
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
    Private Sub hungerBar2_click(sender As Object, e As EventArgs) Handles hungerBar2.Click
        Call hungerBar_click_helper(2, sender)
    End Sub

    Private Sub hungerBar_click_helper(ByVal i, ByRef sender)
        If sumArray(foodDist) <= rationCountVal And Not foodDist(i) Then
            foodDist(i) = Not foodDist(i)
            If foodDist(i) Then
                sender.ForeColor = Color.Lime
            Else
                sender.ForeColor = Color.White
            End If
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
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        rs.MoveLast()
        calcRations = (rs.Fields("rations").Value - num)
        rs.Close()
    End Function

    Function sumArray(ByVal arr)
        Dim num As Int16
        For Each elem In arr
            If elem Then
                num += 1
            End If
        Next
        MsgBox(num)
        sumArray = num
    End Function
End Class