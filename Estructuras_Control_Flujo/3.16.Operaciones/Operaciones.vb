Imports System.Math

Module Operaciones
    Sub Main()
        Console.WriteLine("RESTA DE 1, 2, 3, 4 = {0}", Operar(1, 2, 3, 4, Operacion.Resta))
        Console.WriteLine("RESTA DE 5, 1, 9 = {0}", Operar(5, 1, 9, Operacion.Resta))
        Console.WriteLine("RESTA DE 9, 0 , 1= {0}", Operar(1, 0, 9, Operacion.Resta))

    End Sub

    Enum Operacion As Integer
        Suma
        Resta
        Multiplicacion
        Division
    End Enum

    Private Function Operar(v1 As Integer, v2 As Integer, v3 As Integer, v4 As Integer, op As Operacion) As Integer
        Dim lista As New List(Of Integer) From {v1, v2, v3, v4}
        If lista.Contains(0) Then
            lista.Remove(0)
        End If
        If lista.Count <= 1 Then
            Return 0
        End If
        Select Case op
            Case Operacion.Suma
                Return lista.Sum()

            Case Operacion.Resta
                Dim temp As Integer
                For Each num As Integer In lista
                    If temp = 0 Then
                        temp = num
                    Else
                        temp = temp - num
                    End If
                Next
                Return temp

            Case Operacion.Multiplicacion
                Return v1 * v2 * v3 * v4

            Case Operacion.Division
                Return v1 \ v2 \ v3 \ v4
        End Select
        Return 0
    End Function

    Private Function Operar(v1 As Integer, v2 As Integer, v3 As Integer, v4 As Integer) As Integer
        Return Operar(v1, v2, v3, v4, Operacion.Suma)
    End Function

    Private Function Operar(v1 As Integer, v2 As Integer, v3 As Integer, op As Operacion) As Integer
        Return Operar(v1, v2, v3, 0, op)
    End Function


    Private Function Operar(v1 As Integer, v2 As Integer, v3 As Integer) As Integer
        Return Operar(v1, v2, v3, 0, Operacion.Suma)
    End Function

    Private Function Operar(v1 As Integer, v2 As Integer, op As Operacion) As Integer
        Return Operar(v1, v2, 0, op)
    End Function

    Private Function Operar(v1 As Integer, v2 As Integer)
        Return Operar(v1, v2, Operacion.Suma)
    End Function

End Module
