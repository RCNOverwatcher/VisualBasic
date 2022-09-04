'Modify your calculator program, use a CASE Statement instead of IF’s

Imports System

Module Program
    Sub Main(args As String())
        console.WriteLine("What is your favourite number?")
        Dim favnum1 as Int32
        favnum1 = Console.ReadLine()
        Console.WriteLine("What is your second favourite number?")
        Dim favnum2 as Int32
        favnum2 = console.ReadLine()
        
        Console.WriteLine("What operation do you want to perform? Add. subtract, multiply or divide?")
        Dim operation as String
        operation = console.ReadLine()
        
        Select case operation.ToLower
            case "add"
                Console.WriteLine(favnum1 + favnum2)
            case "subtract"
                Console.WriteLine(favnum1-favnum2)
            case "multiply"
                Console.WriteLine(favnum1*favnum2)
            case "divide"
                Console.WriteLine(favnum1/favnum2)
            case else
                Console.WriteLine("That is not a valid operator. Try again.")
        End select
    End Sub
End Module
