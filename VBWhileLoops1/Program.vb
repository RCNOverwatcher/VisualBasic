'Prompt the user to enter their password, you then have to Check their password against the one in the system.
'If their password is correct display “Welcome to the world”. Otherwise continue to prompt for a password.
'For an extra challenge IF the user enters wrong 3 times, display “you are banished!” and quit (EXIT WHILE)

Imports System

Module Program
    Sub Main(args As String())
        Dim timesentered as Int32
        Dim password as String
        Dim correctPassword as String = "letmein"
        
        while password <> correctPassword
            Console.WriteLine("Enter your password: ")
            password = console.ReadLine()
            if password = correctPassword
                Console.WriteLine("Welcome to the world!")
                Environment.Exit(0)
            End If
            timesentered += 1
            
            if timesentered = 3
                Console.WriteLine("YOU ARE BANISHED!!!")
                Environment.Exit(0)
            End If
        End While
    End Sub
End Module
