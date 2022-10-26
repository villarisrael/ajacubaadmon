Public Class frmMotivoCont

    Private _motivo As String

    Public Property motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        If txtMotivo.Text <> "" Then
            _motivo = txtMotivo.Text
            Me.Close()
        Else
            MessageBox.Show("Introduzca el motivo de las modificaciones por favor", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
    End Sub

    Private Sub frmMotivoCont_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CloseEnabled = False
    End Sub
End Class