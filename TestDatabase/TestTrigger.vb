Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports Microsoft.SqlServer.Server


Partial Public Class Triggers
    ' Enter existing table or view for the target and uncomment the attribute line
    <Microsoft.SqlServer.Server.SqlTrigger(Name:="TestTrigger", Target:="TestTable", Event:="FOR INSERT, UPDATE, DELETE")>
    Public Shared Sub  TestTrigger ()
        ' Replace with your own code
        SqlContext.Pipe.Send("Trigger FIRED")
        Dim id As Integer
        Dim test As String
        Dim command As SqlCommand
        Dim triggContext As SqlTriggerContext
        Dim pipe As SqlPipe
        Dim reader As SqlDataReader

        triggContext = SqlContext.TriggerContext
        pipe = SqlContext.Pipe

        Select Case triggContext.TriggerAction
            Case TriggerAction.Insert
                Using connection As New SqlConnection("context connection=true")
                    connection.Open()
                    command = New SqlCommand("SELECT * FROM INSERTED;", connection)

                    reader = command.ExecuteReader()
                    reader.Read()

                    id = CType(reader(0), Integer)
                    test = CType(reader(1), String)
                    reader.Close()
                    test = $"[{id}].[{test}]"
                    command = New SqlCommand($"
	                        UPDATE [dbo].[TestTable] SET [Test]='{test}'
		                        FROM [dbo].[TestTable]
			                        INNER JOIN INSERTED
				                        ON INSERTED.[Id]=[TestTable].[Id];
                        ", connection)
                    id = command.ExecuteNonQuery()
                    pipe.Send($"[{id}] record updated.")
                End Using

            Case TriggerAction.Update
                pipe.Send($"UPDATE")

            Case TriggerAction.Delete
                pipe.Send($"DELETE")
        End Select
    End Sub
End Class
