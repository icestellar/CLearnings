
Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer
        x = Console.ReadLine()
        Dim stack = New Stack1
        stack.Push(x)
        stack.Push(x + 1)
        stack.PrintStack()
        stack.Pop()
        'Console.WriteLine("__________")
        'stack.PrintStack()

    End Sub
End Module
