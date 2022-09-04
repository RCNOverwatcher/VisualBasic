'Modify this so that you ask someone who picks a healthy option if they want mayo.
'If they pick mayo display “ohhh, you were so close to being healthy” or something like this.

Imports System

Module Program
    Sub Main(args As String())
        console.WriteLine("Pick a food. Apple, pizza, ice cream or fruit cocktail.")
        dim food as String
        food = Console.ReadLine()
        dim mayoornot as String
        Select case food.ToLower
            case "apple"
                Console.WriteLine("Do you want mayo with that? Yes or no.")
                mayoornot = console.ReadLine()
                Select case mayoornot.ToLower
                    Case "yes"
                        Console.WriteLine("Ok thats a little disgusting but you do you ig")
                    Case "no"
                        Console.WriteLine("Good Job!")
                end Select
            case "pizza"
                Console.WriteLine("My condolences")
            case "ice cream"
                Console.WriteLine("Unlucky, thats an unhealthy food")
            case "fruit cocktail"
                Console.WriteLine("Do you want mayo with that? Yes or no.")
                mayoornot = console.ReadLine()
                Select case mayoornot.ToLower
                    Case "yes"
                        Console.WriteLine("Ok thats a little disgusting but you do you ig")
                    Case "no"
                        Console.WriteLine("Good on you!")
                End Select
        End Select
    End Sub
End Module
