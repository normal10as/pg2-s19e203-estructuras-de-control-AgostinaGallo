Imports System.Math
'   Crear un proyecto y un módulo “MultiplosCinco” para resolver con For y Do Loop:
'   con ingresar dos valores numéricos enteros cualquiera, el primero menor al segundo,
'   calcular cuántos números múltiplos de cinco hay entre ellos e informar. 
'    Repetir esta solución en el mismo módulo con las diferentes alternativas las estructuras de repetición 
'    “do while … loop” | “do until … loop” | “do … loop while” | “do … loop until y | “for”
Module MultiplosCinco
    Sub Main()
        Dim val1, val2 As Integer
        Console.WriteLine("Ingresa un valor entero: ")
        val1 = Console.ReadLine()
        Console.WriteLine("Ahora ingresa un valor mayor: ")
        val2 = Console.ReadLine()
        Console.WriteLine("Los multiplos de 5 entre {0} y {1} son= ", val1, val2)
        Console.WriteLine(multiplo_DoWhileLoop(val1, val2) & " --DO WHILE... LOOP")
        Console.WriteLine(multiplo_DoUntilLoop(val1, val2) & " --DO UNTIL... LOOP")
        Console.WriteLine(multiplo_DoLoopWhile(val1, val2) & " --DO ... LOOP WHILE")
        Console.WriteLine(multiplo_DoLoopUntil(val1, val2) & " --DO ... LOOP UNTIL")
        Console.WriteLine(multiplo_For(val1, val2) & " --FOR")
    End Sub
    Private Function multiplo_DoWhileLoop(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim contmultip As UShort = 0
        Do While val1 <= val2
            If val1 Mod 5 = 0 Then
                contmultip += 1
            End If
            val1 += 1
        Loop
        Return contmultip
    End Function

    Private Function multiplo_DoUntilLoop(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim contmultip As UShort = 0
        Do Until val1 > val2
            If val1 Mod 5 = 0 Then
                contmultip += 1
            End If
            val1 += 1
        Loop
        Return contmultip
    End Function

    Private Function multiplo_DoLoopWhile(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim contmultip As UShort = 0
        Do
            If val1 Mod 5 = 0 Then
                contmultip += 1
            End If
            val1 += 1
        Loop While val1 <= val2
        Return contmultip
    End Function

    Private Function multiplo_DoLoopUntil(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim contmultip As UShort = 0
        Do
            If val1 Mod 5 = 0 Then
                contmultip += 1
            End If
            val1 += 1
        Loop Until val1 > val2
        Return contmultip
    End Function

    Private Function multiplo_For(ByVal val1 As Integer, ByVal val2 As Integer) As Integer
        Dim contmultip As UShort = 0
        For val1 = val1 To val2 Step 1
            If val1 Mod 5 = 0 Then
                contmultip += 1
            End If
        Next
        Return contmultip
    End Function
End Module
