Public Class Form1
    Dim rs As ADODB.Recordset
    Dim conn As ADODB.Connection

    Private Sub fillCharFields()
        rs = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")
            rs.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
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
            conn.Close()
        Catch ex As Exception
            MsgBox("Exception: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "MainDataSet1.Character". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.CharacterTableAdapter.Fill(Me.MainDataSet1.Character)
        Call fillCharFields()
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
End Class
