Imports Microsoft.VisualBasic
Dim rs As ADODB.Recordset
Dim conn As ADODB.Connection
Dim nameFields() As TextBox
Private Sub fillCharFields()
    rs = New ADODB.Recordset
    Try
        conn = New ADODB.Connection
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\Damion\Google Drive\Studium\4. Semester\Informatik\main.accdb")
        rs.Open("SELECT * FROM [Character]", conn,
                    ADODB.CursorTypeEnum.adOpenStatic,
                    ADODB.LockTypeEnum.adLockPessimistic
            )
        MsgBox("Datensätze gefunden:" & rs.RecordCount)
        If rs.RecordCount > 0 Then
            rs.MoveFirst()
            Do While Not rs.EOF
                MsgBox(CStr(rs.Fields("fullName").Value))
                rs.MoveNext()
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

