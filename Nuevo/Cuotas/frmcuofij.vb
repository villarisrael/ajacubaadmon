Imports System.Data.Odbc
Imports DevComponents.DotNetBar

Public Class frmcuofij
    Private _tarifa As String

    Dim colec As New Collection
    Dim bs As New BindingSource
    Dim da As New OdbcDataAdapter

    Public Sub New(ByVal tarifa As String)
        InitializeComponent()
        _tarifa = tarifa
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub frmCuomed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        colec = llenaGrid(dgCuotas, " SELECT tarifa, periodo, sm, pago_agua, pago_alcant, saneamiento from cuofij where tarifa=""" & _tarifa & """ order by periodo desc")
        bs = colec(1)
        da = colec(2)
    End Sub


    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Try
            'bs.MoveFirst()
            'bs.MoveLast()
            da.Update(CType(bs.DataSource, DataTable))

        Catch ex As Exception
            MessageBox.Show("Los datos no guardados, verifique sus valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            colec = llenaGrid(dgCuotas, " SELECT tarifa, periodo, sm, pago_agua, pago_alcant, saneamiento from cuofij where tarifa=""" & _tarifa & """ order by periodo desc")
            bs = colec(1)
            da = colec(2)
            Exit Sub
        End Try
        MessageBox.Show("Datos guardados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub cmdAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnt.Click
        bs.MovePrevious()
    End Sub

    Private Sub cmdSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSig.Click
        bs.MoveNext()
    End Sub

    Private Sub cmdPrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrim.Click
        bs.MoveFirst()
    End Sub

    Private Sub cmdUlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUlt.Click
        bs.MoveLast()
    End Sub

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        'dgCuotas.AllowUserToAddRows = True
        'bs.MoveLast()
        Dim frmag As New frmagrcuofij
        frmag.tarifa = _tarifa
        frmag.ShowDialog()

        colec = llenaGrid(dgCuotas, " SELECT tarifa, periodo, sm, pago_agua, pago_alcant, saneamiento from cuofij where tarifa=""" & _tarifa & """ order by periodo desc")

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            ' da.Update(CType(bs.DataSource, DataTable))
            If MsgBox("¿Desea eliminar el periodo: ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Ejecucion("delete from cuofij where tarifa='" & dgCuotas.CurrentRow.Cells(0).Value & "' and periodo= " & dgCuotas.CurrentRow.Cells(1).Value & " ")
            End If
            colec = llenaGrid(dgCuotas, " SELECT tarifa, periodo, sm, pago_agua, pago_alcant, saneamiento from cuofij where tarifa=""" & _tarifa & """ order by periodo desc")
            bs = colec(1)
            da = colec(2)
        Catch ex As Exception
            MessageBoxEx.Show("No se pudo borrar el registro que solicitas")
        End Try
    End Sub

    Private Sub dgCuotas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuotas.CellEndEdit
        'Dim SALARIO As Double
        'SALARIO = obtenerCampo("SELECT SALARIO FROM EMPRESA LIMIT 1 ", "SALARIO")

        'Try


        '    If dgCuotas.Item("pago_agua", dgCuotas.CurrentRow.Index).Value < 0 Then
        '        MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Throw New Exception
        '    End If

        '    If dgCuotas.Item("pago_Alcant", dgCuotas.CurrentRow.Index).Value < 0 Then
        '        MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Throw New Exception
        '    End If
        '    If dgCuotas.Item("saneamiento", dgCuotas.CurrentRow.Index).Value < 0 Then
        '        MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Throw New Exception
        '    End If




        '    Try
        '        dgCuotas.Item("pago_agua", dgCuotas.CurrentRow.Index).Value = dgCuotas.Item("sm", dgCuotas.CurrentRow.Index).Value * SALARIO

        '    Catch ex As Exception

        '    End Try


        'Catch ex As Exception

        '    Exit Sub
        'End Try

    End Sub




    Private Sub dgCuotas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCuotas.DataError
        MessageBoxEx.Show("El dato no parece ser un numero, presione la tecla <ESC>")
    End Sub
End Class