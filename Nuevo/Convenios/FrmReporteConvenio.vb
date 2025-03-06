Public Class FrmReporteConvenio
    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        If rblistadonominal.Checked Then
            Dim con As New Convenio()
            con.GeneralListado(Fechainicio.SelectionStart, Fechafinal.SelectionEnd)
        End If
        If rbdesglozado.Checked Then
            Dim con As New Convenio()
            con.GeneralListadoDesglosado(Fechainicio.SelectionStart, Fechafinal.SelectionEnd)
        End If
        If rbanalisis.Checked Then
            Dim con As New Convenio()
            con.GeneralListadoanalisis(Fechainicio.SelectionStart, Fechafinal.SelectionEnd)
        End If
    End Sub
End Class