Imports DevComponents.DotNetBar

Public Class frmAgrDescuento
    Dim mtipo As Tipo
    Dim Id As String = ""
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum
    Public Property _Id() As String
        Get
            Return Id
        End Get
        Set(ByVal value As String)
            Id = value
        End Set
    End Property

    Public Sub New(ByVal _mtipo As Tipo)
        InitializeComponent()
        llenarCombo(cmbUniDesc, "SELECT idUnidadDscto,DscUnidadDscto FROM unidaddscto")
        mtipo = _mtipo
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub frmAgrDescuento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mtipo = Tipo.Ver Then
            txtDescripcion.Enabled = False
            txtPorcentaje.Enabled = False
            cmbUniDesc.Enabled = False
            cmdAcept.Visible = False
            cmdCance.Select()
        End If

        If mtipo = Tipo.Editar Then
            cmbUniDesc.Select()

        End If
        If mtipo = Tipo.Agregar Then


        End If
    End Sub

    Private Sub cmdAcept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAcept.Click

        If cmbUniDesc.Text = "" Then
            MessageBoxEx.Show("Selecciona la Unidad de Descuento", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmbUniDesc.Select()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MessageBoxEx.Show("Introduzca la Descripcion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Select()
            Exit Sub
        End If

        If txtPorcentaje.Text = "" Then
            MessageBoxEx.Show("Introduzca el Porcentaje", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPorcentaje.Select()
            Exit Sub
        End If

        Try
            If mtipo = Tipo.Agregar Then


                Ejecucion("insert into descuentos (xDescrip, nPctDsct, idUnidadDscto) values('" & txtDescripcion.Text & "','" & txtPorcentaje.Text & "','" & cmbUniDesc.SelectedValue & "')")

            Else
                Ejecucion("update descuentos set xDescrip='" & txtDescripcion.Text & "', nPctDsct='" & txtPorcentaje.Text & "', idUnidadDscto='" & cmbUniDesc.SelectedValue & "' where idDescuento='" & Id & "'")
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
End Class