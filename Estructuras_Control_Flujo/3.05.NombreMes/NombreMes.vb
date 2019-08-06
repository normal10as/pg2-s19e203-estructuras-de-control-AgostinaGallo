Imports System
'Crear un proyecto y un módulo “NombreMes” para resolver con Case. Crear una
'enumeración para los meses del año. Ingresar un valor numérico y mostrar a que mes
'corresponde.Si el valor es inválido mostrar el mensaje correspondiente.
Module NombreMes
    Enum mesesDelAño As Byte
        Enero = 1
        Febrero
        Marzo
        Abril
        Mayo
        Junio
        Julio
        Agosto
        Septiembre
        Octubre
        Noviembre
        Diciembre
    End Enum

    Sub Main()
        Dim valorIngresado As Byte
        Console.WriteLine("Ingrese un valor numerico: ")
        valorIngresado = Console.ReadLine()

        Select Case valorIngresado
            Case 1
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Enero)
            Case 2
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Febrero)
            Case 3
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Marzo)
            Case 4
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Abril)
            Case 5
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Mayo)
            Case 6
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Junio)
            Case 7
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Julio)
            Case 8
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Agosto)
            Case 9
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Septiembre)
            Case 10
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Octubre)
            Case 11
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Noviembre)
            Case 12
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelAño.Diciembre)
            Case Else
                Console.WriteLine(" *El valor ingresado es erroneo.")
        End Select
    End Sub

End Module
