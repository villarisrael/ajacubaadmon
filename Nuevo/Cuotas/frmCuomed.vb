Imports System.Data.Odbc
Imports DevComponents.DotNetBar

Public Class frmCuomed
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

        colec = llenaGrid(dgCuotas, " SELECT  id_tarifa, rango_sup, rango_inf,  vsm_agua,tarifa_agua,  anofiscal from medidor where id_tarifa=""" & _tarifa & """ and anofiscal= year(curdate()) order by rango_inf")
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
            colec = llenaGrid(dgCuotas, " SELECT id_tarifa, rango_sup, rango_inf, tarifa_agua,  vsm_agua,anofiscal from medidor where id_tarifa=""" & _tarifa & """ and anofiscal= year(curdate()) order by rango_inf")
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
        'bs.AddNew()
        'dgCuotas.Item(0, dgCuotas.CurrentRow.Index).Value = _tarifa
        Dim FRMCUAL As New FrmAgrcuo
        FRMCUAL.tarifa = _tarifa
        FRMCUAL.ShowDialog()
        colec = llenaGrid(dgCuotas, " SELECT id_tarifa, rango_sup, rango_inf,    vsm_agua,tarifa_agua,anofiscal  from medidor where id_tarifa=""" & _tarifa & """ and anofiscal= year(curdate()) order by rango_inf")

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            ' da.Update(CType(bs.DataSource, DataTable))
            If MsgBox("¿Desea eliminar el rango: ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Ejecucion("delete from medidor where id_tarifa='" & dgCuotas.CurrentRow.Cells(0).Value & "' and rango_inf= " & dgCuotas.CurrentRow.Cells(2).Value & " and rango_sup=" & dgCuotas.CurrentRow.Cells(1).Value & " and anofiscal= year(curdate())")
            End If
        Catch ex As Exception
            MessageBoxEx.Show("No se pudo borrar el registro que solicitas")
        End Try
    End Sub

    Private Sub dgCuotas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuotas.CellEndEdit
        Dim SALARIO As Double
        SALARIO = obtenerCampo("SELECT SALARIO FROM empresa LIMIT 1 ", "SALARIO")

        Try


            If dgCuotas.Item("Tarifa_agua_sm", dgCuotas.CurrentRow.Index).Value < 0 Then
                MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Throw New Exception
            End If

            'If dgCuotas.Item("Tarifa_alcanta_sm", dgCuotas.CurrentRow.Index).Value < 0 Then
            '    MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Throw New Exception
            'End If
            'If dgCuotas.Item("Tarifa_sanea_sm", dgCuotas.CurrentRow.Index).Value < 0 Then
            '    MessageBoxEx.Show("El total debe ser mayor o igual  0", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Throw New Exception
            'End If




            Try
                dgCuotas.Item("tarifa_agua", dgCuotas.CurrentRow.Index).Value = dgCuotas.Item("tarifa_agua_sm", dgCuotas.CurrentRow.Index).Value * SALARIO
                'dgCuotas.Item("tarifa_alcant", dgCuotas.CurrentRow.Index).Value = dgCuotas.Item("tarifa_alcanta_sm", dgCuotas.CurrentRow.Index).Value * SALARIO
                'dgCuotas.Item("tarifa_sanea", dgCuotas.CurrentRow.Index).Value = dgCuotas.Item("tarifa_sanea_sm", dgCuotas.CurrentRow.Index).Value * SALARIO
            Catch ex As Exception

            End Try


        Catch ex As Exception

            Exit Sub
        End Try

    End Sub




    Private Sub dgCuotas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgCuotas.DataError
        MessageBoxEx.Show("El dato no parece ser un numero, presione la tecla <ESC>")
    End Sub

    Private Sub dgCuotas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuotas.CellContentClick

    End Sub
End Class