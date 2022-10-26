Imports System.IO
Imports Microsoft.VisualBasic

Public Class Formulario
    Dim Destino As String = String.Empty

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        cmbcaja.Visible = False
        llenarCombo(cmbcaja, "select ID_caja,Descripcion  from cajas where Tcaja='Remota'")
        lblcaja.Visible = False
        lblfolio.Visible = False
        txtfolio.Visible = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click

        DataPagos.Rows.Clear()
        cmbcaja.Visible = False

        lblcaja.Visible = False
        lblfolio.Visible = False
        txtfolio.Visible = False
        PG.Visible = True
        PG.Maximum = 1
        PG.Value = 0
        Dim DirGen As String = String.Empty
        OpenFileDialog1.Filter = "Excel Files(.xls)|*.xls| Archivos de Excel (.xlsx)|*.xlsx| Archivos de excel(*.xlsm)|*.xlsm"
        OpenFileDialog1.FileName = Destino
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.ShowDialog()
        '  Archivo = Directorio & "\" & "Importacion" & CmbOficina.SelectedValue.ToString & "-" & CmbCaja.SelectedValue.ToString & "-" & Format(Fecha.Day, "00") & "-" & Format(Fecha.Month, "00") & "-" & Fecha.Year & ".txt"
        Destino = DirGen & "\" & Path.GetFileName(OpenFileDialog1.FileName)
        PG.Text = Destino

        Imagen.Visible = True
        Dim vFileName As String = OpenFileDialog1.FileName
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open(vFileName)


        'Add data to cells of the first worksheet in the new workbook
        oSheet = oBook.Worksheets(1)

        Dim Fecha As String = Now.ToString()
        Dim cuenta As String = "0"
        Dim total As String = "0"
        Dim Pago As String = "0"
        Dim referencia As String = String.Empty

        Dim linea As Integer = 2

        Try
            Do While Not oSheet.Range("A" & linea).value.ToString().Contains("oSheet.Range")
                Fecha = oSheet.Range("A" & linea).Value
                cuenta = oSheet.Range("C" & linea).Value
                total = oSheet.Range("D" & linea).Value
                total = Decimal.Parse(total).ToString("C2")
                referencia = oSheet.Range("E" & linea).Value
                Dim Nombre As String = obtenerCampo("select nombre From usuario where cuenta=" & cuenta, "nombre")
                If Nombre = "0" Then Nombre = ""

                DataPagos.Rows.Add(Fecha, cuenta, Nombre, total, referencia)
                linea = linea + 1
            Loop


        Catch ex As Exception

        End Try




        'MessageBoxEx.Show("Archivo Copiado satisfactoriamente", "Copiar archivos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Imagen.Visible = False
        If DataPagos.Rows.Count >= 1 Then
            cmbcaja.Visible = True
            lblcaja.Visible = True
            txtfolio.Visible = True

            lblfolio.Visible = True
        End If

    End Sub

    Private Sub BtnAplicar_Click(sender As Object, e As EventArgs) Handles BtnAplicar.Click
        If txtservicio.Text = String.Empty Then
            MessageBox.Show("NO indicaste el nombre del servicio")
        End If

        Dim haber As String = obtenerCampo("Select If(EXISTS (Select SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = '" & txtservicio.Text & "'), 'S','N') as dato", "dato")
        If haber = "N" Or haber = "0" Then
            MessageBox.Show("No tengo registrado el servicio en el sistema verifica el nombre")
            Exit Sub
        End If

        If Destino = String.Empty Then
            MessageBox.Show("No seleccionaste un archivo")
            Exit Sub
        End If

        If DataPagos.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para aplicar")
            Exit Sub

        End If
        PG.Maximum = DataPagos.Rows.Count
        PG.Minimum = 1

        Dim folio As Integer = txtfolio.Value
        Dim pagos As New Clspagoenlinea
        For i = 0 To DataPagos.Rows.Count - 1
            Dim fecha As Date = DateTime.Parse(DataPagos.Rows(i).Cells(0).Value.ToString())
            Dim cuenta As Integer = Integer.Parse(DataPagos.Rows(i).Cells(1).Value.ToString())
            Dim referencia As String = (DataPagos.Rows(i).Cells(4).Value.ToString())
            PG.Value = i
            Dim pago As String = (DataPagos.Rows(i).Cells(4).Value.ToString())
            Dim formapago As String = "04"
            If pago.Length > 4 Then
                formapago = "03"
            End If
            pagos.pagarusuario(txtservicio.Text, My.Settings.basereporte, cuenta, folio, fecha, cmbcaja.SelectedValue, referencia, formapago)
            folio += 1
        Next
        MessageBox.Show("Se han generado los recibos")
    End Sub



    Public Sub pagar(cuenta As String)
        Dim cuentaapagar As Integer = Integer.Parse(cuenta)





    End Sub




    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub cmbcaja_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcaja.SelectedIndexChanged
        Try
            Dim folio As Integer = Integer.Parse(obtenerCampo("select max(recibo) as numeromax from pagos where caja=" & cmbcaja.SelectedValue, "numeromax")) + 1
            txtfolio.Value = folio
        Catch ex As Exception

        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked


        System.Diagnostics.Process.Start("https://www.adquiramexico.com.mx/bMunicipio/login")
    End Sub
End Class