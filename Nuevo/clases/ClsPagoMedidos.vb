Public Class ClsPagoMedidos
#Region "Variables"
    Private _Cuenta As Double
    Private _Comunidad As String

    Private _UsoAlcantarillado As Boolean
    Private _UsoSaneamiento As Boolean

    Private _Consumo As Double
    Private _Recargo As Double
    Private _Alcantarillado As Double
    Private _Saneamiento As Double
    Private _Subtotal As Double
    Private _IVA As Double
    Private _Total As Double

    Private Tarifa As String

#End Region
#Region "Modificadores de acceso"
    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
        End Set
    End Property
    Public Property Comunidad() As String
        Get
            Return _Comunidad
        End Get
        Set(ByVal value As String)
            _Comunidad = value
        End Set
    End Property
    Public Property Consumo() As Double
        Get
            Return _Consumo
        End Get
        Set(ByVal value As Double)
            _Consumo = value
        End Set
    End Property
    Public Property Recargo() As Double
        Get
            Return _Recargo
        End Get
        Set(ByVal value As Double)
            _Recargo = value
        End Set
    End Property
    Public Property Alcantarillado() As Double
        Get
            Return _Alcantarillado
        End Get
        Set(ByVal value As Double)
            _Alcantarillado = value
        End Set
    End Property
    Public Property Saneamiento() As Double
        Get
            Return _Saneamiento
        End Get
        Set(ByVal value As Double)
            _Saneamiento = value
        End Set
    End Property
    Public Property Subtotal() As Double
        Get
            Return _Subtotal
        End Get
        Set(ByVal value As Double)
            _Subtotal = value
        End Set
    End Property
    Public Property IVA() As Double
        Get
            Return _IVA
        End Get
        Set(ByVal value As Double)
            _IVA = value
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return _Total
        End Get
        Set(ByVal value As Double)
            _Total = value
        End Set
    End Property
    Public Property UsoAlcantarillado() As Boolean
        Get
            Return _UsoAlcantarillado
        End Get
        Set(ByVal value As Boolean)
            _UsoAlcantarillado = value
        End Set
    End Property
    Public Property UsoSaneamiento() As Boolean
        Get
            Return _UsoSaneamiento
        End Get
        Set(ByVal value As Boolean)
            _UsoSaneamiento = value
        End Set
    End Property
#End Region

    Public Sub SacarTotal()
        Dim Tar As IDataReader

        Tarifa = obtenerCampo("select tarifa from usuario where cuenta = " & _Cuenta & " and id_comunidad = '" & _Comunidad & "'", "tarifa")
        Tar = ConsultaSql("Select * from cuotas where id_tarifa = '" & Tarifa & "'").ExecuteReader
        Tar.Read()
        _Consumo = DeudaMedidos()
        If Tar("recargos") = True Then
            _Recargo = RecargoMedidos()
        Else
            _Recargo = 0
        End If
        If Tar("Alcantarillado") = True Then
            If _UsoAlcantarillado = True Then
                _Alcantarillado = AlcantarilladoMedidos()
            Else
                _Alcantarillado = 0
            End If
        End If
        If Tar("Saneacuo") = True Then
            If _UsoSaneamiento = True Then
                _Saneamiento = SaneamientoMedidos()
            Else
                _Saneamiento = 0
            End If
        Else
            _Saneamiento = 0
        End If

        _Subtotal = _Consumo + _Recargo + _Alcantarillado + _Saneamiento

        If Tar("IVA") = True Then
            _IVA = Tar("Porciva") * _Subtotal
        Else
        End If
        'IVA
        'Total

        'If bRezagos = True Then mRezagos = rezagosMedidos() Else mRezagos = 0
        'If bConsumo = True Then mConsumo -= mRezagos Else mConsumo = 0
    End Sub

