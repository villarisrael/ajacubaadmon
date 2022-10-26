Imports DevComponents.DotNetBar

Public Class frmMuni


    Private Sub frmMuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._catalogo = catControl.Catalogos.Municipios
        CatControl1._frm = Me
        CatControl1.filtrar("select clave as Id_Municipio, nombre as Municipio from municipios")
        'CatControl1.creaTab()
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
        If obtenerCampo("select count(*) as tot from usuario where nmunicipio=" & CatControl1.darSeleccionado("id_municipio") & "", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR EL MUNICIPIO POR QUE ESTÁ EN USO", "MUNICIPIOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR EL MUNICIPIO " & CatControl1.darSeleccionado("Municipio") & "?", "MUNICIPIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from municipios where clave=" & CatControl1.darSeleccionado("id_municipio") & "")
            CatControl1.Actualizar()
        End If
        'CatControl1.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        'Dim frm As New frmOrdenado("municipios")
        'frm.ShowDialog()
        CatControl1.Imprimir()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
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