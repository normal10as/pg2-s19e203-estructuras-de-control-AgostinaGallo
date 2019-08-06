Imports System
'Crear un proyecto y un m�dulo �Fibonacci� para elaborar �Los n�meros de Fibonacci�
'estos constituyen una secuencia que empieza con 0 y 1; el n�mero que sigue a
'�stos se calcula sumando los dos anteriores y as� sucesivamente. Utilizando la estructura de
'repetici�n m�s adecuada elaborar un algoritmo que imprima los 20 primeros n�meros de la secuencia.

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
