Imports System
'Crear un proyecto y un m�dulo �NombreMes� para resolver con Case. Crear una
'enumeraci�n para los meses del a�o. Ingresar un valor num�rico y mostrar a que mes
'corresponde.Si el valor es inv�lido mostrar el mensaje correspondiente.
Module NombreMes
    Enum mesesDelA�o As Byte
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
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Enero)
            Case 2
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Febrero)
            Case 3
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Marzo)
            Case 4
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Abril)
            Case 5
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Mayo)
            Case 6
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Junio)
            Case 7
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Julio)
            Case 8
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Agosto)
            Case 9
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Septiembre)
            Case 10
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Octubre)
            Case 11
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Noviembre)
            Case 12
                Console.WriteLine("El numero corresponde al mes de: {0}", mesesDelA�o.Diciembre)
            Case Else
                Console.WriteLine(" *El valor ingresado es erroneo.")
        End Select
    End Sub

End Module
