Public Class frmCatDir

    Private Sub CatControl1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatControl1.Load
        CatControl1.filtrar("select cod_dir as Codigo_Direccion, nombre as Nombre, respons as Responsable from direc")
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
 
    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        CatControl1.Actualizar()
    End Sub
End Class