Public Class Stack1
    Dim sData(3) As Integer
    Const MaxSize As Integer = 3
    Dim InitialTop As Integer = -1
    Function CheckStack() As Integer
        If InitialTop < 0 Then
            Return -1
        End If
        If InitialTop > MaxSize Then
            Return -2
        End If
        Return 0
    End Function
    Public Function Push(Value As Integer) As Boolean
        If CheckStack() <> -2 Then
            InitialTop = InitialTop + 1
            sData(InitialTop) = Value
            Return True
        Else
            Return False
        End If
        '<> is diferent hihih !=
    End Function

    Public Function Pop() As Integer
        If CheckStack() <> -2 Then
            Dim value As Integer = sData(InitialTop)
            InitialTop = InitialTop - 1
            Return sData(InitialTop)
        Else
            Return 0
        End If
    End Function
    Public Sub PrintStack()
        For position = 0 To InitialTop
            Console.WriteLine(sData(InitialTop - position))
        Next
    End Sub
End Class
