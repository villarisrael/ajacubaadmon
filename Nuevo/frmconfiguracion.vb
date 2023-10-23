Public Class frmconfiguracion
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        My.Settings.servidorreporte = txtservidorereportes.Text
        My.Settings.usuarioreporte = txtusernamereporte.Text
        My.Settings.passreporte = txtpassreporte.Text
        My.Settings.basereporte = txtbasededatos.Text
        My.Settings.CombodeCalles = txtmanejocalles.Text
        My.Settings.conceptofactibilidad = txtfactibilidad.Text

        My.Settings.Clavedeconsumo = txtconsumo.Text
        My.Settings.Clavedealcantarillado = txtalcantarillado.Text
        My.Settings.clavedesaneamiento = txtsaneamiento.Text
        My.Settings.ClavedeRezago = txtrezago.Text
        My.Settings.Clavederecargo = txtrecargos.Text

        My.Settings.Save()
    End Sub

    Private Sub TabFormItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmconfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtservidorereportes.Text = My.Settings.servidorreporte
        txtusernamereporte.Text = My.Settings.usuarioreporte
        txtpassreporte.Text = My.Settings.passreporte
        txtbasededatos.Text = My.Settings.basereporte
        txtmanejocalles.Text = My.Settings.CombodeCalles
        txtfactibilidad.Text = My.Settings.conceptofactibilidad

        txtconsumo.Text = My.Settings.Clavedeconsumo
        txtalcantarillado.Text = My.Settings.Clavedealcantarillado
        txtsaneamiento.Text = My.Settings.clavedesaneamiento
        txtrezago.Text = My.Settings.ClavedeRezago
        txtrecargos.Text = My.Settings.Clavederecargo


    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Close()
    End Sub
End Class