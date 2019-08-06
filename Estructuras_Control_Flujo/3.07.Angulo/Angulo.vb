Imports System
'Crear un proyecto y un módulo “Angulo” para resolver con Case: ingresar el tamaño de un
'ángulo en grados e imprimir el mensaje correspondiente según la siguiente tabla
'Agudo| si es menor a 90°
'Recto| si es igual a 90°
'Obtuso| si es mayor que 90° pero menor que 180°
'Llano| si es igual a 180°
'Cóncavo| si es mayor que 180° pero menor que 360°
'Error| Si el valor es menor a 0º o mayor de 360º
Module Angulo
    Sub Main()
        Dim anguloIngresado As UShort
        Console.Write("Ingresa el tamaño del angulo en grados __° : ")
        anguloIngresado = Console.Read()

        Select Case anguloIngresado
            Case Is < 90
                Console.WriteLine("El ángulo {0}° es = Agudo", anguloIngresado)
            Case 90
                Console.WriteLine("El ángulo {0}° es = Recto", anguloIngresado)
            Case 91 To 179
                Console.WriteLine("El ángulo {0}° es = Obtuso", anguloIngresado)
            Case 180
                Console.WriteLine("El ángulo {0}° es = Llano", anguloIngresado)
            Case 181 To 359
                Console.WriteLine("El ángulo {0}° es = Cóncavo", anguloIngresado)
            Case Else
                Console.WriteLine("Error!")

        End Select

        Console.Read()
    End Sub
End Module
