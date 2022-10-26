Imports System.Data.Odbc
Imports DevComponents.DotNetBar

Public Class frmfactibilidad
    Dim NUMEROACARGAR As Long = 0
    Public responsable As Integer, Clave As Double
    Dim comunidad As String
    Dim regionx As String

    Private Sub frmfactibilidad_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmListFacti.Actualizar()
    End Sub
    Private Sub frmfactibilidad_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()
    End Sub
    Private Sub frmfactibilidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim ascii As Keys = e.KeyData
        Select Case ascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub
    'Private Sub frmfactibilidad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    My.Forms.MDIPrincipal.btnconvierteacontrato.Enabled = False
    'End Sub
    Private Sub frmfactibilidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(CmbDiametro, "descripcion", "select descripcion from diametros")
        TxtClave.Text = Clave
        llenarCombo(cmbresponsable, "select idtrab, nombre from trabajadores")
        cmbestado.Items.Add("EN PROCESO")
        cmbestado.Items.Add("RECHAZADA")
        'cmbestado.Items.Add("CONTRATADA")
        cmbestado.Items.Add("APROBADA")
        llenarCombo(cmbuso, "descripcion", "select descripcion from tipos_usuarios")
        Dim Fec As IDataReader = ConsultaSql("select id_comunidad,diamtoma, capalberca, capcisterna, captinaco, derivacion, altura, latitud, longitud, nombre, observafacti, costocontrato, montofactibilidad, estadosolicitud, responsable,  fechasolicitud, contratode, usosolicitado, usoverificado, fechavisita1,fechavisita2,fechavisita3,MONTOMATERIALES,fechainspeccion,region,ruta,MANZANA,LOTE from solicitud where numero = " & Val(TxtClave.Text) & "").ExecuteReader
        If Fec.Read Then
            comunidad = Fec("id_comunidad")

            'llena el combo con las regiones

            If Not comunidad = "" Then
                'llenarCombo(cmbcolonia, "select id_colonia, colonia from colonia  WHERE ID_COMUNIDAD='" & Cmbcomunidad.SelectedValue.ToString & "' order by colonia")
                llenarCombo(Cmbregion, "select id_region, region from region where id_comunidad='" & comunidad & "' order by region")
            End If
            Try
                If Not IsDBNull(Fec("region")) Then
                    Cmbregion.SelectedValue = Fec("region")
                End If

                If Not Cmbregion.SelectedValue Is Nothing AndAlso Cmbregion.SelectedValue.ToString <> "System.Data.DataRowView" Then
                    llenarCombo(Cmbruta, "select id_ruta, ruta from rutas where id_region='" & Cmbregion.SelectedValue.ToString & "' and id_comunidad='" & comunidad & "'")
                End If

                If Not IsDBNull(Fec("ruta")) Then
                    Cmbruta.SelectedValue = Fec("ruta")
                End If

                If Not IsDBNull(Fec("MANZANA")) Then

                    txtmzn.Text = Fec("MANZANA")
                    LLENAMANZANA()
                End If

                If Not IsDBNull(Fec("LOTE")) Then
                    txtlote.Text = Fec("LOTE")
                    LLENALOTE()
                End If

            Catch ex As Exception
                Stop
            End Try
            CrearUbicacion()





            If Not IsDBNull(Fec("fechainspeccion")) Then dtpfechains.Value = Fec("fechainspeccion") Else dtpfechains.Value = Now
            dt1ravisita.MinDate = DateAdd(DateInterval.Day, -1, dtpfechains.Value)
            txtusuario.Text = Fec("nombre")
            txtmotivo.Text = Fec("contratode")
            txtmateriales.Value = Fec("MONTOMATERIALES")
            If Fec("responsable") <> 0 Then
                cmbresponsable.Text = obtenerCampo("select nombre from trabajadores where idtrab = " & Fec("responsable") & "", "nombre")
            End If
            cmbestado.Text = Fec("estadosolicitud")
            If cmbestado.Text <> "CONTRATADA" And cmbestado.Text <> "CANCELADA" Then
                cmdAcept.Enabled = True
            Else
                cmdAcept.Enabled = False
                'MessageBoxEx.Show("La Factibilidad esta en estado " & cmbestado.Text & ", solo se mostrara en modo consulta", "FACTIBILIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                modoVisualizar()
            End If
            txtobservaciones.Text = Fec("observafacti")
            If Not IsDBNull(Fec("usosolicitado")) Then TxtSolicitado.Text = obtenerCampo("Select descripcion from tipos_usuarios where id_tipo_usuario = '" & Fec("usosolicitado") & "'", "descripcion") Else TxtSolicitado.Text = ""
            If Not IsDBNull(Fec("usoverificado")) Then cmbuso.Text = obtenerCampo("select descripcion from tipos_usuarios where id_tipo_usuario = '" & Fec("usoverificado") & "'", "descripcion") Else cmbuso.Text = ""
            If Not IsDBNull(Fec("fechavisita1")) Then dt1ravisita.Value = Fec("fechavisita1")
            If Not IsDBNull(Fec("fechavisita2")) Then dt2davisita.Value = Fec("fechavisita2")
            If Not IsDBNull(Fec("fechavisita3")) Then dt3ravisita.Value = Fec("fechavisita3")


            txtcosto.Text = Val(Fec("costocontrato"))
            CmbDiametro.Text = obtenerCampo("Select descripcion from diametros where id_diametro = '" & Fec("diamtoma") & "'", "Descripcion")
            NCapAlberca.Value = Val(Fec("capalberca"))
            NCapCisterna.Value = Val(Fec("capcisterna"))
            NCapTinaco.Value = Val(Fec("captinaco"))
            nderivacion.Value = Val(Fec("derivacion"))
            If Not IsDBNull(Fec("altura")) Then TxtASNM.Text = Fec("altura")
            If Not IsDBNull(Fec("latitud")) Then TxtLatitud.Text = Fec("latitud")
            If Not IsDBNull(Fec("latitud")) Then TxtLongitud.Text = Fec("longitud")
        End If
        'cmbestado.Select()
        dtpfechains.Select()
    End Sub
    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        If lblubicacion.Text.Length = 18 Then
            Dim ubitem As String
            ubitem = obtenerCampo("select cuenta,ubicacion from usuario where ubicacion='" & lblubicacion.Text & "'", "cuenta")


            If ubitem <> "0" Then
                Select Case ubitem.Length
                    Case 1
                        ubitem = "00000" & ubitem
                    Case 2
                        ubitem = "0000" & ubitem
                    Case 3
                        ubitem = "000" & ubitem
                    Case 4
                        ubitem = "00" & ubitem
                    Case 5
                        ubitem = "0" & ubitem
                End Select
                MessageBox.Show("No puedo grabarlo así, la ubicacion existe actualmente para la cuenta " & ubitem & ", ubicalo correctamente")
                Exit Sub
            End If
        End If
        If cmbuso.SelectedItem = "" Then
            MessageBoxEx.Show("Introduzca el tipo de uso solicitado, por favor", "Factibilidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbuso.Select()
            Exit Sub
        End If
        If cmbresponsable.SelectedValue = Nothing Then
            MessageBoxEx.Show("Introduzca el jefe de zona, por favor", "Factibilidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbresponsable.Select()
            Exit Sub
        End If
        If dt1ravisita.Value = Nothing Then
            MessageBoxEx.Show("Introduzca la primera visita", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dt1ravisita.Select()
            Exit Sub
        End If

        If dtpfechains.Value = Nothing Then
            MessageBoxEx.Show("Introduzca la fecha de inspección, por favor", "Factibilidad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpfechains.Select()
            Exit Sub
        End If
        Dim Resp As Integer = 0
        'If cmbresponsable.Text <> "" Then
        '    Resp = obtenerCampo("select idtrab from trabajadores where nombre = '" & cmbresponsable.Text & "'", "idtrab")
        'End If
        Dim puso As String = obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion = '" & cmbuso.Text & "'", "id_tipo_usuario")
        Dim diamtoma As String = obtenerCampo("Select id_diametro from diametros where descripcion = '" & CmbDiametro.Text & "'", "id_diametro")
        Dim cadenaupdate As New StringBuilder
        LLENALOTE()
        LLENAMANZANA()

        cadenaupdate.Append("update solicitud set diamtoma = '" & diamtoma & "', capalberca = " & NCapAlberca.Value & ", capcisterna = " & NCapCisterna.Value & ",")
        cadenaupdate.Append("captinaco = " & NCapTinaco.Value & ", derivacion  = " & nderivacion.Value & ", altura = '" & TxtASNM.Text & "', latitud = '" & TxtLatitud.Text & "',")
        cadenaupdate.Append("longitud = '" & TxtLongitud.Text & "' , observafacti = '" & txtobservaciones.Text & "', costocontrato = " & txtcosto.Value & ", estadosolicitud = '" & cmbestado.Text & "',")
        cadenaupdate.Append("responsable = " & cmbresponsable.SelectedValue.ToString & ", usoverificado = '" & puso & "', fechavisita1 = '" & UnixDateFormat(dt1ravisita.Value) & "',")
        cadenaupdate.Append("fechavisita2 = '" & UnixDateFormat(dt2davisita.Value) & "',fechavisita3 = '" & UnixDateFormat(dt3ravisita.Value) & "',MONTOMATERIALES = " & txtmateriales.Value & ",")
        cadenaupdate.Append("fechainspeccion='" & UnixDateFormat(dtpfechains.Value) & "', region='" & Cmbregion.SelectedValue & "', RUTA='" & Cmbruta.SelectedValue & "', MANZANA=" & txtmzn.Text & ", LOTE=" & txtlote.Text & " ")
        cadenaupdate.Append(" where numero = " & Val(TxtClave.Text) & "")
        Ejecucion(cadenaupdate.ToString)
        MessageBoxEx.Show("La información para la factibilidad: " & TxtClave.Text & " ha sido guardada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmdImp.Visible = True
        frmListSoli.CatControl1.Actualizar()
        cmdAcept.Visible = False

    End Sub
    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim rs As IDataReader = ConsultaSql("Select entrecalle1, entrecalle2,entrecalle3,entrecalle4,entrecalle5, id_colonia, id_comunidad from solicitud where numero = " & TxtClave.Text & " ").ExecuteReader
        rs.Read()
        Dim calle1 As String = obtenerCampo("Select nombre from calles where id_comunidad = '" & rs("id_comunidad") & "' and id_colonia = '" & rs("id_colonia") & "' and id_calle = '" & rs("entrecalle1") & "'", "nombre")
        Dim calle2 As String = obtenerCampo("Select nombre from calles where id_comunidad = '" & rs("id_comunidad") & "' and id_colonia = '" & rs("id_colonia") & "' and id_calle = '" & rs("entrecalle2") & "'", "nombre")
        Dim calle3 As String = obtenerCampo("Select nombre from calles where id_comunidad = '" & rs("id_comunidad") & "' and id_colonia = '" & rs("id_colonia") & "' and id_calle = '" & rs("entrecalle3") & "'", "nombre")
        Dim calle4 As String = obtenerCampo("Select nombre from calles where id_comunidad = '" & rs("id_comunidad") & "' and id_colonia = '" & rs("id_colonia") & "' and id_calle = '" & rs("entrecalle4") & "'", "nombre")
        Dim calle5 As String = obtenerCampo("Select nombre from calles where id_comunidad = '" & rs("id_comunidad") & "' and id_colonia = '" & rs("id_colonia") & "' and id_calle = '" & rs("entrecalle5") & "'", "nombre")
        Dim frm As New frmReporte(frmReporte.Lista.Factibilidad, "{solicitud1.numero} = " & Val(TxtClave.Text) & "", "Calle1, '" & calle1 & "'", "Calle2, '" & calle2 & "'", "Calle3, '" & calle3 & "'", "Calle4, '" & calle4 & "'", "Calle5, '" & calle5 & "'")
        frm.MdiParent = My.Forms.MDIPrincipal
        frm.Show()
        frm.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub cmdCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click
        Close()
    End Sub
    Public Sub modoVisualizar()
        gPGen.Enabled = False
        gpTipSol.Enabled = False
        gpRes.Enabled = False
        'TabControl1.Enabled = False
        CmbDiametro.Enabled = False
        NCapCisterna.Enabled = False
        txtcosto.Enabled = False
        nderivacion.Enabled = False
        NCapAlberca.Enabled = False
        txtmateriales.Enabled = False
        TxtLongitud.Enabled = False
        TxtLatitud.Enabled = False
        TxtASNM.Enabled = False
        txtobservaciones.Enabled = False
        NCapTinaco.Enabled = False
    End Sub
    Private Sub dt1ravisita_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt1ravisita.ValueChanged
        If DateDiff(DateInterval.Day, dtpfechains.Value, dt1ravisita.Value) < 0 Then
            MessageBoxEx.Show("ESTÁ INTENTANDO INTRODUCIR UNA FECHA INFERIOR A LA FECHA DE INSPECCIÓN, VERIFIQUE SUS DATOS POR FAVOR", "FACTIBILIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt1ravisita.Value = dtpfechains.Value
        End If
    End Sub
    Private Sub dt2davisita_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt2davisita.ValueChanged
        If DateDiff(DateInterval.Day, dtpfechains.Value, dt2davisita.Value) < 0 Then
            MessageBoxEx.Show("ESTÁ INTENTANDO INTRODUCIR UNA FECHA INFERIOR A LA FECHA DE INSPECCIÓN, VERIFIQUE SUS DATOS POR FAVOR", "FACTIBILIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt2davisita.Value = dtpfechains.Value
        End If
    End Sub
    Private Sub dt3ravisita_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt3ravisita.ValueChanged
        If DateDiff(DateInterval.Day, dtpfechains.Value, dt3ravisita.Value) < 0 Then
            MessageBoxEx.Show("ESTÁ INTENTANDO INTRODUCIR UNA FECHA INFERIOR A LA FECHA DE INSPECCIÓN, VERIFIQUE SUS DATOS POR FAVOR", "FACTIBILIDAD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dt3ravisita.Value = dtpfechains.Value
        End If
    End Sub
    Private Sub cmbuso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbuso.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbuso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbuso.SelectedIndexChanged
        txtcosto.Text = Val(obtenerCampo("Select costo from tipos_usuarios where descripcion = '" & cmbuso.Text & "'", "costo"))
    End Sub
    Private Sub cmbresponsable_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbresponsable.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbresponsable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbresponsable.SelectedIndexChanged
        responsable = obtenerCampo("select idtrab from trabajadores where nombre = '" & (cmbresponsable.Text) & "'", "idtrab")
    End Sub
    Private Sub CmbDiametro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbDiametro.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub CrearUbicacion()
        Dim Com, Reg, Rut As String
        'Try
        '    Com = obtenerCampo("Select id_comunidad from comunidades where comunidad = '" & comunidad & "'", "id_comunidad")
        'Catch ex As Exception
        '    Com = ""
        'End Try
        Com = comunidad
        If comunidad.Length = 1 Then
            Com = "0" & comunidad
        End If

        Try
            Reg = obtenerCampo("Select id_region from region where region = '" & Cmbregion.Text & "'", "id_region")
        Catch ex As Exception
            Reg = ""
        End Try
        Try
            Rut = obtenerCampo("Select id_ruta from rutas where ruta = '" & Cmbruta.Text & "'", "id_ruta")
        Catch ex As Exception
            Rut = ""
        End Try
        lblubicacion.Text = Com & "-" & Reg & "-" & Rut & "-" & txtmzn.Text & "-" & txtlote.Text

    End Sub

    Private Sub txtmzn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmzn.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtmzn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmzn.LostFocus
        LLENAMANZANA()
    End Sub

    Private Sub txtmzn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmzn.TextChanged
        CrearUbicacion()
    End Sub

    Private Sub txtlote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtlote.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtlote_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtlote.LostFocus
        LLENALOTE()
    End Sub

    Dim lote As Integer



    Private Sub txtlote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlote.TextChanged
        CrearUbicacion()
    End Sub

    Private Sub Cmbregion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbregion.SelectedIndexChanged
        If Not Cmbregion.SelectedValue Is Nothing AndAlso Cmbregion.SelectedValue.ToString <> "System.Data.DataRowView" Then
            llenarCombo(Cmbruta, "select id_ruta, ruta from rutas where id_region='" & Cmbregion.SelectedValue.ToString & "' and id_comunidad='" & comunidad & "'")
        End If
        CrearUbicacion()
    End Sub

    Private Sub Cmbruta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbruta.SelectedIndexChanged
        'Ruta = obtenerCampo("select claveruta from rutas where descripcion=""" & cmbruta.Text & """", "claveruta")
        If Not Cmbruta.SelectedValue Is Nothing AndAlso Cmbruta.SelectedValue.ToString <> "System.Data.DataRowView" Then
            ' cruta(Sector, Cmbruta.SelectedValue.ToString, Colonia, txtmzn.Text, txtlote.Text)
            CrearUbicacion()
        End If
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
        CrearUbicacion()
    End Sub

    Private Sub LLENALOTE()
        lote = Val(txtlote.Text)
        If lote <= 0 Then
            lote = 0
            txtlote.Text = "000"
        End If

        If lote <= 9 Then
            txtlote.Text = "00" & lote
        End If
        If lote >= 10 And lote <= 99 Then
            txtlote.Text = "0" & lote
        End If
        CrearUbicacion()

    End Sub


    Private Sub dtpfechains_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpfechains.LostFocus
        dt1ravisita.MinDate = dtpfechains.Value
    End Sub
End Class