Imports DevComponents.DotNetBar

Public Class frmComu



    Private Sub frmComu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.Comunidades
        CatControl1.filtrar("select comunidades.id_comunidad as ID_Comunidad, municipios.nombre as Municipio, comunidades.Comunidad, comunidades.no_contrato as Folio_de_Contrato  from comunidades, municipios where comunidades.nmpio=municipios.clave")
        ' CatControl1.creaTab()
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
        If obtenerCampo("select count(*) as tot from usuario where id_comunidad='" & CatControl1.darSeleccionado("ID_Comunidad") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA COMUNIDAD POR QUE ESTÁ EN USO", "COMUNIDADES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA COMUNIDAD " & CatControl1.darSeleccionado("Comunidad") & "?", "COMUNIDADES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from comunidades where id_comunidad='" & CatControl1.darSeleccionado("ID_Comunidad") & "'")
            CatControl1.Actualizar()

        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        'Dim frm As New frmOrdenado("comunidades")
        'frm.ShowDialog()
        CatControl1.Imprimir()
    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Visualizar()
    End Sub

    Private Sub btnVisu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        If CatControl1.darNumReg > 0 Then
            CatControl1.Visualizar()
        End If
    End Sub

    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRes.Click
        CatControl1.Actualizar()
    End Sub
End Class