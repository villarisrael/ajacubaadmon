Imports DevComponents.DotNetBar

Public Class frmAgrMarMed

    Dim mtipo As Tipo
    Dim idmar As String = ""
    Dim dmar As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idmar() As String
        Get
            Return idmar
        End Get
        Set(ByVal value As String)
            idmar = value
            dmar = ConsultaSql("select * from marcasmedidor where id_marca='" & idmar & "'").ExecuteReader()
            dmar.Read()
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
        If txtClavMar.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la marca", "Marca de Medidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavMar.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción de la marca", "Marca de Medidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim idv As IDataReader = ConsultaSql("select id_marca from marcasmedidor where id_marca='" & txtClavMar.Text & "'").ExecuteReader()
                If idv.Read() Then
                    MessageBoxEx.Show("La clave ya existe, verifique porfavor", "Marca de Medidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClavMar.Select()
                    Exit Sub
                End If
                Ejecucion("insert into marcasmedidor values(""" & txtClavMar.Text & """,""" & txtDes.Text & """, " & NDigitos.Value & ")")
            Else
                Ejecucion("update marcasmedidor set descripcion='" & txtDes.Text & "', Digitos = " & NDigitos.Value & " where id_marca=""" & idmar & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Marca de Medidor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Marca de Medidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub llenar()
        txtClavMar.Text = dmar("id_marca")
        txtDes.Text = dmar("descripcion")
    End Sub

    Private Sub frmAgrMarMed_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmAgrMarMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            llenar()
            txtClavMar.Enabled = False
            If mtipo = Tipo.Ver Then
                txtDes.Enabled = False
                NDigitos.Enabled = False
                cmdAcept.Visible = False
            End If
        End If
    End Sub
End Class