#Region "Metodos"
    'Calcula la deuda de consumo las Tarifas medidas
    Private Function DeudaMedidos() As Double
        Dim resta As Double, resta2 As Double, resta3 As Double, consucob As Double = 0, consumotem As Double
        Dim cm As Integer, consumo As Integer, Tar As IDataReader
        Dim Lecturas As System.Data.IDataReader, Deud As Double = 0, DeuConsumo As Double

        Try
            Tar = ConsultaSql("select * from cuotas, medidor where medidor.tipo = cuotas.numero and numero=" & Tarifa & " order by rango_inf").ExecuteReader
            Tar.Read()

            Lecturas = ConsultaSql("select * from Lecturas where cuenta=" & Cuenta & " and comunidad = '" & _Comunidad & "' and Aplicada = 0").ExecuteReader
            Do While Lecturas.Read
                DeuConsumo = Lecturas("consumo")

                If DeuConsumo <= Tar("consumomin") Then
                    consumotem = Tar("consumomin")
                    consumo = Tar("consumomin")
                Else
                    cm = Tar("consumomin")
                    consumotem = DeuConsumo
                End If
                Dim cuentapaso As Byte
                cuentapaso = 1

                Do While Tar.Read
                    If consumotem > 0 Then
                        resta = Tar("rago_sup") - Tar("rango_inf")
                        If cuentapaso > 1 Then resta = resta + 1
                        cuentapaso = cuentapaso + 1
                        resta2 = consumotem - resta
                        If resta2 < 0 Then
                            resta3 = consumotem
                        Else
                            resta3 = resta
                        End If
                        consucob = consucob + (Tar("tarifa_agua") * resta3)
                        consumotem -= resta3
                    End If
                Loop
            Loop
            DeudaMedidos = consucob
        Catch err As Odbc.OdbcException
            MsgBox(err.Message, MsgBoxStyle.Exclamation, "")
        End Try
    End Function
    'Calcula la deuda de Recargos las Tarifas medidas
    Private Function RecargoMedidos() As Double
        '    Dim TCuotas As System.Data.IDataReader, recaAn As IDataReader, Lecturas As System.Data.IDataReader
        '    Dim Monto As Double, con As Double, porc As Double, DeudRecargos As Double, TotRecargos As Double
        '    TCuotas = ConsultaSql("select * from cuotas where numero=" & tarifa & "").ExecuteReader
        '    If TCuotas.Read() Then
        '        If TCuotas("Recargos") Then
        '            porc = TCuotas("porcrec")
        '        Else
        '            RecargoMedidos = 0
        '            Ejecucion("update lecturas set recargos=0 where cuenta=" & Cuenta & " and pagado=false")
        '            Exit Function
        '        End If
        '    End If
        '    Lecturas = ConsultaSql("select * from Lecturas where cuenta=" & Cuenta & " and pagado = 0").ExecuteReader
        '    Do While Lecturas.Read
        '        If Month(Lecturas("MES")) <= Month(fechapag) And Year(Lecturas("MES")) <= Year(fechapag) Then
        '            Monto = Lecturas("Monto")
        '            con = DateDiff("m", Lecturas("mes"), hoy) - 1
        '            If con < 0 Then con = 0
        '            Do While con > 0
        '                DeudRecargos = DeudRecargos + (con * (Monto * (porc / 100)))
        '                con -= 1
        '            Loop
        '            TotRecargos += Math.Round(DeudRecargos, 2)
        '            Ejecucion("update lecturas set recargos=" & Math.Round(DeudRecargos, 2) & "  where cuenta=" & Cuenta & " and mes='" & Format(Lecturas("MES"), "yyyy-MM-dd") & "' and pagado=0 ")
        '        End If
        '    Loop

        '    recaAn = ConsultaSql("select sum(recargos) as monto,year(mes) as año  from lecturas where cuenta=" & Cuenta & " and pagado=false group by year(mes)").ExecuteReader
        '    recaAn.Read()
        '    While recaAn.Read()
        '        _recaAnual.Add(recaAn("año") & ", " & recaAn("monto"))
        '    End While
        '    RecargoMedidos = TotRecargos
        RecargoMedidos = 0
    End Function
    ''Calcula la deuda de Alcantarillado las Tarifas medidas
    Private Function AlcantarilladoMedidos() As Double
        '    Dim Tar As IDataReader
        '    Tar = ConsultaSql("Select * from cuotas where id_tarifa = '" & Tarifa & "'").ExecuteReader

        '    Dim alcaAn As IDataReader, Lecturas As System.Data.IDataReader
        '    Dim Monto As Double, porc As Double, DeudAlca As Double, TotAlca As Double

        '    If Tar.Read() Then
        '        If Tar("Alcantarillado") Then
        '            porc = Tar("porcAlca")
        '        Else
        '            AlcantarilladoMedidos = 0
        '            Exit Function
        '        End If
        '    End If

        '    Lecturas = ConsultaSql("select * from Lecturas where cuenta=" & Cuenta & " and comunidad = '" & _Comunidad & "' and Aplicada = 0").ExecuteReader
        '    Do While Lecturas.Read
        '        If Month(Lecturas("MES")) <= Month(fechapag) And Year(Lecturas("MES")) <= Year(fechapag) Then
        '            Monto = Lecturas("Monto")
        '            DeudAlca = (Monto * (porc / 100))
        '            TotAlca += Math.Round(DeudAlca, 2)
        '            Ejecucion("update lecturas set alcantarillado=" & Math.Round(DeudAlca, 2) & "  where cuenta=" & Cuenta & " and mes='" & Format(Lecturas("MES"), "yyyy-MM-dd") & "' and pagado=0 ")
        '        End If
        '    Loop

        '    AlcantarilladoMedidos = TotAlca
        AlcantarilladoMedidos = 0
    End Function
    ''Calcula la deuda de Saneamiento las Tarifas medidas
    Private Function SaneamientoMedidos() As Double
        '    Dim TCuotas As System.Data.IDataReader, sanAn As IDataReader, Lecturas As System.Data.IDataReader
        '    Dim Monto As Double, porc As Double, DeudSanea As Double, TotSanea As Double
        '    TCuotas = ConsultaSql("select * from cuotas where numero=" & tarifa & "").ExecuteReader
        '    If TCuotas.Read() Then
        '        If TCuotas("Saneacuo") Then
        '            porc = TCuotas("porcSanea")
        '        Else
        '            SaneamientoMedidos = 0
        '            Exit Function
        '        End If
        '    End If
        '    Lecturas = ConsultaSql("select * from Lecturas where cuenta=" & Cuenta & " and pagado = 0").ExecuteReader
        '    Do While Lecturas.Read
        '        If Month(Lecturas("MES")) <= Month(fechapag) And Year(Lecturas("MES")) <= Year(fechapag) Then
        '            Monto = Lecturas("Monto")
        '            DeudSanea = (Monto * (porc / 100))
        '            TotSanea += Math.Round(DeudSanea, 2)
        '            Ejecucion("update lecturas set saneamiento=" & Math.Round(DeudSanea, 2) & "  where cuenta=" & Cuenta & " and mes='" & Format(Lecturas("MES"), "yyyy-MM-dd") & "' and pagado=0 ")
        '        End If
        '    Loop

        '    sanAn = ConsultaSql("select sum(saneamiento) as monto,year(mes) as año  from lecturas where cuenta=" & Cuenta & " and pagado=false group by year(mes)").ExecuteReader
        '    sanAn.Read()
        '    While sanAn.Read()
        '        _saneaAnual.Add(sanAn("año") & ", " & sanAn("monto"))
        '    End While
        '    SaneamientoMedidos = TotSanea
        SaneamientoMedidos = 0
    End Function

    'Private Function rezagosMedidos() As Double
    '    Dim rezaData As IDataReader

    '    rezaData = ConsultaSql("select sum(monto) as Rezagos from lecturas where (year(mes) < " & Year(hoy) & ") or (year(mes)= " & Year(hoy) & " and month(mes) <  " & Month(hoy) & " and cuenta=" & Cuenta & ")").ExecuteReader
    '    rezaData.Read()
    '    If IsDBNull(rezaData("Rezagos")) Then
    '        rezagosMedidos = 0
    '    Else
    '        rezagosMedidos = rezaData("Rezagos")
    '    End If
    'End Function
#End Region

End Class
