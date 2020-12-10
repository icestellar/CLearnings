Imports System

Module Program
    Sub Main(args As String())
        Dim Ufestado As String = "51"
        Dim AnoEMes As String = "1120"
        Dim CNPJ As String = "04235334001096"
        Dim model As String = "55"
        Dim serie As String = "890"
        Dim numero As String = "000000098"
        Dim tipodeEmissao As String = "2"
        Dim codigoDaNFe As String = "36411778"
        Dim numeroDaNf = Ufestado + AnoEMes + CNPJ + model + serie + numero + tipodeEmissao + codigoDaNFe
        Dim CV As Integer

        Console.WriteLine(CalculaDV(numeroDaNf))
        'Console.WriteLine("512011042353340010965589000001335211527700598".Length)

    End Sub
    Public Function CalculaDV(chave As String)
        Dim indice, multiplicador As Integer
        Dim soma, resto, digito_v As Integer
        soma = 0
        multiplicador = 2
        For indice = Len(chave) To 1 Step -1
            soma = soma + (Mid(chave, indice, 1) * multiplicador)
            multiplicador = multiplicador + 1
            If (multiplicador > 9) Then multiplicador = 2
        Next indice
        resto = soma Mod 11
        digito_v = 11 - resto
        If (digito_v >= 10) Then digito_v = 0
        CalculaDV = digito_v

    End Function
End Module
