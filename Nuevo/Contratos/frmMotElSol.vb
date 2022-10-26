Public Class frmMotElSol
    Private _nsol As Double
    Public Property nsol() As Double
        Get
            Return _nsol
        End Get
        Set(ByVal value As Double)
            _nsol = value
        End Set
    End Property

    Private Sub frmMotElSol_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()

    End Sub
    Private Sub frmMotElSol_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub

 

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Ejecucion("update solicitud set estadosolicitud='CANCELADA', OBSERVA= CONCAT(OBSERVA,', MOT. CANCELACIÓN: ', '" & txtMot.Text & "') where numero=" & _nsol & "")
        Me.Close()
    End Sub

    Private Sub cmdAcept_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.GotFocus
        cmdAcept.Pulse()
        cmdAcept.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdAcept_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAcept.LostFocus
        cmdAcept.StopPulse()
    End Sub


    Private Sub cmdCan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCan.GotFocus
        cmdCan.Pulse()
        cmdCan.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdCan_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCan.LostFocus
        cmdCan.StopPulse()
    End Sub

    Private Sub cmdCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCan.Click
        Me.Close()
    End Sub

    Private Sub frmMotElSol_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtMot.Text = ""
    End Sub
End Class