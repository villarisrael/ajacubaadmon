Imports DevComponents.DotNetBar

Public Class frmListMultas
    Dim idletras As IDataReader = Nothing

    Private Sub frmListMultas_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.tabcobros.Select()
    End Sub

    Private Sub frmListMultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idletras = ConsultaSql("select * from letras where ccodusuario=" & NumUser & "").ExecuteReader()
        idletras.Read()

        'If CBool(idletras("Agregamulta")) Then cmdAgregar.Visible = True Else cmdAgregar.Visible = False
        'If CBool(idletras("calcelamulta")) Then cmdEliminar.Visible = True Else cmdEliminar.Visible = False
        'If CBool(idletras("editamulta")) Then cmdEditar.Visible = True Else cmdEditar.Visible = False

        Dim columna As New System.Windows.Forms.DataGridViewCheckBoxColumn
        columna.Name = "Pagado"
        columna.DataPropertyName = "Pagado"
        columna.HeaderText = "Pagado"
        CatControl1.dgDAt.Columns.Add(columna)
        'CatControl1.filtrar("select Clave, Estado, Concepto, Fec_Alta as Fecha, Cuenta, Comunidad as Comunidad, Nombre as Nombre, Colonia as Colonia, Calle as Calle, NumExt as 'Número Exterior', NumInt as 'Número Interior', Pagado as Pagado, total as Total, resta as Resta from VMultas where fec_alta>='" & UnixDateFormat(DateAdd("m", -3, Now)) & "' order by Clave")
        Act()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Try
            Dim est As String = obtenerCampo("Select estado from otrosconceptos where clave = " & CatControl1.darSeleccionado("clave") & "", "Estado")
            Select Case est
                Case "Cancelado", "Aplicado"
                    MessageBoxEx.Show("La multa : " & CatControl1.darSeleccionado("clave") & " no se puede modificar debido a que su estado es " & est & "", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "Pendiente"
                    Dim FRM As New frmagrmov(eve.Multas, frmagrmov.acceso.Modificar, CatControl1.darSeleccionado("Clave"))
                    FRM.ShowDialog()
                    Act()
                Case "Abonado"
                    MessageBoxEx.Show("No se puede editar este cargo por que ya se hizo un abono", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Try
            Dim est As String = obtenerCampo("Select estado from otrosconceptos where clave = " & CatControl1.darSeleccionado("clave") & "", "Estado")
            Select Case est
                Case "Cancelado", "Aplicado"
                    MessageBoxEx.Show("La multa : " & CatControl1.darSeleccionado("clave") & " no se puede cancelar debido a que su estado es " & est & "", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Case "Pendiente"
                    Dim frm As New FrmCanMulta
                    Double.TryParse(CatControl1.darSeleccionado("clave").ToString(), frm.Clave)
                    frm.ShowDialog()
                Case "Abonado"
                    MessageBoxEx.Show("No se puede cancelar este cargo por que ya se hizo un abono", "Multas y Otros Cargos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar(False)
    End Sub
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub Act()
        CatControl1.filtrar("select * from vmultas order by clave desc limit 50")

    End Sub


    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Act()
    End Sub

    Private Sub BtnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualizar.Click
        Dim frm As New FrmVisMultasAbonos
        frm.Clave = CatControl1.darSeleccionado("clave")
        frm.ShowDialog()
    End Sub

    Private Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Dim FRM As New frmagrmov(eve.Todos, frmagrmov.acceso.Agregar)
        FRM.ShowDialog()
        Act()
    End Sub

    Private Sub cmdImp_Click(sender As Object, e As EventArgs) Handles cmdImp.Click

    End Sub
End Class