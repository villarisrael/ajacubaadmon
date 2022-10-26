Public Class frmcambiofolio

    Private Sub frmcambiofolio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.IntegerInput1.Value = Val(frmCajas.LblRecibo.Text)
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        frmCajas.LblRecibo.Text = IntegerInput1.Value
        frmCajas.recibo = IntegerInput1.Value
        Close()

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Close()
    End Sub
End Class