Imports System

Module Program
    Sub Main(args As String())
        
        'define array
        Dim fruitArray As String() = {"Apple", "Mango", "Banana", "Pear", "Orange", "Lemon"}
        
        'sort and reverse array, ready to put into stack
        Array.Sort(fruitArray)
        Array.Reverse(fruitArray)
        
        'define stack
        Dim fruitStack as Stack = New Stack()
        
        'push all items of the array onto the stack
        For x = 1 to fruitArray.Length -1
            fruitStack.Push(fruitArray(x))
        Next
        
        'text
        Console.WriteLine("Sorted: ")
        
        'print out all the items in the stack in alphabetical order
        For Each fruit in fruitStack
            Console.WriteLine(fruit)
        Next
        
        'add new line to separate
        Console.WriteLine("Reversed: ")
        
        'reverse array again
        Array.Reverse(fruitArray)
        
        'define stack
        Dim reversedFruitStack as Stack = New Stack()
        
        'push all items of the array onto the stack
        For x = 0 to fruitArray.Length - 1
            reversedFruitStack.Push(fruitArray(x))
        Next
        
        'print out all the items in the stack in alphabetical order
        For Each fruit in reversedFruitStack
            Console.WriteLine(fruit)
        Next
        
        'add new line to seperate
        Console.WriteLine()
        
    End Sub
End Module
