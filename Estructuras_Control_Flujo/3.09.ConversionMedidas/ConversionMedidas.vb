Imports System
'Crear un proyecto y un módulo “ConversionMedidas”, para resolver con Case: Elabore un
'algoritmo que permita hacer conversiones de equivalencias entre metros, centímetros,
'yardas, pies y pulgadas: 
'• Presentar un menú y preguntar que unidad de medida desea convertir (pie, pulgadas,
'yarda, pulgada, cms y metros), el valor a convertir y después mostrar las equivalencias.
'• Utilizar únicamente las equivalencias conocidas: 
' 1 metro= 100 cm,  1 pulgada= 2.54 cm,  1 pie= 12 pulgadas, 1 yarda= 3 pies .
'• Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.
Module ConversionMedidas
    Sub Main()
        Dim seleccion As Byte
        Dim valAConvertir As Double
        Console.WriteLine("Elegir que medida desea convertir:" & vbCrLf & "1- Metros" & vbCrLf & "2- Centimetros" & vbCrLf & "3- Yardas" & vbCrLf & "4- Pies" & vbCrLf & "5- Pulgadas")
        seleccion = Console.ReadLine()
        Console.WriteLine("Valor a convertir: ")
        valAConvertir = Console.ReadLine()
        Select Case seleccion
            Case 1 'Metros
                Console.WriteLine("Centimetros= {0}", valAConvertir * 100)
                Console.WriteLine("Yardas= {0}", valAConvertir * 100 / 2.54 / 12 / 3)
                Console.WriteLine("Pies= {0}", valAConvertir * 100 / 2.54 / 12)
                Console.WriteLine("Pulgadas= {0}", valAConvertir * 100 / 2.54)
            Case 2 'Centimetros
                Console.WriteLine("Metros= {0}", valAConvertir / 100)
                Console.WriteLine("Yardas= {0}", valAConvertir / 2.54 / 12 / 3)
                Console.WriteLine("Pies= {0}", valAConvertir / 2.54 / 12)
                Console.WriteLine("Pulgadas= {0}", valAConvertir / 2.54)
            Case 3 'Yardas
                Console.WriteLine("Metros= {0}", valAConvertir * 3 * 12 * 2.54 / 100)
                Console.WriteLine("Centimetros= {0}", valAConvertir * 3 * 12 * 2.54)
                Console.WriteLine("Pies= {0}", valAConvertir * 3)
                Console.WriteLine("Pulgadas= {0}", valAConvertir * 3 * 12)
            Case 4 'Pies
                Console.WriteLine("Metros= {0}", valAConvertir * 12 * 2.54 / 100)
                Console.WriteLine("Centimetros= {0}", valAConvertir * 12 * 2.54)
                Console.WriteLine("Yardas= {0}", valAConvertir / 3)
                Console.WriteLine("Pulgadas= {0}", valAConvertir * 12)
            Case 5 'Pulgadas
                Console.WriteLine("Metros= {0}", valAConvertir * 2.54 / 100)
                Console.WriteLine("Centimetros= {0}", valAConvertir * 2.54)
                Console.WriteLine("Yardas= {0}", valAConvertir / 12 / 3)
                Console.WriteLine("Pies= {0}", valAConvertir / 12)
            Case Else
                Console.WriteLine("---Error en seleccion.")
        End Select
    End Sub
End Module
