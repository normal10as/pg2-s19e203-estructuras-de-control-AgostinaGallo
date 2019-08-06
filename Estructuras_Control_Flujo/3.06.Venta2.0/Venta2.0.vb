Imports System
'Crear un proyecto y un módulo “Venta2.0”, para resolver el problema “Venta” (3.4) con Case.
'    Crear un proyecto y un módulo “Venta” para resolver con If: ingresar dos valores
'    relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es entre a 10 y
'    50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es del 10% y si
'    es 251 o más el descuento es del 20%. 
'    Informar subtotal(cantidad por precio unitario), porcentaje de descuento aplicado,
'    monto descontado y el total (subtotal – monto descontado).
Module Program
    Sub Main()
        Dim cantiProdu, descuento As UShort
        Dim precioUni As Double
        Console.WriteLine("Ingrese cantidad del producto: ")
        cantiProdu = Console.ReadLine()
        Console.WriteLine("Ingrese precio unitario: ")
        precioUni = Console.ReadLine()

        Select Case cantiProdu
            Case 10 To 50
                descuento = 5
            Case 51 To 250
                descuento = 10
            Case Is >= 251
                descuento = 20
            Case Else
                Console.WriteLine("** La cantidad no corresponde a ningun descuento")
        End Select
        Console.WriteLine("SUBTOTAL: ${0}", cantiProdu * precioUni)
        Console.WriteLine("EL DESCUENTO ES DEL: {0}%", descuento)
        Console.WriteLine("MONTO A DESCONTAR: ${0}", (cantiProdu * precioUni) * descuento / 100)
        Console.WriteLine("TOTAL A PAGAR: ${0}", (cantiProdu * precioUni) - (cantiProdu * precioUni * descuento / 100))
    End Sub
End Module
