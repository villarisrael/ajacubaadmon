Imports DevComponents.DotNetBar

Public Class catControl
    Private intFilaSel As Integer
    Private consulta As String
    Private frm As Form
    Private so As New BindingSource
    Private vista As DataView
    Private catalogo As Catalogos
    Private conbus As String = ""
    Private Frmb As frmBusCat
    Private frmb2 As frmBusCat2
    Private Tabla As String
    Private _campos As String = ""


    Enum Catalogos
        Abonos
        Municipios
        Comunidades
        Colonias
        Calles
        EstadosToma
        Sector
        Ruta
        Solicitud
        Requerimientos
        Algoritmos
        Trabajadores
        ListaCambioMedidor
        Departamentos
        Factibilidad
        Region
        Multas
        Situaciones
        EstadosLec
        MarcasMedidor
        DiamTom
        FormaServicio
        FormasPagos
        Giros
        TipoServicio
        TiposUsuario
        OrdenTrab
        NoUsuarios
        Convenios
        Brigada
        Direccion
        ConceptosCis
        Fuentes
        VerLect
        ConceptosCxc
        Users
        Cuotas
        Ajustes
        CatalogosCajas
        CatalogosOficinas
        CorrRec
        Recibos
        matcalle
        ubicacionmedidor

        Descuentos
        Rubros
    End Enum


#Region "Modificadores"
    'Public Property Asc() As DataGridViewAutoSizeColumnMode
    '    Get
    '        Return dgDAt.AutoSizeColumnsMode
    '    End Get
    '    Set(ByVal value As DataGridViewAutoSizeColumnMode)
    '        dgDAt.AutoSizeColumnsMode = value

    '    End Set
    'End Property
    Public Property seleccionMultiple() As Boolean
        Get
            Return dgDAt.MultiSelect()
        End Get
        Set(ByVal value As Boolean)
            dgDAt.MultiSelect = value
        End Set
    End Property
    Public Property _consulta() As String
        Get
            Return consulta
        End Get
        Set(ByVal value As String)
            consulta = value
        End Set
    End Property
    Public Property _frm() As Form
        Get
            Return frm
        End Get
        Set(ByVal value As Form)
            frm = value
        End Set
    End Property
    Public Property _catalogo() As Catalogos
        Get
            Return catalogo
        End Get
        Set(ByVal value As Catalogos)
            catalogo = value
        End Set
    End Property
    Public Property _Tabla() As String
        Get
            Return Tabla
        End Get
        Set(ByVal value As String)
            Tabla = value
        End Set
    End Property
    Public Property Campos() As String
        Get
            Return _campos
        End Get
        Set(ByVal value As String)
            _campos = value

        End Set
    End Property

