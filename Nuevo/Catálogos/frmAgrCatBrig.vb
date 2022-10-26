Imports DevComponents.DotNetBar

Public Class frmAgrCatBrig
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


    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Dim trab As String = ""

        If txtNoBrig.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la Brigada", "Brigada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNoBrig.Select()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MessageBoxEx.Show("Introduzca la Descripción", "Brigada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Select()
            Exit Sub
        End If

        If cmbDirec.Text = "" Then
            MessageBoxEx.Show("Introduzca El Código De La Dirección", "Brigada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbDirec.Select()
            Exit Sub
        End If

        If cmbTrab.Text = "" Then
            trab = " "
            'MessageBox.Show("Establezca el trabajador", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Exit Sub
        Else
            trab = cmbTrab.SelectedValue.ToString
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into brigada value(""" & txtNoBrig.Text & """,""" & txtDescripcion.Text & """,""" & cmbDirec.SelectedValue.ToString & """,""" & trab & """)")
            Else
                Ejecucion("update brigada set descripcion=""" & txtDescripcion.Text & """,cod_dir=""" & cmbDirec.SelectedValue.ToString & """,IDTrab=""" & trab & """ where nobrig='" & idcom & "'")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "Brigadas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "Brigadas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Me.Close()
    End Sub

    Private Sub cmadCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmadCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgrCatBrig_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmAgrCatBrig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbDirec, "select Cod_Dir, nombre from direc order by nombre")
        llenarCombo(cmbTrab, "select idTrab, nombre from trabajadores order by nombre")
        If mtipo <> Tipo.Agregar Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from brigada where nobrig='" & idcom & "'").ExecuteReader
            rea.Read()
            txtDescripcion.Text = rea("descripcion")
            txtNoBrig.Text = rea("nobrig")
            cmbDirec.SelectedValue = rea("cod_dir")
            cmbTrab.SelectedValue = rea("idTrab")
            txtNoBrig.ReadOnly = True
            If mtipo = Tipo.Ver Then
                txtDescripcion.ReadOnly = True
                cmbDirec.Enabled = False
                cmbTrab.Enabled = False
                cmdAceptar.Visible = False
            End If
        Else
            llenarCombo(cmbTrab, "select idTrab, nombre from trabajadores order by nombre")
            'txtNoBrig.Text = Val(obtenerCampo("select max(nobrig) as a from brigada", "a")) + 1
            txtNoBrig.Enabled = True
        End If
    End Sub

    Private Sub cmbDirec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDirec.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbTrab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTrab.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmdAceptar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.GotFocus
        cmdAceptar.Pulse()
        cmdAceptar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAceptar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAceptar.LostFocus
        cmdAceptar.StopPulse()
    End Sub

    Private Sub cmadCancelar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmadCancelar.GotFocus
        cmadCancelar.Pulse()
        cmadCancelar.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmadCancelar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmadCancelar.LostFocus
        cmadCancelar.StopPulse()
    End Sub
End Class