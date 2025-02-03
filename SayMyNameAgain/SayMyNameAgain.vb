'ChristopherZ
'Spring 2025
'RCET2265
'Say my name again
'https://github.com/Christopher-isu/SayMyNameAgain.git

Option Explicit On 'forces all variables to be declared
Option Strict On 'forces all variables to be declared correctly
Option Compare Text 'makes the code case insensitive
Module SayMyNameAgain
    Sub Main()
        ' Prompt the user to enter their name
        Console.Write("Enter your name: ")

        ' Save user input as a variable
        Dim userName As String = Console.ReadLine()

        Select Case userName
            Case "Emily"
                Console.WriteLine("Hello " & (userName))
            Case "Joe"
                Console.WriteLine("Hello " & (userName))
            Case "Christopher"
                Console.WriteLine("There can be only one " & (userName) & " !")
            Case Else
                Console.WriteLine("Your name is not on the list.")
        End Select

        ' Keep console open untill button pressed
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()

    End Sub

End Module