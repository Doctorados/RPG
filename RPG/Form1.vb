Public Class Form1
    Dim rs As ADODB.Recordset
    Dim conn As ADODB.Connection

    Private Sub updateFields()

        Try
            'conn = New ADODB.Connection
            'conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")
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
                    Me.Controls("healthBar" & i).Text = (getBar(rs.Fields("health").Value))
                    Me.Controls("hungerBar" & i).Text = (getBar(rs.Fields("hunger").Value))
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
            dayCounter.Text = "Day " & CStr(rs.Fields("ID").Value)
            foodCounter.Text = "Rations: " & CStr(rs.Fields("rations").Value)
            rs.Close()

            conn.Close()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")
            rs = New ADODB.Recordset
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
        Call updateFields()
    End Sub

    Private Function getBar(ByRef value)
        Dim num As Int16
        Dim str As String
        str = "░"
        num = (value / 100) * 15
        getBar = Replace(Space(num), " ", str)
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
    End Sub

End Class
