Public Class frmPerFiltro
    Protected _consulta As String
    Public Property consulta() As String
        Get
            Return _consulta
        End Get
        Set(ByVal value As String)
            _consulta = value
        End Set
    End Property
    Private Sub frmPerFiltro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCol.Items.Clear()
        ControlRob1.cmbCol.Items.Clear()
        listBase.Items.Clear()

        ControlRob1.Label1.Text = "Seleccione los campos de ordenamiento"
        llenarLista(cmbCol, "fields", "show columns from vusuario")
        llenarLista(ControlRob1.cmbCol, "fields", "show columns from vusuario")
        llenarLista(listBase, "fields", "show columns from vusuario")
        ControlRob1.cmdSig.Visible = False
        ControlRob1.tabu = Me.TabOp

        '*************************************
        cmbCol.Sorted = True
        ControlRob1.cmbCol.Sorted = True
        listBase.Sorted = True

    End Sub

    Private Sub cmdAgr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgr.Click
        Try
            cmbConsulta.Items.Add(cmbCol.SelectedItem)
            cmbCol.Items.Remove(cmbCol.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        Try
            cmbCol.Items.Add(cmbConsulta.SelectedItem)
            cmbConsulta.Items.Remove(cmbConsulta.SelectedItem)
            'cmbCol.Sorted = True
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para quitarlo de la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub cmdAgrT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrT.Click
        Try
            For i = 0 To cmbCol.Items.Count - 1
                cmbConsulta.Items.Add(cmbCol.Items(i))
            Next

            cmbCol.Items.Clear()

        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdQuitT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitT.Click
        Try
            For i = 0 To cmbConsulta.Items.Count - 1
                cmbCol.Items.Add(cmbConsulta.Items(i))
            Next

            cmbConsulta.Items.Clear()
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub cmdSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSig.Click
        TabOp.SelectNextTab()

    End Sub

    Private Sub cmdAgrFil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgrFil.Click
        Dim cont As Int16
        Try
            cont = listFil.Items.Count
            If listBase.SelectedItem <> "" Then
                Dim frm As New frmFil(listBase.SelectedItem, cont)
                frm.ShowDialog()
                listFil.Items.Add(frm.Cadena)
                'listBase.Items.Remove(listBase.SelectedItem)
            Else
                MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para agregarlo a la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        'cont += 1
    End Sub

    Private Sub cmdQuitFil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuitFil.Click
        Try
            'listBase.Items.Add(listFil.SelectedItem)
            listFil.Items.Remove(listFil.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Seleccione un campo para quitarlo de la consulta", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub cmdFin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFin.Click

    End Sub

    Private Sub cmdSig2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSig2.Click
        TabOp.SelectNextTab()
    End Sub

    Private Sub cmdAnt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnt.Click
        TabOp.SelectPreviousTab()
    End Sub

    Private Sub cmdTerminar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTerminar3.Click
        Dim camp As String = "", cadfil As String = "", cadord As String = ""

        For i = 0 To cmbConsulta.Items.Count - 1

            If cmbConsulta.Items.Count > 1 Then

                If i < cmbConsulta.Items.Count - 1 Then
                    camp &= String.Concat(cmbConsulta.Items(i).ToString, ",")
                Else
                    camp &= cmbConsulta.Items(i).ToString
                End If
            ElseIf cmbConsulta.Items.Count - 1 = 0 Then
                camp = cmbConsulta.Items(i).ToString
            End If
        Next

        If camp = "" Then
            camp = "cuenta as Cuenta, nombre as Nombre , comunidad as Comunidad, colonia as Colonia, Calle, numext as Número_exterior, numint as Número_interior"
        End If

        For i = 0 To listFil.Items.Count - 1
            If listFil.Items.Count > 1 Then
                If i < listFil.Items.Count - 1 Then
                    cadfil &= listFil.Items(i).ToString
                Else
                    cadfil &= listFil.Items(i).ToString
                End If
            ElseIf listFil.Items.Count - 1 = 0 Then
                cadfil = listFil.Items(i).ToString
            End If
        Next

        For i = 0 To ControlRob1.cmbConsulta.Items.Count - 1
            If ControlRob1.cmbConsulta.Items.Count > 1 Then

                If i < ControlRob1.cmbConsulta.Items.Count - 1 Then
                    cadord &= String.Concat(ControlRob1.cmbConsulta.Items(i).ToString, ",")
                Else
                    cadord &= ControlRob1.cmbConsulta.Items(i).ToString
                End If
            ElseIf ControlRob1.cmbConsulta.Items.Count - 1 = 0 Then
                cadord = ControlRob1.cmbConsulta.Items(i).ToString
            End If
        Next
        If cadord = "" Then
            cadord = "cuenta"
        End If


        If cadfil <> "" Then
            _consulta = String.Concat("Select ", camp, " from vusuario where ", cadfil, " order by ", cadord)
        Else
            _consulta = "Select " & camp & " from vusuario" & " order by " & cadord
        End If

        Me.Close()

    End Sub

End Class