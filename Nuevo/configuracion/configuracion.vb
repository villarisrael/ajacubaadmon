Imports DevComponents.DotNetBar

Public Class configuracion
    ' Dim X As New ClassRegistros
    Private Sub lblgenerales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblgenerales.Click
        apaga()
        Me.GroupGeneral.Visible = True
    End Sub

    Public Sub apaga()
        Me.GroupDocumentos.Visible = False
        Me.GroupMedicion.Visible = False
        Me.GroupGeneral.Visible = False
        Me.GroupMedicion.Visible = False
        Me.Panelrequerimientos.Visible = False
        Me.GPCaja.Visible = False
    End Sub

    Private Sub lblcobranza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblcobranza.Click
        apaga()
        Me.GroupDocumentos.Visible = True

        GPCaja.Visible = False
    End Sub

    Private Sub lblmedicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblmedicion.Click

        apaga()
        Me.GroupMedicion.Visible = True
        GPCaja.Visible = False
    End Sub

    Private Sub configuracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As System.Data.IDataReader
        rs = ConsultaSql("Select * from empresa").ExecuteReader
        If rs.Read Then
            ' ************** cobranza  *****************
            TxtPreRequeri.Text = rs("prefijo_requeri")
            NumRequeri.Value = rs("no_requeri")
            TxtSufRequeri.Text = rs("sufijo_Requeri")

            Me.TxtSufConvenio.Text = rs("sufijo_conve")
            Me.NumConvenio.Value = rs("no_conve")
            Me.TxtPreConvenio.Text = rs("prefijo_conve")

            anticipo.Value = rs("porcanticipo")
            minconvenio.Value = rs("minimoconvenio")
            SALARIO.Value = rs("salario")

            txtgas1.Value = rs("primer_requeri")
            txtgas2.Value = rs("segundo_requeri")
            txtgas3.Value = rs("tercer_requeri")

            txtcorte.Text = rs("cod_cve")
            recdocumentos.Value = rs("porrec")
            ' ************ general ***********
            IVA.Text = rs("PORCIVA")
            IMAGENES.Text = rs("RUTAIMAGENES")

            ' ********** medicion *************
            TXTSIT.Text = rs("SITUACIONNUEVO")
            minconvenio.Text = rs("minimoConvenio")
            TxtXml.Text = rs("rutaxml")

            IIdiasrequeri.Value = rs("dias_req")
            IIdiasaviso24.Value = rs("dias_aviso_red")
            IIdiascorte.Value = rs("dias_lis_red")
            IIdiasembargo.Value = rs("dias_emb")
            IIdiasremate.Value = rs("dias_rem")

            ' *********** caja **********

            TxtBase.Text = rs("rutabase")
            TxtRuta.Text = rs("rutatmp")

        End If
        '   TxtRuta.Text = X.obtRutaDbase
        '  TxtXml.Text = X.obtRutaXml
        Me.GroupGeneral.Visible = True
        Me.GroupDocumentos.Visible = False
        Me.GroupMedicion.Visible = False
        GPCaja.Visible = False
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim cadena As New StringBuilder
        Dim ubima As String = ""

        cadena.Append("update empresa set  ")
        ' ***************cobranza *********
        '  
        cadena.Append("sufijo_conve='" & Me.TxtSufConvenio.Text & "',")
        cadena.Append("no_conve='" & Me.NumConvenio.Value & "',")
        cadena.Append("prefijo_conve='" & Me.TxtPreConvenio.Text & "',")
        cadena.Append("minimoConvenio =" & minconvenio.Text & ",")
        cadena.Append("porcanticipo=" & anticipo.Value & ",")
        cadena.Append("porrec=" & Me.recdocumentos.Value & ",")
        cadena.Append("prefijo_requeri='" & TxtPreRequeri.Text & "',")
        cadena.Append("no_requeri='" & NumRequeri.Text & "',")
        cadena.Append("sufijo_requeri='" & TxtSufRequeri.Text & "',")
        cadena.Append("cod_cve='" & txtcorte.Text & "',")
        cadena.Append("primer_requeri=" & txtgas1.Value & ",")
        cadena.Append("segundo_requeri=" & txtgas2.Value & ",")
        cadena.Append("tercer_requeri=" & txtgas3.Value & ",")
        cadena.Append("salario=" & SALARIO.Value & ",")
        cadena.Append("dias_req= " & IIdiasrequeri.Value & ",")
        cadena.Append("dias_aviso_red= " & IIdiasaviso24.Value & ",")
        cadena.Append("dias_lis_red= " & IIdiascorte.Value & ",")
        cadena.Append("dias_emb= " & IIdiasembargo.Value & ",")
        cadena.Append("dias_rem= " & IIdiasremate.Value & ",")
        '  ***************generales *************************

        cadena.Append("porciva='" & IVA.Text & "',")
        ubima = IMAGENES.Text.Replace("\", "/")

        cadena.Append("RUTAIMAGENES= '" & ubima & "',")

        ' **************** medicion *******************
        cadena.Append("SITUACIONNUEVO='" & TXTSIT.Text & "',")
        cadena.Append("SITUACIONDISPARADA='" & txtdisparada.Text & "',")
        cadena.Append("RUTAXML='" & TxtXml.Text & "',")

        ' ***************   cajas
        cadena.Append("RUTAbase='" & TxtBase.Text & "',")
        cadena.Append("RUTAtmp='" & TxtRuta.Text & "'")

        Try
            ' para recalcular todas las tarifas de acuerdo al nuevo salario minimo capturado

            Ejecucion("UPDATE MEDIDOR SET TARIFA_AGUA= " & SALARIO.Value & " * vsm_agua, tarifa_alcant = " & SALARIO.Value & " * vsm_alcant  , tarifa_sanea=" & SALARIO.Value & " * vsm_sanea ")
            Ejecucion("update conceptoscxc set monto_inicial= VSM * " & SALARIO.Value)
            Ejecucion("UPDATE CUOTAS SET SANECUO = VSMSANE * " & SALARIO.Value & ", ALCACUO= VSMDREN * " & SALARIO.Value & " , CONSUMEN = VSMAGUA * " & SALARIO.Value & " WHERE  MEDIDO=0")


        Catch ex As Exception

        End Try

        Try
            Ejecucion(cadena.ToString)
            MessageBoxEx.Show("Grabe satisfactoriamente")
        Catch ex As Exception
            MessageBox.Show("No grabe, verifica tus valores ")

        End Try
        '   X.grabRutadDase(TxtRuta.Text)
        '  X.grabRutaXml(TxtXml.Text)

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub LblCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCajas.Click
        apaga()
        GPCaja.Visible = True
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        FBD.ShowDialog()
        TxtRuta.Text = FBD.SelectedPath
    End Sub

    Private Sub BtnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBase.Click
        FBD.ShowDialog()
        TxtBase.Text = FBD.SelectedPath
    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        MessageBox.Show("Recuerde que esta funcion solo trabajara si se esta en una maquina con el servicio de base de datos instalado, no estara disponible para equipos remotos", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Shell("cmd.exe /k mysql --user=" & My.Settings.usuarioreporte & " --host=" & My.Settings.servidorreporte & " --password=" & My.Settings.passreporte & " " & My.Settings.basereporte & "<  " & TxtBase.Text & "\CajaMovil.sql")
    End Sub

    Private Sub BtnRutaXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRutaXml.Click
        FBD.ShowDialog()
        TxtXml.Text = FBD.SelectedPath
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        FBD.ShowDialog()
        IMAGENES.Text = FBD.SelectedPath
    End Sub

    Private Sub lblrequerimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblrequerimiento.Click
        apaga()
        Me.Panelrequerimientos.Visible = True
    End Sub
End Class