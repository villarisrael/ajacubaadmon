Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Rendering
Imports System.Data.Odbc

Public Class MDIPrincipal
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

    Dim FRMCONS As frmConscuotas
    Public FRMCONTRA As frmcontrato
    Dim Sesion As Boolean
    Dim frmord As frmOrdTrab

    Dim repanti As frmrepanti
    Dim ir As IDataReader = Nothing
    Dim tabla As New Hashtable

    Public NomUser As String

#Region "Automatic Color Scheme creation based on the selected color table"
    Private m_ColorSelected As Boolean = False
    Private m_BaseColorScheme As eOffice2007ColorScheme = eOffice2007ColorScheme.Blue
    Private Sub buttonStyleCustom_ExpandChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonStyleCustom.ExpandChange
        If buttonStyleCustom.Expanded Then

            m_ColorSelected = False
            m_BaseColorScheme = CType(GlobalManager.Renderer, Office2007Renderer).ColorTable.InitialColorScheme
        Else
            If Not m_ColorSelected Then
                MDIMenu.Office2007ColorTable = m_BaseColorScheme
            End If
        End If

    End Sub

    Private Sub buttonStyleCustom_ColorPreview(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ColorPreviewEventArgs) Handles buttonStyleCustom.ColorPreview
        RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, e.Color)
    End Sub

    Private Sub buttonStyleCustom_SelectedColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonStyleCustom.SelectedColorChanged
        m_ColorSelected = True
        buttonStyleCustom.CommandParameter = buttonStyleCustom.SelectedColor
    End Sub
