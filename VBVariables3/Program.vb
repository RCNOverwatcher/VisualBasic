Imports System

Module Program
    Sub Main(args As String())
        Dim name as String
        Dim favnum1 as Int32
        Dim favnum2 as Int32
        
        
        Console.WriteLine("What is your name?")
        name = Console.ReadLine()
        Console.WriteLine("What are your two favourite numbers? Type them separately.")
        favnum1 = Console.ReadLine()
        favnum2 = Console.ReadLine()
        
        Console.WriteLine()
        Console.WriteLine("Your name is....")
        Console.WriteLine(name)
        
        Console.WriteLine("and the answer to your two favourite numbers multiplied together is....")
        
        Dim finans as Int32
        finans = favnum1*favnum2
        
        Console.WriteLine(finans, "!")
    End Sub
End Module
