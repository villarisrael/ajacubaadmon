Public Class FrmListadoNoUsuario
    Private idletra As IDataReader = Nothing
    Private Sub FrmListadoNoUsuario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabcobros.Select()
    End Sub

    Private Sub FrmListadoNoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idletra = ConsultaSql("select * from letras where ccodusuario=" & NumUser & "").ExecuteReader()
        idletra.Read()
        'If CBool(idletra("agrnopadron")) Then cmdAgregar.Visible = True Else cmdAgregar.Visible = False
        'If CBool(idletra("editaopadron")) Then cmdEditar.Visible = True Else cmdEditar.Visible = False

        CatControl1.filtrar("Select Clave, Nombre, Comunidad, Colonia, Direccion, NumExt, NumInt, Telefono from nousuarios order by Clave")
    End Sub



    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        CatControl1.Editar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub BtnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualizar.Click
        CatControl1.Visualizar()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        CatControl1.Agregar()
    End Sub
End Class