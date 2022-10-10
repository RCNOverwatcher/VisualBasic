Imports System

Module Program
    Sub Main(args As String())
        Dim names() as String = {"Harry", "Joe", "Susan", "Joanna", "Michael", "John"}
        array.Sort(names)
        Dim linkedListNames as New LinkedList(Of String)(names)
        
        While True:
            Console.WriteLine("Choose and option:")
            Console.WriteLine("1. Count items in the list")
            Console.WriteLine("2. Find an item in the list")
            Console.WriteLine("3. Print the list")
            Console.WriteLine("4. Delete an item from the list")
            Console.WriteLine("5. Exit")
        
            Dim optionSelected as Integer = Console.ReadLine()
        

            Select Case optionSelected
                Case 1
                    Console.WriteLine("There are {0} items in the list", linkedListNames.Count)
                Case 2
                    Console.WriteLine("Enter the name to find")
                    Dim nameToFind as String = Console.ReadLine()
                    If linkedListNames.Contains(nameToFind) Then
                        Console.WriteLine("The name {0} is in the list", nameToFind)
                    Else
                        Console.WriteLine("The name {0} is not in the list", nameToFind)
                    End If
                Case 3
                    Console.WriteLine("The list contains the following names:")
                    For Each name as String in linkedListNames
                        Console.WriteLine(name)
                    Next
                Case 4
                    Console.WriteLine("Enter the name to delete")
                    Dim nameToDelete as String = Console.ReadLine()
                    If linkedListNames.Contains(nameToDelete) Then
                        linkedListNames.Remove(nameToDelete)
                        Console.WriteLine("The name {0} has been deleted", nameToDelete)
                    Else
                        Console.WriteLine("The name {0} is not in the list", nameToDelete)
                    End If
                Case 5
                    Console.WriteLine("Goodbye")
                    Exit While
                Case Else
                    Console.WriteLine("Invalid option")
            End Select
        End While
    End Sub
End Module
