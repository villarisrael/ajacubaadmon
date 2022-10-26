Imports DevComponents.DotNetBar

Public Class frmagrmov
    Dim TipDescuento As String

#Region "Variables"
    Public evento As String
    Private conce As New conceptocxc
    Private even As eve
    Public cadena As String
    Public foliocontrato As Long
    Public nombre As String
    Public idcomunidad As String
    Private _cuenta As String
    Private idusu As IDataReader
    Private _tipoAcceso As acceso
    Private _clave As Double
    Dim exis As Boolean = False
    Dim _Can As Boolean = False
    Enum acceso
        Agregar
        Modificar
    End Enum
#End Region

#Region "Constructores"

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        'conectar()
        DTPicker1.Value = Now
        Txtconcepto.AllowDrop = True
        LBLNOMBRE.Text = nombre
        lblfoliodecontrato.Text = foliocontrato

        ' End If
        dtfven.MinDate = DTPicker1.Value

        evento = "Todos"
        even = eve.Todos
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ByVal eventem As Int16, ByVal foliocon As Long, ByVal nom As String, ByVal idcom As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        'conectar()
        DTPicker1.Value = Now
        Txtconcepto.AllowDrop = True

        txtCuenta.Text = foliocon
        txtCuenta.Enabled = False

        If nom <> "" Then
            LBLNOMBRE.Text = nom
        Else
            LBLNOMBRE.Text = nombre
        End If

        If foliocon <> 0 Or Not foliocon <> Nothing Then
            lblfoliodecontrato.Text = foliocon
        Else
            lblfoliodecontrato.Text = foliocontrato
        End If


        ' End If
        dtfven.MinDate = DTPicker1.Value


        even = eventem

        evento = conce.conce(even)
        foliocontrato = foliocon
        nombre = nom
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


        If even = eve.Abonos Then
            ExpandablePanel1.Visible = False
        Else
            ExpandablePanel1.Visible = True
        End If

    End Sub

    Public Sub New(ByVal eventem As Int16, ByVal tipa As acceso, Optional ByVal clave As Double = 0)
        Dim idotr As IDataReader = Nothing
        InitializeComponent()
        'conectar()
        DTPicker1.Value = Now
        Txtconcepto.AllowDrop = True
        LBLNOMBRE.Text = nombre
        lblfoliodecontrato.Text = foliocontrato
        ' End If
        dtfven.MinDate = DTPicker1.Value
        even = eventem
        If even = eve.Abonos Then
            ExpandablePanel1.Visible = False
        Else
            ExpandablePanel1.Visible = True
        End If
        If even = eve.Multas Or even = eve.Abonos Then
            cmdBuscar.Visible = True
            txtCuenta.Visible = True

            nombre = "Especifique el usuario"
        End If
        evento = conce.conce(even)
        _tipoAcceso = tipa
        txtCuenta.Enabled = True

        If _tipoAcceso = acceso.Modificar Then
            idotr = ConsultaSql("select * from otrosconceptos where clave=" & clave & "").ExecuteReader()
            idotr.Read()
            If Not IsDBNull(idotr("fec_apli")) Then DTPicker1.Value = idotr("fec_apli") Else DTPicker1.Value = Nothing
            Txtidconcepto.Text = idotr("folio")
            Txtconcepto.Text = idotr("concepto")
            dtfven.Value = idotr("vencimiento")
            txtdetalle.Text = idotr("motivo")
            lbltipomov.Text = idotr("tipo_mov")
            cadena = idotr("concepto")
            txtCuenta.Text = cuenta
            cuenta = idotr("cuenta")

            llenaporcadena()
            TxtMonto.Text = idotr("Subtotal")
            LblIva.Text = idotr("Iva")
            LblTotal.Text = idotr("total")

            nombre = obtenerCampo("select nombre from usuario where cuenta=" & cuenta & " ", "nombre")
            _clave = clave
            txtCuenta.Enabled = False

            llenarDatUsu()
            ExpandablePanel1.Visible = True
        End If
    End Sub

#End Region

#Region "Modificadores"

    Public Property cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
            txtCuenta.Text = value
            If idcomunidad <> "" Then
                llenarDatUsu()
            End If
        End Set
    End Property

    Public Property idcom() As String
        Get
            Return idcomunidad
        End Get
        Set(ByVal value As String)
            idcomunidad = value

            If _cuenta <> "" Then
                llenarDatUsu()
            End If
        End Set
    End Property

    Public Property Cancelado() As Boolean
        Get
            Return _Can
        End Get
        Set(ByVal value As Boolean)
            _Can = value
        End Set
    End Property
