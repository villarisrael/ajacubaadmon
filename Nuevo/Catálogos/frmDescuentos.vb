Imports DevComponents.DotNetBar

Public Class frmDescuentos

    Private Sub frmDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl._frm = Me
        CatControl._catalogo = catControl.Catalogos.Descuentos
        CatControl.filtrar("select descuentos.idDescuento as ID, descuentos.xDescrip as DESCRIPCION, descuentos.nPctDsct AS PORCENTAJE, unidaddscto.DscUnidadDscto AS UNIDAD from descuentos, unidaddscto where descuentos.idUnidadDscto=unidaddscto.idUnidadDscto")
        CatControl.dgDAt.Columns("PORCENTAJE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        CatControl.dgDAt.Columns("UNIDAD").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        CatControl.Agregar()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If CatControl.darNumReg > 0 Then
            CatControl.Editar()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        CatControl.Buscar()
    End Sub

    Private Sub btnRest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRest.Click
        CatControl.Actualizar()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim ID As String = obtenerCampo("select idDescuento from descuentos where xDescrip ='" & CatControl.darSeleccionado("DESCRIPCION") & "'", "idDescuento")

        If obtenerCampo("select count(*) as tot from usuario where  idDescuento='" & ID & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR EL DESCUENTO " & CatControl.darSeleccionado("DESCRIPCION") & "", "DESCUENTOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR EL DESCUENTO " & CatControl.darSeleccionado("DESCRIPCION") & "?", "DESCUENTOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from descuentos where idDescuento='" & ID & "'")
            CatControl.Actualizar()
        End If
    End Sub

    Private Sub btnImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImp.Click
        btnImp.Text = "Imprimiendo..."
        btnImp.Enabled = False
        CatControl.Imprimir()
        btnImp.Enabled = True
        btnImp.Text = "Imprimir"
    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        If CatControl.darNumReg > 0 Then
            CatControl.Visualizar()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        CatControl.Salir()
    End Sub
End Class