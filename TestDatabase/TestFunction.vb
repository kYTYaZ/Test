Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server
Imports System.Collections
Imports System.Runtime.InteropServices

Partial Public Class UserDefinedFunctions
    <Microsoft.SqlServer.Server.SqlFunction(
        DataAccess:=DataAccessKind.Read,
        IsDeterministic:=False,
        SystemDataAccess:=SystemDataAccessKind.None,
        IsPrecise:=True)>
    Public Shared Function TestFunction(ByVal para1 As SqlString, ByVal para2 As SqlString) As SqlString
        ' Put your code here
        Return New SqlString($"[{para1}]-[{para2}]")
    End Function

    <SqlFunction(
        DataAccess:=DataAccessKind.Read,
        FillRowMethodName:="TestFunctionTable_FillRow",
        TableDefinition:="Id int, Text nvarchar(100)")>
    Public Shared Function TestFunctionTable(ByVal maxId As SqlInt32) As IEnumerable
        Dim list As ArrayList = New ArrayList()
        For i As Integer = 1 To CType(maxId, Integer)
            list.Add(New TableResult() With {.Id = i, .Text = $"[{i}]"})
        Next
        Return list
    End Function

    Public Shared Sub TestFunctionTable_FillRow(ByVal resultObj As Object, <Out> ByRef id As SqlInt32, <Out> ByRef text As SqlString)
        Dim result As TableResult = CType(resultObj, TableResult)
        id = result.Id
        text = result.Text
    End Sub

    Private Class TableResult
        Public Id As SqlInt32
        Public Text As SqlString
    End Class
End Class
