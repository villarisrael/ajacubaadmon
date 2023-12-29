Imports DevComponents.DotNetBar

Public Class Confirmacion
    Dim acceso As frmConvenio = New frmConvenio
    Public usu As String
    Public autorizacion As String = ""

    ' Public c As Integer = Convert.ToInt16(acceso.cuentatxt.Text)
    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim enc As New Encriptar, Pwd As String
        enc.palabra = TxtUsuario.Text
        usu = enc.Encriptada
        enc.palabra = TxtPwd.Text
        Pwd = enc.Encriptada
        Dim ir As IDataReader
        Dim comando As Odbc.OdbcCommand

        comando = ConsultaSql("Select * from letras where user = '" & usu & "' and pwd = '" & Pwd & "'")
        ir = comando.ExecuteReader
        If ir.Read() Then

            If ir("status") = 0 Then
                MessageBox.Show("Ingreso denegado")
                Exit Sub
            End If
            NumAuto = ir("ccodusuario")
            enc.palabra = ir("User")
            NameAuto = enc.Desencriptada

            MsgBox("Tu convenio a sido guardado satisfactoriamente")
            Me.Close()
        Else
            MessageBoxEx.Show("Nombre de usuario o contraseña incorrectas, verifique sus datos", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPwd.Select()
        End If

    End Sub

    Public Sub metodo(cuenta As Integer)
        Try
            Dim cadenauto As String
            cadenauto = "select nombre from letras where ccodusuario =" & NumAuto
            Dim dracc As IDataReader = ConsultaSql(cadenauto).ExecuteReader()

            If dracc.Read() Then
                autorizacion = dracc("Nombre")
                Ejecucion("update ConvModif set autorizacion ='" & autorizacion & "' where cuenta=" & cuenta)
            Else
                MsgBox("No se autorizo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If autorizacion = String.Empty Then
            autorizacion = "cancelar"
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
    Dim Sesion As Boolean
    Private Sub Confirmacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If Sesion = False Then
        '    If MessageBoxEx.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        e.Cancel = False
        '    Else
        '        e.Cancel = True
        '    End If
        'End If
    End Sub
End Class