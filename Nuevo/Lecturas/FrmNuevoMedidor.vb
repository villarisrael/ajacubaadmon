Imports DevComponents.DotNetBar

Public Class FrmNuevoMedidor
    Dim _Cuenta As Double
    Dim _Com As String
    Dim _Lectura As Double
    Dim _Consumo As Double
    Dim _Resp As Int16
    Dim _Nuevo As Boolean
    Dim _bandera As Boolean
    Dim _tabla As String

    Public Property bandera() As Boolean
        Get
            Return _bandera
        End Get
        Set(ByVal value As Boolean)
            _bandera = value
        End Set
    End Property
    Public Property Nuevo() As Boolean
        Get
            Return _Nuevo
        End Get
        Set(ByVal value As Boolean)
            _Nuevo = value
        End Set
    End Property
    Public Property Respuesta() As Int16
        Get
            Return _Resp
        End Get
        Set(ByVal value As Int16)
            _Resp = value
        End Set
    End Property
    Public Property Lectura() As Double
        Get
            Return _Lectura
        End Get
        Set(ByVal value As Double)
            _Lectura = value
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
    Public Property Comunidad() As String
        Get
            Return _Com
        End Get
        Set(ByVal value As String)
            _Com = value
        End Set
    End Property
    Public Property Consumo() As Double
        Get
            Return _Consumo
        End Get
        Set(ByVal value As Double)
            _Consumo = value
        End Set
    End Property
    Public Property tabla() As String
        Get
            Return _tabla
        End Get
        Set(ByVal value As String)
            _tabla = value
        End Set
    End Property

    Dim Prom, Min, Acu, Con, Prom12 As Double

    Private Sub FrmNuevoMedidor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F10 Then
            Try
                Dim fim As New frmVerLect
                fim.idcomu = _Com
                fim.cuenta = _Cuenta
                fim.Text = "HISTORIAL DE LECTURAS DE LA CUENTA " & _Cuenta & " " & _Com
                fim.ShowDialog()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub FrmNuevoMedidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbAlgo, "select clave, descrip from algoritmos order by descrip")
        lblm3.Visible = False
        lblm32.Visible = False
        NCapcons.Visible = False
        lblMsn.Visible = False

        If Nuevo = True Then
            LblTitulo.Text = "La cuenta " & _Cuenta & " registra un cambio de medidor, ¿que desea cobrar?"
        Else
            LblTitulo.Text = "La cuenta " & _Cuenta & " registra un consumo disparado, ¿que desea cobrar?"
        End If

        'Dim ir As IDataReader
        'Dim MtsConsuAcu As Double

        'ir = ConsultaSql("select promedio('" & _Com & "'," & _Cuenta & ",3)").ExecuteReader
        'ir.Read()
        'ChkPromedio.Text = "Cobrar el promedio de 3 meses " & ir(0) & " m3"
        'Prom = ir(0)

        'ir = ConsultaSql("select promedio('" & _Com & "'," & _Cuenta & ",12)").ExecuteReader
        'ir.Read()
        'ChkPromedio12.Text = "Cobrar el promedio de 12 meses " & ir(0) & " m3"
        'Prom12 = ir(0)

        'If Nuevo = True Then
        '    ir = ConsultaSql("Select ultimo_consumo from cambiomedidor where cuenta =  " & _Cuenta & " and comunidad = '" & _Com & "'").ExecuteReader
        '    If ir.Read Then
        '        MtsConsuAcu = _Lectura + ir("ultimo_consumo")
        '        Acu = MtsConsuAcu
        '    End If

        '    ChkAcumulado.Text = "Consumo acumulado del ultimo consumo y el consumo del nuevo medidor " & MtsConsuAcu & " m3"

        '    ChkConsumo.Text = "Consumo del medidor nuevo " & _Lectura & " m3"
        '    Con = _Lectura
        'Else
        '    ir = ConsultaSql("Select ultimo_consumo from cambiomedidor where cuenta =  " & _Cuenta & " and comunidad = '" & _Com & "'").ExecuteReader
        '    If ir.Read Then
        '        MtsConsuAcu = _Lectura + ir("ultimo_consumo")
        '        Acu = MtsConsuAcu
        '    End If

        '    ChkAcumulado.Text = "Consumo acumulado del ultimo consumo y el consumo del nuevo medidor " & MtsConsuAcu & " m3"
        '    ChkAcumulado.Visible = False

        '    ChkConsumo.Text = "Consumo del medidor " & _Consumo & " m3"
        '    Con = _Lectura
        'End If

        'Select Case _Resp
        '    Case 0, 1
        '        ChkPromedio.Checked = True
        '    Case 2
        '        ChkPromedio12.Checked = True
        '    Case 3
        '        ChkAcumulado.Checked = True
        '    Case 4
        '        ChkConsumo.Checked = True
        '    Case 5
        '        ChkCapConsumo.Checked = True
        'End Select

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        'If ChkAcumulado.Checked = True Then
        '    _Consumo = Acu
        '    _Resp = 3
        'ElseIf ChkConsumo.Checked = True Then
        '    _Consumo = Con
        '    _Resp = 4
        'ElseIf ChkCapConsumo.Checked = True Then
        '    _Consumo = NCapcons.Value
        '    _Resp = 5
        'ElseIf ChkPromedio.Checked = True Then
        '    _Consumo = Prom
        '    _Resp = 1
        'ElseIf ChkPromedio12.Checked = True Then
        '    _Consumo = Prom12
        '    _Resp = 2
        'End If

        If cmbAlgo.Text = "" OrElse cmbAlgo.SelectedValue Is Nothing Then
            MessageBoxEx.Show("Seleccione el algoritmo, por favor", "Cambio de algoritmo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbAlgo.Select()
            Exit Sub
        End If
        _Resp = cmbAlgo.SelectedValue.ToString
        If NCapcons.Visible Then
            _Consumo = NCapcons.Value
        End If
        _bandera = True
        Close()
    End Sub

    'Private Sub ChkCapConsumo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If ChkCapConsumo.Checked = True Then
    '        NCapcons.Visible = True
    '        NCapcons.Select()
    '        lblm3.Visible = True
    '    Else
    '        NCapcons.Visible = False
    '        lblm3.Visible = False
    '    End If
    'End Sub

    Private Sub cmbAlgo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAlgo.SelectedIndexChanged

        If Not cmbAlgo.SelectedValue Is Nothing AndAlso cmbAlgo.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Dim ir As IDataReader = Nothing, ir2 As IDataReader = Nothing

            Dim MtsConsuAcu As Double = 0

            'ir2 = ConsultaSql("select * from algoritmos where clave=" & cmbAlgo.SelectedValue.ToString & "").ExecuteReader()
            'ir2.Read()

            'ir = ConsultaSql("select promedio('" & _Com & "'," & _Cuenta & "," & ir2("nodemeses") & ")").ExecuteReader
            'ir.Read()
            'lblMsn.Text = cmbAlgo.Text & "  " & ir(0) & " m3"
            Dim cllec As New ClsLecturas
            cllec.Lectura = _Lectura
            cllec.Comunidad = Me.Comunidad
            cllec.Cuenta = Cuenta

            cllec.Region = _tabla.Substring(15, 3)
            cllec.Ruta = _tabla.Substring(19, 3)
            _Consumo = cllec.consumoVerificarAlgoritmo(cmbAlgo.SelectedValue.ToString, Me._tabla)
            lblMsn.Text = cmbAlgo.Text & "  " & _Consumo & " m3"

            If cmbAlgo.Text = "Capturar consumo" Then
                lblm3.Visible = True
                lblm32.Visible = True
                NCapcons.Visible = True
                lblMsn.Visible = False
            Else
                lblm3.Visible = False
                lblm32.Visible = False
                NCapcons.Visible = False
                lblMsn.Visible = True
            End If
        End If

    End Sub

    Private Sub BtnAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.GotFocus
        BtnAceptar.Pulse()
        BtnAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub BtnAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAceptar.LostFocus
        BtnAceptar.StopPulse()
    End Sub
End Class