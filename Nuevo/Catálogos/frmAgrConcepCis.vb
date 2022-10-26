Imports DevComponents.DotNetBar

Public Class frmAgrConcepCis
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
        ' Dim cpp As String
        Dim clm As String = obtenerCampo("select cod_Cve from cveque Where cod_cve=""" & txtCod_cve.Text & """", "cod_cve")

        If txtCod_cve.Text = "" Then
            MessageBoxEx.Show("INTRODUZCA LA CLAVE DEL CONCEPTO", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCod_cve.Select()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MessageBoxEx.Show("INTRODUZCA LA DESCRIPCIÓN", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Select()
            Exit Sub
        End If

        If cmbRespon.Text = "" Then
            MessageBoxEx.Show("INTRODUZCA EL NOMBRE DEL RESPONSABLE", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbRespon.Select()
            Exit Sub
        End If

        If cmbDirec.Text = "" Then
            MessageBox.Show("INTRODUZCA LA CLAVE DE LA DIRECCIÓN", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbDirec.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Dim rs As IDataReader = ConsultaSql("Select cod_cve from cveque where cod_cve = '" & txtCod_cve.Text & "'").ExecuteReader
                If rs.Read Then
                    MessageBoxEx.Show("Existe un concepto con esa clave, verifique sus datos", "Conceptos Cis", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    Ejecucion("insert into cveque(cod_cve,descripcion,cod_res,cod_dir,dias_norm,dias_urge,en_web) values(""" & txtCod_cve.Text & """,""" & txtDescripcion.Text & """,""" & cmbRespon.SelectedValue.ToString & """,""" & cmbDirec.SelectedValue.ToString & """," & inipDNor.Text & "," & inipDUrg.Text & "," & chkWeb.Checked & ")")
                End If
            Else
                Ejecucion("update cveque set descripcion='" & txtDescripcion.Text & "', cod_res='" & cmbRespon.SelectedValue.ToString & "', cod_dir='" & cmbDirec.SelectedValue.ToString & "', dias_norm=" & inipDNor.Text & ", dias_urge =" & inipDUrg.Text & ", en_web=" & chkWeb.Checked & " where cod_cve='" & txtCod_cve.Text & "'")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show(err.Message())
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cmadCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmadCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmAgrConcepCis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Private Sub frmAgrConcepCis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(cmbDirec, "select Cod_Dir, nombre from direc order by nombre")

        If mtipo <> Tipo.Agregar Then
            Dim rea As IDataReader
            rea = ConsultaSql("select * from cveque where cod_cve='" & idcom & "'").ExecuteReader
            rea.Read()
            txtCod_cve.Text = rea("cod_cve")
            txtDescripcion.Text = rea("Descripcion")
            cmbDirec.SelectedValue = rea("cod_dir")
            cmbRespon.SelectedValue = rea("cod_res")
            inipDNor.Text = rea("dias_norm")
            inipDUrg.Text = rea("dias_urge")
            txtCod_cve.ReadOnly = True
            chkWeb.Checked = rea("en_web")
            If mtipo = Tipo.Ver Then
                txtDescripcion.ReadOnly = True
                cmbDirec.Enabled = False
                cmbRespon.Enabled = False
                inipDNor.Enabled = False
                inipDUrg.Enabled = False
                cmdAceptar.Visible = False
                cmadCancelar.Select()
            End If
        End If
        If mtipo = Tipo.Agregar Then
            txtCod_cve.Text = Val(obtenerCampo("select max(cod_cve) as a from cveque", "a")) + 1
        End If
    End Sub


    Private Sub cmbDirec_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDirec.SelectedIndexChanged
        If Not cmbDirec.SelectedValue Is Nothing AndAlso cmbDirec.SelectedValue.ToString <> "System.Data.DataRowView" Then
            llenarCombo(cmbRespon, "select cod_dep, nombre from deptos where cod_dir='" & cmbDirec.SelectedValue.ToString & "' order by nombre")
        End If
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