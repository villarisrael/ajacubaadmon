Public Class ClsMedidor
#Region "Variables"
    Private _Cuenta As Double
    Private _Comunidad As String
    Private _Situacion1 As String
    Private _Situacion2 As String
    Private _Situacion3 As String
    Private _Mes As Date
    Private _Actual As Double
    Private _Anterior As Double
    Private _Consumo As Double


    Dim EstadoFinal1 As Integer
    Dim ConsumoCobrar1 As Double
    Dim Accion1 As String

    Dim EstadoFinal2 As Integer
    Dim ConsumoCobrar2 As Double
    Dim Accion2 As String

    Dim EstadoFinal3 As Integer
    Dim ConsumoCobrar3 As Double
    Dim Accion3 As String

    Dim Accion As String
    Dim Tarifa As String
#End Region

#Region "Modificadores de Acceso"
    Public Property Anterior() As Double
        Get
            Return _Anterior
        End Get
        Set(ByVal value As Double)
            _Anterior = value
        End Set
    End Property
    Public Property Actual() As Double
        Get
            Return _Actual
        End Get
        Set(ByVal value As Double)
            _Actual = value
        End Set
    End Property
    Public Property Mes() As Date
        Get
            Return _Mes
        End Get
        Set(ByVal value As Date)
            _Mes = value
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
    Public Property Situacion1() As String
        Get
            Return _Situacion1
        End Get
        Set(ByVal value As String)
            _Situacion1 = value
        End Set
    End Property
    Public Property Situacion2() As String
        Get
            Return _Situacion2
        End Get
        Set(ByVal value As String)
            _Situacion2 = value
        End Set
    End Property
    Public Property Situacion3() As String
        Get
            Return _Situacion3
        End Get
        Set(ByVal value As String)
            _Situacion3 = value
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
#End Region

#Region "Registro de lecturas"
    Public Sub registrar()
        Dim Alerta As Double

        Tarifa = obtenerCampo("select tarifa from usuario where cuenta = " & _Cuenta & " and id_comunidad = '" & _Comunidad & "'", "tarifa")

        Dim Consume As Double, Estado As Integer
        If _Situacion1 <> "" Then
            _Consumo = Math.Abs(_Actual - _Anterior)
            VerificarAlgoritmo(obtenerCampo("select algoritmo from situacion where clave = '" & _Situacion1 & "' ", "algoritmo"), 1)
        End If
        If _Situacion2 <> "" Then
            _Consumo = Math.Abs(_Actual - _Anterior)
            VerificarAlgoritmo(obtenerCampo("select algoritmo from situacion where clave = '" & _Situacion2 & "' ", "algoritmo"), 2)
        End If
        If _Situacion3 <> "" Then
            _Consumo = Math.Abs(_Actual - _Anterior)
            VerificarAlgoritmo(obtenerCampo("select algoritmo from situacion where clave = '" & _Situacion3 & "' ", "algoritmo"), 3)
        End If

        If ConsumoCobrar1 > ConsumoCobrar2 Then
            If ConsumoCobrar1 > ConsumoCobrar3 Then
                Accion = Accion1
                Consume = ConsumoCobrar1
                Estado = EstadoFinal1
            Else
                Accion = Accion3
                Consume = ConsumoCobrar3
                Estado = EstadoFinal3
            End If
        ElseIf ConsumoCobrar2 > ConsumoCobrar3 Then
            Accion = Accion2
            Estado = EstadoFinal2
            Consume = ConsumoCobrar2
        ElseIf ConsumoCobrar3 Then
            Estado = EstadoFinal3
            Accion = Accion3
            Consume = ConsumoCobrar3
        End If
        Alerta = Val(obtenerCampo("Select Altcap from cuotas where id_tarifa = '" & Tarifa & "'", "Altcap"))
        If Consume > Alerta Then
            MsgBox("El consumo supera los " & Alerta & " M3", MsgBoxStyle.Information, "")
        End If
        Ejecucion("insert into lecturas(cuenta, comunidad, lecturaactual, lecturaanterior, Consumo, Situacion1, situacion2, situacion3, mes, accion) values (" & _Cuenta & ", '" & _Comunidad & "', " & _Actual & ", " & _Anterior & ", " & Consume & ", '" & _Situacion1 & "', '" & _Situacion2 & "', '" & _Situacion3 & "',  '" & UnixDateFormat(_Mes) & "', '" & Accion & "' )")
        Ejecucion("update usuario set LecturaAct = " & _Actual & ", LecturaAnt = " & _Anterior & ", estadomedidor = " & Estado & " where cuenta=" & _Cuenta)
    End Sub
