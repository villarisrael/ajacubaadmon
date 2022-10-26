Imports DevComponents.DotNetBar

Public Class frmAgrCalle

    Dim mtipo As Tipo
    Dim idcom As String = ""
    Dim idcol As String = ""
    Dim comu As String = "1"

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
        ' llenarCombo(cmbComu, "select id_comunidad, comunidad from Comunidades")

        mtipo = _mtipo
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub



    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        'Dim comu As String = obtenerCampo("select id_comunidad from comunidades Where comunidad=""" & cmbComu.Text & """", "id_comunidad")

        '  Dim col As String = obtenerCampo("select id_colonia from colonia Where colonia=""" & cmbCol.Text & """", "id_colonia")

        If txtId_calle.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la calle", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_calle.Select()
            Exit Sub
        End If

        ''If cmbComu.Text = "" Then
        ''    MessageBoxEx.Show("Introduzca la comunidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''    cmbComu.Select()
        ''    Exit Sub
        ''End If

        'If cmbCol.Text = "" Then
        '    MessageBoxEx.Show("Introduzca la colonia", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cmbCol.Select()
        '    Exit Sub
        'End If

        If txtNomCall.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre de la calle", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNomCall.Select()
            Exit Sub
        End If



        Try
            If mtipo = Tipo.Agregar Then
                If obtenerCampo("select ID_CALLE from calles where  id_calle='" & txtId_calle.Text & "'", "ID_CALLE") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DE LA CALLE YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "CALLES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into  calles ( id_calle,nombre ) values ('" & txtId_calle.Text & "','" & txtNomCall.Text & "')")
                'Ejecucion("update empresa set folio_calle=" & obtenerCampo("select * from empresa", "folio_sector") + 1)

            Else
                Ejecucion("update calles set nombre='" & txtNomCall.Text & "' where id_calle=""" & txtId_calle.Text & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub frmAgrCalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub


    Private Sub frmAgrCalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Ver Then
            txtId_calle.Enabled = False
            txtNomCall.Enabled = False

            'cmbComu.Enabled = False
            cmdAcept.Visible = False
            cmdCance.Select()
        End If

        If mtipo = Tipo.Editar Then
            txtNomCall.Select()

        End If
        If mtipo = Tipo.Agregar Then
            'txtId_calle.Enabled = False
            'txtId_calle.Text = obtenerCampo("select * from empresa", "folio_calle")

        End If
    End Sub
    'Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComu.KeyPress
    '    DespliegaCombo(cmbComu, e)
    '    'e.KeyChar = UCase(e.KeyChar)
    'End Sub

    'Private Sub cmbCol_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbCol.KeyPress
    '    DespliegaCombo(cmbCol, e)
    '    'e.KeyChar = UCase(e.KeyChar)
    'End Sub

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

    Private Sub cmbComu_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub





End Class