Public Class frmcambicontrasena
    Private Sub frmcambicontraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse
       String.IsNullOrWhiteSpace(txtpasactual.Text) OrElse
       String.IsNullOrWhiteSpace(txtpassnue.Text) OrElse
       String.IsNullOrWhiteSpace(txtpassconfirmacion.Text) Then
            MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validar contraseñas coincidentes
        If txtpassnue.Text <> txtpassconfirmacion.Text Then
            MessageBox.Show("La nueva contraseña y la confirmación no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Validar longitud mínima de contraseña
        If txtpassnue.Text.Length < 6 Then
            MessageBox.Show("La nueva contraseña debe tener al menos 6 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        Dim enc As New Encriptar, Usu As String, Pwd As String, Pwdnuevo As String
        enc.palabra = txtusername.Text
        Usu = enc.Encriptada
        enc.palabra = txtpasactual.Text
        Pwd = enc.Encriptada
        enc.palabra = txtpassnue.Text
        Pwdnuevo = enc.Encriptada


        Dim ir As IDataReader
        Dim comando As Odbc.OdbcCommand

        comando = ConsultaSql("Select * from letras where user = '" & Usu & "' and letra = '" & Pwd & "'")
        ir = comando.ExecuteReader
        If ir.Read() Then

            If ir("status") = False Then
                MessageBox.Show("USUARIO NO PUEDE CAMBIAR SU CONTRASEÑA, ESTA DESHABILITADO")
                Exit Sub
            End If

        Else
            MessageBox.Show("EL USUARIO Y CONTRASEÑA NO CONCIDEN")
            Exit Sub
        End If




        Ejecucion("update letras set letra='" & Pwdnuevo & "' where user='" & Usu & "'")
        Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub
End Class