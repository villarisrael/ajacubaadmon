Imports DevComponents.DotNetBar

Public Class frmsuspendervb
    Public Modo As String = "Suspender"
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If MessageBoxEx.Show("¿Estas seguro de " & Modo & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Modo = "Suspender" Then
                Ejecucion("UPDATE USUARIO SET ESTADO =5 WHERE CUENTA=" & lblcuenta.Text)
            Else
                Ejecucion("UPDATE USUARIO SET ESTADO =1 WHERE CUENTA=" & lblcuenta.Text)
            End If

            frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
            BtnAceptar.Enabled = False
            If Modo = "Suspender" Then


                cmdGenCob.Enabled = True
            End If

            Dim nombre_Host As String = Net.Dns.GetHostName()
            Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString
            Try
                Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Suspender '," & lblcuenta.Text & "," & NumUser & ",'Suspencion del servicio','" & direccion_Ip & "','" & TxtMotivo.Text & "')")

                ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ButtonX1.Enabled = True

                'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                BtnAceptar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
            End Try

        Else

        End If
    End Sub

    Private Sub cmdGenCob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenCob.Click
        Dim frm As New frmagrmov(eve.Reconexion, Val(lblcuenta.Text), lblnombre.Text, lblcomunidad.Text)
        frm.ShowDialog()
        If frm.Cancelado Then
            cmdGenCob.Text = "Cobro generado"
            cmdGenCob.Enabled = False
        End If
    End Sub
End Class