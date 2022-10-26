Public Class LtsRubros
    Inherits DevComponents.DotNetBar.Office2007Form

    Private Sub LtsRubros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select ID_Rubro as ID_rubro, Descripcion as DESCRIPCION from rubros")
    End Sub

    Private Sub cmdagregar_Click(sender As Object, e As EventArgs) Handles cmdagregar.Click
        CatControl1.Agregar()
        CatControl1.filtrar("select ID_Rubro as ID_rubro, Descripcion as DESCRIPCION from rubros")
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        CatControl1.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(sender As Object, e As EventArgs) Handles cmdImp.Click
        CatControl1.Imprimir()
    End Sub

    Private Sub btnVisu_Click(sender As Object, e As EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
End Class