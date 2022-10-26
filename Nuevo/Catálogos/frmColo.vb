Imports DevComponents.DotNetBar

Public Class frmColo
    Private Sub frmColo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.Colonias
        CatControl1.filtrar("select colonia.id_colonia as Id_Colonia, colonia.colonia as Colonia, colonia.cp as Cp from colonia order by colonia.id_colonia")
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
        'Dim comu As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & CatControl1.darSeleccionado("Comunidad") & "'", "id_comunidad")

        If obtenerCampo("select count(*) as tot from usuario where id_colonia='" & CatControl1.darSeleccionado("Id_Colonia") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA COLONIA POR QUE ESTÁ EN USO", "COLONIAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA COLONIA " & CatControl1.darSeleccionado("Colonia") & "?", "COLONIAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from colonia where id_colonia='" & CatControl1.darSeleccionado("Id_Colonia") & "'")
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
        Dim idcol As IDataReader = ConsultaSql("select * from colonia").ExecuteReader()
        While idcol.Read()
            Ejecucion("update colonia set n_usuarios=(select count(*) from usuario where  id_colonia='" & idcol("id_colonia") & "' and mostrar=1) where   id_colonia='" & idcol("id_colonia") & "'")
        End While


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