#End Region

    Private Sub MDIPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Sesion = False Then
            If MessageBoxEx.Show("¿Desea salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MDIPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As Object = Nothing, et As System.EventArgs = Nothing
        Dim ie As ICommandSource = Me.estilos

        ir = ConsultaSql("Select * from letras where ccodusuario = " & NumUser & "").ExecuteReader
        ir.Read()
        'Dim reg As New ClassRegistros
        Sesion = False
        'If reg.obtA() = 0 And reg.obtR() = 0 And reg.obtG() = 0 And reg.obtB() = 0 Then
        If ir("A") = 0 And ir("R") = 0 And ir("G") = 0 And ir("B") = 0 Then
            m_BaseColorScheme = ir("Estilo") 'reg.obtEstilazo()
            ie.CommandParameter = m_BaseColorScheme.ToString
        Else
            ie.CommandParameter = System.Drawing.Color.FromArgb(ir("A"), ir("R"), ir("G"), ir("B"))
            m_BaseColorScheme = ir("Estilo")
        End If



        TabStrip1.MdiForm = Me
        conectar()
        AppCommandTheme_Executed(ie, et)
        'Exb.Expanded = False

        'llenarCombo(CmbComunidad2, "select id_comunidad,comunidad from comunidades ")






        LblUsuario.Text = NomUser

        llenaopciones()
        MDIMenu.Visible = True

        MDIMenu.Refresh()

        MDIMenu.Refresh()
    End Sub

    Private Sub DockTabChanged(ByVal sender As Object, ByVal e As DockTabChangeEventArgs)
        ' Sync caption of the bar with the currently selected dock tab
        Dim bar As Bar = CType(sender, Bar)
        If bar Is Nothing Or e.NewTab Is Nothing Then
            Exit Sub
        Else
            bar.Text = e.NewTab.Text
        End If
    End Sub

    Private Sub ButtonItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem7.Click
        Close()
    End Sub

    'Public Sub TXTCUENTA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        BuscarUsuario()
    '    End If
    'End Sub

    'Public Sub BuscarUsuario()
    '    If CmbComunidad2.SelectedIndex = -1 Then
    '        MessageBoxEx.Show("Selecciona la comunidad del usuario", "Buscar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        CmbComunidad2.Select()
    '        Exit Sub
    '    End If
    '    If TXTCUENTA.Text = "" Then
    '        MessageBoxEx.Show("Selecciona la cuenta del usuario", "Buscar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '        Exit Sub
    '    End If

    '    Dim IDCOMU As String
    '    IDCOMU = CmbComunidad2.SelectedValue   'ListCOUNIDADES.Items(CMBCOMUNIDAD.SelectedIndex)
    '    Dim id As IDataReader = ConsultaSql("select * from usuario where id_comunidad='" & IDCOMU & "' and cuenta=" & TXTCUENTA.Text).ExecuteReader
    '    id.Read()
    '    If id.RecordsAffected > 0 Then
    '        Lblnombre.Text = id("nombre")
    '        ' txtnumerodesolicitud.TextBox.Text = "" & id("factibilidad")
    '        lbldireccion.Text = obtenerCampo("select nombre from calles where id_calle='" & id("id_calle") & "'", "nombre") & " " & id("numext") & " " & id("numint")
    '        LblEstado.Text = obtenerCampo("select descripcion from estadocuenta where clave = " & id("Estado") & "", "descripcion")
    '        If id("Estado") = 1 Then
    '            'btnDarDeBaja.Enabled = True
    '            My.Forms.frmBusUsuario.cmdActi.Enabled = False
    '            'BtnReactivacion.Enabled = False
    '            LblEstado.BackColor = Color.ForestGreen
    '            LblEstado.ForeColor = Color.White
    '        ElseIf id("Estado") = 2 Then
    '            'btnDarDeBaja.Enabled = False
    '            My.Forms.frmBusUsuario.cmdActi.Enabled = True
    '            'BtnReactivacion.Enabled = False
    '            LblEstado.BackColor = Color.DarkGray
    '            LblEstado.ForeColor = Color.White
    '        ElseIf id("Estado") = 3 Then
    '            'btnDarDeBaja.Enabled = False
    '            My.Forms.frmBusUsuario.cmdActi.Enabled = False
    '            'BtnReactivacion.Enabled = True
    '            LblEstado.BackColor = Color.Maroon
    '            LblEstado.ForeColor = Color.White
    '        ElseIf id("Estado") = 4 Then
    '            'btnDarDeBaja.Enabled = True
    '            My.Forms.frmBusUsuario.cmdActi.Enabled = False
    '            'BtnReactivacion.Enabled = False
    '            LblEstado.BackColor = Color.DarkBlue
    '            LblEstado.ForeColor = Color.White
    '        End If
    '    Else
    '        MessageBoxEx.Show("El usuario no se localizo, verifique sus datos", "Buscar usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '    End If

    'End Sub

    'Private Sub btndatosgenerales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If CmbComunidad2.SelectedIndex = -1 Then
    '        MessageBoxEx.Show("Selecciona la comunidad del usuario", "Datos Generales", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        CmbComunidad2.Select()
    '        Exit Sub
    '    End If
    '    If TXTCUENTA.Text = "" Then
    '        MessageBoxEx.Show("Selecciona la cuenta del usuario", "Datos Generales", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '        Exit Sub
    '    End If

    '    FRMCONTRA = New frmcontrato(frmcontrato._vengode.solicitud)
    '    FRMCONTRA.mestado = frmcontrato.Estado.Editar
    '    FRMCONTRA.cuenta = TXTCUENTA.Value
    '    FRMCONTRA.idcomacargar = CmbComunidad2.SelectedValue.ToString
    '    FRMCONTRA.MdiParent = Me
    '    FRMCONTRA.mestado = frmcontrato.Estado.Editar
    '    FRMCONTRA.Show()
    '    FRMCONTRA.Select()
    'End Sub

    'Private Sub ButtonItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If CmbComunidad2.SelectedIndex = -1 Then
    '            MessageBoxEx.Show("Selecciona la comunidad del usuario", "Buscar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            CmbComunidad2.Select()
    '            Exit Sub
    '        End If
    '        If TXTCUENTA.Text = "" Then
    '            MessageBoxEx.Show("Selecciona la cuenta del usuario", "Buscar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            TXTCUENTA.Select()
    '            Exit Sub
    '        End If

    '        FRMCONTRA = New frmcontrato(frmcontrato._vengode.solicitud)
    '        FRMCONTRA.mestado = frmcontrato.Estado.Editar
    '        FRMCONTRA.cuenta = TXTCUENTA.Value
    '        FRMCONTRA.idcomacargar = CmbComunidad2.SelectedValue.ToString
    '        FRMCONTRA.MdiParent = Me
    '        FRMCONTRA.mestado = frmcontrato.Estado.Editar
    '        FRMCONTRA.Show()
    '        FRMCONTRA.Select()
    '    Catch ex As Exception
    '        MessageBoxEx.Show(ex.Message, "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub

    'Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim frmfac As New frmfactibilidad
    '    frmfac.MdiParent = Me
    '    frmfac.Show()
    'End Sub

    'Private Sub btnfacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If CmbComunidad2.SelectedIndex = -1 Then
    '        MessageBoxEx.Show("Selecciona la comunidad del usuario", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        CmbComunidad2.Select()
    '        Exit Sub
    '    End If
    '    If TXTCUENTA.Text = "" Then
    '        MessageBoxEx.Show("Selecciona la cuenta del usuario", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '        Exit Sub
    '    End If

    '    Dim frmfac As New facturasview(TXTCUENTA.Value, CmbComunidad2.SelectedValue.ToString, Lblnombre.Text)
    '    frmfac.MdiParent = Me
    '    frmfac.Show()
    'End Sub

    'Private Sub BtnActivacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim IDCOMU As String
    '    Try
    '        IDCOMU = CmbComunidad2.SelectedValue.ToString
    '        If obtenerCampo("Select descripcion from usuario as A, estadocuenta as B where B.clave = A.estado and id_comunidad='" & IDCOMU & "' and cuenta=" & TXTCUENTA.Text & "", "descripcion") <> "Activo" Then
    '            FrmActivarCuenta.Comunidad = IDCOMU
    '            FrmActivarCuenta.Cuenta = TXTCUENTA.Text
    '            FrmActivarCuenta.ShowDialog()
    '        Else
    '            MessageBoxEx.Show("La cuenta esta activada, no necesita que se active de nuevo", "Activacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception

    '    End Try

    'End Sub


    Private Sub BtnBuscarContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscarContrato.Click
        frmBusUsuario.filtro("select cuenta as Cuenta, cuentaAnterior, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as Número_exterior, numint as Número_interior  from vusuario order by cuenta, comunidad ")
        frmBusUsuario.MdiParent = Me
        frmBusUsuario.Show()
        frmBusUsuario.Select()
    End Sub

    'Private Sub CmdInsta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CmbComunidad2.SelectedIndex = -1 Then
    '        MessageBoxEx.Show("Selecciona la comunidad del usuario", "Instalación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        CmbComunidad2.Select()
    '        Exit Sub
    '    End If
    '    If TXTCUENTA.Text = "" Then
    '        MessageBoxEx.Show("Selecciona la cuenta del usuario", "Instalación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '        Exit Sub
    '    End If

    '    Dim frm As New frmInsta(TXTCUENTA.Text, CmbComunidad2.SelectedValue.ToString)
    '    frm.MdiParent = Me
    '    frm.Show()
    '    frm.WindowState = FormWindowState.Normal
    'End Sub

    'Private Sub estadocuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If CmbComunidad2.SelectedIndex = -1 Then
    '        MessageBoxEx.Show("Selecciona la comunidad del usuario", "Estado de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        CmbComunidad2.Select()
    '        Exit Sub
    '    End If
    '    If TXTCUENTA.Text = "" Then
    '        MessageBoxEx.Show("Selecciona la cuenta del usuario", "Estado de Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        TXTCUENTA.Select()
    '        Exit Sub
    '    End If

    '    Dim frm As New Frmconsultarcierre
    '    frm.Cuenta = Val(TXTCUENTA.Text)
    '    frm.Comunidad = CmbComunidad2.SelectedValue 'ListCOUNIDADES.Items(CMBCOMUNIDAD.SelectedIndex)
    '    frm.MdiParent = Me
    '    frm.Text = "Estado de Cuenta " & Val(TXTCUENTA.Text)
    '    frm.Show()
    '    frm.WindowState = FormWindowState.Maximized
    'End Sub

    Private Sub cmdComu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComu.Click
        If Not frmComu.Created Then
            frmComu.MdiParent = Me
            frmComu.Show()
            frmComu.WindowState = FormWindowState.Maximized
        End If
        frmComu.Select()
    End Sub
    Private Sub cmdMunicipios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMunicipios.Click
        If Not frmMuni.Created Then
            frmMuni.MdiParent = Me
            frmMuni.Show()
            frmMuni.WindowState = FormWindowState.Maximized
        End If
        frmMuni.Select()
    End Sub

    Private Sub cmdColo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdColo.Click
        If Not frmColo.Created Then
            frmColo.MdiParent = Me
            frmColo.Show()
            frmColo.WindowState = FormWindowState.Maximized
        End If
        frmColo.Select()
    End Sub

    Private Sub cmdCalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalles.Click
        If Not frmCalles.Created Then
            frmCalles.MdiParent = Me
            frmCalles.Show()
            frmCalles.WindowState = FormWindowState.Maximized
        End If
        frmCalles.Select()
    End Sub

    Private Sub cmdEstTom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not frmEstTom.Created Then
            frmEstTom.MdiParent = Me
            frmEstTom.Show()
            frmEstTom.WindowState = FormWindowState.Maximized
        End If
        frmEstTom.Select()
    End Sub

    Private Sub cmdCxC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCxC.Click
        If Not frmCatConCxC.Created Then
            frmCatConCxC.MdiParent = Me
            frmCatConCxC.Show()
            frmCatConCxC.WindowState = FormWindowState.Maximized
        End If
        frmCatConCxC.Select()
    End Sub

    Private Sub cmdSector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSector.Click
        If Not frmSector.Created Then
            frmSector.MdiParent = Me
            frmSector.Show()
            frmSector.WindowState = FormWindowState.Maximized
        End If
        frmSector.Select()
    End Sub

    Private Sub cmdRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRuta.Click
        If Not frmRuta.Created Then
            frmRuta.MdiParent = Me
            frmRuta.Show()
            frmRuta.WindowState = FormWindowState.Maximized
        End If
        frmRuta.Select()

    End Sub

    Private Sub BtnFormatoContratos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not FrmFormatoContratos.Created Then
            FrmFormatoContratos.MdiParent = Me
            FrmFormatoContratos.Show()
            FrmFormatoContratos.WindowState = FormWindowState.Maximized
        End If
        FrmFormatoContratos.Select()
    End Sub

    Private Sub BtnEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not FrmEmpresa.Created Then
            FrmEmpresa.MdiParent = Me
            FrmEmpresa.Show()
            FrmEmpresa.WindowState = FormWindowState.Maximized
        End If
        FrmEmpresa.Select()
    End Sub

    Private Sub cmdTrab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrab.Click
        If Not FrmEmpleados.Created Then
            My.Forms.FrmEmpleados.MdiParent = Me
            My.Forms.FrmEmpleados.Show()
            My.Forms.FrmEmpleados.WindowState = FormWindowState.Maximized
        End If
        FrmEmpleados.Select()
    End Sub

    Private Sub AppCommandTheme_Executed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppCommandTheme.Executed
        Dim source As ICommandSource = CType(sender, ICommandSource)
        Dim col As New System.Drawing.Color
        ' Dim reg As New ClassRegistros()

        If TypeOf (source.CommandParameter) Is String Then
            Dim cs As eOffice2007ColorScheme = CType(System.Enum.Parse(GetType(eOffice2007ColorScheme), source.CommandParameter.ToString()), eOffice2007ColorScheme)
            Me.MDIMenu.Office2007ColorTable = cs
            'reg.grabEstilazo(cs)
            'reg.regA(0)
            'reg.regR(0)
            'reg.regG(0)
            'reg.regB(0)
            Ejecucion("update letras set Estilo=" & cs & ", A=0, R=0, G=0, B=0 where ccodusuario=" & NumUser & "")
        ElseIf TypeOf (source.CommandParameter) Is Color Then
            col = CType(source.CommandParameter, Color)
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(Me, m_BaseColorScheme, col)
            'reg.grabEstilazo(m_BaseColorScheme)
            'reg.regA(col.A)
            'reg.regR(col.R)
            'reg.regG(col.G)
            'reg.regB(col.B)
            Ejecucion("update letras set Estilo=" & m_BaseColorScheme & ", A=" & col.A & ", R=" & col.R & ", G=" & col.G & " , B=" & col.B & " where ccodusuario=" & NumUser & "")
        End If

        Invalidate()
    End Sub

    Private Sub cmdDeptos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeptos.Click
        If Not frmDepa.Created Then
            frmDepa.MdiParent = Me
            frmDepa.Show()
            frmDepa.StartPosition = FormStartPosition.CenterParent
        End If
        frmDepa.Select()
    End Sub

    Private Sub cmdSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSolicitud.Click
        If Not frmListSoli.Created Then
            My.Forms.frmListSoli.MdiParent = Me
            My.Forms.frmListSoli.Show()
            My.Forms.frmListSoli.WindowState = FormWindowState.Maximized
        End If
        frmListSoli.Select()
    End Sub

    Private Sub cmdFacti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFacti.Click
        If Not frmListFacti.Created Then
            My.Forms.frmListFacti.MdiParent = Me
            My.Forms.frmListFacti.Show()
            My.Forms.frmListFacti.WindowState = FormWindowState.Maximized
        End If
        frmListFacti.Select()
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If Not frmBusUsuario.Created Then
            frmBusUsuario.filtro("select distinct cuenta as Cuenta,cuentaAnterior, nombre as Nombre , comunidad as Comunidad,Direccion,estado as Estado,nodemedidor as Medidor,catastral  from vusuario order by cuenta ")
            frmBusUsuario.MdiParent = Me
            frmBusUsuario.WindowState = 2
            frmBusUsuario.Show()
        End If
        frmBusUsuario.Select()
    End Sub

    Private Sub cmdRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRegion.Click
        If Not frmListReg.Created Then
            My.Forms.frmListReg.MdiParent = Me
            My.Forms.frmListReg.Show()
            My.Forms.frmListReg.WindowState = FormWindowState.Maximized
        End If
        frmListReg.Select()
    End Sub


    Private Sub CmdCuotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCuotas.Click
        If Not frmCuotasVer.Created Then
            frmCuotasVer.MdiParent = Me
            frmCuotasVer.Show()
            frmCuotasVer.WindowState = FormWindowState.Maximized
        End If
        frmCuotasVer.Select()
    End Sub

    Private Sub BtnSituaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSituaciones.Click
        'If frmSit.Created Then
        frmSit.MdiParent = Me
        frmSit.Show()
        frmSit.WindowState = FormWindowState.Maximized
        'End If
        frmSit.Select()
    End Sub

    Private Sub BtnAlgoritmos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlgoritmos.Click
        'If frmAlg.Created Then
        frmAlg.MdiParent = Me
        frmAlg.Show()
        frmAlg.WindowState = FormWindowState.Maximized
        'End If
        frmAlg.Select()
    End Sub

    Private Sub cmdDiamTom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiamTom.Click
        If Not frmDiamTom.Created Then
            My.Forms.frmDiamTom.MdiParent = Me
            My.Forms.frmDiamTom.Show()
            My.Forms.frmDiamTom.WindowState = FormWindowState.Maximized
        End If
        frmDiamTom.Select()
    End Sub

    Private Sub cmdGir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGir.Click
        If Not frmGiro.Created Then
            My.Forms.frmGiro.MdiParent = Me
            My.Forms.frmGiro.Show()
            My.Forms.frmGiro.WindowState = FormWindowState.Maximized
        End If
        frmGiro.Select()
    End Sub

    Private Sub cmdFSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFSer.Click
        If Not frmFormServ.Created Then
            My.Forms.frmFormServ.MdiParent = Me
            My.Forms.frmFormServ.Show()
            My.Forms.frmFormServ.WindowState = FormWindowState.Maximized
        End If
        frmFormServ.Select()
    End Sub
    Private Sub cmdTipSer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not frmTipSer.Created Then
            My.Forms.frmTipSer.MdiParent = Me
            My.Forms.frmTipSer.Show()
            My.Forms.frmTipSer.WindowState = FormWindowState.Maximized
        End If
        frmTipSer.Select()
    End Sub
    Private Sub cmdTipUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTipUsu.Click
        If Not frmTipUsu.Created Then
            My.Forms.frmTipUsu.MdiParent = Me
            My.Forms.frmTipUsu.Show()
            My.Forms.frmTipUsu.WindowState = FormWindowState.Maximized
        End If
        frmTipUsu.Select()
    End Sub

    Private Sub cmdFpago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFpago.Click
        If Not frmFpag.Created Then
            My.Forms.frmFpag.MdiParent = Me
            My.Forms.frmFpag.Show()
            My.Forms.frmFpag.WindowState = FormWindowState.Maximized
        End If
        frmFpag.Select()
    End Sub




    Private Sub ButtonItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrdenesTrabajo.Click
        If Not frmOrdTrab.Created Then
            My.Forms.frmOrdTrab.MdiParent = Me
            My.Forms.frmOrdTrab.MaximizeBox = True

            My.Forms.frmOrdTrab.Show()
        End If
        frmOrdTrab.Select()
    End Sub

    Private Sub BtnUsuarioNoReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUsuarioNoReg.Click
        If Not FrmListadoNoUsuario.Created Then
            FrmListadoNoUsuario.MdiParent = Me
            FrmListadoNoUsuario.Show()
            FrmListadoNoUsuario.WindowState = FormWindowState.Maximized
        End If
        FrmListadoNoUsuario.Select()
    End Sub



    Private Sub cmdMulOtr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMulOtr.Click
        If Not frmListMultas.Created Then
            frmListMultas.MdiParent = Me
            frmListMultas.Show()
            frmListMultas.WindowState = FormWindowState.Maximized
        End If
        frmListMultas.Select()
    End Sub





    Private Sub cmdconce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdconce.Click
        If Not frmCatConcepCis.Created Then
            frmCatConcepCis.MdiParent = Me
            frmCatConcepCis.Show()
            frmCatConcepCis.WindowState = FormWindowState.Maximized
        End If
        frmCatConcepCis.Select()
    End Sub

    Private Sub BtnBrigadas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrigadas.Click
        If Not frmCatBrig.Created Then
            frmCatBrig.MdiParent = Me
            frmCatBrig.Show()
            frmCatBrig.WindowState = FormWindowState.Maximized
        End If
        frmCatBrig.Select()
    End Sub

    Private Sub BtnFuentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFuentes.Click
        If Not frmCatFuen.Created Then
            frmCatFuen.MdiParent = Me
            frmCatFuen.Show()
            frmCatFuen.WindowState = FormWindowState.Maximized
        End If
        frmCatFuen.Select()
    End Sub

    Private Sub BtnDireccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDireccion.Click
        If Not frmCatDir.Created Then
            frmCatDir.MdiParent = Me
            frmCatDir.Show()
            frmCatDir.WindowState = FormWindowState.Maximized
        End If
        frmCatDir.Select()
    End Sub



    Private Sub BtnMapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Frmexplorer.Created Then
            Frmexplorer.MdiParent = Me
            Frmexplorer.Show()
            Frmexplorer.WindowState = FormWindowState.Maximized
        End If
        Frmexplorer.Select()
    End Sub

    Private Sub BtnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUsers.Click

        If Not FrmListadoUsers.Created Then
            FrmListadoUsers.MdiParent = Me
            FrmListadoUsers.Show()
            FrmListadoUsers.WindowState = FormWindowState.Maximized
        End If
        FrmListadoUsers.Select()
    End Sub

    Private Sub BtnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrarSesion.Click
        If MessageBoxEx.Show("¿Desea Cerrar su Sesión?", "Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Sesion = True
            FrmAcceso.Show()
            Close()
        End If
    End Sub

    Private Sub BtnMarcas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMarcas.Click
        If Not frmMarMed.Created Then
            frmMarMed.MdiParent = Me
            frmMarMed.Show()
            frmMarMed.WindowState = FormWindowState.Maximized
        End If
        frmMarMed.Select()
    End Sub

    Private Sub BtnOficinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOficinas.Click
        If Not frmCatOfi.Created Then
            frmCatOfi.MdiParent = Me
            frmCatOfi.Show()
            frmCatOfi.WindowState = FormWindowState.Maximized
        End If
        frmCatOfi.Select()
    End Sub

    Private Sub BtnCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCajas.Click
        If Not frmCatCajas.Created Then
            frmCatCajas.MdiParent = Me
            frmCatCajas.Show()
            frmCatCajas.WindowState = FormWindowState.Maximized
        End If
        frmCatCajas.Select()
    End Sub

    Private Sub BtnRepPadron_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRepPadron.Click
        If Not frmRepUsu.Created Then
            My.Forms.frmRepUsu.MdiParent = Me
            My.Forms.frmRepUsu.tipr = frmRepUsu.tiporep.UsuariosCont
            My.Forms.frmRepUsu.Show()
            My.Forms.frmRepUsu.WindowState = FormWindowState.Normal
        End If
        frmRepUsu.Select()
    End Sub

    Private Sub BtnRptBajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRptBajas.Click
        If Not frmTomBaja.Created Then
            frmTomBaja.MdiParent = Me
            frmTomBaja.Show()
            frmTomBaja.WindowState = FormWindowState.Normal
        End If
        frmTomBaja.Select()
    End Sub



    Private Sub cmdTomCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTomCont.Click
        Dim FRM As New frmTomContra
        FRM.MdiParent = Me
        FRM.Show()
        FRM.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TXTCUENTA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub BtnImportaCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
    End Sub




    Private Sub BtnMovimientos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMovimientos.Click
        If txtNMed.TextBox.Text <> "" Then
            frmord = New frmOrdTrab(frmOrdTrab.vienede.Hidrómetros, , , txtNMed.TextBox.Text)
            frmord.MdiParent = Me
            frmord.Show()
            frmord.WindowState = FormWindowState.Maximized
        Else
            MessageBoxEx.Show("ESTABLEZCA EL NÚMERO DE MEDIDOR", "HIDRÓMETROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub txtNMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNMed.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If configuracion.Created = False Then
            configuracion.MdiParent = Me
            configuracion.Show()
            configuracion.StartPosition = FormStartPosition.CenterParent
        End If
        configuracion.Select()
    End Sub





    Private Sub BtnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportar.Click
        FrmExportaLecturas.MdiParent = Me
        FrmExportaLecturas.Show()
    End Sub



    Private Sub RTUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RTUsuarios.Click
        Try
            For Each f As Form In System.Windows.Forms.Application.OpenForms

                'If Not f.InvokeRequired Then
                Select Case f.Name
                    Case "DlgImprimeSol"
                        If DlgImprimeSol.WindowState <> FormWindowState.Maximized Then
                            DlgImprimeSol.WindowState = FormWindowState.Maximized
                        End If
                        DlgImprimeSol.Select()
                        Exit For
                    Case "DlgTipoImprSolicitud"
                        If DlgTipoImprSolicitud.WindowState <> FormWindowState.Maximized Then
                            DlgTipoImprSolicitud.WindowState = FormWindowState.Maximized
                        End If
                        DlgTipoImprSolicitud.Select()
                        Exit For
                    Case "FrmActivarCuenta"
                        If FrmActivarCuenta.WindowState <> FormWindowState.Maximized Then
                            FrmActivarCuenta.WindowState = FormWindowState.Maximized
                        End If
                        FrmActivarCuenta.Select()
                        Exit For
                    Case "frmBusUsuario"
                        If frmBusUsuario.WindowState <> FormWindowState.Maximized Then
                            frmBusUsuario.WindowState = FormWindowState.Maximized
                        End If
                        frmBusUsuario.Select()
                        Exit For
                    Case "FrmCambioNombre"
                        If FrmCambioNombre.WindowState <> FormWindowState.Maximized Then
                            FrmCambioNombre.WindowState = FormWindowState.Maximized
                        End If
                        FrmCambioNombre.Select()
                        Exit For
                    Case "FrmCambioTarifa"
                        If FrmCambioTarifa.WindowState <> FormWindowState.Maximized Then
                            FrmCambioTarifa.WindowState = FormWindowState.Maximized
                        End If
                        FrmCambioTarifa.Select()
                        Exit For
                    Case "frmcontrato"
                        If frmcontrato.WindowState <> FormWindowState.Maximized Then
                            frmcontrato.WindowState = FormWindowState.Maximized
                        End If
                        frmcontrato.Select()
                        Exit For
                    Case "FrmDarDeBaja"
                        If FrmDarDeBaja.WindowState <> FormWindowState.Maximized Then
                            FrmDarDeBaja.WindowState = FormWindowState.Maximized
                        End If
                        FrmDarDeBaja.Select()
                        Exit For
                    Case "frmfactibilidad"
                        If frmfactibilidad.WindowState <> FormWindowState.Maximized Then
                            frmfactibilidad.WindowState = FormWindowState.Maximized
                        End If
                        frmfactibilidad.Select()
                        Exit For
                    Case "frmInsta"
                        If frmInsta.WindowState <> FormWindowState.Maximized Then
                            frmInsta.WindowState = FormWindowState.Maximized
                        End If
                        frmInsta.Select()
                        Exit For
                    Case "frmListFacti"
                        If frmListFacti.WindowState <> FormWindowState.Maximized Then
                            frmListFacti.WindowState = FormWindowState.Maximized
                        End If
                        frmListFacti.Select()
                        Exit For
                    Case "frmListSoli"
                        If frmListSoli.WindowState <> FormWindowState.Maximized Then
                            frmListSoli.WindowState = FormWindowState.Maximized
                        End If
                        frmListSoli.Select()
                        Exit For
                    Case "frmMotElSol"
                        If frmMotElSol.WindowState <> FormWindowState.Maximized Then
                            frmMotElSol.WindowState = FormWindowState.Maximized
                        End If
                        frmMotElSol.Select()
                        Exit For
                    Case "FrmReactivar"
                        If FrmReactivar.WindowState <> FormWindowState.Maximized Then
                            FrmReactivar.WindowState = FormWindowState.Maximized
                        End If
                        FrmReactivar.Select()
                        Exit For
                    Case "FrmRegistro"
                        If FrmRegistro.WindowState <> FormWindowState.Maximized Then
                            FrmRegistro.WindowState = FormWindowState.Maximized
                        End If
                        FrmRegistro.Select()
                        Exit For
                    Case "Frmsolicitud"
                        If Frmsolicitud.WindowState <> FormWindowState.Maximized Then
                            Frmsolicitud.WindowState = FormWindowState.Maximized
                        End If
                        Frmsolicitud.Select()
                        Exit For
                    Case "FrmTipoImprContrato"
                        If FrmTipoImprContrato.WindowState <> FormWindowState.Maximized Then
                            FrmTipoImprContrato.WindowState = FormWindowState.Maximized
                        End If
                        FrmTipoImprContrato.Select()
                        Exit For
                    Case "frmRepUsu"
                        If frmRepUsu.WindowState <> FormWindowState.Normal Then
                            frmRepUsu.WindowState = FormWindowState.Normal
                        End If
                        frmRepUsu.Select()
                        Exit For
                    Case Else
                        '      Me.ActiveMdiChild.WindowState = FormWindowState.Minimized
                End Select
                'formTitles.Add(f.Text)
                'End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RBCis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBCis.Click
        Try
            For Each f As Form In System.Windows.Forms.Application.OpenForms
                ' If f.InvokeRequired Then
                Select Case f.Name
                    Case "frmAgrOrd"
                        If frmAgrOrd.WindowState <> FormWindowState.Maximized Then
                            frmAgrOrd.WindowState = FormWindowState.Maximized
                        End If
                        frmAgrOrd.Select()
                        Exit For
                    Case "frmListOrd"
                        If frmListOrd.WindowState <> FormWindowState.Maximized Then
                            frmListOrd.WindowState = FormWindowState.Maximized
                        End If
                        frmListOrd.Select()
                        Exit For
                    Case "frmImpEst"
                        If frmImpEst.WindowState <> FormWindowState.Maximized Then
                            frmImpEst.WindowState = FormWindowState.Maximized
                        End If
                        frmImpEst.Select()
                        Exit For
                    Case "frmImpEstC"
                        If frmImpEstC.WindowState <> FormWindowState.Maximized Then
                            frmImpEstC.WindowState = FormWindowState.Maximized
                        End If
                        frmImpEstC.Select()
                        Exit For
                    Case "frmOrdTrab"
                        If frmOrdTrab.WindowState <> FormWindowState.Maximized Then
                            frmOrdTrab.WindowState = FormWindowState.Maximized
                        End If
                        frmOrdTrab.Select()
                        Exit For
                    Case "frmImpOrdC"
                        If frmImpOrdC.WindowState <> FormWindowState.Maximized Then
                            frmImpOrdC.WindowState = FormWindowState.Maximized
                        End If
                        frmImpOrdC.Select()
                        Exit For
                    Case Else
                        '    Me.ActiveMdiChild.WindowState = FormWindowState.Minimized
                End Select
                'End If
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tabcobros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabcobros.Click
        Try
            For Each f As Form In System.Windows.Forms.Application.OpenForms
                Select Case f.Name
                    Case "FrmListadoNoUsuario"
                        If FrmListadoNoUsuario.WindowState <> FormWindowState.Maximized Then
                            FrmListadoNoUsuario.WindowState = FormWindowState.Maximized
                        End If
                        FrmListadoNoUsuario.Select()
                        Exit For

                    Case "frmListMultas"
                        If frmListMultas.WindowState <> FormWindowState.Maximized Then
                            frmListMultas.WindowState = FormWindowState.Maximized
                        End If
                        frmListMultas.Select()
                        Exit Sub
                    Case Else
                        '   Me.ActiveMdiChild.WindowState = FormWindowState.Minimized

                End Select
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabFacturacion.Click
        For Each f As Form In System.Windows.Forms.Application.OpenForms
            Select Case f.Name


                Case "FrmRepTomaLecturas"
                    If FrmRepTomaLecturas.WindowState <> FormWindowState.Maximized Then
                        FrmRepTomaLecturas.WindowState = FormWindowState.Maximized
                    End If
                    FrmRepTomaLecturas.Select()
                    Exit For
                Case "FrmRepLecturasCapturadas"
                    If frmRepLecturasCapturadas.WindowState <> FormWindowState.Maximized Then
                        frmRepLecturasCapturadas.WindowState = FormWindowState.Maximized
                    End If
                    frmRepLecturasCapturadas.Select()
                    Exit For
                Case "FrmRepCalculoConsumo"
                    If FrmRepCalculoConsumo.WindowState <> FormWindowState.Maximized Then
                        FrmRepCalculoConsumo.WindowState = FormWindowState.Maximized
                    End If
                    FrmRepCalculoConsumo.Select()
                    Exit For
                Case "FrmSituacionesCaptura"
                    If FrmSituacionesCaptura.WindowState <> FormWindowState.Maximized Then
                        FrmSituacionesCaptura.WindowState = FormWindowState.Maximized
                    End If
                    FrmSituacionesCaptura.Select()
                    Exit Sub
                Case "FrmCalculaConsumo"
                    If FrmCalculaConsumo.WindowState <> FormWindowState.Maximized Then
                        FrmCalculaConsumo.WindowState = FormWindowState.Maximized
                    End If
                    FrmCalculaConsumo.Select()
                    Exit For
                    'Case "frmelaboracierre"
                    '    If frmelaboracierre.WindowState <> FormWindowState.Maximized Then
                    '        frmelaboracierre.WindowState = FormWindowState.Maximized
                    '    End If
                    '    frmelaboracierre.Select()
                    Exit For
            End Select
        Next
    End Sub
    Private Sub RBHidrometros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RBHidrometros.Click
        For Each f As Form In System.Windows.Forms.Application.OpenForms
            Select Case f.Name
                Case "FrmExportaLecturas"
                    If FrmExportaLecturas.WindowState <> FormWindowState.Maximized Then
                        FrmExportaLecturas.WindowState = FormWindowState.Maximized
                    End If
                    FrmExportaLecturas.Select()
                    Exit For
                Case "frmOrdTrab"
                    Try
                        If frmord.WindowState <> FormWindowState.Maximized Then
                            frmord.WindowState = FormWindowState.Maximized
                        End If
                        frmord.Select()
                    Catch ex As Exception

                    End Try

                    Exit For
            End Select
        Next
    End Sub

    Private Sub TabCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each f As Form In System.Windows.Forms.Application.OpenForms
            Select Case f.Name
                Case "frmCajas"
                    'If frmCajas.WindowState <> FormWindowState.Maximized Then
                    '    frmCajas.WindowState = FormWindowState.Maximized
                    'End If
                    'frmCajas.Select()
                    Exit For
                Case "FrmImportarCobros"
                    'If FrmImportarCobros.WindowState <> FormWindowState.Maximized Then
                    '    FrmImportarCobros.WindowState = FormWindowState.Maximized
                    'End If
                    'FrmImportarCobros.Select()
                    Exit For
            End Select
        Next
    End Sub

    Private Sub RbRecaudacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each f As Form In System.Windows.Forms.Application.OpenForms
            Select Case f.Name

                Case "frmAviPag"
                    If FrmAvisosPago.WindowState <> FormWindowState.Maximized Then
                        FrmAvisosPago.WindowState = FormWindowState.Maximized
                    End If
                    FrmAvisosPago.Select()
                    Exit For
            End Select
        Next
    End Sub

    Private Sub cmdCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCont.Click
        If Not frmRepCont1.Created Then
            frmRepCont1.MdiParent = Me
            frmRepCont1.Show()
            frmRepCont1.WindowState = FormWindowState.Normal
        End If
        frmRepCont1.Select()
    End Sub
    Private Sub antiguedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FRMan As New frmantiguedad
        FRMan.MdiParent = Me
        FRMan.Show()
        FRMan.WindowState = FormWindowState.Normal
    End Sub


    Private Sub ButtonItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FRMREP = New frmrptfacturacio
        'FRMREP.suministro = True
        'FRMREP.rezagos = False
        'FRMREP.MdiParent = Me
        'FRMREP.Show()
    End Sub

    Private Sub ButtonItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmrep1 = New frmrptfacturacio
        'frmrep1.rezagos = True
        'frmrep1.suministro = False
        'frmrep1.MdiParent = Me
        'frmrep1.Show()
    End Sub





    Private Sub BtnVerPeriodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerPeriodos.Click
        'Frmconsultarcierre.MdiParent = Me
        'Frmconsultarcierre.Show()

    End Sub

    Private Sub cmdCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCap.Click
        FrmCapturaLecturas.MdiParent = Me
        FrmCapturaLecturas.Show()
        FrmCapturaLecturas.Select()
        'FrmCapturaLecturas.WindowState = FormWindowState.Maximized
        FrmCapturaLecturas.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub cmdTomLect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTomLect.Click
        FrmRepTomaLecturas.MdiParent = Me
        FrmRepTomaLecturas.Show()
        FrmRepTomaLecturas.Select()
    End Sub

    Private Sub lecCap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lecCap.Click
        If Not frmRepLecturasCapturadas.Created Then
            frmRepLecturasCapturadas.MdiParent = Me
            frmRepLecturasCapturadas.Show()
        End If
        frmRepLecturasCapturadas.Select()
    End Sub

    Private Sub BtnInconsistencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInconsistencias.Click
        FrmSituacionesCaptura.MdiParent = Me
        FrmSituacionesCaptura.Show()
        FrmSituacionesCaptura.WindowState = FormWindowState.Normal
        FrmSituacionesCaptura.Select()
    End Sub


    Private Sub cmdCalConsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalConsu.Click
        FrmCalculaConsumo.MdiParent = Me
        FrmCalculaConsumo.Show()
        FrmCalculaConsumo.Select()
    End Sub

    Private Sub cmdApliLect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmAplicarLecturas.MdiParent = Me
        'FrmAplicarLecturas.Show()
        'FrmAplicarLecturas.Select()
    End Sub


    Private Sub BtnRptCalculoConsumo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRptCalculoConsumo.Click
        'If Not FrmRepLecturasCapturadas.Created Then
        FrmRepCalculoConsumo.MdiParent = Me
        FrmRepCalculoConsumo.Show()
        'End If
        FrmRepCalculoConsumo.Select()
        FrmRepCalculoConsumo.StartPosition = FormStartPosition.CenterParent
    End Sub
    Private Sub cmdAntiApli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each f As Form In System.Windows.Forms.Application.OpenForms
            If f.Text = "Reporteanticipo" Then
                f.Select()
                f.WindowState = FormWindowState.Maximized
                Exit Sub
            End If
        Next
        repanti = New frmrepanti

        repanti.MdiParent = Me
        repanti.Show()
        repanti.WindowState = FormWindowState.Normal
    End Sub





    Private Sub cmdAnLec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmRepAnLec2.MdiParent = Me
        'frmRepAnLec2.Show()
    End Sub

    Private Sub cmdAviPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAviPag.Click
        If FrmAvisosPago.Created = False Then
            FrmAvisosPago.MdiParent = Me
            FrmAvisosPago.Show()
        End If
        FrmAvisosPago.Select()
    End Sub


    Private Sub cmdInfCNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInfCNA.Click
        Dim frm As New InformeCna
        frm.ShowDialog()
    End Sub

    Private Sub btnmatcalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmatcalle.Click
        If Not frmFormServ.Created Then
            My.Forms.Frmmatcalle.MdiParent = Me
            My.Forms.Frmmatcalle.Show()
            My.Forms.Frmmatcalle.WindowState = FormWindowState.Maximized
        End If
        Frmmatcalle.Select()
    End Sub

    Private Sub Btnmedidor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmedidor.Click
        If Not frmFormServ.Created Then
            My.Forms.frmubmedidor.MdiParent = Me
            My.Forms.frmubmedidor.Show()
            My.Forms.frmubmedidor.WindowState = FormWindowState.Maximized
        End If
        Frmmatcalle.Select()

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim FRMA As New frmcalculasaldo
        FRMA.ShowDialog()
    End Sub



    Private Sub ButtonItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCaplecInd.Click
        FrmCaptura_Lectura_Ind.MdiParent = Me
        FrmCaptura_Lectura_Ind.modo = "Agregar"
        FrmCaptura_Lectura_Ind.Text = "Agregar Lecturas..."
        FrmCaptura_Lectura_Ind.Show()
        FrmCaptura_Lectura_Ind.Select()
        FrmCaptura_Lectura_Ind.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub ButtonItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModLecInd.Click
        FrmCaptura_Lectura_Ind.MdiParent = Me
        FrmCaptura_Lectura_Ind.modo = "Modificar"
        FrmCaptura_Lectura_Ind.Text = "Modificar Lecturas..."
        FrmCaptura_Lectura_Ind.Show()
        FrmCaptura_Lectura_Ind.Select()
        FrmCaptura_Lectura_Ind.StartPosition = FormStartPosition.CenterParent
    End Sub

    Private Sub btnElimLecInd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimLecInd.Click
        FrmCaptura_Lectura_Ind.MdiParent = Me
        FrmCaptura_Lectura_Ind.modo = "Eliminar"
        FrmCaptura_Lectura_Ind.Text = "Eliminar Lecturas..."
        FrmCaptura_Lectura_Ind.Show()
        FrmCaptura_Lectura_Ind.Select()
        FrmCaptura_Lectura_Ind.StartPosition = FormStartPosition.CenterParent




    End Sub

    Private Sub cmdRepFac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRepFac.Click

    End Sub

    Private Sub btnDescuentos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescuentos.Click
        If Not frmDescuentos.Created Then
            frmDescuentos.MdiParent = Me
            frmDescuentos.Show()
        End If
        frmDescuentos.Select()
    End Sub

    Private Sub BtnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImportar.Click
        frmimportalecturas.MdiParent = Me
        frmimportalecturas.Show()
    End Sub

    Private Sub btnRepListadoDeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepListadoDeudores.Click

    End Sub

    Private Sub btnantigu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnantigu.Click

    End Sub

    Private Sub btnAntiguResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ASEH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmaseh As New FrmAseh
        frmaseh.Show()
    End Sub

    Private Sub Btnlistadocorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlistadocorte.Click
        frmRepListadoDeudores.MdiParent = Me
        frmRepListadoDeudores.quees = "Listado de corte"
        frmRepListadoDeudores.Show()
        frmRepListadoDeudores.Select()
    End Sub




    Private Sub ButtonItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem4.Click
        Dim frmmapa As New Frmexplorer
        frmmapa.Show()

        'Dim rutaArchivoHTML As String = "mapa2.html" ' Reemplaza con la ruta real de tu archivo HTML

        'Try
        '    ' Abre el archivo HTML en el navegador predeterminado
        '    Process.Start(rutaArchivoHTML)
        'Catch ex As Exception
        '    ' Manejo de errores, por ejemplo, si el archivo no existe
        '    MessageBox.Show("Error al abrir el archivo HTML: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub ButtonItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem16.Click
        MessageBox.Show("Este reporte puede tardar 5 Minutos o más.. Sea Paciente!! !")
        Dim XREP As New frmReporte(frmReporte.Lista.antiresumen)
        XREP.TitleText = "REPORTE DE ANTIGUEDAD DE SALDOS RESUMEN"
        XREP.Text = "REPORTE DE ANTIGUEDAD DE SALDOS RESUMEN"

        XREP.WindowState = FormWindowState.Maximized

        XREP.Show()
    End Sub

    Private Sub ButtonItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem5.Click
        Dim frmzurich As New frmantiguedad
        frmzurich.Show()
    End Sub

    Private Sub ButtonItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem17.Click
        MessageBox.Show("Este reporte puede tardar 5 Minutos o más.. Sea Paciente!! !")
        Dim XREP As New frmReporte(frmReporte.Lista.antirutas)
        XREP.TitleText = "REPORTE DE ANTIGUEDAD DE SALDOS RESUMEN"
        XREP.Text = "REPORTE DE ANTIGUEDAD DE SALDOS RESUMEN"

        XREP.WindowState = FormWindowState.Maximized

        XREP.Show()
    End Sub

    Private Sub btnexpobbva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexpobbva.Click
        Dim xf As New frmEpagos
        xf.Show()
    End Sub

    Private Sub cmdCorr_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RBBancomer_Click(sender As Object, e As EventArgs) Handles RBBancomer.Click

    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnimportarcobros_Click(sender As Object, e As EventArgs)
        FrmImportarCobros.MdiParent = Me
        FrmImportarCobros.Show()
    End Sub

    Private Sub ButtonItem18_Click(sender As Object, e As EventArgs) Handles ButtonItem18.Click
        frmRepListadoDeudores.MdiParent = Me
        frmRepListadoDeudores.quees = "Listado de deudores"
        frmRepListadoDeudores.Show()
        frmRepListadoDeudores.Select()
    End Sub

    Private Sub ButtonItem19_Click(sender As Object, e As EventArgs) Handles ButtonItem19.Click
        frmRepListadoDeudores.MdiParent = Me
        frmRepListadoDeudores.quees = "Listado de deudores Nombre"
        frmRepListadoDeudores.Show()
        frmRepListadoDeudores.Select()
    End Sub

    Private Sub btnRubros_Click(sender As Object, e As EventArgs) Handles btnRubros.Click
        Dim listarubros As New LtsRubros
        listarubros.MdiParent = Me
        listarubros.Show()
        listarubros.Select()
    End Sub

    Private Sub Importarpagos_Click(sender As Object, e As EventArgs) Handles Importarpagos.Click
        Dim xf As New Formulario
        xf.ShowDialog()
    End Sub

    Private Sub BtnEmpresa_Click_1(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        If Not FrmEmpresa.Created Then
            FrmEmpresa.MdiParent = Me
            FrmEmpresa.Show()
            FrmEmpresa.WindowState = FormWindowState.Maximized
        End If
        FrmEmpresa.Select()
    End Sub


    Public Sub llenaopciones()
        tabla.Clear()

        Dim us As IDataReader = ConsultaSql("Select *  from menu where ccodmenu = " & NumUser & "").ExecuteReader
        Do While us.Read
            tabla.Add(us("nombre"), CBool(us("valor")))

        Loop
        Dim tipo As String

        For Each elemento In MDIMenu.Items
            tipo = elemento.GetType().Name
            If tipo = "RibbonTabItem" Then
                Dim tem As RibbonTabItem
                tem = TryCast(elemento, RibbonTabItem)
                If tem.Visible Then
                    elemento.Visible = tabla(tem.Name)
                End If
                For Each elementorb In tem.Panel.Controls
                    Dim tipo2 As String = elementorb.GetType().Name

                    If tipo2 = "RibbonBar" Then
                        Dim tem2 As RibbonBar
                        tem2 = TryCast(elementorb, RibbonBar)
                        For Each bt In tem2.Items
                            Dim tipo3 As String = bt.GetType().Name
                            If tipo3 = "ButtonItem" Then
                                Dim tem3 As ButtonItem
                                tem3 = TryCast(bt, ButtonItem)
                                If tem3.Visible Then
                                    bt.Visible = tabla(tem3.Name)
                                    ' bt.Visible = True
                                End If


                            End If
                        Next
                    End If
                Next



            End If


        Next



        us.Close()




    End Sub

    Private Sub rbOrdt_ItemClick(sender As Object, e As EventArgs) Handles rbOrdt.ItemClick

    End Sub

    Private Sub cmdCompAde_Click(sender As Object, e As EventArgs) Handles cmdCompAde.Click
        Dim xr As New FRMREPcat
        xr.MdiParent = Me
        xr.Show()
    End Sub

    Private Sub cmdAcept_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdVisualizar_Click(sender As Object, e As EventArgs)
        Try



        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnim_Click(sender As Object, e As EventArgs)
        Dim imp As New Imprimirnet
        Dim ali As Lineaimprimir.alineacion
        Dim impresora As String = ""
        impresora = imp.prtSettings.PrinterName
        Dim nombredeempresa = obtenerCampo("select * from empresa limit 1", "cnombre")
        imp.imprimir(430, 20, nombredeempresa, ali.Centrado, "ARIAL", 11)
        Dim po = obtenerCampo("select * from empresa limit 1", "cdomicilio")
        imp.imprimir(50, 40, po, ali.Izquierda, "ARIAL", 10)
        Dim texto As String = "Estadística de padrón de usuarios"
        imp.imprimir(500, 60, texto, ali.Centrado, "ARIAL", 11)

        Dim linea As Int16 = 95
        Dim altofila As Int16 = 15
        For i As Int16 = 0 To frmConvenio.dataConv.RowCount - 1
            Dim celda1 As String = frmConvenio.dataConv.Rows(i).Cells(0).Value
            imp.imprimir(50, linea, celda1, ali.Izquierda, "ARIAL", 8)
            Dim celda2 As String = frmConvenio.dataConv.Rows(i).Cells(1).Value
            imp.imprimir(500, linea, celda2, ali.Centrado, "ARIAL", 8)
            Dim celda3 As String = frmConvenio.dataConv.Rows(i).Cells(3).Value
            imp.imprimir(650, linea, celda3, ali.Centrado, "ARIAL", 10)
            linea += altofila

        Next
        imp.mandardocumento(False)
    End Sub

    Private Sub convenios_Click(sender As Object, e As EventArgs) Handles convenios.Click
        If Not ListConvenios.Created Then
            'frmBusUsuario.filtro("select distinct cuenta as Cuenta,cuentaAnterior, nombre as Nombre , comunidad as Comunidad,Direccion,estado as Estado,nodemedidor as Medidor,catastral  from vusuario order by cuenta ")
            ListConvenios.MdiParent = Me
            ListConvenios.WindowState = 2
            ListConvenios.Show()
        End If
        ListConvenios.Select()
    End Sub

    Private Sub RbAdministracion_Click(sender As Object, e As EventArgs) Handles RbAdministracion.Click

    End Sub

    Private Sub LabelItem2_Click(sender As Object, e As EventArgs) Handles LabelItem2.Click

    End Sub

    Private Sub RibbonBar3_ItemClick(sender As Object, e As EventArgs) Handles RibbonBar3.ItemClick
        If Not FrmSolicitudPipa.Created Then
            'frmBusUsuario.filtro("select distinct cuenta as Cuenta,cuentaAnterior, nombre as Nombre , comunidad as Comunidad,Direccion,estado as Estado,nodemedidor as Medidor,catastral  from vusuario order by cuenta ")
            'FrmSolicitudPipa.MdiParent = Me
            'FrmSolicitudPipa.WindowState = 2
            'FrmSolicitudPipa.Size = New System.Drawing.Size(100, 100)
            FrmSolicitudPipa.Show()

            'FrmSolicitudPipa.WindowState = FormWindowState.Minimized
        End If
        FrmSolicitudPipa.Select()
    End Sub

    Private Sub ButtonItem6_Click_1(sender As Object, e As EventArgs) Handles ButtonItem6.Click
        Dim frmNotif As New frmNotificaciones
        frmNotif.MdiParent = Me
        frmNotif.Show()
    End Sub

    Private Sub ButtonItem8_Click_1(sender As Object, e As EventArgs)

        'Cartera Vencida
    End Sub

    Private Sub btnimportarcobros_Click_1(sender As Object, e As EventArgs) Handles btnimportarcobros.Click

    End Sub

    Private Sub RibbonBar12_ItemClick(sender As Object, e As EventArgs) Handles RibbonBar12.ItemClick

    End Sub

    Private Sub btnPeriodoLecturas_Click(sender As Object, e As EventArgs)
        'Dim objPeriodoMoviles As New PeriodoLecturas
        'objPeriodoMoviles.ShowDialog()

    End Sub

    Private Sub BtnLecturasNoCapturadas_Click(sender As Object, e As EventArgs) Handles BtnLecturasNoCapturadas.Click
        If Not frmRepLecturasnoCapturadas.Created Then
            frmRepLecturasnoCapturadas.MdiParent = Me
            frmRepLecturasnoCapturadas.Show()
        End If
        frmRepLecturasnoCapturadas.Select()
    End Sub





    Private Sub ButtonItem8_Click_2(sender As Object, e As EventArgs)
        Dim objPeriodoMoviles As New PeriodoLecturas
        objPeriodoMoviles.ShowDialog()
    End Sub

    Private Sub ButtonComerciales_Click(sender As Object, e As EventArgs)
        If Not frmOrdTrab.Created Then
            My.Forms.frmOrdTrab.MdiParent = Me
            My.Forms.frmOrdTrab.MaximizeBox = True


            My.Forms.frmOrdTrab.Show()

        End If

        frmOrdTrab.Select()
    End Sub

    Private Sub ButtonMoviles_Click(sender As Object, e As EventArgs) Handles ButtonMoviles.Click
        Dim objPeriodoMoviles As New PeriodoLecturas
        objPeriodoMoviles.ShowDialog()
    End Sub

    Private Sub RibBtnRespaldo_Click(sender As Object, e As EventArgs) Handles RibBtnRespaldo.Click
        'RespaldarBD()
        RespaldarDataBase()
    End Sub

    Private Sub RibbonBar11_ItemClick(sender As Object, e As EventArgs) Handles RibbonBar11.ItemClick



    End Sub

    Private Sub BtnConfiguracion_Click_1(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        Dim conf As New frmconfiguracion
        conf.Show()
    End Sub

    Private Sub ButtonItem8_Click_3(sender As Object, e As EventArgs) Handles ButtonItem8.Click
        If Not FrmReportexrubros.Created Then
            FrmReportexrubros.MdiParent = Me
            FrmReportexrubros.tipo = "RECONEXIONES"
            FrmReportexrubros.Show()
        End If
        FrmReportexrubros.Select()
    End Sub

    Private Sub ButtonItem9_Click_2(sender As Object, e As EventArgs) Handles ButtonItem9.Click
        If Not FrmReportexrubros.Created Then
            FrmReportexrubros.MdiParent = Me
            FrmReportexrubros.tipo = "CAJA"
            FrmReportexrubros.Show()
        End If
        FrmReportexrubros.Select()
    End Sub

    Private Sub btncorteconc_Click(sender As Object, e As EventArgs) Handles btncorteconc.Click
        If Not FrmReportexrubros.Created Then
            FrmReportexrubros.MdiParent = Me
            FrmReportexrubros.tipo = "CONCEPTOS"
            FrmReportexrubros.Show()
        End If
        FrmReportexrubros.Select()
    End Sub

    Private Sub ButtonItem10_Click_2(sender As Object, e As EventArgs) Handles ButtonItem10.Click
        If Not FrmReportexrubros.Created Then
            FrmReportexrubros.MdiParent = Me
            FrmReportexrubros.tipo = "CAJADESGLOSADO"
            FrmReportexrubros.Show()
        End If
        FrmReportexrubros.Select()
    End Sub

    Private Sub btnpensionado_Click(sender As Object, e As EventArgs) Handles btnpensionado.Click
        If Not frmPensionado.Created Then
            frmPensionado.MdiParent = Me

            frmPensionado.Show()
        End If
        frmPensionado.Select()

    End Sub

    Private Sub ButtonItem11_Click_1(sender As Object, e As EventArgs) Handles ButtonItem11.Click
        If Not frmrepaltaconsumidor.Created Then
            frmrepaltaconsumidor.MdiParent = Me

            frmrepaltaconsumidor.Show()
        End If
        frmrepaltaconsumidor.Select()
    End Sub
End Class
