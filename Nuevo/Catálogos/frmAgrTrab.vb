Imports DevComponents.DotNetBar

Public Class frmAgrTrab

    Dim mtipo As Tipo
    Dim idtrab As Integer
    Dim rdtra As IDataReader

    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Property _idtrab() As Integer
        Get
            Return idtrab
        End Get
        Set(ByVal value As Integer)
            idtrab = value
            llenarCombo(cmbBrig, "select nobrig, descripcion from brigada order by descripcion")
            llenarCombo(cmbDep, "select cod_dep, nombre from deptos order by nombre")
            rdtra = ConsultaSql("select * from trabajadores where idtrab=" & idtrab & "").ExecuteReader()
            If rdtra.Read() Then
                txtId_Trab.Text = rdtra("idtrab")
                txtNombre.Text = rdtra("nombre")
                txtIden.Text = rdtra("nocred")
                txtCurp.Text = rdtra("curp")
                txtDir.Text = rdtra("direccion")
                txtCol.Text = rdtra("colonia")
                txtCom.Text = rdtra("comunidad")
                TxtTel.Text = rdtra("telefono")
                txtMov.Text = rdtra("movil")
                cmbBrig.SelectedValue = rdtra("nobrig")
                txtCargo.Text = rdtra("cargo")
                cmbDep.SelectedValue = rdtra("cod_dep")
            End If
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)

        InitializeComponent()
        mtipo = _mtipo
        llenarCombo(cmbBrig, "select nobrig, descripcion from brigada order by descripcion")
        llenarCombo(cmbDep, "select cod_dep, nombre from deptos order by nombre")
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click
        Dim ide As String = "", tel As String = "", mov As String = ""
        Dim id As Int16 = 0
        Dim valid As Object
        Dim cod_dep As String = ""

        Try
            valid = obtenerCampo("select max( cast(idtrab as signed)) as id from trabajadores", "id")
            If valid.ToString = "" Then
                id = 1
            Else
                id = Val(valid) + 1
            End If

        Catch err As Exception
            id = 1
        End Try

        If txtNombre.Text = "" Then
            MessageBoxEx.Show("Introduzca el nombre del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNombre.Select()
            Exit Sub
        End If

        If txtIden.Text <> "" Then
            ide = "'" & txtIden.Text & "'"
        Else
            ide = "''"
        End If

        If txtDir.Text = "" Then
            MessageBoxEx.Show("Introduzca la dirección del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDir.Select()
            Exit Sub
        End If

        If txtCol.Text = "" Then
            MessageBoxEx.Show("Introduzca la dirección la colonia del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCol.Select()
            Exit Sub
        End If

        If txtCom.Text = "" Then
            MessageBoxEx.Show("Introduzca la dirección la comunidad del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCom.Select()
            Exit Sub
        End If

        If TxtTel.Text <> "" Then
            tel = "'" & TxtTel.Text & "'"
        Else
            tel = "''"
        End If

        If txtMov.Text <> "" Then
            mov = "'" & txtMov.Text & "'"
        Else
            mov = "''"
        End If

        If cmbDep.Text = "" Then
            MessageBoxEx.Show("Introduzca el departamento del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbDep.Select()
            Exit Sub
        Else
            cod_dep = cmbDep.SelectedValue.ToString
        End If

        If cmbBrig.Text = "" Then
            MessageBoxEx.Show("Introduzca la brigada del Empleados", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbBrig.Select()
            Exit Sub
        End If

        If txtCargo.Text = "" Then
            MessageBoxEx.Show("Introduzca el cargo del Empleado", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCargo.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then
                Ejecucion("insert into trabajadores values(" & id & ",""" & txtNombre.Text & """," & ide & ",""" & txtCurp.Text & """,""" & txtDir.Text & """,""" & txtCol.Text & """,""" & txtCom.Text & """," & tel & "," & mov & ",'" & cmbBrig.SelectedValue.ToString & "',""" & txtCargo.Text & """,""" & cod_dep & """)")
            Else
                Ejecucion("update trabajadores set nombre=""" & txtNombre.Text & """, nocred=" & ide & ", curp=""" & txtCurp.Text & """, direccion=""" & txtDir.Text & """, colonia=""" & txtCol.Text & """, comunidad=""" & txtCom.Text & """, telefono=" & tel & ", movil=" & mov & ", nobrig='" & cmbBrig.SelectedValue.ToString & "', cargo=""" & txtCargo.Text & """, cod_dep=""" & cod_dep & """ where idtrab=" & txtId_Trab.Text & "")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBoxEx.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub cmdCance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCance.Click
        Me.Close()
    End Sub

    Private Sub txtId_Trab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId_Trab.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub txtNumBrig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub frmAgrTrab_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim keyascii As Keys = e.KeyData
        Select Case keyascii
            Case Keys.Enter
                SendKeys.Send("{TAB}")
        End Select
    End Sub


    Private Sub frmAgrTrab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Ver Then
            txtDir.ReadOnly = True
            txtCol.ReadOnly = True
            txtCom.ReadOnly = True
            txtId_Trab.ReadOnly = True
            txtCurp.ReadOnly = True
            txtIden.ReadOnly = True
            txtMov.ReadOnly = True
            txtNombre.ReadOnly = True
            cmbBrig.Enabled = False
            TxtTel.ReadOnly = True
            txtCargo.ReadOnly = True
            txtCol.ReadOnly = True
            cmbDep.Enabled = False
            cmdAcept.Visible = False
        End If
    End Sub

End Class