#End Region

    Public Sub filtrar(ByVal sql As String)
        'llenaGrid(dgDAt, sql)
        so.Filter = Nothing
        consulta = sql
        vista = llenarVista(sql)
        so.DataSource = vista
        dgDAt.DataSource = so
        dgDAt.Refresh()
        If darNumReg() > 0 Then
            Try
                dgDAt.Item(0, intFilaSel).Selected = True
            Catch ex As Exception

            End Try

        End If

    End Sub

    Public Sub Salir()
        frm.Close()
    End Sub

    'Public Sub Buscar()
    '    Try
    '        Dim mens As String = "Introduzca el campo: " & dgDAt.Columns.Item(dgDAt.CurrentCell.ColumnIndex).Name
    '        Dim frmb As New frmBusCat(dgDAt.Columns.Item(dgDAt.CurrentCell.ColumnIndex).DataPropertyName, so, mens, dgDAt.Item(dgDAt.CurrentCell.ColumnIndex, dgDAt.CurrentRow.Index).Value)
    '        frmb.ShowDialog()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Public Sub Eliminar()
        Try
            If MessageBoxEx.Show("¿Desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Select Case catalogo
                    Case Catalogos.Comunidades
                        Ejecucion("delete  from comunidades where id_comunidad=""" & dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value & """")
                    Case Catalogos.Municipios
                        Ejecucion("delete  from municipios where clave=""" & dgDAt.Item("Id_Municipio", dgDAt.CurrentRow.Index).Value & """")
                    Case Catalogos.Colonias
                        Ejecucion("delete  from colonia where id_colonia=""" & dgDAt.Item("Id_Colonia", dgDAt.CurrentRow.Index).Value & """")
                    Case Catalogos.Calles
                        Ejecucion("delete  from calles where id_calle=""" & dgDAt.Item("ID_CALLE", dgDAt.CurrentRow.Index).Value & """")
                    Case Catalogos.EstadosToma
                        Ejecucion("delete  from estadotoma where clave=""" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & """")
                    Case Catalogos.Sector
                        Ejecucion("delete from sectores where clavesec = '" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.Ruta
                        Dim sec As String = obtenerCampo("Select id_region from region where region = '" & dgDAt.Item("Región", dgDAt.CurrentRow.Index).Value & "'", "id_region")
                        Ejecucion("delete from rutas where id_region = '" & sec & "' and id_ruta = '" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "' ")
                    Case Catalogos.Trabajadores
                        Ejecucion("delete from trabajadores where idtrab=" & dgDAt.Item("id_Trabajador", dgDAt.CurrentRow.Index).Value & "")
                    Case Catalogos.Departamentos
                        Ejecucion("delete from deptos where cod_dep='" & dgDAt.Item("Código_departamento", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.Region
                        Dim idcomu As String = obtenerCampo("select id_Comunidad from comunidades where comunidad='" & dgDAt.Item("Comunidad", dgDAt.CurrentRow.Index).Value & "'", "id_comunidad")
                        Ejecucion("delete from region where id_region='" & dgDAt.Item("Clave_región", dgDAt.CurrentRow.Index).Value & "' and id_Comunidad='" & idcomu & "'")
                    Case Catalogos.Situaciones
                        Ejecucion("delete from situacion where clave='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.Algoritmos
                        Ejecucion("delete from algoritmos where clave=" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "")
                    Case Catalogos.MarcasMedidor
                        Ejecucion("delete from marcasmedidor where id_marca=" & dgDAt.Item("Id_Marca", dgDAt.CurrentRow.Index).Value & "")
                    Case Catalogos.DiamTom
                        Ejecucion("delete from diametros where id_diametro='" & dgDAt.Item("Id_Diametro", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.FormaServicio
                        Ejecucion("delete from formas_Servicio where id_forma_servicio='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.FormasPagos
                        Ejecucion("delete from fpago where ccodpago='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.Giros
                        Ejecucion("delete from giro where codgir='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.TipoServicio
                        Ejecucion("delete from tipos_servicio where id_tipo_servicio='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "' and id_tipo_usuario='" & obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion='" & dgDAt.Item("Tipo_Usuario", dgDAt.CurrentRow.Index).Value & "'", "id_tipo_usuario") & "'")
                    Case Catalogos.TiposUsuario
                        Ejecucion("delete from tipos_usuarios where id_tipo_usuario='" & dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.OrdenTrab
                        Ejecucion("delete from ordent where folio=" & dgDAt.Item("Folio", dgDAt.CurrentRow.Index).Value & "")
                    Case Catalogos.Brigada
                        Ejecucion("delete from brigada where nobrig='" & dgDAt.Item("Número_Brigada", dgDAt.CurrentRow.Index).Value & "'")
                    Case Catalogos.matcalle
                        Ejecucion("delete from mat_calle where id_matcalle=" & dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value)
                    Case Catalogos.ubicacionmedidor
                        Ejecucion("delete from ub_medidor where id_ubmedidor=" & dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value)

                    Case Catalogos.Descuentos
                        Ejecucion("delete from descuentos where idDescuento=" & dgDAt.Item("ID", dgDAt.CurrentRow.Index).Value)
                    Case Catalogos.Rubros
                        Ejecucion("delete from rubros where id_rubro='" & dgDAt.Item(0, dgDAt.CurrentRow.Index).Value & "'")
                End Select
                filtrar(consulta)
                MessageBox.Show("Registro borrado permanentemente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Agregar()
        Try
            Select Case catalogo
                Case Catalogos.Comunidades
                    Dim frma As New frmAgrComu(frmAgrComu.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Municipios
                    Dim frma As New frmAgrMuni(frmAgrComu.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Colonias
                    Dim frma As New frmAgrCol(frmAgrComu.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Calles
                    Dim frma As New frmAgrCalle(frmAgrComu.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.EstadosToma
                    Dim frma As New frmAgrEstTom(frmAgrComu.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Sector
                    Dim frma As New FrmAgrSector(FrmAgrSector.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Ruta
                    Dim frma As New FrmAgrRuta(FrmAgrRuta.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Trabajadores
                    Dim frma As New frmAgrTrab(FrmAgrRuta.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Departamentos
                    Dim frma As New frmAgrDepa(frmAgrDepa.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Region
                    Dim frma As New frmAgrReg(frmAgrReg.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Situaciones
                    Dim frma As New frmAgrSit(frmAgrSit.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Algoritmos
                    Dim frma As New frmAgrAlg(frmAgrAlg.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.MarcasMedidor
                    Dim frma As New frmAgrMarMed(frmAgrMarMed.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.DiamTom
                    Dim frma As New frmAgrDiam(frmAgrDiam.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.FormaServicio
                    Dim frma As New frmAgrForSer(frmAgrForSer.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.FormasPagos
                    Dim frma As New frmAgrFpag(frmAgrFpag.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Giros
                    Dim frma As New frmAgrGir(frmAgrGir.Tipo.Agregar)
                    frma.ShowDialog()
                    'Case Catalogos.TipoServicio
                    'Dim frma As New frmAgrTipSer(frmAgrTipSer.Tipo.Agregar)
                    'frma.ShowDialog()
                Case Catalogos.TiposUsuario
                    Dim frma As New frmAgrTipUsu(frmAgrTipUsu.Tipo.Agregar)
                    frma.ShowDialog()

                Case Catalogos.NoUsuarios
                    Dim frma As New FrmAgrCargoNoUsuario
                    'frma.MdiParent = My.Forms.MDIPrincipal
                    frma.Nuevo = True
                    frma.StartPosition = FormStartPosition.CenterScreen
                    frma.ShowDialog()

                Case Catalogos.OrdenTrab
                    Dim frma As New frmAgrOrd(0, frmAgrOrd._tipo.Agregar)
                    ' frma.MdiParent = My.Forms.MDIPrincipal
                    frma.WindowState = FormWindowState.Normal
                    frma.ShowDialog()
                Case Catalogos.Brigada
                    Dim frma As New frmAgrCatBrig(frmAgrCatBrig.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Direccion
                    Dim frma As New frmAgrDir(frmAgrDir.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.ConceptosCis
                    Dim frma As New frmAgrConcepCis(frmAgrConcepCis.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Fuentes
                    Dim frma As New frmAgrFuen(frmAgrFuen.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.ConceptosCxc
                    Dim frma As New frmAgrCxC(frmAgrCxC.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Users
                    Dim frm As New FrmAgrUser
                    frm.Modo = FrmAgrUser.Tipo.Nuevo
                    frm.ShowDialog()
                Case Catalogos.CatalogosCajas
                    Dim frma As New frmAgrCaj(frmAgrCaj.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.CatalogosOficinas
                    Dim frma As New frmAgrOfi(frmAgrOfi.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.matcalle
                    Dim frma As New frmAgrmatcalle(frmAgrmatcalle.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.ubicacionmedidor
                    Dim frma As New frmagrubmedidor(frmagrubmedidor.Tipo.Agregar)
                    frma.ShowDialog()
                Case Catalogos.Descuentos
                    Dim frma As New frmAgrDescuento(frmAgrDescuento.Tipo.Agregar)
                    frma.ShowDialog()

                Case Catalogos.Rubros
                    Dim FRMAGRRUB As New FrmAgrRubro(FrmAgrRubro.Tipo.Agregar)
                    FRMAGRRUB.ShowDialog()
            End Select
            filtrar(consulta)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub dgDAt_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDAt.CellEndEdit
        Dim idusu As IDataReader = Nothing
        Dim med As Boolean = False
        Dim iva As Boolean = False
        Dim reca As Boolean = False
        Dim min As Double = 0
        '*********************
        If IsDBNull(dgDAt.Item(e.ColumnIndex, e.RowIndex).Value) Then
            dgDAt.Item(e.ColumnIndex, e.RowIndex).Value = 0
        End If
        '********************

    End Sub
    Public Sub Editar()
        Try
            Select Case catalogo
                Case Catalogos.Comunidades
                    Dim frma As New frmAgrComu(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value
                    frma.txtId_com.Text = dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value
                    frma.txtCont.Text = dgDAt.Item("Folio_de_Contrato", dgDAt.CurrentRow.Index).Value
                    frma.txtNomCom.Text = dgDAt.Item("comunidad", dgDAt.CurrentRow.Index).Value
                    frma.cmbMuni.Text = dgDAt.Item("Municipio", dgDAt.CurrentRow.Index).Value
                    frma.txtId_com.ReadOnly = True
                    frma.ShowDialog()
                Case Catalogos.Municipios
                    Dim frma As New frmAgrMuni(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Id_Municipio", dgDAt.CurrentRow.Index).Value
                    frma.txtId_clave.Text = dgDAt.Item("Id_Municipio", dgDAt.CurrentRow.Index).Value
                    frma.txtNomMun.Text = dgDAt.Item("Municipio", dgDAt.CurrentRow.Index).Value
                    frma.txtId_clave.ReadOnly = True
                    frma.ShowDialog()
                Case Catalogos.Colonias
                    Dim frma As New frmAgrCol(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Id_Colonia", dgDAt.CurrentRow.Index).Value
                    frma.txtId_col.Text = dgDAt.Item("Id_Colonia", dgDAt.CurrentRow.Index).Value
                    frma.txtnomCol.Text = dgDAt.Item("Colonia", dgDAt.CurrentRow.Index).Value

                    frma.txtId_col.ReadOnly = True
                    ' frma.cmbComu.Enabled = False

                    If Not IsDBNull(dgDAt.Item("Cp", dgDAt.CurrentRow.Index).Value) Then
                        frma.txtcp.Text = dgDAt.Item("Cp", dgDAt.CurrentRow.Index).Value
                    Else
                        frma.txtcp.Text = ""
                    End If
                    frma.ShowDialog()
                Case Catalogos.Calles
                    Dim frma As New frmAgrCalle(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("ID_CALLE", dgDAt.CurrentRow.Index).Value
                    frma.txtId_calle.Text = dgDAt.Item("ID_CALLE", dgDAt.CurrentRow.Index).Value


                    frma.txtNomCall.Text = dgDAt.Item("Calle", dgDAt.CurrentRow.Index).Value
                    frma.txtId_calle.Enabled = False

                    'frma.cmbComu.Enabled = False
                    frma.ShowDialog()
                    frma.ShowDialog()
                Case Catalogos.Sector
                    Dim frma As New FrmAgrSector(FrmAgrSector.Tipo.Editar)
                    frma.Clave = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Ruta
                    Dim frma As New FrmAgrRuta(FrmAgrRuta.Tipo.Editar)
                    frma.Clave = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value

                    frma.Sector = obtenerCampo("Select id_region from region where region = '" & dgDAt.Item("Región", dgDAt.CurrentRow.Index).Value & "' ", "id_region")
                    frma.ShowDialog()
                Case Catalogos.Region
                    Dim frma As New frmAgrReg(frmAgrReg.Tipo.Editar)
                    frma._idreg = dgDAt.Item("Clave_región", dgDAt.CurrentRow.Index).Value

                    frma.ShowDialog()
                Case Catalogos.Giros
                    Dim frma As New frmAgrGir(frmAgrGir.Tipo.Editar)
                    frma._idGir = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.EstadosToma
                    Dim frma As New frmAgrEstTom(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtId_est.Text = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtDescrip.Text = dgDAt.Item("Descripción", dgDAt.CurrentRow.Index).Value
                    'frma.cpEst.SelectedColor = obtenerCampo("select cfondo from estadotoma where clave=" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & "", "cfondo").ToString
                    frma.chkMostrar.Checked = CBool(obtenerCampo("select mostrar from estadotoma where clave=" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & "", "mostrar"))
                    frma.ShowDialog()
                Case Catalogos.Solicitud
                    Dim solicita As New Frmsolicitud
                    solicita.Nuevo = False
                    solicita.Clave = dgDAt.Item("Numero", dgDAt.CurrentRow.Index).Value
                    'Reg = dgDAt.SelectedRows.Item(0).Index
                    'My.Forms.MDIPrincipal.txtsolicitud.Text = My.Forms.MDIPrincipal.txtnumerodesolicitud.TextBox.Text
                    solicita.Text = "Solicitud " & dgDAt.Item("Numero", dgDAt.CurrentRow.Index).Value
                    solicita.MdiParent = My.Forms.MDIPrincipal
                    'My.Forms.MDIPrincipal.btnconvierteacontrato.Enabled = False
                    solicita.Show()
                    solicita.WindowState = FormWindowState.Maximized
                Case Catalogos.Trabajadores
                    Dim frma As New frmAgrTrab(frmAgrTrab.Tipo.Editar)
                    frma._idtrab = dgDAt.Item("id_Trabajador", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Departamentos
                    Dim frma As New frmAgrDepa(frmAgrDepa.Tipo.Editar)
                    frma._idres = dgDAt.Item("Código_departamento", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Situaciones
                    Dim frma As New frmAgrSit(frmAgrSit.Tipo.Editar)
                    frma._idSit = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Algoritmos
                    Dim frma As New frmAgrAlg(frmAgrAlg.Tipo.Editar)
                    frma._idAlg = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.MarcasMedidor
                    Dim frma As New frmAgrMarMed(frmAgrMarMed.Tipo.Editar)
                    frma._idmar = dgDAt.Item("Id_Marca", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.DiamTom
                    Dim frma As New frmAgrDiam(frmAgrDiam.Tipo.Editar)
                    frma._iddia = dgDAt.Item("Id_Diametro", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.FormaServicio
                    Dim frma As New frmAgrForSer(frmAgrForSer.Tipo.Editar)
                    frma._idSer = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.FormasPagos
                    Dim frma As New frmAgrFpag(frmAgrFpag.Tipo.Editar)
                    frma._idFp = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.TiposUsuario
                    Dim frma As New frmAgrTipUsu(frmAgrTipUsu.Tipo.Editar)
                    frma._idusu = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.NoUsuarios
                    Dim frmagr As New FrmAgrCargoNoUsuario
                    frmagr.Nuevo = False
                    frmagr.Num = dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()

                Case Catalogos.OrdenTrab
                    Dim frmagr As New frmAgrOrd(dgDAt.Item("Folio", dgDAt.CurrentRow.Index).Value, frmAgrOrd._tipo.Editar)
                    'frmagr.MdiParent = My.Forms.MDIPrincipal
                    frmagr.ShowDialog()
                    frmagr.WindowState = FormWindowState.Normal
                Case Catalogos.Direccion
                    Dim frma As New frmAgrDir(frmAgrDir.Tipo.Editar)
                    frma._idres = dgDAt.Item("Codigo_Direccion", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.ConceptosCis
                    Dim frma As New frmAgrConcepCis(frmAgrConcepCis.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Fuentes
                    Dim frmagr As New frmAgrFuen(frmAgrFuen.Tipo.Editar)
                    frmagr._idcom = dgDAt.Item("ID_Fuente", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()
                Case Catalogos.Brigada
                    Dim frmagr As New frmAgrCatBrig(frmAgrCatBrig.Tipo.Editar)
                    frmagr._idcom = dgDAt.Item("Número_Brigada", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()
                Case Catalogos.EstadosToma
                    Dim frma As New frmAgrEstTom(frmAgrComu.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtId_est.Text = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtDescrip.Text = dgDAt.Item("Descripción", dgDAt.CurrentRow.Index).Value
                    'frma.cpEst.SelectedColor = obtenerCampo("select cfondo from estadotoma where clave=" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & "", "cfondo").ToString
                    frma.chkMostrar.Checked = CBool(obtenerCampo("select mostrar from estadotoma where clave=" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & "", "mostrar"))
                    frma.ShowDialog()
                Case Catalogos.Solicitud
                    Dim solicita As New Frmsolicitud
                    solicita.Nuevo = False
                    solicita.Clave = dgDAt.Item("Numero", dgDAt.CurrentRow.Index).Value
                    'Reg = dgDAt.SelectedRows.Item(0).Index
                    'My.Forms.MDIPrincipal.txtsolicitud.Text = My.Forms.MDIPrincipal.txtnumerodesolicitud.TextBox.Text
                    solicita.Text = "Solicitud " & dgDAt.Item("Numero", dgDAt.CurrentRow.Index).Value
                    solicita.MdiParent = My.Forms.MDIPrincipal
                    'My.Forms.MDIPrincipal.btnconvierteacontrato.Enabled = False
                    solicita.Show()
                    solicita.WindowState = FormWindowState.Maximized
                Case Catalogos.Trabajadores
                    Dim frma As New frmAgrTrab(frmAgrTrab.Tipo.Editar)
                    frma._idtrab = dgDAt.Item("id_Trabajador", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Departamentos
                    Dim frma As New frmAgrDepa(frmAgrDepa.Tipo.Editar)
                    frma._idres = dgDAt.Item("Código_departamento", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Situaciones
                    Dim frma As New frmAgrSit(frmAgrSit.Tipo.Editar)
                    frma._idSit = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Algoritmos
                    Dim frma As New frmAgrAlg(frmAgrAlg.Tipo.Editar)
                    frma._idAlg = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.MarcasMedidor
                    Dim frma As New frmAgrMarMed(frmAgrMarMed.Tipo.Editar)
                    frma._idmar = dgDAt.Item("Id_Marca", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.DiamTom
                    Dim frma As New frmAgrDiam(frmAgrDiam.Tipo.Editar)
                    frma._iddia = dgDAt.Item("Id_Diametro", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.FormaServicio
                    Dim frma As New frmAgrForSer(frmAgrForSer.Tipo.Editar)
                    frma._idSer = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.FormasPagos
                    Dim frma As New frmAgrFpag(frmAgrFpag.Tipo.Editar)
                    frma._idFp = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.TiposUsuario
                    Dim frma As New frmAgrTipUsu(frmAgrTipUsu.Tipo.Editar)
                    frma._idusu = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.NoUsuarios
                    Dim frmagr As New FrmAgrCargoNoUsuario
                    frmagr.Nuevo = False
                    frmagr.Num = dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()

                Case Catalogos.OrdenTrab
                    Dim frmagr As New frmAgrOrd(dgDAt.Item("Folio", dgDAt.CurrentRow.Index).Value, frmAgrOrd._tipo.Editar)
                    'frmagr.MdiParent = My.Forms.MDIPrincipal
                    frmagr.ShowDialog()
                    frmagr.WindowState = FormWindowState.Maximized
                Case Catalogos.Direccion
                    Dim frma As New frmAgrDir(frmAgrDir.Tipo.Editar)
                    frma._idres = dgDAt.Item("Codigo_Direccion", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.ConceptosCis
                    Dim frma As New frmAgrConcepCis(frmAgrConcepCis.Tipo.Editar)
                    frma._idcom = dgDAt.Item("Codigo_Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Fuentes
                    Dim frmagr As New frmAgrFuen(frmAgrFuen.Tipo.Editar)
                    frmagr._idcom = dgDAt.Item("ID_Fuente", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()
                Case Catalogos.Brigada
                    Dim frmagr As New frmAgrCatBrig(frmAgrCatBrig.Tipo.Editar)
                    frmagr._idcom = dgDAt.Item("Numero_Brigada", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()
                Case Catalogos.ConceptosCxc
                    Dim frma As New frmAgrCxC(frmAgrCxC.Tipo.Editar, dgDAt.Item("Id_Concepto", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.Users
                    Dim frm As New FrmAgrUser
                    frm.Modo = FrmAgrUser.Tipo.Edicion
                    frm.Numero = dgDAt.Item("Ccodusuario", dgDAt.CurrentRow.Index).Value
                    frm.ShowDialog()
                Case Catalogos.CatalogosCajas
                    Dim frma As New frmAgrCaj(frmAgrCaj.Tipo.Editar, dgDAt.Item("CLAVE", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.CatalogosOficinas
                    Dim frma As New frmAgrOfi(frmAgrOfi.Tipo.Editar, dgDAt.Item("CLAVE", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.matcalle
                    Dim frma As New frmAgrmatcalle(frmAgrmatcalle.Tipo.Editar)
                    frma._idGir = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.ubicacionmedidor
                    Dim frma As New frmagrubmedidor(frmagrubmedidor.Tipo.Editar)
                    frma._idGir = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Descuentos
                    Dim frma As New frmAgrDescuento(frmAgrDescuento.Tipo.Editar)
                    frma._Id = dgDAt.Item("ID", dgDAt.CurrentRow.Index).Value
                    frma.cmbUniDesc.Text = dgDAt.Item("UNIDAD", dgDAt.CurrentRow.Index).Value
                    frma.txtDescripcion.Text = dgDAt.Item("DESCRIPCION", dgDAt.CurrentRow.Index).Value
                    frma.txtPorcentaje.Text = dgDAt.Item("PORCENTAJE", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Rubros
                    Dim frma As New FrmAgrRubro(frmAgrDescuento.Tipo.Editar)
                    frma.txtidrubro.Text = dgDAt.Item("ID_RUBRO", dgDAt.CurrentRow.Index).Value
                    frma.txtDescripcion.Text = dgDAt.Item(1, dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
            End Select
            filtrar(consulta)
        Catch ex As Exception
            Dim errorme As String = ex.Message
        End Try
    End Sub
    Public Sub Resultado()
        Select Case catalogo
            Case Catalogos.OrdenTrab
                Dim frmagr As New frmAgrOrd(dgDAt.Item("Folio", dgDAt.CurrentRow.Index).Value, frmAgrOrd._tipo.Resultado)
                'frmagr.MdiParent = My.Forms.MDIPrincipal
                frmagr.ShowDialog()
                frmagr.WindowState = FormWindowState.Normal
        End Select
    End Sub
    Public Sub Visualizar()
        Try
            Select Case catalogo
                Case Catalogos.OrdenTrab
                    Dim frmagr As New frmAgrOrd(dgDAt.Item("Folio", dgDAt.CurrentRow.Index).Value, frmAgrOrd._tipo.Verificar)
                    'frmagr.MdiParent = My.Forms.MDIPrincipal
                    frmagr.ShowDialog()
                    frmagr.WindowState = FormWindowState.Normal
                Case Catalogos.Calles
                    Dim frma As New frmAgrCalle(frmAgrCalle.Tipo.Ver)
                    frma._idcom = dgDAt.Item("ID_CALLE", dgDAt.CurrentRow.Index).Value
                    frma.txtId_calle.Text = dgDAt.Item("ID_CALLE", dgDAt.CurrentRow.Index).Value
                    '.SelectedValue = dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value

                    frma.txtNomCall.Text = dgDAt.Item("Calle", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Colonias
                    Dim frma As New frmAgrCol(frmAgrCol.Tipo.Ver)
                    frma._idcom = dgDAt.Item("Id_Colonia", dgDAt.CurrentRow.Index).Value
                    frma.txtId_col.Text = dgDAt.Item("Id_Colonia", dgDAt.CurrentRow.Index).Value
                    frma.txtnomCol.Text = dgDAt.Item("Colonia", dgDAt.CurrentRow.Index).Value

                    'frma.txtcp.Text = dgDAt.Item("Cp", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Comunidades
                    Dim frma As New frmAgrComu(frmAgrComu.Tipo.Ver)
                    frma._idcom = dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value
                    frma.txtId_com.Text = dgDAt.Item("id_comunidad", dgDAt.CurrentRow.Index).Value
                    frma.txtCont.Text = dgDAt.Item("Folio_de_Contrato", dgDAt.CurrentRow.Index).Value
                    frma.txtNomCom.Text = dgDAt.Item("comunidad", dgDAt.CurrentRow.Index).Value
                    frma.cmbMuni.Text = dgDAt.Item("Municipio", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.ConceptosCis
                    Dim frma As New frmAgrConcepCis(frmAgrConcepCis.Tipo.Ver)
                    frma._idcom = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Departamentos
                    Dim frma As New frmAgrDepa(frmAgrDepa.Tipo.Ver)
                    frma._idres = dgDAt.Item("Código_Departamento", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.DiamTom
                    Dim frma As New frmAgrDiam(frmAgrDiam.Tipo.Ver)
                    frma._iddia = dgDAt.Item("id_diametro", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Brigada
                    Dim frma As New frmAgrCatBrig(frmAgrCatBrig.Tipo.Ver)
                    frma._idcom = dgDAt.Item("Número_Brigada", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Direccion
                    Dim frma As New frmAgrDir(frmAgrDir.Tipo.Ver)
                    frma._idres = dgDAt.Item("Codigo_Direccion", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.EstadosToma
                    Dim frma As New frmAgrEstTom(frmAgrEstTom.Tipo.Ver)
                    frma._idcom = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtId_est.Text = dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value
                    frma.txtDescrip.Text = dgDAt.Item("Descripción", dgDAt.CurrentRow.Index).Value
                    frma.chkMostrar.Checked = CBool(obtenerCampo("select mostrar from estadotoma where clave=" & dgDAt.Item("Clave_Estado", dgDAt.CurrentRow.Index).Value & "", "mostrar"))
                    frma.ShowDialog()
                Case Catalogos.FormaServicio
                    Dim frma As New frmAgrForSer(frmAgrForSer.Tipo.Ver)
                    frma._idSer = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.FormasPagos
                    Dim frma As New frmAgrFpag(frmAgrFpag.Tipo.Ver)
                    frma._idFp = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Fuentes
                    Dim frma As New frmAgrFuen(frmAgrFuen.Tipo.Ver)
                    frma._idcom = dgDAt.Item("id_fuente", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Giros
                    Dim frma As New frmAgrGir(frmAgrGir.Tipo.Ver)
                    frma._idGir = dgDAt.Item("Descripción", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.MarcasMedidor
                    Dim frma As New frmAgrMarMed(frmAgrMarMed.Tipo.Ver)
                    frma._idmar = dgDAt.Item("id_marca", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Municipios
                    Dim frma As New frmAgrMuni(frmAgrMuni.Tipo.Ver)
                    frma._idcom = dgDAt.Item("Municipio", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Region
                    Dim frma As New frmAgrReg(frmAgrReg.Tipo.Ver)
                    frma._idreg = dgDAt.Item("Región", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Sector
                    Dim frma As New FrmAgrSector(FrmAgrSector.Tipo.Ver)
                    frma.Clave = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Situaciones
                    Dim frma As New frmAgrSit(frmAgrSit.Tipo.Ver)
                    frma._idSit = dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                    'Case Catalogos.TipoServicio
                    '    Dim frma As New frmAgrTipSer(frmAgrTipSer.Tipo.Ver)
                    '    frma._idSer = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    '    frma._idusu = dgDAt.Item("Tipo_Usuario", dgDAt.CurrentRow.Index).Value
                    '    frma.ShowDialog()
                Case Catalogos.TiposUsuario
                    Dim frma As New frmAgrTipUsu(frmAgrTipUsu.Tipo.Ver)
                    frma._idusu = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Trabajadores
                    Dim frma As New frmAgrTrab(frmAgrTrab.Tipo.Ver)
                    frma._idtrab = dgDAt.Item("id_Trabajador", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.Ruta
                    Dim frma As New FrmAgrRuta(FrmAgrRuta.Tipo.Ver)
                    frma.Clave = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.id_comunidad = obtenerCampo("Select Id_Comunidad from comunidades where Comunidad = '" & dgDAt.Item("Comunidad", dgDAt.CurrentRow.Index).Value & "' ", "Id_comunidad")
                    frma.Sector = obtenerCampo("Select id_region from region where region = '" & dgDAt.Item("Región", dgDAt.CurrentRow.Index).Value & "' ", "id_region")
                    frma.ShowDialog()
                Case Catalogos.Algoritmos
                    Dim frma As New frmAgrAlg(frmAgrAlg.Tipo.Ver)
                    frma._idAlg = dgDAt.Item("Clave", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()
                Case Catalogos.ConceptosCxc
                    Dim frma As New frmAgrCxC(frmAgrCxC.Tipo.Ver, dgDAt.Item("Id_Concepto", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.Users
                    Dim frm As New FrmAgrUser
                    frm.Modo = FrmAgrUser.Tipo.Vizualizar
                    frm.Numero = dgDAt.Item("Ccodusuario", dgDAt.CurrentRow.Index).Value
                    frm.ShowDialog()
                Case Catalogos.CatalogosCajas
                    Dim frma As New frmAgrCaj(frmAgrCaj.Tipo.Ver, dgDAt.Item("CLAVE", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.CatalogosOficinas
                    Dim frma As New frmAgrOfi(frmAgrOfi.Tipo.Ver, dgDAt.Item("CLAVE", dgDAt.CurrentRow.Index).Value)
                    frma.ShowDialog()
                Case Catalogos.Situaciones
                    Dim frma As New frmAgrSit(frmAgrSit.Tipo.Ver)
                    frmAgrSit.ShowDialog()

                Case Catalogos.NoUsuarios
                    Dim frmagr As New FrmAgrCargoNoUsuario
                    frmagr.Nuevo = False
                    frmagr.Num = dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value
                    frmagr.inhabilitar()
                    frmagr.ShowDialog()
                Case Catalogos.Descuentos
                    Dim frma As New frmAgrDescuento(frmAgrDescuento.Tipo.Ver)
                    frma.cmbUniDesc.Text = dgDAt.Item("UNIDAD", dgDAt.CurrentRow.Index).Value
                    frma.txtDescripcion.Text = dgDAt.Item("DESCRIPCION", dgDAt.CurrentRow.Index).Value
                    frma.txtPorcentaje.Text = dgDAt.Item("PORCENTAJE", dgDAt.CurrentRow.Index).Value
                    frma.ShowDialog()


                         'frma.ShowDialog()
                Case Catalogos.Rubros
                    Dim frma As New FrmAgrRubro(frmAgrDescuento.Tipo.Ver)
                    frma.txtidrubro.Text = dgDAt.Item("ID_RUBRO", dgDAt.CurrentRow.Index).Value
                    frma.txtDescripcion.Text = dgDAt.Item("DESCRIPCION", dgDAt.CurrentRow.Index).Value
                    'pendiente
            End Select
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Imprimir(Optional ByVal orden As String = "")
        Dim frmrep As frmReporte = Nothing
        Try
            Select Case catalogo
                Case Catalogos.Comunidades
                    frmrep = New frmReporte(frmReporte.Lista.Comunidades, "")
                Case Catalogos.Colonias
                    frmrep = New frmReporte(frmReporte.Lista.Colonias, "")
                Case Catalogos.Sector
                    frmrep = New frmReporte(frmReporte.Lista.Sector, "")
                Case Catalogos.Calles
                    frmrep = New frmReporte(frmReporte.Lista.Calles, "")
                Case Catalogos.Ruta
                    frmrep = New frmReporte(frmReporte.Lista.Ruta, "")
                Case Catalogos.Trabajadores
                    frmrep = New frmReporte(frmReporte.Lista.Empleados, "")
                Case Catalogos.Departamentos
                    frmrep = New frmReporte(frmReporte.Lista.Departamentos, "")
                Case Catalogos.Algoritmos
                    frmrep = New frmReporte(frmReporte.Lista.Algoritmos, "")
                Case Catalogos.MarcasMedidor
                    frmrep = New frmReporte(frmReporte.Lista.MarMedidor, "")
                Case Catalogos.DiamTom
                    frmrep = New frmReporte(frmReporte.Lista.DiametroToma, "")
                Case Catalogos.Situaciones
                    frmrep = New frmReporte(frmReporte.Lista.Situaciones, "")
                Case Catalogos.FormasPagos
                    frmrep = New frmReporte(frmReporte.Lista.formasPago, "")
                Case Catalogos.Giros
                    frmrep = New frmReporte(frmReporte.Lista.Giro, "")
                Case Catalogos.FormaServicio
                    frmrep = New frmReporte(frmReporte.Lista.FormasServ, "")
                Case Catalogos.FormasPagos
                    frmrep = New frmReporte(frmReporte.Lista.FormasServ, "")
                Case Catalogos.Departamentos
                    frmrep = New frmReporte(frmReporte.Lista.Departamentos, "")
                Case Catalogos.Brigada
                    frmrep = New frmReporte(frmReporte.Lista.Brigada, "")
                Case Catalogos.Direccion
                    frmrep = New frmReporte(frmReporte.Lista.Direccion, "")
                Case Catalogos.Municipios
                    frmrep = New frmReporte(frmReporte.Lista.Municipios, "")
                Case Catalogos.Trabajadores
                    frmrep = New frmReporte(frmReporte.Lista.Empleados, "")
                Case Catalogos.ConceptosCis
                    frmrep = New frmReporte(frmReporte.Lista.ConceptosCIS, "")
                Case Catalogos.Fuentes
                    frmrep = New frmReporte(frmReporte.Lista.Fuentes, "")
                Case Catalogos.MarcasMedidor
                    frmrep = New frmReporte(frmReporte.Lista.MarMedidor, "")
                Case Catalogos.TiposUsuario
                    frmrep = New frmReporte(frmReporte.Lista.TipoUsuario, "")
                Case Catalogos.EstadosToma
                    frmrep = New frmReporte(frmReporte.Lista.EstadoTomas, "")
                Case Catalogos.Situaciones
                    frmrep = New frmReporte(frmReporte.Lista.Situaciones, "")
                Case Catalogos.Cuotas
                    frmrep = New frmReporte(frmReporte.Lista.Cuotas, "")
                Case Catalogos.Region
                    frmrep = New frmReporte(frmReporte.Lista.Region, "")
                Case Catalogos.TipoServicio
                    frmrep = New frmReporte(frmReporte.Lista.TipoServicio, "")
                Case Catalogos.ConceptosCxc
                    frmrep = New frmReporte(frmReporte.Lista.catCxc, "")
                    frmrep.Text = "Catálogo de Conceptos cxc"
                Case Catalogos.CatalogosCajas
                    frmrep = New frmReporte(frmReporte.Lista.reporteCajas, "")
                    frmrep.Text = "Catálogo de Cajas"
                Case Catalogos.CatalogosOficinas
                    frmrep = New frmReporte(frmReporte.Lista.Oficinas, "")
                    frmrep.Text = "Catálogo de Oficinas"

                Case Catalogos.ubicacionmedidor
                    frmrep = New frmReporte(frmReporte.Lista.Ubicacionmedidor, "")
                    frmrep.Text = "Catálogo de Ubicacion de medidor"

                Case Catalogos.matcalle
                    frmrep = New frmReporte(frmReporte.Lista.MaterialCalles, "")
                    frmrep.Text = "Catálogo de Material de Calles"

                Case Catalogos.Descuentos
                    frmrep = New frmReporte(frmReporte.Lista.Descuentos, "")
                    frmrep.Text = "Catálogo de Descuentos"

                Case Catalogos.NoUsuarios
                    Dim frmagr As New FrmAgrCargoNoUsuario
                    frmagr.Nuevo = False
                    frmagr.Num = dgDAt.Item("clave", dgDAt.CurrentRow.Index).Value
                    frmagr.ShowDialog()
                    frmagr.inhabilitar()

            End Select
            frmrep.MdiParent = My.Forms.MDIPrincipal
            frmrep.Show()
            frmrep.WindowState = FormWindowState.Maximized
        Catch
            MessageBoxEx.Show("El reporte no está disponible por el momento", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub dgDAt_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgDAt.CellFormatting
        If catalogo = Catalogos.Solicitud Or catalogo = Catalogos.Factibilidad Then
            If dgDAt.Item("Estado", e.RowIndex).Value = "APROBADA" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.ForestGreen
            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "RECHAZADA" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Orange
            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "EN PROCESO" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.FloralWhite
            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "CANCELADA" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Red
            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "CONTRATADA" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.RoyalBlue
            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "PENDIENTE" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.White
            End If
        End If

        If catalogo = Catalogos.Multas Then
            Try
                If dgDAt.Item("Estado", e.RowIndex).Value = "Pendiente" Then
                    dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.ForestGreen
                ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "Cancelado" Then
                    dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Red
                ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "Aplicada" Then
                    dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Yellow
                End If
            Catch ex As Exception

            End Try

        End If

        'If catalogo = Catalogos.OrdenTrab Then
        '    If dgDAt.Item("Estado", e.RowIndex).Value = "E" Then
        '        dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Green
        '    ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "P" Then
        '        dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Yellow
        '    End If
        'End If

        If catalogo = Catalogos.OrdenTrab Then
            If dgDAt.Item("Estado", e.RowIndex).Value = "1" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Yellow
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Yellow
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Yellow

            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "2" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Green
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Green
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Green

            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "3" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Blue
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Blue
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Blue

            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "4" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Orange
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Orange
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Orange

            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "5" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Red
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Red
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Red

            ElseIf dgDAt.Item("Estado", e.RowIndex).Value = "CANCELADA" Then
                dgDAt.Item("Estado", e.RowIndex).Style.BackColor = Color.Red
                dgDAt.Item("Estado", e.RowIndex).Style.ForeColor = Color.Yellow
                dgDAt.Item("Estado", e.RowIndex).Style.SelectionForeColor = Color.Yellow

            End If
        End If


    End Sub

    Public Function darSeleccionado(ByVal campo As String) As Object
        Try
            Return dgDAt.Item(campo, dgDAt.CurrentRow.Index).Value
        Catch ex As Exception
            MessageBoxEx.Show("NO SE ENCONTRÓ LA COLUMNA " & campo & "", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "0"
        End Try

    End Function

    Private Sub dgDAt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDAt.Click
        If catalogo = Catalogos.Factibilidad OrElse catalogo = Catalogos.Solicitud Then
            If dgDAt.Item("Estado", dgDAt.CurrentRow.Index).Value = "APROBADA" Then
                My.Forms.frmListFacti.cmdConvCont.Enabled = True
                My.Forms.frmListSoli.cmdConvCont.Enabled = True
            Else
                My.Forms.frmListFacti.cmdConvCont.Enabled = False
                My.Forms.frmListSoli.cmdConvCont.Enabled = False

            End If
        End If
        'If catalogo = Catalogos.Factibilidad Then
        '    If dgDAt.Item("Estado", dgDAt.CurrentRow.Index).Value = "APROBADA" Then
        '        My.Forms.frmListFacti.cmdConvCont.Enabled = True
        '    Else
        '        My.Forms.frmListFacti.cmdConvCont.Enabled = False
        '    End If
        'End If
    End Sub

    Private Sub dgDAt_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDAt.DoubleClick
        'If catalogo = Catalogos.OrdenTrab Then
        '    Visualizar()
        'End If
    End Sub

    Public Function darNumReg() As Double
        Return dgDAt.RowCount
    End Function

    Public Sub Siguiente()
        so.MoveNext()
    End Sub

    Public Sub Anterior()
        so.MovePrevious()
    End Sub

    Public Sub Primero()
        so.MoveFirst()
    End Sub

    Public Sub Último()
        so.MoveLast()
    End Sub

    Public Sub Actualizar()
        filtrar(consulta)
    End Sub

    Public Function darConsu() As String
        Return conbus
    End Function

    Public Sub Buscar(Optional ByVal enMemoria As Boolean = True)
        Try
            If enMemoria Then
                Dim mens As String = "Introduzca el campo: " & dgDAt.Columns.Item(dgDAt.CurrentCell.ColumnIndex).Name
                Frmb = New frmBusCat(dgDAt.Columns.Item(dgDAt.CurrentCell.ColumnIndex).DataPropertyName, so, mens, dgDAt.Item(dgDAt.CurrentCell.ColumnIndex, dgDAt.CurrentRow.Index).Value)
                Frmb.ShowDialog()
                conbus = Frmb.darCad()
            Else
                frmb2 = New frmBusCat2(dgDAt.Columns.Item(dgDAt.CurrentCell.ColumnIndex).DataPropertyName, _Tabla, _campos, dgDAt.Item(dgDAt.CurrentCell.ColumnIndex, dgDAt.CurrentRow.Index).Value)
                frmb2.ShowDialog()

                If frmb2.cadSql <> "" Then
                    filtrar(frmb2.cadSql)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub buscar(ByVal campo As String, ByVal busqueda As String)
        Try
            so.Filter = campo & " like '%" & busqueda & "%'"
        Catch ex As Exception
            If busqueda <> "" Then
                so.Filter = campo & " = " & busqueda
            Else
                so.Filter = campo & " > 0"
            End If
        End Try
    End Sub
    Public Sub Posicionar(ByVal textobus As String, ByVal campo As String)
        so.Position = so.Find(campo, textobus)
    End Sub

    Private Sub dgDAt_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDAt.MouseCaptureChanged
        Dim i As Int16 = 0, j As Int16 = 0
        Dim anfi As String = "" 'VALOR DE CELDA ANFITRÍON
        Dim idusu As IDataReader = Nothing
        Dim drenaje As Double = 0
        Dim med As Boolean = False, iva As Boolean
        Dim reca As Boolean = False
        Dim min As Double = 0

        If dgDAt.AreAllCellsSelected(False) Then
            Exit Sub
        End If


    End Sub

    Private Sub dgDAt_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDAt.CellClick
        intFilaSel = e.RowIndex
    End Sub
    Public Sub limpiar()
        dgDAt.DataSource = Nothing
    End Sub
    Public Function Mínimo(ByVal Campo As String) As Double
        Dim donde As String = ""
        Dim constem As String = UCase(consulta)

        If constem = "" Then
            Return 0
        Else
            If constem.Contains("FROM") Then
                donde = Mid(constem, constem.IndexOf("FROM"), constem.Length)
            Else
                Return 0
            End If
        End If
        Try
            Return obtenerCampo("select min(" & Campo & ") as m " & donde, "m")
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function Máximo(ByVal Campo As String) As Double
        Dim donde As String = ""
        Dim constem As String = UCase(consulta)

        If constem = "" Then
            Return 0
        Else
            If constem.Contains("FROM") Then
                donde = Mid(constem, constem.IndexOf("FROM"), constem.Length)
            Else
                Return 0
            End If
        End If
        Try
            Return obtenerCampo("select max(" & Campo & ") as m " & donde, "m")
        Catch ex As Exception
            Return 0
        End Try
    End Function

    'Private Sub catControl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    Dim keyascii As Keys = e.KeyData

    '    Select Case keyascii
    '        Case Keys.Enter
    '            SendKeys.Send("{TAB}")
    '    End Select
    'End Sub
End Class

