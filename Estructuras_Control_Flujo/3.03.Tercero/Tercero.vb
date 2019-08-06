Imports System

Module Tercero
    Sub Main()
        Dim val1, val2, val3, val4, val5 As Integer

        Console.WriteLine("Ingrese 5 valores enteros: ")
            val1 = Console.ReadLine()
            val2 = Console.ReadLine()
            val3 = Console.ReadLine()
            val4 = Console.ReadLine()
            val5 = Console.ReadLine()

            If val1 > val2 And val1 > val3 And val1 > val4 And val1 > val5 Then
                Console.WriteLine("El Primer valor es el mayor valor: {0}", val1)

            ElseIf val2 > val3 And val2 > val4 And val2 > val5 Then
                Console.WriteLine("El Segundo valor es el mayor valor: {0}", val2)

            ElseIf val3 > val4 And val3 > val5 Then
                Console.WriteLine("El Tercer valor es el mayor valor: {0}", val3)

            ElseIf val4 > val5 Then
                Console.WriteLine("El Cuarto valor es el mayor valor: {0}", val4)

            Else
                Console.WriteLine("El Quinto valor es el mayor valor: {0}", val5)
            End If


        Console.Read()
    End Sub
End Module
