Imports System

Module Program
    Sub Main(args As String())
        Dim names(5) as String
        
        names(0) = "Harry"
        names(1) = "Joe"
        names(2) = "Susan"
        names(3) = "Joanna"
        names(4) = "Michael"
        names(5) = "John"
        
        Array.Sort(names)
        
        Dim nameLinkedList As New LinkedList(of String)
        
        For counter = 0 to 5
            nameLinkedList.Append(names(counter))
        Next
        
        
        If IsListEmpty(nameLinkedList) = True
            Console.WriteLine("The Linked list is empty!")
        Else
            Console.WriteLine("Linked list not empty!")
        End If
    End Sub
    
    Function IsListEmpty(byVal linkedList as LinkedList(Of String))
        Dim sArray(linkedList.Count) as String
        
        linkedList.CopyTo(sArray, 0)
        
        If sArray.Length <=1 Then
            Return True
        Else 
            Return False
        End If
    End Function
    
    Function AddToLinkedList(ByRef linkedList As LinkedList(Of String))
        
    End Function
End Module
