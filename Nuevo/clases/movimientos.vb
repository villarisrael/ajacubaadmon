Public Class movimientos
    'Public conexion As New ClassConectar
    Public documento As New documento
    Public consumo As New consumo
    Public cuota As String
    Public id_comunidad As String
    Public folio_contrato As Long


    Public Sub cargo(ByVal fecha As Date, ByVal Descripcion As String, ByVal monto As Double, ByVal idconcepto As String)
        Dim movi As New moviprev
        movi.tipo = moviprev.tipomov.Cargo
        Dim concepto As String
        concepto = obtenerCampo("select * from conceptoscxc where id_concepto='" & idconcepto & "'", "descripcion")
        Dim saldoanterior As Double = obtenerCampo(" select saldo from usuario where id_comunidad='" & id_comunidad & "' and cuenta=" & folio_contrato, "saldo")
        Dim saldoactual = saldoanterior + monto
        cuota = obtenerCampo(" select cuota from usuario where id_comunidad='" & id_comunidad & "' and cuenta=" & folio_contrato, "cuota")


    End Sub

    Public Sub abono(ByVal fecha As Date, ByVal descripcion As String, ByVal monto As Double, ByVal idconcepto As String)

    End Sub

    Public Sub agregamovimiento()

    End Sub

    Public Sub New()
        cuota = ""
    End Sub
End Class

Public Class moviprev
    Public idconcepto As String
    Public concepto As String
    Public tipo As tipomov
    Public descconcepto As String
    Public descdetalle As String


    Enum tipomov
        Cargo
        Abono
    End Enum
End Class

Public Class documento
    Public descripcion As String
    Public serie As String
    Public numero As Long

   
    Public Sub New()
        numero = 0
        serie = ""
        descripcion = ""
    End Sub
End Class

Public Class consumo
    Public servicio As Double
    Public recargo As Double
    Public rezago As Double
    Public alcantarillado As Double
    Public saneamiento As Double
    Public subtotal As Double
    Public iva As Double
    Public total As Double
    Public cobrariva As Double


    Public Sub suma()
        subtotal = Math.Round(servicio + recargo + rezago + alcantarillado + saneamiento, 2)
        If cobrariva = True Then
            iva = Math.Round(subtotal * 0.15, 2)
        Else
            iva = 0
        End If
        total = subtotal + iva
    End Sub


    Public Sub New()
        alcantarillado = 0
        recargo = 0
        rezago = 0
        saneamiento = 0
        subtotal = 0
        servicio = 0
        total = 0

    End Sub
End Class