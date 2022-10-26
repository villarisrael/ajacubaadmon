Imports System.Data.Odbc
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Public Class FrmEmpresa
    Dim I, II As Integer
    Dim COBROHN, COBROMN As IDataReader
    Dim VALOR1, VALOR2, DESCRIPCION1, DESCRIPCION2 As String

    Private Sub FrmEmpresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        pic1.AllowDrop = True
        Dim rs As System.Data.IDataReader
        rs = ConsultaSql("Select * from empresa").ExecuteReader
        If rs.Read Then
            Me.TxtAdministrador.Text = rs("cadminis")
            Me.TxtAreaTecnica.Text = rs("DeptoTecnico").ToString
            Me.TxtColonia.Text = rs("Ccolonia")
            Me.TxtCP.Text = rs("ccodpos")
            Me.TxtDireccion.Text = rs("cdomicilio")
            Me.TxtFax.Text = rs("cfax")
            Me.TxtJuridico.Text = rs("deptojuridico")
            Me.TxtMunicipio.Text = rs("cpoblacion")
            Me.TxtNombre.Text = rs("cnombre")
            Me.TxtRFC.Text = rs("cnif")
            Me.TxtTelefono.Text = rs("ctlf")
            Me.TxtSiglas.Text = rs("siglas")
            VALOR1 = rs("CLV_GTO_NOT")
            VALOR2 = rs("CLV_GTO_MUL")
            COBROHN = ConsultaSql("select * from conceptoscxc where ID_CONCEPTO='" & Trim(VALOR1) & "'").ExecuteReader()
            If COBROHN.Read() Then
                DESCRIPCION1 = COBROHN("DESCRIPCION")
            Else
                DESCRIPCION1 = ""
            End If
            COBROMN = ConsultaSql("select * from conceptoscxc where ID_CONCEPTO='" & Trim(VALOR2) & "'").ExecuteReader()
            If COBROMN.Read() Then
                DESCRIPCION2 = COBROMN("DESCRIPCION")
            Else
                DESCRIPCION2 = ""
            End If
            CmbNotificar.Items.Clear()
            CmbPagoextemporaneo.Items.Clear()
            'Convenios
            'Me.TxtSufConvenio.Text = rs("sufijo_conve")
            'Me.NumConvenio.Value = rs("no_conve")
            'Me.TxtPreConvenio.Text = rs("prefijo_conve")
            ''mantenimientos
            ' Me.TxtPreMante.Text = rs("prefijo_ordMNTo")
            'Me.NumMante.Value = rs("no_ordmnto")
            'Me.TxtSufMante.Text = rs("sufijo_ordMnto")
            'Cortes
            'Me.TxtPreCorte.Text = rs("prefijo_ordcort")
            'Me.numCorte.Value = rs("no_ordcort")
            'Me.TxtSufCorte.Text = rs("sufijo_ordcort")
            'Inspecciones
            ' Me.TxtPreInspeccion.Text = rs("prefijo_insp")
            'Me.Numinspe.Value = rs("no_insp")
            'Me.TxtSufInspe.Text = rs("sufijo_insp")
            'Infracciones
            'Me.TxtPreInfracciones.Text = rs("prefijo_infra")
            'Me.NumInfra.Value = rs("no_infra")
            'Me.TxtSufInfra.Text = rs("sufijo_infra")
            'Requerimientos
            'TxtPreRequeri.Text = rs("prefijo_requeri")
            'NumRequeri.Value = rs("no_requeri")
            'TxtSufRequeri.Text = rs("sufijo_Requeri")
            'PrimerRequeri.Value = rs("primer_requeri")
            'SegundoRequeri.Value = rs("segundo_requeri")
            'TercerRequeri.Value = rs("tercer_requeri")
            llenarCombo(CmbNotificar, "Select id_concepto, descripcion from conceptoscxc")
            llenarCombo(CmbPagoextemporaneo, "Select id_concepto, descripcion from conceptoscxc")
            I = CmbNotificar.Items.IndexOf("'" & DESCRIPCION1 & "'")
            If I >= 0 Then
                CmbNotificar.Text = CmbNotificar.Items(I)
            Else
                CmbNotificar.Text = ""
            End If

            II = CmbPagoextemporaneo.Items.IndexOf("" & DESCRIPCION2 & "")
            If II >= 0 Then
                CmbPagoextemporaneo.Text = CmbPagoextemporaneo.Items(II)
            Else
                CmbPagoextemporaneo.Text = ""
            End If
        End If
        Try
            Dim dr As OdbcDataReader
            If conn.State = 0 Then ' esta cerrada
                conn.Open()
            End If
            dr = New OdbcCommand("select logo From empresa where codemp=1", conn).ExecuteReader
            dr.Read()

            Dim blobdata(CInt(dr.GetBytes(0, 0, Nothing, 0, Integer.MaxValue) - 1)) As Byte
            dr.GetBytes(0, 0, blobdata, 0, blobdata.Length)
            Dim fs As New System.IO.FileStream(AppPath() & "\logo.bmp", IO.FileMode.Create, IO.FileAccess.Write)
            fs.Write(blobdata, 0, blobdata.Length)
            fs.Close()
            pic1.Image = Image.FromFile(AppPath() & "\logo.bmp")
        Catch ex As Exception
            Dim mensaje As String = ex.Message
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        Dim mstream As New System.IO.MemoryStream()

        '  Me.pbLogo.Image = Image.FromFile(Me.OpenFileDialog1.FileName)

        Me.pic1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        Dim arrImage() As Byte = mstream.GetBuffer()


        '    Ejecucion("update empresa set tercer_requeri = " & TercerRequeri.Value & ", segundo_requeri = " & SegundoRequeri.Value & ", primer_requeri = " & PrimerRequeri.Value & ", sufijo_Requeri = '" & TxtSufRequeri.Text & "',no_requeri = " & NumRequeri.Value & ",prefijo_requeri = '" & TxtPreRequeri.Text & "', cadminis = '" & TxtAdministrador.Text & "', DeptoTecnico = '" & TxtAreaTecnica.Text & "', Ccolonia = '" & TxtColonia.Text & "', ccodpos = '" & TxtCP.Text & "', cdomicilio = '" & TxtDireccion.Text & "', cfax = '" & TxtFax.Text & "', deptojuridico = '" & TxtJuridico.Text & "', cpoblacion = '" & Me.TxtMunicipio.Text & "', cnombre = '" & Me.TxtNombre.Text & "', cnif = '" & Me.TxtRFC.Text & "', ctlf = '" & Me.TxtTelefono.Text & "', siglas = '" & Me.TxtSiglas.Text & "', sufijo_conve = '" & Me.TxtSufConvenio.Text & "', no_conve = " & NumConvenio.Value & ", prefijo_conve = '" & Me.TxtPreConvenio.Text & "'")
        Ejecucion("update empresa set cadminis = '" & TxtAdministrador.Text & "', DeptoTecnico = '" & TxtAreaTecnica.Text & "', Ccolonia = '" & TxtColonia.Text & "', ccodpos = '" & TxtCP.Text & "', cdomicilio = '" & TxtDireccion.Text & "', cfax = '" & TxtFax.Text & "', deptojuridico = '" & TxtJuridico.Text & "', cpoblacion = '" & Me.TxtMunicipio.Text & "', cnombre = '" & Me.TxtNombre.Text & "', cnif = '" & Me.TxtRFC.Text & "', ctlf = '" & Me.TxtTelefono.Text & "', siglas = '" & Me.TxtSiglas.Text & "',clv_gto_not = '" & VALOR1 & "',clv_gto_mul = '" & VALOR2 & "'")
        Try
            If conn.State = 0 Then ' esta cerrada
                conn.Open()
            End If
            Dim cmd As New OdbcCommand
            cmd.Connection = conn

            cmd.CommandText = "update empresa Set logo =@File where codemp=1"
            ' Application.DoEvents()

            cmd.Parameters.AddWithValue("@File", arrImage)

            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try



    End Sub

    Private Sub CmbNotificar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbNotificar.SelectedIndexChanged
        COBROHN = ConsultaSql("Select * from conceptoscxc where descripcion='" & Trim(CmbNotificar.Text) & "'").ExecuteReader()
        If COBROHN.Read() Then
            VALOR1 = COBROHN("ID_CONCEPTO")
        Else
            VALOR1 = ""
        End If
    End Sub

    Private Sub CmbPagoextemporaneo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPagoextemporaneo.SelectedIndexChanged
        COBROMN = ConsultaSql("select * from conceptoscxc where descripcion='" & Trim(CmbPagoextemporaneo.Text) & "'").ExecuteReader()
        If COBROMN.Read() Then
            VALOR2 = COBROMN("ID_CONCEPTO")
        Else
            VALOR2 = ""
        End If

    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Try
            OpenFileDialog1.Filter = "Imágenes |*.jpg; *.png; *.gif"
            OpenFileDialog1.Title = "Seleccione una Imagen"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.ImageLocation = OpenFileDialog1.FileName
                PictureBox1.Load()
            Else
                'PictureBox1.ImageLocation = "C:\CONGELADOS DE TECOMAN\NOHAYFOTOGRAFIA.JPG"
                PictureBox1.Image = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click

    End Sub




    Private Sub pic1_Click(sender As Object, e As EventArgs) Handles pic1.Click

    End Sub

    'convertir binario a imágen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    'convertir imagen a binario
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function       'variable de datos binarios en stream(flujo)





    Private Sub pic1_DragDrop(sender As Object, e As DragEventArgs) Handles pic1.DragDrop
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

    Private Sub pic1_DragEnter(sender As Object, e As DragEventArgs) Handles pic1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) _
       Or e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Dim Bin As New MemoryStream
    'convertir a bytes


End Class