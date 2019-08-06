Imports System
Module Venta
    'Realice el ejercicio de esta forma para probar anidar funciones con subs
    Sub Main()
        Dim cantiProdu As UShort, precioProdu As Double

        Console.WriteLine("Ingrese cantidad del producto: ")
        cantiProdu = Console.ReadLine()
        Console.WriteLine("Ingrese precio del producto: ")
        precioProdu = Console.ReadLine()

        If cantiProdu >= 10 And cantiProdu <= 50 Then
            imprimirInformes(cantiProdu, precioProdu, 5)

        ElseIf cantiProdu >= 51 And cantiProdu <= 250 Then
            imprimirInformes(cantiProdu, precioProdu, 10)

        ElseIf cantiProdu >= 251 Then
            imprimirInformes(cantiProdu, precioProdu, 20)
        Else
            Escribir("* La cantidad no entra en los rangos de descuentos.")
        End If
        Console.Read()
    End Sub

    Private Sub Escribir(cadena As String)
        Console.WriteLine(cadena)
    End Sub
    Private Sub imprimirInformes(cantP As UShort, precioU As Double, porcentaj As SByte)
        Escribir("Subtotal a pagar= $" & Subtotal(cantP, precioU))
        Escribir("Descuento correspondido: " & porcentaj & "%")
        Escribir("Monto descontado= $" & MontoDescontado(Subtotal(cantP, precioU), porcentaj))
        Escribir("Total a pagar= $" & TotalPrecio(Subtotal(cantP, precioU), MontoDescontado(Subtotal(cantP, precioU), porcentaj)))
    End Sub

    Private Function Subtotal(cantP As UShort, precioU As Double)
        Return cantP * precioU
    End Function
    Private Function MontoDescontado(subtot As Double, Porcentaje As SByte)
        Return (subtot * Porcentaje) / 100
    End Function
    Private Function TotalPrecio(subtotal As Double, montodescontado As Double)
        Return subtotal - montodescontado
    End Function

End Module
