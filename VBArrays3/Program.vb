Imports System

Module Program
    Sub Main(args As String())
        Dim arraynum(10) as Integer
        
        For counter = 1 To 10
            Dim num as Int32 = Console.ReadLine()
            arraynum(counter) = num
        Next
        
        array.Sort(arraynum)
        
        For counter = 1 to 10
            Console.WriteLine("Number = {0}", arraynum(counter))
        Next
    End Sub
End Module
