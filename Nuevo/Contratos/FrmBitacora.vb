Public Class FrmBitacora
    Public cuenta As String

    Private Sub FrmBitatoca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & cuenta).ExecuteReader
        cons.Read()
        LblCuenta.Text = cuenta

        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("Direccion")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")

        Dim cons2 As IDataReader = ConsultaSql("Select * from Bitacora where cuenta = " & cuenta & " order by fecha desc").ExecuteReader

        While cons2.Read
            Dim node As New DevComponents.AdvTree.Node
            node.Cells.Item(0).Text = cons2("Fecha")
            Dim celda As New DevComponents.AdvTree.Cell
            celda.Text = cons2("Hora")
            node.Cells.Add(celda)
            Dim celdaconcepto As New DevComponents.AdvTree.Cell

            Dim control As New DevComponents.DotNetBar.Controls.TextBoxX

            control.Multiline = True
            control.Text = cons2("concepto")
            celdaconcepto.HostedControl = control
            node.Cells.Add(celdaconcepto)

            Dim celdamotivo As New DevComponents.AdvTree.Cell
            celdamotivo.Text = cons2("Motivo")
            node.Cells.Add(celdamotivo)

            Dim usuario As String = obtenerCampo(" select * from letras where ccodusuario=" & cons2("usuario"), "Nombre")

            Dim celdausuario As New DevComponents.AdvTree.Cell
            celdausuario.Text = usuario
            node.Cells.Add(celdausuario)

            AdvBitacora.Nodes.Add(node)
        End While



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub
End Class