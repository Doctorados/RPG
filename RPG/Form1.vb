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
            For i = 0 To 2
            DirectCast(Me.Controls("task" & i), ComboBox).SelectedIndex = -1
            DirectCast(Me.Controls("hungerBar" & i), TextBox).ForeColor = Color.White
        Next
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
                Call killChar(i)
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
        sumArray = num
    End Function

    Sub killChar(ByVal index)
        index = CStr(index)
        For Each elem In Controls
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

        rs_char.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenDynamic,
                    ADODB.LockTypeEnum.adLockOptimistic
            )
        rs_tasks.Open("SELECT * FROM [Task]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        For i = 0 To 2
            taskInd = DirectCast(Me.Controls("task" & i), ComboBox).SelectedIndex 'get index of assigned task
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
            MsgBox(rs_strings.Fields("string").Value)
            rs_strings.Close()
        Next
        rs_tasks.Close()
        rs_char.Close()
    End Sub

    Function getOutcome(ByRef skill)
        Randomize()
        'gets outcome determined by binomial dist higher skill = higher p
        Dim p As Single
        Dim out As Int16
        out = 0
        p = ((0.045 * skill) + 0.05)
        For i = 0 To 5
            If p > Rnd() Then
                out += 1
            End If
        Next
        getOutcome = out
    End Function

    Sub moveAbsolute(ByRef rs, ByVal pos) 'this function only exists because Recordset.moveabsolute is very unreliable
        rs.MoveFirst()
        If pos > 0 Then
            For i = 0 To pos
                If Not rs.EOF Then
                    rs.MoveNext()
                End If
            Next
        End If
    End Sub
    Function randomRecord(ByRef rs, ByVal fieldName) 'this doesnt work, i dont know why
        Dim numOfRecords As Long
        Dim recordPos As Int16
        Randomize()
        numOfRecords = rs.RecordCount
        recordPos = Int(numOfRecords * Rnd()) 'calculate a random pos in rs
        If recordPos = numOfRecords And recordPos > 0 Then 'treat out of range edge case
            recordPos -= 1
        End If
        rs.AbsolutePosition = recordPos
        randomRecord = rs.Fields(fieldName).Value
    End Function
    Sub assign() 'tbh I don't know anymore why the assignement table exists
        Dim rs_assignment As New ADODB.Recordset
        Dim rs_tasks As New ADODB.Recordset
        Dim rs_char As New ADODB.Recordset
        Dim rs_day As New ADODB.Recordset
        Dim taskInd As Int16

        rs_assignment.Open("SELECT * FROM [Assignment]", conn,
                    ADODB.CursorTypeEnum.adOpenDynamic,
                    ADODB.LockTypeEnum.adLockOptimistic
            )
        rs_char.Open("SELECT ID FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        rs_day.Open("SELECT ID FROM [Day]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        rs_day.MoveLast()
        rs_char.MoveFirst()


        For i = 0 To 2
            taskInd = DirectCast(Me.Controls("task" & i), ComboBox).SelectedIndex
            rs_assignment.AddNew()
            rs_assignment.Fields("dayID").Value = rs_day.Fields("ID").Value
            rs_assignment.Fields("characterID").Value = rs_char.Fields("ID").Value
            rs_assignment.Fields("taskID").Value = taskInd + 1 'this only works when Combobox values are obtained from db
            rs_assignment.Update()
            rs_char.MoveNext()
        Next
        rs_assignment.Close()
        rs_day.Close()
        rs_char.Close()
    End Sub

End Class