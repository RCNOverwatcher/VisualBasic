'Write a menu system that asks the user to pick from a list of foods.
'If the user picks a healthy options display a positive message, otherwise display a negative message.

Imports System

Module Program
    Sub Main(args As String())
        console.WriteLine("Pick a food. Apple, pizza, ice cream or fruit cocktail.")
        dim food as String
        food = Console.ReadLine()
        
        Select case food.ToLower
            case "apple"
                Console.WriteLine("Good job!")
            case "pizza"
                Console.WriteLine("My condolences")
            case "ice cream"
                Console.WriteLine("Unlucky, thats an unhealthy food")
            case "fruit cocktail"
                Console.WriteLine("Good on you!")
        End Select
    End Sub
End Module
