Imports DevComponents.DotNetBar

Public Class frmListFacti
    Public Sub Actualizar()
        CatControl1.filtrar("SELECT Numero as Número, solicitud.estadosolicitud as Estado, fechasolicitud as Fecha, solicitud.Nombre as Nombre, comunidades.comunidad as Comunidad, colonia.colonia  as Colonia, calles.nombre as Calle, solicitud.numext as Número_exterior, solicitud.numint as Número_interior, ObservaFacti as Observacion FROM solicitud, comunidades, colonia, calles where solicitud.id_comunidad=comunidades.id_comunidad and solicitud.id_colonia=colonia.id_colonia and solicitud.id_Calle=calles.id_calle and colonia.id_comunidad=comunidades.id_comunidad and calles.id_comunidad=comunidades.id_comunidad and calles.id_colonia=colonia.id_colonia order by numero desc")
    End Sub

    Private Sub frmListFacti_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub
    Private Sub frmListFacti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Actualizar()
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        CatControl1.Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        Dim frmfac As New frmfactibilidad
        frmfac.TxtClave.Text = CatControl1.darSeleccionado("Número")
        frmfac.Clave = CatControl1.darSeleccionado("Número")
        frmfac.Text = "Factibilidad " & CatControl1.darSeleccionado("Número")
        frmfac.MdiParent = My.Forms.MDIPrincipal
        frmfac.Show()
        frmfac.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub cmdConvCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvCont.Click
        Dim frmcontra As New frmcontrato(frmcontrato._vengode.solicitud)
        frmcontra.mestado = frmcontrato.Estado.factibilidad
        'FRMCONTRA.cuenta = txtnumerodesolicitud.TextBox.Text
        frmcontra.lblsolicitud.Text = CatControl1.darSeleccionado("Número")
        frmcontra.lblsolicitud.Visible = True
        frmcontra.MdiParent = My.Forms.MDIPrincipal
        frmcontra.Show()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Dim motivo As String = ""
        If MessageBoxEx.Show("¿Desea cancelar la Factibilidad?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            motivo = InputBox("Escriba el motivo de la cancelación")
            Ejecucion("update solicitud set estadosolicitud='CANCELADA', observafacti='" & motivo & "' where numero=" & CatControl1.darSeleccionado("Número") & "")
            CatControl1.filtrar("SELECT Numero as Número, solicitud.estadosolicitud as Estado, fechasolicitud as Fecha, seiden as Identificación, solispor as Solicitado_por, solicitud.Nombre as Nombre, comunidades.comunidad as Comunidad, colonia.colonia  as Colonia, calles.nombre as Calle, solicitud.numext as Número_exterior, solicitud.numint as Número_interior FROM solicitud, comunidades, colonia, calles where solicitud.id_comunidad=comunidades.id_comunidad and solicitud.id_colonia=colonia.id_colonia and solicitud.id_Calle=calles.id_calle and colonia.id_comunidad=comunidades.id_comunidad and calles.id_comunidad=comunidades.id_comunidad and calles.id_colonia=colonia.id_colonia")
        End If
    End Sub

    Private Sub cmdact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdact.Click
        Actualizar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frm As New DlgImprimeSol
        frm.ShowDialog()
    End Sub
End Class