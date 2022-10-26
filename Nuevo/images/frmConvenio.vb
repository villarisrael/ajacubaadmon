Public Class frmConvenio

    Dim _descu As Int16
    Dim _bRez As Boolean
    Dim _bConsu As Boolean
    Dim _bAlca As Boolean
    Dim _bReca As Boolean
    Dim _bSane As Boolean
    Dim _bIva As Boolean
    Dim _mOtros As Double
    Dim _FechaIn As Date
    Dim _FechaFin As Date

    Dim _deriv As Int16

    Dim datos As New ClassConectar()
    Public Sub New(ByVal cuenta As Double, ByVal tarifa As String, ByVal nombre As String, ByVal dir As String, ByVal monto As Double, ByVal motivo As String)
        Dim obj As New clsConvenios()
        InitializeComponent()

        txtNoConvenio.Text = obj.darFolio()
        txtCuenta.Text = cuenta
        txtTarifa.Text = tarifa
        txtNombre.Text = nombre
        txtDir.Text = dir
        txtMonto.Text = FormatCurrency(monto, 2)
        txtRestante.Text = FormatCurrency(monto, 2)

        txtMotivo.Text = motivo
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
#Region "Modificadores de Acceso"

    Public Property FechaIn() As Date
        Get
            Return _FechaIn
        End Get
        Set(ByVal value As Date)
            _FechaIn = value
        End Set
    End Property
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property
    Public Property deriv() As Int16
        Get
            Return _deriv
        End Get
        Set(ByVal value As Int16)
            _deriv = value
        End Set
    End Property
    Public Property descu() As Int16
        Get
            Return _descu
        End Get
        Set(ByVal value As Int16)
            _descu = value
        End Set
    End Property

    Public Property bRez() As Boolean
        Get
            Return _bRez
        End Get
        Set(ByVal value As Boolean)
            _bRez = value
        End Set
    End Property
    Public Property bConsu() As Boolean
        Get
            Return _bConsu
        End Get
        Set(ByVal value As Boolean)
            _bConsu = value
        End Set
    End Property
    Public Property bAlca() As Boolean
        Get
            Return _bAlca
        End Get
        Set(ByVal value As Boolean)
            _bAlca = value
        End Set
    End Property
    Public Property bReca() As Boolean
        Get
            Return _bReca
        End Get
        Set(ByVal value As Boolean)
            _bReca = value
        End Set
    End Property
    Public Property bSane() As Boolean
        Get
            Return _bSane
        End Get
        Set(ByVal value As Boolean)
            _bSane = value
        End Set
    End Property
    Public Property bIva() As Boolean
        Get
            Return _bIva
        End Get
        Set(ByVal value As Boolean)
            _bIva = value
        End Set
    End Property
    Public Property mOtros() As Double
        Get
            Return _mOtros
        End Get
        Set(ByVal value As Double)
            _mOtros = value
        End Set
    End Property
#End Region

    Private Sub frmConvenio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dterPag.Value = Now
        Me.dtFecha.Value = Now
    End Sub

    Private Sub rdAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdAuto.CheckedChanged
        If rdAuto.Checked = True Then
            GroupAuto.Visible = True
            'GroupPerPag.Visible = False
        End If
    End Sub

    Private Sub cmdCancelPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelPer.Click
        GroupAuto.Visible = False
        rdManual.Checked = True
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim frm As New frmDatosConvenio()
        frm.MdiParent = My.Forms.Menu()
        frm.Show()

    End Sub

    Private Sub cmdMostrart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMostrart.Click
        Dim tar As Int16 = datos.obtenerCampo("select tarifa from usuario where cuenta=" & txtCuenta.Text & "", "tarifa")
        Dim fecau As Boolean
        Dim nPer As Int16, i As Int16
        Dim matPag As New Collection
        Dim matAux(5) As String
        If rdAuto.Checked = True Then
            fecau = True
        End If

        If txtPeriodos.Text <> "" Then nPer = CInt(txtPeriodos.Text) Else nPer = 1

        If txtNoPagares.Text = "" Then
            MsgBox("Especifique el número de pagarés, para realizar el convenio", MsgBoxStyle.Information, "Pagarés")
            Exit Sub
        End If

        Dim objConv As New clsConvenios(CDbl(txtCuenta.Text), tar, FechaIn, FechaFin, CShort(txtNoPagares.Text), descu, bRez, bConsu, bAlca, bReca, bSane, bIva, mOtros, deriv, _
                                         txtNoConvenio.Text, fecau, dterPag.Value, nPer)
        matPag = objConv.matPag

        For i = 1 To matPag.Count
            matAux = Split(matPag(i), ", ")
            dgPag.Rows.Add(matAux(0), FormatCurrency(matAux(1), 2), matAux(2), matAux(3), FormatDateTime(matAux(4), DateFormat.ShortDate))

        Next

    End Sub

    Private Sub cmdCanPag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCanPag.Click
        Dim i As Int16
        If dgPag.RowCount > 1 Then
            For i = 1 To dgPag.RowCount - 1
                Try
                    dgPag.Rows.RemoveAt(0)
                Catch ex As Exception
                    Exit For
                End Try
            Next
        End If
    End Sub
End Class
