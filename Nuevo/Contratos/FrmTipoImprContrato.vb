Public Class FrmTipoImprContrato
    Enum Posibilidades
        Contrato
        Cambio_Nombre
        Cambio_Tarifa
        Cambio_Medidor
    End Enum
    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private _Cuenta As Double, _Comunidad As String, _TipoContra As Integer, _CambioNombre As Posibilidades
    Private Titulo As String, Clausula As String
    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
        End Set
    End Property
    Public Property Comunidad() As String
        Get
            Return _Comunidad
        End Get
        Set(ByVal value As String)
            _Comunidad = value
        End Set
    End Property
    Public Property CambioNombre() As Posibilidades
        Get
            Return _CambioNombre
        End Get
        Set(ByVal value As Posibilidades)
            _CambioNombre = value
        End Set
    End Property

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim Marca As String = obtenerCampo("select descripcion from marcasmedidor, vusuario where vusuario.marcamedidor = marcasmedidor.id_marca and cuenta = " & _Cuenta, "Descripcion")

        If RBcambiodenombre.Checked Then

            If OptCopia.Checked = True Then
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "COPIA", "CAMBIO DE NOMBRE")
            Else
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE NOMBRE")
            End If
        End If
        If rbcambiotarifa.Checked Then
            If OptCopia.Checked = True Then
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "COPIA", "CAMBIO DE TARIFA")
            Else
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE TARIFA")
            End If
        End If
        If rbcambiomedidor.Checked Then
            If OptCopia.Checked = True Then
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "COPIA", "CAMBIO DE MEDIDOR")
            Else
                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE MEDIDOR")
            End If
        End If

        If RBcontrato1.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "COPIA", "")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "ORIGINAL", "")
            End If
        End If


        If chkProvisional.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New ContratoProvisional()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "COPIA", "")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New ContratoProvisional()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "ORIGINAL", "")
            End If
        End If



        If RBcontrato3.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New Constancia()
                objReporteContratoAgua.GenerarConstancianoadeudo(_Cuenta, "COPIA", "")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New Constancia()
                objReporteContratoAgua.GenerarConstancianoadeudo(_Cuenta, "ORIGINAL", "")
            End If
        End If

        If Rbcontrato6.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New ContratoAlcantarillado()
                objReporteContratoAgua.GenerarContratoAlcantarillado(_Cuenta, "COPIA", "")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim objReporteContratoAgua As New ContratoAlcantarillado()
                objReporteContratoAgua.GenerarContratoAlcantarillado(_Cuenta, "ORIGINAL", "")
            End If
        End If


        If chkBaja.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "COPIA", "", "temporal")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "ORIGINAL", "", "temporal")
            End If
        End If

        If chkbajadef.Checked Then
            If OptCopia.Checked = True Then
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Copia**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "COPIA", "", "Definitiva")

            Else
                'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
                'Frm.MdiParent = My.Forms.MDIPrincipal
                'Frm.Show()

                Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "ORIGINAL", "", "Definitiva")
            End If
        End If


        If Rbcomprconcargo.Checked Then

            Dim Frm As New frmReporte(frmReporte.Lista.Comprobante, "{vusuario1.cuenta} = " & _Cuenta)
            Frm.MdiParent = My.Forms.MDIPrincipal
                Frm.Show()

        End If
        Close()
    End Sub

    Private Sub FrmTipoImprContrato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub FrmTipoImprContrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Formatos As IDataReader = ConsultaSql("Select contrato1, contrato2, contrato3 from formatocontrato").ExecuteReader
            Formatos.Read()
            RBcontrato3.Text = Formatos("contrato1").ToString
            RBcontrato4.Text = Formatos("contrato2").ToString
            RBcontrato5.Text = Formatos("contrato3").ToString

        Catch ex As Exception
            '     MsgBox(ex.Message, MsgBoxStyle.Information, "")
        End Try
    End Sub

    Private Sub RBcontrato3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub Verifica()
        If RBcontrato1.Checked = True Or RBcambiodenombre.Checked = True Then
            If RBcontrato1.Checked = True Then _TipoContra = 1
            If RBcambiodenombre.Checked = True Then _TipoContra = 2
        Else
            If RBcontrato3.Checked = True Then
                _TipoContra = 3
            ElseIf RBcontrato4.Checked = True Then
                _TipoContra = 4
            ElseIf RBcontrato5.Checked = True Then
                _TipoContra = 5
            ElseIf Rbcontrato6.Checked = True Then
                _TipoContra = 2
            End If
        End If
    End Sub

    Private Sub RBcontrato1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub

    Private Sub RBcontrato2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub RBcontrato4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub RBcontrato5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Public Sub New(ByVal NoCuenta As Double, ByVal Comunidad As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        _Cuenta = NoCuenta
        _Comunidad = Comunidad
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Verifica()

    End Sub
End Class