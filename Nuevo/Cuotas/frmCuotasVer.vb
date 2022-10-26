Imports DevComponents.DotNetBar

Public Class frmCuotasVer

    Dim frmDat As frmConscuotas

    Private Sub frmCuotasVer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actBase()
    End Sub

    Public Sub actBase()
        llenaGrid(dgTar, "select cuotas.id_tarifa as Tarifa,tipos_usuarios.descripcion, cuotas.descripcion_cuota, cuotas.medido,  cuotas.alcantarillado,cuotas.saneacuo, cuotas.recargos,cuotas.ivaacon as IVA_CONSUMO, IVAALCA AS IVA_ALCANTARILLADO, IVASANE AS IVA_SANEAMIENTO from cuotas,tipos_usuarios where tipos_usuarios.id_tipo_usuario=cuotas.parauso")
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem1.Click
        Dim s As Object = Nothing, ee As System.EventArgs = Nothing
        frmDat = New frmConscuotas()
        'frmDat.MdiParent = My.Forms.MDIPrincipal
        frmDat.btnimprimir.Visible = False
        frmDat.cmdAgregar_Click(s, ee)
        frmDat.ShowDialog()
        'frmDat.WindowState = FormWindowState.Normal
        actBase()
    End Sub


    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim cuo As String = dgTar.Item("Tarifa", dgTar.CurrentRow.Index).Value 'obtenerCampo("select id_tarifa from cuotas where descripcion_cuota=""" & dgTar.Item(1, dgTar.CurrentRow.Index).Value & """", "id_tarifa")
        frmDat = New frmConscuotas(cuo)
        'frmDat.MdiParent = My.Forms.MDIPrincipal
        frmDat.ShowDialog()
        actBase()
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim cuo As String = dgTar.Item(0, dgTar.CurrentRow.Index).Value 'obtenerCampo("select id_tarifa from cuotas where descripcion_cuota=""" & dgTar.Item(1, dgTar.CurrentRow.Index).Value & """", "id_tarifa")
        Dim ia As IDataReader
        ia = ConsultaSql("select * from usuario where tarifa='" & dgTar.Item(0, dgTar.CurrentRow.Index).Value & "'").ExecuteReader
        If ia.Read() Then
            MessageBoxEx.Show("Hay usuarios asignados a esta cuota")
            Exit Sub
        End If
        If MessageBoxEx.Show("¿Desea eliminar la cuota:" & dgTar.Item(2, dgTar.CurrentRow.Index).Value & "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Ejecucion("delete from cuotas where id_tarifa='" & cuo & "'")
        End If
        actBase()

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()

    End Sub

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Dim cuo As String = dgTar.Item(0, dgTar.CurrentRow.Index).Value 'obtenerCampo("select id_tarifa from cuotas where descripcion_cuota=""" & dgTar.Item(1, dgTar.CurrentRow.Index).Value & """", "id_tarifa")
        frmDat = New frmConscuotas(cuo)
        frmDat.btnaceptar.Visible = False
        frmDat.cmdDel.Visible = False
        frmDat.cmdAgregar.Visible = False

        'frmDat.MdiParent = My.Forms.MDIPrincipal
        frmDat.ShowDialog()
        actBase()
    End Sub


    Private Sub btnVisu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cuo As String = dgTar.Item(0, dgTar.CurrentRow.Index).Value 'obtenerCampo("select id_tarifa from cuotas where descripcion_cuota=""" & dgTar.Item(1, dgTar.CurrentRow.Index).Value & """", "id_tarifa")
        frmDat = New frmConscuotas(cuo)
        frmDat.ShowDialog()
        frmConscuotas.txtalertalecturas.Enabled = False
        frmConscuotas.txtcatidadmonetariasaneamiento.Enabled = False
        frmConscuotas.txtconsumo.Enabled = False

        frmConscuotas.txtcuomensualalcantarillado.Enabled = False
        frmConscuotas.txtcuomensualsaneamiento.Enabled = False

        'frmConscuotas.txtCuota3.Enabled
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frmrep As New frmReporte(frmReporte.Lista.Tarifas, "")
        frmrep.MdiParent = MDIPrincipal
        frmrep.Show()
        frmrep.Text = "Reporte de Cuotas"
        frmrep.WindowState = FormWindowState.Maximized

    End Sub


End Class