Imports System

Module Program
    Sub Main(args As String())
        Dim names() as String = {"Harry", "Joe", "Susan", "Joanna", "Michael", "John"}
        Dim linkedListNames as New LinkedList(Of String)(names)
        Dim node as LinkedListNode(Of String) = linkedListNames.First
        Do While node IsNot Nothing
            Console.WriteLine(node.Value)
            node = node.Next
        Loop
        
        Console.WriteLine("Sorted list")
        array.Sort(names)
        Dim linkedListNamesSorted as New LinkedList(Of String)(names)
        node = linkedListNamesSorted.First
        Do While node IsNot Nothing
            Console.WriteLine(node.Value)
            node = node.Next
        Loop
        
    End Sub
End Module
