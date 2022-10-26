Public Class FrmBusLec
    Dim frm As FrmLecturasCapturadas
    Dim lec As New ClsLecturas
    Dim Columna As Integer
    Dim Campo As String
    Private Sub FrmBusLec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lec.Comunidad = frm.Comunidad
        lec.Region = frm.Regi
        lec.Ruta = frm.Ruta
        lec.Consultas()
    End Sub

    Public Sub New(ByVal _frm As FrmLecturasCapturadas, ByVal Col As Integer, ByVal Camp As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        frm = _frm
        Columna = Col - 1
        Me.Text = "Busqueda de lecturas capturadas"
        Lbltitulo.Text = "Introduce el valor de busqueda para: " & Camp
        Campo = Camp
    End Sub

    Private Sub TxtBus_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBus.KeyUp
        If e.KeyData = Keys.Enter Then
            Close()
        ElseIf e.KeyData = Keys.Escape Then
            Close()
            llenaGrid(frm.DgLecturas, lec.Filtrar("usuario.id_comunidad", "", "S"))
        End If
    End Sub

    Private Sub TxtBus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBus.TextChanged
        Select Case Campo
            Case "Cuenta"
                'cuenta
                llenaGrid(frm.DgLecturas, lec.Filtrar("usuario.cuenta", Val(TxtBus.Text), "N"))
            Case "Comunidad"
                llenaGrid(frm.DgLecturas, lec.Filtrar("usuario.id_comunidad", TxtBus.Text, "S"))
                'Comunidad
            Case "Nombre"
                llenaGrid(frm.DgLecturas, lec.Filtrar("usuario.nombre", TxtBus.Text, "S"))
                'Nombre
            Case "Lectura"
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.lectura", Val(TxtBus.Text), "N"))
                'Lectura
            Case "Consumo"
                'Consumo
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.consumo", Val(TxtBus.Text), "N"))
            Case "Sit_Med"
                'med
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.sit_med", TxtBus.Text, "S"))
            Case "Sit_Padron"
                'Pad
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.sit_pad", TxtBus.Text, "S"))
            Case "Sit_Lec"
                'lec
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.sit_hid", TxtBus.Text, "S"))
            Case "Observa"
                'Observa
                llenaGrid(frm.DgLecturas, lec.Filtrar("lecturas.observa", TxtBus.Text, "S"))
        End Select
    End Sub
End Class