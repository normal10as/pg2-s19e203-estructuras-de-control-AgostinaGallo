Imports System

Module Deposito
    Sub Main()
        Const tasaIntAnual As Byte = 36
        Dim capital, saldo, montoInteres, totIntereses As Double
        Dim plazoMes As UShort
        Console.WriteLine("Ingrese el monto del capital: $")
        capital = Console.ReadLine()
        Console.WriteLine("Ingrese el plazo de meses: ")
        plazoMes = Console.ReadLine()

        Console.WriteLine("MES" & vbTab & "CAPITAL" & vbTab & "INTERES" & vbTab & "SALDO")
        Console.WriteLine("-----------------------------")
        For i As UShort = 1 To plazoMes Step 1
            montoInteres = capital * (tasaIntAnual / 12)
            saldo = capital + montoInteres
            Console.WriteLine(i & vbTab & capital & vbTab & montoInteres & vbTab & saldo)
            capital += montoInteres
            totIntereses += montoInteres

        Next
        Console.WriteLine("-----------------------------")
        Console.WriteLine("TOTAL INTERES GANADO: ${0}", totIntereses)

    End Sub
End Module
