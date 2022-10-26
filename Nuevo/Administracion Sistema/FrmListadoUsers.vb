Imports DevComponents.DotNetBar

Public Class FrmListadoUsers



    Private Sub FrmListadoUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hacer()

        'Actualizar()
    End Sub
    'Public Sub Actualizar()
    '    Dim ir As IDataReader = ConsultaSql("Select ccodusuario, nombre, user from tmpl").ExecuteReader
    '    DGUsers.Rows.Clear()
    '    Dim Nom As String, User As String, Enc As New Encriptar
    '    Do While ir.Read
    '        Enc.Palabra = ir("nombre")
    '        Nom = Enc.Desencriptada
    '        Enc.Palabra = ir("user")
    '        User = Enc.Desencriptada
    '        DGUsers.Rows.Add(ir("ccodusuario"), Nom, User)
    '    Loop
    'End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim frm As New FrmAgrUser
        frm.Modo = FrmAgrUser.Tipo.Nuevo
        frm.ShowDialog()
        hacer()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim frm As New FrmAgrUser
        frm.Modo = FrmAgrUser.Tipo.Edicion
        frm.Numero = CatControl1.darSeleccionado("ccodusuario")
        frm.ShowDialog()
        hacer()
    End Sub

    Private Sub BtnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualizar.Click
        Dim frm As New FrmAgrUser
        frm.Modo = FrmAgrUser.Tipo.Vizualizar
        frm.Numero = CatControl1.darSeleccionado("ccodusuario")
        frm.ShowDialog()
    End Sub

    Private Sub cmdact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdact.Click
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frm As New frmReporte(frmReporte.Lista.UsuSis, "")
        frm.MdiParent = MDIPrincipal
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If MessageBoxEx.Show("¿Desea eliminar el usuario del sistema con nombre : " & CatControl1.darSeleccionado("nombre") & "?", "Usuarios del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Ejecucion("delete from letras where ccodusuario=" & CatControl1.darSeleccionado("ccodusuario") & "")
        Ejecucion("delete from tmpl where ccodusuario=" & CatControl1.darSeleccionado("ccodusuario") & "")
        CatControl1.Actualizar()
    End Sub
    Private Sub hacer()
        Dim idtem As IDataReader = Nothing
        Ejecucion("delete from tmpl")
        Ejecucion("insert into tmpl (ccodusuario,nombre,user) select ccodusuario, nombre,pwd from letras order by nombre")
        Dim obj As New Encriptar
        idtem = ConsultaSql("select ccodusuario,nombre, user from tmpL").ExecuteReader()
        While idtem.Read()
            obj.palabra = idtem("user")

            Ejecucion("update tmpL set user='" & obj.Desencriptada() & "' where ccodusuario='" & idtem("ccodusuario") & "'")
            'obj.Palabra = idtem("user")
            'obj.Desencriptar()
            'Ejecucion("update tmpL set user='" & obj.Desencriptada & "' where ccodusuario='" & idtem("ccodusuario") & "'")

        End While
        CatControl1.filtrar("select ccodusuario, nombre,user from tmpl order by ccodusuario")
    End Sub

End Class