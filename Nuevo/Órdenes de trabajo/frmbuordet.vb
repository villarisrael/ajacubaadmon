Public Class frmbuordet
    Public local As frmAgrOrd
    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        If txtnombre.Text.Length > 6 Then
            llenaGrid(DataGridViewX1, "select Nombre,Cuenta from usuario where nombre like '" & txtnombre.Text & "%'")
            DataGridViewX1.Columns(0).Width = 300
            DataGridViewX1.Columns(1).Width = 50
        End If
    End Sub

   

    Private Sub DataGridViewX1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellDoubleClick
        Try
            local.txtcuenta.Text = DataGridViewX1.SelectedRows(0).Cells(1).Value
            local.txtNombre.Text = DataGridViewX1.SelectedRows(0).Cells(0).Value
            local.datosUsu(True)
        Catch ex As Exception

        End Try
       
        'local.txtTel.Focus()
        Close()
    End Sub
End Class