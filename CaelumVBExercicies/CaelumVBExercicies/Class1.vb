Public Class Baskara
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public Function CalculatingDelta() As Double
        Dim delta As Double
        delta = (b * b) - (4 * a * c)
        If delta >= 0 Then
            Return delta
        Else
            Return -1
        End If
    End Function

    Public Function CalculatingA1() As Double
        Return (-b + Math.Sqrt(CalculatingDelta())) / (2 * a)
    End Function

    Public Function CalculatingA2() As Double
        Return (-b - Math.Sqrt(CalculatingDelta())) / (2 * a)
    End Function

    Public Function returningAs() As String
        If CalculatingDelta() <> -1 Then
            Return "A1: " & CalculatingA1() & "A2: " & CalculatingA2()
        Else
            Return "Impossible to calculate delta"
        End If
    End Function

End Class
