Public Class ListConvenios
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Not frmConvenio.Created Then
            frmConvenio.Show()
        End If
        frmConvenio.Select()
    End Sub

    Private Sub ListConvenios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datConvenios.Refresh()
        llenargrid()
    End Sub
    Public Sub llenargrid()
        Dim CONSULTA As String
        Try
            CONSULTA = "select e.idencconvenio, idCuenta as Cuenta, Nombre, telefono, e.total as Total, fechacreacion, pagos, aplazamiento,e.Estado from encConvenio e order  by e.idencconvenio desc LIMIT 1000"
            llenaGrid(datConvenios, CONSULTA)
            datConvenios.Columns("Cuenta").Width = 70
            datConvenios.Columns("Nombre").Width = 700
            datConvenios.Columns("Telefono").Width = 200

            datConvenios.Columns("Pagos").Width = 100
            datConvenios.Columns("Aplazamiento").Width = 100
            datConvenios.Columns("fechacreacion").Width = 100
            '  datConvenios.Columns("descuento").Width = 200

            datConvenios.Columns("Estado").Width = 100
            datConvenios.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVisualizar_Click(sender As Object, e As EventArgs) Handles cmdVisualizar.Click
        Try
            If datConvenios.CurrentRow.Cells(0).Value = 0 Then
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("No hay seleccionado un convenio")
            Exit Sub
        End Try


        Try
            Dim frmvisual = New FrnVisualizarConvenio
            frmvisual.cargardatos(datConvenios.CurrentRow.Cells(0).Value)
            frmvisual.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "No has seleccionado un contrato correctamente")
        End Try
    End Sub



    Private Sub cmdact_Click(sender As Object, e As EventArgs) Handles cmdact.Click
        llenargrid()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        ' Verificar si hay una fila seleccionada
        If datConvenios.CurrentRow Is Nothing Then
            MessageBox.Show("Seleccione un convenio para cancelar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Obtener el ID del convenio seleccionado
        Dim convenioId As Integer = Convert.ToInt32(datConvenios.CurrentRow.Cells(0).Value)

        ' Confirmación del usuario
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro de cancelar este convenio?", "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.No Then Exit Sub

        ' Cancelar convenio en la base de datos
        Dim repo As New RepositorioConvenios()
        If repo.CancelarConvenio(convenioId) Then
            MessageBox.Show("Convenio cancelado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refrescar la lista de convenios en el DataGridView
            llenargrid()
        Else
            MessageBox.Show("Error al cancelar el convenio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub btnim_Click(sender As Object, e As EventArgs) Handles btnim.Click
        Dim frmre As New FrmReporteConvenio
        frmre.Show()
    End Sub
End Class