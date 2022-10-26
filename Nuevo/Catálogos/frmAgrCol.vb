Imports DevComponents.DotNetBar

Public Class frmAgrCol

    Dim mtipo As Tipo
    Dim idcom As String = ""
    Dim idcol As String = ""
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

    Public Property _idcol() As String
        Get
            Return idcol
        End Get
        Set(ByVal value As String)
            idcol = value
        End Set
    End Property
    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        mtipo = _mtipo
        'llenarCombo(cmbComu, "select id_comunidad, comunidad from comunidades")
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        Dim cpp As String
        'Dim clm As String = obtenerCampo("select id_comunidad from comunidades Where comunidad=""" & cmbComu.Text & """", "id_comunidad")
        Dim clm As String = "001"

        If txtId_col.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la colonia", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtId_col.Select()
            Exit Sub
        End If

        'If cmbComu.Text = "" Then
        '    MessageBoxEx.Show("Introduzca la comunidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    cmbComu.Select()
        '    Exit Sub
        'End If

        If txtnomCol.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre de la colonia", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtnomCol.Select()
            Exit Sub
        End If

        If txtcp.Text <> "" Then
            cpp = "'" & txtcp.Text & "'"
        Else
            cpp = "''"
        End If

        Try
            If mtipo = Tipo.Agregar Then

                If obtenerCampo("select count(*) as tot from colonia where id_colonia='" & txtId_col.Text & "'", "tot") > 0 Then
                    MessageBoxEx.Show("LA CLAVE DE LA COLONIA YA EXISTE PARA LA COMUNIDAD, VERIFIQUE SUS DATOS POR FAVOR", "COMUNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                Ejecucion("insert into colonia (id_colonia,colonia,cp) values('" & txtId_col.Text & "','" & txtnomCol.Text & "'," & cpp & ")")
                Ejecucion("update empresa set folio_colonia=" & obtenerCampo("select * from empresa", "folio_colonia") + 1)

            Else
                Ejecucion("update colonia set id_colonia='" & txtId_col.Text & "', colonia='" & txtnomCol.Text & "', cp=" & cpp & " where id_colonia='" & idcom & "'")
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

    Private Sub frmAgrCol_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrCol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Dim col As String
        'col = cmbComu.Text


        'If mtipo = Tipo.Editar Then
        '    Dim rea As IDataReader
        '    rea = ConsultaSql("select * from colonia where id_colonia='" & idcom & "'").ExecuteReader
        '    rea.Read()
        '    txtId_col.Text = rea("id_col")
        '    txtnomCol.Text = rea("colonia")
        '    txtcp.Text = rea("cp")
        '    Me.Text = "Modo visualizacion"
        'End If

        If mtipo = Tipo.Ver Then
            txtId_col.Enabled = False
            txtnomCol.Enabled = False
            txtcp.Enabled = False
            'cmbComu.Enabled = False
            cmdAcept.Visible = False
            'txtId_col.TabStop = False
            'txtnomCol.TabStop = False
            'txtcp.TabStop = False
            'cmbComu.TabStop = False
        ElseIf mtipo = Tipo.Editar Then
            txtId_col.Enabled = False
        End If
        'cmbComu.Text = col
        If mtipo = Tipo.Agregar Then
            'txtId_col.Enabled = False
            'txtId_col.Text = obtenerCampo("select * from empresa", "folio_colonia")

        End If
    End Sub

    'Private Sub cmbComu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbComu.KeyPress
    '    DespliegaCombo(cmbComu, e)
    '    'e.KeyChar = UCase(e.KeyChar)
    'End Sub

    Private Sub txtcp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcp.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
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