﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("DSn=AGUA")>  _
        Public ReadOnly Property baseaguaConnectionString() As String
            Get
                Return CType(Me("baseaguaConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("porcsanea")>  _
        Public Property Porcentajedesaneamiento() As String
            Get
                Return CType(Me("Porcentajedesaneamiento"),String)
            End Get
            Set
                Me("Porcentajedesaneamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("saneacuo")>  _
        Public Property camposaneamiento() As String
            Get
                Return CType(Me("camposaneamiento"),String)
            End Get
            Set
                Me("camposaneamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PorcAlca")>  _
        Public Property campoalcantarillo() As String
            Get
                Return CType(Me("campoalcantarillo"),String)
            End Get
            Set
                Me("campoalcantarillo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("cuotas")>  _
        Public Property tablacuotas() As String
            Get
                Return CType(Me("tablacuotas"),String)
            End Get
            Set
                Me("tablacuotas") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ALCANTARILLADO")>  _
        Public Property booleanalcantarillado() As String
            Get
                Return CType(Me("booleanalcantarillado"),String)
            End Get
            Set
                Me("booleanalcantarillado") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("IVA")>  _
        Public Property booleanIVA() As String
            Get
                Return CType(Me("booleanIVA"),String)
            End Get
            Set
                Me("booleanIVA") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("RECARGOS")>  _
        Public Property booleanrecargos() As String
            Get
                Return CType(Me("booleanrecargos"),String)
            End Get
            Set
                Me("booleanrecargos") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("alcapcuo")>  _
        Public Property booleancobrarfijoalcantarillado() As String
            Get
                Return CType(Me("booleancobrarfijoalcantarillado"),String)
            End Get
            Set
                Me("booleancobrarfijoalcantarillado") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("PorcAlca")>  _
        Public Property Porcentajedealcantarillado() As String
            Get
                Return CType(Me("Porcentajedealcantarillado"),String)
            End Get
            Set
                Me("Porcentajedealcantarillado") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("saneacuo")>  _
        Public Property booleansaneamiento() As String
            Get
                Return CType(Me("booleansaneamiento"),String)
            End Get
            Set
                Me("booleansaneamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("sanepcuo")>  _
        Public Property booleancobrarfijosaneamiento() As String
            Get
                Return CType(Me("booleancobrarfijosaneamiento"),String)
            End Get
            Set
                Me("booleancobrarfijosaneamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("VALVUL")>  _
        Public Property clavevalvulista() As String
            Get
                Return CType(Me("clavevalvulista"),String)
            End Get
            Set
                Me("clavevalvulista") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("SI")>  _
        Public Property cobrarvalvulista() As String
            Get
                Return CType(Me("cobrarvalvulista"),String)
            End Get
            Set
                Me("cobrarvalvulista") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("medido")>  _
        Public Property booleanmedido() As String
            Get
                Return CType(Me("booleanmedido"),String)
            End Get
            Set
                Me("booleanmedido") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-4")>  _
        Public Property Clavedeconsumo() As String
            Get
                Return CType(Me("Clavedeconsumo"),String)
            End Get
            Set
                Me("Clavedeconsumo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-6")>  _
        Public Property Clavedealcantarillado() As String
            Get
                Return CType(Me("Clavedealcantarillado"),String)
            End Get
            Set
                Me("Clavedealcantarillado") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-7")>  _
        Public Property clavedesaneamiento() As String
            Get
                Return CType(Me("clavedesaneamiento"),String)
            End Get
            Set
                Me("clavedesaneamiento") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-3")>  _
        Public Property Clavederecargo() As String
            Get
                Return CType(Me("Clavederecargo"),String)
            End Get
            Set
                Me("Clavederecargo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-26")>  _
        Public Property Clavedeiva() As String
            Get
                Return CType(Me("Clavedeiva"),String)
            End Get
            Set
                Me("Clavedeiva") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("-14")>  _
        Public Property ClavedeRezago() As String
            Get
                Return CType(Me("ClavedeRezago"),String)
            End Get
            Set
                Me("ClavedeRezago") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("100")>  _
        Public Property TopeRecargo() As String
            Get
                Return CType(Me("TopeRecargo"),String)
            End Get
            Set
                Me("TopeRecargo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("periodo")>  _
        Public Property campoano() As String
            Get
                Return CType(Me("campoano"),String)
            End Get
            Set
                Me("campoano") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("tarifa")>  _
        Public Property campotarifa() As String
            Get
                Return CType(Me("campotarifa"),String)
            End Get
            Set
                Me("campotarifa") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("pago_agua")>  _
        Public Property campoaguafija() As String
            Get
                Return CType(Me("campoaguafija"),String)
            End Get
            Set
                Me("campoaguafija") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("tarifa")>  _
        Public Property campousuariotarifa() As String
            Get
                Return CType(Me("campousuariotarifa"),String)
            End Get
            Set
                Me("campousuariotarifa") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dsn=agua")>  _
        Public ReadOnly Property baseaguaConnectionString1() As String
            Get
                Return CType(Me("baseaguaConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Comercial")>  _
        Public Property usuarioreporte() As String
            Get
                Return CType(Me("usuarioreporte"),String)
            End Get
            Set
                Me("usuarioreporte") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Comercial_01")>  _
        Public Property passreporte() As String
            Get
                Return CType(Me("passreporte"),String)
            End Get
            Set
                Me("passreporte") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("agua_ajacuba")>  _
        Public Property basereporte() As String
            Get
                Return CType(Me("basereporte"),String)
            End Get
            Set
                Me("basereporte") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Agua")>  _
        Public Property servidorreporte() As String
            Get
                Return CType(Me("servidorreporte"),String)
            End Get
            Set
                Me("servidorreporte") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("NO")>  _
        Public Property CombodeCalles() As String
            Get
                Return CType(Me("CombodeCalles"),String)
            End Get
            Set
                Me("CombodeCalles") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("779")>  _
        Public Property conceptofactibilidad() As String
            Get
                Return CType(Me("conceptofactibilidad"),String)
            End Get
            Set
                Me("conceptofactibilidad") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("20")>  _
        Public Property conceptocobrofactibilidad() As String
            Get
                Return CType(Me("conceptocobrofactibilidad"),String)
            End Get
            Set
                Me("conceptocobrofactibilidad") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("CSA")>  _
        Public Property claveConvenio() As String
            Get
                Return CType(Me("claveConvenio"),String)
            End Get
            Set
                Me("claveConvenio") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property IDComunidadSistema() As String
            Get
                Return CType(Me("IDComunidadSistema"),String)
            End Get
            Set
                Me("IDComunidadSistema") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\Server\Documents\DocumentosLeon")>  _
        Public Property RutaDoctos() As String
            Get
                Return CType(Me("RutaDoctos"),String)
            End Get
            Set
                Me("RutaDoctos") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Program Files (x86)\Vigma Consultores\Mapa\sig.exe")>  _
        Public Property RutaModuloMapa() As String
            Get
                Return CType(Me("RutaModuloMapa"),String)
            End Get
            Set
                Me("RutaModuloMapa") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Dsn=AguaGeneral")>  _
        Public ReadOnly Property ConnectionStringGeneral() As String
            Get
                Return CType(Me("ConnectionStringGeneral"),String)
            End Get
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Administativo.My.MySettings
            Get
                Return Global.Administativo.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
