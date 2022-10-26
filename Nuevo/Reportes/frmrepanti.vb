Public Class frmrepanti
    Private cargado As Boolean = False
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        cargado = False
        llenarCombo(cmbComu, "select id_comunidad,comunidad from comunidades order by comunidad")
        llenarCombo(cmbTipUso, "select id_tipo_usuario, descripcion from tipos_usuarios order by descripcion")
        cmbComu.Select()
        cargado = True
    End Sub

    Private Sub cmbComu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbComu.SelectedIndexChanged
        If Not IsNothing(cmbComu.SelectedValue) AndAlso cargado Then
            If cmbComu.SelectedValue.ToString = "System.Data.DataRowView" Then Exit Sub
            llenarCombo(cmbReg, "Select id_region,region from region where id_comunidad='" & cmbComu.SelectedValue.ToString & "' order by region")
        End If
    End Sub

    Private Sub cmbComu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbComu.GotFocus
        lblMen.Top = cmbComu.Top
        lblMen.Text = "Teclee la comunidad"
    End Sub

    Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComu.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbComu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbComu.LostFocus
        lblMen.Text = ""
    End Sub

    Private Sub cmbRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRuta.SelectedIndexChanged
        'If Not IsNothing(cmbReg.SelectedValue) Then
        '    If cmbReg.SelectedValue.ToString = "System.Data.DataRowView" Then Exit Sub
        '    llenarCombo(cmbRuta, "select id_ruta,ruta from rutas where id_region='" & cmbReg.SelectedValue.ToString & "'")
        'End If
    End Sub


    Private Sub cmbReg_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbReg.GotFocus
        lblMen.Top = cmbReg.Top
        lblMen.Text = "Escriba la región"
    End Sub

    Private Sub cmbReg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbReg.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbReg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbReg.LostFocus
        lblMen.Text = ""
    End Sub

    Private Sub cmbRuta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRuta.GotFocus
        lblMen.Top = cmbRuta.Top
        lblMen.Text = "Escriba la ruta"
    End Sub

    Private Sub cmbRuta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRuta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo ..."
        cmdImp.Enabled = False
        Dim cadena As String = "", titulo As String = ""


        If cmbComu.Text <> "" Then
            cadena = "{usuario1.id_comunidad}='" & cmbComu.SelectedValue.ToString & "'"
            titulo = "COMUNIDAD: " & cmbComu.Text
        Else

            'Else
            'MessageBoxEx.Show("ESPECIFIQUE LA COMUNIDAD POR FAVOR", "REPORTE DE USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Exit Sub
        End If

        If cmbReg.Text <> "" Then
            If Len(cadena) = 0 Then
                cadena &= "{usuario1.region}='" & cmbReg.SelectedValue.ToString & "'"
                titulo &= ", REGIÓN: " & cmbReg.Text
            Else
                cadena &= " and {usuario1.region}='" & cmbReg.SelectedValue & "'"
                titulo &= ", REGIÓN: " & cmbReg.Text
            End If

        End If

        If cmbRuta.Text <> "" Then
            If Len(cadena) = 0 Then
                cadena &= "{usuario1.ruta}='" & cmbRuta.SelectedValue.ToString & "'"
                titulo &= ", RUTA: " & cmbRuta.Text
            Else
                cadena &= " and {usuario1.ruta}='" & cmbRuta.SelectedValue.ToString & "'"
                titulo &= ", RUTA: " & cmbRuta.Text
            End If
        End If

        If cmbTipUso.Text <> "" Then
            If cadena = "" Then
                cadena = "{usuario1.id_tipo_usuario}='" & cmbTipUso.SelectedValue.ToString & "'"
                titulo = "TIPO DE USUARIO : " & cmbTipUso.Text
            Else
                cadena &= " and {usuario1.id_tipo_usuario}='" & cmbTipUso.SelectedValue.ToString & "'"
                titulo &= " ,TIPO DE USUARIO : " & cmbTipUso.Text
            End If
        End If

        If cmbTarifa.Text <> "" Then
            If cadena = "" Then
                cadena = "{usuario1.tarifa}='" & cmbTarifa.SelectedValue.ToString & "'"
                titulo = "TARIFA : " & cmbTarifa.Text
            Else
                cadena &= " and {usuario1.tarifa}='" & cmbTarifa.SelectedValue.ToString & "'"
                titulo &= " ,TARIFA : " & cmbTarifa.Text
            End If
        End If

        If cadena = "" Then
            cadena = cadena & "{otrosconceptos1.resta}>0 AND {otrosconceptos1.CONCEPTO}='ANTICIPO' AND {otrosconceptos1.ESTADO}<>'CANCELADO' and {otrosconceptoS1.TIPO_MOV}='Abono'"
        Else
            cadena = cadena & "and {otrosconceptos1.resta}>0 AND {otrosconceptos1.CONCEPTO}='ANTICIPO' AND {otrosconceptos1.ESTADO}<>'CANCELADO' AND {otrosconceptoS1.TIPO_MOV}='Abono'"
        End If


    End Sub

    Private Sub frmrepanti_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    Private Sub cmbReg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReg.SelectedIndexChanged
        If Not cmbReg.SelectedValue Is Nothing AndAlso Not cmbComu.SelectedValue Is Nothing Then
            llenarCombo(cmbRuta, "select id_ruta, ruta from rutas where id_comunidad='" & cmbComu.SelectedValue.ToString & "' and id_region='" & cmbReg.SelectedValue.ToString & "'")
        End If
    End Sub
    Private Sub cmbTipUso_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipUso.GotFocus
        lblmen.Top = cmbTipUso.Top
        lblmen.Text = "Escriba el tipo de usuario"
    End Sub
    Private Sub cmbTipUso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipUso.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbTipUso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipUso.LostFocus
        lblmen.Top = cmbTipUso.Top
        lblmen.Text = ""
    End Sub
    Private Sub cmbTipUso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipUso.SelectedIndexChanged
        If Not cmbTipUso.SelectedValue Is Nothing AndAlso cargado Then
            llenarCombo(cmbTarifa, "select id_tarifa, descripcion_cuota from cuotas where parauso='" & cmbTipUso.SelectedValue.ToString & "'")
        End If
    End Sub
    Private Sub cmbTarifa_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTarifa.GotFocus
        lblmen.Top = cmbTarifa.Top
        lblmen.Text = "Escriba la tarifa"
    End Sub
    Private Sub cmbTarifa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTarifa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbTarifa_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTarifa.LostFocus
        lblmen.Top = cmbTipUso.Top
        lblmen.Text = ""
    End Sub

End Class