Imports DevComponents.DotNetBar

Public Class ClsLecturas
    Enum Viene
        Captura
        Verificacion
    End Enum

    Dim CapVeri As Viene, Cuota As String, ConsumoCobrado As String, Sector As String
    Dim Accion1 As String, Accion2 As String, Accion3 As String
    Dim ConsumoCobrar1 As Double, ConsumoCobrar2 As Double, ConsumoCobrar3 As Double
    Dim Promedio1 As Integer, Promedio2 As Integer, Promedio3 As Integer
    Dim Meses1 As Integer, Meses2 As Integer, Meses3 As Integer
    Dim Promedio As Double, MesesPromedio As Double, ConsNuevo As Double
    Dim Concec As Integer, ConCobrado As Double
    Public mes As String
    Public periodo As Integer
    '  Public periodo_ As Date

#Region "Modificadores de Acceso"
    Dim _Region As String
    Dim _Comunidad As String
    Dim _Cuenta As Double
    Dim _Ruta As String
    Dim _Fecha As Date
    Dim _Lecturista As Integer
    Public _Tabla As String
    Public cuentaAnterior As String
    Dim _Nombre As String
    Dim _Estado As String
    Dim _Medidor As String
    Dim _Direccion As String
    Dim _Anterior As Double
    Dim _Tarifa As String
    Dim _NumLec As Double
    Dim _Manzana As String
    Dim _Lote As String
    Dim _Lectura As Double
    Dim _Sit_Med As String
    Dim _Sit_Pad As String
    Dim _Sit_Hid As String
    Dim _ConsHijo As String
    Dim _Observacion As String
    Dim _Consumo As Double
    Dim _Periodo As Date
    Dim _Lec1 As Double
    Dim _Lec2 As Double
    Dim _algm As Int16 = 0
    Dim _bandera As Boolean
    Dim _conCob As Double
    Public Property consumoCob() As Double
        Get
            Return _conCob
        End Get
        Set(ByVal value As Double)
            _conCob = value
        End Set
    End Property


    Public Property AlgorimoModificado() As Int16
        Get
            Return _algm
        End Get
        Set(ByVal value As Int16)
            _algm = value
        End Set
    End Property
    Public Property Lec1() As Double
        Get
            Return _Lec1
        End Get
        Set(ByVal value As Double)
            _Lec1 = value
        End Set
    End Property
    Public Property Lec2() As Double
        Get
            Return _Lec2
        End Get
        Set(ByVal value As Double)
            _Lec2 = value
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
    Public Property Tabla() As String
        Get
            Return String.Concat("Lecturas")
        End Get
        Set(ByVal value As String)
            _Tabla = String.Concat("Lecturas")
        End Set
    End Property
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property
    Public Property ConsultaHijo() As String
        Get
            Return _ConsHijo
        End Get
        Set(ByVal value As String)
            _ConsHijo = value
        End Set
    End Property
    Public Property Sit_Hid() As String
        Get
            Return _Sit_Hid
        End Get
        Set(ByVal value As String)
            _Sit_Hid = value
        End Set
    End Property
    Public Property Sit_Pad() As String
        Get
            Return _Sit_Pad
        End Get
        Set(ByVal value As String)
            _Sit_Pad = value
        End Set
    End Property
    Public Property Sit_Med() As String
        Get
            Return _Sit_Med
        End Get
        Set(ByVal value As String)
            _Sit_Med = value
        End Set
    End Property

    Public Property Lectura() As Double
        Get
            Return _Lectura
        End Get
        Set(ByVal value As Double)
            _Lectura = value
        End Set
    End Property
    Public Property Lote() As String
        Get
            Return _Lote
        End Get
        Set(ByVal value As String)
            _Lote = value
        End Set
    End Property
    Public Property Manzana() As String
        Get
            Return _Manzana
        End Get
        Set(ByVal value As String)
            _Manzana = value
        End Set
    End Property
    Public Property NumLec() As Double
        Get
            Return _NumLec
        End Get
        Set(ByVal value As Double)
            _NumLec = value
        End Set
    End Property
    Public Property Tarifa() As String
        Get
            Return _Tarifa
        End Get
        Set(ByVal value As String)
            _Tarifa = value
        End Set
    End Property
    Public Property Anterior() As Double
        Get
            Return _Anterior
        End Get
        Set(ByVal value As Double)
            _Anterior = value
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property
    Public Property Medidor() As String
        Get
            Return _Medidor
        End Get
        Set(ByVal value As String)
            _Medidor = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return _Estado
        End Get
        Set(ByVal value As String)
            _Estado = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Public Property Lecturista() As Integer
        Get
            Return _Lecturista
        End Get
        Set(ByVal value As Integer)
            _Lecturista = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property Region() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property
    Public Property Comunidad() As String
        Get
            Return _Comunidad
        End Get
        Set(ByVal value As String)
            If Len(value) > 3 Then
                value = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & value & "'", "id_comunidad")
            End If
            _Comunidad = value
        End Set
    End Property
    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
        End Set
    End Property
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
#End Region

