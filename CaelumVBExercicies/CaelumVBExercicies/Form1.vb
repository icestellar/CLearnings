Public Class Form1
    Private Sub BtnBaskaraClic(sender As Object, e As EventArgs) Handles Button1.Click
        Dim baskara As New Baskara
        baskara.a = 1
        baskara.b = 3
        baskara.c = 1
        MessageBox.Show(baskara.returningAs())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
