Imports CAJAS.base
Imports System.Data.Odbc


Public Class frmListadoRecibos

    Dim fechaoriginal As Date
    Dim recibo As String = ""
    Dim cuenta As String = ""
    Dim serie As String = ""
    Dim result As DialogResult
    Public esusuario As String


    Private Sub frmListadoRecibos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtinicio.Value = DateTime.Now
        dtfinal.Value = DateTime.Now


        GroupBox1.Enabled = False

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargar.Click


        Try

            Dim bas As New base
            If txtcaja.Text = "" Then
                bas.llenaGrid(dataGridView1, "select serie, recibo,cuenta, nombre, periodo, fecha_Act, total-iva as Subtotal,IVA, Total, Facturado,Cancelado, case when esusuario=1 then 'USUARIO' when esusuario=0 then 'CLIENTE' when esusuario=2 then 'CLIENTE' WHEN esusuario=3 then 'FACTIBILIDAD' end as Es, FECHA_DEUDA as Fecha_Deuda, Tarifa, ccodpago AS Forma from pagos where fecha_Act between '" & dtinicio.Value.ToString("yyyy-MM-dd") & "' and '" & dtfinal.Value.ToString("yyyy-MM-dd") & "';")
            Else
                bas.llenaGrid(dataGridView1, "select serie, recibo,cuenta, nombre, periodo, fecha_Act, total-iva as Subtotal,IVA, Total, Facturado,Cancelado, case when esusuario=1 then 'USUARIO' when esusuario=0 then 'CLIENTE' when esusuario=2 then 'CLIENTE' WHEN esusuario=3 then 'FACTIBILIDAD' end as Es, FECHA_DEUDA as Fecha_Deuda, Tarifa, CCODPAGO AS Forma from pagos where fecha_Act between '" & dtinicio.Value.ToString("yyyy-MM-dd") & "' and '" & dtfinal.Value.ToString("yyyy-MM-dd") & "' and caja='" & txtcaja.Text & "'")
            End If
            lblcuantos.Text = "Se econtraton " & dataGridView1.Rows.Count & " recibos"
            dataGridView1.Columns(0).Width = 150
            dataGridView1.Columns(1).Width = 50
            dataGridView1.Columns(2).Width = 50
            dataGridView1.Columns(3).Width = 300



            bas.conexion.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        recibo = dataGridView1.Item("recibo", dataGridView1.CurrentRow.Index).Value.ToString()
        serie = dataGridView1.Item("serie", dataGridView1.CurrentRow.Index).Value.ToString()

        result = MessageBox.Show("¿Esta seguro que desea Eliminar el Recibo: " & recibo & "?", "Cuidado!!! ", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then

            Try
                Dim x As New base
                x.conectar()
                Ejecucion("delete from pagos  where recibo=" & recibo & " and serie ='" & serie & "'")
                Ejecucion("delete from pagotros  where recibo=" & recibo & " and serie ='" & serie & "'")
                Ejecucion("delete from pago_mes  where recibo=" & recibo & " and serie ='" & serie & "'")
                x.conexion.Dispose()
            Catch ex As Exception

            End Try

        End If
        btnAceptar_Click(sender, e)
    End Sub

    Private Sub superTabrecibos_SelectedTabChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles superTabrecibos.SelectedTabChanged
        If e.NewValue.ToString = "Esclavo" Then
            Dim X2 As New base
            X2.conectar()
            advDetalles.ClearAndDisposeAllNodes()
            Try

                Try
                    recibo = dataGridView1.Item("recibo", dataGridView1.CurrentRow.Index).Value.ToString()
                Catch ex As Exception
                    MessageBox.Show("No has seleccionado un recibo")
                    Exit Sub
                End Try


                serie = dataGridView1.Item("serie", dataGridView1.CurrentRow.Index).Value.ToString()

                Dim datosesclavo As Odbc.OdbcDataReader = X2.consultasql("select * from pagotros where recibo=" & recibo & " and serie='" & serie & "'")
                Dim nuevonodo As New DevComponents.AdvTree.Node

                advDetalles.Columns.Add(New DevComponents.AdvTree.ColumnHeader("Cantidad"))
                advDetalles.Columns(0).Width.Absolute = 50
                advDetalles.Columns.Add(New DevComponents.AdvTree.ColumnHeader("Concepto"))
                advDetalles.Columns(1).Width.Absolute = 350
                advDetalles.Columns.Add(New DevComponents.AdvTree.ColumnHeader("Precio Uni"))
                advDetalles.Columns(2).Width.Absolute = 140
                advDetalles.Columns.Add(New DevComponents.AdvTree.ColumnHeader("Importe"))
                advDetalles.Columns(3).Width.Absolute = 140

                advDetalles.Columns.Add(New DevComponents.AdvTree.ColumnHeader("Con Iva"))
                advDetalles.Columns(4).Width.Absolute = 50
                While (datosesclavo.Read)


                    Dim nuevoesclavo As New DevComponents.AdvTree.Node
                    Try
                        nuevoesclavo.Cells(0).Text = datosesclavo!Cantidad
                    Catch ex As Exception

                    End Try
                    Try
                        Dim celda As New DevComponents.AdvTree.Cell
                        celda.Text = datosesclavo!concepto
                        nuevoesclavo.Cells.Add(celda)

                    Catch ex As Exception

                    End Try
                    Try
                        Dim celda8 As New DevComponents.AdvTree.Cell

                        Dim etiqueta8 As New DevComponents.DotNetBar.LabelX
                        celda8.HostedControl = etiqueta8
                        etiqueta8.Text = datosesclavo!importe
                        etiqueta8.TextAlignment = StringAlignment.Far
                        etiqueta8.ForeColor = Color.Blue
                        nuevoesclavo.Cells.Add(celda8)

                    Catch ex As Exception

                    End Try
                    Try
                        Dim celda9 As New DevComponents.AdvTree.Cell

                        Dim etiqueta9 As New DevComponents.DotNetBar.LabelX
                        celda9.HostedControl = etiqueta9
                        etiqueta9.Text = datosesclavo!monto
                        etiqueta9.TextAlignment = StringAlignment.Far
                        etiqueta9.ForeColor = Color.Blue
                        nuevoesclavo.Cells.Add(celda9)

                    Catch ex As Exception

                    End Try
                    Try
                        Dim celdaiva As New DevComponents.AdvTree.Cell
                        celdaiva.Text = datosesclavo!iva
                        nuevoesclavo.Cells.Add(celdaiva)

                    Catch ex As Exception

                    End Try
                    'nuevonodo.Nodes.Add(nuevoesclavo)
                    advDetalles.Nodes.Add(nuevoesclavo)
                End While


            Catch ex As Exception

            End Try
            X2.conexion.Dispose()
        End If
        If e.NewValue.ToString = "Rectifica" Then
            Dim bas As New base
            bas.llenaGrid(dataGridViewRectifica, "select pagos.serie, pagos.recibo, pagos.total-pagos.iva AS SubTotal, pagos.IVA, pagos.Total ,Round( sum(importe),2)  as Esclavo from pagos,pagotros where pagos.serie=pagotros.serie and pagos.recibo=pagotros.recibo and fecha_Act between '" & dtinicio.Value.ToString("yyyy-MM-dd") & "' and '" & dtfinal.Value.ToString("yyyy-MM-dd") & "' group by pagos.serie,pagos.recibo, pagos.total-pagos.iva, pagos.iva, pagos.total;")
            bas.conexion.Dispose()

        End If
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Close()
    End Sub

    Private Sub btnRenumerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRenumerar.Click
        btnRenumerar.Enabled = False
        If btncargar.Text = "" Then
            MessageBox.Show("No has seleccionado una serie")
            btnRenumerar.Enabled = True
            Exit Sub
        End If
        If IIfolioinicio.Value = 0 Then
            MessageBox.Show("No has seleccionado un folio de inicio")
            btnRenumerar.Enabled = True
            Exit Sub
        End If
        If IIfoliofinal.Value = 0 Then
            MessageBox.Show("No has seleccionado un folio final")
            btnRenumerar.Enabled = True
            Exit Sub
        End If
        Try
            Dim x As New base
            x.conectar()
            Dim verificar As OdbcDataReader

            If IIsumando.Value <= -1 Then
                verificar = x.consultasql("select * from pagos where recibo between " & IIfolioinicio.Value + IIsumando.Value & " and " & IIfolioinicio.Value & " and serie='" & btncargar.Text & "'")
            End If
            If IIsumando.Value >= 1 Then
                verificar = x.consultasql("select * from pagos where recibo between " & IIfoliofinal.Value & " and " & IIfoliofinal.Value + IIsumando.Value & " and serie='" & txtserie.Text & "'")
            End If
            If verificar.Read Then
                If IIfolioinicio.Value = 0 Then
                    MessageBox.Show("No puede realizarse la operacion por que hay un folio en ese lugar")
                    Exit Sub
                End If
            End If

            If IIsumando.Value <= -1 Then
                For i = IIfolioinicio.Value To IIfoliofinal.Value
                    Ejecucion("update pagos set recibo= " & i + IIsumando.Value & " where recibo = " & i & " and serie='" & txtserie.Text & "'")
                    Ejecucion("update pagotros set recibo= " & i + IIsumando.Value & " where recibo = " & i & " and serie='" & txtserie.Text & "'")
                    Ejecucion("update pago_mes set recibo= " & i + IIsumando.Value & " where recibo = " & i & " and serie='" & txtserie.Text & "'")
                Next
            End If
            If IIsumando.Value >= 1 Then
                For i = IIfoliofinal.Value To IIfolioinicio.Value Step -1
                    Ejecucion("update pagos set recibo= " & i + IIsumando.Value & " where RECIBO = " & i & " and serie='" & txtserie.Text & "'")
                    Ejecucion("update pagotros set recibo= " & i + IIsumando.Value & " where RECIBO = " & i & " and serie='" & txtserie.Text & "'")
                    Ejecucion("update pago_mes set recibo= " & i + IIsumando.Value & " where RECIBO = " & i & " and serie='" & txtserie.Text & "'")
                Next
            End If
            x.conexion.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
            btnRenumerar.Enabled = True
            Exit Sub
        End Try

        btnRenumerar.Enabled = True

        btnAceptar_Click(sender, e)

    End Sub







End Class