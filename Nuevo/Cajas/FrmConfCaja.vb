Public Class FrmConfCaja
    Dim X As New ClassRegistros
    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FBD.ShowDialog()
        TxtRuta.Text = FBD.SelectedPath
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        X.grabRutadDase(TxtRuta.Text)
    End Sub

    Private Sub FrmConfCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtRuta.Text = X.obtRutaDbase
    End Sub

    Private Sub BtnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBase.Click
        FBD.ShowDialog()
        TxtBase.Text = FBD.SelectedPath
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        MessageBox.Show("Recuerde que esta funcion solo trabajara si se esta en una maquina con el servicio de base de datos instalado, no estara disponible para equipos remotos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Shell("cmd.exe /k mysql --user=root --host=localhost --password=root baseagua <  " & TxtBase.Text & "\CajaMovil.sql")
    End Sub
End Class