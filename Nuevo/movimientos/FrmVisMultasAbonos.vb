Public Class FrmVisMultasAbonos
    Dim _Clave As Double
    Public Property Clave() As String
        Get
            Return _Clave
        End Get
        Set(ByVal value As String)
            _Clave = value
        End Set
    End Property


    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub FrmVisMultasAbonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ir As IDataReader = ConsultaSql("Select * from otrosconceptos where clave = '" & _Clave & "'").ExecuteReader
        ir.Read()
        If ir("Tipo_mov") = "Cargo" Then
            Text = "Visualizar Cargo"
        Else
            Text = "Visualizar Abono"
        End If
        LblCuenta.Text = ir("Cuenta")
        LblComunidad.Text = obtenerCampo("Select comunidad from comunidades where id_comunidad = '" & ir("id_comunidad") & "'", "Comunidad")

        'Datos del usuario
        Dim usu As IDataReader = ConsultaSql("Select * from vusuario where comunidad = '" & LblComunidad.Text & "' and cuenta = " & LblCuenta.Text & "").ExecuteReader
        usu.Read()
        LBLNOMBRE.Text = usu("nombre")
        LblDireccion.Text = usu("Calle") & ", " & usu("numext") & ", " & usu("numint") & ", " & usu("Colonia")
        LblGiro.Text = usu("giro")
        LblTarifa.Text = usu("descripcion_cuota")
        LblEstado.Text = usu("estado")
        usu.Close()

        LblConcepto.Text = ir("concepto")
        LblFecha.Text = ir("fec_alta")
        TxtFolio.Text = Clave

        LblMotivo.Text = ir("motivo")
        LblVencimiento.Text = ir("vencimiento")

        LblSubTotal.Text = FormatCurrency(ir("subtotal"), 2)
        LblIVA.Text = FormatCurrency(ir("iva"), 2)
        LblTotal.Text = FormatCurrency(ir("Total"), 2)

        LblAbonos.Text = FormatCurrency(ir("Abonos"), 2)
        LblResta.Text = FormatCurrency(ir("Resta"), 2)
    End Sub
End Class