#Region "Captura"
    Dim ConsPadre As String, Padre As IDataReader
    Public Sub Consultas()

        '_ConsHijo = "select lecturas.alerta,  usuario.cuenta, usuario.id_comunidad, usuario.nombre, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo FROM usuario,  lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  order by usuario.numlec asc"
        _ConsHijo = "select lecturas.alerta,  usuario.cuenta, usuario.cuentaAnterior, usuario.id_comunidad, usuario.nombre,usuario.tarifa, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo FROM usuario,  lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  order by usuario.lote,cuenta asc"


        Try
            Dim x As IDataReader = ConsultaSql("select cuenta from " & _Tabla & "").ExecuteReader
        Catch ex As Exception
            MessageBoxEx.Show("No se encontro el archivo " & _Tabla & " de lecturas", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub CreaConsultausuario()
        Dim Rut As String = _Ruta
        '  _Tabla = tablatem(Region, Ruta)
        '    _ConsHijo = "select lecturas.alerta, usuario.cuenta,  usuario.id_comunidad, usuario.nombre,usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.montoconsumo as montoconsumo, lecturas.montoiva as montoiva, algoritmos.descrip as algoritmo, lecturas.algoritmo as alg FROM usuario, algoritmos, lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  and lecturas.algoritmo=algoritmos.clave order by usuario.numlec asc"
        '_ConsHijo = "select lecturas.alerta, usuario.cuenta, usuario.nombre, usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.montoconsumo as montoconsumo FROM usuario, lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  and mes ='" & mes & "' and an_per='" & periodo & "' order by usuario.numlec asc"
        _ConsHijo = "select lecturas.alerta, usuario.cuenta, usuario.tarifa, usuario.nombre, usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.monto as montoconsumo, lecturas.montocobrado as montocobrado FROM usuario, lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  and mes ='" & mes & "' and an_per='" & periodo & "' order by usuario.manzana,usuario.lote"
        'ConsPadre = "select v.nombre, v.cuenta, v.estado, v.nodemedidor, v.direccion, v.colonia, v.lecturaact, v.descripcion_cuota, c.id_tarifa, v.numlec, v.manzana, v.lote, v.sector, c.altcap, v.cammed   from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  v.region = '" & _Region & "' and v.ruta = '" & _Ruta & "' and not v.cuenta in (select cuenta from Lecturas where mes='" & mes & "' and an_per=" & periodo & " )  order by numlec asc"
        'ConsPadre = "select v.nombre, v.cuenta,v.cuentaAnterior, v.estado, v.nodemedidor, v.direccion, v.colonia, v.lecturaact, v.descripcion_cuota, c.id_tarifa, v.numlec, v.manzana, v.lote, v.sector, c.altcap, v.cammed   from  vusuario as v, cuotas as c where v.tarifa = c.id_tarifa and c.medido <> 0 and  v.region = '" & _Region & "' and v.ruta = '" & _Ruta & "' and not v.cuenta in (select cuenta from lecturas where mes='" & mes & "' and an_per=" & periodo & " )  order by lote asc,cuenta"
        ConsPadre = "select v.nombre, v.cuenta,  v.tarifa, v.estado, v.nodemedidor, v.direccion, v.colonia, v.lecturaact, v.descripcion_cuota, c.id_tarifa, v.numlec, v.manzana, v.lote, v.sector, c.altcap, v.cammed   from  vusuario as v, cuotas as c where v.tarifa = c.id_tarifa and c.medido <> 0 and  v.region = '" & _Region & "' and v.ruta = '" & _Ruta & "'  order by manzana,lote"
        Dim paso As Boolean = False



        Application.DoEvents()
        Try
            Padre = ConsultaSql(ConsPadre).ExecuteReader
        Catch ex As Exception

        End Try

    End Sub

    Public Sub EliminarLectura(ByVal Tab As String)
        If MessageBoxEx.Show("Desea eliminar la lectura de la cuenta " & _Cuenta & " ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            mes = FrmCapturaLecturas.cmbmes.Text
            Ejecucion("delete from lecturas where cuenta = " & _Cuenta & " and mes='" & mes & "'and an_per='" & periodo & "';")
            MessageBoxEx.Show("Lectura eliminada satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Enum RespCaptura
        Capturado
        Alerta
        No_Capturado
    End Enum
    Public Function ModificarCaptura() As RespCaptura
        '  _Tabla = tablatem(Region, Ruta)
        'ConsPadre = "select * from vusuario, cuotas where vusuario.descripcion_cuota = cuotas.descripcion_cuota and cuotas.medido <> 0 and cuenta = " & _Cuenta & "  order by numlec asc"
        ConsPadre = "select * from vusuario, cuotas where vusuario.tarifa = cuotas.id_tarifa and cuotas.medido <> 0 and cuenta = " & _Cuenta & "  order by lote,cuenta asc"
        Padre = ConsultaSql(ConsPadre).ExecuteReader
        Padre.Read()

        CapVeri = Viene.Captura
        'If _Lectura < 0 Then
        'MessageBoxEx.Show("Lectura no valida, faltan ingresar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'ModificarCaptura = RespCaptura.No_Capturado
        'Else
        Dim Status As Integer = 0
        Dim Accion As String = ""
        Dim Consume As Double, Cons As Double
        Cons = Math.Abs(_Lectura - _Lec2)
        If Padre("altcap") <= (_Lectura - _Lec2) Then
            If MessageBoxEx.Show("El consumo es superior al permitido por la cuota que es de " & CInt(Padre("altcap")) & " y su consumo es de " & (_Lectura - _Lec2) & vbCrLf & "Deberias registrar una situacion de lectura" & vbCrLf & "  ¿desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                ModificarCaptura = RespCaptura.Alerta
                Exit Function
            End If
            Status = 1
        End If
        If Padre("CamMed") Then
            Status = 1
            _Sit_Pad = LMedNuevo
            Accion = "Nuevo"
            GoTo siguiente
        End If

        If _Lectura >= 0 Then
            If (_Lectura - _Lec2) < 0 Then
                If MessageBoxEx.Show("La Lectura Actual es inferior que la Lectura Anterior, por lo que dio vuelta el medidor ¿desea continuar?", "Vuelta de Medidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    ModificarCaptura = RespCaptura.Alerta
                    Cons = Vuelta()
                    Exit Function
                End If
                Status = 1
            End If
        Else
            _Lectura = _Lec2
        End If
siguiente:
        _Consumo = Cons
        Dim que As Integer
        Dim quealgoritmo As IDataReader = Nothing
        quealgoritmo = ConsultaSql("select * from empresa ").ExecuteReader
        quealgoritmo.Read()

        If (_Sit_Hid <> "" OrElse _Sit_Med <> "" OrElse _Sit_Pad <> "") AndAlso _Sit_Pad <> quealgoritmo("situacionnuevo") Then

            que = quealgoritmo("algdefault")
            VerificarAlgoritmo(que, 1)

        End If

        If _Sit_Hid = "" AndAlso _Sit_Med = "" AndAlso _Sit_Pad = "" AndAlso _Sit_Pad <> quealgoritmo("situacionnuevo") Then

            que = quealgoritmo("algdefaultconsumo")
            VerificarAlgoritmo(que, 1)
        End If

        If Accion <> "Nuevo" And Accion <> "Disparada" And Sit_Pad <> quealgoritmo("situacionnuevo") Then

            Accion = Accion1
            Consume = ConsumoCobrar1
            MesesPromedio = Meses1

            If Accion = "" Then
                Accion = "Consumo"
                Consume = _Consumo
            End If
        ElseIf (Accion = "Nuevo" Or Accion = "Disparada") Or Sit_Pad = quealgoritmo("situacionnuevo") Then
            VerificarAlgoritmo(obtenerCampo("select algoritmo from situacion where clave='" & quealgoritmo("situacionnuevo") & "'", "algoritmo"), 1)
            Consume = ConsNuevo
            Accion = Accion1
            que = Concec

        End If


        Ejecucion("update lecturas set  accion = '" & Accion & "',  Alerta = " & Status & ", ope_ver = " & NumUser & ", fec_ver = " & UnixDateFormat(Now, True, True) & ", lectura = " & _Lectura & ", sit_hid = '" & _Sit_Hid & "', sit_med = '" & _Sit_Med & "', sit_pad = '" & _Sit_Pad & "', observa = '" & _Observacion & "', consumo = " & Math.Abs(_Lectura - _Lec2) & ", algoritmo=" & que & ", consumoCobrado=" & _conCob & " where cuenta = " & _Cuenta & " AND MES='" & mes & "' AND AN_PER=" & periodo)
        ModificarCaptura = RespCaptura.Capturado
        'End If
    End Function

    Public Function Capturar() As RespCaptura
        '     CapVeri = Viene.Captura
        Dim que As Integer
        'If _Lectura < 0 Then
        'MessageBoxEx.Show("Lectura no valida, faltan ingresar datos", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Capturar = RespCaptura.No_Capturado
        'Else
        Dim Status As Integer = 0
        Dim cons As Integer
        Dim Accion As String = ""
        Dim Consume As Double

        cons = Math.Abs(_Lec2 - _Lectura)
        If Padre("altcap") <= (_Lectura - _Lec2) Then
            If MessageBoxEx.Show("El consumo es superior al permitido por la cuota que es de " & CInt(Padre("altcap")) & " y su consumo es de " & (_Lectura - _Lec2) & vbCrLf & "Deberias registrar una situacion de lectura" & vbCrLf & " ¿desea continuar? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Capturar = RespCaptura.Alerta
                Exit Function
            End If
            Status = 1
        End If

        If Padre("CamMed") Then
            Status = 1
            _Sit_Pad = LMedNuevo
            Accion = "Nuevo"
            GoTo siguiente
        End If
        If _Lectura >= 0 Then
            If (_Lectura - _Lec2) < 0 Then
                If MessageBoxEx.Show("La Lectura Actual es inferior que la Lectura Anterior, por lo que dio vuelta el medidor ¿desea continuar?", "Vuelta de Medidor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Capturar = RespCaptura.Alerta
                    _Lec1 = _Lec2
                    cons = Vuelta()
                    Exit Function
                End If
                Status = 1
            End If
        Else
            _Lectura = _Lec2
        End If
siguiente:
        _Consumo = cons


        Dim quealgoritmo As IDataReader = Nothing
        quealgoritmo = ConsultaSql("select * from empresa ").ExecuteReader
        quealgoritmo.Read()

        If (_Sit_Hid <> "" OrElse _Sit_Med <> "" OrElse _Sit_Pad <> "") AndAlso _Sit_Pad <> quealgoritmo("situacionnuevo") Then

            que = quealgoritmo("algdefault")
            VerificarAlgoritmo(que, 1)

        End If

        If _Sit_Hid = "" AndAlso _Sit_Med = "" AndAlso _Sit_Pad = "" AndAlso _Sit_Pad <> quealgoritmo("situacionnuevo") Then

            que = quealgoritmo("algdefaultconsumo")
            VerificarAlgoritmo(que, 1)
        End If

        If Accion <> "Nuevo" And Accion <> "Disparada" And Sit_Pad <> quealgoritmo("situacionnuevo") Then

            Accion = Accion1
            ' Consume = ConsumoCobrar1
            MesesPromedio = Meses1

            If Accion = "" Then
                Accion = "Consumo"
                Consume = _Consumo
            End If

            If Accion = "Promediar" Then
                Consume = obtenerCampo("select promedio(" & Cuenta & "," & MesesPromedio & ") as promedio", "promedio")
            End If

            If Accion = "Minimo" Then
                Consume = obtenerCampo("select promedio(" & Cuenta & ") as minimo", "minimo")
            End If
            If Accion = "Ultimo consumo" Then
                Consume = obtenerCampo("select Ultimoconsumo(" & Cuenta & ") as Ultimoconsumo", "Ultimoconsumo")
            End If


        ElseIf (Accion = "Nuevo" Or Accion = "Disparada") Or Sit_Pad = quealgoritmo("situacionnuevo") Then
            VerificarAlgoritmo(obtenerCampo("select algoritmo from situacion where clave='" & quealgoritmo("situacionnuevo") & "'", "algoritmo"), 1)
            Consume = ConsNuevo
            Accion = Accion1
            que = Concec

        End If






        Try


            Try


                If Manzana = "" Then
                    Manzana = 0
                End If


            Catch ex As Exception

            End Try



            Ejecucion("insert into lecturas (cuenta, manzana, lote, consecutivo, fec_lec, lecturista, lectura, lectant, sit_med, sit_pad, sit_hid, observa, Alerta, ope_cap, fec_cap, consumo, region, numlec, tarifa, sector, ruta, mes, an_per, consumocobrado, accion, mesespromedio, algoritmo,monto,montocobrado) values " &
                  "(" & _Cuenta & ",  " & Manzana & ", '" & Lote & "', 0, '" & UnixDateFormat(_Fecha) & "', " & _Lecturista & ", " & _Lectura & ", " & _Lec2 & ", '" & _Sit_Med & "', '" & _Sit_Pad & "', '" & _Sit_Hid & "', '" & _Observacion & "'," & Status & ", '" & NumUser & "', " & UnixDateFormat(Now, True, True) & ", " & cons & ", '" & _Region & "', " & _NumLec & ", '" & Cuota & "', '" & Sector & "', '" & _Ruta & "', '" & mes & "', " & periodo & ", " & Consume & ", '" & Accion & "'," & MesesPromedio & "," & que & ",consumomedidos(" & cons & ",'" & Cuota & "'," & Me.periodo & " ),consumomedidos(" & Consume & ",'" & Cuota & "'," & Me.periodo & ")) ")
            ''"(" & _Cuenta & ",  " & Manzana & ", '" & Lote & "', 0, '" & UnixDateFormat(_Fecha) & "', " & _Lecturista & ", " & _Lectura & ", " & _Lec2 & ", '" & _Sit_Med & "', '" & _Sit_Pad & "', '" & _Sit_Hid & "', '" & _Observacion & "'," & Status & ", '" & NumUser & "', " & UnixDateFormat(Now, True, True) & ", " & cons & ", '" & _Region & "', " & _NumLec & ", '" & Cuota & "', '" & Sector & "', '" & _Ruta & "', '" & mes & "', " & periodo & ", " & Consume & ", '" & Accion & "'," & MesesPromedio & "," & que & ",consumomedidossin(" & Consume & ",'" & Cuota & "' ),consumomedidossin(" & Consume & ",'" & Cuota & "')) ")


            'Consultar el Deuda_Fec del usuario para saber hasta que fecha tiene pagado, si la fecha es mayor al mes de la lectura que se esta agregando se hara un update donde la lectura ya este pagada
            Dim fechaDeuda As String

            fechaDeuda = DateTime.Parse(obtenerCampo("Select DEUDAFEC from USUARIO where CUENTA = '" & _Cuenta & "'", "DEUDAFEC"))

            Dim dateLectura As Date = DateTime.Parse(Now.Day & "-" & CadenaNumeroMes(mes) & "-" & periodo)

            If (DateTime.Compare(fechaDeuda, dateLectura) > 0) Then

                MessageBox.Show("La Fecha de Deuda es mayor")

                Ejecucion("UPDATE lecturas l, usuario SET pagado = '1', adelant = '1' WHERE usuario.cuenta=l.cuenta and l.cuenta='" & _Cuenta & "' and mes='" & mes & "' and an_per='" & periodo & "';")
                MessageBox.Show("Actualizacion Completa... ")

            End If


        Catch ex As Exception


            If ex.Message.ToString.Contains("Duplicate") Then

                '  MessageBoxEx.Show("Lectura repetida, veriricar datos por favor", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Ejecucion("update lecturas set consumopagado=consumo, montopagado=montocobrado where  cuenta= " & _Cuenta & " and mes='" & mes & "' and an_per=" & periodo)
                Ejecucion("update lecturas set fec_lec ='" & UnixDateFormat(_Fecha) & "' ,lecturista=" & _Lecturista & ", lectura=" & _Lectura & ", lectant=" & _Lec2 & ", sit_med='" & _Sit_Med & "', sit_pad='" & _Sit_Pad & "', sit_hid='" & _Sit_Hid & "', observa='" & Observacion & "', alerta =" & Status & ",ope_cap ='" & NumUser & "' ,  fec_cap='" & UnixDateFormat(Now) & "', Consumo= " & cons & ", accion='" & Accion & "', mesespromedio=" & MesesPromedio & ", algoritmo=" & que & ",monto=consumomedidos(" & _Consumo & ",'" & Cuota & "'," & Me.periodo & " ), montocobrado = consumomedidos(" & Consume & ",'" & Cuota & "'," & Me.periodo & " ) - AConsumo  where cuenta= " & _Cuenta & " And mes='" & mes & "' and  an_per=" & periodo)


            Else

                MessageBox.Show(ex.Message)

            End If

        End Try

        Capturar = RespCaptura.Capturado
        'End If
    End Function

    Public Sub ReiniciarCaptura()
        If MessageBoxEx.Show("El proceso de reiniciar eliminara todas las lecturas ya capturadas y empezara desde el principio " & vbCrLf & "¿Desea reiniciar la captura de lecturas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from " & _Tabla & "")
            'Padre = ConsultaSql(ConsPadre).ExecuteReader
            MessageBoxEx.Show("Se ha reiniciado la captura de lecturas", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

#Region "Crear Lecturas no Capturadas"
    Public Sub Crear(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX)
        CapVeri = Viene.Captura

        ConsPadre = "Select * from vusuario, cuotas where vusuario.mostrar = 1 And vusuario.tarifa = cuotas.id_tarifa And cuotas.medido <> 0 And  region = '" & _Region & "' and ruta = '" & _Ruta & "'  order by lote,cuenta asc;"
        Padre = ConsultaSql(ConsPadre).ExecuteReader
        PB.Visible = True
        Dim quealgoritmo As IDataReader = Nothing
        quealgoritmo = ConsultaSql("select * from empresa ").ExecuteReader
        quealgoritmo.Read()

        Dim Accion As String, Consume As Double, Porc As String

        Do While Avanzar() = True
            _Tabla = "lecturas"
            PB.Maximum = Padre.RecordsAffected
            PB.Value = PB.Value + 1
            Porc = Math.Round(((PB.Value / PB.Maximum) * 100), 0) & "%"
            PB.Text = "Creando las lecturas de la Ruta " & _Ruta & "    " & Porc
            _Lectura = _Lec2
            Application.DoEvents()

            Dim tarifadelusuario As String = Padre("tarifa")

            Dim que As Integer
            If (_Sit_Hid <> "" OrElse _Sit_Med <> "" OrElse _Sit_Pad <> "") Then

                que = quealgoritmo("algdefault")
                Consume = consumoVerificarAlgoritmo(que, _Tabla)
                Accion = "Promediar"
            End If
            Try
                If obtenerCampo("select cuenta from lecturas where cuenta=" & Cuenta & " and mes='" & mes & "' and an_per=" & periodo, "cuenta") = "0" Then ' si no existe registro de lecturas lo crea con el promedio
                    Ejecucion("insert into lecturas (cuenta,  manzana, lote, consecutivo, fec_lec, lecturista, lectura, lectant, sit_med, sit_pad, sit_hid, observa, Alerta, ope_cap, fec_cap, consumo, consumocobrado, region, numlec, tarifa, sector, ruta, mes, an_per, algoritmo,monto,montocobrado) values " &
                     "(" & _Cuenta & ",  '" & Manzana & "', '" & Lote & "', 0, '" & UnixDateFormat(Now) & "', " & _Lecturista & ", " & _Lec2 & ", " & _Lec2 & ", '" & _Sit_Med & "', '" & _Sit_Pad & "', '" & _Sit_Hid & "', '" & _Observacion & "',0, '" & NumUser & "', " & UnixDateFormat(Now, True, True) & ",0, " & Consume & ", '" & _Region & "', " & _NumLec & ", '" & Cuota & "', '" & Sector & "', '" & _Ruta & "', '" & mes & "', " & periodo & "," & que & ",consumomedidos(0,'" & tarifadelusuario & "'," & periodo & "),consumomedidos(" & Consume & ",'" & tarifadelusuario & "'," & periodo & ")) ")
                End If
            Catch ex As Exception

            End Try


        Loop
        PB.Visible = False
    End Sub
#End Region

#Region "Numerar Toma lecturas"
    Public Sub NumerarTomas(Optional ByVal tarifa As String = "", Optional ByVal conmedidor As Boolean = False)
        ' Dim NomReg As String = obtenerCampo("Select Region from region where id_region = '" & _Region & "'", "Region")

        'Dim NomRuta As String
        'Dim Tit As String
        'Dim conm As String = ""

        'If conmedidor Then
        '    conm = " and {vUSUARIO1.nodemedidor}<>''"
        'End If
        'If _Ruta = "" Then
        '    Dim ruts As IDataReader = ConsultaSql("Select id_ruta from rutas where id_region = '" & _Region & "'").ExecuteReader
        '    Do While ruts.Read
        '        Try
        '            Application.DoEvents()
        '            Dim ir As IDataReader = ConsultaSql("select numerar('" & _Region & "', '" & ruts("id_ruta") & "')").ExecuteReader
        '            ir.Read()
        '            Ejecucion("Update rutas set TomaLec = 'S' where Id_ruta = '" & ruts("id_ruta") & "' and id_region = '" & _Region & "'")
        '        Catch ex As Exception
        '        End Try
        '    Loop
        '    Dim condicion As String
        '    If tarifa = "" Then
        '        'Tit = " REGION: " & NomReg
        '        condicion = "{vUSUARIO1.numlec} >=0 and {vUSUARIO1.region}='" & _Region & "' " & conm
        '    Else

        '        'Tit = " REGION: " & NomReg & "    TARIFA: " & tarifa
        '        condicion = "{vUSUARIO1.numlec} >0 and {vUSUARIO1.region}='" & _Region & "'   {vUSUARIO1.TARIFA}='" & tarifa & "'" & conm

        '    End If
        '  Dim rsp As New frmReporte(frmReporte.Lista.Listado_Lecturas, condicion, "Titulo, '" & Tit & "'")
        '    'rsp.MdiParent = My.Forms.MDIPrincipal
        '    'rsp.Text = "Reporte " & Tit
        '    'Application.DoEvents()

        '    'rsp.Show()
        '    'rsp.WindowState = FormWindowState.Maximized
        'Else
        '    Application.DoEvents()
        Dim ir As IDataReader = ConsultaSql("select numerar( '" & _Region & "', '" & _Ruta & "')").ExecuteReader
        ir.Read()
        If ir(0) = 1 Then
            MessageBoxEx.Show("No se encontraron tomas en esa ruta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        'NomRuta = obtenerCampo("Select ruta from rutas where id_ruta = '" & _Ruta & "'", "ruta")
        'Dim condicion As String
        'If tarifa = "" Then
        '    ' Tit = "    REGION: " & NomReg & "      RUTA: " & NomRuta
        '    condicion = "{vUSUARIO1.numlec} >0 and {vUSUARIO1.region}='" & _Region & "' and {vUSUARIO1.ruta}= '" & _Ruta & "' " & conm
        'Else
        '    'Tit = "     REGION: " & NomReg & "      RUTA: " & NomRuta & "   TARIFA: " & tarifa
        '    condicion = "{vUSUARIO1.numlec} >0 and {vUSUARIO1.region}='" & _Region & "' and {vUSUARIO1.ruta}= '" & _Ruta & "'  AND {vUSUARIO1.TARIFA}='" & tarifa & "'" & conm
        'End If

        '   Ejecucion("Update rutas set TomaLec = 'S' where id_region = '" & _Region & "' AND  Id_ruta = '" & _Ruta & "'")
        'Dim rsp As New frmReporte(frmReporte.Lista.Listado_Lecturas, condicion, "Titulo, '" & Tit & "'")
        'rsp.MdiParent = My.Forms.MDIPrincipal
        'rsp.Text = "Reporte " & Tit
        'Application.DoEvents()
        'rsp.Show()
        'rsp.WindowState = FormWindowState.Maximized
        'End If


    End Sub
#End Region

#Region "CalculaConsumo"
    Public Sub ConsumoMes(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX)
        Dim iruta As IDataReader
        Dim ArchFal As String = "", Nom As String = "", FalCap As String = ""
        Dim chk As IDataReader
        Dim Alerta As Boolean

        iruta = ConsultaSql("Select id_ruta, ruta, captura from rutas where id_region = '" & Region & "'").ExecuteReader

        Do While iruta.Read
            Try
                _Ruta = iruta("id_ruta")
                Nom = iruta("ruta")
                '_Tabla = tablatem(Region, Ruta)

                chk = ConsultaSql("Select cuenta from lecturas  where mes='" & mes & "' and an_per='" & periodo & "' limit 1").ExecuteReader
                chk.Read()
                If iruta("Captura") = "N" Then
                    FalCap = FalCap & Nom & vbCrLf
                End If
            Catch Err As Exception
                ArchFal = ArchFal & Nom & vbCrLf
            End Try
        Loop

        If Len(FalCap) > 0 Then
            If MessageBoxEx.Show("Faltan la captura para las siguientes rutas: " & vbCrLf & FalCap & " por lo que no se puede realizar el calculo de consumo" & vbCrLf & "¿Desea Calcular el consumo de todas formas?", "Calculo de consumo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then
                Ejecucion("Update rutas set Captura = 'I' where id_region = '" & _Region & "' and captura = 'N' ")
            Else
                Exit Sub
            End If
        End If

        iruta = ConsultaSql("Select id_ruta, ruta from rutas where id_region = '" & Region & "'").ExecuteReader
        'C O L O C A R     M A R C A  D O R    A Q U I 
        Do While iruta.Read
            _Ruta = iruta("id_ruta")
            Nom = iruta("ruta")
            Try
                '_Tabla = tablatem(Region, Ruta)
                '  Dim chec As IDataReader = ConsultaSql("select cuenta from lecturas  where mes='" & mes & "' and an_per='" & periodo & "' limit 1").ExecuteReader
                'Dim Totlec As Double = obtenerCampo("select count(v.nombre) as num from  vusuario as v, cuotas as c                where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  region = '" & _Region & "' and ruta = '" & _Ruta & "' and mostrar = 1 and mes='" & mes & "' and an_per=" & periodo & " order by numlec asc", "num")
                'Dim Totlec As Double = obtenerCampo("select count(v.nombre) as num from  vusuario as v, cuotas as c                where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  l.region = '" & _Region & "' and l.ruta = '" & _Ruta & "' and mostrar = 1 and l.mes='" & mes & "' and l.an_per=" & periodo & " order by numlec asc", "num")
                Dim Totlec As Double = obtenerCampo("select count(cuenta) as num from  vusuario as v, cuotas as c where v.tarifa = c.id_tarifa and c.medido <> 0 and v.region = '" & _Region & "' and v.ruta = '" & _Ruta & "' and mostrar = 1  ", "num")

                'Dim Totlec As Double = obtenerCampo("select count(v.nombre) as num from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  region = '" & _Region & "' and ruta = '" & _Ruta & "' and mes='" & mes & "' and an_per='" & periodo & "' and mostrar = 1 order by numlec asc", "num")
                Dim TotCap As Double = obtenerCampo("select count(l.cuenta) as num from lecturas as l,vusuario as v,cuotas c where l.mes='" & mes & "' and l.an_per=" & periodo & " and v.cuenta=l.cuenta and v.tarifa = c.id_tarifa and c.medido <> 0 and v.region = '" & _Region & "' and v.ruta = '" & _Ruta & "' and mostrar = 1  ", "num")
                If TotCap < Totlec Then
                    Dim noc As New FrmLecturasNoCapturadas
                    noc.Numero = Totlec - TotCap
                    'noc.Comunidad = _Comunidad
                    noc.Regi = _Region
                    noc.Ruta = _Ruta
                    noc.Periodo = periodo
                    noc.mes = mes
                    noc.ShowDialog()

                    If noc.Estado = False Then
                        FrmCalculaConsumo.Close()
                        Exit Sub
                    End If
                End If
                'C O L O C A R     M A R C A  D O R    A Q U I 
                Dim Usuarios As IDataReader = ConsultaSql("Select l.consumocobrado, l.consecutivo, l.consumo, l.cuenta, sit_med, sit_pad, sit_hid, u.tarifa, lectura, accion, cammed, alerta,algoritmo from lecturas as l, usuario as u where l.cuenta = u.cuenta and l.mes='" & mes & "' and l.an_per='" & periodo & "' and u.ruta='" & _Ruta & "' and u.region='" & _Region & "' order by l.numlec").ExecuteReader
                Dim cont As Long = 1, Accion As String
                Dim Consume As Double
                PB.Visible = True

                Do While Usuarios.Read
                    'If Usuarios("cuenta") = 8541 Then Stop
                    Application.DoEvents()
                    PB.Maximum = Usuarios.RecordsAffected
                    PB.Value = cont
                    PB.Text = "Calculando la ruta " & Nom & "    " & Math.Round(((PB.Value / PB.Maximum) * 100), 0) & "%"

                    'De aqui para abajo es por la primera vez que no paso bien la lectura anterior
                    _Lec1 = 0
                    'If Not Usuarios("accion") = "FIJO" Then
                    '
                    'Dim le As IDataReader = ConsultaSql("Select lectura , valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & Usuarios("Cuenta") & " and mes='" & mes & "' and an_per='" & periodo & "' order by ordenado desc limit 1").ExecuteReader
                    '    If le.Read Then
                    '        _Lec1 = le("Lectura")
                    '    End If

                    '    If Usuarios("lectura") > 0 Then
                    '        _Lectura = Usuarios("lectura")
                    '    Else
                    '        _Lectura = _Lec1
                    '    End If
                    ''
                    '' determina el consumo basado en la resta de la lectura actual - ultima lectura
                    '_Consumo = Math.Abs(_Lectura - _Lec1)
                    'If (_Lectura - _Lec1) < 0 Then
                    '    _Consumo = Vuelta()
                    'End If
                    ''De aqui para arriba es porque no paso bien la lectura anterior

                    ''_Consumo = Usuarios("consumo")
                    '_Cuenta = Usuarios("cuenta")
                    ''If _Cuenta = 102 Then Stop



                    '''ESO PROVOCA EL ERROR PROB
                    '_Sit_Med = ""
                    'Try
                    '    _Sit_Med = Usuarios("sit_med")
                    'Catch ex As Exception

                    'End Try


                    '_Sit_Pad = ""
                    'Try
                    '    _Sit_Pad = Usuarios("Sit_pad")
                    'Catch ex As Exception

                    'End Try


                    '_Sit_Hid = ""
                    'Try
                    '    _Sit_Hid = Usuarios("sit_hid")
                    'Catch ex As Exception

                    'End Try


                    ''C O L O C A R     M A R C A  D O R    A Q U I 
                    'Dim Algo As IDataReader = ConsultaSql("select accion, nodemeses from algoritmos where clave=" & Usuarios("algoritmo")).ExecuteReader
                    'Accion = ""

                    'If Algo.Read() Then
                    '    Accion = Algo("accion")
                    '    MesesPromedio = Algo("nodemeses")
                    'End If


                    '''''''REVISAR BIEN ...
                    'Consume = consumoVerificarAlgoritmo(obtenerCampo("select algoritmo from " & _Tabla & " where cuenta = '" & Cuenta & "'", "algoritmo"))
                    '  Consume = consumoVerificarAlgoritmo(obtenerCampo("select algoritmo from lecturas where cuenta = '" & Cuenta & "' and mes='" & mes & "' and an_per=" & periodo & " ", "algoritmo"))
                    'Ejecucion("Update lecturas set consecutivo = " & Concec & ", sit_pad = '" & _Sit_Pad & "', alerta = " & Alerta & ",  mesespromedio = " & MesesPromedio & ",  consumo = " & _Consumo & " where cuenta = " & _Cuenta & " ")
                    'Ejecucion("Update lecturas,uusario u set l.consecutivo = " & Concec & ", l.sit_pad = '" & _Sit_Pad & "', l.alerta = " & Alerta & ",  l.mesespromedio = " & MesesPromedio & ",  consumo = " & _Consumo & ",montoconsumo = ConsumoMedidosSin(" & Consume & ", u.tarifa) where l.cuenta = " & _Cuenta & " and l.mes='" & mes & "' and l.an_per=" & periodo & " and l.cuenta=u.cuenta; ")
                    'Ejecucion("Update lecturas l,usuario u set l.consecutivo = " & Concec & ", l.sit_pad = '" & _Sit_Pad & "', l.alerta = " & Alerta & ",  l.mesespromedio = " & MesesPromedio & ",  l.consumo =" & _Consumo & ",montoconsumo = ConsumoMedidosSin(" & Consume & ", u.tarifa) where l.cuenta = " & _Cuenta & " and l.mes='" & mes & "' and l.an_per=" & periodo & " and l.cuenta=u.cuenta; ")
                    Ejecucion("Update lecturas l,usuario u set monto = ConsumoMedidos(l.consumo, u.tarifa, periodo), montocobrado =consumomedidos(l.consumocobrado, u.tarifa, periodo) where l.cuenta = " & _Cuenta & " and l.mes='" & mes & "' and l.an_per=" & periodo & ";") 'and l.cuenta=u.cuenta; ")


                    cont += 1
                    Application.DoEvents()
                    'End If
                Loop
                'modificar aki
                'Application.DoEvents()
                ''Ejecucion("update lecturas set montoconsumo = ConsumoMedidosSin(consumocobrado, tarifa) ")
                'Ejecucion("update lecturas, usuario u set  ;")
                'Application.DoEvents()


                Ejecucion("update rutas set calculo = 'S' where id_ruta = '" & _Ruta & "' and id_region = '" & _Region & "' ")
                PB.Visible = False
            Catch ex As Exception
                MessageBoxEx.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MessageBoxEx.Show("No se encontro el archivo de la ruta " & Nom & " para ese mes, necesario para calcular el consumo", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try




        Loop
    End Sub

#End Region




#Region "Algoritmos"
    Public Sub VerificarAlgoritmo(ByVal Nalgoritmo As Integer, ByVal NSituacion As Integer)
        Dim MtsCobrar As Double, Ac As String, Meses As Integer
        Try
            Dim Algo As IDataReader = ConsultaSql("select accion, nodemeses from algoritmos where clave=" & Nalgoritmo).ExecuteReader
            If Algo.Read() Then
                Ac = Algo("accion")
                Meses = Algo("nodemeses")
                Select Case Ac

                    Case "Promediar"
                        Dim ir As IDataReader = ConsultaSql("select promedio(" & _Cuenta & "," & Meses & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                        If NSituacion = 1 Then
                            Meses1 = Meses
                        ElseIf NSituacion = 2 Then
                            Meses2 = Meses
                        ElseIf NSituacion = 3 Then
                            Meses3 = Meses
                        End If
                    Case "Ultimo consumo"
                        Dim ir As IDataReader = ConsultaSql("select Ultimoconsumo(" & _Cuenta & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                    Case "Minimo"
                        Dim ir As IDataReader = ConsultaSql("select minimo(" & _Cuenta & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                    Case "Consumo"
                        MtsCobrar = _Consumo
                    Case "Nuevo"
                        Dim frm As New FrmNuevoMedidor
                        frm.Respuesta = Concec
                        frm.NCapcons.Value = ConCobrado
                        frm.Lectura = _Lectura
                        frm.Cuenta = _Cuenta
                        frm.Comunidad = _Comunidad
                        frm.Nuevo = True
                        frm.tabla = Tabla
                        frm.ShowDialog()
                        Concec = frm.Respuesta
                        MtsCobrar = frm.Consumo
                        Ac = "Nuevo"
                        ConsNuevo = MtsCobrar
                        _bandera = frm.bandera
                    Case "Disparada"
                        Dim frm As New FrmNuevoMedidor
                        frm.Text = "Lectura Disparada"
                        frm.Respuesta = Concec
                        frm.NCapcons.Value = ConCobrado
                        frm.Lectura = _Lectura
                        frm.Cuenta = _Cuenta
                        frm.Comunidad = _Comunidad
                        frm.Consumo = _Consumo
                        frm.Nuevo = False
                        frm.ShowDialog()
                        Concec = frm.Respuesta
                        MtsCobrar = frm.Consumo
                        Ac = "Disparada"
                        ConsNuevo = MtsCobrar
                End Select

                If NSituacion = 1 Then
                    Accion1 = Ac
                    ConsumoCobrar1 = MtsCobrar
                ElseIf NSituacion = 2 Then
                    ConsumoCobrar2 = MtsCobrar
                    Accion2 = Ac
                ElseIf NSituacion = 3 Then
                    ConsumoCobrar3 = MtsCobrar
                    Accion3 = Ac
                End If
            Else
                MsgBox("El algoritmo ha desaparecido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function consumoVerificarAlgoritmo(ByVal Nalgoritmo As Integer, Optional ByVal _tabla As String = "")
        Dim MtsCobrar As Double, Ac As String, Meses As Integer
        Try
            Dim Algo As IDataReader = ConsultaSql("select accion, nodemeses from algoritmos where clave=" & Nalgoritmo).ExecuteReader
            If Algo.Read() Then
                Ac = Algo("accion")
                Meses = Algo("nodemeses")
                Select Case Ac

                    Case "Promediar"
                        'Dim ir As IDataReader = ConsultaSql("select promedio('" & _Comunidad & "'," & _Cuenta & "," & Meses & ")").ExecuteReader
                        Dim ir As IDataReader = ConsultaSql("select promedio(" & _Cuenta & "," & Meses & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                        Return MtsCobrar
                    Case "Ultimo consumo"
                        Dim ir As IDataReader = ConsultaSql("select Ultimoconsumo( " & _Cuenta & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                        Return MtsCobrar
                    Case "Minimo"
                        Dim ir As IDataReader = ConsultaSql("select minimo(" & _Cuenta & ")").ExecuteReader
                        ir.Read()
                        MtsCobrar = ir(0)
                        Return MtsCobrar
                    Case "Consumo"
                        MtsCobrar = _Consumo

                        'MtsCobrar = Me._Lectura
                        Return MtsCobrar
                    Case "Suma_Medidores"

                        Dim mtsconsuacu As Integer
                        Dim ir As IDataReader = ConsultaSql("Select ultimo_consumo from cambiomedidor where cuenta =  " & _Cuenta & "  order by fecha desc limit 1").ExecuteReader
                        If ir.Read Then
                            mtsconsuacu = _Lectura + ir("ultimo_consumo")
                            Return mtsconsuacu
                        End If
                    Case "Nuevo"
                        Return _Lectura
                    Case "Vuelta"
                        Dim ir As IDataReader = ConsultaSql("select UltimaLectura2(" & _Cuenta & ")").ExecuteReader
                        ir.Read()
                        Dim cadena, cadena2 As String
                        cadena = "" & ir(0)
                        cadena2 = ""
                        Dim i As Integer
                        For i = 1 To cadena.Length
                            cadena2 = cadena2 & "9"
                        Next
                        Return (Val(cadena2) - Val(cadena)) + _Lectura
                    Case "Capturar"
                        Dim ir As IDataReader = ConsultaSql("select consumocobrado from lecturas where cuenta=" & _Cuenta & " AND   mes ='" & mes & "' and an_per=" & FrmCapturaLecturas.txtAn.Text & "").ExecuteReader
                        If ir.Read() Then

                            If IsDBNull(ir(0)) Then
                                Return 0
                            Else
                                Return ir(0)
                            End If
                        Else
                            Return 0
                        End If
                    Case Else
                        Return 0
                End Select

                Return 0
            Else

                MsgBox("El algoritmo ha desaparecido")
                Return 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try
    End Function
#End Region

#Region "Crear Temporal"
    Public Sub CreaTemporal()


    End Sub

#End Region

#Region "Aplicar Lecturas"


    Public Function verificaparacerrar() As Boolean

    End Function


    Public Function AplicarLectura(ByVal pb As DevComponents.DotNetBar.Controls.ProgressBarX) As Boolean

    End Function
#End Region

    Public Function Vuelta() As Double
        Dim MtsCobrar As Double
        Dim longi As Integer, Maximo As String = "", NumMax As Integer
        'Anterior _Lec1
        'Actual = lectura
        longi = Val(obtenerCampo("Select digitos from marcasmedidor, usuario where marcamedidor = id_marca and cuenta = " & _Cuenta & " and id_comunidad = '" & _Comunidad & "'", "digitos"))

        For a As Integer = 1 To longi
            Maximo = Maximo & "9"
        Next
        NumMax = Val(Maximo)

        'Digitos en el padron de usuarios formar cadena con 9es
        'a estos restar la lectura anterior y sumar la lectura actual + 1
        MtsCobrar = (NumMax - _Lec1) + (_Lectura + 1)

        Return MtsCobrar
    End Function

    Public Function Filtrar(ByVal Campo As String, ByVal Valor As String, ByVal tipo As String) As String
        If tipo = "S" Then
            '_ConsHijo = "select lecturas.alerta, usuario.cuenta, usuario.id_comunidad, usuario.nombre, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas where usuario.region = '" & _Region & "' and usuario.id_comunidad='" & _Comunidad & "' and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and usuario.id_comunidad = lecturas.comunidad and accion <> 'FIJO' and " & Campo & " like '%" & Valor & "%' order by usuario.numlec asc"
            '_ConsHijo = "select lecturas.alerta, usuario.cuenta,   usuario.id_comunidad, usuario.nombre,usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.montoconsumo as montoconsumo, lecturas.montoiva as montoiva, algoritmos.descrip as algoritmo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas,algoritmos where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and lecturas.accion <> 'FIJO' and " & Campo & " like '%" & Valor & "%' and lecturas.algoritmo=algoritmos.clave order by usuario.numlec asc"
            _ConsHijo = "select lecturas.alerta, usuario.cuenta,  usuario.cuentaAnterior,usuario.tarifa, usuario.id_comunidad, usuario.nombre,usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.monto as montoconsumo,lecturas.montocobrado as montocobrado, lecturas.montoiva as montoiva, algoritmos.descrip as algoritmo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas,algoritmos where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and lecturas.accion <> 'FIJO' and " & Campo & " like '%" & Valor & "%' and lecturas.algoritmo=algoritmos.clave order by usuario.lote,cuenta asc"

        Else
            '_ConsHijo = "select lecturas.alerta, usuario.cuenta, usuario.id_comunidad, usuario.nombre, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas where usuario.region = '" & _Region & "' and usuario.id_comunidad='" & _Comunidad & "' and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and usuario.id_comunidad = lecturas.comunidad and  accion <> 'FIJO' and " & Campo & " = " & Valor & " order by usuario.numlec asc"
            '_ConsHijo = "select lecturas.alerta, usuario.cuenta, usuario.id_comunidad, usuario.nombre,usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.montoconsumo as montoconsumo, lecturas.montoiva as montoiva, algoritmos.descrip as algoritmo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas, algoritmos where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and  lecturas.accion <> 'FIJO' and " & Campo & " = " & Valor & "  and lecturas.algoritmo=algoritmos.clave order by usuario.numlec asc"
            _ConsHijo = "select lecturas.alerta, usuario.cuenta,usuario.cuentaAnterior, usuario.tarifa, usuario.id_comunidad, usuario.nombre,usuario.manzana as mzn, cast(usuario.lote as unsigned ) as lote, lecturas.lectura, lecturas.sit_med, lecturas.sit_pad, lecturas.sit_hid, lecturas.observa, lecturas.consumo, lecturas.consumocobrado as consumocobrado, lecturas.accion as accion, lecturas.monto as montoconsumo,lecturas.montocobrado as montocobrado, lecturas.montoiva as montoiva, algoritmos.descrip as algoritmo, lecturas.algoritmo as alg FROM usuario, " & _Tabla & " as lecturas, algoritmos where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta and  lecturas.accion <> 'FIJO' and " & Campo & " = " & Valor & "  and lecturas.algoritmo=algoritmos.clave order by usuario.lote,cuenta asc"
        End If

        Filtrar = _ConsHijo
    End Function


#Region "Exportar e Importar de la Terminal portatil"



    Public Shared Sub Exportar(ByVal PB As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal _pRegion As String, ByVal _pRuta As String, ByVal _Destino As String, ByVal _mes As String, ByVal periodo As Integer)

        CrearXml("select vusuario.cuenta, vusuario.nombre, vusuario.tarifa, vusuario.Direccion, vusuario.id_comunidad, nodemedidor,Giro, region,ruta,ultimaLecturaexp(vusuario.cuenta,'" & _mes & "'," & periodo & " ) as LecturaAct,concat(vusuario.region,'-',vusuario.ruta,'-',manzana,'-',vusuario.lote) as ubicacion, vusuario.total as saldo ,ajustecon(vusuario.cuenta) as mtscobrados, ultimaLecturaexp(vusuario.cuenta,'" & _mes & "'," & periodo & " ) as ultimabuena, promedio(vusuario.cuenta,3) as promedio , vusuario.cuenta as llave, nMontoValvulista as valvulista, vusuario.alcantarillado as alcantarillado, vusuario.saneamiento as saneamiento, vusuario.nodeperiodo as nodeperiodo, vusuario.manzana, vusuario.lote from ccuotavalvulista, vusuario JOIN cuotas ON(vusuario.tarifa = cuotas.id_tarifa) where vusuario.mostrar<>'0' and cuotas.medido <> 0 AND vusuario.Region = '" & _pRegion & "' and vusuario.ruta in(" & _pRuta & ") and ccuotavalvulista.idCuotaValvulista=vusuario.idcuotavalvulista order by ruta,manzana,vusuario.lote", "Lecturas", _Destino)

        CrearXml("select id_tarifa,Descripcion_Cuota,IVA,ivaacon,ivaalca,ivasane,consumomin,memoria,alcantarillado,saneamiento from cuotas where medido <> 0 ", "Cuotas", _Destino)
        CrearXml("select id_tarifa,rango_inf,rango_sup,tarifa_agua,tarifa_alcant,tarifa_sanea from medidor where anofiscal=" & Now.Year, "Medidor", _Destino)
        CrearXml("select * from algoritmos", "Algoritmos", _Destino)
        CrearXml("select * from situacion", "Situacion", _Destino)
        CrearXml("select id_ruta,ruta, id_region,'1' as  id_comunidad from rutas WHERE id_region='" & _pRegion & "' and id_ruta in(" & _pRuta & ")", "RUTAS", _Destino)

        MessageBox.Show("Archivos Xml creados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)





    End Sub
#End Region




#Region "Buscar"
    Public Function Buscar(ByVal Cuenta As Integer) As Boolean
        Dim Encontrado As Boolean = False

        Do While Encontrado = False
            Application.DoEvents()
            If Padre.Read Then
                If Padre("cuenta") = Cuenta Then
                    _Cuenta = Padre("cuenta")
                    _Nombre = Padre("nombre")
                    _Estado = Padre("Estado")
                    _Medidor = Padre("nodemedidor")
                    _Direccion = Padre("direccion") & ", " & Padre("Colonia")
                    _Anterior = Padre("lecturaact")
                    _Tarifa = Padre("descripcion_cuota")
                    Cuota = Padre("tarifa") ' obtenerCampo("Select id_tarifa from cuotas where descripcion_cuota = '" & Padre("descripcion_cuota") & "'", "id_tarifa")
                    _NumLec = Padre("numlec")
                    _Manzana = Padre("manzana")
                    _Lote = Padre("Lote")
                    Sector = Padre("sector")
                    ' cuentaAnterior = Padre("cuentaAnterior")
                    _Lec2 = 0
                    _Lec1 = 0
                    Dim le As IDataReader = ConsultaSql("Select lectura , valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & _Cuenta & "  order by ordenado desc limit 2").ExecuteReader
                    Application.DoEvents()
                    Do While le.Read
                        If _Lec2 = 0 Then
                            _Lec2 = le("Lectura")
                        Else
                            _Lec1 = le("Lectura")
                        End If
                    Loop
                    Buscar = True
                    Encontrado = True
                    If CapVeri = Viene.Verificacion Then
                        Dim Veri As IDataReader
                        Try
                            Veri = ConsultaSql("Select lectura, sit_hid, sit_med, sit_pad, observa from " & _Tabla & " where cuenta = " & _Cuenta & " ").ExecuteReader
                        Catch ex As Exception
                            MessageBoxEx.Show("Aun no se ha creado el archivo de lecturas " & _Tabla & "", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            _Nombre = ""
                            _Cuenta = 0
                            _Estado = ""
                            _Medidor = ""
                            _Direccion = ""
                            _Anterior = 0
                            _Tarifa = ""
                            Cuota = ""
                            _NumLec = 0
                            _Manzana = ""
                            _Lote = ""
                            Sector = ""
                            cuentaAnterior = ""
                            Exit Function
                        End Try
                        If Veri.Read() Then
                            _Lectura = Veri("lectura")
                            _Sit_Hid = Veri("sit_hid")
                            _Sit_Med = Veri("sit_med")
                            _Sit_Pad = Veri("sit_pad")
                            _Observacion = Veri("observa")
                        Else
                            _Lectura = -1
                            _Sit_Hid = ""
                            _Sit_Med = ""
                            _Sit_Pad = ""
                            _Observacion = ""
                        End If
                        Encontrado = True
                    End If
                End If
            Else
                Encontrado = True
                Buscar = False
            End If
        Loop
        If Buscar = False Then
            'Verificar si esta dentro del temporal
            Dim ver As IDataReader = ConsultaSql("Select * from lecturas where cuenta = " & Cuenta & " and mes='" & mes & "' and an_per=" & periodo).ExecuteReader
            If ver.Read Then
                MessageBoxEx.Show("La lectura para ese usuario ya fue capturada", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GoTo Salir
            End If
            ver = ConsultaSql("Select * from vusuario where cuenta = " & Cuenta & " ").ExecuteReader
            If ver.Read() Then
                If ver("estado").ToString.ToLower <> "activo" Then
                    MessageBoxEx.Show("La cuenta del usuario no esta activa en esta region, por lo cual no se pueden capturar lecturas", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo Salir
                End If
                MessageBoxEx.Show("La cuenta se encuentra en la ruta " & ver("ruta") & " de la region " & ver("region") & ", Verifique su informacion", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GoTo Salir

            Else
                MessageBoxEx.Show("La cuenta del usuario no existe", "Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Information)

Salir:
                CreaConsultausuario()
                Avanzar()
            End If
        End If
    End Function

    Public Function Avanzar() As Boolean
        Application.DoEvents()
        Try
            If Padre.Read Then

                _Nombre = Padre("nombre")
                _Cuenta = Padre("cuenta")
                Dim xcl As Boolean = True
                Do While (xcl)
                    Dim datos2 As IDataReader = ConsultaSql("select *  FROM usuario, lecturas where usuario.region = '" & _Region & "'  and usuario.ruta='" & _Ruta & "' and usuario.cuenta = lecturas.cuenta  and mes ='" & mes & "' and an_per='" & periodo & "' and lecturas.cuenta=" & _Cuenta).ExecuteReader()
                    If (datos2.Read) Then
                        If Padre.Read() Then
                            _Nombre = Padre("nombre")
                            _Cuenta = Padre("cuenta")

                        Else
                            xcl = False
                        End If

                    Else
                        xcl = False
                    End If
                Loop
                _Estado = Padre("Estado")
                _Medidor = Padre("nodemedidor")
                _Direccion = Padre("direccion") & ", " & Padre("Colonia")
                _Anterior = Padre("lecturaact")
                _Tarifa = Padre("descripcion_cuota")
                Cuota = Padre("tarifa") 'obtenerCampo("Select id_tarifa from cuotas where descripcion_cuota = '" & Padre("descripcion_cuota") & "'", "id_tarifa")
                _NumLec = Padre("numlec")
                _Manzana = Padre("manzana")
                _Lote = Padre("Lote")
                Sector = Padre("sector")
                '   cuentaAnterior = Padre("cuentaAnterior")
                _Lec2 = 0
                _Lec1 = 0
                'If _Cuenta = 8777 Then Stop
                Dim le As IDataReader = ConsultaSql("Select lectura , LectAnt, valornummes(mes, an_per) as ordenado  from lecturas where cuenta = " & _Cuenta & "  order by ordenado desc limit 1").ExecuteReader
                le.Read()
                'Do While le.Read
                '    If _Lec2 = 0 Then
                '        _Lec2 = le("Lectura")
                '    Else
                '        _Lec1 = le("Lectura")
                '    End If
                'Loop
                Try
                    _Lec2 = le("Lectura")
                    _Lec1 = le("LectAnt")
                Catch ex As Exception

                End Try

                Avanzar = True

            Else
                'MessageBoxEx.Show("Se han capturado todas las lecturas de la ubicacion seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Avanzar = False
            End If
        Catch ex As Exception

        End Try

    End Function
#End Region

    Function tablatem(ByVal REGION As String, ByVal RUTA As String) As String
        Return String.Concat("Lecturas")
    End Function
End Class
