'Make a program that accepts 3 numbers from a console.readline()
'adds them all together and then displays the numbers the person has typed in and the final answer

Imports System

Module Program
    Sub Main(args As String())
        Dim Int1 as Int32
        Dim Int2 as Int32
        Dim Int3 as Int32
        
        Console.WriteLine("Enter 3 numbers")
        Int1 = Console.ReadLine()
        Int2 = Console.ReadLine()
        Int3 = Console.ReadLine()
        
        Dim addAllNumbersUp as Int32
        
        addAllNumbersUp = Int1 + Int2 + Int3
        
        Console.WriteLine("You entered")
        
        Console.WriteLine(Int1)
        Console.WriteLine(Int2)
        Console.WriteLine(Int3)

        Console.WriteLine("All those numbers add up to.....")
        Console.WriteLine(addAllNumbersUp, "!")
        
        
        
    End Sub
End Module
