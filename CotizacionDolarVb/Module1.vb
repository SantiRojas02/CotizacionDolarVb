Module Module1

    Sub Main(args As String())

        Dim dolar As Decimal
        Dim pesos As Decimal

        pesos = 200

        Console.Write("Cantidad de dolar a comprar: ")
        dolar = Console.ReadLine()



        dolar = dolar * pesos


        Console.WriteLine("Valor a pagar: " & dolar)

        Console.ReadLine()



    End Sub

End Module
