Imports System
'Crear un proyecto y un módulo “Descuento” para ingresar repetitivamente dos
'valores relacionados a un producto en venta: cantidad y precio unitario. Si la cantidad es
'entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el descuento es
'del 10% y si es 251 o más el descuento es del 20%. Informar por cada producto subtotal
'(cantidad por precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal – monto descontado). 
'Al finalizar el ingreso, por cantidad igual a cero, informar el total de pesos descontados y el total a cobrar.
Module Descuento
    Sub Main()
        Dim cantidad, aDescontar, subTotal, total, totDescontados, totTotales As UInteger
        Dim precioUni As Double
        Dim porcDescuento As Byte
        Console.Write("Ingrese cantidad del producto: " & vbCrLf & ">> ")
        cantidad = Console.ReadLine()
        Do Until cantidad = 0
            Console.Write("Precio unitario: " & vbCrLf & ">> ")
            precioUni = Console.ReadLine()
            subTotal = cantidad * precioUni
            Console.WriteLine("SUBTOTAL= ${0}", subTotal)
            Select Case cantidad
                Case 10 To 50
                    porcDescuento = 5
                Case 51 To 250
                    porcDescuento = 10
                Case Is >= 251
                    porcDescuento = 20
                Case Else
                    Console.WriteLine("--La cantidad no aplica a ningun descuento")
            End Select
            aDescontar = subTotal * porcDescuento / 100
            totDescontados += aDescontar
            total = subTotal - aDescontar
            totTotales += total
            Console.WriteLine("DESCUENTO= {0}%", porcDescuento)
            Console.WriteLine("A DESCONTAR= ${0}", aDescontar)
            Console.WriteLine("TOTAL= ${0}", total)
            Console.Write(vbCrLf & "Cantidad: (0= FIN)" & vbCrLf & ">> ")
            cantidad = Console.ReadLine()
        Loop
        Console.WriteLine("Total de pesos descontados: ${0}", totDescontados)
        Console.WriteLine("Total a cobrar: ${0}", totTotales)

    End Sub
End Module
