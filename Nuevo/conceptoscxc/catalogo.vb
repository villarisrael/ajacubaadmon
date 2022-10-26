Public Class catalogo

    Private frmpadre As Form
    Public campollave As String
    Public tipollave As String
    Public tablaborrado As String
    Public listacamposbusqueda As ListView
    Public listacamposbustabla As ListView
    Public listatipocambus As ListView
    Public camposgrid As ListView
    Public encabezadosdecampos As ListView
    Public anchosgrid As ListView
    Public wherederelacion As String
    Public tablasfrom As String
    Public frmaltaedita As Form
    Public quees As String

   


    Public Sub preparar(ByVal frm As Form)
        frmpadre = frm
        CMBCAMPOBUSQUEDA.Items.Clear()
        Dim i As Integer

        ' preparando el combo de busqueda
        If listacamposbusqueda.Items.Count <> listacamposbustabla.Items.Count Then
            MsgBox("No puedo prepara el grid los campos de busqueda y los campo tabla busqueda no son inguales")
            Exit Sub
        End If

        For i = 0 To listacamposbusqueda.Items.Count - 1
            CMBCAMPOBUSQUEDA.Items.Add(listacamposbusqueda.Items(i).Text)
        Next


        If camposgrid.Items.Count <> encabezadosdecampos.Items.Count Or camposgrid.Items.Count <> anchosgrid.Items.Count Then
            MsgBox("Hay una inconsitencia en el grid en relacion a sus encabezados o anchos")
            Exit Sub
        End If


        For i = 0 To camposgrid.Items.Count - 1
            DataGridViewX1.Columns.Add(camposgrid.Items(i).Text, encabezadosdecampos.Items(i).Text)
            DataGridViewX1.Columns.Item(i).DataPropertyName = camposgrid.Items(i).Text
            DataGridViewX1.Columns.Item(i).Width = Val(anchosgrid.Items(i).Text)
        Next
        Actualizar()

    End Sub

    Public Sub Actualizar()

        
        Dim clauwhere As String
        clauwhere = ""

        If wherederelacion <> "" Then
            clauwhere = wherederelacion
        End If

        llenaGrid(DataGridViewX1, "select " & cadenacampos() & " from " & tablasfrom & " " & clauwhere)


    End Sub

    Private Function cadenacampos() As String
        cadenacampos = ""
        cadenacampos = camposgrid.Items(0).Text
        Dim i As Integer
        For i = 1 To camposgrid.Items.Count - 1
            cadenacampos += "," & camposgrid.Items(i).Text
        Next
    End Function

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim valor As String
        valor = Me.DataGridViewX1.Item(campollave, DataGridViewX1.CurrentRow.Index).Value.ToString()
        If MsgBox("¿Estas seguro de  borrar " & valor, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If tipollave = "String" Then
                Ejecucion("delete from " & tablaborrado & " where " & campollave & "='" & valor & "'")
            Else
                Ejecucion("delete from " & tablaborrado & " where " & campollave & "=" & valor & "")
            End If
        End If
        Me.Actualizar()
    End Sub




    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If CMBCAMPOBUSQUEDA.SelectedIndex = -1 Then
            MessageBox.Show("Debes elegir el criterio de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CMBCAMPOBUSQUEDA.Focus()
        Else


            Dim cadenawhere As String
            cadenawhere = ""

            If listatipocambus.Items(CMBCAMPOBUSQUEDA.SelectedIndex).Text = "String" Then
                cadenawhere = listacamposbustabla.Items(CMBCAMPOBUSQUEDA.SelectedIndex).Text & "='" & txttextoabuscar.TextBox.Text & "'"
            Else
                cadenawhere = listacamposbustabla.Items(CMBCAMPOBUSQUEDA.SelectedIndex).Text & "=" & txttextoabuscar.TextBox.Text & ""
            End If

            If wherederelacion <> "" Then
                cadenawhere = wherederelacion & " and " & cadenawhere
            End If


            If txttextoabuscar.TextBox.Text <> "" Then

                llenaGrid(DataGridViewX1, "select " & cadenacampos() & " from " & tablasfrom & " where " & cadenawhere & "")
                'Else
                '   llenaGrid(DataGridViewX1, "select " & cadenacampos() & " from " & tablasfrom & " where " & cadenawhere & "")
                'End If


        End If

        End If
    End Sub

    Private Sub btnactualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactualizar.Click
        Me.Actualizar()
    End Sub

    Public Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        frmpadre.Close()
    End Sub


    

    Private Sub ButtonItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonItem2.Click
        Select Case quees
            Case "conceptoscxc"
                Dim frm As New frmdatosccxc
                frm.modo = "Modificar"
                frm.MdiParent = MDIPrincipal
                frm.txtclave.Text = DataGridViewX1.Item("id_concepto", DataGridViewX1.CurrentRow.Index).Value
                frm.txtdescripcion.Text = DataGridViewX1.Item("descripcion", DataGridViewX1.CurrentRow.Index).Value
                frm.cmbtipo.Text = DataGridViewX1.Item("tipo", DataGridViewX1.CurrentRow.Index).Value
                If Not IsDBNull(DataGridViewX1.Item("momento", DataGridViewX1.CurrentRow.Index).Value) Then
                    frm.cmbmomento.Text = DataGridViewX1.Item("momento", DataGridViewX1.CurrentRow.Index).Value
                Else
                    frm.cmbmomento.SelectedIndex = -1
                End If
                frm.chksistema.Checked = Boolean.Parse(obtenerCampo("select sistema from conceptoscxc where id_concepto='" & frm.txtclave.Text & "'", "sistema"))
                frm.cmbevento.Text = DataGridViewX1.Item("evento", DataGridViewX1.CurrentRow.Index).Value
                If Not IsDBNull(DataGridViewX1.Item("monto_inicial", DataGridViewX1.CurrentRow.Index).Value) Then
                    frm.IntegerInput1.Text = Math.Truncate(Double.Parse((obtenerCampo("select monto_inicial from conceptoscxc where id_concepto='" & frm.txtclave.Text & "'", "monto_inicial"))))
                Else
                    frm.IntegerInput1.Value = 0
                End If

                frm.WindowState = FormWindowState.Normal
                frm.Show()
        End Select
    End Sub

    Private Sub btnagregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Select Case quees
            Case "conceptoscxc"
                Dim frm As New frmdatosccxc
                frm.modo = "Nuevo"
                frm.MdiParent = MDIPrincipal

                frm.Show()
                frm.WindowState = FormWindowState.Normal
        End Select
    End Sub

    Private Sub datagridviewx1_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridViewX1.CellFormatting
        If quees = "conceptoscxc" Then
            Try
                Dim r As Integer
                For r = 0 To DataGridViewX1.Rows.Count - 1
                    If DataGridViewX1.Item("tipo", r).Value = "Cargo" Then
                        Dim i As Integer
                        For i = 0 To DataGridViewX1.Columns.Count - 1
                            Me.DataGridViewX1.Rows(r).Cells(i).Style.ForeColor = Color.Black  'VerificaColor(Colores(Veces))
                        Next i
                    Else
                        Dim i As Integer
                        For i = 0 To DataGridViewX1.Columns.Count - 1
                            Me.DataGridViewX1.Rows(r).Cells(i).Style.ForeColor = Color.Blue  'VerificaColor(Colores(Veces))
                        Next i
                    End If
                Next r
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        If quees = "conceptoscxc" Then
            Dim frmrep As New frmReporte("conceptoscxc.rpt", "", "")
            frmrep.MdiParent = My.Forms.MDIPrincipal
            frmrep.Show()
            frmrep.WindowState = FormWindowState.Maximized
        End If
    End Sub
End Class
