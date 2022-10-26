Imports CrystalDecisions.CrystalReports.Engine
Public Class frmRepUsu

    Private tip As tiporep
    Private ini As Boolean = False
    Dim idmes As IDataReader = Nothing

    Enum tiporep
        usuarios
        usuariosbaja

        TomasCont
        UsuariosCont
        CompoAdeudo
        Anlect
    End Enum


    Public Property tipr() As tiporep

        Get
            Return tip
        End Get
        Set(ByVal value As tiporep)
            tip = value

            ' Me.Size = tam
            If tipr = tiporep.TomasCont Then
                lblSol.Visible = True
                lblA.Visible = True
                'dtFec1.Visible = True
                'dtFec2.Visible = True
                ' Me.Size = tam1
                ' cmdImp.Location = New System.Drawing.Point(12, 440)
                'cmdSalir.Location = New System.Drawing.Point(187, 440)
                GPFechas.Visible = True
            Else
                lblSol.Visible = False
                lblA.Visible = False
                dtFec1.Visible = False
                dtFec2.Visible = False
                'Me.Size = tam
                'cmdImp.Location = New System.Drawing.Point(12, 440)
                'cmdSalir.Location = New System.Drawing.Point(187, 440)

            End If

            If tipr = tiporep.usuariosbaja Then
                'GPFechas.Visible = True
            End If


            If value <> tiporep.CompoAdeudo Then

            End If

            If value = tiporep.Anlect Then
                lblSol.Visible = True
                lblSol.Text = "Rango"
                lblA.Visible = True
                txtD.Visible = True
                txtH.Visible = True
                'cmdImp.Location = New System.Drawing.Point(12, 407)
                'cmdSalir.Location = New System.Drawing.Point(187, 407)
                'Me.Size = tam1
                'Else
                '    If Not value = tiporep.TomasCont Then
                '        cmdImp.Location = New System.Drawing.Point(12, 440)
                '        cmdSalir.Location = New System.Drawing.Point(187, 440)
                '        Me.Size = tam
                '    End If
            End If
        End Set
    End Property

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        llenarCombo(cmbReg, "select id_region, region from region order by id_region")
        llenarCombo(cmbCol, "select id_colonia, colonia from colonia order by Colonia")

        llenarCombo(cmbGiro, "select codgir, descripcion from giro order by descripcion")
        llenarCombo(cmbTUsu, "select id_tipo_usuario, descripcion from tipos_usuarios")


        llenarCombo(cmbTipSer, "select id_forma_servicio, descripcion from formas_servicio order by descripcion")
    End Sub


    Private Sub cmbReg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReg.SelectedIndexChanged

        If Not IsNothing(cmbReg.SelectedValue) Then
            llenarCombo(cmbRuta, "select id_ruta, ruta from rutas where id_region='" & cmbReg.SelectedValue.ToString() & "' order by ruta")
        End If

    End Sub

    Private Sub cmbRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRuta.SelectedIndexChanged

        If Not IsNothing(cmbRuta.SelectedValue) Then
            llenarCombo(cmbCol, "Select DISTINCT c.id_colonia,c.Colonia from colonia as c, usuario as u where u.region='" & cmbReg.SelectedValue & "' and c.id_colonia = u.id_colonia order by colonia;")
        End If

    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        ''
        Dim filtro As String = ""
        Dim Titulo As String = ""
        Dim filtromysql As String = ""

        Dim Titulo2 As String = "titulo. 'REPORTE DE PADRÓN DE USUARIOS'"
        ''''''''''''
        If cmbReg.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->REGION:" & cmbReg.Text
            filtro = filtro & " {usuario1.region}='" & cmbReg.SelectedValue & "' and"
            filtromysql = filtromysql & " usuario.region ='" & cmbReg.SelectedValue & "' and"
        End If

        If cmbRuta.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->RUTA:" & cmbRuta.Text
            filtro = filtro & " {usuario1.ruta}='" & cmbRuta.SelectedValue & "' and"
            filtromysql = filtromysql & " usuario.ruta='" & cmbRuta.SelectedValue & "' and"
        End If

        If cmbCol.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->COLONIA:" & cmbCol.Text
            filtro = filtro & " {usuario1.id_colonia}='" & cmbCol.SelectedValue & "' and"
            filtromysql = filtromysql & " usuario1.id_colonia='" & cmbCol.SelectedValue & "' and"
        End If


        'GIRO
        If cmbGiro.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->GIRO:" & cmbGiro.Text
            filtro = filtro & " {usuario1.cod_gir}='" & cmbGiro.SelectedValue & "' and"
            filtromysql = filtromysql & " usuario.cod_gir='" & cmbGiro.SelectedValue & "' and"
        End If

        'TIPO USUARIO
        If cmbTUsu.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->TIPO DE USUARIO:" & cmbTUsu.Text
            filtro = filtro & " {cuotas1.parauso}='" & cmbTUsu.SelectedValue & "' and"
            filtromysql = filtromysql & " cuotas1.parauso='" & cmbTUsu.SelectedValue & "' and"
        End If

        'TARIFA
        If cmbTar.SelectedIndex >= 0 Then
            Titulo = Titulo & "  ->TARIFA:" & cmbTar.Text
            filtro = filtro & " {usuario1.tarifa}='" & cmbTar.SelectedValue & "' and"
            filtromysql = filtromysql & " usuario1.tarifa='" & cmbTar.SelectedValue & "' and"
        End If

        'CON MEDIDOR
        If cmbMed.SelectedIndex >= 0 Then
            If cmbMed.Text = "SI" Then
                Titulo = Titulo & "  ->MEDIDOR:" & cmbMed.Text
                filtro = filtro & " {usuario1.nodemedidor}<>'0' and {usuario1.nodemedidor}<>'' and"
                filtromysql = filtromysql & " usuario1.nodemedidor<>'0' and usuario1.nodemedidor<>'' and"
            End If

            If cmbMed.Text = "NO" Then
                Titulo = Titulo & "  ->MEDIDOR:" & cmbMed.Text
                filtro = filtro & " {usuario1.nodemedidor}='0' or {usuario1.nodemedidor}='' and"
                filtromysql = filtromysql & " usuario1.nodemedidor='0' or usuario1.nodemedidor='' and"
            End If

            If cmbMed.Text = "AMBOS" Then
                Titulo = Titulo & "  ->MEDIDOR:" & cmbMed.Text
            End If

        End If

        If GPFechas.Visible = True Then
            Titulo2 = "titulo. 'REPORTE DE TOMAS CONTRADAS'"
            filtro = filtro + " {usuario1.fechaalta}>=Date(" & DTinicio.Value.Year & "," & DTinicio.Value.Month & "," & DTinicio.Value.Day & ") and {usuario1.fechaalta}<=Date(" & DTfinal.Value.Year & "," & DTfinal.Value.Month & "," & DTfinal.Value.Day & ") and "
            filtromysql = filtromysql + " usuario1.fechaalta>=Date(" & DTinicio.Value.Year & "," & DTinicio.Value.Month & "," & DTinicio.Value.Day & ") and usuario1.fechaalta<=Date(" & DTfinal.Value.Year & "," & DTfinal.Value.Month & "," & DTfinal.Value.Day & ") and "
        End If


        If chktodos.Checked = False Then
            If chkcondescuento.Checked Then
                Titulo = Titulo & "  TOMAS CON DESCUENTO "
                filtro = filtro & " {usuario1.idDescuento}<>0 and "
                filtromysql = filtromysql & " usuario1.idDescuento<>0 and "
            ElseIf chksindescuento.Checked Then
                Titulo = Titulo & "  TOMAS SIN DESCUENTO "
                filtro = filtro & " {usuario1.idDescuento}=0 and "
                filtromysql = filtromysql & " usuario1.idDescuento=0 and "
            End If
        End If

        'If filtro.Length > 0 Then
        '    filtro = Mid(filtro, 1, filtro.Length - 4)
        'End If
        If tipr = tiporep.usuariosbaja Then
            Titulo2 = "titulo. 'REPORTE DE TOMAS DADAS DE BAJA'"
            filtro = filtro & " {usuario1.mostrar}=0 "
            filtromysql = filtromysql & " usuario1.mostrar=0 "
        Else
            filtro = filtro & " {usuario1.mostrar}=1 "
            filtromysql = filtromysql & " usuario1.mostrar=1 "
        End If


        'filtro = filtro & " order by {usuario1.manzana}"
        filtromysql = filtromysql & " order by usuario.manzana"

        cmdImp.Enabled = False





        Dim rp As frmReporte
        Select Case tipr
            Case tiporep.TomasCont
                rp = New frmReporte(frmReporte.Lista.Reportetomcon, filtro, "men. '" & Titulo.Replace(".", " ") & "'", Titulo2)
                rp.MdiParent = My.Forms.MDIPrincipal
                rp.Show()
                rp.WindowState = FormWindowState.Maximized
                cmdImp.Enabled = True
            Case Else

                If chkcondescuento.Checked Then
                    Dim REPDES As New frmReporte
                    Dim objrep As New ReportDocument
                    objrep.Load(".\reportes\UsuariosDetalledescu.rpt")

                    Dim servidorreporte As String = My.Settings.servidorreporte
                    Dim usuarioreporte As String = My.Settings.usuarioreporte
                    Dim passreporte As String = My.Settings.passreporte
                    Dim basereporte As String = My.Settings.basereporte

                    objrep.DataSourceConnections.Item(0).SetConnection(servidorreporte, basereporte, False)
                    objrep.DataSourceConnections.Item(0).SetLogon(usuarioreporte, passreporte)

                    objrep.DataDefinition.FormulaFields("men").Text = "'" & Titulo & "'"
                    objrep.DataDefinition.FormulaFields("titulo").Text = "'PADRON DE USUARIOS CON DESCUENTO'"
                    REPDES.crvReporte.SelectionFormula = filtro
                    REPDES.crvReporte.ReportSource = objrep
                    REPDES.crvReporte.RefreshReport()
                    REPDES.MdiParent = My.Forms.MDIPrincipal
                    REPDES.Show()
                    REPDES.WindowState = FormWindowState.Maximized
                    cmdImp.Enabled = True


                    'REEMPLAZAR POR REPORTE EN ITEXTSHARP
                    ' filtromysql



                Else
                    rp = New frmReporte(frmReporte.Lista.ReporteUsuarios, filtro, "men. '" & Titulo.Replace(".", " ") & "'", Titulo2)

                    rp.MdiParent = My.Forms.MDIPrincipal
                    rp.Show()
                    rp.WindowState = FormWindowState.Maximized
                    cmdImp.Enabled = True
                End If




        End Select


    End Sub

    Private Sub cmbTUsu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTUsu.SelectedIndexChanged


        Try
            llenarCombo(cmbTar, "select id_tarifa, descripcion_cuota from cuotas where parauso=" & cmbTUsu.SelectedValue.ToString() & " order by descripcion_cuota")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()

    End Sub

    Private Sub frmRepUsu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If tip = tiporep.UsuariosCont Then
            Descuentos.Visible = True
        Else
            Descuentos.Visible = False
        End If
    End Sub

    Private Sub lblmen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmen.Click

    End Sub
End Class