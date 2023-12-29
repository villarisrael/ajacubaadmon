Imports System.Math

Public Class FrmCaptura_Lectura_Ind

    Public modo As String = "Insertar"
    Dim lecturaActualAntesModif As String
    Dim lecturaAnteriorAntesModif As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        txtcuentaanterior.Visible = False

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub loadLecturas()
        Dim cuenta As String = txtcuenta.Text
        Try
            'Dim x As base = New base()
            If txtubicacion.Text <> "" Then
                cuenta = obtenerCampo("select cuenta from usuario where ubicacion='" & txtubicacion.Text & "'", "cuenta")
                If cuenta <> "0" Then
                    txtcuenta.Text = cuenta
                End If
            End If

            If txtcuentaanterior.Text <> "" Then
                cuenta = obtenerCampo("select cuenta from usuario where cuentaAnterior='" & txtcuentaanterior.Text & "'", "cuenta")
                If cuenta <> "0" Then
                    txtcuenta.Text = cuenta
                End If
            End If

            If txtcuenta.Text <> "" Then
                llenaGrid(DTGLecturas, "SELECT mes as MES , an_per as PERIODO, lectant as LECT_ANT, lectura as LECT_ACT, consumo as CONSUMO_M3 , consumocobrado as 'Consumo_cobrado_M3',Monto as Monto_$, Montocobrado as Monto_Cobrado_$,case when pagado=1 then 'SI' else 'NO' end As PAGADO,cuenta as cuenta FROM lecturas where cuenta=" & txtcuenta.Text & " order by valornummes(mes,an_per) ")

            End If



            DTGLecturas.Columns(2).Width = 50
            DTGLecturas.Columns(3).Width = 50
            DTGLecturas.Columns(4).Width = 100
            DTGLecturas.Columns(5).Width = 120
            DTGLecturas.Columns(6).Width = 120
            DTGLecturas.Columns(7).Width = 120
            DTGLecturas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DTGLecturas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DTGLecturas.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DTGLecturas.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            lblNombreLoad.Text = "NOMBRE: " & obtenerCampo("Select Nombre from usuario where cuenta=" & txtcuenta.Text & "", "Nombre")

            txtLecAnt.Text = Convert.ToString(DTGLecturas.Item("LECT_ACT", DTGLecturas.Rows.Count - 1).Value)
            ' x.conexion.Dispose()
        Catch ex As Exception
            MsgBox("No Existen Lecturas")
            lblNombreLoad.ResetText()
        End Try
    End Sub
    Public Sub clearCampos()
        CmbMes.ResetText()
        txtAper.Text = ""
        txtLecAct.Text = ""
        txtConsumo.Text = ""
        txtConsumoCobrado.Text = ""
        txtcuenta.Text = ""
        txtcuenta.Enabled = True
        txtLecAnt.Text = ""
        txtLecAnt.Enabled = False
        DTGLecturas.DataSource = ""
        btnGuardar.Enabled = False
        btnCambioMed.Enabled = False
        CmbHidrometro.ResetText()
        CmbMedicion.ResetText()
        CmbPadron.ResetText()
        txtLecAct.Enabled = False
        txtLecAct.ResetText()
        lblNombreLoad.ResetText()
        txtMesE.ResetText()
        txtAnPerE.ResetText()

    End Sub


    Private Sub txtcuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcuenta.KeyDown
        If e.KeyCode = 13 Then
            Try
                loadLecturas()
                txtcuenta.Enabled = False
                btnCambioMed.Enabled = True
                btnGuardar.Enabled = True
                txtLecAct.Enabled = True
            Catch ex As Exception
                MsgBox("No Existen Registros... Verifique la Cuenta. ")
            End Try

            '''''''''''''
            '''Obtener las lecturas antes de modificarse

        End If
    End Sub

    Private Sub btnbuscacliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscacliente.Click
        Try
            loadLecturas()
            txtcuenta.Enabled = False
            btnCambioMed.Enabled = True
            btnGuardar.Enabled = True
            txtLecAct.Enabled = True

        Catch ex As Exception
            MsgBox("No Existen Registros... Verifique la Cuenta. ")
        End Try
    End Sub

    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If (txtLecAnt.Enabled = True And CmbHidrometro.Text = "" And CmbMedicion.Text = "" And CmbPadron.Text = "") Then
            MessageBox.Show("El Cambio de Medidor, Solicita una Situacion")
            CmbPadron.Focus()
            CmbPadron.BackColor = Color.LightYellow
            CmbMedicion.BackColor = Color.LightYellow
            CmbHidrometro.BackColor = Color.LightYellow



        ElseIf CmbMes.Text = "" Then
            MessageBox.Show("El Campo Mes es Obligatorio...")
            CmbMes.Focus()
            CmbMes.BackColor = Color.YellowGreen

        ElseIf txtAper.Text = "" Then
            MessageBox.Show("El Campo Año es Obligatorio...")
            txtAper.Focus()
            txtAper.BackColor = Color.LightYellow

        Else

            If txtLecAct.Text = "" Then
                txtLecAct.Text = "0"
            End If

            If txtConsumo.Text = "" Then
                txtConsumo.Text = "0"
            End If

            If txtConsumoCobrado.Text = "" Then
                txtConsumoCobrado.Text = "0"
            End If

            Try

                If txtLecAnt.Text > "0" And txtLecAct.Text = "0" And (CmbHidrometro.SelectedIndex >= 0 Or CmbMedicion.SelectedIndex >= 0 Or CmbPadron.SelectedIndex >= 0) Then
                    txtLecAct.Text = txtLecAnt.Text
                End If


                Dim xcc As Odbc.OdbcCommand
                xcc = ConsultaSql("select cuenta, mes, an_per from lecturas where cuenta='" + txtcuenta.Text + "' and mes='" + CmbMes.Text + "' and an_per='" + txtAper.Text + "'")
                Dim datos As IDataReader
                datos = xcc.ExecuteReader()



                If datos.Read Then


                    MessageBox.Show("La Lectura que Desea Capturar ya Existe... /n Si Desea Ajustarla Valla al Módulo de Ajustes.")
                    'clearCampos()


                Else


                    Dim tarifa As String
                    Dim memoria As String
                    Dim fechaDeuda As String


                    tarifa = obtenerCampo(" select tarifa from usuario where cuenta=" & txtcuenta.Text & "", "tarifa")
                    memoria = obtenerCampo(" select memoria from cuotas where id_tarifa=" & tarifa & "", "memoria")

                    fechaDeuda = DateTime.Parse(obtenerCampo("Select DEUDAFEC from USUARIO where CUENTA = '" & txtcuenta.Text & "'", "DEUDAFEC"))


                    If memoria = 0 Then


                        Ejecucion("insert into lecturas (cuenta, mes, an_per, lectura, lectant, consumo, consumocobrado, sit_med, sit_pad, sit_hid,monto,tarifa) values(" + txtcuenta.Text + ", '" + CmbMes.Text + "', " + txtAper.Text + ", " + txtLecAct.Text + ", " + txtLecAnt.Text + ", " + txtConsumo.Text + ", " + txtConsumoCobrado.Text + ", '" + CmbMedicion.SelectedValue + "', '" + CmbPadron.SelectedValue + "', '" + CmbHidrometro.SelectedValue + "', ConsumoMedidossin(" & txtConsumoCobrado.Text & ",'" & tarifa & "'," & txtAper.Text & "),'" & tarifa & "');")


                        'Si el campo Deuda_Fec de la tabla usuario es mayor, la lectura se da por pagada

                        Dim dateLectura As Date = DateTime.Parse(Now.Day & "-" & NumeroMes(CmbMes.Text) & "-" & txtAper.Text)

                        If (DateTime.Compare(fechaDeuda, dateLectura) > 0) Then

                            MessageBox.Show("La Fecha Deuda es mayor")

                            Ejecucion("UPDATE lecturas l, usuario SET pagado = '1', adelant = '1' WHERE usuario.cuenta=l.cuenta and l.cuenta='" & txtcuenta.Text & "' and mes='" & CmbMes.Text & "' and an_per='" & txtAper.Text & "';")
                            MessageBox.Show("Actualizacion Completa... ")

                        End If

                    Else


                        Ejecucion("insert into lecturas (cuenta, mes, an_per, lectura, lectant, consumo, consumocobrado, sit_med, sit_pad, sit_hid,monto,montocobrado,tarifa) values(" + txtcuenta.Text + ", '" + CmbMes.Text + "', " + txtAper.Text + ", " + txtLecAct.Text + ", " + txtLecAnt.Text + ", " + txtConsumo.Text + ", " + txtConsumoCobrado.Text + ", '" + CmbMedicion.SelectedValue + "', '" + CmbPadron.SelectedValue + "', '" + CmbHidrometro.SelectedValue + "', ConsumoMedidos(" & txtConsumoCobrado.Text & ",'" & tarifa & "'," & txtAper.Text & "), ConsumoMedidos(" & txtConsumoCobrado.Text & ",'" & tarifa & "'," & txtAper.Text & "),'" & tarifa & "'));")


                        'Si el campo Deuda_Fec de la tabla usuario es mayor, la lectura se da por pagada

                        Dim dateLectura As Date = DateTime.Parse(Now.Day & "-" & NumeroMes(CmbMes.Text) & "-" & txtAper.Text)

                        If (DateTime.Compare(fechaDeuda, dateLectura) > 0) Then

                            MessageBox.Show("La Fecha Deuda es mayor")

                            Ejecucion("UPDATE lecturas l, usuario SET pagado = '1', adelant = '1' WHERE usuario.cuenta=l.cuenta and l.cuenta='" & txtcuenta.Text & "' and mes='" & CmbMes.Text & "' and an_per='" & txtAper.Text & "';")
                            MessageBox.Show("Actualizacion Completa... ")

                        End If

                    End If

                    MessageBox.Show("Lectura Agregada... ")
                    loadLecturas()
                    ' datos.Dispose()
                End If

            Catch ex As Exception
                MessageBox.Show("El Registro no Pudo ser Almacenado... ")
            End Try

        End If
    End Sub

    Private Sub FrmCaptura_Lectura_Ind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If modo = "Agregar" Then
            GrpAccionesA.Visible = True
            GrpAccionesM.Visible = False
            GrpAccionesE.Visible = False

        End If

        If modo = "Modificar" Then
            GrpAccionesA.Visible = False
            GrpAccionesM.Visible = True
            GrpAccionesE.Visible = False

        End If

        If modo = "Eliminar" Then
            GrpAccionesA.Visible = False
            GrpAccionesM.Visible = False
            GrpAccionesE.Visible = True

        End If

        llenarCombo(CmbPadron, "Select Clave, Situacion from situacion where Tipo='Padrón';")
        llenarCombo(CmbMedicion, "Select Clave, Situacion from situacion where Tipo='Medición';")
        llenarCombo(CmbHidrometro, "Select Clave, Situacion from situacion where Tipo='Hidrómetro';")

        txtAper.Text = Date.Now.ToString("yyyy")
        txtcuenta.Focus()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuev.Click
        clearCampos()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambioMed.Click
        txtLecAnt.Enabled = True
        txtLecAnt.Focus()
        If (txtLecAct.Text = "") Then
            txtLecAct.Text = "0"
        End If

    End Sub

    Private Sub txtLecAct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecAct.TextChanged
        Try
            If (txtLecAnt.Text = "") Then
                txtLecAnt.Text = "0"
            End If

            txtConsumo.Text = Math.Abs((txtLecAnt.Text) - (txtLecAct.Text))
            txtConsumoCobrado.Text = Math.Abs((txtLecAnt.Text) - (txtLecAct.Text))
        Catch ex As Exception
            'MsgBox("Ingrese un Numero Valido", MsgBoxStyle.Exclamation, "Advertencia....!!!")
        End Try
    End Sub

    Private Sub txtLecAnt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLecAnt.TextChanged
        Try
            If (txtLecAnt.Text = "") Then
                txtLecAnt.Text = "0"
            End If
            txtConsumo.Text = Math.Abs((txtLecAnt.Text) - (txtLecAct.Text))
            txtConsumoCobrado.Text = Math.Abs((txtLecAnt.Text) - (txtLecAct.Text))
        Catch ex As Exception
            'MsgBox("Ingrese un Numero Valido", MsgBoxStyle.Exclamation, "Advertencia....!!!")
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If txtAnPerE.Text <> "" And txtMesE.Text <> "" Then

            If MsgBox("Estas Seguro que Desea Eliminar la Lectura? ", MsgBoxStyle.YesNo, "ALERTA") = MsgBoxResult.Yes Then
                Try

                    Ejecucion("delete from lecturas where Cuenta=" + txtcuenta.Text + " and mes='" + txtMesE.Text + "' and an_per=" + txtAnPerE.Text + ";")

                    'Registrar el movimiento en la bitacora
                    Dim nombre_Host As String = Net.Dns.GetHostName()
                    Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
                    Dim direccion_Ip As String = este_Host.AddressList(0).ToString


                    Try
                        Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','LECTURA ELIMINADA'," & txtcuenta.Text & "," & NumUser & ",' LECTURA ELIMINADA: " & txtMesE.Text & "  AÑO: " & txtAper.Text & "','" & direccion_Ip & "','CORRECCIÓN AL CONTRATO')")

                        ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'ButtonX1.Enabled = True

                        'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                        'BtnAceptar.Enabled = False 
                    Catch ex As Exception
                        MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
                    End Try

                    MessageBox.Show("Registro Eliminado... ")
                    loadLecturas()
                    txtAnPerE.Text = ""
                    txtMesE.Text = ""



                Catch ex As Exception
                    MessageBox.Show("Error al Eliminar el Registro...")
                End Try
            End If
        Else
            MessageBox.Show("Seleccione un Registro...")
        End If

    End Sub

    Private Sub RadGroupBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrpAccionesA.Click

    End Sub

    Private Sub DTGLecturas_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGLecturas.CellDoubleClick
        Try
            txtMesE.Text = DTGLecturas.Item("MES", DTGLecturas.CurrentRow.Index).Value
            txtAnPerE.Text = DTGLecturas.Item("PERIODO", DTGLecturas.CurrentRow.Index).Value
            txtAper.Text = txtAnPerE.Text

            ' GRUPO MODIFICAR 
            txtMesM.Text = DTGLecturas.Item("MES", DTGLecturas.CurrentRow.Index).Value
            txtAperM.Text = DTGLecturas.Item("PERIODO", DTGLecturas.CurrentRow.Index).Value
            txtLecAntM.Text = DTGLecturas.Item("LECT_ANT", DTGLecturas.CurrentRow.Index).Value
            txtLecActM.Text = DTGLecturas.Item("LECT_ACT", DTGLecturas.CurrentRow.Index).Value
            txtConsumoM.Text = DTGLecturas.Item("CONSUMO_M3", DTGLecturas.CurrentRow.Index).Value
            txtConsumoCM.Text = DTGLecturas.Item("CONSUMO_COBRADO_M3", DTGLecturas.CurrentRow.Index).Value

            'Grupo AGREGAR
            CmbMes.Text = DTGLecturas.Item("MES", DTGLecturas.CurrentRow.Index).Value
            txtAper.Text = DTGLecturas.Item("PERIODO", DTGLecturas.CurrentRow.Index).Value


            '''''Obtener las lecturas antes de modificar e insertar a la bitacora
            lecturaActualAntesModif = txtLecActM.Text
            lecturaAnteriorAntesModif = txtLecAntM.Text

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Close()

    End Sub

    Private Sub btnActualizar_Click(sender As System.Object, e As System.EventArgs) Handles btnActualizar.Click
        If txtMesM.Text <> "" Then
            If txtAper.Text <> "" Then

                ' Dim validaCambioTarifa As Boolean = CalcularDiasModificacionLectura(txtcuenta.Text, txtMesM.Text, txtAperM.Text)

                ' If validaCambioTarifa = True Then


                If MsgBox("Estas Seguro que Desea Actualizar el Registro? ", MsgBoxStyle.YesNo, "ALERTA") = MsgBoxResult.Yes Then
                        Try
                            Dim memoria As String
                            Dim tarifa As String

                            tarifa = obtenerCampo(" select tarifa from usuario where cuenta=" & txtcuenta.Text & "", "tarifa")
                            memoria = obtenerCampo(" select memoria from cuotas where id_tarifa=" & tarifa & "", "memoria")

                            If memoria = 0 Then

                            Ejecucion("UPDATE lecturas l, usuario SET lectura=" & txtLecActM.Text & ", l.LectAnt=" + txtLecAntM.Text + ", l.consumo=" + txtConsumoM.Text + ", consumocobrado=" + txtConsumoCM.Text + ", monto=ConsumoMedidos(" + txtConsumoCM.Text + ",usuario.tarifa," & txtAper.Text & "), l.Modificado = '1', l.FECHAMODIFICADO = " & UnixDateFormat(Now.Date, True, False) & " WHERE usuario.cuenta=l.cuenta and l.cuenta=" + txtcuenta.Text + " and mes='" + txtMesM.Text + "' and an_per=" + txtAperM.Text + ";")


                            'Registrar el movimiento en la bitacora
                            Dim nombre_Host As String = Net.Dns.GetHostName()
                                Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
                                Dim direccion_Ip As String = este_Host.AddressList(0).ToString


                                Try
                                    Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','MODIFICACIÓN DE LECTURA '," & txtcuenta.Text & "," & NumUser & ",' MES MODIFICADO: " & CmbMes.Text & " AÑO: " & txtAnPerE.Text & " | ANTES DE MODIFICAR: LECTURA ANTERIOR: " & lecturaAnteriorAntesModif & ", LECTURA ACTUAL: " & lecturaActualAntesModif & " | DESPUES DE MODIFICAR: LECTURA ANTERIOR: " & txtLecAntM.Text & ", LECTURA ACTUAL: " & txtLecAntM.Text & "','" & direccion_Ip & "','CORRECCIÓN AL CONTRATO')")

                                    ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    'ButtonX1.Enabled = True

                                    'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                                    'BtnAceptar.Enabled = False
                                Catch ex As Exception
                                    MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
                                End Try


                                MessageBox.Show("Actualizacion Completa... ")




                            Else

                            Ejecucion("UPDATE lecturas l, usuario SET lectura=" & txtLecActM.Text & ", l.LectAnt=" + txtLecAntM.Text + ", l.consumo=" + txtConsumoM.Text + ", consumocobrado=" + txtConsumoCM.Text + ", monto=ConsumoMedidos(" + txtConsumoCM.Text + ",usuario.tarifa," & txtAper.Text & "), l.Modificado = '1', l.FECHAMODIFICADO = " & UnixDateFormat(Now.Date, True, False) & " WHERE usuario.cuenta=l.cuenta and l.cuenta=" + txtcuenta.Text + " and mes='" + txtMesM.Text + "' and an_per=" + txtAperM.Text + ";")

                            'Registrar el movimiento en la bitacora
                            Dim nombre_Host As String = Net.Dns.GetHostName()
                                Dim este_Host As Net.IPHostEntry = Net.Dns.GetHostEntry(nombre_Host)
                                Dim direccion_Ip As String = este_Host.AddressList(0).ToString

                                'Registrar los movimientos de cambios de lecturas en la Bitacora para hacer mas transparente al sistema 2022/04/28
                                Try
                                    Ejecucion("insert into bitacora(fecha,hora,evento,cuenta,usuario,concepto,maquina,motivo) values(" & UnixDateFormat(Now.Date, True, False) & ",'" & Now.ToShortTimeString() & "','MODIFICACIÓN DE LECTURA '," & txtcuenta.Text & "," & NumUser & ",' MES MODIFICADO: " & CmbMes.Text & " AÑO: " & txtAnPerE.Text & " | ANTES DE MODIFICAR: LECTURA ANTERIOR: " & lecturaAnteriorAntesModif & ", LECTURA ACTUAL: " & lecturaActualAntesModif & " | DESPUES DE MODIFICAR: LECTURA ANTERIOR: " & txtLecAntM.Text & ", LECTURA ACTUAL: " & txtLecAntM.Text & "','" & direccion_Ip & "','CORRECCIÓN AL CONTRATO')")

                                    ' MessageBoxEx.Show("Registro realizado satisfactoriamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    'ButtonX1.Enabled = True

                                    'frmBusUsuario.filtro(frmBusUsuario._sqlgeneral)
                                    'BtnAceptar.Enabled = False
                                Catch ex As Exception
                                    MessageBox.Show("Ocurrio un error al registar en la bitacora: " & ex.ToString())
                                End Try



                                MessageBox.Show("Actualizacion Completa... ")





                            End If
                            loadLecturas()

                        Catch ex As Exception
                            MessageBox.Show("Error en la Concordancia de Datos " + ex.Message)
                        End Try

                    End If

                '  Else
                '     Dim fechaUltimoCambio As String

                '  fechaUltimoCambio = obtenerCampo($"SELECT FECHAMODIFICADO FROM LECTURAS WHERE CUENTA = {txtcuenta.Text} AND MES = '{txtMesM.Text}' AND AN_PER = {txtAper.Text}", "FECHAMODIFICADO")

                '  MessageBox.Show($"No es posible realizar la módificación de la lectura debido a que ya se realizo un cambio en la lectura recientemente, espera 30 días a partir de la última modificación de la lectura para volver a hacer una modificación. {vbCrLf}Fecha de la última modificación: {fechaUltimoCambio}")

                '   End If

            Else
                MessageBox.Show("Seleccione un Registro...")
            End If
        Else
            MessageBox.Show("Seleccione un Registro...")
        End If
    End Sub

    Private Sub DTGLecturas_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DTGLecturas.KeyDown

        If e.KeyCode = 120 Then        ' F9
            txtMesM.Text = DTGLecturas.Item("MES", DTGLecturas.CurrentRow.Index).Value
            txtAperM.Text = DTGLecturas.Item("PERIODO", DTGLecturas.CurrentRow.Index).Value
            If (DTGLecturas.Item("PAGADO", DTGLecturas.CurrentRow.Index).Value.ToString.ToUpper = "SI") Then

                If MsgBox("Estas Seguro poner como 'NO PAGADO'? ", MsgBoxStyle.YesNo, "ALERTA") = MsgBoxResult.Yes Then
                    Try
                        Ejecucion("UPDATE lecturas SET pagado='0' WHERE cuenta='" + txtcuenta.Text + "' and mes='" + txtMesM.Text + "' and an_per='" + txtAperM.Text + "';")
                        MessageBox.Show("Registro Actualizado a Pagado Completa... ")
                        loadLecturas()
                    Catch ex As Exception
                        MessageBox.Show("Error en la  de Datos")
                    End Try
                End If
            Else

                If MsgBox("Estas Seguro que Desea Dar por 'PAGADO'? ", MsgBoxStyle.YesNo, "ALERTA") = MsgBoxResult.Yes Then
                    Try

                        Ejecucion("UPDATE lecturas SET pagado='1' WHERE cuenta='" + txtcuenta.Text + "' and mes='" + txtMesM.Text + "' and an_per='" + txtAperM.Text + "';")
                        MessageBox.Show("Registro Actualizado a Pagado Completa... ")
                        loadLecturas()
                    Catch ex As Exception
                        MessageBox.Show("Error en la  de Datos")
                    End Try
                End If

            End If
        End If


    End Sub

    Private Sub RadButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles RadButton1.Click
        Close()
    End Sub

    Private Sub RadButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles RadButton2.Click
        Close()

    End Sub

    Private Sub DTGLecturas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTGLecturas.CellContentClick

    End Sub

    Private Sub RadGroupBox3_Click(sender As Object, e As EventArgs) Handles RadGroupBox3.Click

    End Sub

    Private Function CalcularDiasModificacionLectura(ByVal cuentaP As Integer, ByVal lecturaMesP As String, ByVal lecturaAnoP As Integer) As Boolean

        Dim contrato = cuentaP
        Dim mesLectura = lecturaMesP
        Dim periodoLectura = lecturaAnoP
        Dim fechaUltimoCambio As DateTime
        Dim fechaHoy As DateTime
        Dim tieneCambioLectura As Boolean = False

        fechaHoy = DateTime.Today

        Try
            fechaUltimoCambio = obtenerCampo($"SELECT FECHAMODIFICADO FROM LECTURAS WHERE CUENTA = {contrato} AND MES = '{mesLectura}' AND AN_PER = {periodoLectura}", "FECHAMODIFICADO")

            tieneCambioLectura = True

        Catch ex As Exception

            tieneCambioLectura = False

        End Try


        ' Calcular la diferencia en días entre las dos fechas
        Dim diferencia As TimeSpan = fechaHoy.Subtract(fechaUltimoCambio)
        Dim diasDiferencia As Integer = diferencia.Days

        ' Validar la diferencia de días
        If tieneCambioLectura = True Then

            If diasDiferencia >= 30 Then


                Return True

            Else


                Return False

            End If

        Else

            Return True

        End If


    End Function

    Private Sub txtubicacion_KeyUp(sender As Object, e As KeyEventArgs) Handles txtubicacion.KeyUp
        If e.KeyCode = 13 Then
            loadLecturas()
        End If
    End Sub
End Class