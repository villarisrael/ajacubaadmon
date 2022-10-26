Imports DevComponents.DotNetBar

Public Class frmAgrComu

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
        llenarCombo(cmbMuni, "select clave, nombre from municipios")
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmAgrComu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrComu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mun As String
        mun = cmbMuni.Text


        If mtipo = Tipo.Ver Then
            'Dim rea As IDataReader
            'rea = ConsultaSql("select * from comunidades where id_comunidad='" & idcom & "'").ExecuteReader
            'rea.Read()
            'txtCont.Text = rea("no_contrato")
            'txtId_com.Text = rea("ID_comunidad")
            'txtNomCom.Text = rea("comunidad")

            ''Dim com As String
            'com = rea("clave")
            'cmbMuni.SelectedValue = com

            txtCont.Enabled = False
            txtId_com.Enabled = False
            txtNomCom.Enabled = False
            cmbMuni.Enabled = False
            cmdAcept.Visible = False
            Me.Text = "Modo Visualización"
            'txtCont.TabStop = False
            'txtId_com.TabStop = False
            'txtNomCom.TabStop = False

        ElseIf mtipo = Tipo.Editar Then
            txtId_com.Enabled = False
        End If
        cmbMuni.Text = mun
        If mtipo = Tipo.Agregar Then
            'txtId_com.Enabled = False
            'txtId_com.Text = obtenerCampo("select * from empresa", "folio_comu")

        End If

    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        Dim clm As Integer = CInt(obtenerCampo("select clave from municipios Where nombre=""" & cmbMuni.Text & """", "clave"))

        If txtId_com.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la comunidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_com.Select()
            Exit Sub
        End If

        If cmbMuni.Text = "" Then
            MessageBoxEx.Show("Introduzca el municipio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbMuni.Select()
            Exit Sub
        End If

        If txtNomCom.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre de la comunidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNomCom.Select()
            Exit Sub
        End If

        If txtCont.Value <= 0 Then
            MessageBoxEx.Show("Intruduzca un valor correcto para el contrato ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCont.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then

                If obtenerCampo("select count(*) as tot from comunidades where id_comunidad='" & txtId_com.Text & "' and nmpio=" & clm & "", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DE LA COMUNIDAD YA EXISTE PARA EL MUNICIPIO, VERIFIQUE POR FAVOR", "COMUNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into comunidades (ID_COMUNIDAD,NMPIO, COMUNIDAD, NO_CONTRATO) values('" & txtId_com.Text & "'," & clm & ",'" & txtNomCom.Text & "'," & txtCont.Value & ")")
                Ejecucion("update empresa set folio_comu=" & obtenerCampo("select * from empresa", "folio_comu") + 1)
            Else
                Ejecucion("update comunidades set id_comunidad=""" & txtId_com.Text & """, nmpio=" & clm & ", comunidad=""" & txtNomCom.Text & """, no_contrato=" & txtCont.Value & " where id_comunidad=""" & idcom & """")
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



    'Private Sub cmbMuni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbMuni.KeyPress
    '    DespliegaCombo(cmbMuni, e)
    '    'e.KeyChar = UCase(e.KeyChar)
    'End Sub

    Private Sub cmbMuni_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMuni.SelectedIndexChanged

    End Sub
End Class