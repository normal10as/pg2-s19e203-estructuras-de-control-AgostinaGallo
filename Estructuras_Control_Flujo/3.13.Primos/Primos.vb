Imports System
'Crear un proyecto y un m�dulo �Primos� para obtener los n�meros primos menores a mil.
'    En matem�ticas, un n�mero primo es un n�mero natural mayor que 1 que tiene
'    �nicamente dos divisores distintos: �l mismo y el 1.
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
