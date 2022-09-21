Imports System

Module Program
    Sub Main(args As String())
        Dim stopCommand as String = "."
        Dim vars(10) as Int32
        Dim addedValue as String
        Dim count as Int32 = 0
        
        Console.WriteLine("Enter a number to add: ")
        
        while addedValue <> stopCommand
            addedValue = Console.ReadLine()
            if addedValue = "."
                ReDim Preserve vars(vars.Length)
                for i = 0 To vars.Length - 1
                    Console.WriteLine(vars(i))
                Next
                Environment.Exit(0)
            End If
            vars(count) = addedValue
            count += 1
        End While
        
        
    End Sub
End Module
