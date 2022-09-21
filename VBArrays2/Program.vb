Imports System

Module Program
    Sub Main(args As String())
        Dim value as Int32
        Dim vars(10) as Int32
        Dim count as Int32 = 0
        While count < 8
            Console.WriteLine("Enter a value: ")
            value =  Console.ReadLine()
            vars(count) = value
            count += 1
        End While
        
        for i = 0 to vars.Length - 1
            If vars.Contains(vars(i)) Then
                'UNFINISHED
            End If
        Next
        Console.WriteLine("No values in the array match")
    End Sub
End Module
