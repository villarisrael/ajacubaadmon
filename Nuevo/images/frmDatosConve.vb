Public Class frmDatosConvenio

    Dim datos As New ClassConectar
    Dim idUsuario As IDataReader, idotrosConce As IDataReader
    Dim s As Object, e As System.EventArgs
    Dim pDescuento As Double
    Dim qDescuenta As String, motivo As String
    Dim consuOtr As String

    Private Sub buscarUsu(ByVal cuenta As Double)
        Dim i As Int16
        Dim conce As String
        idUsuario = datos.ConsultaSql("select usuario.cuenta,usuario.nombre, usuario.direccion, comunidades.comunidad, colonia.colonia, municipios.nombre,cuotas.descripcion_cuota,usuario.tarifa,usuario.derivacion,usuario.descu, usuario.deudafec, usuario.tarifa, usuario.nombrequedesc from usuario, comunidades, municipios,colonia, cuotas where usuario.numcomu=comunidades.numero_comunidad and usuario.nmunicipio=municipios.clave and usuario.ncolonia=colonia.numero and usuario.tarifa=cuotas.numero and usuario.cuenta=" & cuenta & "").ExecuteReader()

        If idUsuario.Read() Then
            txtCuenta.Text = idUsuario("cuenta").ToString
            txtNombre.Text = idUsuario("nombre").ToString
            txtDir.Text = String.Concat(idUsuario("direccion").ToString, " COMUNIDAD: ", idUsuario("comunidad"), " COLONIA: ", idUsuario("colonia"))
            txtTarifa.Text = idUsuario("descripcion_cuota")
            txtfecpag.Text = UCase(MonthName(Month(idUsuario("deudafec")), True)) & " - " & Year(idUsuario("deudafec"))
            idotrosConce = datos.ConsultaSql("select * from otrosconceptos where cuenta=" & txtCuenta.Text & "").ExecuteReader()
            If idotrosConce.Read() Then
                conce = String.Concat(idotrosConce("concepto"), " Documento: ", idotrosConce("folio"))
                For i = 1 To idotrosConce.RecordsAffected
                    dgConceptos.Rows.Add(" ", conce, 1, idotrosConce("monto"))
                Next

            End If
        End If

    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        limpiaControles()
        buscarUsu(CDbl(txtCuenta.Text))
        cmdCalcular_Click(s, e)
    End Sub


    Private Sub txtCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCuenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If KeyAscii = 13 Then
            cmdBuscar_Click(s, e)
        End If
    End Sub
    Private Sub cmdCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCalcular.Click

        Dim i As Int16

        consuOtr = 0
        If dgConceptos.RowCount > 1 And Chkotros.Checked = True Then
            For i = 0 To dgConceptos.RowCount - 1
                consuOtr += dgConceptos.Item(3, i).Value
            Next
        End If
        If txtNombre.Text <> "" Then
            Dim pago As New ClasePago(CLng(txtCuenta.Text), CInt(idUsuario("derivacion")), pDescuento, idUsuario("deudafec"), Me.dtFecha.Value, CShort(idUsuario("tarifa")), CBool(ChkReza.Checked), CBool(Chkconsu.Checked), CBool(ChkAlca.Checked), CBool(ChkReca.Checked), CBool(ChkSanea.Checked), CBool(Checkiva.Checked), consuOtr)
            txtPer.Text = pago.construyePeriodo()
            txtReca.Text = FormatCurrency(pago.mReca, 2)
            txtConsumo.Text = FormatCurrency(pago.mConsumo, 2)
            txtAlcanta.Text = FormatCurrency(pago.mAlcanta, 2)
            txtSaneamiento.Text = FormatCurrency(pago.mSanea, 2)
            txtReza.Text = FormatCurrency(pago.mRezagos, 2)
            txtOtros.Text = FormatCurrency(consuOtr, 2)
            txtSubTot.Text = FormatCurrency(pago.mSubtotal, 2)
            txtIva.Text = FormatCurrency(pago.mIva, 2)
            txtTotal.Text = FormatCurrency(pago.mTotal, 2)

            If Not IsDBNull(idUsuario("descu")) AndAlso idUsuario("descu") <> 0 Then pDescuento = idUsuario("descu") Else pDescuento = 0

            If Not IsDBNull(idUsuario("nombrequedesc")) AndAlso idUsuario("descu") <> 0 Then
                qDescuenta = idUsuario("nombrequedesc")
                lblNomDesc.Text = idUsuario("nombrequedesc")
                Checkdescuento.Checked = True
            Else
                Checkdescuento.Checked = False
                lblNomDesc.Text = ""
                qDescuenta = ""
            End If
        End If

    End Sub

    Private Sub frmDatosConvenkio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkAlca.Checked = True
        Chkconsu.Checked = True
        ChkReca.Checked = True
        ChkReca.Checked = True
        ChkReza.Checked = True
        ChkSanea.Checked = True
        ChkAlca.Checked = True

    End Sub
    Private Sub limpiaControles()
        Dim i As Int16

        Me.txtReca.Text = FormatCurrency("0", 2)
        Me.txtConsumo.Text = FormatCurrency("0", 2)
        Me.txtSaneamiento.Text = FormatCurrency("0", 2)
        Me.txtAlcanta.Text = FormatCurrency("0", 2)
        Me.txtReza.Text = FormatCurrency("0", 2)
        Me.txtOtros.Text = FormatCurrency("0", 2)
        Me.txtDescu.Text = FormatCurrency("0", 2)
        Me.txtSubTot.Text = FormatCurrency("0", 2)
        Me.txtIva.Text = FormatCurrency("0", 2)
        Me.txtTotal.Text = FormatCurrency("0", 2)
        Me.txtNombre.Text = ""

        If dgConceptos.RowCount > 1 Then

            For i = 0 To dgConceptos.Rows.Count - 1
                Try
                    dgConceptos.Rows.RemoveAt(0)
                Catch ex As Exception
                    Exit For
                End Try

            Next
        End If
        'txtCuenta.Text = ""
        dtFecha.Value = Now
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim i As Int16
        Dim obj As New clsConvenios

        If Chkconsu.Checked = True Then
            motivo = "Consumo "
        End If

        If dgConceptos.RowCount > 1 Then
            For i = 0 To dgConceptos.RowCount - 1
                motivo += String.Concat(", ", dgConceptos.Item(1, i).Value)
            Next
        End If

        frmConve.txtNoConvenio.Text = obj.darFolio()
        frmConve.txtCuenta.Text = Me.txtCuenta.Text
        frmConve.txtTarifa.Text = Me.txtTarifa.Text
        frmConve.txtNombre.Text = Me.txtNombre.Text
        frmConve.txtDir.Text = Me.txtDir.Text
        frmConve.txtPeriodo.Text = Me.txtPer.Text
        frmConve.txtMotivo.Text = motivo
        frmConve.descu = pDescuento
        frmConve.bRez = CBool(ChkReza.Checked)
        frmConve.FechaIn = idUsuario("deudafec")
        frmConve.FechaFin = dtFecha.Value
        frmConve.bConsu = CBool(Chkconsu.Checked)
        frmConve.bAlca = CBool(ChkAlca.Checked)
        frmConve.bSane = CBool(ChkSanea.Checked)
        frmConve.bIva = CBool(Checkiva.Checked)
        frmConve.deriv = CInt(idUsuario("derivacion"))
        frmConve.mOtros = consuOtr
        frmConve.txtMonto.Text = FormatCurrency(txtTotal.Text, 2)
        frmConve.txtRestante.Text = FormatCurrency(txtTotal.Text, 2)
        Me.Close()
    End Sub

    Private Sub Chkconsu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chkconsu.CheckedChanged
        If Chkconsu.Checked = True Then
            Me.ChkReza.Checked = True
            Me.ChkSanea.Checked = True
            Me.ChkAlca.Checked = True
            Me.ChkReca.Checked = True
        Else
            Me.ChkReza.Checked = False
            Me.ChkSanea.Checked = False
            Me.ChkAlca.Checked = False
            Me.ChkReca.Checked = False
        End If
        cmdCalcular_Click(s, e)
    End Sub
End Class