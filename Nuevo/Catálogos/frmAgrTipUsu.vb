Imports DevComponents.DotNetBar

Public Class frmAgrTipUsu
    Dim mtipo As Tipo
    Dim idusu As String = ""
    Dim dusu As IDataReader

    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum


    Public Property _idusu() As String
        Get
            Return idusu
        End Get
        Set(ByVal value As String)
            idusu = value
            dusu = ConsultaSql("select * from tipos_usuarios where id_tipo_usuario='" & idusu & "'").ExecuteReader()
            dusu.Read()
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
        Dim idv As IDataReader = ConsultaSql("select id_tipo_usuario from tipos_usuarios where id_tipo_usuario='" & txtClavUsu.Text & "'").ExecuteReader()
        If mtipo = Tipo.Agregar Then
            If idv.Read() Then
                MessageBoxEx.Show("La clave ya existe, verifique porfavor", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClavUsu.Select()
                Exit Sub
            End If
        End If

        If txtClavUsu.Text = "" Then
            MessageBox.Show("Introduzca la clave del tipo de usuario", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBox.Show("Introduzca la descripción del tipo de usuario", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into tipos_usuarios (ID_TIPO_USUARIO,DESCRIPCION) values('" & txtClavUsu.Text & "','" & txtDes.Text & "')")
            Else
                Ejecucion("update tipos_usuarios set id_tipo_usuario='" & txtClavUsu.Text & "', descripcion='" & txtDes.Text & "' where id_tipo_usuario='" & idusu & "'")
            End If
            MessageBox.Show("Datos guardados exitosamente", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "Tipo de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavUsu.Text = dusu("id_tipo_usuario")
        txtDes.Text = dusu("descripcion")

    End Sub

    Private Sub frmAgrTipUsu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrTipUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Editar Then
            llenar()
            txtClavUsu.ReadOnly = True
            If mtipo = Tipo.Ver Then

                txtDes.ReadOnly = True
                cmdAcept.Enabled = False
            End If
        End If
    End Sub
End Class