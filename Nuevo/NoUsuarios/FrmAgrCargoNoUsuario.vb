Imports System.Math
Imports DevComponents.DotNetBar

Public Class FrmAgrCargoNoUsuario
    Private _Nuevo As Boolean
    Private _Num As Double
    Public cadena As String
    Public Property Num() As Double
        Get
            Return _Num
        End Get
        Set(ByVal value As Double)
            _Num = value
        End Set
    End Property
    Public Property Nuevo() As Boolean
        Get
            Return _Nuevo
        End Get
        Set(ByVal value As Boolean)
            _Nuevo = value
        End Set
    End Property

    Private Sub FrmAgrCargoNoUsuario_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        llenaporcadena()
    End Sub

    Private Sub FrmAgrCargoNoUsuario_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Sub FrmAgrCargoNoUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{TAB}")
        ElseIf e.KeyData = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub FrmAgrCargoNoUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenarCombo(CmbConceptos, "Select id_concepto, descripcion from conceptoscxc order by descripcion")
        Dim idr As IDataReader
        Dim even As eve = eve.Todos
        Dim conce As New conceptocxc
        idr = conce.conceptos(even)
        Me.AllowDrop = True
        Dim numero As Integer = 0
        Do While idr.Read()
            AdvTree1.Nodes.Add(New DevComponents.AdvTree.Node())
            AdvTree1.Nodes.Item(numero).Text = idr("descripcion")
            numero += 1
        Loop
        If _Nuevo = False Then
            Dim rs As IDataReader = ConsultaSql("select * from nousuarios where clave = " & Num & "").ExecuteReader
            rs.Read()
            Txtnombre.Text = rs("nombre")
            TxtComunidad.Text = rs("comunidad")
            TxtColonia.Text = rs("colonia")
            TxtDireccion.Text = rs("direccion")
            TxtNoExt.Text = rs("numext")
            TxtNoInt.Text = rs("numint")
            TxtTelefono.Text = rs("telefono")
            TxtCp.Text = rs("cp")
            TxtRfc.Text = rs("rfc")
            dgCob.Rows.Clear()
            rs.Close()
            rs = ConsultaSql("select * from conceptosnousuario where nousuario = " & _Num & "").ExecuteReader
            Do While rs.Read
                dgCob.Rows.Add(rs("id_concepto"), "", 1, rs("concepto"), rs("subtotal"), rs("iva"), rs("total"))
            Loop
            rs.Close()
        End If
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click

        If CmbConceptos.SelectedIndex = -1 Then
            MessageBoxEx.Show("No selecciono ningun concepto para agregar", "Agregar Concepto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CmbConceptos.Select()
            Exit Sub
        End If

        Dim icam As IDataReader
        Dim SubTot, Iva, Tot As Double
        icam = ConsultaSql("select tipo, descripcion, monto_inicial, aplicaiva from conceptoscxc where id_concepto='" & CmbConceptos.SelectedValue.ToString & "' ").ExecuteReader
        If icam.Read() Then
            If icam("AplicaIva") Then
                SubTot = Round(icam("monto_inicial"), 2)
                Iva = Round(SubTot * 0.16, 2)
                Tot = Round(SubTot + Iva, 2)
            Else
                SubTot = Round(icam("monto_inicial"), 2)
                Iva = Round(0, 2)
                Tot = Round(SubTot, 2)
            End If
            dgCob.Rows.Add(0, icam("Tipo"), 1, icam("Descripcion"), SubTot, Iva, Tot)
        End If
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim valida As String = obtenerCampo("select * from nousuarios where nombre = '" & Txtnombre.Text & "'", "nombre")
        If _Nuevo Then
            If valida <> "0" Then
                MessageBoxEx.Show("El nombre que intenta introducir ya esta registrado " & Chr(13) & "para agregarle un cargo eliga la opcion editar", "Usuarios No registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If Txtnombre.Text = "" Then

            MessageBoxEx.Show("Falta introducir el nombre, verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Txtnombre.Select()
            Exit Sub
        End If
        If TxtComunidad.Text = "" Then
            MessageBoxEx.Show("Falta introducir la comunidad, verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtComunidad.Select()
            Exit Sub
        End If
        If TxtColonia.Text = "" Then
            MessageBoxEx.Show("Falta introducir la colonia , verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtColonia.Select()
            Exit Sub
        End If
        If TxtDireccion.Text = "" Then
            MessageBoxEx.Show("Falta introducir la dirección, verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtDireccion.Select()
            Exit Sub
        End If
        If TxtNoExt.Text = "" Then
            MessageBoxEx.Show("Falta introducir el Numero Exterior, verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtNoExt.Select()
            Exit Sub
        End If
        If dgCob.RowCount = 0 Then
            'MessageBoxEx.Show("No agrego ningun cargo para el usuario, verifique sus datos", "Usuarios No Registrados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'CmbConceptos.Select()
            'Exit Sub
        Else
            cmdGuardar.Enabled = False
            Dim total As Double = 0
            Dim i As Integer = 0
            Dim bandera As Boolean = False
            For Each row In dgCob.Rows
                If dgCob.Rows(i).Cells("total").Value <= 0 Then
                    MessageBoxEx.Show("Total Invalido para el concepto " & dgCob.Rows(i).Cells(3).Value, " Usuarios No registrados", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cmdGuardar.Enabled = True
                    bandera = True
                End If
                i = i + 1
            Next
            If bandera = True Then
                Exit Sub
            End If
        End If

        Dim NumCon As Double
        If Nuevo = True Then
            Dim Cla As Double = Val(obtenerCampo("select max(clave) as cla from nousuarios", "cla")) + 1
            Ejecucion("insert into nousuarios (clave, nombre, comunidad, colonia, direccion, numext, numint, telefono, rfc, cp) values (" & Cla & ", '" & Txtnombre.Text & "', '" & TxtComunidad.Text & "', '" & TxtColonia.Text & "', '" & TxtDireccion.Text & "', '" & TxtNoExt.Text & "', '" & TxtNoInt.Text & "', '" & TxtTelefono.Text & "' , '" & TxtRfc.Text & "', '" & TxtCp.Text & "')")
            For i As Integer = 0 To dgCob.RowCount - 1
                NumCon = Val(obtenerCampo("select max(clave) as cla from conceptosnousuario", "cla")) + 1
                Ejecucion("insert into conceptosnousuario (clave, nousuario, concepto, subtotal, iva, total,id_concepto) values (" & NumCon & ", " & Cla & ", '" & dgCob.Item(3, i).Value & "', " & dgCob.Item(4, i).Value & ", " & dgCob.Item(5, i).Value & ", " & dgCob.Item(6, i).Value & ",'" & dgCob.Item(0, i).Value & "')")
            Next
            _Num = Cla
        Else
            Ejecucion("update nousuarios set  nombre = '" & Txtnombre.Text & "', comunidad = '" & TxtComunidad.Text & "', colonia = '" & TxtColonia.Text & "', direccion = '" & TxtDireccion.Text & "', numext = '" & TxtNoExt.Text & "', numint = '" & TxtNoInt.Text & "', telefono = '" & TxtTelefono.Text & "', cp = '" & TxtCp.Text & "', rfc = '" & TxtRfc.Text & "'  where clave = " & _Num & " ")
            Ejecucion("delete from conceptosnousuario where nousuario = " & _Num & "")
            For i As Integer = 0 To dgCob.RowCount - 1
                NumCon = Val(obtenerCampo("select max(clave) as cla from conceptosnousuario", "cla")) + 1
                Ejecucion("insert into conceptosnousuario (clave, nousuario, concepto, subtotal, iva, total,id_concepto) values (" & NumCon & ", " & _Num & ", '" & dgCob.Item(3, i).Value & "', " & dgCob.Item(4, i).Value & ", " & dgCob.Item(5, i).Value & ", " & dgCob.Item(6, i).Value & ",'" & dgCob.Item(0, i).Value & "')")
            Next
            NumCon = Val(obtenerCampo("select count(clave) as cla from conceptosnousuario", "cla"))
            If NumCon > 0 Then
                Ejecucion("update nousuarios set activo=1 where clave = " & _Num & " ")
            End If
        End If
        MessageBoxEx.Show("Datos guardados satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmdGuardar.Enabled = False
        FrmListadoNoUsuario.CatControl1.Actualizar()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub dgCob_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCob.CellEndEdit
        Dim iv As Boolean = False
        If CBool(obtenerCampo("select aplicaiva from conceptoscxc where id_concepto='" & dgCob.Item("Clave", dgCob.CurrentRow.Index).Value & "'", "aplicaiva")) = True Then iv = True Else iv = False

        Dim miva As New Collection
        Dim tot As Double
        Try
            tot = dgCob.Item("Total", dgCob.CurrentRow.Index).Value
            'dgCob.Item("Total", dgCob.CurrentRow.Index).Value = tot
            If tot < 0 Then Throw New Exception

            Dim tieneiva As Integer = obtenerCampo("select aplicaiva from conceptoscxc where id_concepto='" & dgCob.Item("clave", dgCob.CurrentRow.Index).Value & "'", "aplicaiva")
            If tieneiva = 1 Then
                miva = regIva(tot, iv)
                dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = miva.Item(1)
                dgCob.Item("iva", dgCob.CurrentRow.Index).Value = miva.Item(2)
            Else

                dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = tot
                dgCob.Item("iva", dgCob.CurrentRow.Index).Value = 0
            End If
        Catch ex As Exception
            MessageBoxEx.Show("Valor incorrecto", "No usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            dgCob.Item("Total", dgCob.CurrentRow.Index).Value = 0
            miva = regIva(tot, iv)
            dgCob.Item("subTot", dgCob.CurrentRow.Index).Value = miva.Item(1)
            dgCob.Item("iva", dgCob.CurrentRow.Index).Value = miva.Item(2)
        End Try
    End Sub

    Private Sub TxtCp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCp.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub CmbConceptos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbConceptos.KeyPress
        DespliegaCombo(CmbConceptos, e)
    End Sub

    Private Sub CmbConceptos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbConceptos.LostFocus
        BtnAgregar.Select()
    End Sub

    Private Sub AdvTree1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles AdvTree1.DragEnter
        cadena = AdvTree1.SelectedNode.SelectedCell.Text
    End Sub
    Public Sub llenaporcadena()
        Dim icam As IDataReader

        Dim SubTot, Iva, Tot As Double
        icam = ConsultaSql("select id_concepto,tipo, descripcion, monto_inicial, aplicaiva from conceptoscxc where descripcion='" & cadena & "' ").ExecuteReader
        If icam.Read() Then
            If icam("AplicaIva") Then
                SubTot = Round(icam("monto_inicial"), 2)
                Iva = Round(SubTot * 0.16, 2)
                Tot = Round(SubTot + Iva, 2)
            Else
                SubTot = Round(icam("monto_inicial"), 2)
                Iva = Round(0, 2)
                Tot = Round(SubTot, 2)
            End If
            dgCob.Rows.Add(icam("id_concepto"), icam("Tipo"), 1, icam("Descripcion"), SubTot, Iva, Tot)
        End If

    End Sub

    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        Try
            If MessageBoxEx.Show("¿Desea quitar el concepto " & dgCob.Item(3, dgCob.CurrentRow.Index).Value & "?", "No Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dgCob.Rows.Remove(dgCob.CurrentRow)
            End If
        Catch ex As Exception
            MessageBoxEx.Show("No se puede eliminar el concepto dado que no tiene seleccionado ninguno", "No Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub



    Private Sub dgCob_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgCob.DragDrop
        llenaporcadena()

    End Sub

    Private Sub dgCob_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles dgCob.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub
    Public Sub inhabilitar()
        Txtnombre.Enabled = False
        TxtColonia.Enabled = False
        TxtComunidad.Enabled = False
        TxtDireccion.Enabled = False
        TxtNoExt.Enabled = False
        TxtRfc.Enabled = False
        TxtTelefono.Enabled = False
        TxtCp.Enabled = False
        TxtNoInt.Enabled = False
        cmdGuardar.Enabled = False
        BtnQuitar.Visible = False
        GroupPanel2.Visible = False
        GroupPanel1.Visible = False
        dgCob.Enabled = False
        Me.ExpandablePanel1.Visible = False
        Me.AllowDrop = False
    End Sub

End Class