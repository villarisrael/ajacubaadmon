Imports System.Data
Imports DevComponents.DotNetBar

Public Class Frmsolicitud
    Public Nuevo As Boolean, Clave As Double
    Public Modificar As Boolean
    Dim Sector As String, Colonia As String, Municipio As String, Comunidad As String, tipousuario As String
    Dim UbiCroquis As Integer

#Region "carga formulario"

    Private Sub Frmsolicitud_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmListSoli.Actualizar()
    End Sub

    Private Sub Frmsolicitud_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIPrincipal.RTUsuarios.Select()

    End Sub

    'Private Sub Frmsolicitud_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
    '    MDIPrincipal.RTUsuarios.Select()
    'End Sub

    Private Sub Frmsolicitud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter

                SendKeys.Send("{TAB}")

                If TxtCostoFacti.Focused Then
                    Tabsolicitud.SelectNextTab()
                End If

        End Select
    End Sub

    Private Sub Frmsolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' tipo de contrato
        cmbcontrato.Items.Add("AGUA")
        cmbcontrato.Items.Add("DRENAJE")
        cmbcontrato.Items.Add("AMBOS")
        cmbcontrato.SelectedIndex = 0

        llenarCombo(CmbEstPredio, "SELECT idEstado_Predio, Descripcion FROM estado_predio ORDER BY Descripcion")
        CmbEstPredio.SelectedIndex = 0

        llenarCombo(Cmbsector, "select clavesec, descripcion from sectores order by descripcion")
        Cmbsector.SelectedIndex = 0
        'llena el combo de municipio
        llenarCombo(Cmbmunicipio, "select clave, nombre from municipios order by nombre")

        llenarCombo(CmbCalle, "select id_Calle, nombre from calles order by nombre")
        llenarCombo(CMBCALLE1, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE2, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE3, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE4, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(CMBCALLE5, "SELECT ID_CALLE, NOMBRE FROM calles  ORDER BY NOMBRE")
        llenarCombo(Cmbcomunidad, "SELECT ID_COMUNIDAD, COMUNIDAD FROM comunidades ORDER BY comunidad")
        llenarCombo(cmbcolonia, "select id_Colonia, Colonia from colonia order by colonia")

        Cmbmunicipio.SelectedIndex = 0

        Dim IDMUNI As Integer
        IDMUNI = Cmbmunicipio.SelectedValue.ToString

        'llena tipo de usos
        llenarCombo(cmbtipouso, "select id_tipo_usuario, descripcion from tipos_usuarios")

        cmdImp.Enabled = False
        dtComp.Value = DiasHabiles(Now, 7)
        dtfsolicitud.Value = Now
        If Nuevo = False Then
            'MDIPrincipal.txtnumerodesolicitud.Text = Me.txtclave.Text
            cmdImp.Enabled = True
            Dim Rs As IDataReader = ConsultaSql("Select * from solicitud where numero = " & Clave & " ").ExecuteReader
            Rs.Read()
            If Rs.RecordsAffected > 0 Then
                txtclave.Text = Rs("numero")
                dtfsolicitud.Value = Rs("fechasolicitud")
                txtidentificacion.Text = Rs("seiden")
                txtsolicitado.Text = Rs("solispor")
                txtpropietario.Text = Rs("nombre")
                Cmbmunicipio.SelectedValue = Rs("nmunicipio")
                Cmbcomunidad.SelectedValue = Rs("id_comunidad")
                '  Cmbcomunidad.SelectedIndex = 13
                cmbcolonia.SelectedValue = Rs("id_colonia")

                If My.Settings.CombodeCalles = "SI" Then
                    CmbCalle.SelectedValue = Rs("id_calle")
                    CmbCalle.Visible = True

                    txtDomicilio.Visible = False
                Else

                    txtDomicilio.Text = Rs("Domicilio")
                    txtDomicilio.Visible = True
                    CmbCalle.Visible = False
                End If

                If Rs("noorden") > 0 Then
                    lblOrd.BackColor = Color.Red
                    lblOrd.Text = "Orden de trabajo: " & Rs("noorden")
                End If
                TxtTel.Text = Rs("telefono")
                txtcp.Text = Rs("cp")
                txtrfc.Text = Rs("rfc")
                cmbcontrato.Text = Rs("contratode")

                Select Case Rs("estadosolicitud")
                    Case "APROBADA"
                        lblEst.Text = "APROBADA"
                        lblEst.BackColor = Color.ForestGreen
                    Case "RECHAZADA"
                        lblEst.Text = "RECHAZADA"
                        lblEst.BackColor = Color.Orange
                    Case "EN PROCESO"
                        lblEst.Text = "EN PROCESO"
                        lblEst.BackColor = Color.FloralWhite
                    Case "CANCELADA"
                        lblEst.Text = "CANCELADA"
                        lblEst.BackColor = Color.Red
                    Case "CONTRATADA"
                        lblEst.Text = "CONTRATADA"
                        lblEst.BackColor = Color.RoyalBlue
                    Case "PENDIENTE"
                        lblEst.Text = "PENDIENTE"
                        lblEst.BackColor = Color.FloralWhite
                        BtnOrdenTrabajo.Visible = True
                End Select
                txtobservaciones.Text = Rs("observa")
                UbiCroquis = Rs("ubicroquis")
                croquis(UbiCroquis)
                If Not IsDBNull(Rs("entrecalle1")) And Not Rs("entrecalle1").ToString = "" Then CMBCALLE1.Text = obtenerCampo("Select nombre from calles where id_comunidad = '" & Rs("id_comunidad") & "' and id_colonia = '" & Rs("id_colonia") & "' and id_calle = '" & Rs("entrecalle1") & "' ", "nombre")
                If Not IsDBNull(Rs("entrecalle2")) And Not Rs("entrecalle2").ToString = "" Then CMBCALLE2.Text = obtenerCampo("Select nombre from calles where id_comunidad = '" & Rs("id_comunidad") & "' and id_colonia = '" & Rs("id_colonia") & "' and id_calle = '" & Rs("entrecalle2") & "' ", "nombre")
                If Not IsDBNull(Rs("entrecalle3")) And Not Rs("entrecalle3").ToString = "" Then CMBCALLE3.Text = obtenerCampo("Select nombre from calles where id_comunidad = '" & Rs("id_comunidad") & "' and id_colonia = '" & Rs("id_colonia") & "' and id_calle = '" & Rs("entrecalle3") & "' ", "nombre")
                If Not IsDBNull(Rs("entrecalle4")) And Not Rs("entrecalle4").ToString = "" Then CMBCALLE4.Text = obtenerCampo("Select nombre from calles where id_comunidad = '" & Rs("id_comunidad") & "' and id_colonia = '" & Rs("id_colonia") & "' and id_calle = '" & Rs("entrecalle4") & "' ", "nombre")
                If Not IsDBNull(Rs("entrecalle5")) And Not Rs("entrecalle5").ToString = "" Then CMBCALLE5.Text = obtenerCampo("Select nombre from calles where id_comunidad = '" & Rs("id_comunidad") & "' and id_colonia = '" & Rs("id_colonia") & "' and id_calle = '" & Rs("entrecalle5") & "' ", "nombre")
                txtparentesco.Text = Rs("parentesco")
                Cmbsector.Text = "" & obtenerCampo("select descripcion from sectores where clavesec = '" & Rs("sector") & "'", "descripcion")
                txtnumext.Text = Rs("numext")
                txtnumint.Text = Rs("numint")
                txtref.Text = Rs("referencias")
                cmbtipouso.Text = obtenerCampo("select descripcion from tipos_usuarios where id_tipo_usuario = '" & Rs("usosolicitado") & "' ", "descripcion")
                CmbEstPredio.Text = Rs("estpredio")
                dtComp.Text = Rs("compromiso")
                If Rs("coppred").ToString = "s" Then ChkPredial1.Checked = True Else ChkPredial1.Checked = False
                If Rs("copcred").ToString = "s" Then chkcrede.Checked = True Else chkcrede.Checked = False
                If Rs("constdel").ToString = "s" Then chconsdele.Checked = True Else chconsdele.Checked = False
                If Rs("croqloc").ToString = "s" Then chkCroqLoc.Checked = True Else chkCroqLoc.Checked = False
                If Rs("pagfac").ToString = "s" Then chkPagFac.Checked = True Else chkPagFac.Checked = False
                TxtCostoFacti.Text = Rs("montofactibilidad")
            End If
        Else
            dtComp.Value = DiasHabiles(Now, 4)
            txtpropietario.Focus()
        End If

        If Modificar = False OrElse lblEst.Text = "CANCELADA" Then
            Deshabilitar()
        End If

        If Not Nuevo AndAlso Not Modificar Then
            If lblEst.Text <> "CANCELADA" Then
                cmdImp.Visible = True
            Else
                cmdImp.Visible = False
            End If
        End If

        dtfsolicitud.Select()
    End Sub

#End Region

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub cmbtipouso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tipousuario = cmbtipouso.SelectedValue.ToString
    End Sub

    Private Sub CMBCALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    'Private Sub CMBCALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE.KeyPress
    '    DespliegaCombo(CMBCALLE, e)
    'End Sub

    Private Sub CMBCALLE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  LblCalleprincipal.Text = CMBCALLE.Text
    End Sub

    Private Sub Cmbmunicipio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbmunicipio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


    'Private Sub Cmbmunicipio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbmunicipio.KeyPress
    '    DespliegaCombo(Cmbmunicipio, e)
    'End Sub

    Private Sub Cmbmunicipio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbmunicipio.SelectedIndexChanged
        If Cmbmunicipio.SelectedIndex - 1 Then
            Exit Sub
        End If

        Try
            Try
                If Cmbmunicipio.SelectedValue.ToString() = "" Then
                    Exit Sub
                End If

            Catch ex As Exception
                Exit Sub
            End Try

            If Cmbmunicipio.SelectedValue.ToString > 0 Then
                llenarCombo(Cmbcomunidad, "select id_comunidad, comunidad from comunidades where nmpio = '" & Cmbmunicipio.SelectedValue.ToString & "' order by comunidad")
            End If

            Cmbsector.SelectedItem = 0
            Cmbcomunidad.SelectedItem = Nothing
            cmbcolonia.SelectedItem = Nothing
            ' CMBCALLE.SelectedItem = Nothing
            txtnumint.Text = ""
            CmbEstPredio.SelectedItem = Nothing
            txtcp.Text = ""
            txtnumext.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cmbcomunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbcomunidad.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    'Private Sub Cmbcomunidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbcomunidad.KeyPress
    '    DespliegaCombo(Cmbcomunidad, e)
    'End Sub

    Private Sub Cmbcomunidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbcomunidad.SelectedIndexChanged
        'Try
        '    If Cmbcomunidad.SelectedValue.ToString <> "System.Data.DataRowView" Then
        '        llenarCombo(cmbcolonia, "select id_colonia, colonia from colonia  order by colonia")
        '        Try
        '            ' llenarCombo(CMBCALLE, "SELECT ID_CALLE, NOMBRE FROM CALLES  ORDER BY NOMBRE")
        '           
        '        Catch ex As Exception
        '        End Try
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cmbcolonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcolonia.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


    'Private Sub cmbcolonia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcolonia.KeyPress
    '    DespliegaCombo(cmbcolonia, e)
    'End Sub

    Private Sub cmbcolonia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbcolonia.SelectedIndexChanged
        If Not IsNothing(cmbcolonia.SelectedValue) AndAlso Not IsNothing(Cmbcomunidad.SelectedValue) Then
            Try

                txtcp.Text = obtenerCampo("SELECT CP FROM colonia WHERE ID_COLONIA='" & cmbcolonia.SelectedValue.ToString & "'", "CP")

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If TxtCostoFacti.Value = 0 AndAlso TxtCostoFacti.Value = Nothing Then
            MessageBoxEx.Show("Falta introducir el costo de la factibilidad", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            TxtCostoFacti.Select()
            Exit Sub
        End If

        If txtref.Text = "" Then
            MessageBoxEx.Show("Falta especificar la referencia de la ubicacion del predio", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = Referencias
            txtref.Select()
            Exit Sub
        End If

        If CmbEstPredio.SelectedIndex.ToString = "" Then
            MessageBoxEx.Show("Falta especificar el estado del predio", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            CmbEstPredio.Select()
            Exit Sub
        End If

        If txtnumext.Text = "" Then
            MessageBoxEx.Show("Falta especificar el numero exterior de la solicitud.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            txtnumext.Select()
            Exit Sub
        End If

        If cmbcontrato.Text = "" Then
            MessageBoxEx.Show("Falta especificar tipo de contrato.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbcontrato.Select()
            Exit Sub
        End If

        If txtpropietario.Text = "" Then
            MessageBoxEx.Show("Falta especificar propietario.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            txtpropietario.Select()
            Exit Sub
        End If

        If Cmbmunicipio.Text = "" Then
            MessageBoxEx.Show("Falta especificar  municipio ", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbmunicipio.Select()
            Exit Sub
        End If
        If Cmbcomunidad.Text = "" Then
            MessageBoxEx.Show("Falta especificar comunidad", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbcomunidad.Select()
            Exit Sub
        End If

        If cmbcolonia.Text = "" Then
            MessageBoxEx.Show("Falta especificar colonia", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbcolonia.Select()
            Exit Sub
        End If

        If Cmbsector.Text = "" Then
            MessageBoxEx.Show("Falta especificar sector.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            Cmbsector.Select()
            Exit Sub
        End If
        Dim CALLE As String = "XXX"

        If My.Settings.CombodeCalles = "SI" Then
            If CmbCalle.SelectedIndex = -1 Then
                MessageBoxEx.Show("Falta especificar la calle principal", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tabsolicitud.SelectedTab = TabItem3
                CmbCalle.Select()

                Exit Sub
            Else
                CALLE = CmbCalle.SelectedValue
            End If
        Else
            If txtDomicilio.Text = "" Then
                MessageBoxEx.Show("Falta introducir el Domicilio", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tabsolicitud.SelectedTab = TabItem3
                txtDomicilio.Select()

                Exit Sub
            End If
        End If



            'If UbiCroquis = 0 Then
            'MessageBoxEx.Show("Falta especificar la ubicacion del predio en el croquis.", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Tabsolicitud.SelectedTab = Referencias
            ' Tab1.Select()
            ' Exit Sub
            'End If

            Try
            If CmbEstPredio.SelectedItem.ToString = "" Then
                MessageBoxEx.Show("Establezca el estado del predio, por favor", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Tabsolicitud.SelectedTab = TabItem3
                CmbEstPredio.Select()
                Exit Sub
            End If
        Catch err As Exception
            MessageBoxEx.Show("Establezca el estado del predio, por favor", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            CmbEstPredio.Select()
            Exit Sub
        End Try

        If cmbtipouso.Text = "" Then
            MessageBoxEx.Show("Establezca el tipo de uso, por favor", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tabsolicitud.SelectedTab = TabItem3
            cmbtipouso.Select()
            Exit Sub
        End If


        Sector = Cmbsector.SelectedValue.ToString  'obtenerCampo("select clavesec from sectores where descripcion = '" & Cmbsector.Text & "'", "clavesec")
        Dim Puso As String = cmbtipouso.SelectedValue.ToString ' obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion = '" & cmbtipouso.Text & "'", "id_tipo_usuario")
        Dim Calle1 As String, Calle2 As String, Calle3 As String, Calle4 As String, Calle5 As String, nMuni As Int16
        Dim tel As String, tel1 As String, tel2 As String

        If TxtTel.Text = "" Then
            tel = "''"
        Else
            tel = "'" & TxtTel.Text & "'"
        End If

        If TxtTelefono2.Text = "" Then
            tel1 = "''"
        Else
            tel1 = "'" & TxtTel.Text & "'"
        End If

        If TxtTelefono3.Text = "" Then
            tel2 = "''"
        Else
            tel2 = "'" & TxtTel.Text & "'"
        End If




        If CMBCALLE1.SelectedIndex > -1 Then
            Calle1 = CMBCALLE1.SelectedValue.ToString
        Else
            Calle1 = ""
        End If
        If CMBCALLE2.SelectedIndex > -1 Then
            Calle2 = CMBCALLE2.SelectedValue.ToString
        Else
            Calle2 = ""
        End If
        If CMBCALLE3.SelectedIndex > -1 Then
            Calle3 = CMBCALLE3.SelectedValue.ToString
        Else
            Calle3 = ""
        End If
        If CMBCALLE4.SelectedIndex > -1 Then
            Calle4 = CMBCALLE4.SelectedValue.ToString
        Else
            Calle4 = ""
        End If
        If CMBCALLE5.SelectedIndex > -1 Then
            Calle5 = CMBCALLE5.SelectedValue.ToString
        Else
            Calle5 = ""
        End If

        Comunidad = Cmbcomunidad.SelectedValue.ToString
        Colonia = cmbcolonia.SelectedValue.ToString
        nMuni = Cmbmunicipio.SelectedValue.ToString

        Dim predial As String, Crede As String, consdele As String, croqloc As String, pagfac As String
        If ChkPredial1.Checked Then predial = "s" Else predial = "n"
        If chkcrede.Checked Then Crede = "s" Else Crede = "n"
        If chconsdele.Checked Then consdele = "s" Else consdele = "n"
        If chkCroqLoc.Checked Then croqloc = "s" Else croqloc = "n"
        If chkPagFac.Checked Then pagfac = "s" Else pagfac = "n"

        If Nuevo = True Then
            Try
                txtclave.Text = Val(obtenerCampo("select nsolicitud as maximo from empresa", "maximo")) + 1
                Ejecucion("insert into solicitud(numero,fechasolicitud,seiden,solispor,nombre,id_colonia,id_comunidad,id_calle,nmunicipio,telefono,cp,rfc,observa,entrecalle1,entrecalle2,entrecalle3,entrecalle4,entrecalle5,parentesco,sector,numext,numint,referencias,contratode,usosolicitado,estpredio,compromiso,coppred,copcred,constdel, croqloc,pagfac, ubicroquis, telefono2, telefono3, montofactibilidad,Clave_predial,Domicilio)" &
                                     " values(" & Val(txtclave.Text) & ",'" & UnixDateFormat(dtfsolicitud.Value) & "','" & txtidentificacion.Text & "','" & txtsolicitado.Text & "','" & txtpropietario.Text & "','" & Colonia & "','" & Comunidad & "','" & CALLE & "'," & nMuni & ",'" & TxtTel.Text & "','" & txtcp.Text & "','" & txtrfc.Text & "','" & txtobservaciones.Text & "','" & Calle1 & "','" & Calle2 & "','" & Calle3 & "','" & Calle4 & "','" & Calle5 & "',""" & txtparentesco.Text & """,'" & Sector & "',""" & txtnumext.Text & """,""" & txtnumint.Text & """,""" & txtref.Text & """,'" & cmbcontrato.SelectedItem & "','" & Puso & "',""" & CmbEstPredio.SelectedItem.ToString & """,'" & UnixDateFormat(dtComp.Value) & "','" & predial & "','" & Crede & "','" & consdele & "','" & croqloc & "','" & pagfac & "', " & UbiCroquis & ", '" & TxtTelefono2.Text & "','" & TxtTelefono3.Text & "', '" & TxtCostoFacti.Text & "', '" & txtcatastral.Text & "','" & txtDomicilio.Text & "')")

                Ejecucion("update empresa set nsolicitud = '" & txtclave.Text & "'")

                lblMen.Text = "<b><font size='+6'><i>NUEVA SOLICITUD " & txtclave.Text & " </i></font></b>"

                Clave = txtclave.Text
                MessageBoxEx.Show("Datos guardados satisfactoriamente", "Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmdImp.Enabled = True
                cmdImp.Visible = True

                Nuevo = False
            Catch Ex As Exception
                MessageBoxEx.Show(Ex.Message())
                MessageBoxEx.Show("Los datos no han sido guardados", "Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End Try
        Else
            Try
                Ejecucion("update solicitud set fechasolicitud = '" & UnixDateFormat(dtfsolicitud.Value) & "',seiden= '" & txtidentificacion.Text & "',solispor='" & txtsolicitado.Text & "',nombre = '" & txtpropietario.Text & "',id_calle = '" & CALLE & "',id_colonia = '" & Colonia & "',id_comunidad='" & Comunidad & "',nmunicipio =" & nMuni & ",telefono=" & tel & ",cp = '" & txtcp.Text & "',rfc='" & txtrfc.Text & "',observa ='" & txtobservaciones.Text & "',entrecalle1 = '" & Calle1 & "',entrecalle2 = '" & Calle2 & "',entrecalle3 = '" & Calle3 & "',entrecalle4 = '" & Calle4 & "',entrecalle5 = '" & Calle5 & "',parentesco = '" & txtparentesco.Text & "',sector = '" & Sector & "',numext = '" & txtnumext.Text & "',numint = '" & txtnumint.Text & "',referencias ='" & txtref.Text & "',contratode = '" & cmbcontrato.SelectedItem & "',usosolicitado = '" & Puso & "',estpredio ='" & CmbEstPredio.SelectedItem.ToString & "',compromiso = '" & UnixDateFormat(dtComp.Value) & "',coppred = '" & predial & "',copcred = '" & Crede & "',constdel = '" & consdele & "', croqloc = '" & croqloc & "',pagfac = '" & pagfac & "', ubicroquis = " & UbiCroquis & ", telefono2 = " & tel1 & ", telefono3 = " & tel2 & ", montofactibilidad = " & TxtCostoFacti.Text & " where numero = " & Clave & "")
            Catch
                MessageBoxEx.Show("Los datos no fueron actualizados", "Solicitudes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            cmdImp.Visible = True
        End If
        Tabsolicitud.SelectedTab = TabItem3
        TabControlPanel1.Select()
        frmListSoli.Actualizar()
        Me.Text = "Solicitud " & txtclave.Text
        If Not Nuevo AndAlso lblEst.Text <> "PENDIENTE" Then
            BtnOrdenTrabajo.Visible = True
        End If
        BtnAceptar.Visible = False
        rbOp.Refresh()
    End Sub

    Private Sub cmdImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImp.Click
        Dim x As New DlgTipoImprSolicitud
        x.ShowDialog()
        If x.DialogResult = Windows.Forms.DialogResult.OK Then
            If x.RBFactibilidad.Checked = True Then
                Dim frm As New frmReporte(frmReporte.Lista.Factibilidad, "{solicitud1.numero} = " & Val(txtclave.Text) & "", "Calle1, '" & CMBCALLE1.Text & "'", "Calle2, '" & CMBCALLE2.Text & "'", "Calle3, '" & CMBCALLE3.Text & "'", "Calle4, '" & CMBCALLE4.Text & "'", "Calle5, '" & CMBCALLE5.Text & "'")
                'frm.MdiParent = My.Forms.MDIPrincipal
                frm.Show()
                frm.WindowState = FormWindowState.Maximized
            Else
                Dim frm As New frmReporte(frmReporte.Lista.Solicitud, "{solicitud1.numero} = " & Val(txtclave.Text) & "", "Calle1* '" & CMBCALLE1.Text & "'", "Calle2* '" & CMBCALLE2.Text & "'", "Calle3* '" & CMBCALLE3.Text & "'", "Calle4* '" & CMBCALLE4.Text & "'", "Calle5* '" & CMBCALLE5.Text & "'")
                ' frm.MdiParent = My.Forms.MDIPrincipal
                frm.Show()
                frm.WindowState = FormWindowState.Maximized
            End If
        End If
        'Me.Close()
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

#Region "Valida Calles"

#End Region

#Region "Ubicacion Croquis"
    Private Sub croquis(ByVal num As Integer)
        lblcroquis1.BackColor = Color.Transparent
        lblcroquis2.BackColor = Color.Transparent
        lblcroquis3.BackColor = Color.Transparent
        lblcroquis4.BackColor = Color.Transparent
        lblcroquis5.BackColor = Color.Transparent
        lblcroquis6.BackColor = Color.Transparent
        lblcroquis7.BackColor = Color.Transparent
        lblcroquis8.BackColor = Color.Transparent
        lblcroquis9.BackColor = Color.Transparent
        lblcroquis10.BackColor = Color.Transparent
        lblcroquis11.BackColor = Color.Transparent
        lblcroquis12.BackColor = Color.Transparent
        lblcroquis13.BackColor = Color.Transparent
        lblcroquis14.BackColor = Color.Transparent
        lblcroquis15.BackColor = Color.Transparent
        lblcroquis16.BackColor = Color.Transparent
        lblcroquis17.BackColor = Color.Transparent
        lblcroquis18.BackColor = Color.Transparent
        lblcroquis19.BackColor = Color.Transparent
        lblcroquis20.BackColor = Color.Transparent
        lblcroquis21.BackColor = Color.Transparent
        lblcroquis22.BackColor = Color.Transparent
        lblcroquis23.BackColor = Color.Transparent
        lblcroquis24.BackColor = Color.Transparent
        lblcroquis25.BackColor = Color.Transparent
        lblcroquis26.BackColor = Color.Transparent
        lblcroquis27.BackColor = Color.Transparent
        lblcroquis28.BackColor = Color.Transparent
        lblcroquis29.BackColor = Color.Transparent
        lblcroquis30.BackColor = Color.Transparent
        lblcroquis31.BackColor = Color.Transparent
        lblcroquis32.BackColor = Color.Transparent
        Select Case num
            Case 1 : lblcroquis1.BackColor = Color.Yellow
            Case 2 : lblcroquis2.BackColor = Color.Yellow
            Case 3 : lblcroquis3.BackColor = Color.Yellow
            Case 4 : lblcroquis4.BackColor = Color.Yellow
            Case 5 : lblcroquis5.BackColor = Color.Yellow
            Case 6 : lblcroquis6.BackColor = Color.Yellow
            Case 7 : lblcroquis7.BackColor = Color.Yellow
            Case 8 : lblcroquis8.BackColor = Color.Yellow
            Case 9 : lblcroquis9.BackColor = Color.Yellow
            Case 10 : lblcroquis10.BackColor = Color.Yellow
            Case 11 : lblcroquis11.BackColor = Color.Yellow
            Case 12 : lblcroquis12.BackColor = Color.Yellow
            Case 13 : lblcroquis13.BackColor = Color.Yellow
            Case 14 : lblcroquis14.BackColor = Color.Yellow
            Case 15 : lblcroquis15.BackColor = Color.Yellow
            Case 16 : lblcroquis16.BackColor = Color.Yellow
            Case 17 : lblcroquis17.BackColor = Color.Yellow
            Case 18 : lblcroquis18.BackColor = Color.Yellow
            Case 19 : lblcroquis19.BackColor = Color.Yellow
            Case 20 : lblcroquis20.BackColor = Color.Yellow
            Case 21 : lblcroquis21.BackColor = Color.Yellow
            Case 22 : lblcroquis22.BackColor = Color.Yellow
            Case 23 : lblcroquis23.BackColor = Color.Yellow
            Case 24 : lblcroquis24.BackColor = Color.Yellow
            Case 25 : lblcroquis25.BackColor = Color.Yellow
            Case 26 : lblcroquis26.BackColor = Color.Yellow
            Case 27 : lblcroquis27.BackColor = Color.Yellow
            Case 28 : lblcroquis28.BackColor = Color.Yellow
            Case 29 : lblcroquis29.BackColor = Color.Yellow
            Case 30 : lblcroquis30.BackColor = Color.Yellow
            Case 31 : lblcroquis31.BackColor = Color.Yellow
            Case 32 : lblcroquis32.BackColor = Color.Yellow
        End Select
        UbiCroquis = num
    End Sub

    Private Sub lblcroquis1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis1.Click
        croquis(1)
    End Sub

    Private Sub lblcroquis2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis2.Click
        croquis(2)
    End Sub

    Private Sub lblcroquis3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis3.Click
        croquis(3)
    End Sub

    Private Sub lblcroquis4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis4.Click
        croquis(4)
    End Sub

    Private Sub lblcroquis5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis5.Click
        croquis(5)
    End Sub

    Private Sub lblcroquis6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis6.Click
        croquis(6)
    End Sub

    Private Sub lblcroquis7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis7.Click
        croquis(7)
    End Sub

    Private Sub lblcroquis8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis8.Click
        croquis(8)
    End Sub

    Private Sub lblcroquis9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis9.Click
        croquis(9)
    End Sub

    Private Sub lblcroquis10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis10.Click
        croquis(10)
    End Sub

    Private Sub lblcroquis11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis11.Click
        croquis(11)
    End Sub

    Private Sub lblcroquis12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis12.Click
        croquis(12)
    End Sub

    Private Sub lblcroquis13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis13.Click
        croquis(13)
    End Sub

    Private Sub lblcroquis14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis14.Click
        croquis(14)
    End Sub

    Private Sub lblcroquis15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis15.Click
        croquis(15)
    End Sub

    Private Sub lblcroquis16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis16.Click
        croquis(16)
    End Sub

    Private Sub lblcroquis17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis17.Click
        croquis(17)
    End Sub

    Private Sub lblcroquis18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis18.Click
        croquis(18)
    End Sub

    Private Sub lblcroquis19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis19.Click
        croquis(19)
    End Sub

    Private Sub lblcroquis20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis20.Click
        croquis(20)
    End Sub

    Private Sub lblcroquis21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis21.Click
        croquis(21)
    End Sub

    Private Sub lblcroquis22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis22.Click
        croquis(22)
    End Sub

    Private Sub lblcroquis23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis23.Click
        croquis(23)
    End Sub

    Private Sub lblcroquis24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis24.Click
        croquis(24)
    End Sub

    Private Sub lblcroquis25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis25.Click
        croquis(25)
    End Sub

    Private Sub lblcroquis26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis26.Click
        croquis(26)
    End Sub

    Private Sub lblcroquis27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis27.Click
        croquis(27)
    End Sub

    Private Sub lblcroquis28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis28.Click
        croquis(28)
    End Sub

    Private Sub lblcroquis29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis29.Click
        croquis(29)
    End Sub

    Private Sub lblcroquis30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis30.Click
        croquis(30)
    End Sub

    Private Sub lblcroquis31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis31.Click
        croquis(31)
    End Sub

    Private Sub lblcroquis32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcroquis32.Click, Label1.Click
        croquis(32)
    End Sub
#End Region

    Private Sub BtnOrdenTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrdenTrabajo.Click
        Dim folio As Double = 0
        Dim nord As Double = 0
        If txtclave.Text = "" Then
            MessageBoxEx.Show("No puede generar la orden de trabajo para esta solicitud, porque aun no ha sido guardada", "ÓRDENES DE TRABAJO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        nord = obtenerCampoInt("select noorden from solicitud where numero=" & txtclave.Text & "", "noorden")
        If nord > 0 Then
            MessageBoxEx.Show("La solicitud ya tiene la  orden de servicio: " & nord & " y no se podrá realizar otra", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If MessageBoxEx.Show("¿DESEA CREAR LA ORDEN PARA LA FACTIBILIDAD " & txtclave.Text & "?", "ÓRDENES DE TRABAJO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                folio = Val(obtenerCampoInt("select max(folio) as mFolio from ordent", "mFolio")) + 1
            Catch ex As Exception
                folio = 1
            End Try

            Dim Ubi As String = "Sector: " & Cmbsector.Text & " Domicilio: " & txtDomicilio.Text & " " & txtnumint.Text & " " & txtnumext.Text & " " & cmbcolonia.Text & " " & Cmbcomunidad.Text
            'Dim CodCve As String = obtenerCampo("Select cod_Cve from cveque where Descripcion = 'ESTUDIO DE FACTIBILIDAD'", "Cod_cve")
            Dim Quej As IDataReader = ConsultaSql("Select * from cveque where cod_Cve ='" & ConcepFac & "'").ExecuteReader
            If Quej.Read() Then
                Ejecucion("insert into ordent(status,folio,fec_ord,hora,id_comunidad,tel,cod_cve,cod_dir" &
                          ",indic,urge,nombre,fec_com,cuenta,ubicacion,cod_res,cel,fuente,COD_ALT) values(1," & folio & ",'" & UnixDateFormat(Now) & "','" & TimeString & "','" & Cmbcomunidad.SelectedValue.ToString &
                          "','" & TxtTel.Text & "','" & ConcepFac & "','" & Quej("cod_dir") & "','ESTUDIO DE FACTIBILIDAD NO " & txtclave.Text & "' ,FALSE ,'" & txtpropietario.Text & "','" & UnixDateFormat(dtComp.Value) & "',0" &
                          ",'" & Ubi & "','" & Quej("cod_res") & "','" & TxtTelefono2.Text & "','5','" & NumUser & "')")

                Ejecucion("update solicitud set noorden=" & folio & " where numero=" & txtclave.Text & "")


            Else
                MessageBoxEx.Show("NO SE ENCONTRÓ EL CONCEPTO DE LA QUEJA NÚMERO=" & ConcepFac & "", "SOLICITUDES", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            MessageBoxEx.Show("Su orden de trabajo es la numero " & folio, "Orden de Trabajo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub Deshabilitar()
        txtclave.Enabled = False
        dtfsolicitud.Enabled = False
        txtidentificacion.Enabled = False
        txtsolicitado.Enabled = False
        txtpropietario.Enabled = False
        Cmbmunicipio.Enabled = False
        Cmbcomunidad.Enabled = False
        cmbcolonia.Enabled = False
        If My.Settings.CombodeCalles = "SI" Then
            CmbCalle.Enabled = False
        Else
            txtDomicilio.Text = False
        End If

        '
        TxtTel.Enabled = False
        txtcp.Enabled = False
        txtrfc.Enabled = False
        cmbcontrato.Enabled = False

        txtobservaciones.Enabled = False
        CMBCALLE1.Enabled = False
        CMBCALLE2.Enabled = False
        CMBCALLE3.Enabled = False
        CMBCALLE4.Enabled = False
        CMBCALLE5.Enabled = False
        txtparentesco.Enabled = False
        Cmbsector.Enabled = False
        txtnumext.Enabled = False
        txtnumint.Enabled = False
        txtref.Enabled = False
        cmbtipouso.Enabled = False
        CmbEstPredio.Enabled = False
        dtComp.Enabled = False
        ChkPredial1.Enabled = False
        chkcrede.Enabled = False
        chconsdele.Enabled = False
        chkCroqLoc.Enabled = False
        chkPagFac.Enabled = False
        TxtCostoFacti.Enabled = False
        BtnAceptar.Enabled = False
        BtnOrdenTrabajo.Enabled = False
        TxtTelefono2.Enabled = False
        TxtTelefono3.Enabled = False
        BtnOrdenTrabajo.Enabled = False
    End Sub

    Private Sub Cmbsector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbsector.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    'Private Sub Cmbsector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmbsector.KeyPress
    '    DespliegaCombo(Cmbsector, e)
    'End Sub

    Private Sub Cmbsector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbsector.SelectedIndexChanged
        If Not IsNothing(Cmbsector.SelectedValue) Then
            Sector = Cmbsector.SelectedValue.ToString
        End If
    End Sub

    Private Sub CMBCALLE3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE3.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    'Private Sub CmbEstPredio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstPredio.KeyPress
    '    DespliegaCombo(CmbEstPredio, e)
    'End Sub
    'Private Sub cmbcontrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcontrato.KeyPress
    '    DespliegaCombo(cmbcontrato, e)
    'End Sub

    'Private Sub cmbtipouso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipouso.KeyPress
    '    DespliegaCombo(cmbtipouso, e)
    'End Sub

    'Private Sub CMBCALLE3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE3.KeyPress
    '    DespliegaCombo(CMBCALLE3, e)
    'End Sub
    Private Sub CMBCALLE3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCALLE3.SelectedIndexChanged
        'If CMBCALLE3.Text = "" Then Exit Sub
        'If CMBCALLE3.Text = CMBCALLE.Text Or CMBCALLE3.Text = CMBCALLE1.Text Or CMBCALLE3.Text = CMBCALLE2.Text Or CMBCALLE3.Text = CMBCALLE4.Text Or CMBCALLE3.Text = CMBCALLE5.Text Then
        '    MessageBoxEx.Show("Existen dos calles con el mismo nombre", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub CMBCALLE5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE5.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    'Private Sub CMBCALLE5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE5.KeyPress
    '    DespliegaCombo(CMBCALLE5, e)
    'End Sub
    Private Sub CMBCALLE5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCALLE5.SelectedIndexChanged
        'If CMBCALLE5.Text = "" Then Exit Sub
        'If CMBCALLE5.Text = CMBCALLE.Text Or CMBCALLE5.Text = CMBCALLE1.Text Or CMBCALLE5.Text = CMBCALLE2.Text Or CMBCALLE5.Text = CMBCALLE3.Text Or CMBCALLE5.Text = CMBCALLE4.Text Then
        '    MessageBoxEx.Show("Existen dos calles con el mismo nombre", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub CMBCALLE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE1.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    'Private Sub CMBCALLE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE1.KeyPress
    '    DespliegaCombo(CMBCALLE1, e)
    'End Sub
    Private Sub CMBCALLE1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCALLE1.SelectedIndexChanged
        'If CMBCALLE1.Text = "" Then Exit Sub
        'If CMBCALLE1.Text = CMBCALLE.Text Or CMBCALLE1.Text = CMBCALLE2.Text Or CMBCALLE1.Text = CMBCALLE3.Text Or CMBCALLE1.Text = CMBCALLE4.Text Or CMBCALLE1.Text = CMBCALLE5.Text Then
        '    MessageBoxEx.Show("Existen dos calles con el mismo nombre", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub

    Private Sub CMBCALLE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE2.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    'Private Sub CMBCALLE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE2.KeyPress
    '    DespliegaCombo(CMBCALLE2, e)
    'End Sub
    Private Sub CMBCALLE2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCALLE2.SelectedIndexChanged
        'If CMBCALLE2.Text = "" Then Exit Sub
        'If CMBCALLE2.Text = CMBCALLE.Text Or CMBCALLE2.Text = CMBCALLE1.Text Or CMBCALLE2.Text = CMBCALLE3.Text Or CMBCALLE2.Text = CMBCALLE4.Text Or CMBCALLE2.Text = CMBCALLE5.Text Then
        '    MessageBoxEx.Show("Existen dos calles con el mismo nombre", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub CMBCALLE4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE4.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    'Private Sub CMBCALLE4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMBCALLE4.KeyPress
    '    DespliegaCombo(CMBCALLE4, e)
    'End Sub
    Private Sub CMBCALLE4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBCALLE4.SelectedIndexChanged
        'If CMBCALLE4.Text = "" Then Exit Sub
        'If CMBCALLE4.Text = CMBCALLE.Text Or CMBCALLE4.Text = CMBCALLE1.Text Or CMBCALLE4.Text = CMBCALLE2.Text Or CMBCALLE4.Text = CMBCALLE3.Text Or CMBCALLE4.Text = CMBCALLE5.Text Then
        '    MessageBoxEx.Show("Existen dos calles con el mismo nombre", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub ChkPredial1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkPredial1.GotFocus
        ChkPredial1.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub
    Private Sub ChkPredial1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkPredial1.LostFocus
        ChkPredial1.BackColor = Color.Transparent
    End Sub
    Private Sub chkcrede_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcrede.GotFocus
        chkcrede.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub
    Private Sub chkcrede_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcrede.LostFocus
        chkcrede.BackColor = Color.Transparent
    End Sub
    Private Sub chconsdele_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chconsdele.GotFocus
        chconsdele.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub
    Private Sub chconsdele_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chconsdele.LostFocus
        chconsdele.BackColor = Color.Transparent
    End Sub
    Private Sub chkCroqLoc_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCroqLoc.GotFocus
        chkCroqLoc.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub
    Private Sub chkCroqLoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkCroqLoc.LostFocus
        chkCroqLoc.BackColor = Color.Transparent
    End Sub
    Private Sub chkPagFac_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPagFac.GotFocus
        chkPagFac.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 136)
    End Sub
    Private Sub chkPagFac_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPagFac.LostFocus
        chkPagFac.BackColor = Color.Transparent
    End Sub
    Private Sub dtfsolicitud_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtfsolicitud.ValueChanged
        If Modificar OrElse Nuevo Then
            dtComp.Value = DiasHabiles(dtfsolicitud.Value, 7)
        End If
    End Sub
    Private Sub dtComp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtComp.ValueChanged
        If DateDiff(DateInterval.Day, dtfsolicitud.Value, dtComp.Value) < 0 Then
            MessageBoxEx.Show("Está estableciendo una fecha de compromiso menor a la fecha de alta, verifique por favor", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtComp.Value = DiasHabiles(dtfsolicitud.Value, 7)
        End If
    End Sub
    Private Sub Tabsolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabsolicitud.Click
        txtref.Select()
    End Sub
    Private Sub cmbcontrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbcontrato.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub cmbtipouso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbtipouso.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub CmbEstPredio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbEstPredio.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub


End Class