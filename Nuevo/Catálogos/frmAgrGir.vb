Imports DevComponents.DotNetBar

Public Class frmAgrGir
    Dim mtipo As Tipo
    Dim idgir As String = ""
    Dim dgir As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idGir() As String
        Get
            Return idgir
        End Get
        Set(ByVal value As String)
            idgir = value
            dgir = ConsultaSql("select * from giro where codgir='" & idgir & "'").ExecuteReader()
            dgir.Read()
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        mtipo = _mtipo
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        If txtClavGir.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave del Giro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavGir.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción del Giro", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                If obtenerCampo("select count(*) as tot from giro where codgir='" & txtClavGir.Text & "'", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DEL GIRO YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "GIROS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into giro values('" & txtClavGir.Text & "','" & txtDes.Text & "',0," & txtm3.Text & ")")
                Ejecucion("update empresa set folio_giros=" & obtenerCampo("select * from empresa", "folio_giros") + 1)

            Else
                Ejecucion("update giro set codgir=""" & txtClavGir.Text & """, descripcion='" & txtDes.Text & "', pro_anual=" & txtm3.Text & " where codgir=""" & idgir & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavGir.Text = dgir("codgir")
        txtDes.Text = dgir("descripcion")
        txtm3.Text = dgir("pro_anual")
    End Sub

    Private Sub frmAgrGir_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrGir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Editar Then
            txtClavGir.Enabled = False
            txtDes.Select()
            llenar()
        End If
        If mtipo = Tipo.Ver Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from giro where descripcion='" & idgir & "'").ExecuteReader
            rea.Read()
            txtClavGir.Text = rea("codgir")
            txtDes.Text = rea("descripcion")
            txtClavGir.Enabled = False
            txtDes.Enabled = False
            cmdAcept.Visible = False
            cmdCance.Select()
        End If

        If mtipo = Tipo.Agregar Then
            txtClavGir.Enabled = False
            txtClavGir.Text = obtenerCampo("select * from empresa", "folio_giros")

        End If
    End Sub

    'Private Sub txtClavGir_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClavGir.LostFocus
    '    Dim idv As IDataReader = ConsultaSql("select codgir from giro where codgir='" & txtClavGir.Text & "'").ExecuteReader()
    '    If mtipo = Tipo.Agregar Then
    '        If idv.Read() Then
    '            'MessageBox("La clave ya existe, verifique porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            txtClavGir.WatermarkText = "Clave repetida"
    '            txtClavGir.Text = ""
    '            txtDes.Focus()
    '            Exit Sub
    '        Else
    '            txtClavGir.WatermarkText = "Sólo tres caracteres"

    '        End If
    '    End If
    'End Sub


    Private Sub cmdAcept_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.GotFocus
        cmdAcept.Pulse()
        cmdAcept.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAcept_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.LostFocus
        cmdAcept.StopPulse()
    End Sub

    Private Sub cmdCance_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCance.GotFocus
        cmdCance.Pulse()
        cmdCance.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdCance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCance.LostFocus
        cmdCance.StopPulse()
    End Sub
End Class