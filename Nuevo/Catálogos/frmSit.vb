Imports DevComponents.DotNetBar

Public Class frmSit

    Private Sub frmSit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select situacion.clave as Clave, situacion.situacion as Situación, algoritmos.descrip as Algoritmo, situacion.tipo as Tipo from situacion, algoritmos where situacion.algoritmo=algoritmos.clave")
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        CatControl1.Agregar()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim Clave As String = CatControl1.darSeleccionado("Clave").ToString
        Dim rs As IDataReader = ConsultaSql("Select * from lecturas where sit_med = '" & Clave & "' or sit_hid = '" & Clave & "' or sit_pad = '" & Clave & "' limit 1").ExecuteReader
        If rs.Read Then
            MessageBoxEx.Show("No se puede eliminar la Situacion " & Clave & vbCrLf & "Existen lecturas con esta situación", "Eliminar Situación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            CatControl1.Eliminar()
        End If
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        CatControl1.Imprimir()
    End Sub

    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CatControl1.Visualizar()
    End Sub

    Private Sub btnVisu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisu.Click
        CatControl1.Visualizar()
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub
End Class