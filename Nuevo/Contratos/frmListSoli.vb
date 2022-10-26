Imports DevComponents.DotNetBar

Public Class frmListSoli
    Dim idlet As IDataReader = Nothing
    Public Sub Actualizar()
        CatControl1.filtrar("SELECT Numero as Numero,  Estado,  Fecha, Identificacion,  Solicitado_por, Nombre, Comunidad,  Colonia, Domicilio, numext as Número_exterior, numint as Número_interior,  Observación FROM vsolicitud order by Numero desc")
    End Sub

    Private Sub frmListSoli_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub
    Private Sub frmListSoli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        idlet = ConsultaSql("select * from letras where ccodusuario=" & NumUser & "").ExecuteReader
        idlet.Read()

        'If CBool(idlet("AgrSolicitud")) Then cmdAgr.Visible = True Else cmdAgr.Visible = False
        'If CBool(idlet("EdiSolicitud")) Then cmdEditar.Visible = True Else cmdEditar.Visible = False
        'If CBool(idlet("VisSolicitud")) Then BtnVisualizar.Visible = True Else BtnVisualizar.Visible = False
        'If CBool(idlet("CanSolicitud")) Then cmdCancelar.Visible = True Else cmdCancelar.Visible = False
        'If CBool(idlet("ImpSoli")) Then cmdImp.Visible = True Else cmdImp.Visible = False
        'If CBool(idlet("EdiFactibilidad")) Then cmdEditF.Visible = True Else cmdEditF.Visible = False
        'If CBool(idlet("VisFac")) Then cmdVisF.Visible = True Else cmdVisF.Visible = False
        'If CBool(idlet("ConvierteContrato")) Then cmdConvCont.Visible = True Else cmdConvCont.Visible = False

        'If Not cmdEditF.Visible AndAlso Not cmdVisF.Visible AndAlso Not cmdConvCont.Visible Then
        '    cmdFac.Visible = False
        'Else
        '    cmdFac.Visible = True
        'End If
        Actualizar()
    End Sub


    Private Sub cmdEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditar.Click
        If CatControl1.darNumReg > 0 Then
            Dim solicita As New Frmsolicitud
            solicita.Text = "Solicitud " & Val(CatControl1.darSeleccionado("Numero"))
            solicita.lblMen.Text = "<b><font size='+6'><i>EDICIÓN DE SOLICITUD " & Val(CatControl1.darSeleccionado("Numero")) & " </i></font></b>"
            solicita.Nuevo = False
            solicita.Clave = Val(CatControl1.darSeleccionado("Numero"))
            solicita.Modificar = True
            'solicita.MdiParent = My.Forms.MDIPrincipal
            'btnconvierteacontrato.Enabled = False
            solicita.WindowState = FormWindowState.Normal
            solicita.ShowDialog()
            'solicita.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        If CatControl1.darNumReg() <= 0 Then
            CatControl1.Actualizar()
        End If
        CatControl1.Buscar()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        CatControl1.Salir()
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If CatControl1.darNumReg > 0 Then
            ' Dim motivo As String = ""
            If CatControl1.darSeleccionado("Estado") = "EN PROCESO" OrElse CatControl1.darSeleccionado("Estado") = "PENDIENTE" Then
                If MessageBoxEx.Show("¿Desea cancelar la solicitud No " & CatControl1.darSeleccionado("Numero") & "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'motivo = InputBox("Escriba el motivo de la cancelación")
                    frmMotElSol.nsol = CatControl1.darSeleccionado("Numero")
                    frmMotElSol.ShowDialog()
                    ' Ejecucion("update solicitud set estadosolicitud='CANCELADA', OBSERVA='" & motivo & "' where numero=" & CatControl1.darSeleccionado("Número") & "")
                    CatControl1.filtrar("SELECT Numero as Numero,  Estado,  Fecha, Identificacion,  Solicitado_por, Nombre, Comunidad,  Colonia, Domicilio, numext as Número_exterior, numint as Número_interior,  Observación FROM vsolicitud order by numero desc")

                End If
            Else
                MessageBoxEx.Show("La solicitud " & CatControl1.darSeleccionado("Numero") & " no puede ser cancelada dado que su estado es: " & CatControl1.darSeleccionado("Estado"), "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmdact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdact.Click
        'Actualizar()
        CatControl1.Actualizar()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim frm As New DlgImprimeSol
        frm.MdiParent = MDIPrincipal
        frm.Show()
        frm.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVisualizar.Click
        If CatControl1.darNumReg > 0 Then
            Dim solicita As New Frmsolicitud
            solicita.Text = "Solicitud " & Val(CatControl1.darSeleccionado("Numero"))
            solicita.lblMen.Text = "<b><font size='+6'><i>VISUALIZACIÓN DE SOLICITUD " & Val(CatControl1.darSeleccionado("Numero")) & " </i></font></b>"
            solicita.Nuevo = False
            solicita.Clave = Val(CatControl1.darSeleccionado("Numero"))
            solicita.Modificar = False
            'solicita.MdiParent = My.Forms.MDIPrincipal
            'btnconvierteacontrato.Enabled = False
            solicita.WindowState = FormWindowState.Normal
            solicita.ShowDialog()
            'solicita.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub cmdEditF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEditF.Click
        Dim frmfac As New frmfactibilidad
        frmfac.TxtClave.Text = CatControl1.darSeleccionado("Numero")
        frmfac.Clave = CatControl1.darSeleccionado("Numero")
        frmfac.Text = "Factibilidad " & CatControl1.darSeleccionado("Numero")
        frmfac.MdiParent = My.Forms.MDIPrincipal
        frmfac.Show()
        frmfac.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdConvCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConvCont.Click
        Dim frmcontra As New frmcontrato(frmcontrato._vengode.solicitud)
        frmcontra.mestado = frmcontrato.Estado.factibilidad
        'FRMCONTRA.cuenta = txtnumerodesolicitud.TextBox.Text
        frmcontra.lblsolicitud.Text = CatControl1.darSeleccionado("Numero")
        frmcontra.lblsolicitud.Visible = True
        frmcontra.MdiParent = My.Forms.MDIPrincipal
        frmcontra.Show()
        frmcontra.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdVisF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisF.Click
        Dim frmfac As New frmfactibilidad
        frmfac.TxtClave.Text = CatControl1.darSeleccionado("Numero")
        frmfac.Clave = CatControl1.darSeleccionado("Numero")
        frmfac.Text = "Factibilidad " & CatControl1.darSeleccionado("Numero")
        frmfac.MdiParent = My.Forms.MDIPrincipal
        frmfac.modoVisualizar()
        frmfac.Show()
        frmfac.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        Dim SOLICITA As New Frmsolicitud
        SOLICITA.Text = "Solicitud Nueva"
        SOLICITA.lblMen.Text = "<b><font size='+6'><i>NUEVA SOLICITUD</i></font></b>"
        SOLICITA.Nuevo = True
        'SOLICITA.MdiParent = My.Forms.MDIPrincipal
        SOLICITA.Modificar = True
        SOLICITA.WindowState = FormWindowState.Normal
        SOLICITA.ShowDialog()
        'SOLICITA.WindowState = FormWindowState.Normal
    End Sub
End Class