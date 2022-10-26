Public Class frmBuscaruser


    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Hide()
    End Sub

    Private Sub txtcuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcuenta.TextChanged
        Try
            Dim x As base = New base()
            x.llenaGrid(DTGbusqueda, "   SELECT CUENTA , NOMBRE, DIRECCION, COLONIA,DESCRIPCION_CUOTA FROM vusuario WHERE CUENTA =" & txtcuenta.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        If txtnombre.Text.Length > 3 Then
            Dim x As base = New base()
            x.llenaGrid(DTGbusqueda, "   SELECT CUENTA , NOMBRE, DIRECCION, COLONIA,DESCRIPCION_CUOTA FROM vusuario WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")

        End If
    End Sub

    Private Sub txtdireccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdireccion.TextChanged
        If txtdireccion.Text.Length > 3 Then
            Dim x As base = New base()
            x.llenaGrid(DTGbusqueda, "   SELECT CUENTA , NOMBRE, DIRECCION, COLONIA,DESCRIPCION_CUOTA FROM vusuario WHERE DIRECCION LIKE '%" & txtdireccion.Text & "%'")
        End If
    End Sub

    Private Sub txtcolonia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcolonia.TextChanged
        If txtcolonia.Text.Length > 3 Then
            Dim x As base = New base()
            x.llenaGrid(DTGbusqueda, "SELECT CUENTA , NOMBRE, DIRECCION, COLONIA,DESCRIPCION_CUOTA FROM vusuario WHERE COLONIA LIKE '%" & txtcolonia.Text & "%'")

        End If
    End Sub

    Private Sub DTGbusqueda_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DTGbusqueda.CellMouseDoubleClick
        Try
            Dim cuenta As Long = DTGbusqueda.SelectedRows.Item(0).Cells(0).Value
            'CajaSaldos.txtCuentaCliente.Text = cuenta
            'CajaSaldos.usuario = 1
            'CajaSaldos.btnbuscacliente_Click_1(sender, e)
            Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        Try
            Dim cuenta As Long = DTGbusqueda.SelectedRows.Item(0).Cells(0).Value
            'CajaSaldos.txtCuentaCliente.Text = cuenta
            'CajaSaldos.usuario = 1
            'CajaSaldos.btnbuscacliente_Click_1(sender, e)
            Close()
        Catch ex As Exception

        End Try
    End Sub
End Class