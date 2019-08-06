Imports System
'Crear un proyecto y un módulo “Fibonacci” para elaborar “Los números de Fibonacci”
'estos constituyen una secuencia que empieza con 0 y 1; el número que sigue a
'éstos se calcula sumando los dos anteriores y así sucesivamente. Utilizando la estructura de
'repetición más adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia.

Module Fibonacci
    Sub Main()
        Dim A As Byte = 0
        Dim B As Byte = 1
        Console.WriteLine("Metodo Fibonacci")
        Console.WriteLine()

        For C As Byte = 0 To 20 Step 1
            C = A + B
            A = B
            B = C
            Console.Write("{0}, ", C)
        Next
    End Sub
End Module
