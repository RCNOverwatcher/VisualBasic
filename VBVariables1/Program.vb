'Modify the program in exercise 1 so that it accepts a number of questions and places them into variables.
'At the end of the program, print out each of the answers to the screen

Imports System

Module Program
    Sub Main(args As String())
        Dim Q1 as String
        Dim Q2 as String
        Dim Q3 as String
        
        Console.WriteLine("How are you?")
        Q1 = console.ReadLine()
        Console.WriteLine("Whats your favourite colour")
        Q2 = console.ReadLine()
        Console.WriteLine("Do you have a pet?")
        Q3 = Console.ReadLine()
        
        Console.WriteLine()
        
        Console.WriteLine(Q1)
        Console.WriteLine(Q2)
        Console.WriteLine(Q3)
        
    End Sub
End Module
