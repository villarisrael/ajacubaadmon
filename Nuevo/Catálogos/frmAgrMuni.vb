Imports DevComponents.DotNetBar

Public Class frmAgrMuni
    Dim mtipo As Tipo
    Dim idcom As String = ""
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idcom() As String
        Get
            Return idcom
        End Get
        Set(ByVal value As String)
            idcom = value
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

        If txtId_clave.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave del municipio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_clave.Select()
            Exit Sub
        End If

        If txtNomMun.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre del municipio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNomMun.Select()
            Exit Sub
        End If
        Try
            If mtipo = Tipo.Agregar Then
                If obtenerCampo("select count(*) as tot from municipios where clave=" & txtId_clave.Text & "", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DEL MUNICIPIO YA EXISTE, VERIFIQUE POR FAVOR", "MUNICIPIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtId_clave.Select()

                    Exit Sub
                End If
                Ejecucion("insert into municipios values(" & txtId_clave.Text & ",""" & txtNomMun.Text & """)")
                Ejecucion("update empresa set folio_muni=" & obtenerCampo("select * from empresa", "folio_muni") + 1)


            Else
                Ejecucion("update municipios set clave=" & txtId_clave.Text & ", nombre=""" & txtNomMun.Text & """ where clave=""" & idcom & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub txtId_clave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId_clave.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub frmAgrMuni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrMuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Agregar Then
            txtId_clave.Enabled = False
            txtId_clave.Text = obtenerCampo("select * from empresa", "folio_muni")

        End If
        If mtipo = Tipo.Ver Then

            Dim rea As IDataReader
            rea = ConsultaSql("select * from municipios where nombre='" & idcom & "'").ExecuteReader
            rea.Read()
            txtId_clave.Text = rea("clave")
            txtNomMun.Text = rea("nombre")
            txtId_clave.Enabled = False
            txtNomMun.Enabled = False
            cmdAcept.Enabled = False
            cmdAcept.Visible = False
            txtId_clave.TabStop = False
            txtNomMun.TabStop = False

        ElseIf mtipo = Tipo.Editar Then
            txtId_clave.Enabled = False
        End If

    End Sub

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