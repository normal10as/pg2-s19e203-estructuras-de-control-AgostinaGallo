Imports System
'Crear un proyecto y un m�dulo �Angulo� para resolver con Case: ingresar el tama�o de un
'�ngulo en grados e imprimir el mensaje correspondiente seg�n la siguiente tabla
'Agudo| si es menor a 90�
'Recto| si es igual a 90�
'Obtuso| si es mayor que 90� pero menor que 180�
'Llano| si es igual a 180�
'C�ncavo| si es mayor que 180� pero menor que 360�
'Error| Si el valor es menor a 0� o mayor de 360�
Module Angulo
    Sub Main()
        Dim anguloIngresado As UShort
        Console.Write("Ingresa el tama�o del angulo en grados __� : ")
        anguloIngresado = Console.Read()

        Select Case anguloIngresado
            Case Is < 90
                Console.WriteLine("El �ngulo {0}� es = Agudo", anguloIngresado)
            Case 90
                Console.WriteLine("El �ngulo {0}� es = Recto", anguloIngresado)
            Case 91 To 179
                Console.WriteLine("El �ngulo {0}� es = Obtuso", anguloIngresado)
            Case 180
                Console.WriteLine("El �ngulo {0}� es = Llano", anguloIngresado)
            Case 181 To 359
                Console.WriteLine("El �ngulo {0}� es = C�ncavo", anguloIngresado)
            Case Else
                Console.WriteLine("Error!")

        End Select

        Console.Read()
    End Sub
End Module
