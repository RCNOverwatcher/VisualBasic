'Modify your existing program that asks for the user’s 2 favorite numbers.
'Then ask the user for what they want to do with those numbers ( +, -, *, /)
'Then perform that operation using IF Statements

Imports System

Module Program
    Sub Main(args As String())
        console.WriteLine("What is your favourite number?")
        Dim favnum1 as Int32
        favnum1 = Console.ReadLine()
        Console.WriteLine("What is your second favourite number?")
        Dim favnum2 as Int32
        favnum2 = console.ReadLine()
        
        Console.WriteLine("What operation do you want to perform? +, -, *, /")
        Dim operation as String
        operation = console.ReadLine()
        
        if operation = "+" Then
            Console.WriteLine(favnum1 + favnum2)
        ElseIf operation = "-" Then
            Console.WriteLine(favnum1-favnum2)
        ElseIf operation = "*" Then
            Console.WriteLine(favnum1*favnum2)
        Elseif operation = "/" Then
            Console.WriteLine(favnum1/favnum2)
        Else
            Console.WriteLine("That is not a valid operator. Try again.")
        End If
    End Sub
End Module
