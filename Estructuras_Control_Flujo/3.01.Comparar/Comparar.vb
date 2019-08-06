Imports System

Module Comparar
    Sub Main()
        Dim val1, val2 As Double
        Console.WriteLine("Ingrese primer valor: ")
        val1 = Console.ReadLine()
        Console.WriteLine("Ingrese segundo valor: ")
        val2 = Console.ReadLine()

        If val1 > val2 Then
            Console.WriteLine("El mayor es: {0}", val1, "El menor es: {1}", val2)

        ElseIf val1 = val2 Then
            Console.WriteLine("Los valores son iguales")
        Else
            Console.WriteLine("El mayor es: {0}", val2, "El menor es: {1}", val1)
        End If
    End Sub
End Module
