Module Module1

    Sub Main()
        Dim numeros(14) As Integer
        Dim auxiliar(14) As Integer
        Dim suma As Integer = 0

        Dim constante As Double
        Dim valMax As Integer
        Dim valMin As Integer
        Dim valArreglo As Integer

        Dim mediaA As Double = 0.00

        Dim rep As Integer = 0
        Dim valor As Integer = 0

        'obtiene los valores por consola
        For N = 0 To numeros.Length - 1 Step 1
            Console.WriteLine("ingrese un numero: " & N + 1 & ":")
            numeros(N) = Console.ReadLine()
            suma += numeros(N)

        Next
        Array.Sort(numeros)

        'recorre el arreglo para valores maximo y minimo
        For index = 0 To numeros.GetUpperBound(0)
            'valor maximo y minimo
            valArreglo = numeros(index)
            If (index = 0) Then
                valMin = valArreglo
                valMax = valArreglo
            End If

            If (valArreglo < valMin) Then
                valMin = valArreglo

            End If

            If (valArreglo > valMax) Then
                valMax = valArreglo
            End If

            Console.WriteLine(numeros(index))

        Next
        Console.WriteLine($"Valor minimo: {valMin}")
        Console.WriteLine($"Valor maximo: {valMax}")

        'Media Aritmetica
        mediaA = suma / numeros.Length
        Console.WriteLine($"Media Aritmetica: {mediaA}")

        'Mediana
        Dim cantidad As Integer = numeros.Length - 1
        Dim puntomedio As Integer = cantidad / 2
        Dim mediana As Integer = numeros(puntomedio)

        Console.WriteLine($"mediana: {mediana}")

        'Moda
        Dim posicion As Integer = 0
        For index = 0 To numeros.GetUpperBound(0)
            valor = numeros(index)
            posicion = index
            For index2 = index To numeros.GetUpperBound(0)
                If (numeros(index2) = valor) Then
                    auxiliar(posicion) += 1
                End If
            Next
        Next

        Dim mayor As Integer = 0
        Dim posicionmayor As Integer = 0
        mayor = auxiliar(0)

        For index = 0 To numeros.GetUpperBound(0)
            If (auxiliar(index) > mayor) Then
                posicionmayor = index
                mayor = auxiliar(index)
            End If

        Next

        Console.WriteLine($"Moda: {numeros(posicionmayor)}")

        Console.WriteLine("suma total:  " & suma)
        Console.ReadLine()
    End Sub


End Module
