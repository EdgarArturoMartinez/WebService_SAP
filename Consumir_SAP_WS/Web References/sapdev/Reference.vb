﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.18444
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.18444.
'
Namespace sapdev
    
    'CODEGEN: No se controló el elemento de extensión WSDL opcional 'Policy' del espacio de nombres 'http://schemas.xmlsoap.org/ws/2004/09/policy'.
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="ZFICL_CONTRATO", [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZFICL_CONTRATO
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private ZficlContratoOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Consumir_SAP_WS.My.MySettings.Default.Consumir_SAP_WS_sapdev_zficl_contrato
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event ZficlContratoCompleted As ZficlContratoCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:sap-com:document:sap:soap:functions:mc-style:zficl_contrato:ZficlContratoRequ"& _ 
            "est", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>  _
        Public Function ZficlContrato(<System.Xml.Serialization.XmlElementAttribute("ZficlContrato", [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")> ByVal ZficlContrato1 As ZficlContrato) As <System.Xml.Serialization.XmlElementAttribute("ZficlContratoResponse", [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")> ZficlContratoResponse
            Dim results() As Object = Me.Invoke("ZficlContrato", New Object() {ZficlContrato1})
            Return CType(results(0),ZficlContratoResponse)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ZficlContratoAsync(ByVal ZficlContrato1 As ZficlContrato)
            Me.ZficlContratoAsync(ZficlContrato1, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ZficlContratoAsync(ByVal ZficlContrato1 As ZficlContrato, ByVal userState As Object)
            If (Me.ZficlContratoOperationCompleted Is Nothing) Then
                Me.ZficlContratoOperationCompleted = AddressOf Me.OnZficlContratoOperationCompleted
            End If
            Me.InvokeAsync("ZficlContrato", New Object() {ZficlContrato1}, Me.ZficlContratoOperationCompleted, userState)
        End Sub
        
        Private Sub OnZficlContratoOperationCompleted(ByVal arg As Object)
            If (Not (Me.ZficlContratoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ZficlContratoCompleted(Me, New ZficlContratoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZficlContrato
        
        Private itDatosField() As ZficlDatos
        
        Private itReturnField() As Bapireturn1
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property ItDatos() As ZficlDatos()
            Get
                Return Me.itDatosField
            End Get
            Set
                Me.itDatosField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property ItReturn() As Bapireturn1()
            Get
                Return Me.itReturnField
            End Get
            Set
                Me.itReturnField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZficlDatos
        
        Private mandtField As String
        
        Private bukrsField As String
        
        Private tipoconField As String
        
        Private contratoField As String
        
        Private nitField As String
        
        Private tiponitField As String
        
        Private nombre1Field As String
        
        Private nombre2Field As String
        
        Private apell1Field As String
        
        Private apell2Field As String
        
        Private dirField As String
        
        Private telefField As String
        
        Private emailField As String
        
        Private ciudadField As String
        
        Private depbenField As String
        
        Private deprecField As String
        
        Private valorSinivaField As Decimal
        
        Private ivaField As Decimal
        
        Private feciniField As String
        
        Private fefinField As String
        
        Private regionField As String
        
        Private paisField As String
        
        Private augblField As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Mandt() As String
            Get
                Return Me.mandtField
            End Get
            Set
                Me.mandtField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Bukrs() As String
            Get
                Return Me.bukrsField
            End Get
            Set
                Me.bukrsField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Tipocon() As String
            Get
                Return Me.tipoconField
            End Get
            Set
                Me.tipoconField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Contrato() As String
            Get
                Return Me.contratoField
            End Get
            Set
                Me.contratoField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Nit() As String
            Get
                Return Me.nitField
            End Get
            Set
                Me.nitField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Tiponit() As String
            Get
                Return Me.tiponitField
            End Get
            Set
                Me.tiponitField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Nombre1() As String
            Get
                Return Me.nombre1Field
            End Get
            Set
                Me.nombre1Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Nombre2() As String
            Get
                Return Me.nombre2Field
            End Get
            Set
                Me.nombre2Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Apell1() As String
            Get
                Return Me.apell1Field
            End Get
            Set
                Me.apell1Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Apell2() As String
            Get
                Return Me.apell2Field
            End Get
            Set
                Me.apell2Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Dir() As String
            Get
                Return Me.dirField
            End Get
            Set
                Me.dirField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Telef() As String
            Get
                Return Me.telefField
            End Get
            Set
                Me.telefField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Email() As String
            Get
                Return Me.emailField
            End Get
            Set
                Me.emailField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Ciudad() As String
            Get
                Return Me.ciudadField
            End Get
            Set
                Me.ciudadField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Depben() As String
            Get
                Return Me.depbenField
            End Get
            Set
                Me.depbenField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Deprec() As String
            Get
                Return Me.deprecField
            End Get
            Set
                Me.deprecField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property ValorSiniva() As Decimal
            Get
                Return Me.valorSinivaField
            End Get
            Set
                Me.valorSinivaField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Iva() As Decimal
            Get
                Return Me.ivaField
            End Get
            Set
                Me.ivaField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Fecini() As String
            Get
                Return Me.feciniField
            End Get
            Set
                Me.feciniField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Fefin() As String
            Get
                Return Me.fefinField
            End Get
            Set
                Me.fefinField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Region() As String
            Get
                Return Me.regionField
            End Get
            Set
                Me.regionField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Pais() As String
            Get
                Return Me.paisField
            End Get
            Set
                Me.paisField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Augbl() As String
            Get
                Return Me.augblField
            End Get
            Set
                Me.augblField = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class Bapireturn1
        
        Private typeField As String
        
        Private idField As String
        
        Private numberField As String
        
        Private messageField As String
        
        Private logNoField As String
        
        Private logMsgNoField As String
        
        Private messageV1Field As String
        
        Private messageV2Field As String
        
        Private messageV3Field As String
        
        Private messageV4Field As String
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Type() As String
            Get
                Return Me.typeField
            End Get
            Set
                Me.typeField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Id() As String
            Get
                Return Me.idField
            End Get
            Set
                Me.idField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Number() As String
            Get
                Return Me.numberField
            End Get
            Set
                Me.numberField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property Message() As String
            Get
                Return Me.messageField
            End Get
            Set
                Me.messageField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LogNo() As String
            Get
                Return Me.logNoField
            End Get
            Set
                Me.logNoField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property LogMsgNo() As String
            Get
                Return Me.logMsgNoField
            End Get
            Set
                Me.logMsgNoField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MessageV1() As String
            Get
                Return Me.messageV1Field
            End Get
            Set
                Me.messageV1Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MessageV2() As String
            Get
                Return Me.messageV2Field
            End Get
            Set
                Me.messageV2Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MessageV3() As String
            Get
                Return Me.messageV3Field
            End Get
            Set
                Me.messageV3Field = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property MessageV4() As String
            Get
                Return Me.messageV4Field
            End Get
            Set
                Me.messageV4Field = value
            End Set
        End Property
    End Class
    
    '''<comentarios/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="urn:sap-com:document:sap:soap:functions:mc-style")>  _
    Partial Public Class ZficlContratoResponse
        
        Private itDatosField() As ZficlDatos
        
        Private itReturnField() As Bapireturn1
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property ItDatos() As ZficlDatos()
            Get
                Return Me.itDatosField
            End Get
            Set
                Me.itDatosField = value
            End Set
        End Property
        
        '''<comentarios/>
        <System.Xml.Serialization.XmlArrayAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified),  _
         System.Xml.Serialization.XmlArrayItemAttribute("item", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable:=false)>  _
        Public Property ItReturn() As Bapireturn1()
            Get
                Return Me.itReturnField
            End Get
            Set
                Me.itReturnField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub ZficlContratoCompletedEventHandler(ByVal sender As Object, ByVal e As ZficlContratoCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ZficlContratoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As ZficlContratoResponse
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),ZficlContratoResponse)
            End Get
        End Property
    End Class
End Namespace
