Imports System
'Crear un proyecto y un módulo “ParesImpares” Utilizando la estructura de repetición
'más adecuada elaborar un programa que se ingresen valores enteros hasta que se ingrese
'cero(descartar negativos). Luego informar cuantos son pares y cuantos impares. 
'Si todos son pares o todos son impares informar esta situación particular en lugar de la consigna anterior.
Module ParesImpares
    Sub Main()
        Dim ingreso As Integer
        Dim pares, impares As UShort
        Console.Write("Ingresa valores enteros (0= FIN): " & vbCrLf & ">> ")
        ingreso = Console.ReadLine()
        Do Until ingreso = 0
            If ingreso < 0 Then
                Console.WriteLine("descartado")
            ElseIf ingreso Mod 2 = 0 Then
                pares += 1
            Else
                impares += 1
            End If
            Console.Write(">> ")
            ingreso = Console.ReadLine()
        Loop

        If impares > 0 And pares = 0 Then
            Console.WriteLine("TODOS LOS NUMEROS SON IMPARES")
        ElseIf pares > 0 And impares = 0 Then
            Console.WriteLine("TODOS LOS NUMEROS SON PARES")
        Else
            Console.WriteLine("Total de PARES= {0} IMPARES= {1}", pares, impares)
        End If


    End Sub
End Module
