Imports System.Net.Mail
Imports System
Imports System.Collections
Imports System.Net
Imports System.Net.Mime
Imports System.Data.Odbc
Imports System.Drawing
Imports System.IO
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar

Public Class frmcontrato

#Region "Variables"
    Dim Municipio As Int16, Sector As String, Ruta As String, Colonia As String
    Dim comunidad As String
    Dim dUbi As String = "0"
    Dim dAu As String = "0"
    Dim dFis As String = "0"
    Dim GC As String = "0"
    Dim AC As String = "0"
    Public mestado As Estado
    Public tarifa As Integer
    Public cuenta As Long
    Public idcomacargar As String
    Protected _vengo As _vengode
    Private picture As Image
    Private pictureLocation As Point
    Dim img1 As String = "", img2 As String = "", img3 As String = "", img4 As String = ""
    Dim _claComu As String
    Private matMod As New Collection
    Private buf As String
    Private vreg As String = "", vrut As String = ""
    Private fechaDeudaAntes As String = ""
#End Region

#Region "Modificadores"

    Public Property claComu() As String
        Get
            If comunidad <> "" Then
                Return comunidad
            Else
                Return obtenerCampo("SELECT ID_COMUNIDAD FROM comunidades WHERE COMUNIDAD='" & Cmbcomunidad.Text & "'", "ID_COMUNIDAD")
            End If

        End Get
        Set(ByVal value As String)
            _claComu = comunidad
        End Set
    End Property

    Enum Estado
        Nuevo
        Editar
        Cancelar
        factibilidad
        Visualizar
    End Enum

    Enum _vengode
        nuevocont
        solicitud
    End Enum

#End Region

#Region "Constructores"

    Public Sub New(ByVal vengo As _vengode)
        InitializeComponent()
        _vengo = vengo
        MO(_vengo)
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

#End Region

