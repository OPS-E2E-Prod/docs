﻿' Visual Basic .NET Document
Option Strict On

' <Snippet8>
Imports System.Text.RegularExpressions

Module Example
    Public Sub Main()
        Dim inputs() As String = {"aaaaa", "aaaaab"}
        Dim nonbacktrackingPattern As String = "((?>a+))\w"
        Dim match As Match

        For Each input As String In inputs
            Console.WriteLine("Input: {0}", input)
            match = Regex.Match(input, nonbacktrackingPattern)
            Console.WriteLine("   Pattern: {0}", nonbacktrackingPattern)
            If match.Success Then
                Console.WriteLine("      Match: {0}", match.Value)
                Console.WriteLine("      Group 1: {0}", match.Groups(1).Value)
            Else
                Console.WriteLine("      Match failed.")
            End If
        Next
        Console.WriteLine()
    End Sub
End Module
' The example displays the following output:
'       Input: aaaaa
'          Pattern: ((?>a+))\w
'             Match failed.
'       Input: aaaaab
'          Pattern: ((?>a+))\w
'             Match: aaaaab
'             Group 1: aaaaa
' </Snippet8>

