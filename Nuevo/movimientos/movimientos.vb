Imports DevComponents.DotNetBar

Public Class movimientos
    Public consumo As New consumo
    Public cuota As String
    Public concepto As String
    Public id_comunidad As String
    Public folio_contrato As Double
    Public tipo_movimiento As tipo
    Private _tipoevento As Int16
    Private _fecven As Date
    Private _clave As Double
    Private _Reca As Boolean = False
    Enum tipo_acceso
        Agregar
        Modificar
    End Enum

    Enum tipo
        cargo
        abono
    End Enum

    Public Property tipoevento() As Int16
        Get
            Return _tipoevento
        End Get
        Set(ByVal value As Int16)
            _tipoevento = value
        End Set
    End Property
    Public Property Recargo() As Boolean
        Get
            Return _Reca
        End Get
        Set(ByVal value As Boolean)
            _Reca = value
        End Set
    End Property


#Region "Modificadores"
    Public Property fecven() As Date
        Get
            Return _fecven
        End Get
        Set(ByVal value As Date)
            _fecven = value
        End Set
    End Property

    Public Property clave() As Double
        Get
            Return _clave
        End Get
        Set(ByVal value As Double)
            _clave = value
        End Set
    End Property

#End Region


    Public Sub Modificar(ByVal fecha As Date, ByVal descripcion As String, ByVal monto As Double, ByVal idconcepto As String)
        Dim tabla As String = ""
        Select Case _tipoevento
            Case eve.Multas
                tabla = "MULTA"
        End Select

        Try
            'Verificar esta variable concepto para ver si trae iva o no de la tabla conceptos cxc y se pueda aplicar
            Dim ApIva As Boolean = CBool(obtenerCampo("select aplicaiva from conceptoscxc where id_concepto = '" & idconcepto & "'", "aplicaiva"))
            Dim Iva As Double
            If ApIva = True Then
                Iva = Math.Round(monto * VARIABLE_IVA, 2)
            Else
                Iva = 0
            End If
            ' tabla='" & tabla & "'
            Dim recargootro As Double = 0
            If _Reca Then
                recargootro = Val(obtenerCampo("select porrec from empresa", "porrec"))
            Else
                recargootro = 0
            End If



            Ejecucion("update otrosconceptos set id_concepto='" & idconcepto & "', PorcRec=" & recargootro & ", cuenta=" & folio_contrato & ", id_comunidad='" & id_comunidad & "', concepto='" & concepto & "', subtotal=" & monto & ", iva=" & Iva & ",total=" & monto + Iva & ", SUBTOTRESTA = " & monto & ", IVARESTA = " & Iva & ", vencimiento='" & UnixDateFormat(_fecven) & "', folio='" & idconcepto & "', motivo='" & descripcion & "', fecha_ult_camb='" & UnixDateFormat(Now) & "', usuariocambio='" & NumUser & "', MES_PERIODO = '" & UCase(MonthName(Month(fecha), True)) & "', AN_PER = " & Year(fecha) & ", fec_apli='" & UnixDateFormat(fecha) & "', resta=" & monto + Iva & " where clave=" & _clave & "")
        Catch ex As Exception

        End Try
    End Sub

    Public Sub cargo(ByVal fecha As Date, ByVal Descripcion As String, ByVal monto As Double, ByVal idconcepto As String)
        Dim tabla As String = ""
        Dim saldoanterior As Double = obtenerCampo("select saldo from usuario where id_comunidad='" & id_comunidad & "' and cuenta=" & folio_contrato, "saldo")
        Dim saldoactual = saldoanterior + monto
        'cuota = obtenerCampo("select tarifa from usuario where id_comunidad='" & id_comunidad & "' and cuenta=" & folio_contrato, "tarifa")
        Dim bcont As Boolean, Rec As Integer
        If _Reca Then
            Rec = PORC_RECA_OTRO
        Else
            Rec = 0
        End If
        If folio_contrato = 0 Then
            MessageBoxEx.Show("Falta Especificar la Cuenta, Cargo no guardado", "Agregar Cargos", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        Select Case _tipoevento
            Case eve.Multas
                tabla = "MULTA"
            Case Else
                Dim evetem As eve = _tipoevento
                tabla = evetem.ToString
        End Select
        'Dim Clav As Double = Val(obtenerCampo("Select max(clave) as cla from otrosconceptos", "cla")) + 1

        'Verificar esta variable concepto para ver si trae iva o no de la tabla conceptos cxc y se pueda aplicar
        Dim ApIva As Boolean = CBool(obtenerCampo("select aplicaiva from conceptoscxc where id_concepto = '" & idconcepto & "'", "aplicaiva"))
        Dim Iva As Double
        If ApIva = True Then
            Iva = Math.Round(monto * (VARIABLE_IVA / 100), 2)
        Else
            Iva = 0
        End If
        Try
            If _tipoevento <> eve.Contratos Then
                Ejecucion("insert into otrosconceptos( cuenta,concepto,subtotal,iva,total,pagado,vencimiento,tabla,folio,estado,motivo,fec_alta,usuarioalta,resta,id_comunidad,tipo_mov,MES_PERIODO,AN_PER, SUBTOTRESTA, IVARESTA,fec_apli, PorcRec,id_concepto) values(" & folio_contrato & ",'" & concepto & "'," & monto & "," & Iva & "," & (monto + Iva) & ",FALSE,'" & UnixDateFormat(_fecven) & "','" & tabla & "','" & idconcepto & "','Pendiente','" & Descripcion & "','" & UnixDateFormat(Now) & "','" & NumUser & "'," & (monto + Iva) & ",'" & id_comunidad & "','Cargo','" & UCase(MonthName(Month(fecha), True)) & "'," & Year(fecha) & "," & monto & "," & Iva & ",'" & UnixDateFormat(fecha) & "', " & Rec & ",'" & idconcepto & "')")
            Else
                bcont = obtenerCampo("select cargoContrato from usuario where cuenta=" & folio_contrato, "cargocontrato")
                If bcont = True Then
                    DevComponents.DotNetBar.MessageBoxEx.Show("El usuario ya tiene un cargo por contrato", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                Else
                    Ejecucion("insert into otrosconceptos(cuenta,concepto,subtotal,iva,total,pagado,vencimiento,tabla,folio,estado,motivo,fec_alta,usuarioalta,resta,id_comunidad,tipo_mov,MES_PERIODO,AN_PER, SUBTOTRESTA, IVARESTA, fec_apli, PorcRec,id_concepto) values(" & folio_contrato & ",'" & concepto & "'," & monto & "," & Iva & "," & (monto + Iva) & ",FALSE,'" & UnixDateFormat(_fecven) & "','" & tabla & "','" & idconcepto & "','Pendiente','" & Descripcion & "','" & UnixDateFormat(Now) & "','" & NumUser & "'," & (monto + Iva) & ",'" & id_comunidad & "','Cargo','" & UCase(MonthName(Month(fecha), True)) & "'," & Year(fecha) & "," & monto & "," & Iva & ",'" & UnixDateFormat(fecha) & "', " & Rec & ",'" & idconcepto & "')")
                    Ejecucion("update usuario set cargoContrato=True where cuenta=" & folio_contrato)
                End If
            End If
        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub


    Public Sub add(ByVal monto As Double, ByVal detalle As String, ByVal idcon As String, ByVal fec As Date, ByVal acceso As tipo_acceso, Optional ByVal Rec As Boolean = False)
        _Reca = Rec
        Dim rs As IDataReader
        rs = ConsultaSql("select * from conceptoscxc where id_concepto='" & idcon & "'").ExecuteReader
        If rs.Read() Then

            concepto = rs("descripcion")

            tipo_movimiento = tipo.cargo

        Else
            MessageBox.Show("Los cambios no podrán ser guardados correctamente, verifique el id del concepto", "Cargos y abonos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If acceso = tipo_acceso.Agregar Then

            Me.cargo(fec, detalle, monto, idcon)

        Else
            Modificar(fec, detalle, monto, idcon)
        End If
    End Sub

End Class

Public Class consumo
    Public servicio As Double
    Public recargo As Double
    Public rezago As Double
    Public saneamiento As Double
    Public alcantarillado As Double
    Public subtotal As Double
    Public iva As Double
    Public total As Double
    Public cobrariva As Double


    Public Sub suma()
        'subtotal = Math.Round(servicio + recargo + rezago + alcantarillado + saneamiento, 2)
        If cobrariva = True Then
            iva = Math.Round(subtotal * 0.16, 2)
        Else
            iva = 0
        End If
        total = subtotal + iva
    End Sub

End Class

Class conceptocxc

    Public evento As eve

    Function conceptos(ByVal evento As eve) As IDataReader
        'Dim CLC As New ClassConectar
        Dim CM As Odbc.OdbcCommand

        If evento <> eve.Todos Then
            CM = ConsultaSql("select * from conceptoscxc where obsoleto=0 and evento='" & conce(evento) & "' ORDER BY DESCRIPCION")
        Else
            CM = ConsultaSql("select * from conceptoscxc where obsoleto=0 ORDER BY DESCRIPCION")
        End If

        conceptos = CM.ExecuteReader

    End Function

    Public Function conce(ByVal evento As eve) As String
        Select Case evento
            Case eve.Ajustes
                Return "Ajustes"
            Case eve.Cierre
                Return "Cierre"
            Case eve.Contratos
                Return "Contratos"
            Case eve.Corte
                Return "Corte"
            Case eve.Factibilidad
                Return "Factibilidad"
            Case eve.Lecturas
                Return "Lecturas"
            Case eve.Mantenimiento
                Return "Mantenimiento"
            Case eve.Multas
                Return "Multas"
            Case eve.Notas
                Return "Notas"
            Case eve.CambioNombre
                Return "CamNom"
            Case eve.CambioTarifa
                Return "CamTar"
            Case eve.CambioMedidor
                Return "CamMed"
            Case eve.Reconexion
                Return "Reconexion"
            Case Else
                Return "Todos"
        End Select
    End Function
End Class