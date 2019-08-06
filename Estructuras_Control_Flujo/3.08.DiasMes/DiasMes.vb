Imports System.Math
'Crear un proyecto y un módulo “DiasMes” para resolver con Case: Elabore un programa
'que indique cuantos días tiene un mes respetando los siguientes requerimientos:
'• En el flujo normal se ingresa el número de mes a evaluar y mediante una enumeración
'   se informa la cantidad de días que tiene el mes.
'• En el caso de ser febrero, además ingresar el año y tener en cuenta que tiene 28 días y si
'   es un año bisiesto tiene 29 días. Un año bisiesto es aquél que es múltiplo de 4 y no de 100
'   o cuando es múltiplo de 400. Por ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.
Module DiasMes
    Enum diasPorMes
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
        Dim numIngresado As Byte
        Dim anio As UShort
        Console.WriteLine("Ingresa numero de mes (1-12): ")
        numIngresado = Console.ReadLine()

        Select Case numIngresado
            Case 1
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Enero)
            Case 2
                Console.WriteLine("Ingresa el año: ")
                anio = Console.ReadLine()
                If anio Mod 4 = 0 And (anio Mod 400 = 0 Or anio Mod 100 <> 0) Then
                    Console.WriteLine("En el año Bisiesto {0} el mes de {1} tiene 29 dias", anio, diasPorMes.Febrero)
                Else
                    Console.WriteLine("En el año {0} el mes de {1} tiene 28 dias", anio, diasPorMes.Febrero)
                End If
            Case 3
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Marzo)
            Case 4
                Console.WriteLine("El mes de {0} tiene 30 dias", diasPorMes.Abril)
            Case 5
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Mayo)
            Case 6
                Console.WriteLine("El mes de {0} tiene 30 dias", diasPorMes.Junio)
            Case 7
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Julio)
            Case 8
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Agosto)
            Case 9
                Console.WriteLine("El mes de {0} tiene 30 dias", diasPorMes.Septiembre)
            Case 10
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Octubre)
            Case 11
                Console.WriteLine("El mes de {0} tiene 30 dias", diasPorMes.Noviembre)
            Case 12
                Console.WriteLine("El mes de {0} tiene 31 dias", diasPorMes.Diciembre)
            Case Else
                Console.WriteLine("Error de ingreso.")
        End Select
    End Sub
End Module
