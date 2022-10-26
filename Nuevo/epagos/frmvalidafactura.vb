Imports System.Data.Odbc
Imports System.IO

Imports System.Net
Imports System.Net.Mail

Imports System.Text
Imports System.Text.RegularExpressions


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.Shared
Imports MultiFacturasSDK


Public Class Frmvalidafactura
    Public recibo As New clsrecibo
    Public control As New Clscontrolpago

    Private archivotexto As String
    Private archivopdf As String
    Private strStreamW As Stream = Nothing
    Private strStreamWriter As StreamWriter = Nothing

    Public subtotal As Double
    Public iva As Double
    Public total As Double

    Public cuenta As Integer
    Public TIPO As String

    Public quehacer As String = "INSERTAR"
    Public facturado As Long = 0 ' para factupronto
    Public formafacturado As String

    Public actualizarfecha As Boolean = True
    Public seriefactura As String = "" ' para multifacturas 
    Public foliofactura As Long = 0 ' para multifacturas
    Public vienede As String = "CAJA"


    Public Reciboqueseestafacturando As Int32 = 0


    Private dts As OdbcDataReader
    Private Sub Frmvalidafactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'basem.conexion.Dispose()
    End Sub

    
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

    End Sub


    Private Sub BTNGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGUARDAR.Click
        Dim CADENA As String = "", cadena2 As String = String.Empty

        If validarEmail(txtmail.Text) = True Then

            Select Case quehacer
                Case "INSERTAR"
                    CADENA = "INSERT INTO datosfiscales SET TIPO='" & TIPO & "', CUENTA=" & cuenta & ","
                Case "ACTUALIZAR"
                    CADENA = "UPDATE datosfiscales SET "

            End Select
            CADENA = CADENA & " NOMBRE ='" & txtnombre.Text & "', CALLE='" & txtcalle.Text & "',NUMEXT='" & txtnumext.Text & "', NUMINT ='" & txtnuminterior.Text & "', COLONIA='" & txtcolonia.Text & "', POBLACION='" & txtpoblacion.Text & "' , DELEGACION='" & txtdelegacion.Text & "', ESTADO='" & txtestado.Text & "', PAIS='" & txtPais.Text & "', CP='" & txtcp.Text & "',RFC='" & txtrfc.Text & "', MAILdeenvio='" & txtmail.Text & "' , rfcbanco='" & cmbbanco.SelectedValue & "', cuentabancaria='" & txtcuentabancaria.Text & "' "

            If quehacer = "ACTUALIZAR" Then
                CADENA = CADENA & " WHERE CUENTA=" & cuenta & " AND TIPO ='" & TIPO & "'"
            End If
            If cmbbanco.SelectedIndex >= 0 Then
                cadena2 = "updatate datosfiscales set rfcbanco='" & cmbbanco.SelectedValue & "', cuentabancaria='" & txtcuentabancaria.Text & "' WHERE CUENTA=" & cuenta & " AND TIPO ='" & TIPO & "'"
            End If
            Ejecucion(CADENA)
            If cadena2 <> String.Empty Then
                Try
                    Ejecucion(cadena2)
                Catch ex As Exception

                End Try
            End If

        Else
            MsgBox("El e-mail no es correcto, favor de validarlo o ingresarlo nuevamente.")
        End If

    
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Close()
    End Sub

    Public Sub grabarfactura()


    End Sub


    ' graba el recibo 25/10/2016
    Public Sub grabar()

    End Sub


    Public Sub Timbrar()


    End Sub ' para multifacturas

    Public Sub ExportToDisk(ByVal fileName As String, ByVal Reporte As ReportDocument)
        ' Declare variables and get the export options.
        Dim exportOpts As New ExportOptions()
        Dim diskOpts As New DiskFileDestinationOptions()
        exportOpts = Reporte.ExportOptions

        ' Set the export format.
        exportOpts.ExportFormatType = ExportFormatType.PortableDocFormat

        exportOpts.ExportDestinationType = ExportDestinationType.DiskFile

        ' Set the disk file options.
        diskOpts.DiskFileName = fileName
        exportOpts.DestinationOptions = diskOpts

        ' Export the report.
        Reporte.Export()

       

    End Sub ' exporta a un archivo pdf


    Public Function validarEmail(ByVal correo) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(correo) Then
            Return True
        Else
            Return False
        End If
    End Function

    'convierte una imagen en byte para poderlo poner en crystal report datamatrix


End Class
