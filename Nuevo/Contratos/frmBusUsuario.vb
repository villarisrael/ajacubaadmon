Imports DevComponents.DotNetBar

Public Class frmBusUsuario
    Dim so As New BindingSource
    Dim vista As DataView
    Private _evento As eve
    Private _frm As Object
    Private sqlgeneral As String = ""
    Dim yn As Boolean = True
    Dim intFila As Integer
    Public Cuenta As Double
    Public Comunidad As String
    Dim idletra As IDataReader = Nothing

#Region "Constructores"
    Public Sub New(ByVal evento As Int16, ByVal frm As Form)
        InitializeComponent()
        _evento = evento
        If evento = eve.Multas Then
            _frm = New frmagrmov
            _frm = frm



        End If
        cmdFiltro.Visible = False
    End Sub

    Public Sub New(ByVal evento As Int16)
        InitializeComponent()
        _evento = evento
    End Sub

    Public Sub New()
        InitializeComponent()
        _evento = eve.Contratos
    End Sub
#End Region

#Region "Modificadores"
    Public Property _sqlgeneral() As String
        Get
            Return sqlgeneral
        End Get
        Set(ByVal value As String)
            sqlgeneral = value
        End Set
    End Property
#End Region

    Private Sub frmBusUsuario_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub frmBusUsuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub frmBusUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub frmBusUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idletra = ConsultaSql("select * from letras where ccodusuario=" & NumUser & "").ExecuteReader()
        idletra.Read()
        'If CBool(idletra("MostrarContrato")) Then cmdVisualizar.Visible = True Else cmdVisualizar.Visible = False
        'If CBool(idletra("NuevoContrato")) Then BtnNuevo.Visible = True Else BtnNuevo.Visible = False
        'If CBool(idletra("EditCont")) Then cmdContrato.Visible = True Else cmdContrato.Visible = False
        'If CBool(idletra("Instalacion")) Then cmdInstaB.Visible = True Else cmdInstaB.Visible = False
        'If CBool(idletra("Activacion")) Then cmdActi.Visible = True Else cmdActi.Visible = False
        'If CBool(idletra("CambioNombre")) Then cmdCamNom.Visible = True Else cmdCamNom.Visible = False
        'If CBool(idletra("CambioMedidor")) Then cmdCamMed.Visible = True Else cmdCamMed.Visible = False
        'If CBool(idletra("CambioTarifa")) Then cmdCamTar.Visible = True Else cmdCamTar.Visible = False
        'If CBool(idletra("BajTem")) Then cmdDarBaja.Visible = True Else cmdDarBaja.Visible = False
        'If CBool(idletra("BajDef")) Then cmdBajaDef.Visible = True Else cmdBajaDef.Visible = False
        'If CBool(idletra("ReacCuen")) Then cmdReacti.Visible = True Else cmdReacti.Visible = False



        If Me.MdiParent Is Nothing Then
            ToolBar.Visible = False
            Me.Text = "Buscar Usuario"
        Else
            ToolBar.Visible = True
            Me.Text = "Padron de Usuario"
        End If

        Actualizar()
        dgvUsuario_Click(New Object, New System.EventArgs)

        'Try
        '    Select Case dgvUsuario.Item("Estado", dgvUsuario.CurrentRow.Index).Value
        '        Case "activo"
        '            cmdInstaB.Enabled = False
        '            cmdActi.Enabled = False
        '            cmdCamNom.Enabled = True
        '            cmdCamMed.Enabled = True
        '            cmdCamTar.Enabled = True
        '            cmdDarBaja.Enabled = True
        '            cmdBajaDef.Enabled = True
        '            cmdReacti.Enabled = False
        '        Case "baja temporal"
        '            cmdInstaB.Enabled = False
        '            cmdActi.Enabled = False
        '            cmdCamNom.Enabled = False
        '            cmdCamMed.Enabled = False
        '            cmdCamTar.Enabled = False
        '            cmdDarBaja.Enabled = False
        '            cmdBajaDef.Enabled = True
        '            cmdReacti.Enabled = True
        '        Case "inactiva"
        '            cmdInstaB.Enabled = True
        '            cmdActi.Enabled = False
        '            cmdCamNom.Enabled = False
        '            cmdCamMed.Enabled = False
        '            cmdCamTar.Enabled = False
        '            cmdDarBaja.Enabled = False
        '            cmdBajaDef.Enabled = False
        '            cmdReacti.Enabled = False
        '        Case "baja"
        '            cmdInstaB.Enabled = False
        '            cmdActi.Enabled = False
        '            cmdCamNom.Enabled = False
        '            cmdCamMed.Enabled = False
        '            cmdCamTar.Enabled = False
        '            cmdDarBaja.Enabled = False
        '            cmdBajaDef.Enabled = False
        '            cmdReacti.Enabled = True
        '        Case "preparada"
        '    End Select
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmdFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltro.Click
        'Dim frm As New frmPerFiltro
        so.Filter = Nothing
        frmPerFiltro = Nothing
        If cmdFiltro.Text = "Filtrar" Then
            My.Forms.frmPerFiltro.ShowDialog()
            If My.Forms.frmPerFiltro.consulta <> "" Then
                filtro(My.Forms.frmPerFiltro.consulta)
                'Else
                '    filtro("select cuenta as Cuenta, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as Número_exterior, numint as 'Número interior', estado as Estado  from vusuario where comunidad =""" & My.Forms.MDIPrincipal.CMBCOMUNIDAD.SelectedItem & """ ")
            Else
                Exit Sub
            End If
            cmdFiltro.Text = "Quitar Filtro"
            cmdFiltro.Icon = My.Resources.Salir16
        Else
            'filtro("select cuenta as Cuenta, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as 'Número exterior', numint as 'Número interior',estado as Estado  from vusuario order by cuenta, comunidad ")
            filtro("select distinct cuenta as Cuenta, nombre as Nombre , domicilio as Direccion,comunidad as Comunidad,estado as Estado,nodemedidor as Medidor,Ubicacion,nodeperiodo as Periodos, periodoadeudo as Periodo,consumo as agua,  deudaagua AS RezagoAgua, alcaconsumo as alcantarillado, Deudaalcantarillado as Rezagoalcantarillado,Otros, recargos,iva,Total  from vusuario order by cuenta")
            My.Forms.frmPerFiltro.Refresh()
            cmdFiltro.Text = "Filtrar"
            cmdFiltro.Icon = My.Resources._16__Filter_2_
        End If


        yn = True
    End Sub

    Public Sub filtro(ByVal sql As String)
        'so.DataSource = Nothing
        'dgvUsuario.DataSource = Nothing

        vista = llenarVista(sql)
        sqlgeneral = sql
        so.DataSource = vista
        dgvUsuario.DataSource = so
        Try
            dgvUsuario.Item(0, intFila).Selected = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Dim cad As String
        cad = "Introduzca el campo:  " & dgvUsuario.Columns.Item(dgvUsuario.CurrentCell.ColumnIndex).HeaderText

        Dim frm As frmFiltro
        If _evento <> eve.Multas And _evento <> eve.Cobros And _evento <> eve.Convenios Then
            Try
                frm = New frmFiltro(cad, dgvUsuario.Columns.Item(dgvUsuario.CurrentCell.ColumnIndex).DataPropertyName, Me)
                frm.ShowDialog()
                frm.Close()
            Catch ex As Exception
            End Try
        Else
            Try
                frm = New frmFiltro(cad, dgvUsuario.Columns.Item(dgvUsuario.CurrentCell.ColumnIndex).DataPropertyName, Me)
                frm.ShowDialog()
                frm.Close()

            Catch ex As Exception
            End Try
        End If

    End Sub

    Public Sub consulta(ByVal cad As String)
        so.Filter = cad
    End Sub

    Public Sub iniciar()
        so.Filter = Nothing
    End Sub


    Private Sub cmdMuestra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMuestra.Click
        Try
            DataTableToExcel(CType(Me.vista.Table, DataTable), 10)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdMuestra2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMuestra2.Click
        Try
            DataTableToExcel(CType(Me.vista.Table, DataTable), 13)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmdMuestra3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMuestra3.Click
        Try
            DataTableToExcel(CType(Me.vista.Table, DataTable), 12)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvUsuario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuario.CellClick
        intFila = e.RowIndex
    End Sub

    Private Sub dgvUsuario_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvUsuario.CellFormatting

        If yn Then
            Try
                If LCase(dgvUsuario.Item("Estado", e.RowIndex).Value) = "funcionando" Then
                    dgvUsuario.Item("Estado", e.RowIndex).Style.BackColor = Color.LightGreen
                ElseIf LCase(dgvUsuario.Item("Estado", e.RowIndex).Value) = "baja temporal" Then
                    dgvUsuario.Item("Estado", e.RowIndex).Style.BackColor = Color.Orange
                ElseIf LCase(dgvUsuario.Item("Estado", e.RowIndex).Value) = "inactivo" Then
                    dgvUsuario.Item("Estado", e.RowIndex).Style.BackColor = Color.Gray
                ElseIf LCase(dgvUsuario.Item("Estado", e.RowIndex).Value) = "baja" Then
                    dgvUsuario.Item("Estado", e.RowIndex).Style.BackColor = Color.Red
                ElseIf LCase(dgvUsuario.Item("Estado", e.RowIndex).Value) = "preparada" Then
                    dgvUsuario.Item("Estado", e.RowIndex).Style.BackColor = Color.Blue
                End If

                If dgvUsuario.Columns(e.ColumnIndex).Name = "Cuenta" Then
                    llenaceros(e)
                End If
            Catch err As Exception
                yn = False
            End Try
        End If
    End Sub

    Private Sub llenaceros(ByVal formatting As DataGridViewCellFormattingEventArgs)
        llenarcero(formatting.Value, 7)
        formatting.FormattingApplied = True
    End Sub
    Private Sub dgvUsuario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUsuario.Click
        Try
            Dim estado As String = (dgvUsuario.Item("Estado", dgvUsuario.CurrentRow.Index).Value).ToString().ToLower()

            Select Case estado
                Case "funcionando"
                    cmdInstaB.Enabled = False
                    cmdActi.Enabled = False
                    cmdCamNom.Enabled = True
                    cmdCamMed.Enabled = True
                    cmdCamTar.Enabled = True
                    cmdDarBaja.Enabled = True
                    cmdBajaDef.Enabled = True
                    cmdReacti.Enabled = False


                Case "baja temporal"
                    cmdInstaB.Enabled = False
                    cmdActi.Enabled = False
                    cmdCamNom.Enabled = False
                    cmdCamMed.Enabled = False
                    cmdCamTar.Enabled = False
                    cmdDarBaja.Enabled = False
                    cmdBajaDef.Enabled = True
                    cmdReacti.Enabled = True
                Case "inactivo"
                    cmdInstaB.Enabled = True
                    cmdActi.Enabled = False
                    cmdCamNom.Enabled = False
                    cmdCamMed.Enabled = False
                    cmdCamTar.Enabled = False
                    cmdDarBaja.Enabled = False
                    cmdBajaDef.Enabled = False
                    cmdReacti.Enabled = True
                Case "baja"
                    cmdInstaB.Enabled = False
                    cmdActi.Enabled = False
                    cmdCamNom.Enabled = False
                    cmdCamMed.Enabled = False
                    cmdCamTar.Enabled = False
                    cmdDarBaja.Enabled = False
                    cmdBajaDef.Enabled = False
                    cmdReacti.Enabled = False
                Case "preparada"
                    cmdInstaB.Enabled = False
                    cmdActi.Enabled = True
                    cmdCamNom.Enabled = False
                    cmdCamMed.Enabled = False
                    cmdCamTar.Enabled = False
                    cmdDarBaja.Enabled = False
                    cmdBajaDef.Enabled = False
                    cmdReacti.Enabled = False

            End Select
        Catch ex As Exception

        End Try

    End Sub
    Private Sub dgvUsuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvUsuario.DoubleClick
        Dim s As Object = Nothing, ee As New KeyPressEventArgs(CChar(Chr(13)))
        Dim e1 As New EventArgs
        If _evento = eve.Multas Then
            Try
                _frm.cuenta = dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
                _frm.idcom = dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value
                Close()
            Catch err As Exception
                MessageBoxEx.Show("Para ésta utilidad agregue el campo comunidad y cuenta en su consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        ElseIf _evento = eve.Cobros Then
            Try
                'frmCajas.txtCuenta.Text = dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
                'frmCajas.cmbComu.SelectedValue = obtenerCampo("Select id_comunidad from comunidades where comunidad='" & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & "'", "id_comunidad")
                'frmCajas.cmdAceptar_Click(s, e1)
                Close()
            Catch ex As Exception
            End Try
        ElseIf _evento = eve.Convenios Then
            Try
                Cuenta = dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
                Comunidad = dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value 'obtenerCampo("Select id_comunidad from comunidades where comunidad='" & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & "'", "id_comunidad")
                Close()
            Catch ex As Exception

            End Try

        Else
            ee.Handled = True
        End If
    End Sub

    Private Sub cmdContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdContrato.Click
        Try
            Dim FRMCONTRA = New frmcontrato(frmcontrato._vengode.solicitud)
            FRMCONTRA.mestado = frmcontrato.Estado.Editar
            FRMCONTRA.cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
            FRMCONTRA.idcomacargar = obtenerCampo("select id_comunidad from comunidades where comunidad=""" & Me.dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & """", "id_comunidad")
            FRMCONTRA.MdiParent = MDIPrincipal
            FRMCONTRA.Text = "Contrato de la Cuenta " & Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value & " de la comunidad " & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value
            FRMCONTRA.mestado = frmcontrato.Estado.Editar
            FRMCONTRA.WindowState = FormWindowState.Maximized

            FRMCONTRA.Show()
        Catch ex As Exception

        End Try

        ' Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim cadena As String = "SELECT `usuario1`.`CUENTA`, `usuario1`.`NOMBRE`, `colonia1`.`Colonia`, `comunidades1`.`Comunidad`, `calles1`.`NOMBRE`, `usuario1`.`numext`, `usuario1`.`numint`, `usuario1`.`ubicacion` FROM   ((`usuario` `usuario1` INNER JOIN `colonia` `colonia1` ON (`usuario1`.`id_colonia`=`colonia1`.`id_colonia`) AND (`usuario1`.`id_comunidad`=`colonia1`.`id_comunidad`)) INNER JOIN `comunidades` `comunidades1` ON `usuario1`.`id_comunidad`=`comunidades1`.`Id_comunidad`) INNER JOIN `calles` `calles1` ON  (`usuario1`.`id_calle`=`calles1`.`ID_CALLE`)"
        cadena &= ""
    End Sub

    Private Sub cmdCamNom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCamNom.Click
        Dim FrmCam As New FrmCambioNombre
        'FrmCam.MdiParent = MDIPrincipal
        Try
            FrmCam.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
            FrmCam.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
            FrmCam.Text = "Cambio de Nombre Cuenta " & dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value & " Comunidad " & dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
            FrmCam.ShowDialog()

            FrmCam.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            MessageBox.Show("No has seleccionado un registro")
        End Try

    End Sub

    Private Sub cmdCamMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCamMed.Click
        Dim FrmCam As New FrmCambioMedidor
        'FrmCam.MdiParent = MDIPrincipal
        FrmCam.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
        FrmCam.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        FrmCam.Text = "Cambio de Medidor Cuenta " & dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value & " Comunidad " & dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        FrmCam.TxtMotivo.Text = ""
        FrmCam.BtnAceptar.Enabled = True
        FrmCam.ShowDialog()
        FrmCam.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdCamTar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCamTar.Click
        Dim FrmCam As New FrmCambioTarifa
        ' FrmCam.MdiParent = MDIPrincipal
        FrmCam.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
        FrmCam.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        FrmCam.Text = "Cambio de Tarifa de la cuenta " & dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value & " Comunidad " & dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        FrmCam.TxtMotivo.Text = ""
        FrmCam.BtnAceptar.Enabled = True
        FrmCam.ShowDialog()
        FrmCam.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim FrmContra As New frmcontrato(frmcontrato._vengode.nuevocont)
        FrmContra.MdiParent = MDIPrincipal
        FrmContra.Show()
        FrmContra.WindowState = FormWindowState.Normal
    End Sub
    Private Sub cmdDarBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDarBaja.Click
        'FrmDarDeBaja.MdiParent = MDIPrincipal
        Dim x As New FrmDarDeBaja

        Dim _clacomu As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value & "'", "id_comunidad")
        Dim ahoy As Double = 0
        Try
            ahoy = obtenerCampo("select total from usuario where cuenta=" & dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value & ") ", "total")
        Catch ex As Exception
            ahoy = 0
        End Try


        If ahoy > 0 Then
            MessageBoxEx.Show("No se pueda cambiar el estado de la toma a baja temporal, por que tiene un monto de " & FormatCurrency(ahoy, 2) & " pesos sin pagar", "Baja temporal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            x.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
            x.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
            x.Enabled = True
            x.TxtMotivo.Text = ""
            x.ShowDialog()
        End If
    End Sub
    Private Sub cmdReacti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReacti.Click
        FrmReactivar.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
        FrmReactivar.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        FrmReactivar.BtnAceptar.Enabled = True
        FrmReactivar.TxtMotivo.Text = ""
        FrmReactivar.ShowDialog()
    End Sub
    Public Sub Actualizar()
        filtro("select distinct cuenta as Cuenta, nombre as Nombre , domicilio as Direccion,comunidad as Comunidad,estado as Estado,nodemedidor as Medidor,Ubicacion,nodeperiodo as Periodos, periodoadeudo as Periodo,consumo as agua,  deudaagua AS RezagoAgua, alcaconsumo as alcantarillado, Deudaalcantarillado as Rezagoalcantarillado,Otros, recargos,iva,Total  from vusuario order by cuenta")
    End Sub
    Private Sub cmbAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAct.Click
        so.Filter = Nothing
    End Sub
    Private Sub IMPRIMIRESTADODECUENTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMIRESTADODECUENTAToolStripMenuItem.Click
        Try
            Dim Cuenta As String = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
            Dim comunidad As String = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
            Dim Impr As New FrmTipoImprContrato(Cuenta, comunidad)
            Impr.Rbcomprconcargo.Checked = True

            Impr.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub cmdInstaB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInstaB.Click
        Try
            Dim frm As New frmInsta(Val(Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value), obtenerCampo("select id_comunidad from comunidades where comunidad=""" & Me.dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & """", "id_comunidad"))
            'frm.MdiParent = My.Forms.MDIPrincipal
            frm.ShowDialog()
            frm.WindowState = FormWindowState.Normal
        Catch ex As Exception
            MessageBoxEx.Show("Establezca la columna comunidad o cuenta para ejecutar esta acción")
        End Try
    End Sub
    Private Sub cmdActi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdActi.Click
        Dim frm As New FrmActivarCuenta
        Dim estado As String = ""
        Dim fcambio As Date = Nothing

        Try
            estado = obtenerCampo("Select estado from vusuario where comunidad='" & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & "' and cuenta=" & dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value & "", "estado")
            frm.Comunidad = dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value
            frm.Cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
            If estado = "Activo" Then
                Try
                    fcambio = obtenerCampo("Select fechacambio from activaciones where id_comunidad='" & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & "' and cuenta=" & dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value & "", "estado")
                    MessageBoxEx.Show("La cuenta fue activada el día " & fcambio & ", no necesita que se active de nuevo", "Activación de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBoxEx.Show("La cuenta ya está activada, no necesita que se active de nuevo", "Activación de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Exit Sub

                ' frm.lblMen.Text = "La cuenta está activada, no necesita que se active de nuevo"
                'frm.BtnAceptar.Enabled = False
            Else
                frm.lblMen.Text = ""
                frm.BtnAceptar.Enabled = True
            End If
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisualizar.Click
        Try
            Dim FRMCONTRA = New frmcontrato(frmcontrato._vengode.solicitud)
            FRMCONTRA.cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
            FRMCONTRA.idcomacargar = obtenerCampo("select id_comunidad from comunidades where comunidad=""" & Me.dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value & """", "id_comunidad")
            FRMCONTRA.MdiParent = MDIPrincipal
            FRMCONTRA.Text = "Contrato de la Cuenta " & Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value & " de la comunidad " & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value
            FRMCONTRA.mestado = frmcontrato.Estado.Visualizar
            FRMCONTRA.Show()
            ' FRMCONTRA.WindowState = FormWindowState.Normal
        Catch ex As Exception
            MessageBox.Show("No has seleccionado un contrato correctamente")
        End Try

    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub
    Private Sub cmdBajaDef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBajaDef.Click

        Dim x As New FrmBajaDefinitiva
        Dim _clacomu As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value & "'", "id_comunidad")
        Dim ahoy As Double = 0
        Try
            ahoy = obtenerCampo("select ahoy('" & _clacomu & "'," & dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value & ") as hoy", "hoy")
        Catch ex As Exception
            ahoy = 0
        End Try

        If ahoy > 0 Then
            MessageBoxEx.Show("No se pueda cambiar el estado de la toma a baja definitiva, por que tiene un monto de " & FormatCurrency(ahoy, 2) & " pesos sin pagar", "Baja temporal", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            x.Cuenta = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
            x.Comunidad = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
            x.ShowDialog()
        End If
    End Sub



    Private Sub btnsuspender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuspender.Click
        Dim frmsus As New frmsuspendervb
        frmsus.lblcuenta.Text = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblcomunidad.Text = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblnombre.Text = dgvUsuario.Item("Nombre", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblcalle.Text = dgvUsuario.Item("Direccion", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblmedidor.Text = dgvUsuario.Item("Medidor", dgvUsuario.CurrentRow.Index).Value
        frmsus.Show()
    End Sub

    Private Sub btnconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconectar.Click
        Dim frmsus As New frmsuspendervb
        frmsus.lblcuenta.Text = dgvUsuario.Item("Cuenta", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblcomunidad.Text = dgvUsuario.Item("Comunidad", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblnombre.Text = dgvUsuario.Item("Nombre", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblcalle.Text = dgvUsuario.Item("Direccion", dgvUsuario.CurrentRow.Index).Value
        frmsus.lblmedidor.Text = dgvUsuario.Item("Medidor", dgvUsuario.CurrentRow.Index).Value
        frmsus.Modo = "Conectar"

        frmsus.Show()
    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Try
            DataTableToExcel(CType(Me.vista.Table, DataTable), 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDatosfiscales_Click(sender As Object, e As EventArgs) Handles btnDatosfiscales.Click
        Try
            Dim FRMCONTRA = New frmdatosfiscales

            FRMCONTRA.cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value

            '  FRMCONTRA.MdiParent = MDIPrincipal
            FRMCONTRA.Text = "Datos fiscales de la Cuenta " & Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value & " de la comunidad " & dgvUsuario.Item("comunidad", dgvUsuario.CurrentRow.Index).Value

            FRMCONTRA.WindowState = FormWindowState.Normal

            FRMCONTRA.Show()
        Catch ex As Exception
            MessageBox.Show("Posiblemente no has seleccionado un registro")
        End Try

    End Sub

    Private Sub ToolBar_Click(sender As Object, e As EventArgs) Handles ToolBar.Click

    End Sub

    Private Sub rbOpciones_ItemClick(sender As Object, e As EventArgs) Handles rbOpciones.ItemClick

    End Sub

    Private Sub btnCompro_Click(sender As Object, e As EventArgs) Handles btnCompro.Click
        Try
            Dim frmTipoImpContrat As New FrmTipoImprContrato
            frmTipoImpContrat.Cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value
            frmTipoImpContrat.Rbcomprconcargo.Checked = True
            frmTipoImpContrat.Show()
        Catch ex As Exception
            MessageBox.Show("Posiblemente no has seleccionado un registro")
        End Try

    End Sub

    Private Sub btnbitacora_Click(sender As Object, e As EventArgs) Handles btnbitacora.Click
        Try
            Dim frmTipoImpContrat As New FrmBitacora
            frmTipoImpContrat.Cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value

            frmTipoImpContrat.Show()
        Catch ex As Exception
            MessageBox.Show("Posiblemente no has seleccionado un registro")
        End Try
    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        Try
            Dim frmTipoImpContrat As New FrmAgrBitacora
            frmTipoImpContrat.Cuenta = Me.dgvUsuario.Item("cuenta", dgvUsuario.CurrentRow.Index).Value

            frmTipoImpContrat.Show()
        Catch ex As Exception
            MessageBox.Show("Posiblemente no has seleccionado un registro")
        End Try
    End Sub
End Class