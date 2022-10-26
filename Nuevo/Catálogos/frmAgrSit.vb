Imports DevComponents.DotNetBar

Public Class frmAgrSit
    Dim mtipo As Tipo
    Dim idsit As String = ""
    Dim dsit As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idSit() As String
        Get
            Return idsit
        End Get
        Set(ByVal value As String)
            idsit = value
            dsit = ConsultaSql("select * from situacion where clave='" & idsit & "'").ExecuteReader()
            dsit.Read()
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
        If txtClavSit.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la situación", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClavSit.Select()
            Exit Sub
        End If

        If cmbAlg.SelectedIndex = -1 Then
            MessageBoxEx.Show("Introduzca el algoritmo de la situación", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbAlg.Select()
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBoxEx.Show("Introduzca la descripción de la situación", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDes.Select()
            Exit Sub
        End If

        If cmbtipo.SelectedIndex = -1 Then
            MessageBoxEx.Show("Introduzca el tipo de la situación ", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbtipo.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim idv As IDataReader = ConsultaSql("select clave from situacion where clave='" & txtClavSit.Text & "'").ExecuteReader()
                If idv.Read() Then
                    MessageBoxEx.Show("La clave ya existe, verifique por favor", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtClavSit.Select()
                    Exit Sub
                End If
                Ejecucion("insert into situacion values(""" & txtClavSit.Text & """,""" & txtDes.Text & """," & cmbAlg.SelectedValue.ToString & ",""" & cmbtipo.SelectedItem.ToString & """)")
            Else
                Ejecucion("update situacion set situacion='" & txtDes.Text & "', algoritmo=" & cmbAlg.SelectedValue.ToString & ", tipo='" & cmbtipo.SelectedItem.ToString & "' where clave=""" & idsit & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Situaciones de lectura", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub frmAgrSit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrSit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbAlg, "Select clave, descrip from algoritmos order by descrip")
        If mtipo <> Tipo.Agregar Then
            llenar()
            txtClavSit.Enabled = False
            If mtipo = Tipo.Ver Then
                txtDes.Enabled = False
                cmbAlg.Enabled = False
                cmbtipo.Enabled = False
                cmdAcept.Visible = False
            End If
        End If
    End Sub

    Private Sub llenar()
        txtClavSit.Text = dsit("clave")
        txtDes.Text = dsit("Situacion")
        If cmbAlg.SelectedValue <> dsit("algoritmo") Then cmbAlg.SelectedValue = dsit("algoritmo")
        cmbtipo.Text = dsit("tipo")
    End Sub

End Class