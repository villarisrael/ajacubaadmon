Imports DevComponents.DotNetBar

Public Class FrmAgregarLectura

#Region "Modificadores de acceso"
    Dim _Comunidad As String, _Cuenta As Double, _Tabla As String, _Fecha As Date
    Dim _Region As String, _Ruta As String
    Dim _cons As Double = 0
    Dim _Algo As Int16
    Dim _s As Boolean = False
    Public mes As String
    Public periodo As Integer
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
    Public Property Algo() As Int16
        Get
            Return _Algo
        End Get
        Set(ByVal value As Int16)
            _Algo = value
            cmbAlgo.SelectedValue = value
            _s = True
        End Set
    End Property
    Public Property Regi() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
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
    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
        End Set
    End Property
    Public Property Tabla() As String
        Get
            Return _Tabla
        End Get
        Set(ByVal value As String)
            _Tabla = value
        End Set
    End Property
#End Region

    Private Sub FrmAgregarLectura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.F10 Then
            If LblCuenta.Text <> "" And LblCuenta.Text <> "Cuenta" Then
                Try
                    Dim fim As New frmVerLect
                    fim.idcomu = _Comunidad
                    fim.cuenta = _Cuenta
                    fim.Text = " LECTURAS DE LA CUENTA " & _Cuenta & " " & _Comunidad
                    fim.ShowDialog()

                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Private Sub FrmAgregarLectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LblCuenta.Text = Cuenta
        LblComunidad.Text = obtenerCampo("Select comunidad from comunidades where id_comunidad = '" & _Comunidad & "'", "Comunidad")
        LblNombre.Text = obtenerCampo("Select nombre from usuario where cuenta = " & _Cuenta & " and id_comunidad = '" & _Comunidad & "'", "nombre")
        'LblAnterior.Text = obtenerCampo("Select lecturaact from usuario where cuenta = " & _Cuenta & " and id_comunidad = '" & _Comunidad & "'", "lecturaact")
        LblAnterior.Text = obtenerCampo("Select lectura , valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & _Cuenta & " and comunidad = '" & _Comunidad & "' order by ordenado desc limit 1", "lectura")

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If cmbAlgo.Text = "" Then
            MessageBoxEx.Show("Seleccione el algoritmo, por favor", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbAlgo.Select()
            Exit Sub
        End If
        If txtconsumo.Text = "" Then txtconsumo.Text = "0"

        Dim tarifa As String = obtenerCampo("select tarifa from usuario where cuenta=" & Cuenta, "tarifa")
        Ejecucion("update lecturas set consumocobrado=" & Me._cons & ", lectura=" & TxtActual.Text & " , sit_pad='" & CmbSituacion2.Text & "' , sit_med='" & CmbSituacion1.Text & "', sit_hid='" & CmbSituacion3.Text & "', observa ='" & TxtObservacion.Text & "', montocobrado= consumomedidossin(" & Me._cons & ",'" & tarifa & "'," & Me.periodo & " ) where cuenta=" & Cuenta & " and mes= '" & mes & "' and an_per=" & periodo & "")
        Close()
    End Sub

    Private Sub CmbSituacion1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion1.KeyPress
        Select Case e.KeyChar

            Case vbCrLf
                'SendKeys.Send("{TAB}")
                CmbSituacion1.Select()
        End Select
    End Sub

    Private Sub CmbSituacion1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion1.SelectedIndexChanged
        Try
            LblMedicion.Text = CmbSituacion1.SelectedValue.ToString
        Catch ex As Exception
            LblMedicion.Text = ""
        End Try
    End Sub

    Private Sub CmbSituacion2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion2.KeyPress
        Select Case e.KeyChar

            Case vbCrLf
                'SendKeys.Send("{TAB}")
                CmbSituacion2.Select()
        End Select
    End Sub

    Private Sub CmbSituacion2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion2.SelectedIndexChanged
        Try
            LblPadron.Text = CmbSituacion2.SelectedValue.ToString
        Catch ex As Exception
            LblPadron.Text = ""
        End Try
    End Sub

    Private Sub CmbSituacion3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSituacion3.KeyPress
        Select Case e.KeyChar

            Case vbCrLf

                CmbSituacion3.Select()
        End Select
    End Sub

    Private Sub CmbSituacion3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSituacion3.SelectedIndexChanged
        Try
            lblHidro.Text = CmbSituacion3.SelectedValue.ToString
        Catch ex As Exception
            lblHidro.Text = ""
        End Try
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        llenarCombo(CmbSituacion1, "Select situacion, clave from situacion where tipo = 'Medicion'")
        llenarCombo(CmbSituacion2, "Select situacion ,clave from situacion where tipo = 'Padron'")
        llenarCombo(CmbSituacion3, "Select situacion, clave from situacion where tipo = 'Hidrometro'")
        llenarCombo(cmbAlgo, "select clave,descrip from algoritmos order by descrip")
        CmbSituacion1.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        CmbSituacion1.SelectedIndex = -1
        CmbSituacion2.SelectedIndex = -1
        CmbSituacion3.SelectedIndex = -1
    End Sub

    Private Sub cmbAlgo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlgo.SelectedIndexChanged
        If _s Then
            Dim cllec As New ClsLecturas
            cllec.mes = FrmCapturaLecturas.cmbmes.Text
            cllec.periodo = FrmCapturaLecturas.txtAn.Text
            cllec.Lectura = obtenerCampo("select consumocobrado from lecturas  where cuenta= " & Cuenta & " and mes='" & mes & "' and an_per =" & periodo & "", "consumocobrado")
            cllec.Cuenta = Cuenta
            cllec.Comunidad = Comunidad
            cllec.Region = Me.Regi
            cllec.Ruta = Ruta
            _cons = cllec.consumoVerificarAlgoritmo(cmbAlgo.SelectedValue)

            If obtenerCampo("select accion from algoritmos where clave=" & cmbAlgo.SelectedValue.ToString & "", "accion") = "Capturar" Then
                Try
                    _cons = InputBox("Introduzca el consumo", "Lecturas")
                Catch ex As Exception
                    _cons = 0
                End Try

            End If
            lblmts.Text = _cons & " mts3"
        End If
    End Sub
End Class