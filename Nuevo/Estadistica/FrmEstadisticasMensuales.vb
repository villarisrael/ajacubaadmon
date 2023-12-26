Imports DevComponents.Schedule.Model

Public Class FrmEstadisticasMensuales

    Public Sub New()

        ' Llamada al método InitializeComponent para inicializar los componentes del formulario
        InitializeComponent()

        ConectarRemoto()

        txtComunidad.Text = ObtenerCampoBDRemoto($"SELECT COMUNIDAD FROM comunidades_bc WHERE ID = {My.Settings.IDComunidadSistema}", "COMUNIDAD")

        txtComunidad.Enabled = False


        CargarComboBoxPeriodo()

        CargarComboBoxMeses()

        ' Deshabilita el botón de maximizar (Maximizar)
        Me.MaximizeBox = False

        ' Deshabilita el botón de minimizar (Minimizar)
        Me.MinimizeBox = False

        ' Deshabilita los botones de cerrar (Cerrar)
        'Para obligar al usuario a ocupar el botón de "Cerrar" y no queden un proceso abierto de la aplicación
        Me.ControlBox = False

        ' 
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        Dim objCargarDatos As New CargarEstadisticas()


        ' Verificar qué RadioButton está seleccionado usando Select Case
        Select Case True
            Case RBNumTomas.Checked


                objCargarDatos.CargarInfNumeroTomas(txtComunidad.Text, CmbMeses.Text, CmbPeriodo.Text)

            Case RBNumDescargas.Checked

                objCargarDatos.CargarInfNumeroDescargas(txtComunidad.Text, CmbMeses.Text, CmbPeriodo.Text)

            Case RBVolServicio.Checked

                objCargarDatos.CargarInfVolumenServicio(txtComunidad.Text, CmbMeses.Text, CmbPeriodo.Text)

            Case RBAguaFacturada.Checked

                objCargarDatos.CargarInfConsumoFacturado(txtComunidad.Text, CmbMeses.Text, CmbPeriodo.Text)

            Case Else

                MessageBox.Show("NO HAS SELECCIONADO UNA OPCIÓN VÁLIDA")

        End Select

        DesconectarRemoto()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click

        DesconectarRemoto()
        Me.Close()

    End Sub

    Public Sub CargarComboBoxPeriodo()

        ' Obtenemos el año actual
        Dim currentYear As Integer = DateTime.Now.Year

        ' Definimos un rango de años (por ejemplo, 50 años hacia atrás desde el año actual)
        Dim startYear As Integer = currentYear - 50
        Dim endYear As Integer = currentYear

        ' Limpiamos el ComboBox
        CmbPeriodo.Items.Clear()

        ' Llenamos el ComboBox con los años
        For i As Integer = startYear To endYear
            CmbPeriodo.Items.Add(i.ToString())
        Next

        ' Opcional: seleccionar el año actual
        CmbPeriodo.SelectedItem = currentYear.ToString()

    End Sub

    Public Sub CargarComboBoxMeses()

        ' Arreglo con los nombres de los meses
        Dim months() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                              "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}

        ' Limpiamos el ComboBox
        CmbMeses.Items.Clear()

        ' Agregamos los nombres de los meses al ComboBox
        For Each monthName As String In months
            CmbMeses.Items.Add(monthName)
        Next

        ' Opcional: seleccionar el mes actual
        Dim currentMonth As Integer = DateTime.Now.Month
        CmbMeses.SelectedIndex = currentMonth - 1 ' Restamos 1 porque el ComboBox comienza desde el índice 0

    End Sub

End Class