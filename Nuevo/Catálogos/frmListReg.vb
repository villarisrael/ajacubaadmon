Imports DevComponents.DotNetBar

Public Class frmListReg

    Private Sub frmListReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select id_region as Clave_región, region as Región from region")

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

        '     Dim comunidad As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & CatControl1.darSeleccionado("Comunidad") & "'", "id_comunidad")

        If obtenerCampo("select count(*) as tot from usuario where region='" & CatControl1.darSeleccionado("Clave_región") & "' ", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA REGIÓN POR QUE ESTÁ EN USO", "REGIONES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA REGIÓN " & CatControl1.darSeleccionado("Región") & "?", "REGIONES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from region where id_region='" & CatControl1.darSeleccionado("Clave_región") & "' ")
            CatControl1.Actualizar()
        End If
        'CatControl1.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        Dim idreg As IDataReader = ConsultaSql("select * from region").ExecuteReader()

        While idreg.Read()
            Ejecucion("update region set n_usuarios=(select count(*) from usuario where region='" & idreg("id_region") & "' and mostrar=1) where id_region='" & idreg("id_region") & "'")
        End While

        CatControl1.Imprimir()
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
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