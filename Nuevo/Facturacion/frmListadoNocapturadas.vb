Public Class frmListadoNocapturadas
    Public ori As FrmCalculaConsumo

  
    Private Sub frmListadoNocapturadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RL1.Text = "<b><font size=""+6""><i>Dev</i><font color=""#B02B2C"">Listado faltantes del la region " & ori.CmdRegion.SelectedText & " y de la ruta " & ori.CmbRuta.SelectedText & "</font></font></b>"

        llenaGrid(dgfaltantes, "select cuenta,nombre,direccion from  vusuario as v, cuotas as c where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  v.region = " & ori.CmdRegion.SelectedValue & " and v.ruta = " & ori.CmbRuta.SelectedValue & " and mostrar = 1  and cuenta not in (select count(v.nombre) as num from  vusuario as v, cuotas as c, lecturas as l where v.descripcion_cuota = c.descripcion_cuota and c.medido <> 0 and  v.region = " & ori.CmdRegion.SelectedValue & " and v.ruta = " & ori.CmbRuta.SelectedValue & " and mostrar = 1 and l.mes='" & ori.cmbmes.Text & "' and l.an_per=" & ori.txtAn.Text & "  and v.cuenta=l.cuenta )")
    End Sub
End Class
