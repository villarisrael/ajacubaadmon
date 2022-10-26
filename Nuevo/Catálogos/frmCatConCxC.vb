Imports DevComponents.DotNetBar

Public Class frmCatConCxC

    Private Sub frmCatConCxC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim estilo As New System.Windows.Forms.DataGridViewCellStyle
        estilo.Alignment = DataGridViewContentAlignment.MiddleRight
        estilo.ForeColor = Color.Blue
        estilo.Format = "###,###.####"
        CatControl1.filtrar("select id_concepto as Id_Concepto, descripcion as Descripción, tipo as Tipo, Evento as Evento,  VSM as 'Monto SM',Monto_inicial as 'Monto $',ClaveSat,UnidadSat from conceptoscxc where obsoleto=0")

        CatControl1.dgDAt.Columns(5).DefaultCellStyle = estilo
    End Sub

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim otr As String = ""
        otr = obtenerCampo("select folio from otrosconceptos where folio='" & CatControl1.darSeleccionado("Id_Concepto") & "'", "folio")
        If otr = "" OrElse otr = "0" Then
            If MessageBoxEx.Show("¿Desea eliminar el concepto " & CatControl1.darSeleccionado("Id_Concepto") & " ?", "Conceptos cxc", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Ejecucion("delete  from conceptoscxc where id_concepto='" & CatControl1.darSeleccionado("Id_Concepto") & "'")
                CatControl1.Actualizar()
            End If
        Else
            MessageBoxEx.Show("No se puede eliminar el concepto " & CatControl1.darSeleccionado("Id_Concepto") & " por que está en uso", "Conceptos cxc", MessageBoxButtons.OK, MessageBoxIcon.Information)
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