Public Class FrmTipoImprContrato
    Enum Posibilidades
        Contrato
        Cambio_Nombre
        Cambio_Tarifa
        Cambio_Medidor
    End Enum
    Public Sub New()

        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().

    End Sub
    Private _Cuenta As Double, _Comunidad As String, _TipoContra As Integer, _CambioNombre As Posibilidades
    Private Titulo As String, Clausula As String
    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
        End Set
    End Property
    Public Property Comunidad() As String
        Get
            Return _Comunidad
        End Get
        Set(ByVal value As String)
            _Comunidad = value
        End Set
    End Property
    Public Property CambioNombre() As Posibilidades
        Get
            Return _CambioNombre
        End Get
        Set(ByVal value As Posibilidades)
            _CambioNombre = value
        End Set
    End Property

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim Marca As String = obtenerCampo("select descripcion from marcasmedidor, vusuario where vusuario.marcamedidor = marcasmedidor.id_marca and cuenta = " & _Cuenta, "Descripcion")
        Select Case _TipoContra
            Case 3
                Titulo = obtenerCampo("Select contrato1 from formatocontrato", "Contrato1")
                Clausula = obtenerCampo("Select Clausula1 from formatocontrato", "Clausula1")
            Case 4
                Titulo = obtenerCampo("Select contrato2 from formatocontrato", "Contrato2")
                Clausula = obtenerCampo("Select Clausula2 from formatocontrato", "Clausula2")
            Case 5
                Titulo = obtenerCampo("Select contrato3 from formatocontrato", "Contrato3")
                Clausula = obtenerCampo("Select Clausula3 from formatocontrato", "Clausula3")
        End Select
        If RBcambiodenombre.Checked Then

            If OptCopia.Checked = True Then
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Copia *", "Titulo, Cambio de Nombre ", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            Else
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Original *", "Titulo, Cambio de Nombre", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            End If
        End If
        If rbcambiotarifa.Checked Then
            If OptCopia.Checked = True Then
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Copia *", "Titulo, Cambio de Tarifa ", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            Else
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Original *", "Titulo, Cambio de Tarifa", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            End If
        End If
        If rbcambiomedidor.Checked Then
            If OptCopia.Checked = True Then
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Copia *", "Titulo, Cambio de Medidor ", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            Else
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato_Cambio_Nombre, "{vcontrato1.cuenta} = " & _Cuenta, "Original_o_copia, * Original *", "Titulo, Cambio de Medidor", "Marcamedidor, " & Marca & "")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
                Frm.WindowState = FormWindowState.Maximized
            End If
        End If
        If RBcontrato1.Checked Then
            If OptCopia.Checked = True Then
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
            Else
                Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()
            End If
        End If
        If Rbcomprconcargo.Checked Then

            Dim Frm As New frmReporte(frmReporte.Lista.Comprobante, "{vusuario1.cuenta} = " & _Cuenta)
            Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()

        End If
        Close()
    End Sub

    Private Sub FrmTipoImprContrato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmTipoImprContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Formatos As IDataReader = ConsultaSql("Select contrato1, contrato2, contrato3 from formatocontrato").ExecuteReader
            Formatos.Read()
            RBcontrato3.Text = Formatos("contrato1").ToString
            RBcontrato4.Text = Formatos("contrato2").ToString
            RBcontrato5.Text = Formatos("contrato3").ToString

        Catch ex As Exception
            '     MsgBox(ex.Message, MsgBoxStyle.Information, "")
        End Try
    End Sub

    Private Sub RBcontrato3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub Verifica()
        If RBcontrato1.Checked = True Or RBcambiodenombre.Checked = True Then
            If RBcontrato1.Checked = True Then _TipoContra = 1
            If RBcambiodenombre.Checked = True Then _TipoContra = 2
        Else
            If RBcontrato3.Checked = True Then
                _TipoContra = 3
            ElseIf RBcontrato4.Checked = True Then
                _TipoContra = 4
            ElseIf RBcontrato5.Checked = True Then
                _TipoContra = 5
            ElseIf Rbcontrato6.Checked = True Then
                _TipoContra = 2
            End If
        End If
    End Sub

    Private Sub RBcontrato1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub

    Private Sub RBcontrato2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub RBcontrato4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub RBcontrato5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Public Sub New(ByVal NoCuenta As Double, ByVal Comunidad As String)

        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
        _Cuenta = NoCuenta
        _Comunidad = Comunidad
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Verifica()

    End Sub
End Class