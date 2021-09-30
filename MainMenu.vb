Class MainMenu
    Implements IMenu
    Sub Initial() Implements IMenu.Start
        
        Console.WriteLine("Hello World!")
        dim repeat As Boolean = true
        Do While repeat
            Console.WriteLine("what would you like to do?")
            Console.WriteLine("[0] Say Hello")
            Console.WriteLine("[1] Say Goodbye")
            Console.WriteLine(" Exit")
            dim input As String = Console.ReadLine()
                Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                Case "1"
                    Console.writeline("Goodbye")
                    repeat = False
            End Select           
            
        Loop
        
    
    
    End Sub 

End Class
   