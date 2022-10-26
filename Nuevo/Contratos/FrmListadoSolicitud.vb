Public Class FrmListadoSolicitud

    Private Sub FrmListadoSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.Solicitud
        CatControl1.filtrar("select * from vsolicitud")
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        CatControl1.Imprimir()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub BtnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMostrar.Click
        CatControl1.Editar()
    End Sub

    Private Sub btnmostrarfactibilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmostrarfactibilidad.Click
        My.Forms.MDIPrincipal.Factibilidad(CatControl1.dgDAt.Item(0, CatControl1.dgDAt.CurrentRow.Index).Value)
    End Sub
End Class