#End Region

    Private Sub frmagrmov_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        llenaporcadena()
    End Sub

    Private Sub frmagrmov_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub frmagrmov_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyData = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmagrmov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim idr As IDataReader
        idr = conce.conceptos(even)
        Dim numero As Integer = 0
        Do While idr.Read()
            AdvTree1.Nodes.Add(New DevComponents.AdvTree.Node())
            AdvTree1.Nodes.Item(numero).Text = idr("descripcion")
            numero += 1
        Loop
        txtCuenta.Visible = True
        txtCuenta.Focus()
    End Sub
    Private Sub AdvTree1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles AdvTree1.DragEnter
        cadena = AdvTree1.SelectedNode.SelectedCell.Text
    End Sub

    Private Sub txtconcepto_DragDrop(
          ByVal sender As Object,
          ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtconcepto.DragDrop
        llenaporcadena()
    End Sub
    Private Sub txtconcepto_DragEnter(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtconcepto.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub Txtidconcepto_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtidconcepto.DragDrop
        llenaporcadena()
    End Sub

    Private Sub Txtidconcepto_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Txtidconcepto.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Public Sub llenaporcadena()
        Try
            Dim ird As IDataReader = ConsultaSql("select * from conceptoscxc where descripcion='" & cadena & "'").ExecuteReader
            ird.Read()
            Txtidconcepto.Text = ird("id_concepto")
            Txtconcepto.Text = cadena
            ' lbltipomov.Text = ird("tipo")
            TxtMonto.Value = ird("monto_inicial")

        Catch ex As Exception
            MessageBox.Show("Este concepto no fue elaborado en el sistema " & vbCrLf & "por favor cambialo por uno que si este en el catalogo")
        End Try
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Try
            foliocontrato = txtCuenta.Text
        Catch ex As Exception

        End Try

        If foliocontrato = 0 Then

            MessageBoxEx.Show("Introduzca la Cuenta a la cual se va a cargar el movimiento", "Agregar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If
        If dtfven.Value = Nothing Then
            MessageBoxEx.Show("Introduzca la fecha de vencimiento", "Agregar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtfven.Select()
            Exit Sub
        End If

        If Txtconcepto.Text = "" Then
            MessageBoxEx.Show("Seleccione el concepto del movimiento", "Agregar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txtconcepto.Select()
            Exit Sub
        End If

        If TxtMonto.Value <= 0 Then
            TxtMonto.Value = 1
            MessageBoxEx.Show("No se permite agregar un movimiento por un valor de 0", "Agregar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMonto.Select()
            Exit Sub
        End If

        Dim x As New movimientos
        x.concepto = Txtconcepto.Text
        If Len(idcomunidad) = 3 Then
            x.id_comunidad = idcomunidad
        Else
            x.id_comunidad = obtenerCampo("select id_comunidad from comunidades where id_comunidad='" & idcomunidad & "'", "id_Comunidad")
        End If

        x.tipo_movimiento = movimientos.tipo.cargo

        x.folio_contrato = foliocontrato
        x.tipoevento = even
        x.fecven = dtfven.Value
        x.clave = _clave

        x.add(Val(TxtMonto.Value), txtdetalle.Text, Txtidconcepto.Text, DTPicker1.Value, Me._tipoAcceso, ChkAplicaRecargo.Checked)
        _Can = True
        Close()
    End Sub

    Private Sub llenarDatUsu()

        If txtCuenta.Text = "" Then Exit Sub
        Try
            idusu = ConsultaSql("select * from vusuario where  cuenta=" & txtCuenta.Text & "").ExecuteReader()
            If idusu.Read() Then

                lblfoliodecontrato.Text = idusu("cuenta")
                txtCuenta.Text = idusu("cuenta")

                LBLNOMBRE.Text = idusu("nombre")
                foliocontrato = idusu("cuenta")
                LblDireccion.Text = idusu("Direccion") & " " & idusu("Colonia") & ", " & idusu("comunidad")
                ExpandablePanel1.Visible = True
            Else
                MessageBoxEx.Show("La cuenta no ha sido encontrada, verifique sus datos", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ExpandablePanel1.Visible = False

                txtCuenta.Text = ""

                DTPicker1.Select()
                'cmbComu.SelectedValue = Nothing
                'txtCuenta.Select()
                '    Stop
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If exis = False Then
            exis = True
            Dim frmbus As New frmBusUsuario(eve.Multas, Me)
            frmbus.filtro("select cuenta as Cuenta, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as Número_exterior, numint as Número_interior  from vusuario order by cuenta ")
            frmbus.ShowDialog()
            exis = False
        End If
    End Sub
    Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        e.KeyChar = UCase(e.KeyChar)

        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 13 Then
            e.Handled = True
            llenarDatUsu()
        End If
    End Sub

    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 13 Then
            e.Handled = True
            llenarDatUsu()
        End If

    End Sub

    Private Sub txtCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.LostFocus
        llenarDatUsu()
    End Sub


    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        _Can = False
        Close()
    End Sub

    Private Sub TxtMonto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMonto.ValueChanged
        If lbltipomov.Text = "Cargo" Then
            Dim ApIva As Boolean = CBool(obtenerCampo("select aplicaiva from conceptoscxc where id_concepto = '" & Txtidconcepto.Text & "'", "aplicaiva"))
            If ApIva = True Then
                LblIva.Text = FormatCurrency(Math.Round(TxtMonto.Value * (VARIABLE_IVA / 100), 2), 2)
                LblTotal.Text = FormatCurrency(TxtMonto.Value + CDbl(LblIva.Text), 2)
            Else
                LblIva.Text = FormatCurrency(0, 2)
                LblTotal.Text = FormatCurrency(TxtMonto.Value, 2)
            End If
        End If
    End Sub

    Private Sub DTPicker1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPicker1.LostFocus
        dtfven.MinDate = DTPicker1.Value
        If Not dtfven.Value = Nothing Then
            If dtfven.Value < DTPicker1.Value Then
                dtfven.Value = DTPicker1.Value
            End If
        End If
    End Sub

    Private Sub Txtconcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtconcepto.KeyPress
        e.Handled = True
    End Sub

    Private Sub Txtidconcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtidconcepto.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmdBuscar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.GotFocus
        cmdBuscar.Pulse()
        cmdBuscar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdBuscar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.LostFocus
        cmdBuscar.StopPulse()
    End Sub

    Private Sub btnok_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnok.GotFocus
        btnok.Pulse()
        btnok.StopPulseOnMouseOver = False
    End Sub

    Private Sub btnok_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnok.LostFocus
        btnok.StopPulse()
    End Sub

    Private Sub BtnCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.GotFocus
        BtnCancelar.Pulse()
        BtnCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancelar.LostFocus
        BtnCancelar.StopPulse()
    End Sub

    Private Sub txtcatastral_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub



End Class