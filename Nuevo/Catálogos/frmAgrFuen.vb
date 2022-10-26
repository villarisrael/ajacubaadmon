Imports DevComponents.DotNetBar

Public Class frmAgrFuen

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
        If mtipo = Tipo.Editar Then
            txtDescripcion.Select()
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim comu As String = obtenerCampo("select id_fuente from fuente Where id_Fuente=""" & txtID_Fuente.Text & """", "id_fuente")
        If txtID_Fuente.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la Fuente", "Fuentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtID_Fuente.Select()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MessageBoxEx.Show("Introduzca la Descripción", "Fuentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Select()
            Exit Sub
        End If
        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into fuente values(" & txtID_Fuente.Text & ",""" & txtDescripcion.Text & """)")
            Else
                Ejecucion("update fuente set descripcion=""" & txtDescripcion.Text & """ where id_fuente=""" & idcom & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Fuentes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Fuentes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub frmAgrFuen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrFuen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from fuente where id_fuente='" & idcom & "'").ExecuteReader
            rea.Read()
            txtID_Fuente.Text = rea("id_fuente")
            txtDescripcion.Text = rea("descripcion")
            txtID_Fuente.ReadOnly = True
            If mtipo = Tipo.Ver Then
                txtDescripcion.ReadOnly = True
                cmdAcept.Visible = False
                cmdCance.Select()
            End If
        Else
            txtID_Fuente.Text = Val(obtenerCampo("select max(ID_Fuente) as a from fuente", "a")) + 1
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