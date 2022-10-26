Imports DevComponents.DotNetBar

Public Class frmAgrForSer
    Dim mtipo As Tipo
    Dim idser As String = ""
    Dim dser As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idSer() As String
        Get
            Return idser
        End Get
        Set(ByVal value As String)
            idser = value
            dser = ConsultaSql("select * from formas_servicio where id_forma_servicio='" & idser & "'").ExecuteReader()
            dser.Read()
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
        If txtClavSer.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave del servicio", "Forma de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavSer.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción del servicio", "Forma de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If
        Try
            If mtipo = Tipo.Agregar Then
                Dim idv As IDataReader = ConsultaSql("select id_forma_servicio from formas_servicio where id_forma_servicio='" & txtClavSer.Text & "'").ExecuteReader()
                If idv.Read() Then
                    MessageBoxEx.Show("La clave ya existe, verifique porfavor", "Forma de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClavSer.Select()
                    Exit Sub
                End If
                Ejecucion("insert into formas_servicio values(""" & txtClavSer.Text & """,""" & txtDes.Text & """)")
            Else
                Ejecucion("update formas_servicio set descripcion='" & txtDes.Text & "' where id_forma_servicio=""" & idser & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Forma de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Forma de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavSer.Text = dser("id_forma_servicio")
        txtDes.Text = dser("descripcion")
    End Sub

    Private Sub frmAgrForSer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmAgrForSer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            llenar()
            txtClavSer.Enabled = False
            If mtipo = Tipo.Ver Then
                txtDes.Enabled = False
                cmdAcept.Visible = False
            End If
        End If
    End Sub
End Class