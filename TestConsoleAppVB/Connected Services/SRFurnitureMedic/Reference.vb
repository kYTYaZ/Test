﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace SRFurnitureMedic
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="DocumentQueryBean", [Namespace]:="http://rpc.xml.coldfusion"),  _
     System.SerializableAttribute(),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SRFurnitureMedic.ArrayOf_xsd_string)),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SRFurnitureMedic.ArrayOf_xsd_anyType)),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SRFurnitureMedic.ArrayOfArrayOf_xsd_anyType)),  _
     System.Runtime.Serialization.KnownTypeAttribute(GetType(SRFurnitureMedic.CFCInvocationException))>  _
    Partial Public Class DocumentQueryBean
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        Private columnListField As SRFurnitureMedic.ArrayOf_xsd_string
        
        Private dataField As SRFurnitureMedic.ArrayOfArrayOf_xsd_anyType
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property columnList() As SRFurnitureMedic.ArrayOf_xsd_string
            Get
                Return Me.columnListField
            End Get
            Set
                If (Object.ReferenceEquals(Me.columnListField, value) <> true) Then
                    Me.columnListField = value
                    Me.RaisePropertyChanged("columnList")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute(IsRequired:=true)>  _
        Public Property data() As SRFurnitureMedic.ArrayOfArrayOf_xsd_anyType
            Get
                Return Me.dataField
            End Get
            Set
                If (Object.ReferenceEquals(Me.dataField, value) <> true) Then
                    Me.dataField = value
                    Me.RaisePropertyChanged("data")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ArrayOf_xsd_string", [Namespace]:="http://rpc.xml.coldfusion", ItemName:="item"),  _
     System.SerializableAttribute()>  _
    Public Class ArrayOf_xsd_string
        Inherits System.Collections.Generic.List(Of String)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ArrayOf_xsd_anyType", [Namespace]:="http://rpc.xml.coldfusion", ItemName:="item"),  _
     System.SerializableAttribute()>  _
    Public Class ArrayOf_xsd_anyType
        Inherits System.Collections.Generic.List(Of Object)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ArrayOfArrayOf_xsd_anyType", [Namespace]:="http://rpc.xml.coldfusion", ItemName:="item"),  _
     System.SerializableAttribute()>  _
    Public Class ArrayOfArrayOf_xsd_anyType
        Inherits System.Collections.Generic.List(Of SRFurnitureMedic.ArrayOf_xsd_anyType)
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="CFCInvocationException", [Namespace]:="http://rpc.xml.coldfusion"),  _
     System.SerializableAttribute()>  _
    Partial Public Class CFCInvocationException
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://webservice", ConfigurationName:="SRFurnitureMedic.Soap")>  _
    Public Interface Soap
        
        'CODEGEN: Generating message contract since element name getVendorsReturn from namespace http://webservice is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SRFurnitureMedic.CFCInvocationException), Action:="", Name:="fault")>  _
        Function getVendors(ByVal request As SRFurnitureMedic.getVendorsRequest) As SRFurnitureMedic.getVendorsResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function getVendorsAsync(ByVal request As SRFurnitureMedic.getVendorsRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getVendorsResponse)
        
        'CODEGEN: Generating message contract since element name getPurchaseOrdersReturn from namespace http://webservice is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SRFurnitureMedic.CFCInvocationException), Action:="", Name:="fault")>  _
        Function getPurchaseOrders(ByVal request As SRFurnitureMedic.getPurchaseOrdersRequest) As SRFurnitureMedic.getPurchaseOrdersResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function getPurchaseOrdersAsync(ByVal request As SRFurnitureMedic.getPurchaseOrdersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getPurchaseOrdersResponse)
        
        'CODEGEN: Generating message contract since element name getSalesOrdersReturn from namespace http://webservice is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SRFurnitureMedic.CFCInvocationException), Action:="", Name:="fault")>  _
        Function getSalesOrders(ByVal request As SRFurnitureMedic.getSalesOrdersRequest) As SRFurnitureMedic.getSalesOrdersResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function getSalesOrdersAsync(ByVal request As SRFurnitureMedic.getSalesOrdersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getSalesOrdersResponse)
        
        'CODEGEN: Generating message contract since element name getCustomersReturn from namespace http://webservice is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*"),  _
         System.ServiceModel.FaultContractAttribute(GetType(SRFurnitureMedic.CFCInvocationException), Action:="", Name:="fault")>  _
        Function getCustomers(ByVal request As SRFurnitureMedic.getCustomersRequest) As SRFurnitureMedic.getCustomersResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="", ReplyAction:="*")>  _
        Function getCustomersAsync(ByVal request As SRFurnitureMedic.getCustomersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getCustomersResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getVendorsRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getVendors", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getVendorsRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getVendorsRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getVendorsRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public inReadDate As Date
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal inReadDate As Date)
            MyBase.New
            Me.inReadDate = inReadDate
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getVendorsResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getVendorsResponse", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getVendorsResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getVendorsResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getVendorsResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getVendorsReturn As SRFurnitureMedic.DocumentQueryBean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getVendorsReturn As SRFurnitureMedic.DocumentQueryBean)
            MyBase.New
            Me.getVendorsReturn = getVendorsReturn
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getPurchaseOrdersRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getPurchaseOrders", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getPurchaseOrdersRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getPurchaseOrdersRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getPurchaseOrdersRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public inReadDate As Date
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal inReadDate As Date)
            MyBase.New
            Me.inReadDate = inReadDate
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getPurchaseOrdersResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getPurchaseOrdersResponse", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getPurchaseOrdersResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getPurchaseOrdersResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getPurchaseOrdersResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getPurchaseOrdersReturn As SRFurnitureMedic.DocumentQueryBean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getPurchaseOrdersReturn As SRFurnitureMedic.DocumentQueryBean)
            MyBase.New
            Me.getPurchaseOrdersReturn = getPurchaseOrdersReturn
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getSalesOrdersRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getSalesOrders", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getSalesOrdersRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getSalesOrdersRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getSalesOrdersRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public inReadDate As Date
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal inReadDate As Date)
            MyBase.New
            Me.inReadDate = inReadDate
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getSalesOrdersResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getSalesOrdersResponse", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getSalesOrdersResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getSalesOrdersResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getSalesOrdersResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getSalesOrdersReturn As SRFurnitureMedic.DocumentQueryBean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getSalesOrdersReturn As SRFurnitureMedic.DocumentQueryBean)
            MyBase.New
            Me.getSalesOrdersReturn = getSalesOrdersReturn
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getCustomersRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getCustomers", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getCustomersRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getCustomersRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getCustomersRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public inReadDate As Date
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal inReadDate As Date)
            MyBase.New
            Me.inReadDate = inReadDate
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class getCustomersResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="getCustomersResponse", [Namespace]:="http://webservice", Order:=0)>  _
        Public Body As SRFurnitureMedic.getCustomersResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As SRFurnitureMedic.getCustomersResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://webservice")>  _
    Partial Public Class getCustomersResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public getCustomersReturn As SRFurnitureMedic.DocumentQueryBean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal getCustomersReturn As SRFurnitureMedic.DocumentQueryBean)
            MyBase.New
            Me.getCustomersReturn = getCustomersReturn
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface SoapChannel
        Inherits SRFurnitureMedic.Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SoapClient
        Inherits System.ServiceModel.ClientBase(Of SRFurnitureMedic.Soap)
        Implements SRFurnitureMedic.Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getVendors(ByVal request As SRFurnitureMedic.getVendorsRequest) As SRFurnitureMedic.getVendorsResponse Implements SRFurnitureMedic.Soap.getVendors
            Return MyBase.Channel.getVendors(request)
        End Function
        
        Public Function getVendors(ByVal inReadDate As Date) As SRFurnitureMedic.DocumentQueryBean
            Dim inValue As SRFurnitureMedic.getVendorsRequest = New SRFurnitureMedic.getVendorsRequest()
            inValue.Body = New SRFurnitureMedic.getVendorsRequestBody()
            inValue.Body.inReadDate = inReadDate
            Dim retVal As SRFurnitureMedic.getVendorsResponse = CType(Me,SRFurnitureMedic.Soap).getVendors(inValue)
            Return retVal.Body.getVendorsReturn
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getVendorsAsync(ByVal request As SRFurnitureMedic.getVendorsRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getVendorsResponse) Implements SRFurnitureMedic.Soap.getVendorsAsync
            Return MyBase.Channel.getVendorsAsync(request)
        End Function
        
        Public Function getVendorsAsync(ByVal inReadDate As Date) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getVendorsResponse)
            Dim inValue As SRFurnitureMedic.getVendorsRequest = New SRFurnitureMedic.getVendorsRequest()
            inValue.Body = New SRFurnitureMedic.getVendorsRequestBody()
            inValue.Body.inReadDate = inReadDate
            Return CType(Me,SRFurnitureMedic.Soap).getVendorsAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getPurchaseOrders(ByVal request As SRFurnitureMedic.getPurchaseOrdersRequest) As SRFurnitureMedic.getPurchaseOrdersResponse Implements SRFurnitureMedic.Soap.getPurchaseOrders
            Return MyBase.Channel.getPurchaseOrders(request)
        End Function
        
        Public Function getPurchaseOrders(ByVal inReadDate As Date) As SRFurnitureMedic.DocumentQueryBean
            Dim inValue As SRFurnitureMedic.getPurchaseOrdersRequest = New SRFurnitureMedic.getPurchaseOrdersRequest()
            inValue.Body = New SRFurnitureMedic.getPurchaseOrdersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Dim retVal As SRFurnitureMedic.getPurchaseOrdersResponse = CType(Me,SRFurnitureMedic.Soap).getPurchaseOrders(inValue)
            Return retVal.Body.getPurchaseOrdersReturn
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getPurchaseOrdersAsync(ByVal request As SRFurnitureMedic.getPurchaseOrdersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getPurchaseOrdersResponse) Implements SRFurnitureMedic.Soap.getPurchaseOrdersAsync
            Return MyBase.Channel.getPurchaseOrdersAsync(request)
        End Function
        
        Public Function getPurchaseOrdersAsync(ByVal inReadDate As Date) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getPurchaseOrdersResponse)
            Dim inValue As SRFurnitureMedic.getPurchaseOrdersRequest = New SRFurnitureMedic.getPurchaseOrdersRequest()
            inValue.Body = New SRFurnitureMedic.getPurchaseOrdersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Return CType(Me,SRFurnitureMedic.Soap).getPurchaseOrdersAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getSalesOrders(ByVal request As SRFurnitureMedic.getSalesOrdersRequest) As SRFurnitureMedic.getSalesOrdersResponse Implements SRFurnitureMedic.Soap.getSalesOrders
            Return MyBase.Channel.getSalesOrders(request)
        End Function
        
        Public Function getSalesOrders(ByVal inReadDate As Date) As SRFurnitureMedic.DocumentQueryBean
            Dim inValue As SRFurnitureMedic.getSalesOrdersRequest = New SRFurnitureMedic.getSalesOrdersRequest()
            inValue.Body = New SRFurnitureMedic.getSalesOrdersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Dim retVal As SRFurnitureMedic.getSalesOrdersResponse = CType(Me,SRFurnitureMedic.Soap).getSalesOrders(inValue)
            Return retVal.Body.getSalesOrdersReturn
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getSalesOrdersAsync(ByVal request As SRFurnitureMedic.getSalesOrdersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getSalesOrdersResponse) Implements SRFurnitureMedic.Soap.getSalesOrdersAsync
            Return MyBase.Channel.getSalesOrdersAsync(request)
        End Function
        
        Public Function getSalesOrdersAsync(ByVal inReadDate As Date) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getSalesOrdersResponse)
            Dim inValue As SRFurnitureMedic.getSalesOrdersRequest = New SRFurnitureMedic.getSalesOrdersRequest()
            inValue.Body = New SRFurnitureMedic.getSalesOrdersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Return CType(Me,SRFurnitureMedic.Soap).getSalesOrdersAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getCustomers(ByVal request As SRFurnitureMedic.getCustomersRequest) As SRFurnitureMedic.getCustomersResponse Implements SRFurnitureMedic.Soap.getCustomers
            Return MyBase.Channel.getCustomers(request)
        End Function
        
        Public Function getCustomers(ByVal inReadDate As Date) As SRFurnitureMedic.DocumentQueryBean
            Dim inValue As SRFurnitureMedic.getCustomersRequest = New SRFurnitureMedic.getCustomersRequest()
            inValue.Body = New SRFurnitureMedic.getCustomersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Dim retVal As SRFurnitureMedic.getCustomersResponse = CType(Me,SRFurnitureMedic.Soap).getCustomers(inValue)
            Return retVal.Body.getCustomersReturn
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function SRFurnitureMedic_Soap_getCustomersAsync(ByVal request As SRFurnitureMedic.getCustomersRequest) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getCustomersResponse) Implements SRFurnitureMedic.Soap.getCustomersAsync
            Return MyBase.Channel.getCustomersAsync(request)
        End Function
        
        Public Function getCustomersAsync(ByVal inReadDate As Date) As System.Threading.Tasks.Task(Of SRFurnitureMedic.getCustomersResponse)
            Dim inValue As SRFurnitureMedic.getCustomersRequest = New SRFurnitureMedic.getCustomersRequest()
            inValue.Body = New SRFurnitureMedic.getCustomersRequestBody()
            inValue.Body.inReadDate = inReadDate
            Return CType(Me,SRFurnitureMedic.Soap).getCustomersAsync(inValue)
        End Function
    End Class
End Namespace
