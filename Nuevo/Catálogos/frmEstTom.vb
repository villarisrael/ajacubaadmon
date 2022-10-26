Imports DevComponents.DotNetBar

Public Class frmEstTom





    Private Sub frmEstTom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.EstadosToma
        CatControl1.filtrar("select clave as Clave_Estado, descripcion as Descripción from estadotoma")
        'CatControl1.creaTab()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If obtenerCampo("select count(*) as tot from usuario where estado=" & CatControl1.darSeleccionado("Clave_Estado") & "", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR EL ESTADO POR QUE ESTÁ EN USO", "ESTADOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR EL ESTADO " & CatControl1.darSeleccionado("Descripción") & "?", "ESTADOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from estadotoma where clave=" & CatControl1.darSeleccionado("Clave_Estado") & "")
            CatControl1.Actualizar()
        End If
        'CatControl1.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        CatControl1.Imprimir()
    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub
End Class