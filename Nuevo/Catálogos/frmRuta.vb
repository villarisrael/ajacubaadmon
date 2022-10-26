Imports DevComponents.DotNetBar

Public Class frmRuta

    Private Sub frmRuta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.Ruta
        CatControl1.filtrar("select rutas.id_ruta as Clave, rutas.ruta as Descripción, region.region as Región from rutas inner join region on (rutas.id_region=region.id_region) order by region, id_ruta")
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
        'Dim region As String = obtenerCampo("select id_region from region where region='" & CatControl1.darSeleccionado("Región") & "' and id_comunidad='" & CatControl1.darSeleccionado("Comunidad") & "'", "id_region")
        If obtenerCampo("select count(*) as tot from usuario where ruta='" & CatControl1.darSeleccionado("Clave") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA RUTA POR QUE ESTÁ EN USO", "RUTAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MessageBoxEx.Show("¿DESEA ELIMINAR LA RUTA " & CatControl1.darSeleccionado("Clave") & ", REGIÓN " & CatControl1.darSeleccionado("Región") & "", "RUTAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'Ejecucion("delete from rutas where id_ruta='" & CatControl1.darSeleccionado("Clave") & "' and id_region='" & region & "' ")
            Ejecucion("delete from rutas where id_ruta='" & CatControl1.darSeleccionado("Clave") & "'")
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
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False

        Dim idruta As IDataReader = ConsultaSql("select * from rutas").ExecuteReader()
        While idruta.Read()
            Ejecucion("update rutas set n_usuarios=(select count(*) from usuario where   region='" & idruta("id_region") & "' and ruta='" & idruta("id_ruta") & "' and mostrar=1) where  id_region='" & idruta("id_region") & "' and id_ruta='" & idruta("id_ruta") & "'")
        End While
        CatControl1.Imprimir()
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"

    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        If CatControl1.darNumReg > 0 Then
            CatControl1.Visualizar()
        End If
    End Sub

    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRes.Click
        CatControl1.Actualizar()
    End Sub
End Class