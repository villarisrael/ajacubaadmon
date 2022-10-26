Imports DevComponents.DotNetBar

Public Class frmAgrDiam
    Dim mtipo As Tipo
    Dim iddia As String = ""
    Dim ddia As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _iddia() As String
        Get
            Return iddia
        End Get
        Set(ByVal value As String)
            iddia = value
            ddia = ConsultaSql("select * from diametros where id_diametro='" & iddia & "'").ExecuteReader()
            ddia.Read()
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
        If txtClavDiam.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave del diámetro de la toma", "Diametros Toma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavDiam.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción del diámetro de la toma", "Diametros Toma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim idv As IDataReader = ConsultaSql("select id_diametro from diametros where id_diametro='" & txtClavDiam.Text & "'").ExecuteReader()
                If idv.Read() Then
                    MessageBoxEx.Show("La clave ya existe, verifique porfavor", "Diametros Toma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClavDiam.Select()
                    Exit Sub
                End If
                Ejecucion("insert into diametros values(""" & txtClavDiam.Text & """,""" & txtDes.Text & """)")
            Else
                Ejecucion("update diametros set descripcion='" & txtDes.Text & "' where id_diametro=""" & iddia & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Diametros Toma", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Diametros Toma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavDiam.Text = ddia("id_diametro")
        txtDes.Text = ddia("descripcion")
    End Sub

    Private Sub frmAgrDiam_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmAgrDiam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            llenar()
            txtClavDiam.Enabled = False
            If mtipo = Tipo.Ver Then
                txtDes.Enabled = False
                cmdAcept.Visible = False
            End If
        End If
    End Sub
End Class