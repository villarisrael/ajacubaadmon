Public Class FrnVisualizarConvenio

    Private convenio As New ConvenioPago()
    Public Sub cargardatos(_idconvenio As String)
        Dim idConvenio As Integer

        ' Validar entrada
        If Not Integer.TryParse(_idconvenio, idConvenio) Then
            MessageBox.Show("Ingrese un ID de convenio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Obtener convenio desde la base de datos
        Dim repo As New RepositorioConvenios()
        convenio = repo.ObtenerConvenioPorId(idConvenio)

        If convenio Is Nothing Then
            MessageBox.Show("Convenio no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Mostrar datos del convenio
        txtidconvenio.Text = convenio.idConvenio
        txtNombre.Text = convenio.Nombre
        txtTelefono.Text = convenio.Telefono
        txtTotalAdeudo.Text = convenio.TotalDeuda.ToString("C")
        txtEstado.Text = convenio.Estado
        txtFechaCreacion.Text = convenio.fechacreacion.ToShortDateString()
        txtNumeroPagos.Text = convenio.NumeroPagos
        txtAplazamiento.Text = convenio.Aplazamiento
        lblvencimiento.Text = "Finaliza " & convenio.Mes & " " & convenio.Periodo

        Dim repou = New VUsuarioRepository().ObtenerUsuarioPorCuenta(convenio.IdCuenta)

        lblnombre.Text = repou.Nombre
        lblfecha.Text = repou.PeriodoAdeudo
        lbldireccion.Text = repou.Direccion & " " + repou.NumExt & " " & repou.NumInt
        lblcolonia.Text = repou.Colonia
        lblcomunidad.Text = repou.Comunidad
        lbltarifa.Text = repou.DescripcionCuota
        lbltotal.Text = repou.Total.ToString("C")
        txtestadotoma.Text = repou.Estado
        txtubicacion.Text = repou.Ubicacion

        ' Llenar Grid con los pagos del convenio
        dataConv.Rows.Clear()
        For Each Pago As PagoConvenio In convenio.Pagos
            dataConv.Rows.Add(Pago.FechaPago.ToShortDateString(), Pago.NoPagare, Pago.Monto.ToString("C"), If(Pago.Pagado, "Pagado", "Pendiente"))
        Next

        ' MessageBox.Show("Convenio cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles ButtonX4.Click
        Dim conve As New Convenio
        conve.GenerarConvenio(convenio.idConvenio)
    End Sub

    Private Sub Buttoncerrar_Click(sender As Object, e As EventArgs) Handles Buttoncerrar.Click
        Close()
    End Sub

    Private Sub FrnVisualizarConvenio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class