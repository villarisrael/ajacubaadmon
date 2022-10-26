Imports DevComponents.DotNetBar

Public Class frmAgrReg

    Dim mtipo As Tipo
    Dim idreg As String = ""
    Dim dreg As IDataReader
    Dim idcomu As String = ""
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idreg() As String
        Get
            Return idreg
        End Get
        Set(ByVal value As String)
            idreg = value
        End Set
    End Property
    Public Property _idcomu() As String
        Get
            Return idcomu
        End Get
        Set(ByVal value As String)
            idcomu = value
            'idcomu = obtenerCampo("select id_comunidad from comunidades where comunidad='" & value & "'", "id_comunidad")
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

        If txtId_reg.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la región", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_reg.Select()
            Exit Sub
        End If



        If txtReg.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre de la región", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtReg.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                If obtenerCampo("select count(*) as tot from region where id_region='" & txtId_reg.Text & "' ", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DE LA REGIÓN YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "REGIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into region (ID_REGION,REGION) values('" & txtId_reg.Text & "','" & txtReg.Text & "')")


            Else
                Ejecucion("update region set region='" & txtReg.Text & "' where id_region='" & txtId_reg.Text & "' ")

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

    Private Sub frmAgrReg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrReg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If mtipo = Tipo.Editar Then
            dreg = ConsultaSql("select * from region where id_region='" & idreg & "' ").ExecuteReader()
            dreg.Read()
            txtId_reg.Text = dreg("id_region")
            txtReg.Text = dreg("region")

            txtId_reg.Enabled = False

            txtReg.Select()
        End If

        If mtipo = Tipo.Ver Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from region where region='" & idreg & "'").ExecuteReader
            rea.Read()
            txtId_reg.Text = rea("id_region")
            txtReg.Text = rea("region")
            'comunidad

            Dim com As String



            txtId_reg.Enabled = False
            txtReg.Enabled = False

            cmdAcept.Visible = False
            cmdCance.Select()

        End If

    End Sub

    'Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComu.KeyPress
    '    DespliegaCombo(cmbComu, e)
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
End Class