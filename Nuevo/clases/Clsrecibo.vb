Public Class Clsrecibo
    Private _Cuenta As Long
    Private _comunidad As String
    Private _subtotal As Double
    Private _iva As Double
    Private _total As Double
    Private _otros As Double
    Private _otrostotal As Double
    Private _rezagos As Double
    Private _recargos As Double
    Private _consumo As Double
    Private _alcantarillado As Double
    Private _saneamiento As Double
    Private _redondeo As Double
    Private _redondear As Boolean
    Private _recargosotros As Double
    Private _aplicaotros As Boolean
    Private _aplicaconsumo As Boolean
    Private _descuento As Double
    Private _anticipo As Double
    Private _arriba As Boolean


#Region "modificadores de acceso"
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
            Return _comunidad
        End Get
        Set(ByVal value As String)
            _comunidad = value
        End Set
    End Property
    Public Property Consumo() As Double
        Get
            Return _consumo
        End Get
        Set(ByVal value As Double)
            _consumo = value
            SUMAR()
        End Set
    End Property
    Public Property descuento() As Double
        Get
            Return _descuento
        End Get
        Set(ByVal value As Double)
            _descuento = value
            SUMAR()
        End Set
    End Property
    Public Property recargos() As Double
        Get
            Return _recargos
        End Get
        Set(ByVal value As Double)
            _recargos = value
            SUMAR()
        End Set
    End Property
    Public Property recargosotros() As Double
        Get
            Return _recargosotros
        End Get
        Set(ByVal value As Double)
            _recargosotros = value
            SUMAR()
        End Set
    End Property

    Public Property otros() As Double
        Get

            Return _otros

        End Get
        Set(ByVal value As Double)
            _otros = value
            SUMAR()
        End Set
    End Property
    Public Property otrostotal() As Double
        Get

            Return _otrostotal

        End Get
        Set(ByVal value As Double)
            _otrostotal = value

        End Set
    End Property
    Public Property Recargo() As Double
        Get
            Return _recargos
        End Get
        Set(ByVal value As Double)
            _recargos = value
            SUMAR()
        End Set
    End Property
    Public Property Alcantarillado() As Double
        Get
            Return _alcantarillado
        End Get
        Set(ByVal value As Double)
            _alcantarillado = value
            SUMAR()
        End Set
    End Property
    Public Property Saneamiento() As Double
        Get
            Return _saneamiento
        End Get
        Set(ByVal value As Double)
            _saneamiento = value
            SUMAR()
        End Set
    End Property
    Public Property Subtotal() As Double
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Double)
            _subtotal = value
            SUMAR()
        End Set
    End Property
    Public Property IVA() As Double
        Get
            Return _iva
        End Get
        Set(ByVal value As Double)
            _iva = value
            SUMAR()
        End Set
    End Property
    Public Property Total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value

        End Set
    End Property
    Public Property rezagos() As Double
        Get
            Return _rezagos
        End Get
        Set(ByVal value As Double)
            _rezagos = value
            SUMAR()
        End Set
    End Property

    Public Property anticipo() As Double
        Get
            Return _anticipo
        End Get
        Set(ByVal value As Double)
            _anticipo = value
            SUMAR()
        End Set
    End Property

    Public Property redondeo() As Double
        Get
            Return _redondeo
        End Get
        Set(ByVal value As Double)
            _redondeo = value
            SUMAR()
        End Set
    End Property

    Public Property redondear() As Boolean
        Get
            Return _redondear
        End Get
        Set(ByVal value As Boolean)
            _redondear = value
            SUMAR()
        End Set
    End Property

    Public Property aplicaotros() As Boolean
        Get
            Return _aplicaotros
        End Get
        Set(ByVal value As Boolean)
            _aplicaotros = value
            SUMAR()

        End Set
    End Property
    Public Property arriba() As Boolean
        Get
            Return _arriba
        End Get
        Set(ByVal value As Boolean)
            _arriba = value
            SUMAR()

        End Set
    End Property

    Public Property aplicaconsumo() As Boolean
        Get
            Return _aplicaconsumo
        End Get
        Set(ByVal value As Boolean)
            _aplicaconsumo = value
            SUMAR()
        End Set
    End Property


