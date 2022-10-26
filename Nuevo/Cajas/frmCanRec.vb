Public Class frmCanRec
    Dim Tipo_Caja As String
    Dim _Caja, _Oficina, _Serie As String
    Public Property Serie() As String
        Get
            Return _Serie
        End Get
        Set(ByVal value As String)
            _Serie = value
        End Set
    End Property
    Public Property Caja() As String
        Get
            Return _Caja
        End Get
        Set(ByVal value As String)
            _Caja = value
        End Set
    End Property
    Public Property Oficina() As String
        Get
            Return _Oficina
        End Get
        Set(ByVal value As String)
            _Oficina = value
        End Set
    End Property

    Public Sub New(ByVal ofi As String, ByVal caj As String, ByVal seri As Char, ByVal Fecha As Date)
        InitializeComponent()
        _Oficina = ofi
        _Caja = caj
        _Serie = seri
        LblCaja.Text = obtenerCampo("Select descripcion from cajas where id_caja = '" & _Caja & "' and cod_ofi = '" & _Oficina & "'", "descripcion")
        LblOficina.Text = obtenerCampo("Select nombre from oficinas where cod_ofi = '" & _Oficina & "'", "nombre")
        txtSerie.Text = _Serie
        Tipo_Caja = obtenerCampo("Select Tcaja from croape WHERE cod_ofi='" & ofi & "' and caja='" & caj & "' and maquina = '" & My.Computer.Name & "' and fec_ape = '" & UnixDateFormat(Fecha) & "' ", "Tcaja")
    End Sub
    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim linea As Double = 0, leidos As Double = 0
        Dim caden As String = ""
        'Try
        Dim tip As String, Anticipo As Double, Cuenta As Double, Comunidad As String
        Dim TotCon As Double, Exotro As Boolean = False

        If txtRec.Text = "" Then
            MessageBoxEx.Show("Escriba el número del folio del recibo, porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            linea = 49
            Dim idusu As IDataReader = ConsultaSql("select Pagos, Rezagos, recargos, alcantarillado, saneamiento, Cancelado, Tipo, Anticipo, Cuenta, id_Comunidad  from pagos where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "'").ExecuteReader()
            linea = 1
            If idusu.Read() Then
                linea = 53
                If idusu("Cancelado").ToString.ToUpper = "C" Then
                    MessageBoxEx.Show("El recibo que escribio ya está cancelado, verifique sus datos", "Cancelación de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                linea = 58
                Cuenta = idusu("Cuenta")
                linea = 59
                Comunidad = idusu("id_comunidad")
                linea = 60
                tip = idusu("tipo")
                linea = 61
                Anticipo = idusu("anticipo")
                linea = 62
                TotCon = idusu("Rezagos") + idusu("pagos") + idusu("recargos") + idusu("alcantarillado") + idusu("saneamiento")
            Else
                MessageBoxEx.Show("El recibo que escribio no se encuentra, verifique sus datos", "Cancelación de Recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        linea = 73
        If TxtMotivo.Text = "" Then
            MessageBoxEx.Show("No ha escrito el motivo por el cual se cancelara la factura", "Recibos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TxtMotivo.Select()
            Exit Sub
        End If
        linea = 74
        If MessageBoxEx.Show("¿Desea cancelar el recibo " & txtRec.Text & " con la serie " & txtSerie.Text & " especificado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            linea = 75
            cmdAcept.Enabled = False
            cmdCan.Enabled = False
            TxtMotivo.Enabled = False
            linea = 85
            Ejecucion("update pagos set cancelado='C', Can_usu = " & NumUser & ", Can_Fec = curdate(), Can_Hora = curtime(), can_motivo = '" & TxtMotivo.Text & "' where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")

            Dim anno As String = Mid(Convert.ToString(Now()), 7, 4)
            'Ejecucion("update otrosconceptos set estado='Cancelado' where folio='2012A" & txtRec.Text & txtSerie.Text & "' and concepto='Anticipo'")
            Ejecucion("update otrosconceptos set estado='Cancelado' where folio='" & anno & "A" & txtRec.Text & txtSerie.Text & "' and concepto='Anticipo'")
            Ejecucion("update estados set pagado=0 where factura = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
            If Tipo_Caja = "Remota" Then
                GuardarTxt("update pagos set cancelado='C', Can_usu = " & NumUser & ", Can_Fec = curdate(), Can_Hora = curtime(), can_motivo = '" & TxtMotivo.Text & "' where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")
            End If
            linea = 90
            Select Case tip
                Case "Usuarios"
                    linea = 92
                    'If Anticipo > 0 Then
                    'Ejecucion("update otrosconceptos set estado = 'Cancelado' where cuenta = " & Cuenta & "  and id_comunidad = '" & Comunidad & "' and concepto = 'Anticipo' and estado = 'Pendiente' ")
                    'Ejecucion("update anticipos set status = 'C' where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt("update otrosconceptos set estado = 'Cancelado' where cuenta = " & Cuenta & "  and id_comunidad = '" & Comunidad & "' and concepto = 'Anticipo' and estado = 'Pendiente' ")
                    'GuardarTxt("update anticipos set status = 'C' where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")
                    'End If
                    'End If
                    'If TotCon > 0 Then
                    'Ejecucion("update estados set pagado=false where factura=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt("update estados set pagado=false where factura=" & txtRec.Text & " and serie='" & txtSerie.Text & "'")
                    'End If
                    'End If
                    linea = 108
                    On Error Resume Next

                    Dim otros As IDataReader = ConsultaSql("Select * from pagotros where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'").ExecuteReader
                    caden = "Select * from pagotros where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'"
                    linea = 110
                    leidos = otros.RecordsAffected
                    Do While otros.Read
                        Exotro = True
                        linea = 114
                        If otros("tipo_mov") = "Abono" Then
                            linea = 112
                            Ejecucion("update otrosconceptos set estado = 'Pendiente', pagado = 0, resta = resta + " & CDbl(otros("Subtotal") + otros("IVA")) & ", abonos = abonos - " & CDbl(otros("total")) & " where clave = " & otros("id_concepto") & " ")
                            If Tipo_Caja = "Remota" Then
                                GuardarTxt("update otrosconceptos set pagado = false, resta = resta + " & CDbl(otros("Subtotal") + otros("IVA")) & ", abonos = abonos - " & CDbl(otros("total")) & " where clave = " & otros("id_concepto") & " ")
                            End If
                        Else
                            linea = 122
                            If otros("Concepto").ToString.Trim = "ANTICIPO DE CONVENIO" Then
                                Dim NumCon As String = obtenerCampo("Select no_convenio from convenios where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "' and status = 'Activo'", "No_Convenio")
                                linea = 122
                                Ejecucion("update convenios set Status = 'Pendiente'  where no_convenio = '" & NumCon & "' ")
                                linea = 123
                                Ejecucion("update usuario set convenio = 1 where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'")
                                linea = 125
                                Ejecucion("update otrosconceptos set Estado = 'Cancelado' where Concepto = '" & NumCon & "' ")
                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("update convenios set Status = 'Pendiente'  where no_convenio = '" & NumCon & "' ")
                                    GuardarTxt("update usuario set convenio = 1 where cuenta = " & Cuenta & " and id_comunidad = '" & Comunidad & "'")
                                    GuardarTxt("update otrosconceptos set Estado = 'Cancelado' where no_convenio = '" & NumCon & "' ")
                                End If
                            End If

                            If otros("numconcepto").ToString.Trim = "023CCA" Then
                                linea = 139
                                Ejecucion("update otrosconceptos set pagado = TRUE where folio='" & String.Concat(Year(otros("fecha")), otros("serie"), otros("recibo")) & "'")

                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("update otrosconceptos set pagado = TRUE where folio='" & String.Concat(Year(otros("fecha")), otros("serie"), otros("recibo")) & "'")
                                End If
                            Else
                                linea = 146
                                Ejecucion("update otrosconceptos set estado = 'Pendiente', pagado = false, subtotresta = subtotresta + " & otros("Subtotal") & ", ivaresta = ivaresta + " & otros("IVA") & ",  resta = resta + " & CDbl(otros("Subtotal") + otros("IVA")) & ", abonos = abonos - " & CDbl(otros("total")) & " where clave = '" & otros("id_concepto") & "' ")
                                If Tipo_Caja = "Remota" Then
                                    GuardarTxt("update otrosconceptos set pagado = false, subtotresta = subtotresta + " & otros("Subtotal") & ", ivaresta = ivaresta + " & otros("IVA") & ",  resta = resta + " & CDbl(otros("Subtotal") + otros("IVA")) & ", abonos = abonos - " & CDbl(otros("total")) & " where clave = " & otros("id_concepto") & " ")
                                End If
                            End If

                        End If
                    Loop
                    'If Exotro Then
                    'Ejecucion("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'End If
                    'End If
                Case "Factibilidad"
                    'Ejecucion("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'End If
                    'Actualizar la factibilidad si ya pago 
                    Ejecucion("update solicitud set estadosolicitud = 'PENDIENTE', pagfac = 'n' where numero = " & Cuenta & "")
                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("update solicitud set estado = 'PENDIENTE', pagfac = 'n' where numero = " & Cuenta & "")
                    End If
                Case "NoUsuario"
                    'Ejecucion("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'If Tipo_Caja = "Remota" Then
                    'GuardarTxt("Update pagotros set cancelado = 'C' where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'")
                    'End If
                    Dim otros As IDataReader = ConsultaSql("Select * from pagotros where recibo = " & txtRec.Text & " and serie = '" & txtSerie.Text & "'").ExecuteReader
                    Do While otros.Read
                        Ejecucion("insert into conceptosnousuario (nousuario, concepto, subtotal, iva, total) values (" & otros("CUENTA") & ", '" & otros("CONCEPTO") & "', " & otros("SUBTOTAL") & ", " & otros("IVA") & ", " & otros("TOTAL") & ")")
                        If Tipo_Caja = "Remota" Then
                            GuardarTxt("insert into conceptosnousuario (nousuario, concepto, subtotal, iva, total) values (" & otros("CUENTA") & ", '" & otros("CONCEPTO") & "', " & otros("SUBTOTAL") & ", " & otros("IVA") & ", " & otros("TOTAL") & ")")
                        End If
                    Loop
                    Ejecucion("update nousuarios set activo = 1 where clave = " & Cuenta & "")
                    If Tipo_Caja = "Remota" Then
                        GuardarTxt("update nousuarios set activo = 1 where clave = " & Cuenta & "")
                    End If
            End Select
            MessageBoxEx.Show("El recibo se ha cancelado satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If

        'Catch ex As Exception
        '   MessageBoxEx.Show(ex.Message() & " en la línea" & linea & " leidos: " & leidos & " Cadena: " & caden, "Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try

    End Sub
    Private Sub cmdCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCan.Click
        Me.Close()
    End Sub
    Private Sub txtRec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRec.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRec_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRec.LostFocus
        lblNombre.Text = ""
        LblEstado.BackColor = Color.Transparent
        LblEstado.ForeColor = Color.White
        LblEstado.Text = ""
        cmdAcept.Enabled = False
        LblSubtotal.Text = FormatCurrency(0, 2)
        LblIva.Text = FormatCurrency(0, 2)
        lblMonto.Text = FormatCurrency(0, 2)
        LblTarifa.Text = ""
        LblFpago.Text = ""
        LblReferencia.Text = ""

        If txtRec.Text <> "" Then
            Dim idusu As IDataReader = ConsultaSql("select nombre, total, Cancelado, subtotal, iva, Tarifa, ccodpago, referencia from pagos where recibo=" & txtRec.Text & " and serie='" & txtSerie.Text & "' and cod_ofi='" & _Oficina & "' and id_caja='" & _Caja & "'").ExecuteReader()
            If idusu.Read() Then
                lblNombre.Text = idusu("nombre")
                If idusu("Cancelado") = "C" Then
                    LblEstado.BackColor = Color.Red
                    LblEstado.ForeColor = Color.White
                    LblEstado.Text = "CANCELADO"
                    cmdAcept.Enabled = False
                Else
                    LblEstado.BackColor = Color.Green
                    LblEstado.ForeColor = Color.White
                    LblEstado.Text = "ACTIVO"
                    cmdAcept.Enabled = True
                End If
                LblSubtotal.Text = FormatCurrency(idusu("subtotal"), 2)
                LblIva.Text = FormatCurrency(idusu("IVA"), 2)
                lblMonto.Text = FormatCurrency(idusu("total"), 2)

                LblTarifa.Text = obtenerCampo("Select descripcion_cuota from cuotas where id_tarifa = '" & idusu("Tarifa") & "'", "descripcion_cuota")
                LblFpago.Text = obtenerCampo("Select cdespago from fpago where ccodpago ='" & idusu("ccodPago") & "'", "cdespago")
                LblReferencia.Text = idusu("Referencia")
            Else
                cmdAcept.Enabled = False
                MessageBoxEx.Show("El folio de la factura no fue localizado, verifique su informacion", "Cancelacion de recibos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            cmdAcept.Enabled = False
        End If
    End Sub

    Private Sub frmCanRec_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyData = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmCanRec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRec.Select()
    End Sub
End Class