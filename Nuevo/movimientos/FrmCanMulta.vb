Imports DevComponents.DotNetBar

Public Class FrmCanMulta
    Public Clave As Double

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtdetalle.Text = "" Then
            MessageBoxEx.Show("Falta introducir el motivo de la cancelación", "Cancelar Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtdetalle.Select()
            Exit Sub
        End If
        If MessageBoxEx.Show("¿Desea cancelar el cargo : " & Clave & "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim est As String = obtenerCampo("Select estado from otrosconceptos where clave = " & Clave & "", "Estado")
            Select Case est
                Case "Cancelado", "Aplicado"
                    MessageBoxEx.Show("La multa : " & Clave & " no se puede cancelar debido a que su estado es " & est & "", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "Pendiente"
                    Ejecucion("update otrosconceptos set estado='Cancelado', UsuarioBaja = " & NumUser & ", fecha_baja = curdate(), observa = '" & txtdetalle.Text & "' where clave=" & Clave & "")
                Case "Abonado"
                    MessageBoxEx.Show("No se puede cancelar este cargo por que ya se hizo un abono", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
            frmListMultas.CatControl1.Actualizar()
            Close()
        End If
    End Sub

    Private Sub FrmCanMulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim idotr As IDataReader = ConsultaSql("select * from otrosconceptos as o, vusuario as v where clave=" & Clave & " and v.cuenta = o.cuenta ").ExecuteReader()
        idotr.Read()
        LBLNOMBRE.Text = idotr("nombre")
        LblCuenCom.Text = idotr("cuenta") & " " & idotr("comunidad")
        LblFecha.Text = idotr("fec_alta")
        LblDireccion.Text = idotr("Direccion")
        LblConcepto.Text = idotr("concepto")
        LblVencimiento.Text = idotr("vencimiento")
        LblMotivo.Text = idotr("motivo")

        LblSubtotal.Text = FormatCurrency(idotr("Subtotal"), 2)
        LblIva.Text = FormatCurrency(idotr("Iva"), 2)
        LblTotal.Text = FormatCurrency(idotr("subtotal") + idotr("iva"), 2)

    End Sub
End Class