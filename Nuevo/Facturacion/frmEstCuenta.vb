Public Class frmEstCuenta
    Private cie As Boolean = False, lec As Boolean = False, ordt As Boolean = False, carg As Boolean = False, abn As Boolean = False
    Private meses As Integer = 0


    Public Property _cie() As Boolean
        Get
            Return cie
        End Get
        Set(ByVal value As Boolean)
            cie = value
        End Set
    End Property

    Public Property _lec() As Boolean
        Get
            Return lec
        End Get
        Set(ByVal value As Boolean)
            lec = value
        End Set
    End Property

    Public Property _ordt() As Boolean
        Get
            Return ordt
        End Get
        Set(ByVal value As Boolean)
            ordt = value
        End Set
    End Property

    Public Property _carg() As Boolean
        Get
            Return carg
        End Get
        Set(ByVal value As Boolean)
            carg = value
        End Set
    End Property

    Public Property _abn() As Boolean
        Get
            Return abn
        End Get
        Set(ByVal value As Boolean)
            abn = value
        End Set
    End Property

    Public Property _meses() As Integer
        Get
            Return meses

        End Get
        Set(ByVal value As Integer)
            meses = value
        End Set
    End Property

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        'Dim descomu As String = obtenerCampo("select comunidad from comunidades where id_comunidad='" & Comunidad & "'", "comunidad")
        'Dim frmrepa As New frmReporte(frmReporte.Lista.HistoriaUsuario, "{vusuario1.cuenta}=" & Cuenta & " and {vusuario1.comunidad}='" & descomu & "'", "rez_con ,'" & CierreH._rez_con & "'", "rez_alca ,'" & CierreH._rez_alca & "'", "rez_san ,'" & CierreH._rez_san & "'", "rez_rec ,'" & _
        '                              CierreH._rez_rec & "'", "rez_iva ,'" & CierreH._rez_iva & "'", "rez_tot ,'" & CierreH._tot_consua & "'", "act_con ,'" & CierreH._act_con & "'", "act_alca ,'" & CierreH._act_alca & "'", "act_san ,'" & CierreH._act_san & "'", "act_rec ,'" & _
        '                              CierreH._act_rec & "'", "act_iva ,'" & CierreH._act_iva & "'", "act_tot ,'" & CierreH._tot_consun & "'", "t_con ,'" & CierreH._t_con & "'", "t_alca ,'" & CierreH._t_alca & "'", "t_san ,'" & CierreH._t_san & "'", "t_rec ,'" & CierreH._t_rec & "'", "t_iva ,'" & _
        '                              CierreH._t_iva & "'", "t_total ,'" & CierreH._tot_gen1 & "'", "otrcargos ,'" & CierreH._otr_cargos & "'", "cargosmconsumo ,'" & CierreH._cargomconsumo & "'", "abodesc ,'" & CierreH._abodescu & "'", "totalfinal ,'" & CierreH._totalfinal & "'")

        'frmrepa.MdiParent = MDIPrincipal

        'frmrepa.Show()
        'frmrepa.WindowState = FormWindowState.Maximized

        cie = chkCierres.Checked
        lec = chkLecturas.Checked
        ordt = chkOrdt.Checked
        carg = chkCargos.Checked
        abn = chkAbonos.Checked
        meses = txtLect.Value
        Me.Close()
    End Sub

    Private Sub cmdSal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSal.Click
        Me.Close()
    End Sub

    Private Sub cmdImp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.GotFocus
        cmdImp.Pulse()
        cmdImp.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdImp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdImp.LostFocus
        cmdImp.StopPulse()
    End Sub

    Private Sub cmdSal_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSal.GotFocus
        cmdSal.Pulse()
        cmdSal.StopPulseOnMouseOver = False
    End Sub

    Private Sub cmdSal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSal.LostFocus
        cmdSal.StopPulse()
    End Sub

    Private Sub frmEstCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub



    Private Sub chkLecturas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLecturas.CheckedChanged
        If chkLecturas.Checked Then
            txtLect.Visible = True
            lbl1.Visible = True
        Else
            txtLect.Visible = False
            lbl1.Visible = False
        End If
    End Sub

 


End Class