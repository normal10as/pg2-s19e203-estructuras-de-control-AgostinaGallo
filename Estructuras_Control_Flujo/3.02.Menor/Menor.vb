Imports System

Module Menor
    Sub Main()
        Dim val1, val2, val3, menor As Double
        Console.WriteLine("INGRESE 3 VALORES: ")
        val1 = Console.ReadLine()
        val2 = Console.ReadLine()
        val3 = Console.ReadLine()

        If val1 < val2 And val3 Then
            menor = val1
        ElseIf val2 < val3 Then
            menor = val2
        ElseIf val1 = val2 And val1 = val3 Then
            Console.WriteLine("Los valores son iguales.")
        Else
            menor = val3
        End If
        Console.WriteLine("EL MENOR ES = {0}", menor)
    End Sub
End Module
