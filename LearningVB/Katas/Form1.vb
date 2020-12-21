Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(EncriptyEach(TextBox1.Text))
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Function EncriptyEach(ByVal phrase As String) As String
        Dim words() As String
        words = Split(phrase, " ")
        Dim acumulate As String = ""
        For Each word As String In words
            'Dim aux() As Char = word.ToCharArray()
            Dim scndLetter As Char = word(1)
            Dim lastLetter As Char = word(word.Length - 1)
            Dim newWord As String = word.Replace(word(0), Asc(word(0)))
            newWord = word.Replace(word(1), lastLetter)
            newWord = word.Replace(word(word.Length - 1), scndLetter)
            acumulate += newWord
        Next
        Return acumulate
    End Function


End Class
