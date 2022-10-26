Imports DevComponents.DotNetBar

Public Class frmCatConcepCis

    Private Sub frmCatConcepCis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("Select cveque.Cod_CVE as 'Clave', cveque.descripcion as Descripción, cveque.cod_res as 'Código Responsable', cveque.cod_dir as Dirección, cveque.dias_norm as 'Días Normal', cveque.dias_urge as 'Días Urge' from cveque, direc, deptos where deptos.cod_dep =cveque.cod_res and cveque.cod_Dir=direc.Cod_Dir")
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

    Private Sub btnVisu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If obtenerCampo("select count(*) as tot from ordent where cod_cve='" & CatControl1.darSeleccionado("Clave") & "'", "tot") > 0 Then
            MessageBoxEx.Show("No se puede eliminar el concepto : " & CatControl1.darSeleccionado("Descripción") & " por que está en uso.", "CONCEPTOS CIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR EL CONCEPTOS " & CatControl1.darSeleccionado("Descripción") & "?", "CONCEPTOS CIS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from cveque where cod_cve='" & CatControl1.darSeleccionado("Clave") & "'")
            CatControl1.Actualizar()
        End If

    End Sub
End Class