@@ -0,0 +1,33 @@
﻿Module Module1
    Dim a As Long
    Dim b As Long
    Dim c As Double
    Dim bound As Long

    Sub Main()
        My.Computer.FileSystem.WriteAllText("Values.txt", TimeOfDay & vbCrLf, False)
        bound = 5
        While True
            For a As Long = bound To (bound + 999999) Step 2
                If IsPrime(a) = True Then
                    My.Computer.FileSystem.WriteAllText("Values.txt", a & " is prime" & vbCrLf, True)
                End If
            Next
            bound = bound + 1000000
        End While

    End Sub

    Function IsPrime(a As Long) As Boolean
        b = 3
        For b As Long = 3 To Math.Ceiling(Math.Sqrt(a)) Step 2
            c = a Mod b
            If (c = 0) Then
                Return False
            End If
        Next
        Return True
    End Function

End Module
