Imports DevComponents.DotNetBar

Public Class frmCalles

    Private Sub frmCalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1._frm = Me
        CatControl1._catalogo = catControl.Catalogos.Calles
        CatControl1.filtrar("select  calles.ID_CALLE as Id_CALLE, calles.Nombre as Calle from calles ")

        'CatControl1.creaTab()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CatControl1.darNumReg > 0 Then
            CatControl1.Editar()
        End If
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim comunidad As String = obtenerCampo("select id_comunidad from comunidades where comunidad='" & CatControl1.darSeleccionado("Comunidad") & "'", "id_comunidad")
        Dim colonia As String = obtenerCampo("select id_colonia from colonia where colonia='" & CatControl1.darSeleccionado("Colonia") & "'", "id_colonia")

        If obtenerCampo("select count(*) as tot from usuario where  id_calle='" & CatControl1.darSeleccionado("ID_CALLE") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA CALLE " & CatControl1.darSeleccionado("Calle") & "", "CALLES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA CALLE " & CatControl1.darSeleccionado("CALLE") & "?", "CALLES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from calles where  id_calle='" & CatControl1.darSeleccionado("ID_CALLE") & "'")
            CatControl1.Actualizar()
        End If
        'CatControl1.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Buscar()
    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Salir()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        Dim idcall As IDataReader = ConsultaSql("select * from calles").ExecuteReader()
        While idcall.Read()
            Ejecucion("update calles set n_usuarios=(select count(cuenta) from usuario where id_calle='" & idcall("id_calle") & "' and mostrar=1)")
        End While
        CatControl1.Imprimir()
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"

    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CatControl1.darNumReg > 0 Then
            CatControl1.Visualizar()
        End If
    End Sub

    Private Sub cmdRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Actualizar()

    End Sub

    Private Sub ButtonItem1_Click_1(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click_1(sender As Object, e As EventArgs) Handles cmdEditar.Click
        If CatControl1.darNumReg > 0 Then
            CatControl1.Editar()
        End If
    End Sub

    Private Sub cmdEliminar_Click_1(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        Dim colonia As String = obtenerCampo("select id_colonia from colonia where colonia='" & CatControl1.darSeleccionado("Colonia") & "'", "id_colonia")

        If obtenerCampo("select count(*) as tot from usuario where  id_calle='" & CatControl1.darSeleccionado("ID_CALLE") & "'", "tot") > 0 Then
            MessageBoxEx.Show("NO SE PUEDE ELIMINAR LA CALLE " & CatControl1.darSeleccionado("Calle") & "", "CALLES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA ELIMINAR LA CALLE " & CatControl1.darSeleccionado("CALLE") & "?", "CALLES", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from calles where  id_calle='" & CatControl1.darSeleccionado("ID_CALLE") & "'")
            CatControl1.Actualizar()
        End If
    End Sub

    Private Sub cmdBuscar_Click_1(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub


    Private Sub cmdRes_Click_1(sender As Object, e As EventArgs) Handles cmdRes.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub btnVisu_Click_1(sender As Object, e As EventArgs) Handles btnVisu.Click
        If CatControl1.darNumReg > 0 Then
            CatControl1.Visualizar()
        End If
    End Sub

    Private Sub cmdImp_Click_1(sender As Object, e As EventArgs) Handles cmdImp.Click
        cmdImp.Text = "Imprimiendo..."
        cmdImp.Enabled = False
        Dim idcall As IDataReader = ConsultaSql("select * from calles").ExecuteReader()
        While idcall.Read()
            Ejecucion("update calles set n_usuarios=(select count(cuenta) from usuario where id_calle='" & idcall("id_calle") & "' and mostrar=1)")
        End While
        CatControl1.Imprimir()
        cmdImp.Enabled = True
        cmdImp.Text = "Imprimir"

    End Sub

    Private Sub cmdSalir_Click_1(sender As Object, e As EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub
End Class