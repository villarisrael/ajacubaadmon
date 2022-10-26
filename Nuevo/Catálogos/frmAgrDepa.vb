Imports DevComponents.DotNetBar

Public Class frmAgrDepa

    Dim mtipo As Tipo
    Dim idres As String = ""
    Dim idr As IDataReader
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idres() As String

        Get
            Return idres
        End Get
        Set(ByVal value As String)
            idres = value
            idr = ConsultaSql("select * from deptos where cod_dep='" & idres & "'").ExecuteReader()
            If idr.Read() Then
                txtCodDep.Text = idr("cod_dep")
                txtNomDep.Text = idr("nombre")
                txtRespo.Text = idr("respons")
                cmbDir.SelectedValue = idr("cod_dir")
            End If

        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        llenarCombo(cmbDir, "select cod_dir, nombre from direc order by nombre")
        mtipo = _mtipo

        Select Case mtipo
            Case Tipo.Editar
                txtNomDep.Select()
            Case Tipo.Ver
                cmdCance.Select()
        End Select
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        If txtCodDep.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave del Departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCodDep.Select()
            Exit Sub
        End If

        If txtNomDep.Text = "" Then
            MessageBoxEx.Show("Introduzca el Nombre del Departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNomDep.Select()
            Exit Sub
        End If

        If txtRespo.Text = "" Then
            MessageBoxEx.Show("Introduzca el Responsable del Departamento", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtRespo.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("Select * from deptos where cod_dep = '" & txtCodDep.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("La clave del departamento ya existe, verifique sus datos", "Departamento", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    Ejecucion("insert into deptos (cod_dep,nombre,respons,cod_dir) values('" & txtCodDep.Text & "','" & txtNomDep.Text & "','" & txtRespo.Text & "','" & cmbDir.SelectedValue.ToString & "')")
                End If
            Else
                Ejecucion("update deptos set nombre=""" & txtNomDep.Text & """, respons=""" & txtRespo.Text & """, cod_dir='" & cmbDir.SelectedValue.ToString & "' where cod_dep='" & idres & "'")
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

    Private Sub frmAgrDepa_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

    Private Sub frmAgrDepa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If mtipo = Tipo.Ver Then
            txtCodDep.ReadOnly = True
            txtNomDep.ReadOnly = True
            txtRespo.ReadOnly = True
            cmdAcept.Visible = False
            cmbDir.Enabled = False
            cmdCance.Select()
        ElseIf mtipo = Tipo.Editar Then
            txtCodDep.ReadOnly = True
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