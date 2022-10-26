Public Class frmRepCont1

    Private Sub cmdCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCan.Click
        Me.Close()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        Dim cad As String = ""
        Dim tit As String = ""
        If cmbTipUsu.SelectedValue <> Nothing Then
            cad = "{cuotas1.ParaUso}='" & cmbTipUsu.SelectedValue.ToString & "'"
            tit = "TIPO DE USUARIO: " & cmbTipUsu.Text
            'Else
            '    MessageBoxEx.Show("ESPECIFIQUE EL TIPO DE USUARIO", "REPORTE DE CONTEO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If chkFig.Checked Then
            If Len(cad) > 0 Then
                cad &= " and {cuotas1.MEDIDO}=0"
            Else
                cad = "{cuotas1.MEDIDO}=0"
            End If
            tit &= " FIJOS"
        ElseIf chkMed.Checked Then
            If Len(cad) > 0 Then
                cad &= " and {cuotas1.MEDIDO}=1"
            Else
                cad = "{cuotas1.MEDIDO}=1"
            End If

            tit &= " MEDIDOS"
        End If
        If Len(cad) > 0 Then
            cad &= " and {vusuario1.mostrar}=1"
        Else
            cad &= "{vusuario1.mostrar}=1"
        End If
        Dim frm As New frmReporte(frmReporte.Lista.UsuariosCont, cad, "titulo, '" & tit & "'")
        frm.MdiParent = MDIPrincipal
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
        Me.Close()

    End Sub

    Private Sub cmdImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub
    Private Sub cmdImp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.LostFocus
        cmdImp.StopPulse()
    End Sub
    Private Sub cmdCan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCan.GotFocus
        cmdCan.Pulse()
        cmdCan.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdCan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCan.LostFocus
        cmdCan.StopPulse()
    End Sub

    Private Sub frmRepCont1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub frmRepCont1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarCombo(cmbTipUsu, "select id_tipo_usuario,descripcion from tipos_usuarios")

    End Sub

    Private Sub cmbTipUsu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbTipUsu.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

End Class