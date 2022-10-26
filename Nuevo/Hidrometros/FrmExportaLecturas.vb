Imports System.IO
Imports DevComponents.DotNetBar

'Imports Micevigma.basededatos
Public Class FrmExportaLecturas
    'Public base As New Micevigma.basededatos

    Private Sub FrmExportaLecturas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus

        MDIPrincipal.RBHidrometros.Select()
    End Sub

    Private Sub ExportaLecturas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub ExportaLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IIPeriodo.Value = Year(Now)
        Try
            llenarCombo(CmbRegion, "select id_region, region from region  order by region")
        Catch ex As Exception
        End Try


        'txtObs.Text = obtenerCampo("select mensaje from mensajeterminal where idmensaje=1", "mensaje")
        'txtVen1.Text = obtenerCampo("select mensaje from mensajeterminal where idmensaje=2", "mensaje")
        'txtmenCance1.Text = obtenerCampo("select mensaje from mensajeterminal where idmensaje=3", "mensaje")
        'txtMenAgra.Text = obtenerCampo("select mensaje from mensajeterminal where idmensaje=4", "mensaje")
    End Sub
    Private Sub CmbComunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    'Private Sub CmbComunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbComunidad.KeyPress
    '    'DespliegaCombo(CmbComunidad, e)
    'End Sub


    'Private Sub CmdRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmdRegion.KeyPress
    '    'DespliegaCombo(CmdRegion, e)
    'End Sub
    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub
    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        Dim dirDes As String = ""
        Dim rutas As String = ""
        If CmbMes.SelectedIndex = -1 Then
            MessageBoxEx.Show("No seleccionaste un mes valido")
            Exit Sub
        End If


        Ejecucion("update mensajeterminal set mensaje='" & txtObs.Text & "' where idmensaje=1")
        Ejecucion("update mensajeterminal set mensaje='" & txtVen1.Text & "' where idmensaje=2")
        Ejecucion("update mensajeterminal set mensaje='" & txtmenCance1.Text & "' where idmensaje=3")
        Ejecucion("update mensajeterminal set mensaje='" & txtMenAgra.Text & "' where idmensaje=4")
        If CmbRegion.SelectedIndex = -1 Then
            MessageBoxEx.Show("No especificaste la Comunidad necesaria", "Exportar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbRegion.Select()
            BtnCalcular.Enabled = True
            BtnSalir.Enabled = True
            Exit Sub
        End If
        'If cmbRuta.SelectedIndex = -1 Then
        '    MessageBoxEx.Show("No especificaste la Region necesaria", "Exportar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    cmbRuta.Select()
        '    BtnCalcular.Enabled = True
        '    BtnSalir.Enabled = True
        '    Exit Sub
        'End If
        'If cmbRuta.SelectedIndex = -1 Then
        '    MessageBoxEx.Show("Indique la ruta, por favor", "Exportar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cmbRuta.Select()
        '    BtnCalcular.Enabled = True
        '    BtnSalir.Enabled = True
        '    Exit Sub
        'End If
        If chkRutas.CheckedItems.Count = 0 Then
            MessageBoxEx.Show("Seleccione por lo menos una ruta, por favor", "Exportar lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            chkRutas.Select()
            Exit Sub
        End If
        For i = 0 To chkRutas.CheckedItems.Count - 1
            rutas &= String.Concat("'", chkRutas.CheckedItems(i).Name, "', ")
        Next
        rutas = Mid(rutas, 1, rutas.Length - 2)
        Folderdialogo.ShowDialog()
        If Not Folderdialogo.SelectedPath = "" Then
            dirDes = Folderdialogo.SelectedPath & "\"
            BtnCalcular.Enabled = False
            BtnSalir.Enabled = False

            'ClsLecturas.Exportar(PB, CmbRegion.SelectedValue.ToString, CmbRuta.SelectedValue.ToString, rutas, dirDes)
            ClsLecturas.Exportar(PB, CmbRegion.SelectedValue.ToString, rutas, dirDes, CmbMes.Text, IIPeriodo.Value)
        End If
        BtnCalcular.Enabled = True
        BtnSalir.Enabled = True
        Close()
    End Sub
    Private Sub BtnCalcular_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCalcular.GotFocus
        BtnCalcular.Pulse()
        BtnCalcular.StopPulseOnMouseOver = False
    End Sub
    Private Sub BtnCalcular_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCalcular.LostFocus
        BtnCalcular.StopPulse()
    End Sub
    Private Sub BtnSalir_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSalir.GotFocus
        BtnSalir.Pulse()
        BtnSalir.StopPulseOnMouseOver = False
    End Sub
    Private Sub BtnSalir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSalir.LostFocus
        BtnSalir.StopPulse()
    End Sub
    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim archivo As String
        SuperTooltip1.ShowTooltip(New Object())
        Folderdialogo.ShowDialog()
        archivo = Folderdialogo.SelectedPath
        If MessageBoxEx.Show("¿Este proceso borrara todos los datos de la terminal, estas seguro? ", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            archivo = archivo & "\lecturasce.sdf"
            'Try
            '    base.archivo = archivo
            '    base.crearbase()

            'Catch ex As Exception
            '    MessageBoxEx.Show(ex.Message)
            'End Try
        End If
    End Sub
    Private Sub CmdRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub CmdRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not CmbComunidad.SelectedValue Is Nothing AndAlso Not CmdRegion.SelectedValue Is Nothing AndAlso Not CmbComunidad.SelectedValue.ToString = "System.Data.DataRowView" AndAlso Not CmdRegion.SelectedValue.ToString = "System.Data.DataRowView" Then
        '    llenarCombo(cmbRuta, "select id_ruta, ruta from rutas where id_comunidad='" & CmbComunidad.SelectedValue.ToString & "' and id_region='" & CmdRegion.SelectedValue.ToString & "' order by ruta")
        'End If
        If Not CmbRegion.SelectedValue Is Nothing Then
            Dim idruta As IDataReader = ConsultaSql("select id_ruta, ruta from rutas where  and id_region='" & CmbRegion.SelectedValue.ToString & "' order by ruta").ExecuteReader()
            chkRutas.Items.Clear()
            While idruta.Read()
                chkRutas.Items.Add(idruta("id_ruta"), idruta("ruta"), 0)
            End While
        End If
    End Sub



    Private Sub CmbRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRegion.SelectedIndexChanged
        'Try
        '    llenarCombo(CmbRuta, "select id_ruta, ruta from rutas where id_region = '" & CmbRegion.SelectedValue.ToString & "'  order by ruta")
        'Catch ex As Exception
        'End Try


        If Not CmbRegion.SelectedValue Is Nothing Then
            Dim idruta As IDataReader = ConsultaSql("select id_ruta, ruta from rutas where id_region='" & CmbRegion.SelectedValue.ToString & "' order by ruta").ExecuteReader()
            chkRutas.Items.Clear()
            While idruta.Read()
                chkRutas.Items.Add(idruta("id_ruta"), idruta("ruta"), 0)
            End While
        End If


    End Sub
End Class