'Write a program that asks the user for their Password.
'IF their password is equal to “password” then let then print the message “welcome to the world”.
'Otherwise print “Access Denied”.

Imports System

Module Program
    Sub Main(args As String())
        Dim pword as String
        
        Console.WriteLine("Gimmie ur password rn")
        pword = Console.ReadLine()
        If pword = "password" Then
            Console.WriteLine("welcome to the world")
        Else
            Console.WriteLine("Access denied")
        End If
    End Sub
End Module
