Public Class PeriodoLecturas
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        Try


            Ejecucion($"Update PeridoMoviles set mes = '{cmbMes.Text}', Periodo = '{cmbPeriodo.Text}' where idPeridoMoviles = 1")
            'Ejecucion($"Update PeridoMoviles set Periodo = '{cmbPeriodo.Text}' where idPeridoMoviles = 1")

            MessageBox.Show("PERIODO ACTUALIZADO")

            Close()

        Catch ex As Exception
            MessageBox.Show($"OCURRIO UN ERROR AL ACTUALIZAR EL PERIODO: {ex.ToString()}")
        End Try


    End Sub

    Private Sub PeriodoLecturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim periodoLectura As String = ""
        Dim periodo As String = ""
        'Anterior _Lec1
        'Actual = lectura
        periodoLectura = obtenerCampo("Select mes from PERIDOMOVILES where idPeridoMoviles = 1", "mes")
        periodo = obtenerCampo("Select periodo from PERIDOMOVILES where idPeridoMoviles = 1", "periodo")

        lblMes.Text = periodoLectura
        lblPeriodo.Text = periodo

        Dim n As Integer

        With cmbPeriodo

            For n = 2020 To 2099

                cmbPeriodo.Items.Add(n)

            Next

        End With

        cmbPeriodo.Text = DateTime.Now.Year

    End Sub
End Class