#Region "Manda mail"

    Private Sub cmdMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMail.Click
        Dim empresa As String = obtenerCampo("select cnombre from empresa", "cnombre")
        Dim cuerpo As String


        If txtemail.Text = "" Then
            MsgBox("Especifique el correo electrónico porfavor", MsgBoxStyle.Information, "Correo electrónico")
            Exit Sub
        End If


        cuerpo = "*******************************************" & Chr(13) & " Envio de contraseña " & Chr(13) &
        "*******************************************" & Chr(13) & Chr(13) & " Contraseña: " & txtpass.Text & Chr(13) &
        "Pregunta secreta : " & Me.txtpreguntasecreta.Text & Chr(13) & " Respuesta secreta: " & txtrespsec.Text

        Dim MMessage As New System.Net.Mail.MailMessage()
        MMessage.To.Add(txtemail.Text)
        'rgtntnitro61@gmail.com
        MMessage.From = New MailAddress("capyat@gmail.com", empresa, System.Text.Encoding.UTF8)
        MMessage.Attachments.Add(New Attachment("C:\Archivo.doc"))
        MMessage.Subject = "Registro al padrón de usuarios"
        MMessage.SubjectEncoding = System.Text.Encoding.UTF8
        MMessage.Body = cuerpo
        MMessage.BodyEncoding = System.Text.Encoding.UTF8
        MMessage.IsBodyHtml = False
        Dim SClient As New SmtpClient()
        SClient.Credentials = New System.Net.NetworkCredential("capyat@gmail.com", "capyatcapyat")
        SClient.Host = "smtp.gmail.com"
        SClient.Port = 587
        SClient.EnableSsl = True

        Try
            SClient.Send(MMessage)
            MessageBoxEx.Show("Correo enviado exitosamente", "Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As System.Net.Mail.SmtpException
            MessageBoxEx.Show(ex.Message, "Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

#End Region
    Dim contratonuevo As Integer = 0
    Dim contratonuevo2 As Integer = 0
    Dim D_CUENTA, D_IDCOMUNIDAD, D_IDTARIFA As String
    Dim CONSULTA_TA, FOLIO, EXPE As IDataReader
    Dim D_FOLIOTARIFA As Double = 0
    Public nombreTitular As String
    Public expD As Integer

#Region "carga formulario"
    Private Sub frmcontrato_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        'If e.Data.GetDataPresent(DataFormats.FileDrop) Then

        '    Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        '    Try
        '        
        '        Me.picture = Image.FromFile(files(0))

        '        Me.pictureLocation = Me.PointToClient(New Point(e.X, e.Y))
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '        Return
        '    End Try
        'End If


        'If e.Data.GetDataPresent(DataFormats.Bitmap) Then
        '    Try

        '        Me.picture = CType(e.Data.GetData(DataFormats.Bitmap), Image)

        '        Me.pictureLocation = Me.PointToClient(New Point(e.X, e.Y))
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '        Return
        '    End Try
        'End If

        'Me.Invalidate()
        ''Me.PictureBox1.Image = picture












    End Sub

    Private Sub frmcontrato_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        'If e.Data.GetDataPresent(DataFormats.Bitmap) _
        '   Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
        '    e.Effect = DragDropEffects.Copy
        'Else
        '    e.Effect = DragDropEffects.None
        'End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)


        If (Me.picture IsNot Nothing) And
          Not (Me.pictureLocation.Equals(Point.Empty)) Then
            e.Graphics.DrawImage(Me.picture, Me.pictureLocation)
        End If
    End Sub

    Private Sub frmcontrato_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'My.Forms.frmBusUsuario.cmdInstaB.Enabled = False
        'My.Forms.frmBusUsuario.cmdActi.Enabled = False
    End Sub

    Private Sub frmcontrato_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub

    Private Sub frmcontrato_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Dim keyascii As Keys = e.KeyData

        Select Case keyascii
            Case Keys.Enter


                If rbDirUbi.Focused OrElse rbDomAu.Focused OrElse rbDirFis.Focused Then
                    Tabsolicitud.SelectNextTab()
                    txtreferencias.Select()
                ElseIf dtffechainst.Focused Then
                    Tabsolicitud.SelectNextTab()
                    txtcatastral.Select()

                ElseIf txtemail.Focused Then
                    Tabsolicitud.SelectNextTab()
                    pic1.Select()
                Else
                    SendKeys.Send("{TAB}")
                End If

        End Select
    End Sub

    Private Sub frmcontrato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        'TODO: esta línea de código carga datos en la tabla 'BaseaguaDataSet.Solicitud' Puede moverla o quitarla según sea necesario.
        'llena el combo de municipio
        pic1.AllowDrop = True
        pic2.AllowDrop = True
        pic3.AllowDrop = True
        pic4.AllowDrop = True
        Me.AllowDrop = True
        llenarCombo(Cmbmunicipio, "select clave,nombre from municipios order by nombre")
        Cmbmunicipio.SelectedIndex = 0
        'Dim IDMUNI As Integer
        'IDMUNI = CInt(obtenerCampo("SELECT CLAVE FROM MUNICIPIOS WHERE NOMBRE='" & Cmbmunicipio.Text & "'", "CLAVE"))

        'llena el combo de comunidades
        llenarCombo(Cmbcomunidad, "select id_comunidad, comunidad from comunidades WHERE NMPIO = " & Cmbmunicipio.SelectedValue.ToString & " order by comunidad")

        'llena tipo de usos
        llenarCombo(cmbtipouso, "select id_tipo_usuario, descripcion from tipos_usuarios")
        llenarCombo(Cmbsector, "select clavesec, descripcion from sectores order by descripcion")
        llenarCombo(cmbgiro, "select codgir, descripcion from giro order by descripcion")
        llenarCombo(cmbnivsoc, "select clave, descripcion from nivelsocioe order by descripcion")
        llenarCombo(cmbRegion, "select id_region,region from region order by region")
        'llenarCombo(cmbruta, "select id_ruta, ruta from rutas order by ruta")
        llenarCombo(cmbtarifa, "select id_tarifa, descripcion_cuota from cuotas order by descripcion_cuota")
        llenarCombo(cmbtarifa2, "select id_tarifa, descripcion_cuota from cuotas order by descripcion_cuota")
        llenarCombo(Cmbmunicipio, "select clave, nombre from municipios order by nombre")
        llenarCombo(CmbMarcaMedidor, "select id_marca,descripcion from marcasmedidor order by descripcion")
        llenarCombo(cmbFservicio, "select id_forma_servicio, descripcion from formas_servicio")
        llenarCombo(cmbDiamMed, "select id_diametro, descripcion from diametros")
        llenarCombo(CmbDiamToma, "select id_diametro, descripcion from diametros")
        llenarCombo(Cmbestado, "select clave,descripcion from estadotoma")
        llenarCombo(Cmbmatcalle, "select id_matcalle, descripcion from mat_calle")
        llenarCombo(cmbubmedidor, "select id_ubmedidor, descripcion from ub_medidor")
        llenarCombo(cmbcolonia, "select id_colonia, colonia from colonia order by colonia")
        If My.Settings.CombodeCalles.ToUpper() = "SI" Then
            llenarCombo(cmbcalle, "SELECT ID_CALLE, NOMBRE FROM CALLES  ORDER BY NOMBRE")
            txtDomicilio.Visible = False
            cmbcalle.Visible = True
        Else
            txtDomicilio.Visible = True
            cmbcalle.Visible = False
        End If
        llenarCombo(CMBCALLE1, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE2, "SELECT ID_CALLE, NOMBRE FROM calles ORDER BY NOMBRE")
        llenarCombo(CMBCALLE3, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE4, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CmbEstPredio, "SELECT idEstado_Predio, Descripcion FROM estado_predio ORDER BY Descripcion")
        llenarCombo(cmbDescuento, "SELECT idDescuento, xDescrip FROM descuentos ORDER BY idDescuento")
        cmbDescuento.SelectedIndex = 0
        llenarCombo(cmbCuoValvu, "SELECT idCuotaValvulista, xDscCuotaValvulista FROM ccuotavalvulista order by idCuotaValvulista")
        cmbCuoValvu.SelectedIndex = 0
        'rbDirUbi.Checked = True


        dtfsolicitud.Value = Now
        'Cmbestado.SelectedItem = "Inactivo"

        Select Case mestado
            Case Estado.Visualizar
                gpDatCont.Enabled = False
                gpDatServ.Enabled = False
                gpUbiToma.Enabled = False
                gpDatRec.Enabled = False
                gpDatUbi.Enabled = False
                gpObserva.Enabled = False
                gpDatTec.Enabled = False
                gpDatEscri.Enabled = False

                gpClaWeb.Enabled = False
                gpFotos.Enabled = False

                cmdAcept.Visible = False
                cmdImp.Visible = True
                cmdMail.Visible = False
                'cmdOrdTrab1.Visible = False
                cmdAgrCar.Visible = False

                'txtclave.BackColor = Color.Ivory
                'txtclave.ForeColor = Color.Ivory
                'txtclave.Border.BackColor = Color.Ivory

                'Cmbcomunidad.BackColor = Color.Red
                'Cmbcomunidad.ForeColor = Color.Ivory
                'TARIFAS ADICIONALES
                TarifasAdicionales.Enabled = False
                BtnAgregar.Enabled = False
                BtnEliminar.Enabled = False
                cmbtarifa2.Enabled = False
                dporce.Enabled = False



                llenadoEXP()



        End Select
        If Not mestado = Estado.Nuevo Then
            carga()

        End If

        If mestado = Estado.Nuevo Then
            'ChkGestCob.Checked = True
            Cmbestado.Visible = False
            lblestado.Visible = False
            tabDocumentos.Visible = False
        End If

        If mestado = Estado.Editar Then
            gpDatTec.Enabled = True
            tabDocumentos.Visible = True
            llenadoEXP()

            'nderivacion.Enabled = False
            'CmbMarcaMedidor.Enabled = False
            'txtnumerodemedidor.Enabled = False
            'cmbDiamMed.Enabled = False
            'dtffechainst.Enabled = False
        End If


        'txtpropietario.Select()
        If _vengo = _vengode.nuevocont Then
            Cmbmunicipio.Select()
        Else
            dtfsolicitud.Select()
        End If
        txtcatastral.Select()
        llenado()
        llenadoEXP()

    End Sub

    Private Sub MO(ByVal v As _vengode)

        If v = _vengode.solicitud Then
            txtsolicitado.Visible = False
            lblsolicitado.Visible = False
            txtparentesco.Visible = False
            lblparentesco.Visible = False
            txtidentificacion.Visible = False
            lblidentificacion.Visible = False

            'nderivacion.Visible = False
            'lblDerivaciones.Visible = False
            'cmbDiamMed.Visible = False
            'lblDiamMedidor.Visible = False

            'txtAlberca.Visible = False
            'lblDiamMedidor.Visible = False
            'txtTinaco.Visible = False
            'lblTinaco.Visible = False
            'CmbMarcaMedidor.Visible = False
            'lblMarcaMedidor.Visible = False
            'txtnumerodemedidor.Visible = False
            'lblNoMedidor.Visible = False
            'CmbDiamToma.Visible = False
            'lblDiamToma.Visible = False
            'txtCisterna.Visible = False
            'lblCisterna.Visible = False
            'dtffechainst.Visible = False
            'lblfecha.Visible = False
            'Label31.Visible = False

            'txtGps33.Visible = False
            'txtGps22.Visible = False
            'txtGps11.Visible = False

            'gpDatCont.Height = 83
            'gpDatUbi.Height = 202
            'Me.Height = 550

            'gpDatServ.Location = New System.Drawing.Point(25, 89)
            'gpUbiToma.Location = New System.Drawing.Point(25, 221)
            'gpDatRec.Location = New System.Drawing.Point(25, 408)
            'gpObserva.Location = New System.Drawing.Point(13, 205)
            'gpDatTec.Visible = False
        Else
            txtsolicitado.Visible = True
            lblsolicitado.Visible = True
            txtparentesco.Visible = True
            lblparentesco.Visible = True
            txtidentificacion.Visible = True
            lblidentificacion.Visible = True

            nderivacion.Visible = True
            lblDerivaciones.Visible = True
            cmbDiamMed.Visible = True
            lblDiamMedidor.Visible = True

            txtAlberca.Visible = True
            lblDiamMedidor.Visible = True
            txtTinaco.Visible = True
            lblTinaco.Visible = True
            CmbMarcaMedidor.Visible = True
            lblMarcaMedidor.Visible = True
            txtnumerodemedidor.Visible = True
            lblNoMedidor.Visible = True
            CmbDiamToma.Visible = True
            lblDiamToma.Visible = True
            txtCisterna.Visible = True
            lblCisterna.Visible = True
            dtffechainst.Visible = True
            lblfecha.Visible = True
            Label31.Visible = True


            txtGps33.Visible = True
            txtGps22.Visible = True
            txtGps11.Visible = True
            'gpDatCont.Height = 151

            'gpDatServ.Location = New System.Drawing.Point(25, 151)
            'gpUbiToma.Location = New System.Drawing.Point(25, 284)
            'gpDatRec.Location = New System.Drawing.Point(25, 472)
            'gpObserva.Location = New System.Drawing.Point(13, 238)
            'gpDatTec.Visible = True
            'Me.Height = 609
        End If

    End Sub

#End Region

#Region "Valida y graba"


#End Region

#Region "llena ubicacion"
    Private Sub cruta(ByVal sec As String, ByVal rut As String, ByVal colonia As String, ByVal mzn As String, ByVal lot As String)
        sec = llenaCero(sec, 3)
        rut = llenaCero(rut, 3)
        colonia = llenaCero(colonia, 3)
        mzn = llenaCero(mzn, 3)
        lot = llenaCero(lot, 4)
        txtubicacion.Text = String.Concat(sec, "-", rut, "-", colonia, "-", mzn, "-", lot)
    End Sub

    Private Function llenaCero(ByVal cad As String, ByVal n As Int16) As String
        Dim i As Int16

        If Len(cad) < n Then
            For i = Len(cad) To n - 1
                cad = "0" & cad
            Next
        End If
        llenaCero = cad
    End Function



#End Region

#Region "Carga datos"

    Private Sub carga()

        If mestado = Estado.Editar OrElse mestado = Estado.Visualizar Then

            cmbtarifa.Enabled = False

            Dim cadenadecarga As String

            cadenadecarga = "select cuenta,cuentaAnterior,nombre,nmunicipio,id_comunidad,id_colonia,id_calle,numext,numint,fechaalta,solicitadopor,parentesco,seiden,escritura" _
                           & ",cp,rfc,estado,sector,ruta,nodemedidor,telefono,diametrotoma,capcisterna,captinaco,capalberca,marcamedidor,alcantarillado,saneamiento" _
                           & ",diammedidor,tarifa,clave_predial,ubicacion,entrecalle1,entrecalle2,entrecalle3,entrecalle4,derivacion,cod_gir,ID_TIPO_USUARIO,ESTADOPREDIO" _
                           & ",ubicaciongps1,ubicaciongps2,ubicaciongps3,observacion,niveleconomico,lote,manzana,caracter,REFERENCIAS,FECHAINST" _
                           & ",password,pregsect,ressect,email,id_forma_servicio,DirUbi,DirAu,DirFis,foto1,foto2,foto3,foto4,region, GestCob, RegGis, AltoConsumidor,cto_agua,cto_drenaje,pro_anual,Cedula_Catastral,DEUDAFEC, matcalle, ubmedidor, Domicilio, idDescuento, idCuotaValvulista from usuario where  cuenta =" & cuenta
            Dim dr As IDataReader = ConsultaSql(cadenadecarga).ExecuteReader()
            dr.Read()
            Try
                'pic1.Image = Nothing
                'pic2.Image = Nothing
                'pic3.Image = Nothing
                'pic4.Image = Nothing
                pic1.Load(String.Concat(RutaImagenes, "/", dr("foto1")))
                pic2.Load(String.Concat(RutaImagenes, "/", dr("foto2")))
                pic3.Load(String.Concat(RutaImagenes, "/", dr("foto3")))
                pic4.Load(String.Concat(RutaImagenes, "/", dr("foto4")))
            Catch ing As Exception
            End Try

            Cmbmunicipio.SelectedValue = dr("nmunicipio")
            Cmbcomunidad.SelectedValue = dr("id_comunidad")
            cmbcolonia.SelectedValue = dr("id_colonia")

            cmbFservicio.SelectedValue = dr("id_forma_servicio")

            cmbRegion.SelectedValue = dr("region")
            cmbruta.SelectedValue = dr("ruta")

            If CBool(dr("dirubi")) = False And CBool(dr("DirAu")) = False And CBool(dr("DirFis")) = False Then
                rbDirUbi.Checked = True
            Else
                rbDirUbi.Checked = CBool(dr("Dirubi"))
                rbDomAu.Checked = CBool(dr("DirAu"))
                rbDirFis.Checked = CBool(dr("DirFis"))
            End If


            ' datosgenales  ok
            Try
                txtclave.Text = dr("cuenta")
                ''txtInmueble.Text = dr("cuentaAnterior")
            Catch
                'MsgBox("No encontre el contrato " & cuenta & " ")
                'Exit Sub
            End Try
            If Not IsDBNull(dr("fechaalta")) Then
                dtfsolicitud.Value = dr("fechaalta")
            Else
                dtfsolicitud.Value = Nothing

            End If

            If Not IsDBNull(dr("DEUDAFEC")) Then
                DTfechadeuda.Value = dr("DEUDAFEC")
                fechaDeudaAntes = dr("DEUDAFEC")
            Else
                DTfechadeuda.Value = Nothing

            End If


            If Not IsDBNull(dr("solicitadopor")) Then
                txtsolicitado.Text = dr("solicitadopor")
            Else
                txtsolicitado.Text = Nothing

            End If

            If Not IsDBNull(dr("seiden")) Then
                txtidentificacion.Text = dr("seiden")
            Else
                txtidentificacion.Text = Nothing

            End If

            If Not IsDBNull(dr("nombre")) Then
                txtpropietario.Text = dr("nombre")
            Else
                txtpropietario.Text = Nothing

            End If
            '''''''
            If Not IsDBNull(dr("nombre")) Then
                lblnombreexp.Text = dr("nombre")


                'lblnombre.Text = CStr(dr("nombre"))
                nombreTitular = CStr(dr("nombre"))

            Else
                lblnombreexp.Text = Nothing

            End If

            ''''''''''



            Try
                txtescritura.Text = dr("escritura")

            Catch ex As Exception
                txtescritura.Text = String.Empty
            End Try






            If Not IsDBNull(dr("parentesco")) Then
                txtparentesco.Text = dr("parentesco")
            Else
                txtparentesco.Text = Nothing

            End If

            Cmbestado.SelectedValue = dr("estado")
            cmbtipouso.SelectedValue = dr("ID_TIPO_USUARIO")
            cmbtarifa.SelectedValue = dr("tarifa")
            'nderivacion.Value = dr("derivacion")

            txtpropietario.Enabled = False
            cmbDescuento.SelectedValue = dr("idDescuento")
            cmbCuoValvu.SelectedValue = dr("idCuotaValvulista")




            Try
                cmbDiamMed.SelectedValue = dr("diammedidor") ' obtenerCampo("select descripcion from diametros where id_diametro=""" & dr("diammedidor") & """", "descripcion")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ' cmbDiamMed.SelectedValue = dr("diammedidor")

            Try
                Cmbsector.SelectedValue = dr("SECTOR")
                cmbruta.SelectedValue = dr("ruta")
                vrut = dr("ruta")
                vreg = dr("region")
                If Not IsDBNull(dr("cp")) Then
                    txtcp.Text = dr("CP")
                End If

                If My.Settings.CombodeCalles = "SI" Then
                    llenarCombo(cmbcalle, "SELECT ID_CALLE, NOMBRE FROM CALLES  ORDER BY NOMBRE")
                    cmbcalle.SelectedValue = dr("id_calle") '  obtenerCampo("select * from calles where id_calle='" & dr("id_calle") & "'", "nombre")
                Else

                    txtDomicilio.Text = dr("Domicilio")
                End If




                If IsDBNull(dr("lote")) Then
                    txtlote.Text = "000"
                Else
                    txtlote.Text = dr("lote")
                End If
                If IsDBNull(dr("manzana")) Then
                    txtmzn.Text = "000"
                Else
                    txtmzn.Text = dr("manzana")
                End If
                If IsDBNull(dr("numext")) Then
                    txtnumext.Text = ""
                Else
                    txtnumext.Text = dr("NUMEXT")
                End If
                If IsDBNull(dr("numint")) Then
                    txtnumint.Text = ""
                Else
                    txtnumint.Text = dr("NUMINT")
                End If
                If IsDBNull(dr("cod_gir")) Then
                    cmbgiro.SelectedValue = ""
                Else
                    cmbgiro.SelectedValue = dr("cod_gir")
                End If
                Try
                    txtctoagua.Text = dr("cuentaanterior")
                Catch ex As Exception

                End Try

                'txtctodrenaje.Text = dr("cto_drenaje")
                If Not IsDBNull(dr("ESTADOPREDIO")) Then CmbEstPredio.SelectedValue = dr("ESTADOPREDIO")
                If Not IsDBNull(dr("matcalle")) Then Cmbmatcalle.SelectedValue = dr("matcalle")
                If Not IsDBNull(dr("ubmedidor")) Then cmbubmedidor.SelectedValue = dr("ubmedidor")

                If Not IsDBNull(dr("TELEFONO")) Then Me.TxtTel.Text = dr("TELEFONO")


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


            If dr("alcantarillado") = 1 Then
                chkAlcantarillado.Checked = True
            Else
                chkAlcantarillado.Checked = False
            End If

            If dr("saneamiento") = 1 Then
                chkSanea.Checked = True
            Else
                chkSanea.Checked = False
            End If
            If Not IsDBNull(dr("fechainst")) Then dtffechainst.Value = dr("fechainst")


            ' referencias ok
            If Not IsDBNull(dr("referencias")) Then txtreferencias.Text = dr("referencias")

            If dr("NIVELECONOMICO") > 0 Then cmbnivsoc.SelectedValue = dr("niveleconomico")


            If Not IsDBNull(dr("entrecalle1")) Then CMBCALLE1.SelectedValue = dr("entrecalle1")
            If Not IsDBNull(dr("entrecalle2")) Then CMBCALLE2.SelectedValue = dr("entrecalle2")
            If Not IsDBNull(dr("entrecalle3")) Then CMBCALLE3.SelectedValue = dr("entrecalle3")
            If Not IsDBNull(dr("entrecalle4")) Then CMBCALLE4.SelectedValue = dr("entrecalle4")


            txtubicacion.Text = dr("ubicacion")
            If Not IsDBNull(dr("observacion")) Then txtobservacioncontrato.Text = dr("observacion")

            txtDerivaciones.Text = dr("derivacion")

            If Not IsDBNull(dr("marcamedidor")) Then
                CmbMarcaMedidor1.Text = obtenerCampo("select id_marca,DESCRIPCION from marcasmedidor where ID_MARCA='" & dr("marcamedidor") & "'", "descripcion")
            Else
                CmbMarcaMedidor1.Text = ""
            End If
            If Not IsDBNull(dr("nodemedidor")) Then txtNoMedidor.Text = dr("nodemedidor")
            If Not IsDBNull(dr("nodemedidor")) Then txtnumerodemedidor.Text = dr("nodemedidor")
            If Not IsDBNull(dr("marcamedidor")) Then CmbMarcaMedidor.SelectedValue = dr("marcamedidor")

            CmbDiamToma.Text = obtenerCampo("select descripcion from diametros where id_diametro=""" & dr("DIAMETROTOMA") & """ ", "descripcion")
            txtCisterna.Value = dr("cAPCISTERNA")
            txtTinaco.Value = dr("CAPTINACO")
            txtAlberca.Value = dr("CAPALBERCA")
            'Ndiametromedidor.Value = dr("diammedidor")


            TxtGps1.Text = "" & dr("ubicaciongps1")
            TxtGps2.Text = "" & dr("ubicaciongps2")
            TxtGps3.Text = "" & dr("ubicaciongps3")

            ' catastral  ok
            txtcatastral.Text = "" & dr("clave_predial")


            If Not IsDBNull(dr("Cedula_Catastral")) Then
                txtCedulaC.Text = dr("Cedula_Catastral")
            End If



            cmbCaracter.Text = dr("caracter")





            ' web ok

            txtpass.Text = "" & dr("password")
            txtpreguntasecreta.Text = "" & dr("pregsect")
            txtrespsec.Text = "" & dr("ressect")
            txtemail.Text = "" & dr("email")


            'cmbcolonia.Enabled = False
            'CMBCALLE.Enabled = False
            ChkAltoCon.Checked = CBool(dr("AltoConsumidor"))
            ChkGestCob.Checked = CBool(dr("GestCob"))
            If CBool(dr("RegGis")) Then
                LblGis.BackColor = Color.GreenYellow
            Else
                LblGis.BackColor = Color.Red
            End If
            Try
                llenaGrid(DtgNombre, "SELECT `NombreAntes`,`cambionombre`.`Nombre`,`cambionombre`.`Fecha`,`cambionombre`.`Observacion`, letras.Nombre as Nombre_Usuario FROM cambionombre inner join letras on cambionombre.usuario=letras.ccodusuario where cuenta=" & cuenta)
                llenaGrid(DtgTarifa, "select  `cambiotarifa`.`AntesTarifa`,  `cambiotarifa`.`Tarifa`,`cambiotarifa`.`Fecha`, `cambiotarifa`.`Observacion`, letras.Nombre as Nombre from cambiotarifa inner join letras on  cambiotarifa.usuario = letras.ccodusuario where cuenta=" & cuenta)
                llenaGrid(DTgfecha, " SELECT `cambiofecha`.`fecha_antes`,`cambiofecha`.`fecha_despues`,`cambiofecha`.`motivo`,  `cambiofecha`.`fecha`, letras.Nombre FROM cambiofecha inner join letras on cambiofecha.usuario=letras.ccodusuario where cuenta=" & cuenta)


            Catch ex As Exception

            End Try
        End If



        If mestado = Estado.factibilidad Then
            Dim cadenadecarga As String = ""
            CmbDiamToma.Enabled = False

            cadenadecarga = "select nombre,nmunicipio,id_comunidad,id_colonia,id_calle,numext,numint,solispor,parentesco,seiden" _
            & ",cp,rfc,estadosolicitud,sector,telefono, DiamToma, CapAlberca, Capcisterna, CapTinaco" _
            & ",entrecalle1,entrecalle2,entrecalle3,entrecalle4,cod_gir,USOVERIFICADO,ESTPREDIO,region,ruta" _
            & ",lote,manzana,REFERENCIAS,Clave_predial, Domicilio" _
            & " from solicitud where numero=" & Val(lblsolicitud.Text)
            Dim dr As IDataReader, cmd As Odbc.OdbcCommand
            cmd = ConsultaSql(cadenadecarga)
            dr = cmd.ExecuteReader()

            dr.Read()

            Try
                If dr("estadosolicitud") <> "APROBADA" Then
                    MsgBox("ESTA SOLICITUD NO HA SIDO APROBADA")
                    Me.lblsolicitud.Text = ""
                    mestado = Estado.Nuevo
                    Exit Sub
                End If


                'If IsDBNull(dr("region")) Then
                '    MsgBox("LA TOMA NO HA SIDO UBICADA, TU CONTRATO NO PUEDE REALIZARSE")
                '    Exit Sub
                'End If

                'If IsDBNull(dr("ruta")) Then
                '    MsgBox("LA TOMA NO HA SIDO UBICADA, TU CONTRATO NO PUEDE REALIZARSE")
                '    Exit Sub
                'End If

                'If dr("lote") = "0" Or dr("manzana") = "0" Or dr("REGION") = "" Or dr("RUTA") = "" Then
                '    MsgBox("LA TOMA NO HA SIDO UBICADA, TU CONTRATO NO PUEDE REALIZARSE")
                '    Exit Sub
                'End If


            Catch ex As Exception
                Exit Sub
            End Try


            ' datosgenales  ok

            txtpropietario.Text = dr("nombre")
            txtpropietario.Enabled = False
            'txtsolicitado.Text = dr("soliSpor")
            'txtidentificacion.Text = dr("seiden")
            'txtparentesco.Text = dr("parentesco")

            cmbtipouso.SelectedValue = dr("USOVERIFICADO")

            Cmbsector.SelectedValue = dr("SECTOR")
            Cmbmunicipio.SelectedValue = dr("nmunicipio")
            Cmbcomunidad.SelectedValue = dr("id_comunidad")
            cmbcolonia.SelectedValue = dr("id_colonia")
            txtcp.Text = dr("CP")

            If My.Settings.CombodeCalles = "SI" Then
                llenarCombo(cmbcalle, "SELECT ID_CALLE, NOMBRE FROM CALLES  ORDER BY NOMBRE")
                cmbcalle.SelectedValue = obtenerCampo("select * from calles where id_calle='" & dr("id_calle") & "'", "nombre")
            End If
            '
            ' CMBCALLE.SelectedValue = dr("id_calle")
            txtDomicilio.Text = dr("Domicilio")

            txtlote.Text = llenaCero(dr("lote").ToString, 3)
            txtmzn.Text = llenaCero(dr("manzana").ToString, 3)
            txtnumext.Text = dr("NUMEXT")
            txtnumint.Text = dr("NUMINT")
            CmbDiamToma.SelectedValue = dr("DiamToma")
            txtAlberca.Value = dr("CapAlberca")
            txtCisterna.Value = dr("Capcisterna")
            txtTinaco.Value = dr("CapTinaco")

            'If Not IsDBNull(dr("ESTADOPREDIO")) Then
            '    CmbEstPredio.SelectedValue = dr("ESTADOPREDIO")
            'Else
            '    CmbEstPredio.Text = ""
            'End If
            Me.TxtTel.Text = dr("TELEFONO")

            ' referencias ok?????
            txtreferencias.Text = dr("referencias")

            If Not IsDBNull(dr("entrecalle3")) Then CMBCALLE1.SelectedValue = dr("entrecalle3")
            If Not IsDBNull(dr("entrecalle4")) Then CMBCALLE2.SelectedValue = dr("entrecalle4")
            If Not IsDBNull(dr("entrecalle2")) Then CMBCALLE3.SelectedValue = dr("entrecalle2")
            If Not IsDBNull(dr("entrecalle1")) Then CMBCALLE4.SelectedValue = dr("entrecalle1")

            ' catastral  ok
            txtcatastral.Text = "" & dr("clave_predial")

            Cmbmunicipio.Enabled = False
            Cmbcomunidad.Enabled = False
            cmbcolonia.Enabled = False
            'CMBCALLE.Enabled = False
            Cmbsector.Enabled = False

            cmbRegion.SelectedValue = dr("region")
            cmbruta.SelectedValue = dr("ruta")


            mestado = Estado.Nuevo
        End If
    End Sub
    Private Sub cmbtipouso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipouso.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbtipouso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipouso.SelectedIndexChanged

        'If Not cmbtipouso.SelectedValue Is Nothing AndAlso cmbtipouso.SelectedValue.ToString <> "System.Data.DataRowView" Then
        '    llenarCombo(cmbtarifa, "select id_tarifa,descripcion_cuota from cuotas where paraUso='" & cmbtipouso.SelectedValue.ToString & "' order by descripcion_cuota")
        'End If
    End Sub
    Private Sub Cmbcomunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbcomunidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub Cmbcomunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcomunidad.SelectedIndexChanged
        CrearUbicacion()
    End Sub

    Private Sub cmbcolonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcolonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbcolonia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcolonia.SelectedIndexChanged

        If Not cmbcolonia.SelectedValue Is Nothing AndAlso cmbcolonia.SelectedValue.ToString <> "System.Data.DataRowView" Then
            txtcp.Text = obtenerCampo("SELECT CP FROM colonia WHERE id_colonia='" & cmbcolonia.SelectedValue.ToString & "'", "cp")

        End If
    End Sub

#End Region

#Region "Carga de imágenes"

    Private Sub Pic1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic1.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Try

                pic1.Image = Image.FromFile(files(0))

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            Try

                pic1.Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        pic1.Invalidate()
    End Sub

    Private Sub Pic1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic1.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) _
           Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pic2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic2.DragDrop


        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Try

                pic2.Image = Image.FromFile(files(0))

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            Try

                pic2.Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If
        pic2.Invalidate()
    End Sub

    Private Sub pic4_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic4.DragDrop


        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Try

                pic4.Image = Image.FromFile(files(0))

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            Try

                pic4.Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        pic4.Invalidate()
    End Sub

    Private Sub pic3_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic3.DragDrop


        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
            Try

                pic3.Image = Image.FromFile(files(0))

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If

        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            Try

                pic3.Image = CType(e.Data.GetData(DataFormats.Bitmap), Image)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            End Try
        End If


        pic3.Invalidate()
    End Sub

    Private Sub pic2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic2.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) _
           Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pic3_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic3.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) _
           Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub pic4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles pic4.DragEnter

        If e.Data.GetDataPresent(DataFormats.Bitmap) _
           Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


#End Region

#Region "Historial"
    Private Sub guardHistorial()
        Dim cadena As String = ""
        Dim matrix() As String
        Dim motivo As String = ""

        Dim nombre_Host As String = Net.Dns.GetHostName()
        Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
        Dim direccion_Ip As String = este_Host.AddressList(0).ToString


        If matMod.Count > 0 Then
            Dim frm As New frmMotivoCont()
            frm.ShowDialog()
            motivo = frm.motivo
        End If
        For i = 1 To matMod.Count
            matrix = Split(matMod.Item(i), ", ")


            Select Case matrix(1)
                Case "txtpropietario"
                    cadena &= String.Concat(" Campo: Nombre || ", "Anterior ---> ", matrix(0), " Ahora ---> ", txtpropietario.Text)
                Case "txtmzn"
                    cadena &= String.Concat(" Campo: Manzana || ", "Anterior ---> ", matrix(0), " Ahora ---> ", txtmzn.Text)
                Case "txtlote"
                    cadena &= String.Concat(" Campo: Lote || ", "Anterior ---> ", matrix(0), " Ahora ---> ", txtlote.Text)
                Case "dtfsolicitud"
                    cadena &= String.Concat(" Campo: Fecha de solicitud || ", "Anterior ---> ", matrix(0), " Ahora ---> ", dtfsolicitud)
                Case "Cmbestado"
                    cadena &= String.Concat(" Campo: Estado || ", "Anterior ---> ", matrix(0), " Ahora ---> ", Cmbestado.SelectedItem)
                Case "cmbtipouso"
                    cadena &= String.Concat(" Campo: tipo de uso || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbtipouso.SelectedItem)
                Case "cmbtarifa"
                    cadena &= String.Concat(" Campo: Tarifa || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbtarifa.SelectedItem)
                Case "cmbFservicio"
                    cadena &= String.Concat(" Campo: Forma de servicio || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbFservicio.SelectedItem)
                Case "CmbEstPredio"
                    cadena &= String.Concat(" Campo: Estado predio || ", "Anterior ---> ", matrix(0), " Ahora ---> ", CmbEstPredio.SelectedItem)
                Case "cmbgiro"
                    cadena &= String.Concat(" Campo: Giro || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbgiro.SelectedItem)
                Case "Cmbsector"
                    cadena &= String.Concat(" Campo: Sector || ", "Anterior ---> ", matrix(0), " Ahora ---> ", Cmbsector.SelectedItem)
                Case "cmbruta"
                    cadena &= String.Concat(" Campo: Ruta || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbruta.SelectedItem)
                Case "Cmbmunicipio"
                    cadena &= String.Concat(" Campo: Municipio || ", "Anterior ---> ", matrix(0), " Ahora ---> ", Cmbmunicipio.SelectedItem)
                Case "Cmbcomunidad"
                    cadena &= String.Concat(" Campo: Comunidad || ", "Anterior ---> ", matrix(0), " Ahora ---> ", Cmbcomunidad.SelectedItem)
                Case "cmbcolonia"
                    cadena &= String.Concat(" Campo: Colonia || ", "Anterior ---> ", matrix(0), " Ahora ---> ", cmbcolonia.SelectedItem)
                    'Case "CMBCALLE"
                    '    cadena &= String.Concat(" Campo: Calle  || ", "Anterior ---> ", matrix(0), " Ahora ---> ", CMBCALLE.SelectedItem)
            End Select
            Try
                Ejecucion("insert into his_borr(fecha,nombre_op,cuenta,usuario,concepto,maquina,id_comunidad,motivo) values('" & UnixDateFormat(Now, True, True) & "','" & direccion_Ip & "'," & txtclave.Text & ",'" & txtpropietario.Text & "','" & cadena & "','" & direccion_Ip & "','" & claComu & "','" & motivo & "')")
            Catch ex As Exception

            End Try

        Next


    End Sub

    Private Sub historial(ByVal cTexto As TextBox)
        Try
            buf = cTexto.Text
            cTexto.Undo()
            matMod.Add(String.Concat(cTexto.Text, ", ", cTexto.Name))
            cTexto.Text = buf
            cTexto.SelectionStart = Len(buf)
        Catch err As Exception
        End Try

    End Sub

    Private Sub historial(ByVal cTexto As MaskedTextBox)
        Try
            buf = cTexto.Text
            cTexto.Undo()
            matMod.Add(String.Concat(cTexto.Text, ", ", cTexto.Name))
            cTexto.Text = buf
            cTexto.SelectionStart = Len(buf)
        Catch err As Exception
        End Try

    End Sub

    Private Sub historial(ByVal cCombo As ComboBox)

        Try
            Dim buf As String = ""

            If cCombo.Tag = "" Then
                If Not cCombo.SelectedValue Is Nothing AndAlso cCombo.SelectedValue.ToString <> "System.Data.DataRowView" Then
                    cCombo.Tag = cCombo.SelectedValue.ToString
                End If
            Else
                matMod.Add(String.Concat(cCombo.Tag, ", ", cCombo.Name))
            End If
        Catch err As Exception
        End Try
    End Sub

    Private Sub historial(ByVal cTime As DevComponents.Editors.DateTimeAdv.DateTimeInput)
        Try
            Dim buf As String = ""

            If cTime.Tag = "" Then
                cTime.Tag = cTime.Value
            Else
                matMod.Add(String.Concat(cTime.Tag, ", ", cTime.Name))
            End If
        Catch err As Exception
        End Try
    End Sub

    Private Sub txtpropietario_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpropietario.ModifiedChanged
        historial(txtpropietario)
    End Sub

    Private Sub txtsolicitado_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsolicitado.ModifiedChanged
        historial(txtsolicitado)
    End Sub

    Private Sub txtparentesco_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtparentesco.ModifiedChanged
        historial(txtparentesco)
    End Sub

    Private Sub txtidentificacion_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtidentificacion.ModifiedChanged
        historial(txtidentificacion)
    End Sub

    Private Sub txtmzn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmzn.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmzn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmzn.LostFocus
        Dim manzana As Integer

        manzana = Val(txtmzn.Text)
        If manzana <= 0 Then
            manzana = 0
        End If
        If manzana <= 9 Then
            txtmzn.Text = "00" & manzana
        End If
        If manzana >= 10 And manzana <= 99 Then
            txtmzn.Text = "0" & manzana
        End If
        CrearUbicacion()
    End Sub

    Private Sub txtmzn_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmzn.ModifiedChanged
        historial(txtmzn)
    End Sub

    Private Sub txtlote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlote.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlote.LostFocus
        Dim lote As Integer

        lote = Val(txtlote.Text)
        If lote <= 0 Then
            lote = 0
        End If
        If lote <= 9 Then
            txtlote.Text = "00" & lote
        End If
        If lote >= 10 And lote <= 99 Then
            txtlote.Text = "0" & lote
        End If
        CrearUbicacion()
    End Sub

    Private Sub txtlote_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlote.ModifiedChanged
        historial(txtlote)
    End Sub

    Private Sub txtnumint_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumint.ModifiedChanged
        historial(txtnumint)
    End Sub

    Private Sub txtreferencias_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtreferencias.ModifiedChanged
        historial(txtreferencias)
    End Sub

    Private Sub txtubicacion_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtubicacion.ModifiedChanged
        historial(txtubicacion)
    End Sub

    Private Sub txtGps11_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGps11.ModifiedChanged
        historial(txtGps11)
    End Sub

    Private Sub txtGps22_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGps22.ModifiedChanged
        historial(txtGps22)
    End Sub

    Private Sub txtGps33_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGps33.ModifiedChanged
        historial(txtGps33)
    End Sub

    Private Sub txtobservacioncontrato_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtobservacioncontrato.ModifiedChanged
        historial(txtobservacioncontrato)
    End Sub

    Private Sub txtnumerodemedidor_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtnumerodemedidor.ModifiedChanged
        historial(txtnumerodemedidor)
    End Sub



    Private Sub txtrespsec_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrespsec.ModifiedChanged
        historial(txtrespsec)
    End Sub

    Private Sub txtemail_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtemail.ModifiedChanged
        historial(txtrespsec)
    End Sub

    Private Sub Cmbestado_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbestado.SelectedValueChanged
        historial(Cmbestado)
    End Sub

    Private Sub cmbtipouso_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtipouso.SelectedValueChanged
        historial(cmbtipouso)
    End Sub

    Private Sub cmbtarifa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtarifa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbtarifa_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbtarifa.SelectedValueChanged
        historial(cmbtarifa)
    End Sub

    Private Sub cmbFservicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFservicio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbFservicio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFservicio.SelectedValueChanged
        historial(cmbFservicio)
    End Sub

    Private Sub CmbEstPredio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstPredio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub



    Private Sub CmbEstPredio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbEstPredio.SelectedValueChanged
        historial(CmbEstPredio)
    End Sub

    Private Sub cmbgiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbgiro.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub



    Private Sub cmbgiro_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbgiro.SelectedValueChanged
        historial(cmbgiro)
    End Sub

    Private Sub Cmbsector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbsector.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub Cmbsector_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbsector.SelectedValueChanged
        historial(Cmbsector)
    End Sub

    Private Sub cmbruta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbruta.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbruta_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbruta.SelectedValueChanged
        historial(cmbruta)
    End Sub

    Private Sub Cmbmunicipio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbmunicipio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub



    Private Sub Cmbmunicipio_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbmunicipio.SelectedValueChanged
        historial(Cmbmunicipio)
    End Sub

    Private Sub Cmbcomunidad_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmbcomunidad.SelectedValueChanged
        historial(Cmbcomunidad)
    End Sub

    Private Sub cmbcolonia_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbcolonia.SelectedValueChanged
        historial(cmbcolonia)
    End Sub

    Private Sub CMBCALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub CMBCALLE_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' historial(CMBCALLE)
    End Sub


    Private Sub TxtTel_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTel.ModifiedChanged
        historial(TxtTel)
    End Sub

    Private Sub dtfsolicitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfsolicitud.TextChanged
        historial(dtfsolicitud)
    End Sub

#End Region

    Private Sub Cmbsector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbsector.SelectedIndexChanged
        Sector = obtenerCampo("select clavesec from sectores where descripcion = '" & Cmbsector.Text & "'", "clavesec")
        'txtubicacion.Text = Sector & "-" & Ruta & "-" & Colonia & "-" & txtmzn.Text & "-" & txtlote.Text

    End Sub

    Private Sub cmbRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRegion.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRegion.SelectedIndexChanged
        Try
            llenarCombo(cmbruta, "select id_ruta, ruta from rutas where id_region='" & cmbRegion.SelectedValue.ToString & "'")
            '  llenarCombo(cmbruta, "select id_ruta, ruta from rutas")
        Catch ex As Exception

        End Try
        CrearUbicacion()
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim fs As String = obtenerCampo("select id_forma_servicio from formas_servicio where descripcion=""" & cmbFservicio.Text & """", "id_forma_servicio")
        Dim regi As String = "", tipoCont As String = "", desCont As String = ""
        Dim idtemant As IDataReader = Nothing
        Dim matcalle, ubimedidor As Integer

        If DTfechadeuda.Value < Now.AddYears(-6) Then
            MessageBox.Show("Checa tu fecha de deuda es importante poner una fecha valida legalmente")
            Exit Sub
        End If

        If cmbFservicio.Text = "" Then
            MessageBoxEx.Show("Determina la forma de servicio", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbFservicio.Select()
            Exit Sub
        End If

        If CmbEstPredio.SelectedIndex = -1 Then
            MessageBoxEx.Show("Determina el Estado del Predio", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            CmbEstPredio.Select()
            Exit Sub
        End If

        If txtcatastral.Text = "" And Len(txtcatastral.Text) = 11 Then
            MessageBoxEx.Show("Determina la clave catastral", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            txtcatastral.Select()
            Exit Sub
        End If

        'If Cmbestado.Text = "" Then
        'MessageBox.Show("Determina el estado inicial de la toma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Cmbestado.Focus()
        'Exit Sub
        'End If



        If cmbRegion.Text = "" Then
            MessageBoxEx.Show("Seleccione la región por favor", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tabsolicitud.SelectedTab = TabItem3
            cmbRegion.Select()
            Exit Sub
            'Else
            '    regi = obtenerCampo("select id_region from region where region='" & cmbRegion.Text & "'", "id_region")
        End If

        If cmbtarifa.Text = "" Then
            MessageBoxEx.Show("Falta especificar tarifa.", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbtarifa.Select()
            Exit Sub
        End If

        If txtpropietario.Text = "" Then
            MessageBoxEx.Show("Falta especificar propietario.", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            txtpropietario.Select()
            Exit Sub
        End If


        If cmbtipouso.Text = "" Then
            MessageBoxEx.Show("No especificaste el tipo de usuario", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3


            cmbtipouso.Select()
            Exit Sub
        End If

        'If Cmbsector.Text = "" Then
        '    MessageBoxEx.Show("Falta especificar ZONA.", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Tabsolicitud.SelectedTab = TabItem3
        '    Cmbsector.Select()
        '    Exit Sub

        'End If

        If cmbruta.Text = "" Then
            MessageBoxEx.Show("Falta especificar la ruta.", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbruta.Select()
            Exit Sub
        End If

        If Cmbmunicipio.Text = "" Then
            MessageBoxEx.Show("Falta especificar  municipio ", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbmunicipio.Select()
            Exit Sub
        End If

        If Cmbcomunidad.Text = "" Then
            MessageBoxEx.Show("Falta especificar comunidad", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbcomunidad.Select()
            Exit Sub
        End If

        If cmbcolonia.Text = "" Then
            MessageBoxEx.Show("Falta especificar colonia", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbcolonia.Select()
            Exit Sub
        End If


        If My.Settings.CombodeCalles = "SI" Then
            If cmbcalle.SelectedIndex = -1 Then
                MessageBox.Show("Selecciona una calle")
                Tabsolicitud.SelectedTab = TabItem3
                cmbcalle.Focus()
                Exit Sub
            End If
        Else
            If txtDomicilio.Text = "" Then
                MessageBoxEx.Show("Falta especificar el Domicilio", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tabsolicitud.SelectedTab = TabItem3
                txtDomicilio.Focus()
                Exit Sub
            End If
        End If

        If Cmbmatcalle.Text = "" Then
            MessageBoxEx.Show("No especificaste el material de la calle", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbmatcalle.Focus()
            Exit Sub
        End If

        If cmbubmedidor.SelectedItem.ToString = "" Then
            MessageBoxEx.Show("No especificaste la ubicacion del medidor", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbubmedidor.Select()
            Exit Sub
        End If

        If cmbDescuento.SelectedIndex = -1 Then
            MessageBoxEx.Show("No elegiste el tipo de descuento, no lo escribas, seleccionalo", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbgiro.Select()
            Exit Sub
        End If

        If cmbCuoValvu.SelectedIndex = -1 Then
            MessageBoxEx.Show("No elegiste si cuenta con cuota de valvulista, no lo escribas, seleccionalo", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbgiro.Select()
            Exit Sub
        End If

        If cmbgiro.SelectedIndex = -1 Then
            MessageBoxEx.Show("No elegiste el giro correctamente, no lo escribas, seleccionalo", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbgiro.Select()
            Exit Sub
        End If

        'If txtmzn.Text = "" Then
        '    MessageBoxEx.Show("No ha especificado la manzana", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Tabsolicitud.SelectedTab = TabItem3
        '    txtmzn.Select()
        '    Exit Sub
        'End If

        'If txtlote.Text = "" Then
        '    MessageBoxEx.Show("No ha especificado el folio", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Tabsolicitud.SelectedTab = TabItem3
        '    txtlote.Select()
        '    Exit Sub
        'End If

        If mestado = Estado.Nuevo Then
            Me.txtclave.Text = Val(obtenerCampo("Select max(cuenta) as x from usuario", "x")) + 1
        End If

        If txtclave.Text = "" Then
            MessageBoxEx.Show("No tiene establecido un número de contrato", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Tabsolicitud.SelectedTab = TabItem3
            txtclave.Select()
            Exit Sub
        End If

        Dim Calle As String = "", Calle1 As String = "", Calle2 As String = "", Calle3 As String = "", Calle4 As String = ""
        Dim cadenaprop As String, feccontrato As String, idtarifa As String, numext As String, numint As String, Deudafec As String
        Dim clave As String, propie As String
        Dim cp As String, rfc As String, telefono As String, diametrotoma As String, capcisterna As String, captinaco As String, capalberca As String, marcamedidor As String, alcantarillado As String, sanea As String
        Dim clavepredial As String, ubi As String, giro As String = ""
        Dim gps1 As String, gps2 As String, gps3 As String, obs As String, nivsoc As String, carac As String, escritura As String, fecacta As String


        Dim dma1 As String, dma2 As String, dma3 As String, pass As String, preg As String, resp As String, mail As String
        Dim tipusuario As String, referencias As String, solipor As String, iden As String, paren As String, nodemedidor As String, fecinst As String, diammed As String = ""
        Dim CedulaC As String
        Dim estadoPredio As String
        Dim Domicilio As String


        If Not cmbDiamMed.SelectedValue Is Nothing AndAlso cmbDiamMed.SelectedValue.ToString <> "System.Data.DataRowView" Then
            diammed = "'" & cmbDiamMed.SelectedValue.ToString & "'"
        Else
            diammed = "'NGR'"
        End If

        If Not CmbDiamToma.SelectedValue Is Nothing AndAlso CmbDiamToma.SelectedValue.ToString <> "System.Data.DataRowView" Then
            diametrotoma = "'" & CmbDiamToma.SelectedValue.ToString & "'"
        Else
            diametrotoma = "'NRG'"
        End If

        clave = "'" & txtclave.Text & "'"
        propie = "'" & txtpropietario.Text & "'"
        CedulaC = "'" & txtCedulaC.Text & "'"
        Municipio = CInt(Cmbmunicipio.SelectedValue.ToString)
        Colonia = cmbcolonia.SelectedValue.ToString

        If My.Settings.CombodeCalles = "SI" Then

            Calle = "'" & cmbcalle.SelectedValue & "'"
        Else
            Calle = "'XXX'"
            Domicilio = "'" & txtDomicilio.Text & "'"
        End If


        If Not CMBCALLE1.SelectedValue Is Nothing AndAlso CMBCALLE1.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Calle1 = "'" & CMBCALLE1.SelectedValue.ToString & "'"
        Else
            Calle1 = "''"
        End If

        If Not CMBCALLE2.SelectedValue Is Nothing AndAlso CMBCALLE2.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Calle2 = "'" & CMBCALLE2.SelectedValue.ToString & "'"
        Else
            Calle2 = "''"
        End If

        If Not CMBCALLE3.SelectedValue Is Nothing AndAlso CMBCALLE3.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Calle3 = "'" & CMBCALLE3.SelectedValue.ToString & "'"
        Else
            Calle3 = "''"
        End If

        If Not CMBCALLE4.SelectedValue Is Nothing AndAlso CMBCALLE4.SelectedValue.ToString <> "System.Data.DataRowView" Then
            Calle4 = "'" & CMBCALLE4.SelectedValue.ToString & "'"
        Else
            Calle4 = "''"
        End If

        comunidad = Cmbcomunidad.SelectedValue.ToString
        solipor = "'" & txtsolicitado.Text & "'"
        iden = "'" & txtidentificacion.Text & "'"
        paren = "'" & txtparentesco.Text & "'"
        cadenaprop = "'" & Me.txtpropietario.Text & "'"
        feccontrato = "'" & UnixDateFormat(dtfsolicitud.Value) & "'"
        idtarifa = "'" & cmbtarifa.SelectedValue.ToString & "'"
        If idtarifa = "''" Then
            MessageBoxEx.Show("Es importante elegir una tarifa correctamente", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        numext = "'" & txtnumext.Text & "'"
        numint = "'" & txtnumint.Text & "'"
        cp = "'" & txtcp.Text & "'"

        tipusuario = "'" & cmbtipouso.SelectedValue.ToString & "'"
        referencias = "'" & txtreferencias.Text & "'"
        If tipusuario = "''" Then
            MessageBoxEx.Show("No elegiste un tipo de usuario correcto", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'Try
        '    Sector = Cmbsector.SelectedValue
        '    If Sector = "" Then
        '        MessageBoxEx.Show("Selecciona el sector correctamente", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If

        'Catch ex As Exception
        '    Sector = "000"
        'End Try
        nodemedidor = "'" & Me.txtnumerodemedidor.Text & "'"
        telefono = "'" & Me.TxtTel.Text & "'"

        capcisterna = Val(txtCisterna.Value)
        captinaco = Val(txtTinaco.Value)
        capalberca = Val(txtAlberca.Value)
        If Not CmbMarcaMedidor.SelectedValue Is Nothing AndAlso CmbMarcaMedidor.SelectedValue.ToString <> "System.Data.DataRowView" Then
            marcamedidor = "'" & CmbMarcaMedidor.SelectedValue.ToString & "'"
        Else
            marcamedidor = "'NRG'"
        End If

        clavepredial = "'" & txtcatastral.Text & "'"

        ubi = "'" & txtubicacion.Text & "'"
        Try
            Ruta = cmbruta.SelectedValue.ToString
        Catch ex As Exception
            Ruta = ""
        End Try

        gps1 = "'" & txtGps11.Text & "'"
        gps2 = "'" & txtGps22.Text & "'"
        gps3 = "'" & txtGps33.Text & "'"

        obs = "'" & txtobservacioncontrato.Text & "'"
        If Not cmbgiro.SelectedValue Is Nothing AndAlso cmbgiro.SelectedValue.ToString <> "System.Data.DataRowView" Then
            giro = cmbgiro.SelectedValue.ToString
        Else
            MessageBoxEx.Show("No seleccionaste un giro valido", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If Not cmbnivsoc.SelectedValue Is Nothing AndAlso cmbnivsoc.SelectedValue.ToString <> "System.Data.DataRowView" Then
            nivsoc = cmbnivsoc.SelectedValue.ToString
        Else
            nivsoc = "0"
        End If

        carac = "'" & cmbCaracter.Text & "'"
        escritura = "'" & txtescritura.Text & "'"

        fecinst = "'" & UnixDateFormat(dtffechainst.Value) & "'"
        Deudafec = "'" & UnixDateFormat(DTfechadeuda.Value) & "'"

        pass = "'" & txtpass.Text & "'"
        preg = "'" & txtpreguntasecreta.Text & "'"
        resp = "'" & txtrespsec.Text & "'"
        mail = "'" & txtemail.Text & "'"
        Dim reple As String


        If chkAlcantarillado.Checked = True Then
            alcantarillado = "1"
        Else
            alcantarillado = "0"
        End If

        If chkSanea.Checked = True Then
            sanea = "1"
        Else
            sanea = "0"
        End If



        ' costruyo la cadena para el megainsert
        If mestado = frmcontrato.Estado.Nuevo Then
            Dim insert As String
            Dim CADENAINSERT As New StringBuilder
            If _vengo = _vengode.solicitud Then
                regi = cmbRegion.SelectedValue.ToString
                clave = "'" & txtclave.Text & "'"

                CADENAINSERT.Append("insert into usuario set ")
                CADENAINSERT.Append("cuenta=" & clave & ",")
                '   CADENAINSERT.Append("cuentaAnterior='" & txtInmueble.Text & "',")
                CADENAINSERT.Append("nombre=" & propie & ",")
                CADENAINSERT.Append("nmunicipio='" & Municipio & "',")
                CADENAINSERT.Append("id_comunidad='" & comunidad & "',")
                CADENAINSERT.Append("id_colonia='" & Colonia & "',")
                CADENAINSERT.Append("id_calle=" & Calle & ",")
                CADENAINSERT.Append("numext=" & numext & ",")
                CADENAINSERT.Append("numint=" & numint & ",")
                CADENAINSERT.Append("fechaalta=" & feccontrato & ",")
                CADENAINSERT.Append("cp=" & cp & ",")
                CADENAINSERT.Append("rfc='" & rfc & "',")
                CADENAINSERT.Append("sector='" & Sector & "',")
                CADENAINSERT.Append("ruta='" & Ruta & "',")
                CADENAINSERT.Append("telefono=" & telefono & ",")
                CADENAINSERT.Append("alcantarillado='" & alcantarillado & "',")
                CADENAINSERT.Append("saneamiento='" & sanea & "',")
                CADENAINSERT.Append("convenio='0',")
                CADENAINSERT.Append("clave_predial=" & CedulaC & ",")
                CADENAINSERT.Append("tarifa=" & idtarifa & ",")
                CADENAINSERT.Append("ubicacion=" & ubi & ",")
                CADENAINSERT.Append("entrecalle1=" & Calle1 & ",")
                CADENAINSERT.Append("entrecalle2=" & Calle2 & ",")
                CADENAINSERT.Append("entrecalle3=" & Calle3 & ",")
                CADENAINSERT.Append("entrecalle4=" & Calle4 & ",")
                CADENAINSERT.Append("cod_gir='" & giro & "',")
                CADENAINSERT.Append("observacion=" & obs & ",")
                CADENAINSERT.Append("niveleconomico='" & nivsoc & "',")
                CADENAINSERT.Append("lote=" & Val(txtlote.Text) & ",")
                CADENAINSERT.Append("manzana=" & txtmzn.Text & ",")
                CADENAINSERT.Append("caracter=" & carac & ",")


                CADENAINSERT.Append("estadopredio='" & CmbEstPredio.SelectedValue & "',")
                'CADENAINSERT.Append("represeNtantelegal='" & reple & "',")
                CADENAINSERT.Append("DomicilioAudiencia='" & dma1 & "',")
                CADENAINSERT.Append("DomicilioAudiencia1='" & dma2 & "',")
                CADENAINSERT.Append("DomicilioAudiencia2='" & dma3 & "',")
                CADENAINSERT.Append("password=" & pass & ",")
                CADENAINSERT.Append("pregsect=" & preg & ",")
                CADENAINSERT.Append("ressect=" & resp & ",")
                CADENAINSERT.Append("email=" & mail & ",")
                CADENAINSERT.Append("referencias=" & referencias & ",")
                CADENAINSERT.Append("id_tipo_usuario=" & tipusuario & ",")
                CADENAINSERT.Append("ID_FORMA_SERVICIO='" & fs & "',")
                CADENAINSERT.Append("ESCRITURA='" & txtescritura.Text & "',")
                'CADENAINSERT.Append("DirUbi='" & rbDirUbi.Checked & "',")
                ' CADENAINSERT.Append("DirAu='" & rbDomAu.Checked & "',")
                'CADENAINSERT.Append("DirFis='" & rbDirFis.Checked & "',")
                CADENAINSERT.Append("DirUbi='" & dUbi & "',")
                CADENAINSERT.Append("DirAu='" & dAu & "',")
                CADENAINSERT.Append("DirFis='" & dFis & "',")
                CADENAINSERT.Append("estado='1',")
                CADENAINSERT.Append("region='" & regi & "',")
                'CADENAINSERT.Append("factibilidad='',")
                CADENAINSERT.Append("solicitud='" & lblsolicitud.Text & "',")
                CADENAINSERT.Append("AltoConsumidor='" & AC & "',")
                CADENAINSERT.Append("GestCob='" & GC & "',")
                CADENAINSERT.Append("DiametroToma=" & diametrotoma & ",")
                CADENAINSERT.Append("Marcamedidor=" & marcamedidor & ",")
                CADENAINSERT.Append("diammedidor=" & diammed & ",")
                CADENAINSERT.Append("fechainst=" & fecinst & ",")
                CADENAINSERT.Append("derivacion='" & nderivacion.Value & "',")
                CADENAINSERT.Append("capcisterna='" & capcisterna & "',")
                CADENAINSERT.Append("captinaco='" & captinaco & "',")
                CADENAINSERT.Append("capalberca='" & capalberca & "',")
                CADENAINSERT.Append("nodemedidor=" & nodemedidor & ",")
                CADENAINSERT.Append("matcalle='" & Cmbmatcalle.SelectedValue.ToString & "',")
                CADENAINSERT.Append("ubmedidor='" & cmbubmedidor.SelectedValue.ToString & "',")
                CADENAINSERT.Append("cto_agua='" & txtctoagua.Text.Replace("A", "").Replace("B", "").Replace("C", "").Replace("-", "") & "',")
                CADENAINSERT.Append("cto_drenaje='" & txtctodrenaje.Text & "',")
                CADENAINSERT.Append("DEUDAFEC=" & Deudafec & ",")
                CADENAINSERT.Append("Domicilio=" & Domicilio & ",")
                CADENAINSERT.Append("idDescuento='" & cmbDescuento.SelectedValue & "',")
                CADENAINSERT.Append("idCuotaValvulista='" & cmbCuoValvu.SelectedValue & "',")
                CADENAINSERT.Append("Cedula_Catastral=" & CedulaC & "")

                Ejecucion("Update solicitud set estadosolicitud = 'CONTRATADA' WHERE Numero = " & lblsolicitud.Text & "")

            Else
                'Dim frm As New frmCuenDis(comunidad)
                'frm.ShowDialog()
                'If frm._cuenta <> 0 Then
                '    txtclave.Text = frm._cuenta
                'End If
                If txtctoagua.Text = "" Then txtctoagua.Text = 0
                If txtctodrenaje.Text = "" Then txtctodrenaje.Text = 0

                If Cmbmatcalle.Text = "" Then Cmbmatcalle.Text = 0

                regi = cmbRegion.SelectedValue.ToString

                If Cmbmatcalle.Text = "" Then
                    matcalle = 0
                Else
                    matcalle = Cmbmatcalle.SelectedValue.ToString
                End If

                If cmbubmedidor.Text = "" Then
                    ubimedidor = 0
                Else
                    ubimedidor = cmbubmedidor.SelectedValue.ToString
                End If

                If CmbEstPredio.Text = "" Then
                    estadoPredio = ""
                Else
                    estadoPredio = CmbEstPredio.SelectedValue.ToString
                End If

                clave = "'" & txtclave.Text & "'"

                CADENAINSERT.Append("insert into usuario set ")
                CADENAINSERT.Append("cuenta=" & clave & ",")
                'CADENAINSERT.Append("cuentaAnterior='" & txtInmueble.Text & "',")
                CADENAINSERT.Append("nombre=" & propie & ",")
                CADENAINSERT.Append("nmunicipio='" & Municipio & "',")
                CADENAINSERT.Append("id_comunidad='" & comunidad & "',")
                CADENAINSERT.Append("id_colonia='" & Colonia & "',")
                If My.Settings.CombodeCalles.ToUpper = "NO" Then
                    CADENAINSERT.Append("id_calle='XXX',")
                    CADENAINSERT.Append("Domicilio=" & Domicilio & ",")

                Else
                    CADENAINSERT.Append("id_calle='" & cmbcalle.SelectedValue & "',")
                    CADENAINSERT.Append("Domicilio='',")
                End If
                CADENAINSERT.Append("numext=" & numext & ",")
                CADENAINSERT.Append("numint=" & numint & ",")
                CADENAINSERT.Append("estadopredio='" & estadoPredio & "',")
                CADENAINSERT.Append("fechaalta=" & feccontrato & ",")
                CADENAINSERT.Append("cp=" & cp & ",")
                CADENAINSERT.Append("rfc='" & rfc & "',")
                CADENAINSERT.Append("sector='" & Sector & "',")
                CADENAINSERT.Append("ruta='" & Ruta & "',")
                CADENAINSERT.Append("telefono=" & telefono & ",")
                CADENAINSERT.Append("diametrotoma=" & diametrotoma & ",")
                CADENAINSERT.Append("capcisterna='" & capcisterna & "',")
                CADENAINSERT.Append("captinaco='" & captinaco & "',")
                CADENAINSERT.Append("capalberca='" & capalberca & "',")
                CADENAINSERT.Append("marcamedidor=" & marcamedidor & ",")
                CADENAINSERT.Append("alcantarillado='" & alcantarillado & "',")
                CADENAINSERT.Append("saneamiento='" & sanea & "',")
                CADENAINSERT.Append("convenio='0',")
                CADENAINSERT.Append("clave_predial=" & CedulaC & ",")
                CADENAINSERT.Append("tarifa=" & idtarifa & ",")
                CADENAINSERT.Append("ubicacion=" & ubi & ",")
                CADENAINSERT.Append("entrecalle1=" & Calle1 & ",")
                CADENAINSERT.Append("entrecalle2=" & Calle2 & ",")
                CADENAINSERT.Append("entrecalle3=" & Calle3 & ",")
                CADENAINSERT.Append("entrecalle4=" & Calle4 & ",")
                CADENAINSERT.Append("cod_gir='" & giro & "',")
                CADENAINSERT.Append("ubicaciongps1=" & gps1 & ",")
                CADENAINSERT.Append("ubicaciongps2=" & gps2 & ",")
                CADENAINSERT.Append("ubicaciongps3=" & gps3 & ",")
                CADENAINSERT.Append("observacion=" & obs & ",")
                CADENAINSERT.Append("niveleconomico='" & nivsoc & "',")
                CADENAINSERT.Append("lote=" & Val(txtlote.Text) & ",")
                CADENAINSERT.Append("manzana=" & txtmzn.Text & ",")
                CADENAINSERT.Append("caracter=" & carac & ",")


                CADENAINSERT.Append("DomicilioAudiencia='" & dma1 & "',")
                CADENAINSERT.Append("DomicilioAudiencia1='" & dma2 & "',")
                CADENAINSERT.Append("DomicilioAudiencia2='" & dma3 & "',")
                CADENAINSERT.Append("password=" & pass & ",")
                CADENAINSERT.Append("pregsect=" & preg & ",")
                CADENAINSERT.Append("ressect=" & resp & ",")
                CADENAINSERT.Append("email=" & mail & ",")
                CADENAINSERT.Append("referencias=" & referencias & ",")
                CADENAINSERT.Append("id_tipo_usuario=" & tipusuario & ",")
                CADENAINSERT.Append("ID_FORMA_SERVICIO='" & fs & "',")
                CADENAINSERT.Append("ESCRITURA='" & txtescritura.Text & "',")
                'CADENAINSERT.Append("DirUbi='" & rbDirUbi.Checked & "',")
                'CADENAINSERT.Append("DirAu='" & rbDomAu.Checked & "',")
                'CADENAINSERT.Append("DirFis='" & rbDirFis.Checked & "',")
                CADENAINSERT.Append("DirUbi='" & dUbi & "',")
                CADENAINSERT.Append("DirAu='" & dAu & "',")
                CADENAINSERT.Append("DirFis='" & dFis & "',")
                CADENAINSERT.Append("solicitadopor='" & txtsolicitado.Text & "',")
                CADENAINSERT.Append("parentesco='" & txtparentesco.Text & "',")
                CADENAINSERT.Append("seiden='" & txtidentificacion.Text & "',")
                CADENAINSERT.Append("derivacion='" & nderivacion.Value & "',")
                CADENAINSERT.Append("diammedidor=" & diammed & ",")
                CADENAINSERT.Append("nodemedidor=" & nodemedidor & ",")
                CADENAINSERT.Append("fechainst=" & fecinst & ",")
                CADENAINSERT.Append("estado='1',")
                CADENAINSERT.Append("region='" & regi & "',")
                CADENAINSERT.Append("AltoConsumidor='" & AC & "',")
                CADENAINSERT.Append("GestCob='" & GC & "',")
                CADENAINSERT.Append("matcalle='" & matcalle & "',")
                CADENAINSERT.Append("ubmedidor='" & ubimedidor & "',")
                CADENAINSERT.Append("cto_agua='" & txtctoagua.Text.Replace("A", "").Replace("B", "").Replace("C", "").Replace("-", "") & "',")
                CADENAINSERT.Append("cto_drenaje='" & txtctodrenaje.Text & "',")
                CADENAINSERT.Append("DEUDAFEC=" & Deudafec & ",")


                CADENAINSERT.Append("idDescuento='" & cmbDescuento.SelectedValue & "',")
                CADENAINSERT.Append("idCuotaValvulista='" & cmbCuoValvu.SelectedValue & "',")
                CADENAINSERT.Append("Cedula_Catastral=" & CedulaC & "")

            End If

            'insert = megainser1 & megainsert2
            insert = CADENAINSERT.ToString()
            Dim exito As Integer = 1
            Try
                Ejecucion(insert)
            Catch ERR As Exception
                exito = 0
                If Mid(ERR.Message.ToString, 1, 21) = "ERROR [HY000] [MySQL]" Then
                    MessageBoxEx.Show(ERR.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBoxEx.Show(ERR.Message, "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Try

            If exito = 1 Then


                MessageBoxEx.Show("Los datos se guardaron satisfactoriamente", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)

                mestado = frmcontrato.Estado.Editar
                Cmbmunicipio.Enabled = False
                Cmbcomunidad.Enabled = False
                '  Ejecucion("update comunidades set no_contrato=" & txtclave.Text & " where id_comunidad='" & comunidad & "'")
                My.Forms.frmBusUsuario.cmdActi.Enabled = True
                My.Forms.frmBusUsuario.cmdInstaB.Enabled = True
            Else
                MessageBoxEx.Show("Los datos no se guardaron verifica por favor los valores introducidos", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


            ', id_calle='" & CMBCALLE.SelectedValue.ToString & 


        ElseIf mestado = Estado.Editar Then
            Dim megaupdate As String
            regi = cmbRegion.SelectedValue

            If DTfechadeuda.Value.Year < 2000 Then
                MessageBox.Show("No puedo hasta que pongas una fecha de deuda")
                Exit Sub
            End If

            If My.Settings.CombodeCalles = "NO" Then
                megaupdate = "update usuario set nombre= " & propie & "," & "id_colonia='" & Colonia & "', numext=" & numext & ", numint=" & numint & ", fechaalta=" & feccontrato _
                        & ", cp=" & cp & ",rfc='" & rfc & "', sector='" & Sector & "', ruta ='" & Ruta & "', telefono=" & telefono & ", alcantarillado=" & alcantarillado & ", saneamiento=" & sanea _
                        & ", tarifa=" & idtarifa & ",clave_predial='" & txtcatastral.Text & "',ubicacion= " & ubi & ",entrecalle1=" & Calle1 & ",entrecalle2=" & Calle2 & ",entrecalle3=" & Calle3 & ",entrecalle4=" & Calle4 & ",cod_gir='" & giro _
                        & "', ubicaciongps1=" & gps1 & ",ubicaciongps2=" & gps2 & ",ubicaciongps3=" & gps3 & ",observacion=" & obs & ",niveleconomico=" & nivsoc & ",lote=" & Val(txtlote.Text) & ",manzana='" & txtmzn.Text & "',caracter=" & carac & ",escritura='" & txtescritura.Text & "'" _
                        & ",DomicilioAudiencia='" & dma1 & "',DomicilioAudiencia1='" & dma2 & "',DomicilioAudiencia2='" & dma3 & "',password=" & pass & ",pregsect=" _
                        & preg & ",ressect=" & resp & ",email=" & mail & ",referencias=" & referencias & ",id_tipo_usuario=" & tipusuario & ",estadopredio='" & CmbEstPredio.SelectedValue & "', ID_FORMA_SERVICIO=""" _
                        & fs & """,DirUbi=" & rbDirUbi.Checked _
                        & ",  DirFis=" & rbDirFis.Checked & ", region='" & regi & "', Altoconsumidor = " & ChkAltoCon.Checked & ", GestCob = " & ChkGestCob.Checked & ", nodemedidor=" & nodemedidor _
                        & ", marcamedidor=" & marcamedidor & ",cto_agua=" & txtctoagua.Text & " ,cto_drenaje=" & txtctodrenaje.Text & ",derivacion=" & nderivacion.Value & ",Cedula_Catastral=" & CedulaC _
                        & ", deudafec='" & DTfechadeuda.Value.Year & "-" & DTfechadeuda.Value.Month & "-" & DTfechadeuda.Value.Day & "',Domicilio='" & txtDomicilio.Text & "',idDescuento='" & cmbDescuento.SelectedValue & "',idCuotaValvulista='" & cmbCuoValvu.SelectedValue & "', estado='" & Cmbestado.SelectedValue & "', id_comunidad='" & Cmbcomunidad.SelectedValue & "' where cuenta=" & txtclave.Text







            Else
                megaupdate = "update usuario set nombre= " & propie & ", " & " ID_CALLE ='" & cmbcalle.SelectedValue & "', id_colonia='" & Colonia & "', numext=" & numext & ", numint=" & numint & ", fechaalta=" & feccontrato _
                        & ", cp=" & cp & ",rfc='" & rfc & "', sector='" & Sector & "', ruta ='" & Ruta & "', telefono=" & telefono & ", alcantarillado=" & alcantarillado & ", saneamiento=" & sanea _
                        & ", tarifa=" & idtarifa & ",clave_predial='" & txtcatastral.Text & "',ubicacion= " & ubi & ",entrecalle1=" & Calle1 & ",entrecalle2=" & Calle2 & ",entrecalle3=" & Calle3 & ",entrecalle4=" & Calle4 & ",cod_gir='" & giro _
                        & "', ubicaciongps1=" & gps1 & ",ubicaciongps2=" & gps2 & ",ubicaciongps3=" & gps3 & ",observacion=" & obs & ",niveleconomico=" & nivsoc & ",lote=" & Val(txtlote.Text) & ",manzana='" & txtmzn.Text & "',caracter=" & carac & ",escritura='" & txtescritura.Text & "'" _
                        & ",DomicilioAudiencia='" & dma1 & "',DomicilioAudiencia1='" & dma2 & "',DomicilioAudiencia2='" & dma3 & "',password=" & pass & ",pregsect=" _
                        & preg & ",ressect=" & resp & ",email=" & mail & ",referencias=" & referencias & ",id_tipo_usuario=" & tipusuario & ",estadopredio='" & CmbEstPredio.SelectedValue & "', ID_FORMA_SERVICIO=""" _
                        & fs & """,DirUbi=" & rbDirUbi.Checked _
                        & ",  DirFis=" & rbDirFis.Checked & ", region='" & regi & "', Altoconsumidor = " & ChkAltoCon.Checked & ", GestCob = " & ChkGestCob.Checked & ", nodemedidor=" & nodemedidor _
                        & ", marcamedidor=" & marcamedidor & ",cto_agua=" & txtctoagua.Text & " ,cto_drenaje=" & txtctodrenaje.Text & ",derivacion=" & nderivacion.Value & ",Cedula_Catastral=" & CedulaC _
                        & ", deudafec='" & DTfechadeuda.Value.Year & "-" & DTfechadeuda.Value.Month & "-" & DTfechadeuda.Value.Day & "',Domicilio='" & txtDomicilio.Text & "',idDescuento='" & cmbDescuento.SelectedValue & "',idCuotaValvulista='" & cmbCuoValvu.SelectedValue & "', estado='" & Cmbestado.SelectedValue & "', id_comunidad='" & Cmbcomunidad.SelectedValue & "' where cuenta=" & txtclave.Text





            End If
            Ejecucion(megaupdate)

            'Agregar cambio DeudaFec a bitacora del usuario

            Dim nombre_Host As String = Net.Dns.GetHostName()
            Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString
            Dim SQLBitacora As String = ""

            Try
                SQLBitacora = "insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','Cambio Fecha Deuda'," & txtclave.Text & "," & NumUser & ",'CAMBIO DE LA FECHA DE DEUDA, FECHA DEUDA ANTES: " & fechaDeudaAntes & ", FECHA DEUDA AHORA: " & DTfechadeuda.Value.Day & "/" & DTfechadeuda.Value.Month & "/" & DTfechadeuda.Value.Year & "','" & direccion_Ip & "','CAMBIO DE LA FECHA DE DEUDA')"
                Ejecucion(SQLBitacora)

                MessageBoxEx.Show("Registro realizado satisfactoriamente en la bitacora", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ButtonX1.Enabled = True

                'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                '  BtnAceptar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
            End Try
            'MsgBox("Cambio de tarifa realizada satisfactoriamente", MsgBoxStyle.Information, "")
            'ButtonX1.Enabled = True
            'cmdGenCob.Enabled = True
            'BtnAceptar.Enabled = False
            guardHistorial()
            MessageBox.Show("Datos guardados satisfactoriamente", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If




        '********************************************************************************

        img1 = txtclave.Text & "F1" & ".jpg"
        img2 = txtclave.Text & "F2" & ".jpg"
        img3 = txtclave.Text & "M1" & ".jpg"
        img4 = txtclave.Text & "M2" & ".jpg"

        Try
            pic1.Image.Save(String.Concat(RutaImagenes, "/", img1))
        Catch ex As Exception

        End Try
        Try
            pic2.Image.Save(String.Concat(RutaImagenes, "/", img2))
        Catch ex As Exception

        End Try
        Try
            pic3.Image.Save(String.Concat(RutaImagenes, "/", img3))
        Catch ex As Exception

        End Try
        Try
            pic4.Image.Save(String.Concat(RutaImagenes, "/", img4))
        Catch ex As Exception

        End Try
        'Try

        tabDocumentos.Visible = True





        'Catch ex As Exception
        '    Try
        '        Dim ima1 As New Bitmap(pic1.Image), ima2 As New Bitmap(pic2.Image), ima3 As New Bitmap(pic3.Image), ima4 As New Bitmap(pic4.Image)
        '        ima1.Save(String.Concat(RutaImagenes, "/", img1))
        '        ima2.Save(String.Concat(RutaImagenes, "/", img2))
        '        ima3.Save(String.Concat(RutaImagenes, "/", img3))
        '        ima4.Save(String.Concat(RutaImagenes, "/", img4))
        '    Catch err As Exception

        '    End Try
        'End Try
        Try
            Ejecucion("update usuario set foto1=""" & img1 & """, foto2=""" & img2 & """, foto3=""" & img3 & """, foto4=""" & img4 & """ where cuenta=" & txtclave.Text & " ")
        Catch ex As Exception

        End Try


        Try
            frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
        Catch ex As Exception
        End Try

        Try
            frmListSoli.CatControl1.Actualizar()
        Catch ex As Exception
        End Try
        '***********************VERIFICACIÓN DE TEMPORALES DE LECTURAS
        If mestado = Estado.Editar Then
            Try
                If Not cmbRegion.SelectedValue.ToString = vreg OrElse Not cmbruta.SelectedValue.ToString = vrut Then
                    If obtenerCampo("select count(*) as tot from tmplecturas" & "_" & vreg & "_" & vrut & "", "tot") > 0 Then
                        If obtenerCampo("select count(*) as tot from tmplecturas" & "_" & cmbRegion.SelectedValue.ToString & "_" & cmbruta.SelectedValue.ToString & "", "tot") > 0 Then
                            Ejecucion("insert into  tmplecturas" & "_" & cmbRegion.SelectedValue.ToString & "_" & cmbruta.SelectedValue.ToString & " select * from tmplecturas" & Cmbcomunidad.SelectedValue.ToString & "_" & vreg & "_" & vrut & " where cuenta=" & txtclave.Text & " ")
                            Ejecucion("update tmplecturas" & "_" & cmbRegion.SelectedValue.ToString & "_" & cmbruta.SelectedValue.ToString & " set sector='" & Cmbsector.SelectedValue.ToString & "', ruta='" & cmbruta.SelectedValue.ToString & "', manzana='" & txtmzn.Text & "',lote=" & Val(txtlote.Text) & ", region='" & cmbRegion.SelectedValue.ToString & "' where cuenta=" & txtclave.Text & " ")
                            Ejecucion("delete from tmplecturas" & "_" & vreg & "_" & vrut & " where cuenta=" & txtclave.Text & " ")

                        End If
                    End If
                    MessageBoxEx.Show("La región o la ruta fueron cambiados, si ya capturó las lecturas de la nueva región veifique su listado, por favor", "Contratos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception

            End Try
        End If


        If contratonuevo = 1 Or contratonuevo2 = 1 Then

            If contratonuevo = 1 Then Ejecucion("update empresa set folio_cto_agua= folio_cto_agua+1")
            If contratonuevo2 = 1 Then Ejecucion("update empresa set folio_cto_drenaje= folio_cto_drenaje+1")

            MessageBoxEx.Show("Debe generar el cargo por el contrato generado", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm As New frmagrmov(eve.Contratos, Val(txtclave.Text), txtpropietario.Text, idcomacargar)
            frm.ShowDialog()
        End If

        cmdImp.Visible = True
        cmdMail.Visible = True
        'cmdOrdTrab1.Visible = True
        cmdAgrCar.Visible = True
        cmdAcept.Visible = False
        rbOp.Refresh()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim Impr As New FrmTipoImprContrato(txtclave.Text, Cmbcomunidad.Text)
        Impr.RBcontrato1.Checked = True
        Impr.CambioNombre = False
        Impr.ShowDialog()
    End Sub

    'Private Sub cmdOrdTrab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOrdTrab1.Click
    '    Dim frmrep As New frmReporte("OrdenTrabajo.rpt", "{vusuario1.cuenta}=" & txtclave.Text & " and {vusuario1.comunidad}=""" & Cmbcomunidad.SelectedItem & """", "Orden de trabajo")
    '    frmrep.MdiParent = My.Forms.MDIPrincipal
    '    frmrep.Show()
    '    frmrep.WindowState = FormWindowState.Maximized
    'End Sub

    Private Sub cmdAgrCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrCar.Click
        Dim frm As New frmagrmov(eve.Contratos, Val(txtclave.Text), txtpropietario.Text, idcomacargar)
        frm.ShowDialog()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub Cmbmunicipio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbmunicipio.SelectedIndexChanged

        If Not Cmbmunicipio.SelectedValue Is Nothing AndAlso Cmbmunicipio.SelectedValue.ToString <> "System.Data.DataRowView" Then
            llenarCombo(Cmbcomunidad, "select id_comunidad, comunidad from comunidades where nmpio = '" & Cmbmunicipio.SelectedValue.ToString & "' order by comunidad")
        End If
    End Sub

    Private Sub cmbruta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbruta.SelectedIndexChanged
        'Ruta = obtenerCampo("select claveruta from rutas where descripcion=""" & cmbruta.Text & """", "claveruta")
        If Not cmbruta.SelectedValue Is Nothing AndAlso cmbruta.SelectedValue.ToString <> "System.Data.DataRowView" Then
            cruta(Sector, cmbruta.SelectedValue.ToString, Colonia, txtmzn.Text, txtlote.Text)
            CrearUbicacion()

        End If
    End Sub


    Private Sub CrearUbicacion()
        Dim Com, Reg, Rut As String
        Com = ""

        Try
            Reg = cmbRegion.SelectedValue
        Catch ex As Exception
            Reg = ""
        End Try
        Try
            Rut = cmbruta.SelectedValue
        Catch ex As Exception
            Rut = ""
        End Try
        Try
            LLENALOTE()
        Catch ex As Exception

        End Try


        Try
            txtUbicacion.Text = Rut & Cmbcomunidad.SelectedValue & txtlote.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtmzn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmzn.TextChanged
        CrearUbicacion()
    End Sub

    Private Sub txtlote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlote.TextChanged
        CrearUbicacion()
    End Sub
    Private Sub rbDirUbi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDirUbi.GotFocus
        rbDirUbi.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub

    Private Sub rbDirUbi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDirUbi.LostFocus
        rbDirUbi.BackColor = Color.Transparent
    End Sub
    Private Sub rbDomAu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDomAu.GotFocus
        rbDomAu.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub

    Private Sub rbDomAu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDomAu.LostFocus
        rbDomAu.BackColor = Color.Transparent
    End Sub


    Private Sub cmbnivsoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbnivsoc.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CMBCALLE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


    Private Sub CMBCALLE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CMBCALLE3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE3.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CMBCALLE4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE4.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbMarcaMedidor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbMarcaMedidor.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbDiamMed_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDiamMed.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CmbDiamToma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbDiamToma.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub cmbRegion_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRegion.SelectedValueChanged
        historial(cmbRegion)
    End Sub


    Private Sub LLENAMANZANA()
        Dim manzana As Integer
        manzana = Val(txtmzn.Text)
        If manzana <= 0 Then
            manzana = 0
        End If
        If manzana <= 9 Then
            txtmzn.Text = "00" & manzana
        End If
        If manzana >= 10 And manzana <= 99 Then
            txtmzn.Text = "0" & manzana
        End If

    End Sub

    Private Sub LLENALOTE()
        Dim lote As Integer
        lote = Val(txtlote.Text)
        If lote <= 0 Then
            lote = 0
            txtlote.Text = "0000"
        End If

        If lote <= 9 Then
            txtlote.Text = "000" & lote
        End If
        If lote >= 10 And lote <= 99 Then
            txtlote.Text = "00" & lote
        End If
        If lote >= 100 And lote <= 999 Then
            txtlote.Text = "0" & lote
        End If


    End Sub


    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If txtctoagua.Text = "0" Then
            txtctoagua.Text = obtenerCampo("select * from empresa", "folio_cto_agua")
            contratonuevo = 1
        Else
            MessageBoxEx.Show("ya tiene un numero de contrato asignado", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub TextBoxX2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If txtctodrenaje.Text = "0" Then
            txtctodrenaje.Text = obtenerCampo("select * from empresa", "folio_cto_drenaje")
            contratonuevo2 = 1
        Else
            MessageBoxEx.Show("ya tiene un numero de contrato asignado", "Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtcatastral_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Cmbmunicipio.Focus()
    End Sub

    Private Sub llenado()
        Dim CONSULTA As String
        D_IDCOMUNIDAD = Cmbcomunidad.SelectedValue ' obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Cmbcomunidad.Text & "'", "id_comunidad")
        CONSULTA = "select ta.id_tarifasadicionales AS FOLIO,ta.CUENTA as CUENTA,ta.ID_COMUNIDAD as COMUNIDAD,ta.TARIFA as TARIFA,cu.Descripcion_Cuota as DESCRIPCION,ta.PORCE as PORCENTAJE from tarifas_adicionales ta,cuotas cu where ta.tarifa=cu.id_tarifa and cuenta=" & Val(txtclave.Text) & " and id_comunidad='" & D_IDCOMUNIDAD & "' ORDER BY FOLIO"
        llenaGrid(TarifasAdicionales, CONSULTA)
        TarifasAdicionales.Columns("FOLIO").ReadOnly = True
        TarifasAdicionales.Columns("CUENTA").ReadOnly = True
        TarifasAdicionales.Columns("COMUNIDAD").ReadOnly = True
        TarifasAdicionales.Columns("TARIFA").ReadOnly = True
        TarifasAdicionales.Columns("DESCRIPCION").ReadOnly = True
        TarifasAdicionales.Columns("FOLIO").Width = 70
        TarifasAdicionales.Columns("CUENTA").Width = 70
        TarifasAdicionales.Columns("COMUNIDAD").Width = 80
        TarifasAdicionales.Columns("TARIFA").Width = 50
        TarifasAdicionales.Columns("DESCRIPCION").Width = 550
        TarifasAdicionales.Columns("PORCENTAJE").Width = 100
        TarifasAdicionales.AllowUserToAddRows = False
    End Sub

    Private Sub TarifasAdicionales_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TarifasAdicionales.SelectionChanged
        Try
            'D_IDTARIFA = "" & TarifasAdicionales.Rows(TarifasAdicionales.CurrentRow.Index).Cells(3).Value & ""
            'D_FOLIOTARIFA = "" & TarifasAdicionales.Rows(TarifasAdicionales.CurrentRow.Index).Cells(0).Value & ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click

        Try
            Dim archivo As New OpenFileDialog
            archivo.Filter = "Todos los archivcos (*.*)|*.*"
            If archivo.ShowDialog = DialogResult.OK Then
                lblexaminar.Text = archivo.FileName

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        mostrar.Refresh()
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim DID_COMUNIDAD, DID_TARIFA As String
        FOLIO = ConsultaSql("SELECT MAX(id_tarifasadicionales) AS FOLIOMAYOR  FROM tarifas_adicionales").ExecuteReader
        FOLIO.Read()

        DID_TARIFA = obtenerCampo("Select id_tarifa from cuotas where descripcion_cuota = '" & cmbtarifa2.Text & "'", "id_tarifa")
        DID_COMUNIDAD = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & Cmbcomunidad.Text & "'", "id_comunidad")
        'CONSULTA DEL REGISTRO DE LA TABLA DE TARIFAS ADICIONALES
        CONSULTA_TA = ConsultaSql("SELECT * FROM tarifas_adicionales where cuenta=" & txtclave.Text & " and id_tarifasadicionales='" & Val(FOLIO("FOLIOMAYOR")) + 1 & "' and id_comunidad='" & Trim(DID_COMUNIDAD) & "'").ExecuteReader
        If CONSULTA_TA.Read Then
            MsgBox("ESTA TARIFA ADICIONAL YA EXISTE, FAVOR DE VERIFICARLO")
        Else
            Ejecucion("insert into tarifas_adicionales(id_tarifasadicionales,cuenta,id_comunidad,tarifa,porce)values(" & Val(FOLIO("FOLIOMAYOR")) + 1 & ",'" & txtclave.Text & "','" & DID_COMUNIDAD & "','" & DID_TARIFA & "'," & dporce.Value & ")")
            cmbtarifa2.Text = ""
            dporce.Value = 100
        End If
        llenado()
        TarifasAdicionales.FirstDisplayedScrollingRowIndex = TarifasAdicionales.Rows.Count - 1
    End Sub



    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        'CONSULTA DEL REGISTRO DE LA TABLA DE TARIFAS ADICIONALES
        CONSULTA_TA = ConsultaSql("SELECT * FROM tarifas_adicionales where cuenta=" & txtclave.Text & " and tarifa='" & D_IDTARIFA & "' and id_comunidad='" & Trim(D_IDCOMUNIDAD) & "'").ExecuteReader
        If CONSULTA_TA.Read Then
            Ejecucion("delete from tarifas_adicionales where cuenta=" & txtclave.Text & " AND id_tarifasadicionales=" & D_FOLIOTARIFA & " and tarifa='" & D_IDTARIFA & "' and id_comunidad='" & Trim(D_IDCOMUNIDAD) & "'")
        End If
        llenado()
        TarifasAdicionales.FirstDisplayedScrollingRowIndex = TarifasAdicionales.Rows.Count - 1
    End Sub

    Private Sub mostrar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mostrar.CellClick
        textDescripcion.Text = mostrar.CurrentRow.Cells(1).EditedFormattedValue.ToString()
        'ButtonX3.Enabled = False
        lblexaminar.Text = mostrar.CurrentRow.Cells(2).EditedFormattedValue.ToString()
        lblexaminar.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        'If Not mostrar.CurrentRow.Cells(1).EditedFormattedValue.ToString() Then
        '    MsgBox("No hay archivo que actualizar")
        'Else

        Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")
        'Try

        '    If Not Directory.Exists((enlace) & "\" & nombreTitular) Then
        '        Directory.Delete((enlace) & "\" & nombreTitular)
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Dim destino As String = String.Empty
        Try
            'File.Delete((enlace) & "\" & nombreTitular & "\Exp-" & expD & "-" & destex & ext)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            destino = Reenombrar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim Cadena As String = mostrar.CurrentRow.Cells(0).EditedFormattedValue.ToString()
        Dim ArrCadena As String() = Cadena.Split("-")

        Dim CUENTA As Integer = ArrCadena(0)
        Dim id As String = ArrCadena(1)
        'MsgBox(id)
        'MsgBox(CUENTA)

        Try
            Ejecucion("update expedientes set Descripcion='" & textDescripcion.Text & "', ruta='" & destino & "' where idexpedientes=" & id & " ")

            MsgBox("Datos Actualizados")

            llenadoEXP()

            'My.Computer.FileSystem.DeleteFile("C:\test.txt")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        textDescripcion.Text = ""
        lblexaminar.Text = ""
        mostrar.Refresh()
        'End If
    End Sub

    Private Sub mostrar_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles mostrar.CellDoubleClick

        ' Run calculator.
        Try
            Process.Start(mostrar.SelectedRows(0).Cells(2).Value.ToString)
            ' The preceding path is for Windows XP.
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenadoEXP()

        Dim CONSULTA As String

        CONSULTA = "select concat (cuenta ,'-' ,IDExpedientes)as Expedientes, Descripcion, Ruta FROM expedientes where CUENTA =" & Val(txtclave.Text)

        llenaGrid(mostrar, CONSULTA)
        mostrar.Columns("Expedientes").Width = 70
        mostrar.Columns("Descripcion").Width = 100
        mostrar.Columns("Ruta").Width = 200

        TarifasAdicionales.AllowUserToAddRows = False
    End Sub
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If String.IsNullOrEmpty(lblexaminar.Text) Then
            MsgBox("Sin archivo")
            'ButtonX3.Enabled = False
        Else

            Dim destino As String = String.Empty

            Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")

            llenadoEXP()
            expD = txtclave.Text
            Try

                If Not Directory.Exists((enlace) & "\" & nombreTitular) Then
                    Directory.CreateDirectory((enlace) & "\" & nombreTitular)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Try
                destino = copiar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try

                Ejecucion("insert into expedientes (Cuenta, Descripcion, Ruta) values(" & txtclave.Text & ",'" & textDescripcion.Text & "','" & destino & "')")

                MsgBox("Datos Almacenados")

                llenadoEXP()
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Catch ex As Exception

                MsgBox("No se almacenaron los datos " & ex.Message)
            End Try
            textDescripcion.Text = ""
            lblexaminar.Text = ""
            mostrar.Refresh()
        End If


    End Sub

    Dim destex As String = String.Empty

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim result As DialogResult = MsgBox("NOTA: Se eliminará el registro y el archivo físico llamado " & mostrar.CurrentRow.Cells(1).EditedFormattedValue.ToString() & " ¿Desea continuar?", MsgBoxStyle.YesNo)

        If result = System.Windows.Forms.DialogResult.Yes Then

            Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")
            Dim destino As String = String.Empty
            Try
                'File.Delete((enlace) & "\" & nombreTitular & "\Exp-" & expD & "-" & destex & ext)

                destino = Eliminar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim Cadena As String = mostrar.CurrentRow.Cells(0).EditedFormattedValue.ToString()
            Dim ArrCadena As String() = Cadena.Split("-")

            Dim CUENTA As Integer = ArrCadena(0)
            Dim id As String = ArrCadena(1)

            Try
                Ejecucion("delete from expedientes where idexpedientes=" & id & " ")

                MsgBox("Documento eliminado")

                llenadoEXP()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            textDescripcion.Text = ""
            lblexaminar.Text = ""
            mostrar.Refresh()

        End If
    End Sub

    Private Sub TabControlPanel1_Click(sender As Object, e As EventArgs) Handles TabControlPanel1.Click

    End Sub

    Dim ext As String = String.Empty
    Private Function copiar() As String

        Dim cadena As String = String.Empty
        Dim destino As String = String.Empty

        Try
            cadena = lblexaminar.Text

            Dim p As Integer
            p = cadena.LastIndexOf(".")
            ext = cadena.Substring(p, 4)
            'MsgBox(ext)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            destex = textDescripcion.Text
            Dim origen As String = lblexaminar.Text
            Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")

            destino = enlace & "\" + nombreTitular & "\Exp-" & expD & "-" & destex & ext
            destino = destino.Replace("\", "\\")
            System.IO.File.Copy(origen, destino, True)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return destino
    End Function

    Private Function Eliminar() As String

        Dim cadena As String = String.Empty
        Dim destino As String = String.Empty

        Try
            cadena = lblexaminar.Text

            Dim p As Integer
            p = cadena.LastIndexOf(".")
            ext = cadena.Substring(p, 4)
            'MsgBox(ext)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            destex = textDescripcion.Text
            Dim origen As String = lblexaminar.Text
            Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")

            destino = enlace & "\" + nombreTitular & "\Exp-" & expD & "-" & destex & ext
            destino = destino.Replace("\", "\\")
            'System.IO.File.Copy(origen, destino, True)
            If System.IO.File.Exists(destino) = True Then
                System.IO.File.Delete(destino)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return destino
    End Function
    Private Function Reenombrar() As String

        Dim cadena As String = String.Empty
        Dim destino As String = String.Empty

        Try
            cadena = lblexaminar.Text

            Dim p As Integer
            p = cadena.LastIndexOf(".")
            ext = cadena.Substring(p, 4)
            'MsgBox(ext)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            destex = textDescripcion.Text
            Dim origen As String = lblexaminar.Text
            Dim enlace As String = obtenerCampo("select rutabase from empresa limit 1", "rutabase")

            destino = enlace & "\" + nombreTitular & "\Exp-" & expD & "-" & destex & ext
            destino = destino.Replace("\", "\\")
            'System.IO.File.Copy(origen, destino, True)
            Rename(origen, destino)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return destino
    End Function



    Dim ex As String = String.Empty

    Private Sub Tabsolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabsolicitud.Click
        TarifasAdicionales.AllowUserToAddRows = False

    End Sub

    Private Sub rbDirUbi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDirUbi.CheckedChanged

        If rbDirUbi.Checked = True Then
            dUbi = "1"
            dAu = "0"
            dFis = "0"
        End If

    End Sub

    Private Sub rbDomAu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDomAu.CheckedChanged
        If rbDomAu.Checked = True Then
            dUbi = "0"
            dAu = "1"
            dFis = "0"
        End If
    End Sub

    Private Sub rbDirFis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDirFis.CheckedChanged

        If rbDirFis.Checked = True Then
            dUbi = "0"
            dAu = "0"
            dFis = "1"
        End If

    End Sub

    Private Sub ChkGestCob_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkGestCob.CheckedChanged

        If ChkGestCob.Checked = True Then
            GC = "1"
        End If

    End Sub

    Private Sub ChkAltoCon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAltoCon.CheckedChanged
        If ChkAltoCon.Checked = True Then
            AC = "1"
        End If
    End Sub

End Class