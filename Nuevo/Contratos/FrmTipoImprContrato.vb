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


        If RBContratoAgua.Checked Then

            Dim numeroContrato As Integer = 0

            If Integer.TryParse(_Cuenta, numeroContrato) Then


                Dim repositorioUsuario As New OperacionesUsuarioRepositorio()
                Dim repositorioFormatos As New FormatosUsuarioRepositorio()

                Dim usuarioDTO As UsuarioDTO = repositorioUsuario.GenerarDatosUsuario(numeroContrato)



                If repositorioFormatos.GenerarContratoAguaPDF(usuarioDTO) Then

                    MessageBox.Show("PDF generado correctamente")

                    'repositorioFormatos.VisualizarPDF()

                Else

                    MessageBox.Show("Error al generar el PDF")

                End If

            Else

                MessageBox.Show("Número de contrato no válido")
                Return

            End If

        End If


        If RBContratoAlcantarillado.Checked Then

            'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
            'Frm.MdiParent = My.Forms.MDIPrincipal
            'Frm.Show()

            Dim objReporteContratoAgua As New ContratoAlcantarillado()
            objReporteContratoAgua.GenerarContratoAlcantarillado(_Cuenta, "ORIGINAL", "")

        End If


        If RBCambioNombre.Checked Then


            Dim objReporteContratoAgua As New Reporte_ContratoAgua()
            objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE NOMBRE")


        End If


        If RBConstanciaNoAdeudo.Checked Then

            'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
            'Frm.MdiParent = My.Forms.MDIPrincipal
            'Frm.Show()

            Dim objReporteContratoAgua As New Constancia()
                objReporteContratoAgua.GenerarConstancianoadeudo(_Cuenta, "ORIGINAL", "")


        End If


        'Notificación





        If RBCambioTarifa.Checked Then

            Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE TARIFA")


        End If



        If RBCambioMedidor.Checked Then

            Dim objReporteContratoAgua As New Reporte_ContratoAgua()
                objReporteContratoAgua.GenerarContratoAgua(_Cuenta, "**ORIGINAL**", "CAMBIO DE MEDIDOR")


        End If



        If RBBajaTemporal.Checked Then

            'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
            'Frm.MdiParent = My.Forms.MDIPrincipal
            'Frm.Show()

            Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "ORIGINAL", "", "temporal")


        End If

        If RBBajaDefinitiva.Checked Then


            'Dim Frm As New frmReporte(frmReporte.Lista.Contrato, "{vusuario1.cuenta} = " & _Cuenta & "", "Original_o_copia, **Original**")
            'Frm.MdiParent = My.Forms.MDIPrincipal
            'Frm.Show()

            Dim Formatb As New FormatoBaja()
                Formatb.GenerarFpormatobaja(_Cuenta, "ORIGINAL", "", "Definitiva")


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
            RBConstanciaNoAdeudo.Text = Formatos("contrato1").ToString
            'RBcontrato4.Text = Formatos("contrato2").ToString
            'RBcontrato5.Text = Formatos("contrato3").ToString

        Catch ex As Exception
            '     MsgBox(ex.Message, MsgBoxStyle.Information, "")
        End Try
    End Sub

    Private Sub RBcontrato3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Verifica()
    End Sub
    Private Sub Verifica()
        If RBContratoAgua.Checked = True Or RBCambioNombre.Checked = True Then
            If RBContratoAgua.Checked = True Then _TipoContra = 1
            If RBCambioNombre.Checked = True Then _TipoContra = 2
        Else
            If RBConstanciaNoAdeudo.Checked = True Then
                _TipoContra = 3
                'ElseIf RBcontrato4.Checked = True Then
                '    _TipoContra = 4
                'ElseIf RBcontrato5.Checked = True Then
                '    _TipoContra = 5
            ElseIf RBContratoAlcantarillado.Checked = True Then
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