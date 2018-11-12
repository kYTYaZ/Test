'******************************************************************************
'* Copyright (c) WebSan Solutions Inc. 2000 - 2018                            *
'*                                                                            *
'*                All rights reserved.                                        *
'*                http://www.websan.com                                       *
'* ========================================================================== *
'*        Author: Andrew Huang
'*   Create Date: 2018.05.18
'*   Description: 
'*       Company: WebSan
'*  Project Name: Sync
'*     Reference: 
'* Code Reviewer: 
'*   Review Date: 
'*        Remark: 
'* ****************************************************************************
'* Revision History:                                                          *
'* ========================================================================== *
'*          Name: 
'* Modified Date: 
'*   Description: 
'* --------------------------------------------------------------------------
'* ****************************************************************************

Imports System.ComponentModel
Public Class FranConnect
    Private Const CONTEXT_PATH As String = ""
    Public Property Key As String
    Public Property MainModule As ModuleType = ModuleType.admin
    Public Property SubModule As String
    Public Property TypeResponse As ResponseType = ResponseType.JSON
    Public Property FilterXml As String
    Public Property XmlString As String
    Public Property RoleTypeForQuery As String
    Public Property Operation As OperationType = OperationType.create
    Public ReadOnly Property Parameter As String
        Get
            Return String.Format("key={0}&module={1}&subModule={2}&responseType={3}&filterXML={4}", Me.Key, Me.MainModule, Me.SubModule, Me.TypeResponse, Me.FilterXml)
        End Get
    End Property
    Public ReadOnly Property URL As String
        Get
            Return String.Format("https://{0}/rest/dataservices/{1}", CONTEXT_PATH, Me.Operation)
        End Get
    End Property

    Public Sub New()


    End Sub

    Public Sub New(ByVal key As String, ByVal mainModule As ModuleType, ByVal subModule As String, ByVal typeResponse As ResponseType, ByVal filterXml As String)
        Me.Key = key
        Me.MainModule = mainModule
        Me.SubModule = subModule
        Me.TypeResponse = typeResponse
        Me.FilterXml = filterXml
    End Sub

    Public Enum ModuleType
        <Description("Sales")>
        fs
        <Description("Info Mgr")>
        fim
        <Description("CRM")>
        cm
        <Description("Admin")>
        admin
    End Enum
    Public Enum OperationType
        login
        submodule
        query
        create
        update
        retrieve
        delete
        log
        logout
    End Enum
    Public Enum ResponseType
        XML
        JSON
    End Enum
End Class
