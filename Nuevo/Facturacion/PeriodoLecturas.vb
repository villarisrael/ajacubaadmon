Public Class PeriodoLecturas
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try


            Ejecucion($"Update PeridoMoviles set mes = '{cmbPeriodoLecturas.Text}' where idPeridoMoviles = 1")

            MessageBox.Show("PERIODO ACTUALIZADO")

            Close()

        Catch ex As Exception
            MessageBox.Show($"OCURRIO UN ERROR AL ACTUALIZAR EL PERIODO: {ex.ToString()}")
        End Try


    End Sub

    Private Sub PeriodoLecturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim periodoLectura As String = ""
        'Anterior _Lec1
        'Actual = lectura
        periodoLectura = obtenerCampo("Select mes from PERIDOMOVILES where idPeridoMoviles = 1", "mes")

        txtMesActual.Text = periodoLectura



    End Sub
End Class