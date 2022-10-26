Imports DevComponents.DotNetBar

Public Class frmCatCajas

    Private Sub frmCatCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Column1 As New System.Windows.Forms.DataGridViewCheckBoxColumn
        Try
            Column1.HeaderText = "ACTIVO"
            Column1.Name = "ACTIVO"
            Column1.ReadOnly = False
            Column1.DataPropertyName = "activo"

            Column1.Width = 54
        Catch err As Exception
            MsgBox(err.Message)

        End Try
        CatControl1.dgDAt.Columns.Add(Column1)
        CatControl1.filtrar("select id_caja as CLAVE, serie as SERIE, cod_ofi as OFICINA, folio as 'FOLIO DE RECIBO', activo from cajas")

        'CatControl1.dgDAt
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If MessageBoxEx.Show("¿DESEA ELIMINAR LA CAJA: " & CatControl1.darSeleccionado("CLAVE") & "?", "CAJAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from cajas where id_caja='" & CatControl1.darSeleccionado("CLAVE") & "'")
            CatControl1.Actualizar()
        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        CatControl1.Imprimir()
    End Sub
    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub
End Class