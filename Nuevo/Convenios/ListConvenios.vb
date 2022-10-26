Public Class ListConvenios
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        If Not frmConvenio.Created Then
            frmConvenio.Show()
        End If
        frmConvenio.Select()
    End Sub

    Private Sub ListConvenios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datConvenios.Refresh()
        llenargrid()
    End Sub
    Public Sub llenargrid()
        Dim CONSULTA As String
        Try
            CONSULTA = "select e.idencconvenio, idCuenta as Cuenta, Nombre, telefono, e.total as Total, fechasolicitud, pagos, aplazamiento, sum(o.resta) as resta from encConvenio as e inner join otrosconceptos as o on e.idcuenta= o.cuenta group by e.idcuenta"
            llenaGrid(datConvenios, CONSULTA)
            datConvenios.Columns("Cuenta").Width = 70
            datConvenios.Columns("Nombre").Width = 700
            datConvenios.Columns("Telefono").Width = 200
            datConvenios.Columns("Total").Width = 200
            datConvenios.Columns("Pagos").Width = 200
            datConvenios.Columns("Aplazamiento").Width = 200
            datConvenios.Columns("Fechasolicitud").Width = 200
            'datConvenios.Columns("descuento").Width = 200
            datConvenios.Columns("Resta").Width = 200
            datConvenios.AllowUserToAddRows = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdVisualizar_Click(sender As Object, e As EventArgs) Handles cmdVisualizar.Click
        Dim FRMCONTRA = New frmConvenio(frmConvenio._vengode.solicitud)
        Try
            Dim cadenadecarga As String
            Dim consulta As String
            Dim modi As String

            cadenadecarga = "select idcuenta, nombre,telefono, round(total,2) as total, pagos, aplazamiento from encConvenio where  idcuenta =" & datConvenios.CurrentRow.Cells(1).EditedFormattedValue.ToString()
            Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
            dr.Read()

            consulta = "select comunidad,domicilio, colonia, cuentaAnterior from vusuario where  cuenta =" & datConvenios.CurrentRow.Cells(1).EditedFormattedValue.ToString()
            Dim dra As IDataReader = ConsultaSql(consulta).ExecuteReader()
            dra.Read()

            modi = "select round(TotalAnt,2) as TotalAnt, descuento,  round(totalConv,2) as totalConv from convmodif where cuenta =" & datConvenios.CurrentRow.Cells(1).EditedFormattedValue.ToString()
            Dim dr1 As IDataReader = ConsultaSql(modi).ExecuteReader()


            If Not IsDBNull(dr("nombre")) Then
                FRMCONTRA.nombre.Text = dr("nombre")
            Else
                FRMCONTRA.nombre.Text = Nothing

            End If
            If Not IsDBNull(dr("total")) Then
                FRMCONTRA.total.Text = dr("total")
            Else
                FRMCONTRA.total.Text = Nothing

            End If
            If Not IsDBNull(dr("idcuenta")) Then
                FRMCONTRA.cuentatxt.Text = dr("idcuenta")
            Else
                FRMCONTRA.cuentatxt.Text = Nothing

            End If
            If Not IsDBNull(dr("telefono")) Then
                FRMCONTRA.TxtTel.Text = dr("telefono")
            Else
                FRMCONTRA.TxtTel.Text = Nothing

            End If

            If Not IsDBNull(dr("pagos")) Then
                FRMCONTRA.pagos.Text = dr("pagos")
            Else
                FRMCONTRA.pagos.Text = Nothing

            End If
            If Not IsDBNull(dr("aplazamiento")) Then
                FRMCONTRA.fecha.Text = dr("aplazamiento")
            Else
                FRMCONTRA.fecha.Text = Nothing

            End If
            If Not IsDBNull(dra("comunidad")) Then
                FRMCONTRA.Comunidad.Text = dra("comunidad")
            Else
                FRMCONTRA.Comunidad.Text = Nothing

            End If
            If Not IsDBNull(dra("colonia")) Then
                FRMCONTRA.Colonia.Text = dra("colonia")
            Else
                FRMCONTRA.Colonia.Text = Nothing

            End If
            If Not IsDBNull(dra("domicilio")) Then
                FRMCONTRA.Domicilio.Text = dra("domicilio")
            Else
                FRMCONTRA.Domicilio.Text = Nothing

            End If
            If Not IsDBNull(dra("cuentaAnterior")) Then
                FRMCONTRA.cuentaAnte.Text = dra("cuentaAnterior")
            Else
                FRMCONTRA.cuentaAnte.Text = Nothing

            End If


            If dr1.Read() Then
                FRMCONTRA.descuento.Text = dr1("descuento")
                FRMCONTRA.nuevoadeudo.Text = dr1("totalConv")
                FRMCONTRA.Label9.Visible = True
                FRMCONTRA.descuento.Visible = True
                FRMCONTRA.nuevoadeudo.Visible = True
                FRMCONTRA.Label1.Visible = True
                FRMCONTRA.Label3.Visible = True
                FRMCONTRA.total.Text = dr1("totalAnt")
            Else
                FRMCONTRA.descuento.Text = 0
                FRMCONTRA.nuevoadeudo.Text = 0
                FRMCONTRA.Label9.Visible = True
                FRMCONTRA.descuento.Visible = True
                FRMCONTRA.nuevoadeudo.Visible = True
                FRMCONTRA.Label1.Visible = True
                FRMCONTRA.Label3.Visible = True
                FRMCONTRA.total.Text = dr1("totalAnt")
            End If

            FRMCONTRA.ButtonX5.Visible = False
            FRMCONTRA.MdiParent = MDIPrincipal
            FRMCONTRA.mestado = frmConvenio.Estado.Visualizar
            FRMCONTRA.Show()
            FRMCONTRA.WindowState = FormWindowState.Normal
        Catch ex As Exception
            MessageBox.Show(ex.Message & "No has seleccionado un contrato correctamente")
        End Try
    End Sub

    Private Sub btnim_Click(sender As Object, e As EventArgs) Handles btnim.Click
        'Dim ccon = New frmConvenio
        'Dim Frm As New frmReporte(frmReporte.Lista.Convenio, "")
        'Frm.MdiParent = My.Forms.MDIPrincipal
        'Frm.ShowDialog()
        'Frm.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub cmdact_Click(sender As Object, e As EventArgs) Handles cmdact.Click
        llenargrid()
    End Sub
End Class