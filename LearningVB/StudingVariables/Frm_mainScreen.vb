Public Class Frm_mainScreen
    Dim totalMessage As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label1.TextAlignChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label1.Text = ToSumAscii(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        totalMessage += TextBox1.Text + vbCrLf
        TextBox2.Text = totalMessage
        TextBox1.Text = ""
    End Sub

    Public Function InvertText(myText As String) As String
        Dim arr() As Char
        arr = myText.ToCharArray()
        Array.Reverse(arr)
        Return arr
    End Function

    Public Function OneBig(myArr As String) As String
        Dim arrOk() As Char = myArr.ToCharArray()
        Dim arr(myArr.ToCharArray().Length) As Char

        For i As Integer = 0 To arrOk.Length - 1 Step 1
            If i Mod 2 = 0 Then
                arr(i) = arrOk(i).ToString().ToUpper()
            Else
                arr(i) = arrOk(i).ToString.ToLower()
            End If
        Next i
        Return New String(arr)
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Public Function ToSumAscii(myarr As String) As Integer
        Dim mArry() As Char = myarr.ToCharArray()
        Dim sum As Integer = 0
        For i As Integer = 0 To mArry.Length - 1 Step 1
            sum += Asc(mArry(i))
        Next i
        Return sum
    End Function


End Class
