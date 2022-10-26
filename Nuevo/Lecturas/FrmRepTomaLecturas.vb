Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar
Imports System.Data.Odbc
Public Class FrmRepTomaLecturas

    Private Sub FrmRepTomaLecturas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabFacturacion.Select()
    End Sub

    Private Sub FrmRepTomaLecturas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub FrmRepTomaLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            llenarCombo(CmbRegion, "select id_region, region from region  order by region")
            llenarCombo(cmbtipousuario, "select id_tarifa, descripcion_cuota from cuotas")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim tarifa As String = ""
        Dim TIT As String = ""
        Dim conm As String = ""
        Dim FILTRO As String = " cuotas.medido=1"
        Dim condicion As String = " {cuotas1.medido}=1 "
        If CmbRegion.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste la Región", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRegion.Select()
            Exit Sub
        End If

        If CmbRuta.SelectedIndex < 0 Then
            MessageBoxEx.Show("No especificaste una", "Reporte de Toma de lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRuta.Select()
            Exit Sub
        End If
        BtnImprimir.Enabled = False




        BtnSalir.Enabled = False

        CmbRuta.Enabled = False
        cmbtipousuario.Enabled = False
        CmbRegion.Enabled = False
        'MessageBoxEx.Show("Espere un momento por favor, se esta generando el reporte", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LblEspera.Text = "Espere un momento por favor, se esta generando el reporte"
        LblEspera.Visible = True


        Dim Lectura As New ClsLecturas
        Lectura.Region = CmbRegion.SelectedValue.ToString

        Try
            Lectura.Ruta = CmbRuta.SelectedValue.ToString
        Catch ex As Exception
            Lectura.Ruta = ""
        End Try
        If cmbtipousuario.SelectedIndex >= 0 Then
            tarifa = cmbtipousuario.SelectedValue
        End If

        TIT = " REGION: " & CmbRegion.Text & "  RUTA: " & CmbRuta.Text

        If tarifa <> "" Then
            TIT = TIT + " TARIFA : " & cmbtipousuario.Text
        End If

        If chkmedidor.Checked Then
            conm = " and {vUSUARIO.nodemedidor}<>''"

        End If


        If cmbtipousuario.Text = "" Then

            FILTRO = FILTRO & " and vUSUARIO1.region='" & CmbRegion.SelectedValue & "' and vUSUARIO1.ruta= '" & CmbRuta.SelectedValue & "' " & conm
            condicion = condicion & " and  {vUSUARIO1.region}='" & CmbRegion.SelectedValue & "' and {vUSUARIO1.ruta}= '" & CmbRuta.SelectedValue & "' " & conm
        Else

            FILTRO = FILTRO & " and vUSUARIO1.region='" & CmbRegion.SelectedValue & "' and vUSUARIO1.ruta= '" & CmbRuta.SelectedValue & "'  AND vUSUARIO.TARIFA='" & cmbtipousuario.Text & "' " & conm
            condicion = condicion & " and {vUSUARIO1.numlec} >0 and {vUSUARIO1.region}='" & CmbRegion.SelectedValue & "' and {vUSUARIO1.ruta}= '" & CmbRuta.SelectedValue & "'  AND {vUSUARIO1.TARIFA}='" & tarifa & "' " & conm
        End If



        Dim sql As String
        sql = "SELECT * FROM vusuario as vUSUARIO1,cuotas WHERE vusuario1.tarifa=cuotas.id_tarifa and " & FILTRO & " ORDER BY LOTE, CUENTA"


        Try
            Application.DoEvents()
            Dim ir As IDataReader = ConsultaSql(sql).ExecuteReader
            ir.Read()

            Ejecucion("Update rutas set TomaLec = 'S' where id_region = '" & CmbRegion.SelectedValue & "' AND Id_ruta = '" & CmbRuta.SelectedValue & "'")
        Catch ex As Exception
            MessageBox.Show("No hay registros para el reporte que pides")
            BtnImprimir.Enabled = True
            BtnSalir.Enabled = True
            Exit Sub
        End Try





        '  Lectura.NumerarTomas(tarifa, chkmedidor.Checked)

        Dim reporte As New ReportDocument()
        'Dim DR As New dtsDatosReporte()
        Dim DT, DT2, DT3 As New DataTable()
        Dim DATAS As New DataSet

        'DatosReporte(sql, DATAS, "VUSUARIO1")


        'Dim EMPRESA As String = "SELECT * FROM EMPRESA AS EMPRESA1 LIMIT 1"


        'DatosReporte(EMPRESA, DATAS, "EMPRESA1")



        'Dim RUTA As String = " SELECT * FROM RUTAS AS RUTAS1"


        'DatosReporte(RUTA, DATAS, "RUTAS1")



        reporte.Load(".\reportes\ListaLecturas.rpt")

        Dim servidorreporte As String = My.Settings.servidorreporte
        Dim usuarioreporte As String = My.Settings.usuarioreporte
        Dim passreporte As String = My.Settings.passreporte
        Dim basereporte As String = My.Settings.basereporte

        reporte.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
        reporte.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

        'reporte.SetDataSource(DATAS)
        reporte.DataDefinition.FormulaFields("Titulo").Text = "'" & TIT & "'"
        reporte.RecordSelectionFormula = condicion.ToLower()

        Dim x As New frmReporte()
        x.crvReporte.ReportSource = reporte
        x.Show()
        BtnImprimir.Enabled = True
        BtnSalir.Enabled = True

        CmbRuta.Enabled = True
        CmbRegion.Enabled = True
        cmbtipousuario.Enabled = True
        LblEspera.Visible = False
    End Sub


    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        Try
            llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region = '" & CmbRegion.SelectedValue.ToString & "' order by ruta")
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DatosReporte(ByVal sql As String, ByVal _Ds As DataSet, ByVal titulo As String)
        Dim conn As OdbcConnection
        conn = New OdbcConnection(My.Settings.baseaguaConnectionString)
        Dim comando As OdbcCommand
        Dim Adapt As OdbcDataAdapter
        'Dim DS As DataSet

        Try
            conn.Open()
            comando = New OdbcCommand(sql.ToLower(), conn)
            Adapt = New OdbcDataAdapter(comando)
            '   DS = New DataSet
            Adapt.Fill(_Ds, titulo)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'Return DS.Tables(0)

    End Sub

End Class