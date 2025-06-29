Imports System.Windows
Imports CrystalDecisions.CrystalReports.Engine
Imports DevComponents.DotNetBar
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmAgrOrd
    Private _FOLIO As Double
    Private idOrden As IDataReader
    Private _tipo1 As _tipo
    Private idUsu As IDataReader
    Private salio As Boolean
    Private cardat As Boolean = False
    Private ultLec As Double = 0
    Private ultimo As Date = DateAdd(DateInterval.Month, -1, Now)
    Private mes As String = UCase(MonthName(Month(ultimo), True)), anio As Int32 = Year(ultimo)
    Private id_tipo_usuario As String = ""
    Private temporal As String = ""
    Private idcomunidad As String = String.Empty
    Private INMUBLE As String = String.Empty
    Private Departamento As String = String.Empty


    Public INDICACIONES As String
    Public ELABORO As String
    Public REGISTRORESULTADO As String



    Private cuotas As IDataReader
    Private tarifa As String = ""

    Enum _tipo
        Agregar
        Editar
        Verificar
        Resultado
        EditarBrigada
    End Enum
    Public Sub New()
        ' Llamada necesaria para el Dise�ador de Windows Forms.
        InitializeComponent()
        ' Agregue cualquier inicializaci�n despu�s de la llamada a InitializeComponent().
    End Sub
    Public Sub New(ByVal FOLIO As Double, ByVal tipo As _tipo)
        InitializeComponent()
        cardat = False
        'Static tam As New System.Drawing.Size(701, 377)
        'Static pos As New System.Drawing.Point(25, 292)




        Try
            Dim estado As String = ""
            _FOLIO = FOLIO
            _tipo1 = tipo

            llenarCombo(cmbProb, "select cod_cve, descripcion from cveque order by descripcion")
            llenarCombo(cmbRel, "select nobrig, descripcion from  brigada  order by descripcion")
            llenarCombo(cmbFue, "select id_fuente, descripcion from fuente order by descripcion")
            llenarCombo(CmbComunidad, "SELECT ID_COMUNIDAD, COMUNIDAD FROM COMUNIDADES ORDER BY COMUNIDAD")
            RB.Enabled = True
            cmdImp.Enabled = True

            If _tipo1 = _tipo.Resultado OrElse _tipo1 = _tipo.Verificar OrElse _tipo1 = _tipo.Editar OrElse _tipo1 = _tipo.EditarBrigada Then

                idOrden = ConsultaSql("select * from ordent where folio=" & _FOLIO & "").ExecuteReader()
                idOrden.Read()
                DTfAlta.Text = idOrden("FEC_ORD")
                txthFalta.Text = idOrden("HORA").ToString
                'txtcomunidad.Text = obtenerCampo("select comunidad from comunidades where id_comunidad=""" & idOrden("id_comunidad") & """ ", "comunidad")
                CmbComunidad.SelectedValue = idOrden("id_comunidad")
                idcomunidad = idOrden("id_comunidad")
                txtTel.Text = idOrden("tel")
                cmbProb.SelectedValue = idOrden("COD_CVE")
                If idOrden("cuenta") <> 0 Then
                    txtcuenta.Text = idOrden("cuenta")


                End If
                INDICACIONES = txtInd.Text

                txtNombre.Text = idOrden("nombre")
                txtUbi.Text = idOrden("ubicacion")
                cmbRel.SelectedValue = idOrden("COD_REL")
                TXTINMUEBLE.Text = idOrden("INMUEBLE")
                txtCel.Text = idOrden("cel")
                txtInd.Text = idOrden("indic").ToString
                chkUrge.Checked = CBool(idOrden("urge"))
                chkRein.Checked = CBool(idOrden("reincide"))
                DTfeccom.Text = idOrden("FEC_COM")
                txtPerRec.Text = idOrden("per_ate")
                If Not IsDBNull(idOrden("FEC_RES")) Then dtFecRel.Value = idOrden("FEC_RES").ToString Else dtFecRel.Value = Nothing
                txtCom.Text = idOrden("coment1").ToString
                TXTSECTOR.Text = idOrden("clavesec")
                cmbFue.SelectedValue = CInt(idOrden("fuente").ToString)
                txtMED.Text = idOrden("nodemedidor")
                ultLec = idOrden("ultlect")
                id_tipo_usuario = idOrden("id_tipo_usuario")

                '   txtcuenta.Text = idOrden("cuenta")
                Select Case idOrden("status").ToString
                    Case 1
                        lblEst.BackColor = Color.Yellow
                    Case 2
                        lblEst.BackColor = Color.Green
                    Case 3
                        lblEst.BackColor = Color.Blue
                    Case 4
                        lblEst.BackColor = Color.Orange
                    Case 5
                        lblEst.BackColor = Color.Red
                End Select
                gpUsu.Enabled = False
                gpDatOrd.Enabled = False
                If Not IsDBNull(idOrden("cod_alt")) And Not idOrden("cod_alt") = " " And Not idOrden("cod_alt") = "" Then


                    Dim ir As IDataReader = ConsultaSql("Select * from letras where ccodusuario = " & idOrden("cod_alt") & "").ExecuteReader
                    ir.Read()
                    Dim des As New Encriptar
                    Try


                        ELABORO = ir("nombre")
                        lblReg.Text = "ELABORO: " & ELABORO

                    Catch ex As Exception

                    End Try
                End If
                'lblReg.Text = "ORDEN REGISTRADA POR:    " & obtenerCampo("SELECT NOMBRE FROM TRABAJADORES where idtrab='" & idOrden("cod_alt") & "'", "nombre")

                If Not IsDBNull(idOrden("reg_resp")) Then
                    Dim ir1 As IDataReader = ConsultaSql("Select * from letras where ccodusuario = " & idOrden("reg_resp") & "").ExecuteReader
                    ir1.Read()
                    Try

                        REGISTRORESULTADO = ir1("nombre")
                        lblReg.Text &= " Y REGISTR� EL RESULTADO: " & UCase(REGISTRORESULTADO)
                    Catch ex As Exception

                    End Try

                    If Not IsDBNull(idOrden("FEC_RESP")) Then
                        lblReg.Text &= " EL DIA " & idOrden("FEC_RESP")
                    End If

                    'lblReg.Text &= " Y REGISTR� EL RESULTADO: " & obtenerCampo("SELECT NOMBRE FROM TRABAJADORES where idtrab='" & idOrden("reg_resp") & "'", "nombre")
                End If

                If _tipo1 = _tipo.Verificar Then
                    lblTit.Text = "<b><font size='+6'><i>VERIFICACI�N DE LA ORDEN DE TRABAJO N� " & _FOLIO & " </i></font></b>"
                    'gpRes.Enabled = False
                    cmdGuar.Visible = False
                    cmdGen.Visible = False
                    cmdImp.Enabled = True
                    txtCom.Enabled = True
                    '  dtFecCom.ReadOnly = True
                    dtFecRel.Enabled = False
                    cmbRel.Enabled = False
                    txtCom.ReadOnly = True
                    txtPerRec.ReadOnly = False
                    txtInd.Enabled = True
                    txtInd.ReadOnly = True
                    gpDatOrd.Enabled = True
                    cmbProb.Enabled = False
                    txtInd.Width = txtInd.Width + 200
                    txtCom.Width = txtCom.Width + 350
                    txtPerRec.Width = txtPerRec.Width + 350
                    chkUrge.Enabled = False
                    chkRein.Enabled = False
                    cmbFue.Enabled = False
                    gpUsu.Enabled = True
                    ' dtFalta.ReadOnly = True
                    txthFalta.ReadOnly = True
                    CmbComunidad.Enabled = False
                    txtcuenta.Enabled = False
                    txtTel.Enabled = False
                    txtCel.Enabled = False
                    txtUbi.ReadOnly = True
                    RB.Enabled = False
                    txtcuenta.Enabled = False

                    txtCom.Height = txtCom.Height + 5
                    cmdImp.Enabled = True

                ElseIf _tipo1 = _tipo.Editar Then
                    lblTit.Text = "<b><font size='+6'><i>EDICI�N DE LA ORDEN DE TRABAJO N� " & _FOLIO & " </i></font></b>"
                    gpUsu.Enabled = True
                    gpDatOrd.Enabled = True
                    gpRes.Enabled = True
                    cmdImp.Enabled = True
                ElseIf _tipo1 = _tipo.EditarBrigada Then
                    lblTit.Text = "<b><font size='+6'><i>EDICI�N DE LA ZONA DE LA ORDEN DE TRABAJO N� " & _FOLIO & " </i></font></b>"
                    gpUsu.Enabled = True
                    gpDatOrd.Enabled = False
                    gpRes.Enabled = False

                    DTfAlta.Enabled = False
                    txthFalta.Enabled = False
                    CmbComunidad.Enabled = False
                    txtNombre.Text = False
                    txtcuenta.Text = False
                    txtMED.Enabled = False
                    txtTel.Enabled = False
                    txtCel.Enabled = False
                    txtUbi.Enabled = False
                    RB.Enabled = True

                    ''cmbRel.Enabled = True
                    'dtFecCom.Enabled = False
                    'dtFecRel.Enabled = False
                    'txtCom.Enabled = False
                    'txtPerRec.Enabled = False

                Else
                    cmdImp.Enabled = True
                    lblTit.Text = "<b><font size='+6'><i>RESULTADO DE LA ORDEN DE TRABAJO N� " & _FOLIO & " </i></font></b>"
                End If
                'bloc()
                DTfeccom.Focus()
            ElseIf _tipo1 = _tipo.Agregar Then
                cmdImp.Visible = False

                DTfAlta.Text = Now.Date
                txthFalta.Text = String.Concat(Now.Hour, ":", Now.Minute, ":", Now.Second)

                lblFecRel.Visible = False
                dtFecRel.Visible = False
                lblBrig.Visible = True
                cmbRel.Visible = True
                txtCom.Visible = False
                lblREs.Visible = False
                lblAt.Visible = False
                txtPerRec.Visible = False

                'gpRes.Visible = False
                'Me.Size = tam

            End If

        Catch ex As Exception

        End Try

        If tipo = _tipo.Verificar Then
            cmdImp.Enabled = True
            RB.Enabled = True
        End If
        cardat = True
    End Sub
    'Private Sub tmp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmp.Tick
    '    If _tipo1 = _tipo.Agregar Then
    '        txthFalta.Text = String.Concat(Format(Now.Hour, "00"), ":", Format(Now.Minute, "00"), ":", Format(Now.Second, "00"))
    '    End If
    'End Sub





    Public Function datosUsu(Optional ByVal concuenta As Boolean = False) As String
        Dim cadena As String = ""
        Try
            If txtcuenta.Text <> "" Then
                idUsu = Nothing

                If My.Settings.CombodeCalles = "NO" Then
                    idUsu = ConsultaSql("select nodemedidor, usuario.nombre as nombre, usuario.numext, usuario.numint, nombre,domicilio ,id_tipo_usuario, colonia.colonia as colonia, usuario.id_comunidad,usuario.sector from colonia, " &
                                      " comunidades, usuario where usuario.id_comunidad=comunidades.id_comunidad and " &
                                      " usuario.id_colonia=colonia.id_colonia  and usuario.cuenta=" & txtcuenta.Text & " ").ExecuteReader()
                Else
                    idUsu = ConsultaSql("select nodemedidor, CuentaAnterior, nombre, concat(domicilio,"" "",numext,"" "",numint, "" "", colonia) as domicilio , tipousu  as id_tipo_usuario, colonia, comunidad,id_comunidad,region from vusuario where cuenta=" & txtcuenta.Text & " ").ExecuteReader()
                End If


            End If
            If idUsu.Read() Then
                txtMED.Text = idUsu("nodemedidor")
                ultLec = 0
                id_tipo_usuario = idUsu("id_tipo_usuario")

                cadena = idUsu("domicilio").ToString().Trim()

                idcomunidad = idUsu("id_comunidad")
                ''    TXTINMUEBLE.Text = idUsu("cuentaAnterior")
                '  INMUBLE = idUsu("cuentaAnterior")

                If idUsu("numext") <> "" AndAlso idUsu("numext") <> "" Then
                    cadena &= String.Concat(" ", idUsu("numext"))
                End If


                If idUsu("numint") <> "" AndAlso idUsu("numint") <> "" Then
                    cadena &= String.Concat(" ", idUsu("numint"))
                End If



                cadena &= String.Concat(", ", idUsu("colonia"))
                txtUbi.Text = cadena
                TXTSECTOR.Text = 1 ' idUsu("region")

                txtNombre.Text = idUsu("nombre")
                CmbComunidad.Text = idUsu("comunidad")
                'txtTel.Focus()

                'lblmen2.Text = "TECLEE EL TELEFONO"
                'lblmen2.Top = txtTel.Top
                'Return cadena


            Else
                RB.Text = ""
                txtNombre.Text = ""
                CmbComunidad.Text = ""
                txtNombre.Focus()
                txtUbi.Text = ""
                txtMED.Text = ""
                lblmen2.Text = "TECLEE EL NOMBRE"
                lblmen2.Top = txtNombre.Top
                Return ""
            End If


        Catch ex As Exception
            Return " "
        End Try
    End Function

    Private Sub cmbProb_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProb.GotFocus
        lblmen2.Text = "TECLEE EL PROBLEMA"
        lblmen2.Top = cmbProb.Top
    End Sub
    Private Sub cmbProb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProb.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        'cmbProb.DroppedDown = True
    End Sub

    Private Sub cmbProb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProb.LostFocus
        lblmen2.Text = ""
    End Sub
    Private Sub cmbProb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProb.SelectedIndexChanged

        If DTfAlta.Text <> "" And cmbProb.Text <> "" Then
            Try
                Dim dp As Int32 = 0
                If chkUrge.Checked = True Then
                    dp = obtenerCampo("select dias_urge from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "dias_urge")
                Else
                    dp = obtenerCampo("select dias_norm from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "dias_norm")
                End If
                DTfeccom.Text = DateAdd("d", dp, DTfAlta.Text)
                If CBool(obtenerCampo("select cobrar from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "cobrar")) = True Then cmdGen.Visible = True Else cmdGen.Visible = False
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub cmbUsu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
        ' cmbUsu.DroppedDown = True
    End Sub

    Private Sub cmbRel_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRel.GotFocus
        lblmen3.Text = "ESPECIFIQUE LA BRIGADA"
        lblmen3.Top = cmbRel.Top
    End Sub
    Private Sub cmbRel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbRel.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        'If _tipo1 = _tipo.Agregar Then
        '    'cmbRel.DroppedDown = True
        'End If
    End Sub


    Private Sub cmbFue_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFue.GotFocus
        lblmen2.Text = "ESPECIFIQUE LA FUENTE"
        lblmen2.Top = cmbFue.Top
    End Sub
    Private Sub cmbFue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFue.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        'cmbFue.DroppedDown = True
    End Sub
    Private Sub cmbRel_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRel.LostFocus
        'cmdGuar.Focus()
        cmdGuar.Focus()
        lblmen3.Text = ""
    End Sub
    Private Sub cmbFue_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFue.LostFocus
        lblmen2.Text = ""
    End Sub

    Private Sub cmdGuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuar.Click
        Dim folio As Double = 0
        Dim clavesec As String = ""

        If txtcuenta.Text = "" Then
            txtcuenta.Text = 0
        End If

        If cmbFue.Focused Then cmdGuar.Focus()

        If cmbProb.Text = "" Then
            MessageBoxEx.Show("ESTABLEZCA EL PROBLEMA POR FAVOR", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbProb.Select()
            Exit Sub
        End If

        If CmbComunidad.Text = "" Then
            MessageBoxEx.Show("ELIJA LA COMUNIDAD", "�RDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbProb.Select()
            Exit Sub
        End If

        If cmbProb.SelectedValue Is Nothing Then
            MessageBoxEx.Show("ESTABLEZCA EL PROBLEMA CORRECTAMETE, S�LO PUEDE SELECCIONAR UN PROBLEMA DEL LISTADO", "�RDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbProb.Select()
            Exit Sub
        End If

        If _tipo1 = _tipo.Resultado Then
            If dtFecRel.Value = Nothing Then
                MessageBoxEx.Show("ESTABLEZCA LA FECHA REAL DEL RESULTADO, POR FAVOR", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dtFecRel.Select()
                Exit Sub
            End If
        End If


        Dim direc As String = obtenerCampo("select cod_dir from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "cod_dir")
        Dim dep As String = obtenerCampo("select cod_res from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "cod_res")
        Dim estado As Int16 = 0
        Dim cuenta As Double = 0
        Dim nomed As String = ""

        If txtMED.Text <> "" Then
            nomed = txtMED.Text
        Else
            nomed = " "
        End If

        If txtUbi.Text = "" Then
            MessageBoxEx.Show("Establezca la ubicacion de la falla, por favor", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUbi.Select()
            Exit Sub
        End If
        If _tipo1 = _tipo.Agregar Or _tipo1 = _tipo.Editar Then
            If cmbFue.Text = "" Then
                MessageBoxEx.Show("Establezca la fuente, por favor", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cmbFue.Select()
                Exit Sub
            End If

            If cmbRel.SelectedIndex = -1 Then
                MessageBoxEx.Show("NO SELECCIONASTE LA BRIGADA")
                cmbRel.Select()
                Exit Sub
            End If

        End If

        If txtNombre.Text = "" Then
            MessageBoxEx.Show("Establezca el nombre del usuario, por favor", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Select()
            Exit Sub
        End If



        If cmbProb.Text = "" Then
            MessageBoxEx.Show("Establezca el tipo del problema, por favor", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbProb.Select()
            Exit Sub
        End If

        'If txtPerRec.Text = "" Then
        '    MessageBox.Show("Establezca los datos de la persona que atendi�, por favor", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If

        If _tipo1 = _tipo.Resultado Then
            If txtCom.Text = "" Or txtCom Is Nothing Then
                MessageBoxEx.Show("NO CAPTURASTE EL RESULTADO")
                txtCom.Select()
                Exit Sub
            End If



            If txtPerRec.Text = "" Or txtPerRec.Text = " " Or txtPerRec.Text Is Nothing Then
                MessageBoxEx.Show("NO INDICASTE LA PERSONA QUE ATENDIO")
                txtPerRec.Select()
                Exit Sub
            End If

        End If



        Try
            folio = obtenerCampo("select max(folio) + 1 as mFolio from ordent", "mFolio")
        Catch ex As Exception
            folio = 1
        End Try
        clavesec = TXTSECTOR.Text

        If _tipo1 = _tipo.Agregar Then
            lblEst.BackColor = Color.Yellow

            Ejecucion("insert into ordent(status,folio,fec_ord,hora,id_comunidad,tel,cod_cve" &
                      ",indic,urge,nombre,fec_com,cuenta,ubicacion,cel,fuente,COD_ALT,nodemedidor,claveSec,ultlect,id_tipo_usuario,INMUEBLE,cod_rel) values(1," & folio & ",'" & UnixDateFormat(DTfAlta.Text) & "','" & txthFalta.Text & "','" & CmbComunidad.SelectedValue.ToString &
                      "','" & txtTel.Text & "','" & cmbProb.SelectedValue.ToString & "','" & txtInd.Text &
                      "'," & CInt(chkUrge.Checked) & ",'" & txtNombre.Text & "','" & UnixDateFormat(DTfeccom.Text) & "'," & txtcuenta.Text & ",'" & txtUbi.Text & "','" & txtCel.Text & "','" & cmbFue.SelectedValue.ToString & "','" & NumUser & "','" & nomed & "','" & clavesec & "'," & ultLec & ",'" & id_tipo_usuario & "','" & INMUBLE & "','" & cmbRel.SelectedValue & "')")


            'Agregar Orden de Servicio a la Bitacora
            Dim nombre_Host As String = Net.Dns.GetHostName()
            Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
            Dim direccion_Ip As String = este_Host.AddressList(0).ToString

            Try
                Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','NUEVA ORDEN DE SERVICIO '," & cuenta & "," & NumUser & ",'ORDEN DE SERVICIO: " & folio & "','" & direccion_Ip & "','ORDEN DE SERVICIO')")

                ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ButtonX1.Enabled = True

                'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                '  BtnAceptar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
            End Try


            MessageBoxEx.Show("La orden:" & folio & " se ha creado correctamente", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Not dtFecRel.Value = Nothing Then
                If DateDiff("d", CDate(DTfeccom.Text), CDate(dtFecRel.Value)) <= 0 Then
                    lblEst.BackColor = Color.Green
                    estado = 2
                ElseIf DateDiff("d", CDate(DTfeccom.Text), CDate(dtFecRel.Value)) > 0 Then
                    lblEst.BackColor = Color.Blue
                    estado = 3

                Else
                    estado = 1
                End If
            End If
            Try
                If estado = 0 Then estado = 1

                Ejecucion("update ordent set status=" & estado & ", id_comunidad='" & CmbComunidad.SelectedValue.ToString &
                                      "', INMUEBLE='" & INMUBLE & "',tel='" & txtTel.Text & "', cod_cve='" & cmbProb.SelectedValue.ToString & "', indic='" & txtInd.Text & "', fec_com='" & UnixDateFormat(DTfeccom.Text) &
                                      "', fec_res='" & UnixDateFormat(dtFecRel.Value) & "', coment1='" & txtCom.Text & "', urge=" & CInt(chkUrge.Checked) & ", reincide=" & CInt(chkRein.Checked) &
                                      ", COD_REL='" & cmbRel.SelectedValue.ToString & "', REG_RESP='" & NumUser & "', FEC_RESP='" & UnixDateFormat(Now, 0, True) & "', ubicacion='" & txtUbi.Text & "',cel='" & txtCel.Text & "', fuente='" & cmbFue.SelectedValue.ToString & "', per_ate='" & txtPerRec.Text & "', nombre='" & txtNombre.Text & "', cuenta=" & txtcuenta.Text & ", nodemedidor='" & nomed & "', clavesec='" & clavesec & "', ultlect=" & ultLec & ", id_tipo_usuario='" & id_tipo_usuario & "' where folio=" & _FOLIO & "")
            Catch ex As Exception
                Ejecucion("update ordent set status=" & estado & ", id_comunidad='" & CmbComunidad.SelectedValue.ToString &
                                     "', INMUEBLE='" & INMUBLE & "', tel='" & txtTel.Text & "', cod_cve='" & cmbProb.SelectedValue.ToString & "', indic='" & txtInd.Text & "', fec_com='" & UnixDateFormat(DTfeccom.Text) &
                                     "', fec_res='" & UnixDateFormat(dtFecRel.Value) & "', coment1='" & txtCom.Text & "', urge=" & CInt(chkUrge.Checked) & ", reincide=" & CInt(chkRein.Checked) &
                                     ", FEC_RESP='" & UnixDateFormat(Now, 0, True) & "', ubicacion='" & txtUbi.Text & "',cel='" & txtCel.Text & "', fuente='" & cmbFue.SelectedValue.ToString & "', per_ate='" & txtPerRec.Text & "', nombre='" & txtNombre.Text & "', cuenta=" & txtcuenta.Text & ", nodemedidor='" & nomed & "', clavesec='" & clavesec & "', ultlect=" & ultLec & ", id_tipo_usuario='" & id_tipo_usuario & "' where folio=" & _FOLIO & "")
            Finally
                'Agregar Orden de Servicio a la Bitacora
                Dim nombre_Host As String = Net.Dns.GetHostName()
                Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
                Dim direccion_Ip As String = este_Host.AddressList(0).ToString

                Try
                    Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','RESULTADO ORDEN DE SERVICIO '," & cuenta & "," & NumUser & ",'RESULTADO ORDEN DE SERVICIO: " & _FOLIO & " ESTADO: " & estado & "','" & direccion_Ip & "','ORDEN DE SERVICIO')")

                    ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'ButtonX1.Enabled = True

                    'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                    '  BtnAceptar.Enabled = False
                Catch ex As Exception
                    MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
                End Try
            End Try


            If _tipo1 = _tipo.Resultado Then
                MessageBoxEx.Show("El resultado de la orden: " & _FOLIO & " se ha guardado correctamente", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmdImp.Enabled = True
            Else
                MessageBoxEx.Show("La orden: " & _FOLIO & " se ha guardado correctamente", "�rdenes de trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If


        My.Forms.frmOrdTrab.CatControl1.Actualizar()
        If _tipo1 <> _tipo.Editar AndAlso _tipo1 <> _tipo.Resultado Then
            Me.Close()
        Else
            cmdImp.Enabled = True
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGen.Click
        'Dim frm As New frmagrmov(eve.CambioNombre, txtCuenta.Text, txtNombre.Text, cmbCom.SelectedValue)
        'frm.ShowDialog()
    End Sub

    Private Sub frmAgrOrd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RBCis.Select()
    End Sub

    Private Sub frmAgrOrd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim KeyAscii As Keys = e.KeyData
        Select Case KeyAscii
            Case Keys.Enter
                'If salio Then
                '    SendKeys.Send("{ESC}")
                'End If
                'If txtUbi.Focus Then
                '    txtUbi.SelectionStart = Len(txtUbi.Text)
                'End If
                SendKeys.Send("{TAB}")
        End Select
    End Sub


    Private Sub frmAgrOrd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTfeccom.Focus()
    End Sub






    Private Sub txtInd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInd.GotFocus
        If _tipo1 <> _tipo.Verificar Then
            lblmen2.Text = "TECLEE EL LA INDICACI�N"
            lblmen2.Top = txtInd.Top
        End If
        txtInd.SelectionStart = Len(txtInd.Text)
    End Sub

    'Private Sub txtInd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtInd.KeyPress
    '    txtInd.SelectionStart = Len(txtInd.Text)
    'End Sub
    Private Sub txtUbi_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbi.GotFocus
        If _tipo1 <> _tipo.Verificar Then
            lblMen.Text = "ESCRIBA LA UBICACI�N DEL PROBLEMA"
            lblMen.Top = txtUbi.Top
        End If
        txtUbi.SelectionStart = Len(txtUbi.Text)

    End Sub
    'Private Sub txtUbi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUbi.KeyPress
    '    txtUbi.SelectionStart = Len(txtUbi.Text)
    'End Sub
    Private Sub txtCom_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCom.GotFocus
        txtCom.SelectionStart = Len(txtCom.Text)
        If _tipo1 <> _tipo.Verificar Then
            lblmen3.Text = "ESCRIBA LOS COMENTARIOS DE LA SOLUCI�N"
            lblmen3.Top = txtCom.Top
        End If

        txtCom.SelectionStart = Len(txtCom.Text)
    End Sub
    'Private Sub txtCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCom.KeyPress
    '    txtCom.SelectionStart = Len(txtCom.Text)
    'End Sub
    Private Sub txtPerRec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerRec.GotFocus
        If _tipo1 <> _tipo.Verificar Then
            lblmen3.Text = "NOMBRE Y/O IDENTIFICACI�N Y/O PARENTESCO"
            lblmen3.Top = txtPerRec.Top
        End If
        txtPerRec.SelectionStart = Len(txtPerRec.Text)

    End Sub

    Private Sub txtUbi_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUbi.LostFocus
        lblMen.Text = ""
    End Sub

    Private Sub txtInd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInd.LostFocus
        lblmen2.Text = ""
    End Sub

    Private Sub txtCom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCom.KeyPress

    End Sub

    Private Sub txtCom_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCom.LostFocus
        lblmen3.Text = ""
    End Sub
    Private Sub txtPerRec_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerRec.LostFocus
        lblmen3.Text = ""
    End Sub
    Private Sub dtFecRel_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtFecRel.ValueChanged
        If DateDiff("d", CDate(DTfAlta.Text), CDate(dtFecRel.Value)) < 0 Then
            dtFecRel.Value = CDate(DTfAlta.Text)
            MessageBoxEx.Show("NO SE PUEDE ESTABLECER UNA FECHA DE REALIZACI�N MENOR A LA FECHA DE CREACI�N DE ORDEN", "�RDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub chkUrge_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUrge.CheckedChanged
        If DTfAlta.Text <> "" And cmbProb.Text <> "" Then
            Try
                Dim dp As Int32 = 0
                If chkUrge.Checked = True Then
                    dp = obtenerCampo("select dias_urge from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "dias_urge")
                Else
                    dp = obtenerCampo("select dias_norm from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "dias_norm")
                End If
                DTfeccom.Text = DateAdd("d", dp, DTfAlta.Text)
                If CBool(obtenerCampo("select cobrar from cveque where cod_cve='" & cmbProb.SelectedValue.ToString & "'", "cobrar")) = True Then cmdGen.Visible = True Else cmdGen.Visible = False
            Catch ex As Exception
            End Try
        End If
    End Sub




    Private Sub txtPerRec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPerRec.TextChanged
        If _tipo1 = _tipo.Verificar Then
            txtPerRec.ReadOnly = True

        End If
    End Sub

    Private Sub txtcuenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcuenta.GotFocus
        lblMen.Text = "SELECCIONE LA CUENTA"
        lblMen.Top = txtcuenta.Top

    End Sub



    Private Sub txtcuenta_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcuenta.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If KeyAscii = 13 Then
            datosUsu(True)
        End If
    End Sub

    Private Sub txtcuenta_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcuenta.LostFocus
        datosUsu(True)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        temporal = ""
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))

        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If KeyAscii = 43 Then



        End If
    End Sub

    Private Sub txtcuenta_TextChanged(sender As Object, e As EventArgs) Handles txtcuenta.TextChanged

    End Sub

    Private Sub LabelX8_Click(sender As Object, e As EventArgs) Handles LabelX8.Click

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Try
            Dim xf As New frmbuordet
            Try
                xf.txtnombre.Text = txtNombre.Text.Substring(0, txtNombre.Text.Length)
            Catch ex As Exception

            End Try

            xf.local = Me
            xf.ShowDialog()
            txtNombre.Text = xf.local.txtNombre.Text
            txtTel.Focus()
            Exit Sub
        Catch ex As Exception

        End Try
    End Sub



    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim idim As IDataReader = Nothing

        Dim noOrdenTrabajo As Integer = 0

        If Integer.TryParse(_FOLIO, noOrdenTrabajo) Then

            Dim repositorio As New OrdenesTrabajoRespositorio()

            Dim ordenTrabajo As OrdenTrabajo = repositorio.GenerarOrdenTrabajo(noOrdenTrabajo)


            If repositorio.GenerarPDF(ordenTrabajo) Then

                MessageBox.Show("PDF generado correctamente")

            Else

                MessageBox.Show("Error al generar el PDF")

            End If

        Else

            Console.WriteLine("N�mero de solicitud no v�lido")
            Return

        End If

        idim = ConsultaSql("select fec_imp, fec_rimp from ordent where folio=" & _FOLIO & "").ExecuteReader()
        idim.Read()

        If IsDBNull(idim("fec_imp")) Then
            Ejecucion("update ordent set fec_imp='" & UnixDateFormat(Now()) & "' where folio=" & _FOLIO & "")
        Else
            Ejecucion("update ordent set fec_rimp='" & UnixDateFormat(Now()) & "' where folio=" & _FOLIO & "")
        End If
        Me.Close()
    End Sub

    Public Sub imprimirordent()



        Try



            'Crear el directorio en donde se van a almacenar los PDF
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim) Then

                My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2).Trim)
            End If

            Dim cadenafolder As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ReporteCaja\" & Year(Now) & acompletacero(Month(Now).ToString(), 2)).Trim

            Dim nombrearchivo As String = cadenafolder & "\Ordendetrabajo_" & _FOLIO & ".pdf"


            'Dar propiedades al Documento
            Dim pdfDoc As New Document(iTextSharp.text.PageSize.LETTER, 15.0F, 15.0F, 5.0F, 5.0F)

            'Obtener la ruta donde se va a crear el pdf
            Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New System.IO.FileStream(cadenafolder & "\Ordendetrabajo_" & _FOLIO & ".pdf", System.IO.FileMode.Create))

            'Formato de letras
            Dim Font8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.NORMAL))
            Dim Font5 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.NORMAL))
            Dim Font7 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.NORMAL))
            Dim Font4 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 4, iTextSharp.text.Font.NORMAL))
            Dim Font8N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD))
            Dim Font13N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 13, iTextSharp.text.Font.BOLD))
            Dim Font10N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 10, iTextSharp.text.Font.BOLD))
            Dim Font12N As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 14, iTextSharp.text.Font.BOLD))
            Dim Font9 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 9, iTextSharp.text.Font.NORMAL))
            Dim Font7White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 7, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
            Dim Font8White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
            Dim Font5White As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 5, iTextSharp.text.Font.BOLD, BaseColor.WHITE))
            Dim Font7courierN As New Font(FontFactory.GetFont(FontFactory.COURIER, 6, iTextSharp.text.Font.BOLD))

            'Abrimos el pdf para comenzar a escribir en el
            pdfDoc.Open()

            Dim imagenBMP As iTextSharp.text.Image
            imagenBMP = iTextSharp.text.Image.GetInstance(LOGOBYTE)
            imagenBMP.ScaleAbsolute(200, 70.0F)
            imagenBMP.Border = 0
            ' imagenBMP.ScalePercent(22.0) 'escala al tama�o de la imagen
            ' imagenBMP.SetAbsolutePosition(30, 700)

            ' pdfDoc.Add(imagenBMP)

            Dim TableVacio As PdfPTable = New PdfPTable(1)
            TableVacio.DefaultCell.Border = BorderStyle.None
            TableVacio.WidthPercentage = 100
            Dim widthsVacio As Single() = New Single() {1000.0F}
            TableVacio.SetWidths(widthsVacio)

            Dim ColVacio = New PdfPCell(New Phrase(" ", Font5White))
            ColVacio.Border = 0
            ColVacio.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            TableVacio.AddCell(ColVacio)


            Dim TableEncGeneral As PdfPTable = New PdfPTable(3)
            TableEncGeneral.DefaultCell.Border = BorderStyle.None
            TableEncGeneral.WidthPercentage = 100
            Dim widthsEncGen2 As Single() = New Single() {300.0F, 400.0F, 300.0F}
            TableEncGeneral.SetWidths(widthsEncGen2)


            Dim ColPiePag1 = New PdfPCell(imagenBMP)
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEncGeneral.AddCell(ColPiePag1)



            ColPiePag1 = New PdfPCell(New Phrase(Empresa, Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEncGeneral.AddCell(ColPiePag1)



            Dim TableEnc2 As PdfPTable = New PdfPTable(1)
            TableEnc2.DefaultCell.Border = BorderStyle.None
            TableEnc2.WidthPercentage = 100
            Dim widthsEnc2 As Single() = New Single() {1000.0F}
            TableEnc2.SetWidths(widthsEnc2)


            Dim ColPiePag4 = New PdfPCell(New Phrase("ORDEN DE TRABAJO ", Font12N))
            ColPiePag4.BorderWidth = 1
            ColPiePag4.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableEnc2.AddCell(ColPiePag4)

            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)

            Dim ColPiePag5 = New PdfPCell(New Phrase(_FOLIO, Font12N))
            ColPiePag5.BorderWidth = 1
            ColPiePag5.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            TableEnc2.AddCell(ColPiePag5)


            TableEncGeneral.AddCell(TableEnc2)


            Dim TableEncFechas As PdfPTable = New PdfPTable(2)
            TableEncFechas.DefaultCell.Border = BorderStyle.None
            TableEncFechas.WidthPercentage = 100
            Dim widthsEncFec As Single() = New Single() {650.0F, 400.0F}
            TableEncFechas.SetWidths(widthsEncFec)





            Dim ColEncFec = New PdfPCell(New Phrase("", Font8))
            ColEncFec.Border = 0
            ColEncFec.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEncFechas.AddCell(ColEncFec)

            ' Dim fechaActual As String = DateTime.Now.ToString("dd-MMM-yyyy").ToUpper()

            ColEncFec = New PdfPCell(New Phrase("FECHA DE EMISI�N: " & DTfAlta.Text, Font8))
            ColEncFec.Border = 0
            ColEncFec.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEncFechas.AddCell(ColEncFec)







            Dim TableGeneralUsuario As PdfPTable = New PdfPTable(3)
            TableGeneralUsuario.WidthPercentage = 100
            TableGeneralUsuario.DefaultCell.Border = BorderStyle.None
            Dim widthsInfUsua As Single() = New Single() {500, 100.0F, 400.0F}
            TableGeneralUsuario.SetWidths(widthsInfUsua)

            'Tabla Info Usuario 1
            Dim TableUsua1 As PdfPTable = New PdfPTable(1)
            TableUsua1.WidthPercentage = 100

            Dim widthsInfUsua1 As Single() = New Single() {500.0F}
            TableUsua1.SetWidths(widthsInfUsua1)

            Dim Contrato As String = _FOLIO
            Dim UsuarioCot As String = txtNombre.Text
            'Dim IDCValvu As String = dts("idcuotavalvulista")

            Dim contenidox As String = "Datos de la Toma:"

            Dim ColInfoUsu1 = New PdfPCell(New Phrase(contenidox, Font10N))
            ColInfoUsu1.BorderWidthTop = 1
            ColInfoUsu1.BorderWidthLeft = 1
            ColInfoUsu1.BorderWidthRight = 1
            ColInfoUsu1.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableUsua1.AddCell(ColInfoUsu1)

            Dim contenido As String = "Contrato: " & txtcuenta.Text & " " & UsuarioCot

            ColInfoUsu1 = New PdfPCell(New Phrase(contenido, Font10N))
            ColInfoUsu1.Border = 0
            ColInfoUsu1.BorderWidthLeft = 1
            ColInfoUsu1.BorderWidthRight = 1
            ColInfoUsu1.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableUsua1.AddCell(ColInfoUsu1)

            Dim contenido2 As String = txtUbi.Text

            ColInfoUsu1 = New PdfPCell(New Phrase(contenido2, Font10N)) With {
            .Border = 0,
            .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            }
            TableUsua1.AddCell(ColInfoUsu1)

            Dim estadotoma As String = ""
            ColInfoUsu1 = New PdfPCell(New Phrase(CmbComunidad.Text, Font10N)) With {
            .Border = 0,
             .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua1.AddCell(ColInfoUsu1)

            ColInfoUsu1 = New PdfPCell(New Phrase("Medidor: " & txtMED.Text, Font10N)) With {
            .Border = 0,
             .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua1.AddCell(ColInfoUsu1)

            ColInfoUsu1 = New PdfPCell(New Phrase("Telefono: " & txtTel.Text & " " & txtCel.Text, Font10N)) With {
                .Border = 0,
                 .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
                .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            }
            TableUsua1.AddCell(ColInfoUsu1)

            Dim tarifa = obtenerCampo("select tarifa from usuario where cuenta=" & txtcuenta.Text, "tarifa")

            Try
                cuotas = ConsultaSql("select * from cuotas where id_tarifa='" & tarifa & "'").ExecuteReader()
                cuotas.Read()
                tarifa = cuotas("Descripcion_cuota")
                cuotas.Close()
            Catch ex As Exception
                tarifa = ""
            End Try


            ColInfoUsu1 = New PdfPCell(New Phrase("Tarifa: " & tarifa.ToUpper(), Font10N)) With {
                .Border = 0,
                 .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .BorderWidthBottom = 1,
                .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            }

            'ColInfoUsu1 = New PdfPCell(New Phrase("Tarifa: " & id_tipo_usuario, Font10N)) With {
            '    .Border = 0,
            '     .BorderWidthLeft = 1,
            '.BorderWidthRight = 1,
            '.BorderWidthBottom = 1,
            '    .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            '}
            TableUsua1.AddCell(ColInfoUsu1)

            TableGeneralUsuario.AddCell(TableUsua1)


            'Tabla Info Usuario 2
            Dim TableUsua2 As PdfPTable = New PdfPTable(1)
            TableUsua2.WidthPercentage = 100
            Dim widthsInfUsua2 As Single() = New Single() {100.0F}
            TableUsua1.SetWidths(widthsInfUsua2)

            Dim ColInfoUsu2 = New PdfPCell(New Phrase(" ")) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua2.AddCell(ColInfoUsu2)

            TableGeneralUsuario.AddCell(TableUsua2)

            'Tabla Info Usuario 1
            TableUsua1 = New PdfPTable(1)
            TableUsua1.WidthPercentage = 100


            TableUsua1.SetWidths(widthsInfUsua1)


            ColInfoUsu2 = New PdfPCell(New Phrase(" ")) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua2.AddCell(ColInfoUsu2)
            contenidox = "Clasificacion de la orden:"

            ColInfoUsu1 = New PdfPCell(New Phrase(contenidox, Font10N))
            ColInfoUsu1.BorderWidthTop = 1
            ColInfoUsu1.BorderWidthLeft = 1
            ColInfoUsu1.BorderWidthRight = 1
            ColInfoUsu1.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableUsua1.AddCell(ColInfoUsu1)

            contenido = cmbProb.Text

            ColInfoUsu1 = New PdfPCell(New Phrase(contenido, Font10N))
            ColInfoUsu1.Border = 0
            ColInfoUsu1.BorderWidthLeft = 1
            ColInfoUsu1.BorderWidthRight = 1
            ColInfoUsu1.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            TableUsua1.AddCell(ColInfoUsu1)

            contenido2 = Departamento

            ColInfoUsu1 = New PdfPCell(New Phrase(contenido2, Font10N)) With {
            .Border = 0,
            .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            }
            TableUsua1.AddCell(ColInfoUsu1)




            ColInfoUsu1 = New PdfPCell(New Phrase("", Font10N)) With {
            .Border = 0,
             .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua1.AddCell(ColInfoUsu1)

            ColInfoUsu1 = New PdfPCell(New Phrase("", Font10N)) With {
                .Border = 0,
                 .BorderWidthLeft = 1,
            .BorderWidthRight = 1,
            .BorderWidthBottom = 1,
                .HorizontalAlignment = PdfPCell.ALIGN_LEFT
            }
            TableUsua1.AddCell(ColInfoUsu1)





            TableGeneralUsuario.AddCell(TableUsua1)

            'Tabla Info Usuario 3





            'Tabla Informaci�n Lecturas

            Dim TableUsua3 As PdfPTable = New PdfPTable(1)
            TableUsua3.WidthPercentage = 100
            Dim widthsInfUsua3 As Single() = New Single() {1000.0F}
            TableUsua3.SetWidths(widthsInfUsua3)




            Dim ColInfoUsu3 = New PdfPCell(New Phrase("Fecha compromiso " & DTfeccom.Text, Font8N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)
            ColInfoUsu3 = New PdfPCell(New Phrase(" ", Font8N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)


            ColInfoUsu3 = New PdfPCell(New Phrase("INDICACIONES :" & txtInd.Text, Font12N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)


            Dim x As String = ""
            x = "FUENTE: " & cmbFue.Text & "   "
            If chkUrge.Checked = True Then
                x = x & "URGUE "
            End If

            If chkRein.Checked = True Then
                x = x & " REINCIDE "
            End If
            ColInfoUsu3 = New PdfPCell(New Phrase(x, Font10N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)

            ColInfoUsu3 = New PdfPCell(New Phrase(" ", Font8N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)

            ColInfoUsu3 = New PdfPCell(New Phrase("ELABORO :" & ELABORO, Font8N)) With {
            .Border = 0,
            .HorizontalAlignment = PdfPCell.ALIGN_LEFT
        }
            TableUsua3.AddCell(ColInfoUsu3)



            Dim imagenBMP2 As iTextSharp.text.Image
            imagenBMP2 = iTextSharp.text.Image.GetInstance(esquemaBYTE)
            imagenBMP2.ScaleAbsolute(200.0F, 300.0F)
            imagenBMP2.Border = 0
            ' imagenBMP.ScalePercent(22.0) 'escala al tama�o de la imagen
            ' imagenBMP.SetAbsolutePosition(30, 700)

            ' pdfDoc.Add(imagenBMP)




            Dim TableEsquema As PdfPTable = New PdfPTable(3)
            TableEsquema.DefaultCell.Border = BorderStyle.None
            TableEsquema.WidthPercentage = 100
            Dim widthsEsquema As Single() = New Single() {450, 100.0F, 450.0F}
            TableEsquema.SetWidths(widthsEsquema)


            Dim ColPiePag2 = New PdfPCell(imagenBMP2)
            ColPiePag2.BorderWidth = 1
            ColPiePag2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEsquema.AddCell(ColPiePag2)



            ColPiePag1 = New PdfPCell(New Phrase("", Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEsquema.AddCell(ColPiePag1)



            ColPiePag1 = New PdfPCell(New Phrase("RESULTADOS:  " & txtCom.Text, Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            TableEsquema.AddCell(ColPiePag1)



            Dim tablefirmas As PdfPTable = New PdfPTable(3)
            tablefirmas.DefaultCell.Border = BorderStyle.None
            tablefirmas.WidthPercentage = 100
            Dim widthsEncfirmas As Single() = New Single() {300.0F, 400.0F, 300.0F}
            tablefirmas.SetWidths(widthsEncfirmas)


            ColPiePag1 = New PdfPCell(New Phrase("_____________________________", Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)


            ColPiePag1 = New PdfPCell(New Phrase("______________________________", Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)

            ColPiePag1 = New PdfPCell(New Phrase("______________________________", Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)



            ColPiePag1 = New PdfPCell(New Phrase(cmbRel.Text, Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)


            ColPiePag1 = New PdfPCell(New Phrase(txtNombre.Text, Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)

            ColPiePag1 = New PdfPCell(New Phrase(ELABORO.ToUpper(), Font10N))
            ColPiePag1.Border = 0
            ColPiePag1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tablefirmas.AddCell(ColPiePag1)

            Dim tableArticulo As PdfPTable = New PdfPTable(1)
            tableArticulo.DefaultCell.Border = BorderStyle.None
            tableArticulo.WidthPercentage = 100
            Dim widthsArticulo As Single() = New Single() {1000.0F}
            tableArticulo.SetWidths(widthsArticulo)

            Dim ColPiePag3 = New PdfPCell(New Phrase("La falta de pago en dos ocasiones consecutivas por parte de usuarios no dom�sticos,faculta al prestador de los servicios a suspender los servicios p�blicos hasta que regularice su pago. En el caso de uso dom�stico, la falta de pago en dos ocasiones consecutivas ocasionar� la suspensi�n del servicio y de no regularizarse el mismo en el termino de treinta dias naturales, se proceder� a la suspensi�n desde la red de distribuci�n.", Font9))
            ColPiePag3.Border = 0
            ColPiePag3.HorizontalAlignment = PdfPCell.ALIGN_LEFT
            'ColPiePag1.BackgroundColor = New iTextSharp.text.BaseColor(21, 76, 121)
            tableArticulo.AddCell(ColPiePag3)


            pdfDoc.Add(TableEncGeneral)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableEncFechas)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableGeneralUsuario)
            pdfDoc.Add(TableUsua3)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableEsquema)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(tablefirmas)
            pdfDoc.Add(TableVacio)
            pdfDoc.Add(tableArticulo)

            pdfDoc.Close()


            Try
                Dim psi As New ProcessStartInfo(nombrearchivo)
                'psi.WorkingDirectory = cadenafolder & "\factura\" + nombresespacios

                psi.WindowStyle = ProcessWindowStyle.Normal
                Dim p As Process = Process.Start(psi)
            Catch ex As Exception
                MessageBox.Show("Error al visualizar el pdf, posiblemente el archivo este en uso, cierrelo antes de generar un nuevo reporte" & ex.Message)
            End Try




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




End Class