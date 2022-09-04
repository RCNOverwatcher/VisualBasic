'Write a simple For Loop that asks how many times they would like to display a certain message.
'On entering this number the program then prints out the message that many times

Imports System

Module Program
    Sub Main(args As String())
        Dim i as Int32
        Dim playerask as Int32
        
        Console.WriteLine("Enter the message that you want displayed.")
        Dim playermessage as String
        playermessage = console.ReadLine()
        
        Console.WriteLine("How many times do you want that displayed?")
        playerask = Console.ReadLine()
        
        for i = 1 to playerask
            Console.WriteLine(playermessage)
        Next
    End Sub
End Module
