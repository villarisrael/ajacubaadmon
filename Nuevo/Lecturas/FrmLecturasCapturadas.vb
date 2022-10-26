Imports DevComponents.DotNetBar

Public Class FrmLecturasCapturadas
#Region "Variables"
    Dim _Filtro As String, _Fecha As Date
    Dim _Comunidad As String, _Region As String, _Ruta As String
    Dim intFilaSel As Integer

    'Private so As New BindingSource
    'Private vista As DataView
    Public Property Ruta() As String
        Get
            Return _Ruta
        End Get
        Set(ByVal value As String)
            _Ruta = value
        End Set
    End Property
    Public Property Regi() As String
        Get
            Return _Region
        End Get
        Set(ByVal value As String)
            _Region = value
        End Set
    End Property
    Public Property Comunidad() As String
        Get
            Return _Comunidad
        End Get
        Set(ByVal value As String)
            _Comunidad = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property
    Public Property Filtro() As String
        Get
            Return _Filtro
        End Get
        Set(ByVal value As String)
            _Filtro = value
        End Set
    End Property

#End Region

    Private Sub FrmLecturasCapturadas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmCapturaLecturas.SigRuta = False
        FrmCapturaLecturas.Buscar()
        FrmCapturaLecturas.SigRuta = True
    End Sub

    Private Sub FrmLecturasCapturadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If _Filtro = Nothing Then
            MessageBoxEx.Show("No ha establecido el criterio de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Actualizar()
        Try
            DgLecturas.Columns.Item(4).Width = 50
            DgLecturas.Columns.Item(7).Width = 50
            DgLecturas.Columns.Item(8).Width = 50

            DgLecturas.Columns.Item(9).Width = 50
            DgLecturas.Columns.Item(10).Width = 50
            DgLecturas.Columns.Item(11).Width = 50
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DgLecturas_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgLecturas.CellClick
        If e.RowIndex >= 0 Then
            intFilaSel = DgLecturas.Item(0, e.RowIndex).Value
        End If
    End Sub

    Private Sub DgLecturas_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DgLecturas.CellFormatting
        If DgLecturas.Item("Alerta", e.RowIndex).Value = 1 Then
            For a As Integer = 0 To DgLecturas.ColumnCount - 1
                DgLecturas.Item(a, e.RowIndex).Style.BackColor = Color.LightSalmon
            Next
        Else
            For a As Integer = 0 To DgLecturas.ColumnCount - 1
                DgLecturas.Item(a, e.RowIndex).Style.BackColor = Color.White
            Next
        End If
    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Try
            Dim Lectura As New ClsLecturas
            Lectura.Cuenta = DgLecturas.Item("CUENTA", DgLecturas.CurrentRow.Index).Value()
            Lectura.Region = _Region
            Lectura.Ruta = _Ruta
            Lectura.periodo = Year(Fecha)
            Lectura.EliminarLectura("lecturas")
            Actualizar()
        Catch ex As Exception
            MessageBoxEx.Show("No se puede eliminar, no hay lecturas seleccionadas", "Eliminar Lectura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModificar.Click
        Try
            Dim LecInd As New FrmAgregarLectura
            'LecInd.Comunidad = DgLecturas.Item(2, DgLecturas.CurrentRow.Index).Value()
            LecInd.Cuenta = DgLecturas.Item("CUENTA", DgLecturas.CurrentRow.Index).Value()
            LecInd.Algo = DgLecturas.Item("alg", DgLecturas.CurrentRow.Index).Value()

            LecInd.mes = FrmCapturaLecturas.cmbmes.Text
            LecInd.periodo = FrmCapturaLecturas.txtAn.Text

            'LecInd.Comunidad = DgLecturas.Item("Comunidad", DgLecturas.CurrentRow.Index).Value
            'LecInd.Cuenta = DgLecturas.Item("Cuenta", DgLecturas.CurrentRow.Index).Value

            LecInd.Regi = _Region
            LecInd.Ruta = _Ruta
            LecInd.Fecha = Fecha
            LecInd.TxtActual.Value = DgLecturas.Item("Lectura", DgLecturas.CurrentRow.Index).Value
            Try
                LecInd.TxtObservacion.Text = DgLecturas.Item("Observaciones", DgLecturas.CurrentRow.Index).Value
            Catch ex As Exception
                LecInd.TxtObservacion.Text = ""
            End Try
            Try
                LecInd.CmbSituacion1.Text = DgLecturas.Item("Sit_med", DgLecturas.CurrentRow.Index).Value
            Catch ex As Exception
                LecInd.CmbSituacion1.Text = ""
            End Try
            Try
                LecInd.CmbSituacion2.Text = DgLecturas.Item("Sit_Padron", DgLecturas.CurrentRow.Index).Value
            Catch ex As Exception
                LecInd.CmbSituacion2.Text = ""
            End Try
            Try
                LecInd.CmbSituacion3.Text = DgLecturas.Item("Sit_lec", DgLecturas.CurrentRow.Index).Value
            Catch ex As Exception
                LecInd.CmbSituacion3.Text = ""
            End Try

            LecInd.ShowDialog()
            Actualizar()
        Catch ex As Exception
            MessageBoxEx.Show("No se puede modificar, no hay lecturas seleccionadas", "Modificar Lectura", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Try
            Dim frm As New FrmBusLec(Me, DgLecturas.CurrentCell.ColumnIndex, DgLecturas.Columns(DgLecturas.CurrentCell.ColumnIndex).HeaderText)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        Catch ex As Exception
            Try
                Dim frm As New FrmBusLec(Me, 0, DgLecturas.Columns(DgLecturas.CurrentCell.ColumnIndex).HeaderText)
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
            Catch ex1 As Exception
                MessageBoxEx.Show("No se puede buscar dado que no tiene seleccionada ninguna columna", "Busqueda de Lecturas", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End Try

        End Try

    End Sub

    Private Sub BtnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizar.Click
        Actualizar()
    End Sub

    Private Sub Actualizar()
        Try
            'Dim i As Integer = DgLecturas.CurrentRow.Index
            llenaGrid(DgLecturas, _Filtro)

            DgLecturas.Refresh()
            DgLecturas.Columns.Item(4).Width = 50
            DgLecturas.Columns.Item(7).Width = 50
            DgLecturas.Columns.Item(8).Width = 50
            DgLecturas.Columns.Item(9).Width = 50
            DgLecturas.Columns.Item(10).Width = 50
            DgLecturas.Columns.Item(11).Width = 50
            DgLecturas.Columns.Item(12).Width = 50
            'DgLecturas.SelectedCells(i)
            If DgLecturas.RowCount > 0 Then
                'DgLecturas.Item(0, intFilaSel).Selected = True
                DgLecturas.SelectedCells(intFilaSel).Selected = True
            End If
        Catch ex As Exception
            'llenaGrid(DgLecturas, _Filtro)
            'DgLecturas.Item(0, 1).Selected = True
        End Try
    End Sub

    Private Sub Lecturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lecturas.Click
        Try
            Dim fim As New frmVerLect

            'fim.cuenta = DgLecturas.Item(3, DgLecturas.CurrentRow.Index).Value
            fim.cuenta = DgLecturas.Item("CUENTA", DgLecturas.CurrentRow.Index).Value()
            fim.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbOp_ItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOp.ItemClick

    End Sub

    Private Sub btnvercalculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvercalculos.Click
        If btnvercalculos.Text = "Ver Calculos" Then
            Me.DgLecturas.Columns("montoconsumo").Visible = True
            Me.DgLecturas.Columns("montocobrado").Visible = True
            'DgLecturas.Columns("montoiva").Visible = True
            btnvercalculos.Text = "Ocultar calculos"
            'DgLecturas.Refresh()
        Else
            btnvercalculos.Text = "Ocultar calculos"
            DgLecturas.Columns("montoconsumo").Visible = False
            DgLecturas.Columns("montocobrado").Visible = False
            ' DgLecturas.Columns("montoiva").Visible = False
            btnvercalculos.Text = "Ver Calculos"
            'DgLecturas.Refresh()
        End If
        DgLecturas.Refresh()

    End Sub



    Private Sub DgLecturas_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DgLecturas.CellMouseDoubleClick
        Dim fim As New frmcontrato
        fim.idcomacargar = DgLecturas.Item(2, DgLecturas.CurrentRow.Index).Value
        fim.cuenta = DgLecturas.Item(1, DgLecturas.CurrentRow.Index).Value
        fim.mestado = frmcontrato.Estado.Visualizar
        fim.MdiParent = MDIPrincipal
        fim.Text = "Cotrato de la cuenta " & fim.cuenta
        fim.WindowState = FormWindowState.Normal
        fim.Show()
    End Sub
End Class