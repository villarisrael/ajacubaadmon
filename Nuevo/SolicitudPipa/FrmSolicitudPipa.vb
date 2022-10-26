Public Class FrmSolicitudPipa


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        VaciarTextBox()
        txtNombre.Enabled = True
        btnGuardar.Enabled = True
    End Sub

    Private Sub VaciarTextBox()

        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtReferencia.Text = ""
        txtEntre.Text = ""
        txtCelular.Text = ""
        txtTelefono.Text = ""
        txtZona.Text = ""
        txtInmueble.Text = ""
        txtLitros.Text = ""
        txtEntrego.Text = ""
        'CmbEstatus.Items.Clear()
        TxtObservacion.Text = ""
        LabelID.Text = ""

    End Sub

    Dim Nombre As String
    Dim comboEstatus As String


    'Private Sub llenarGrid()
    '    Dim ds As New DataSet
    '    'Dim dt As New DataTable
    '    Dim sql As String = "Select IDOrden,Nombre,Cuenta, Direccion, Referencia, Entre, NumCel, Telefono, Zona, Inmueble, FechaSolicitud, CantLts, FechaEntrega, Entrego, Estatus, Observacion from solcitudpipa"
    '    Dim dt As String = ConsultaSql("Select IDOrden,Nombre,Cuenta, Direccion, Referencia, Entre, NumCel, Telefono, Zona, Inmueble, FechaSolicitud, CantLts, FechaEntrega, Entrego, Estatus, Observacion from solcitudpipa")
    '    'Dim da As New OleDb.OleDbDataAdapter(, conn)
    'End Sub

    Private Sub ActualizarGrid()
        Dim sql As String = "Select * from solicitudpipa"
        llenaGrid(DataGridViewPipa, sql)
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        If Not FrmReportesPipa.Created Then
            'frmBusUsuario.filtro("select distinct cuenta as Cuenta,cuentaAnterior, nombre as Nombre , comunidad as Comunidad,Direccion,estado as Estado,nodemedidor as Medidor,catastral  from vusuario order by cuenta ")
            'FrmReportesPipa.MdiChildren = Me
            'FrmReportesPipa.WindowState = 2

            FrmReportesPipa.Show()
            FrmReportesPipa.WindowState = FormWindowState.Normal
        End If
        FrmReportesPipa.Select()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub FrmSolicitudPipa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sql As String = "Select IDOrden,Nombre,Cuenta, Direccion, Referencia, Entre, NumCel, Telefono, Zona, Inmueble, FechaSolicitud, CantLts, FechaEntrega, Entrego, Estatus, Observacion from solicitudpipa"

        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size

        'Me.Size = New System.Drawing.Size(100, 100)

        Me.DGVAutocomplete.BackgroundColor = Color.White
        ActualizarGrid()
        Editar.Enabled = False
        Eliminar.Enabled = False
        'Dim x As base = New base()
        'Dim sql As String = "Select * from solicitudpipa"
        'MySqlCommand cmd = New MySqlCommand(sql, x);


    End Sub

    Private Sub Editar_Click(sender As Object, e As EventArgs) Handles Editar.Click
        'If DataGridViewPipa.SelectedRows.Count = 0 Then
        '    MessageBox.Show("Selecciona un registro")
        'Else
        '    DataGridViewPipa.SelectedRows(0).SetValues(txtNombre.Text, txtDireccion.Text, txtReferencia.Text, txtEntre.Text, txtCelular.Text, txtTelefono.Text, txtZona.Text, txtInmueble.Text, txtLitros.Text)
        'End If
        'If (Nombre == "") Then
        '    MessageBox.Show("Selecciona una fila para editar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    txtNombre.Text = Nombre
        'End If


        Dim cuenta As Integer = obtenerCampo("select cuenta from usuario where nombre = '" & txtNombre.Text & "'", "Cuenta")
        Dim IDOrden As Integer = LabelID.Text
        'Dim FechaEntrega As String

        'FechaEntrega = MonthCalendarEntrega.SelectionRange.Start.Year & "-" & MonthCalendarEntrega.SelectionRange.Start.Month & "-" & MonthCalendarEntrega.SelectionRange.Start.Day




        'obtenerCampo("select IDOrden from solicitudpipa where IDOrden = '" &  & "'", "Cuenta")
        'Dim FechaSolicitud As Date = obtenerCampo("select FechaSolicitud from solicitudpipa where Cuenta = '" &  & "'", "Cuenta")

        'MessageBox.Show(FechaSolicitud)

        Ejecucion("update solicitudpipa set Estatus = '" & "En Proceso" & "', Nombre='" & txtNombre.Text & "', Direccion='" & txtDireccion.Text & "', Referencia='" & txtReferencia.Text & "', Entre='" & txtEntre.Text & "', NumCel='" & txtCelular.Text & "', Telefono='" & txtTelefono.Text & "', Zona='" & txtZona.Text & "', Inmueble='" & txtInmueble.Text & "', CantLts = '" & txtLitros.Text & "', FechaEntrega = '" & "0000-00-00" & "', Entrego = '" & txtEntrego.Text & "', Observacion = '" & TxtObservacion.Text & "' where IDOrden = '" & IDOrden & "'")

        VaciarTextBox()
        ActualizarGrid()


    End Sub

    Private Sub DataGridViewPipa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPipa.CellClick

        Dim i As Integer
        i = DataGridViewPipa.CurrentRow.Index
        LabelID.Text = DataGridViewPipa.Item(0, i).Value()
        txtNombre.Text = DataGridViewPipa.Item(2, i).Value()
        txtDireccion.Text = DataGridViewPipa.Item(4, i).Value()
        txtReferencia.Text = DataGridViewPipa.Item(5, i).Value()
        txtEntre.Text = DataGridViewPipa.Item(6, i).Value()
        txtCelular.Text = DataGridViewPipa.Item(7, i).Value()
        txtTelefono.Text = DataGridViewPipa.Item(8, i).Value()
        txtZona.Text = DataGridViewPipa.Item(9, i).Value()
        txtInmueble.Text = DataGridViewPipa.Item(10, i).Value()
        txtLitros.Text = DataGridViewPipa.Item(12, i).Value()

        txtNombre.Enabled = False
        btnGuardar.Enabled = True
        Editar.Enabled = True
        Eliminar.Enabled = True

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        MessageBox.Show("Se eliminara la solicitud de pipa seleccionada", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Ejecucion("Delete from solicitudpipa where IDOrden = '" & LabelID.Text & "'")

        VaciarTextBox()
        ActualizarGrid()

    End Sub




    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text.Length > 3 Then
            Dim x As base = New base()
            'x.llenaGrid(DGVContenido, "   SELECT CUENTA , NOMBRE,DIRECCION, COMUNIDAD FROM consesionarios WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            'x.llenaGrid(DGVContenido, "  SELECT CUENTA, NOMBRE, DIRECCION, Comunidad FROM consesionarios INNER JOIN comunidades ON (comunidades.Id_comunidad= consesionarios.NUMCOMU) WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            x.llenaGrid(DGVAutocomplete, "SELECT  CUENTA, NOMBRE, id_calle FROM usuario WHERE NOMBRE LIKE '%" & txtNombre.Text & "%'")
        End If
    End Sub



    Private Sub DGVAutocomplete_DoubleClick(sender As Object, e As EventArgs) Handles DGVAutocomplete.DoubleClick
        Try
            Dim cuenta As Long = DGVAutocomplete.SelectedRows.Item(0).Cells(0).Value

            Dim Nombre As String = obtenerCampo("select nombre from usuario where cuenta = '" & cuenta & "'", "Nombre")

            txtNombre.Text = Nombre

            Dim idcalle As String = obtenerCampo("select id_calle from usuario where cuenta = '" & cuenta & "'", "id_calle")


            Dim calle As String = obtenerCampo("select nombre from calles where id_calle = '" & idcalle & "'", "Nombre")

            txtDireccion.Text = calle


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim Nombre As String
        Nombre = txtNombre.Text
        MessageBox.Show(Nombre)

        ' Obtener la fecha de los calendarios AAAA-M-D
        Dim FechaSol As String

        FechaSol = MonthCalendarSol.SelectionRange.Start.Year & "-" & MonthCalendarSol.SelectionRange.Start.Month & "-" & MonthCalendarSol.SelectionRange.Start.Day
        'FechaSol += MonthCalendarSol.SelectionStart.Month
        'FechaSol += MonthCalendarSol.SelectionStart.Day
        'MessageBox.Show(FechaSol)
        'FechaEntrega = MonthCalendarEntrega.SelectionRange.End
        'MessageBox.Show(FechaEntrega)

        ' Autocompletar el nombre
        Dim ds As New DataTable
        Dim col As New AutoCompleteStringCollection

        ConsultaSql("select nombre from usuario")

        '

        Dim cuenta As Integer = obtenerCampo("select cuenta from usuario where nombre = '" & txtNombre.Text & "'", "Cuenta")

        If cuenta <> 0 Then
            Ejecucion("insert into solicitudpipa(Nombre,Cuenta, Direccion, Referencia, Entre, NumCel, Telefono, Zona, Inmueble, FechaSolicitud, CantLts, FechaEntrega, Entrego, Estatus, Observacion) values('" & txtNombre.Text & "','" & cuenta & "','" & txtDireccion.Text & "','" & txtReferencia.Text & "','" & txtEntre.Text & "','" & txtCelular.Text & "','" & txtTelefono.Text & "','" & txtZona.Text & "','" & txtInmueble.Text & "','" & FechaSol & "','" & "0" & "','" & "0000-0-0'" & "," & "' '" & "," & " 'En Proceso' " & "," & "' '" & ")")

        Else
            MessageBox.Show("El usuario no está dentro del padrón de usuarios pero se hara la solicitud")

            Ejecucion("insert into solicitudpipa(Nombre,Cuenta, Direccion, Referencia, Entre, NumCel, Telefono, Zona, Inmueble, FechaSolicitud, CantLts, FechaEntrega, Entrego, Estatus, Observacion) values('" & txtNombre.Text & "','" & cuenta & "','" & txtDireccion.Text & "','" & txtReferencia.Text & "','" & txtEntre.Text & "','" & txtCelular.Text & "','" & txtTelefono.Text & "','" & txtZona.Text & "','" & txtInmueble.Text & "','" & FechaSol & "','" & "0" & "','" & "0000-0-0'" & "," & "' '" & "," & " 'En Proceso' " & "," & "''" & ")")
        End If

        MessageBox.Show("La solicitud de pipa del usuario: " & txtNombre.Text & " Se ha registrado con exito", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information)

        VaciarTextBox()
        txtBuscarxNom.Text = " "
        ActualizarGrid()

    End Sub

    Private Sub DataGridViewPipa_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewPipa.CellFormatting
        If (DataGridViewPipa.Columns(e.ColumnIndex).Name = "Estatus") Then
            If Convert.ToString(e.Value) = "En Proceso" Then
                e.CellStyle.BackColor = Color.Yellow
            End If

            If Convert.ToString(e.Value) = "Entregado" Then
                e.CellStyle.BackColor = Color.Green
            End If

            If Convert.ToString(e.Value) = "No Se Entrego" Then
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub CmbEstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEstatus.SelectedIndexChanged
        'If CmbEstatus.SelectedIndex >= 0 Then
        '    Editar.Enabled = True
        'End If


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        If txtNombre.Text.Length > 3 Then
            Dim x As base = New base()
            'x.llenaGrid(DGVContenido, "   SELECT CUENTA , NOMBRE,DIRECCION, COMUNIDAD FROM consesionarios WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            'x.llenaGrid(DGVContenido, "  SELECT CUENTA, NOMBRE, DIRECCION, Comunidad FROM consesionarios INNER JOIN comunidades ON (comunidades.Id_comunidad= consesionarios.NUMCOMU) WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            x.llenaGrid(DGVAutocomplete, "SELECT  CUENTA, NOMBRE, id_calle FROM usuario WHERE NOMBRE LIKE '%" & txtNombre.Text & "%'")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EditarEntrega.Click
        Dim cuenta As Integer = obtenerCampo("select cuenta from usuario where nombre = '" & txtNombre.Text & "'", "Cuenta")
        Dim IDOrden As Integer = LabelID.Text
        Dim FechaEntrega As String

        FechaEntrega = MonthCalendarEntrega.SelectionRange.Start.Year & "-" & MonthCalendarEntrega.SelectionRange.Start.Month & "-" & MonthCalendarEntrega.SelectionRange.Start.Day

        comboEstatus = CmbEstatus.SelectedItem.ToString()


        'obtenerCampo("select IDOrden from solicitudpipa where IDOrden = '" &  & "'", "Cuenta")
        'Dim FechaSolicitud As Date = obtenerCampo("select FechaSolicitud from solicitudpipa where Cuenta = '" &  & "'", "Cuenta")

        'MessageBox.Show(FechaSolicitud)

        Ejecucion("update solicitudpipa set Estatus = '" & comboEstatus & "', Nombre='" & txtNombre.Text & "', Direccion='" & txtDireccion.Text & "', Referencia='" & txtReferencia.Text & "', Entre='" & txtEntre.Text & "', NumCel='" & txtCelular.Text & "', Telefono='" & txtTelefono.Text & "', Zona='" & txtZona.Text & "', Inmueble='" & txtInmueble.Text & "', CantLts = '" & txtLitros.Text & "', FechaEntrega = '" & FechaEntrega & "', Entrego = '" & txtEntrego.Text & "', Observacion = '" & TxtObservacion.Text & "' where IDOrden = '" & IDOrden & "'")

        VaciarTextBox()
        ActualizarGrid()
    End Sub

    Private Sub BtnBuscarxNom_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarxNom.TextChanged
        If txtBuscarxNom.Text.Length > 3 Then
            Dim x As base = New base()
            'x.llenaGrid(DGVContenido, "   SELECT CUENTA , NOMBRE,DIRECCION, COMUNIDAD FROM consesionarios WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            'x.llenaGrid(DGVContenido, "  SELECT CUENTA, NOMBRE, DIRECCION, Comunidad FROM consesionarios INNER JOIN comunidades ON (comunidades.Id_comunidad= consesionarios.NUMCOMU) WHERE NOMBRE LIKE '%" & txtnombre.Text & "%'")
            x.llenaGrid(DataGridViewPipa, "SELECT * FROM solicitudpipa WHERE NOMBRE LIKE '%" & txtBuscarxNom.Text & "%'")
        End If
        If txtBuscarxNom.Text.Length = 0 Then
            ActualizarGrid()
        End If
    End Sub
End Class