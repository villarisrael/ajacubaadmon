Imports DevComponents.DotNetBar

Public Class FrmAgrRubro
    Dim mtipo As Tipo
    Enum Tipo
        Agregar
        Editar
        Ver
    End Enum

    Public Sub New(ByVal _mtipo As Tipo)
        mtipo = _mtipo
        InitializeComponent()
        ' llenarCombo(cmbComu, "select id_comunidad, comunidad from Comunidades")

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmAgrRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If mtipo <> Tipo.Agregar Then
            txtidrubro.Enabled = False
        End If
    End Sub

    Private Sub cmdAcept_Click(sender As Object, e As EventArgs) Handles cmdAcept.Click
        If txtidrubro.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la calle", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtidrubro.Select()
            Exit Sub
        End If

        If txtDescripcion.Text = "" Then
            MessageBoxEx.Show("Introduzca la clave de la calle", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescripcion.Select()
            Exit Sub
        End If
        Dim poner As Int16 = 0
        If chksistema.Checked Then
            poner = 1
        End If

        Try
            If mtipo = Tipo.Agregar Then
                If obtenerCampo("select count(*) as tot from rubros where  id_Rubro='" & txtidrubro.Text & "'", "tot") > 0 Then
                    MessageBoxEx.Show("EL RUBRO YA EXISTE, VERIFIQUE SUS DATOS POR FAVOR", "RUBROS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                Ejecucion("insert into  RUBROS ( ID_RUBRO,descripcion,sistema ) values ('" & txtidrubro.Text & "','" & txtDescripcion.Text & "'," & poner & ")")


            Else
                Ejecucion("update rubros set  Descripcion=""" & txtDescripcion.Text & """, sistema=" & poner & "  where id_Rubro=""" & txtidrubro.Text & """")
            End If
            MessageBoxEx.Show("Datos guardados exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch err As Exception
            MessageBox.Show("No se han guardado los datos verifique sus valores", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cmdCance_Click(sender As Object, e As EventArgs) Handles cmdCance.Click
        Close()
    End Sub
End Class