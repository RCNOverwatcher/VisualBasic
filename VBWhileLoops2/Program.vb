'Suppose you had a credit card, with a balance of £50 owed on it.
'The bank charges you 2% interest every month.
'How many months could you leave it, before the bank charges you £1003

Imports System

Module Program
    Sub Main(args As String())
        Dim credValue as Int32 = 50
        Dim interestValue as Double = 1.02
        Dim days as Int32
        
        while credValue < 100
            credValue *= interestValue
            days += 1
            
        End While
        
        Console.WriteLine("It will take " & days & " days")
        
    End Sub
End Module
