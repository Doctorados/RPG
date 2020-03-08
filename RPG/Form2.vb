Public Class Form2
    Dim displayStrings(3) As String
    Public Sub New(ByVal resultStrings)
        InitializeComponent()
        displayStrings = resultStrings

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 2
            DirectCast(Me.Controls("TextBox" & i), TextBox).Text = "..."
        Next
        Call write()
    End Sub

    Private Sub write()
        For i = 0 To 2
            DirectCast(Me.Controls("TextBox" & i), TextBox).Text = displayStrings(i)
            Threading.Thread.Sleep(1000)
        Next
    End Sub
End Class