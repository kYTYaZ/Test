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
'*  Project Name: Polling data from FurnitureMedic
'*     Reference: 
'* Code Reviewer: 
'*   Review Date: 
'*        Remark: [_XMITEntityMap].[apiEntity] must be same as hard code in GetData
'* ****************************************************************************
'* Revision History:                                                          *
'* ========================================================================== *
'*          Name: 
'* Modified Date: 
'*   Description: 
'* --------------------------------------------------------------------------
'* ****************************************************************************
Public Class Sample
    Implements IDisposable
#Region "Public Shared Fields"

#End Region
#Region "Private Fields"
    Private _DisposedValue As Boolean = False
#End Region

#Region "Public Properties"
    'Public ReadOnly Property FolderTemp As String
    '    Get
    '        Return Me._FolderTemp
    '    End Get
    'End Property
#End Region

#Region "Constructors"

    'Public Sub New(Optional ByVal emailServer As String, Optional ByVal emailUser As String, Optional ByVal emailPassword As String = "")
    'End Sub
#End Region

#Region "Public Methods"
#Region "IDisposable Support"

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not _DisposedValue Then
            If disposing Then
            End If
        End If
        _DisposedValue = True
    End Sub

    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#End Region

#Region "Private Methods"
#End Region


#Region "Internal Classes"

#End Region

End Class
