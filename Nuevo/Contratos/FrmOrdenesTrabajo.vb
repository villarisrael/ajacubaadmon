Public Class FrmOrdenesTrabajo
    Enum Tareas
        CambioMedidor
        Instalacion
        Corte
        Baja
        Reinstalacion
    End Enum

    Private _Cuenta As Double, _Comunidad As String, _tarea As Tareas


#Region "Modificadores"

    Public Property Cuenta() As Double
        Get
            Return _Cuenta
        End Get
        Set(ByVal value As Double)
            _Cuenta = value
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

    Public Property Tarea() As Tareas
        Get
            Return _tarea
        End Get
        Set(ByVal value As Tareas)
            _tarea = value
        End Set
    End Property

#End Region

#Region "Constructores"

    Public Sub New(ByVal cue As Double, ByVal comu As String, ByVal tar As Tareas)
        InitializeComponent()
        _Cuenta = cue
        _Comunidad = comu
        _tarea = tar

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

#End Region

    Private Sub FrmOrdenesTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarCombo(CmbResponsable, "nombre", "Select nombre from trabajadores")
        Dim cons As IDataReader = ConsultaSql("Select * from vusuario where cuenta = " & _Cuenta & " and comunidad = '" & _Comunidad & "' ").ExecuteReader

        cons.Read()
        LblCuenta.Text = _Cuenta
        LblComunidad.Text = _Comunidad
        LblNombre.Text = cons("nombre")
        LblEstadoActual.Text = UCase(cons("estado"))
        LblDireccion.Text = cons("colonia") & "   " & cons("calle") & "  " & cons("numext") & "  " & cons("numint")
        LblGiro.Text = cons("giro")
        LblTarifa.Text = cons("descripcion_cuota")


        Select Case _tarea
            Case Tareas.Baja
                TxtTarea.Text = "Cuenta dada de baja temporal, realizar cierre de la toma"
            Case Tareas.CambioMedidor
                TxtTarea.Text = "Realizar el cambio de medidor"
            Case Tareas.Corte
                TxtTarea.Text = "Realizar corte de la toma"
            Case Tareas.Instalacion
                TxtTarea.Text = "Instalar la toma"
            Case Tareas.Reinstalacion
                TxtTarea.Text = "Reinstalar la toma"
        End Select


    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Select Case _tarea
            Case Tareas.CambioMedidor
                Dim fol As Double = obtenerCampo("select folordtrab + 1 as folio from empresa", "folio")
                Dim obs As String = ""
                Dim emp As Integer = obtenerCampo("select idtrab from trabajadores where nombre=""" & CmbResponsable.Text & """", "idtrab")

                If TxtTarea.Text = "" Then
                    MessageBox.Show("Especifique la tarea porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If TxtObservacion.Text <> "" Then
                    obs = "'" & TxtObservacion.Text & "'"
                Else
                    obs = "''"
                End If

                If CmbResponsable.Text = "" Then
                    MessageBox.Show("Establezca el nombre del responsable porfavor", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Ejecucion("insert into ordenestrabajo(clave, cuenta, comunidad, nombre, direccion, responsable, tarea, observacion,fecha) values(" & fol & "," & _Cuenta & ",'" & _Comunidad & "',""" & LblNombre.Text & """,""" & LblDireccion.Text & """,""" & emp & """,""" & _tarea.ToString & """," & obs & ",'" & UnixDateFormat(Now) & "')")

        End Select
        MessageBox.Show("Datos guardados satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Finalize()
    End Sub
End Class