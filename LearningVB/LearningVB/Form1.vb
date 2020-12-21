Public Class Form1
    Dim message As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Function invertString(S As String) As String
        Dim arr() As Char = S.ToCharArray
        Array.Reverse(arr)
        Return New String(arr)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        message = TextBox1.Text

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(invertString(message), MsgBoxStyle.Critical, "Message")
    End Sub


End Class
