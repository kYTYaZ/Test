Public Partial Class HelloWorldProc
    <Microsoft.SqlServer.Server.SqlProcedure>
    Public Shared Sub HelloWorld(ByVal paraInput As SqlString, <Out> ByRef paraOutput As SqlString)
        paraOutput = $"***{paraInput}***"
    End Sub

    <SqlFunction(DataAccess:=DataAccessKind.Read, FillRowMethodName:="FindInvalidEmails_FillRow", TableDefinition:="CustomerId int, EmailAddress nvarchar(4000)")>
    Public Shared Function FindInvalidEmails(ByVal modifiedSince As SqlDateTime) As IEnumerable
        Dim resultCollection As ArrayList = New ArrayList()

        Using connection As SqlConnection = New SqlConnection("context connection=true")
            connection.Open()

            Using selectEmails As SqlCommand = New SqlCommand("SELECT " & "[CustomerID], [EmailAddress] " & "FROM [AdventureWorksLT2008].[SalesLT].[Customer] " & "WHERE [ModifiedDate] >= @modifiedSince", connection)
                Dim modifiedSinceParam As SqlParameter = selectEmails.Parameters.Add("@modifiedSince", SqlDbType.DateTime)
                modifiedSinceParam.Value = modifiedSince

                Using emailsReader As SqlDataReader = selectEmails.ExecuteReader()

                    While emailsReader.Read()
                        Dim emailAddress As SqlString = emailsReader.GetSqlString(1)

                        If ValidateEmail(emailAddress) Then
                            resultCollection.Add(New EmailResult(emailsReader.GetSqlInt32(0), emailAddress))
                        End If
                    End While
                End Using
            End Using
        End Using

        Return resultCollection
    End Function

    Public Shared Sub FindInvalidEmails_FillRow(ByVal emailResultObj As Object, <Out> ByRef customerId As SqlInt32, <Out> ByRef emailAdress As SqlString)
        Dim emailResult As EmailResult = CType(emailResultObj, EmailResult)
        customerId = emailResult.CustomerId
        emailAdress = emailResult.EmailAdress
    End Sub

    Private Class EmailResult
        Public CustomerId As SqlInt32
        Public EmailAdress As SqlString

        Public Sub New(ByVal customerId As SqlInt32, ByVal emailAdress As SqlString)
            CustomerId = customerId
            EmailAdress = emailAdress
        End Sub
    End Class

    Public Shared Function ValidateEmail(ByVal emailAddress As SqlString) As Boolean
        If emailAddress.IsNull Then Return False
        If Not emailAddress.Value.EndsWith("@adventure-works.com") Then Return False
        Return True
    End Function
End Class