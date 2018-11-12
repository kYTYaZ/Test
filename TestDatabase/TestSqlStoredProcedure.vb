Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Runtime.InteropServices

Partial Public Class TestSqlStoredProcedure
    <Microsoft.SqlServer.Server.SqlProcedure>
    Public Shared Sub TestStoredProcedure(ByVal paraInput As SqlString, <Out> ByRef paraOutput As SqlString)
        paraOutput = $"***[{paraInput}]***"
    End Sub
    Public Shared Sub TestStoredProcedure2(ByVal paraInput As String, <Out> ByRef paraOutput As String)
        paraOutput = $"@@@{paraInput}@@@"
    End Sub
End Class
