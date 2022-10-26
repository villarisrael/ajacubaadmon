Imports DevComponents.DotNetBar

Public Class frmubmedidor

    Private Sub frmubmedidor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select id_ubmedidor as Clave, descripcion as Descripción from ub_medidor")
    End Sub



    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRes.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If CatControl1.darNumReg > 0 Then
            CatControl1.Editar()
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If obtenerCampo("select count(*) as tot from usuario where matcalle='" & CatControl1.darSeleccionado("Clave") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR EL MATERIAL POR QUE ESTÁ EN USO", "MATERIAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR EL MATERIAL " & CatControl1.darSeleccionado("Descripción") & "?", "MATERIAL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from mat_calle where id_matcalle='" & CatControl1.darSeleccionado("Clave") & "'")
            CatControl1.Actualizar()
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()

    End Sub

    Private Sub cmdImp_Click(sender As Object, e As EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        CatControl1.Imprimir()
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"
    End Sub
End Class