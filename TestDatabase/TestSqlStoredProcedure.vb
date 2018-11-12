Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Runtime.InteropServices
Imports System.Text

Partial Public Class TestSqlStoredProcedure
    <Microsoft.SqlServer.Server.SqlProcedure>
    Public Shared Sub TestStoredProcedure(ByVal paraInput As SqlString, <Out> ByRef paraOutput As SqlString)
        executeCommand(paraInput, paraOutput)
        executeDataAdapter(paraInput, paraOutput)
    End Sub
    Private Shared Sub executeDataAdapter(ByVal paraInput As SqlString, <Out> ByRef paraOutput As SqlString)
        Try
            Dim output As String = ""
            If SqlContext.IsAvailable Then
                SqlContext.Pipe.ExecuteAndSend(New SqlCommand("PRINT 'Starting executeDataAdapter...';"))
            End If
            Dim result As New DataTable
            Using connection As New SqlConnection("context connection=true")
                connection.Open()
                Dim sqlCommand As String = $"SELECT TOP(10) * FROM [dbo].[{paraInput}];"
                Dim adapter As New SqlDataAdapter(sqlCommand, connection)
                adapter.Fill(result)
            End Using
            For Each row As DataRow In result.Rows
                If SqlContext.IsAvailable Then
                    SqlContext.Pipe.ExecuteAndSend(New SqlCommand($"PRINT 'Id: [{row("Id")}]; Name: [{row("Name")}]';"))
                Else
                    output &= output & Environment.NewLine & $"PRINT 'Id: [{row("Id")}]; Name: [{row("Name")}]';"
                End If
            Next
            If SqlContext.IsAvailable Then
                SqlContext.Pipe.ExecuteAndSend(New SqlCommand("PRINT 'End';"))
            End If
        Catch ex As Exception
            paraOutput = ex.Message
        End Try

    End Sub
    Private Shared Sub executeCommand(ByVal paraInput As SqlString, <Out> ByRef paraOutput As SqlString)
        Try

            Dim output As String = ""
            Dim command As SqlCommand
            If SqlContext.IsAvailable Then
                SqlContext.Pipe.ExecuteAndSend(New SqlCommand("PRINT 'Starting executeCommand...';"))
            End If
            Dim reader As SqlDataReader
            Using connection As New SqlConnection("context connection=true")
                connection.Open()
                command = New SqlCommand($"SELECT TOP(10) * FROM [dbo].[{paraInput}];", connection)
                reader = command.ExecuteReader()
                Do While reader.Read()
                    output &= output & Environment.NewLine & $"Id: [{reader("Id")}]; Name: [{reader("Name")}]"
                Loop
                paraOutput = output
            End Using
            If SqlContext.IsAvailable Then
                SqlContext.Pipe.ExecuteAndSend(New SqlCommand("PRINT 'End';"))
            End If
        Catch ex As Exception
            paraOutput = ex.Message
        End Try

    End Sub
End Class
