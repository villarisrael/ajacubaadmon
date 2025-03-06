Imports System.Data.Odbc

Public Class ConvenioPago

    Public Property idConvenio As Integer
    Public Property IdCuenta As Integer
    Public Property Nombre As String

    Public Property Domicilio As String
    Public Property Ubicacion As String
    Public Property Colonia As String

    Public Property Tarifa As String
    Public Property Telefono As String
    Public Property TotalDeuda As Decimal
    Public Property NuevoAdeudo As Decimal
    Public Property NumeroPagos As Integer
    Public Property Aplazamiento As Integer = 0

    Public Property Descuento As Decimal

    Public Property PeriodosAdeudados As Integer

    Public Property Mes As String
    Public Property Estado As String = "Activo"
    Public Property Periodo As Integer

    Public convenio As Boolean

    Public fechacreacion As Date

    Public Property Pagos As List(Of PagoConvenio)

    Public Sub New()
        Me.IdCuenta = "0"
        Me.Nombre = String.Empty
        Me.Telefono = String.Empty
        Me.TotalDeuda = 0
        Me.NuevoAdeudo = 0
        Me.NumeroPagos = 0
        Me.PeriodosAdeudados = 0
        Me.Descuento = 0
    End Sub

    ' Constructor
    Public Sub New(idCuenta As Integer, nombre As String, telefono As String, totalDeuda As Decimal, _PeriodosAdeduados As Int32)
        Me.IdCuenta = idCuenta
        Me.Nombre = nombre
        Me.Telefono = telefono
        Me.TotalDeuda = totalDeuda
        Me.NuevoAdeudo = totalDeuda
        Me.NumeroPagos = 0
        Me.PeriodosAdeudados = _PeriodosAdeduados
        Me.Descuento = 0
    End Sub

    '' Método para aplicar un descuento
    'Public Sub AplicarDescuento(porcentaje As Decimal)
    '    Me.Descuento = porcentaje
    '    Me.NuevoAdeudo = TotalDeuda - (TotalDeuda * (porcentaje / 100))
    'End Sub

    '' Método para calcular los pagos
    'Public Function CalcularPagos(numeroPagos As Integer) As List(Of Decimal)
    '    Me.NumeroPagos = numeroPagos
    '    Dim pagos As New List(Of Decimal)
    '    Dim pagoMensual As Decimal = NuevoAdeudo / numeroPagos
    '    For i As Integer = 1 To numeroPagos
    '        pagos.Add(Math.Round(pagoMensual, 2))
    '    Next
    '    Return pagos
    'End Function



End Class

Public Class PagoConvenio
    Public Property IdPago As Integer
    Public Property FechaPago As DateTime
    Public Property Monto As Decimal
    Public Property Pagado As Boolean
    Public Property NoPagare As String
End Class
