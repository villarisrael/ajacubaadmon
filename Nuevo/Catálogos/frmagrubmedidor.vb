Imports DevComponents.DotNetBar

Public Class frmagrubmedidor
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
            dgir = ConsultaSql("select * from ub_medidor where id_ubmedidor=" & idgir).ExecuteReader()
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

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then

                Ejecucion("insert into ub_medidor(id_ubmedidor,descripcion) values(" & obtenerCampo("select * from empresa", "folio_ubmedidor") & ",""" & txtDes.Text & """)")
                Ejecucion("update empresa set folio_ubmedidor=" & obtenerCampo("select * from empresa", "folio_matcalle") + 1)

            Else
                Ejecucion("update ub_medidor set id_ubmedidor=""" & txtClav.Text & """, descripcion='" & txtDes.Text & "' where id_ubmedidor=""" & idgir & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub llenar()
        txtClav.Text = dgir("id_ubmedidor")
        txtDes.Text = dgir("descripcion")
    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Close()

    End Sub

    Private Sub frmagrubmedidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Editar Then
            txtDes.Select()
            llenar()
        End If
        If mtipo = Tipo.Ver Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from ub_medidor where descripcion='" & idgir & "'").ExecuteReader
            rea.Read()
            txtClav.Text = rea("id_ubmedidor")
            txtDes.Text = rea("descripcion")
            txtClav.Enabled = False
            txtDes.Enabled = False
            cmdAcept.Visible = False
            cmdCance.Select()
        End If
        If mtipo = Tipo.Agregar Then
            txtClav.Enabled = False
            txtClav.Text = obtenerCampo("select * from empresa", "folio_ubmedidor")

        End If
    End Sub
End Class