#End Region

#Region "Algoritmos"
    Public Sub VerificarAlgoritmo(ByVal Nalgoritmo As Integer, ByVal NSituacion As Integer)
        'Dim Consumo As Double, 
        Dim MtsCobrar As Double, estado As Integer
        Dim Ac As String, Meses As Integer, Descripcion As String
        Try
            Dim Algo As IDataReader = ConsultaSql("select accion, nodemeses, cambiarestadoa, descrip from algoritmos where clave=" & Nalgoritmo).ExecuteReader
            If Algo.Read() Then
                Ac = Algo("accion")
                Meses = Algo("nodemeses")
                Estado = Val(Algo("cambiarestadoa"))
                Descripcion = Algo("descrip")
                Select Case Ac
                    Case "Promediar"
                        MtsCobrar = promediar(Meses)
                    Case "Ultimo consumo"
                        MtsCobrar = ultimalectura()
                    Case "Minimo"
                        MtsCobrar = Minimo()
                    Case "Consumo"
                        MtsCobrar = _Consumo
                    Case "Nuevo"
                        _Anterior = Val(InputBox("Escribe la lectura inicial del medidor de la cuenta " & _Cuenta, "Constesta por favor", 0))
                        MtsCobrar = _Actual - _Anterior
                    Case "Vuelta"
                        Dim cadenalectura As String, cadenavuelta As String, tope As Long
                        cadenavuelta = ""
                        cadenalectura = _Anterior
                        Dim longi As Integer, i As Integer
                        longi = Len(cadenalectura)
                        If longi >= 1 Then
                            cadenavuelta = "1"
                            For i = 1 To longi
                                cadenavuelta = cadenavuelta & "0"
                            Next i
                            tope = Val(cadenavuelta)
                            MtsCobrar = (tope - _Anterior) + _Actual
                        Else
                            MtsCobrar = _Consumo
                        End If
                End Select
                If NSituacion = 1 Then
                    Accion1 = Ac
                    EstadoFinal1 = Estado
                    ConsumoCobrar1 = MtsCobrar
                ElseIf NSituacion = 2 Then
                    EstadoFinal2 = Estado
                    ConsumoCobrar2 = MtsCobrar
                    Accion2 = Ac
                ElseIf NSituacion = 3 Then
                    EstadoFinal3 = Estado
                    ConsumoCobrar3 = MtsCobrar
                    Accion3 = Ac
                End If
            Else
                MsgBox("El algoritmo a desaparecido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "Acciones"

    Public Function promediar(ByVal NMeses As Integer)
        Try
            promediar = Val(obtenerCampo("select avg(consumo) as prom from lecturas where cuenta=" & _Cuenta & " order by mes desc limit " & NMeses, "Prom"))
        Catch ex As Exception
            MsgBox(ex.Message)
            promediar = 0
        End Try
    End Function

    Public Function Minimo()
        Try
            Minimo = Val(obtenerCampo("select cuotas.consumomin as consumomin from usuario, cuotas where cuenta=" & _Cuenta & " and cuotas.id_tarifa=usuario.tarifa ", "consumomin"))
        Catch ex As Exception
            minimo = 0
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ultimalectura()
        Try
            ultimalectura = Val(obtenerCampo("select consumo from lecturas where cuenta=" & _Cuenta & " order by mes desc limit 1 ", "consumo"))
        Catch ex As Exception
            ultimalectura = 0
            MsgBox(ex.Message)
        End Try
    End Function

    'Function ultimalectura() As Double
    '    ultimalectura = dat.obtenerCampo("select lectura from lecturas where cuenta=" & m_Cuenta & " order by mes asc limit 1", "lecturas")
    'End Function

    Function ultimomeslectura() As String
        ultimomeslectura = obtenerCampo("select mes from lecturas where cuenta=" & _Cuenta & " and pagado order by fecha desc", "mes")
    End Function

    Function lecturadelmes(ByVal meslectura As String) As Double
        lecturadelmes = obtenerCampo("select lectura from lecturas where cuenta=" & _Cuenta & " and mes='" & UnixDateFormat(meslectura) & "'", "Lectura")
    End Function

    Function consumodelmes(ByVal meslectura As String) As Double
        consumodelmes = obtenerCampo("select consumo from lecturas where cuenta=" & _Cuenta & " and mes='" & UnixDateFormat(meslectura) & "'", "CONSUMO")
    End Function
#End Region

End Class
