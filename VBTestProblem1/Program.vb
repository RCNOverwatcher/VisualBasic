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
        
        'print out all the items in the stack in alphabetical order
        For Each fruit in fruitStack
            Console.WriteLine(fruit)
        Next
        
        'add new line to seperate
        Console.WriteLine()
        dim arrayLen as Integer = fruitArray.Length -1
        
        'clear array
        Array.Clear(fruitArray)
        
        'define queue
        Dim fruitQueue As Queue = New Queue()
        
        'add items from stack to array
        fruitStack.CopyTo(fruitArray,1)

        
        'put items from array into queue
        for counter = 1 to fruitArray.Length -1
            fruitQueue.Enqueue(fruitArray(counter))
        Next
        
        'delete old stack
        fruitStack.Clear()
        
        'declare reversed array
        Dim reversedArray(6) as String
        
        'put items back into stack
        for each fruit in fruitQueue
            fruitQueue.CopyTo(reversedArray, fruit)
        Next
        
        for each fruit in reversedArray
            fruitStack.Push(fruit)
        Next
        
        'print out all the items in the stack in alphabetical order
        For Each fruit in fruitStack
            Console.WriteLine(fruit)
        Next
        
    End Sub
End Module
