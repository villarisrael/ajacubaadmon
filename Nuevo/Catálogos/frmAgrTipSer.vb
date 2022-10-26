Public Class frmAgrTipSer
    Dim mtipo As Tipo
    Dim idser As String = ""
    Dim idusu As String = ""
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
            If idusu <> "" Then
                dser = ConsultaSql("select * from tipos_servicio where id_tipo_servicio='" & idser & "' and id_tipo_usuario='" & idusu & "'").ExecuteReader()
                dser.Read()
            End If
        End Set
    End Property

    Public Property _idusu() As String
        Get
            Return idusu
        End Get
        Set(ByVal value As String)
            idusu = value
            If idser <> "" Then
                dser = ConsultaSql("select * from tipos_servicio where id_tipo_servicio='" & idser & "' and id_tipo_usuario='" & obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion='" & idusu & "'", "id_tipo_usuario") & "'").ExecuteReader()
                dser.Read()
            End If
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
        Dim idv As IDataReader = ConsultaSql("select id_tipo_servicio, id_tipo_usuario from tipos_servicio where id_tipo_servicio='" & txtClavSer.Text & "' and id_tipo_usuario='" & cmbTipUsu.SelectedValue.ToString & "'").ExecuteReader()
        If mtipo = Tipo.Agregar Then
            If idv.Read() Then
                MessageBoxEx.Show("La clave ya existe, verifique porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClavSer.Text = ""
                Exit Sub
            End If
        Else
            If idv.Read() And txtClavSer.Text <> idser And cmbTipUsu.SelectedValue.ToString <> idusu Then
                MessageBoxEx.Show("La clave ya existe, verifique porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtClavSer.Text = ""
                Exit Sub
            End If
        End If

        If txtClavSer.Text = "" Then
            MessageBox.Show("Introduzca la clave del servicio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If cmbTipUsu.Text = "" Then
            MessageBox.Show("Introduzca el tipo de usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If txtDes.Text = "" Then
            MessageBox.Show("Introduzca la descripción del servicio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into tipos_servicio values(""" & cmbTipUsu.SelectedValue.ToString & """,""" & txtClavSer.Text & """,'" & txtDes.Text & "'," & txtAlertCon.Value & "," & CInt(chkCuoFij.Checked) & ")")
            Else
                Ejecucion("update tipos_servicio set id_tipo_usuario=""" & cmbTipUsu.SelectedValue.ToString & """, id_tipo_servicio='" & txtClavSer.Text & "', descripción='" & txtDes.Text & "', alerta_consumo=" & txtAlertCon.Value & ", cuota_fija=" & CBool(chkCuoFij.Checked) & " where id_tipo_servicio=""" & idser & """ and id_tipo_usuario='" & cmbTipUsu.SelectedValue.ToString & "'")
            End If
            MessageBox.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub frmAgrTipSer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmAgrSit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbTipUsu, "Select id_tipo_usuario, descripcion from tipos_usuarios order by descripcion")
        If mtipo = Tipo.Editar Then
            llenar()
        End If
        If mtipo = Tipo.Ver Then
            'Dim rea As IDataReader
            'rea = ConsultaSql("select * from tipos_servicio where id_tipo_servicio =  '" & idser & "'").ExecuteReader
            'rea.Read()

            'Dim tip As String
            'tip = rea("descripción")
            'llenarCombo(cmbTipUsu, "select id_tipo_servicio, descripcion from tipos_usuario")
            'cmbTipUsu.Text = tip

            'txtAlertCon.Text = rea("alerta_consumo")
            'txtClavSer.Text = rea("id_tipo_servicio")
            'txtDes.Text = rea("descripción")

            txtAlertCon.Enabled = False
            txtClavSer.Enabled = False
            txtDes.Enabled = False
            cmbTipUsu.Enabled = False
            txtAlertCon.Enabled = False
            chkCuoFij.Enabled = False
        End If
    End Sub

    Private Sub llenar()
        txtClavSer.Text = dser("id_tipo_servicio")
        txtDes.Text = dser("Descripción")
        If cmbTipUsu.SelectedValue <> dser("id_tipo_usuario") Then cmbTipUsu.SelectedValue = dser("id_tipo_usuario")
        txtAlertCon.Value = dser("alerta_consumo")
        chkCuoFij.Checked = dser("cuota_fija")
    End Sub
End Class