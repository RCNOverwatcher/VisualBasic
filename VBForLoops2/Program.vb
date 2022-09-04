'Make a variable that has a number in it. Give the user 10 guesses to pick the correct number,
'if the number is guessed correctly then exit the for loop and display either a congratulations statement or a commiseration statement.
'(You will need to use a FOR loop and a number of IF Statements as well as the EXITFOR command)


Imports System

Module Program
    Sub Main(args As String())
        dim target as Int32
        dim count as Int32
        dim playerguess as Int32
        dim countdown as Int32
        
        target = 420
        countdown = 9
        
        Console.WriteLine("Guess a number.... Any number!")
        for count = 1 to 10
            playerguess = console.ReadLine()
            if playerguess = target
                Console.WriteLine("GG you win")
                Exit For
            else
                Console.WriteLine("WRONG! You have " & countdown & " guesses remaining!")
                countdown = countdown - 1
            End If
            if countdown = -1
                Console.WriteLine("You didn't guess the number in 10 tries :(")
            end if
        Next
        
    End Sub
End Module
