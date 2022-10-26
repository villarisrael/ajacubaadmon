Imports DevComponents.DotNetBar

Public Class frmCatBrig
    Private Sub frmCatBrig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select brigada.NoBrig as 'Número_Brigada', brigada.descripcion as Descripción, direc.nombre as Dirección from brigada, direc where brigada.cod_Dir = direc.cod_Dir and direc.cod_dir= brigada.cod_dir")
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

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Visualizar()
    End Sub

    Private Sub btnVisu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If obtenerCampo("select count(*) as tot from trabajadores where nobrig='" & CatControl1.darSeleccionado("Número_Brigada") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA BRIGADA POR QUE ESTÁ EN USO", "BRIGADAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA BRIGADAD " & CatControl1.darSeleccionado("Descripción") & "?", "BRIGADAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete  from brigada where nobrig='" & CatControl1.darSeleccionado("Número_Brigada") & "'")
            CatControl1.Actualizar()
        End If

    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub
End Class