Public Class frmTipSer

    Private Sub frmTipSer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select tipos_servicio.id_tipo_servicio as Clave, tipos_usuarios.descripcion as Tipo_Usuario, tipos_servicio.Descripción as Descripción, tipos_servicio.alerta_Consumo as Alerta_Consumo, tipos_servicio.cuota_fija as Cuota_fija from tipos_servicio, tipos_usuarios where tipos_servicio.id_tipo_usuario=tipos_usuarios.id_tipo_usuario")
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        CatControl1.Eliminar()
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

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Visualizar()
    End Sub

    Private Sub btnVisu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub
End Class