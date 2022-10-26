Imports DevComponents.DotNetBar

Public Class frmFpag

    Private Sub frmFpag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select ccodpago as Clave, cdespago as Descripción, ndiasapl as Plazo_en_días, referencia as Referencia from fpago")
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim ir As IDataReader = ConsultaSql("Select ccodpago from pagos where ccodpago = '" & CatControl1.darSeleccionado("Clave") & "'").ExecuteReader
        If ir.Read Then
            MessageBoxEx.Show("No se puede eliminar la Forma de Pago ya que hay Facturas con esta Forma", "Forma de Pago", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            CatControl1.Eliminar()
        End If

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



    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        CatControl1.Actualizar()
    End Sub


    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub
End Class