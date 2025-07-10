Module Module1

    Sub Main()
        Dim binaryString As String = "1011011"
        Dim decimalString As String = ConvertBintoDec(binaryString)
        Console.WriteLine($"Binary {binaryString} is decimal {decimalString}")
        Console.ReadLine()
    End Sub

    Function ConvertBintoDec(bnum As String) As String
        Dim totalnum As Integer = 0

        For i As Integer = 0 To bnum.Length - 1
            If bnum(i) = "1"c Then
                Dim bit As Integer = 2 ^ (bnum.Length - 1 - i)
                totalnum += bit
            ElseIf bnum(i) = "0"c Then

            Else
                Throw New ArgumentException("Input contains invalid characters.")
            End If
        Next

        Return totalnum.ToString()
    End Function

End Module
