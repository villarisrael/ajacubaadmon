Public Class frmdatosccxc
    Public modo As String

    
    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If cmbevento.SelectedIndex = -1 Then
            MsgBox("No has seleccionado el evento")
            cmbevento.Focus()
            Exit Sub
        End If

        If cmbmomento.SelectedIndex = -1 Then
            MsgBox("No has seleccionado el momento en el que se aplica")
            cmbmomento.Focus()
            Exit Sub
        End If

        If cmbtipo.SelectedIndex = -1 Then
            MsgBox("No has seleccionado un tipo de movimiento")
            cmbtipo.Focus()
            Exit Sub
        End If

        If modo = "Nuevo" Then
            Dim estalallave As String
            estalallave = obtenerCampo("select * from conceptoscxc where id_concepto='" & txtclave.Text & "'", "id_concepto")
            If estalallave = "0" Then
                Dim cadenainsert As String
                cadenainsert = "insert into conceptoscxc(id_concepto,descripcion,tipo,monto_inicial,sistema,momento,evento) values "
                cadenainsert += "('" & txtclave.Text & "','" & txtdescripcion.Text & "','" & cmbtipo.Text & "'," & IntegerInput1.Value & "," & chksistema.Checked & ",'" & cmbmomento.Text & "','" & cmbevento.Text & "')"
                Ejecucion(cadenainsert)

            Else
                MsgBox("La clave ya esta dada de alta")
            End If
        End If
        If modo = "Modificar" Then
            Dim cadenainsert As String
            cadenainsert = "update conceptoscxc set descripcion='" & txtdescripcion.Text & "',tipo='" & cmbtipo.Text & "',monto_inicial=" & IntegerInput1.Value & ",sistema =" & chksistema.Checked & ",momento='" & cmbmomento.Text & "' ,evento='" & cmbevento.Text & "' where id_concepto='" & txtclave.Text & "'"
            Ejecucion(cadenainsert)

        End If
        Close()
    End Sub

    Private Sub frmdatosccxc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If modo = "Modificar" Then
            txtclave.Enabled = False
        End If
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Close()
    End Sub
End Class