#End Region

    Public Sub limpiar()
        Me.Alcantarillado = 0
        Me.anticipo = 0
        Me.aplicaconsumo = False
        Me.aplicaotros = False
        Me.Comunidad = ""
        Me.Consumo = 0
        Me.Cuenta = 0
        Me.descuento = 0
        Me.IVA = 0
        Me.otros = 0
        Me.otrostotal = 0
        Me.Recargo = 0
        Me.recargos = 0
        Me.recargosotros = 0
        Me.redondear = False
        Me.redondeo = 0
        Me.rezagos = 0
        Me.Saneamiento = 0
        Me.Subtotal = 0
        Me.Total = 0
    End Sub


    Private Sub SUMAR()
        _redondeo = 0
        ' caseo de que pague otros y pague consumo
        If _aplicaotros And _aplicaconsumo Then

            _subtotal = _otros + _anticipo + _consumo + _saneamiento + _alcantarillado + _rezagos + _recargos + _recargosotros - descuento
            _total = _subtotal + _iva

            If _redondear Then

                If Not _arriba Then
                    _redondeo = Math.Round(((_total - Int(_total)) * -1), 2)
                Else
                    _redondeo = Math.Round((1 - (_total - Int(_total))), 2)
                End If
                If _redondeo = 1 Then
                    _redondeo = 0
                End If
            Else
                _redondeo = 0
            End If

            _subtotal = _otros + _redondeo + _anticipo + _consumo + _saneamiento + _alcantarillado + _rezagos + _recargos + _recargosotros - descuento
            _total = _subtotal + _iva

        End If

        ' caso de que no pague otros y ague consumo

        If Not _aplicaotros And _aplicaconsumo Then
            _subtotal = _anticipo + _consumo + _saneamiento + _alcantarillado + _rezagos + _recargos - descuento
            _total = _subtotal + _iva

            If redondear Then
                If Not _arriba Then
                    _redondeo = Math.Round(((_total - Int(_total)) * -1), 2)
                Else
                    _redondeo = Math.Round((1 - (_total - Int(_total))), 2)
                End If

                If _redondeo = 1 Then _redondeo = 0
             
            Else
                _redondeo = 0
                
            End If

            _subtotal = _redondeo + _anticipo + _consumo + _saneamiento + _alcantarillado + _rezagos + _recargos + -descuento
            _total = _subtotal + _iva
        End If

        ' caso de que pague otros y no pague consumo

        If _aplicaotros And Not _aplicaconsumo Then
            _subtotal = _otros + _recargosotros - _descuento
            _total = _subtotal + _iva
            If redondear Then
                If Not _arriba Then
                    _redondeo = Math.Round(((_total - Int(_total)) * -1), 2)
                Else
                    _redondeo = Math.Round((1 - (_total - Int(_total))), 2)
                End If
                If _redondeo = 1 Then _redondeo = 0

            Else
                _redondeo = 0

            End If

            _subtotal = _otros + _redondeo + _recargosotros - _descuento

            _total = _subtotal + _iva

        End If

        ' caso de que no paque nada
        If Not _aplicaotros And Not _aplicaconsumo Then
            _alcantarillado = 0
            _anticipo = 0
            ' Me.aplicaconsumo = False
            _aplicaotros = False
            ' Me.Comunidad = ""
            _consumo = 0
            ' Me.Cuenta = 0
            _descuento = 0
            _iva = 0
            _otros = 0
            _otrostotal = 0
            _recargos = 0
            _otros = 0
            _recargosotros = 0
            ' Me.redondear = False
            _redondeo = 0
            _rezagos = 0
            _saneamiento = 0
            _subtotal = 0
            _total = 0

        End If

    End Sub


    Public Sub New()
        limpiar()
    End Sub


End Class

