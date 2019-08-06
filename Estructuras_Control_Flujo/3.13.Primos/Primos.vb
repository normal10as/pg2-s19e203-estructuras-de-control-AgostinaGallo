Imports System
'Crear un proyecto y un módulo “Primos” para obtener los números primos menores a mil.
'    En matemáticas, un número primo es un número natural mayor que 1 que tiene
'    únicamente dos divisores distintos: él mismo y el 1.
Module Primos
    Sub Main()
        Dim bandera As Integer
        Dim num As Integer
        For num = 2 To 1000
            bandera = 1

            For i = 2 To Math.Sqrt(num)
                If num Mod i = 0 Then
                    bandera = 0
                    Exit For
                End If
            Next

            If bandera = 1 Then
                Console.WriteLine(num)
            Else
                bandera = 1
            End If

        Next
    End Sub
End Module
