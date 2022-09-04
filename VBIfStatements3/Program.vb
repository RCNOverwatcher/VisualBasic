'Write another program that asks for the user for the answer to “life the universe and everything”
'If the number is less than 42, print the answer “too low”
'Otherwise, if the answer is higher than 42 print “too high”.
'Otherwise, print “Spot on”

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("What is the answer to the life the universe and everything?")
        Dim userans as Int32
        userans = console.ReadLine()
        
        if userans = 42 Then
            Console.WriteLine("Spot on")
        elseif userans < 42 Then
            Console.WriteLine("too low")
        elseif userans > 42 Then
            Console.WriteLine("too high")
        else
            Console.WriteLine("That is not a valid guess. Try again.")
        End If
    End Sub
End Module
