﻿Imports System.Xml
Imports System.Data
Imports System.Data.Odbc
Imports System.Data.Common
Imports System.Windows.Forms

Public Class Form1
    Inherits Form
    Protected DataSet1 As DataSet
    Protected dataGrid1 As DataGrid

' <Snippet1>
 Public Sub CreateOdbcConnection(connectionString As String)
        Using connection As New OdbcConnection(connectionString)
            With connection
                .Open()
                Console.WriteLine("ServerVersion: " & .ServerVersion _
                   & vbCrLf + "Database: " & .Database)
            End With
        End Using 
 End Sub
' </Snippet1>
End Class

