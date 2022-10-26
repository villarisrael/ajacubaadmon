Imports DevComponents.DotNetBar

Public Class frmConscuotas
    Protected _idtar As String
    Protected rstar As IDataReader
    Dim Agr As Boolean
    Public Sub New()
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal idtar As String)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        'AdvTree2.Nodes.Item(1).Expand()
        'AdvTree2.Nodes.Item(2).Collapse()
        'AdvTree2.Nodes.Item(3).Collapse()
        'AdvTree2.Nodes.Item(4).Collapse()
        'AdvTree2.Nodes.Item(5).Collapse()

        Agr = False

        Id_Tipo_ServicioTextBox.Text = idtar
        _idtar = idtar
        rstar = ConsultaSql("select * from cuotas where id_Tarifa='" & idtar & "'").ExecuteReader

        llenarCombo(cmbtipousuario, "select id_tipo_usuario, descripcion from tipo_usuarios")
        If rstar.Read() Then
            DescripciónTextBox.Text = rstar("descripcion_cuota")


            '  cmbtipousuario.Text = obtenerCampo("select descripcion from tipos_usuarios where id_tipo_usuario=""" & rstar("parauso") & """ ", "descripcion")
            If rstar("MEDIDO") Then
                TipmedidoCheckBox.Checked = True
                TipfijoCheckBox.Checked = False
                '    AdvTree2.Nodes(1).Nodes(0).Visible = False

                txtconsumo.Value = rstar("consumomin")
                txtalertalecturas.Value = rstar("altcap")
                'AdvTree2.Nodes(2).Expand()
                'AdvTree2.Nodes(1).Collapse()
            Else
                TipmedidoCheckBox.Checked = False
                TipfijoCheckBox.Checked = True
                '   AdvTree2.Nodes(1).Nodes(1).Visible = False

                txtconsumo.Value = 0
                txtalertalecturas.Value = 0
                'AdvTree2.Nodes(1).Expand()
                'AdvTree2.Nodes(2).Collapse()
            End If

            'Alcantarillado

            AlcantarilladoCheckBox.Checked = rstar("alcantarillado")
            If rstar("alcantarillado") Then
                PoralcCheckBox.Checked = rstar("alcapporc")
                CantalcCheckBox.Checked = rstar("alcapcuo")

                If rstar("alcapporc") Then
                    '     AdvTree2.Nodes(2).Nodes(1).Visible = False
                    txtporalcanta.Value = rstar("PorcAlca")
                    txtcuomensualalcantarillado.Value = 0
                Else
                    '      AdvTree2.Nodes(2).Nodes(0).Visible = False
                    txtcuomensualalcantarillado.Value = rstar("alcacuo")


                    divsmdren.Value = rstar("vsmdren")


                    txtporalcanta.Value = 0
                End If
            Else
                ' AdvTree2.Nodes(2).Visible = False
                PoralcCheckBox.Checked = False
                CantalcCheckBox.Checked = False
                txtporalcanta.Value = 0
                txtcuomensualalcantarillado.Value = 0
            End If

            'Saneamiento
            SaneamientoCheckBox.Checked = rstar("saneacuo")
            If rstar("saneacuo") Then
                PorsanCheckBox.Checked = rstar("sanepporc")
                CantsanCheckBox.Checked = rstar("sanepcuo")


                If rstar("sanepporc") Then
                    '    AdvTree2.Nodes(3).Nodes(1).Visible = False
                    porcsaneamiento.Value = rstar("porcsanea")
                    txtcatidadmonetariasaneamiento.Value = 0
                Else
                    '   AdvTree2.Nodes(3).Nodes(0).Visible = False
                    porcsaneamiento.Value = 0
                    txtcatidadmonetariasaneamiento.Value = rstar("sanecuo")
                    DIsane.Value = rstar("vsmsane")
                End If

            Else
                ' AdvTree2.Nodes(3).Visible = False
                PorsanCheckBox.Checked = False
                CantsanCheckBox.Checked = False

                porcsaneamiento.Value = 0
                txtcatidadmonetariasaneamiento.Value = 0
            End If


            'Recargos
            RecargoCheckBox.Checked = rstar("recargos")
            If rstar("recargos") Then
                RecargoconsumoCheckBox.Checked = rstar("recasocon")
                RecargosobretodoCheckBox.Checked = rstar("recasotod")

                porcreca.Value = rstar("porcrec")
            Else
                ' AdvTree2.Nodes(4).Visible = False
                RecargoconsumoCheckBox.Checked = False
                RecargosobretodoCheckBox.Checked = False
                porcreca.Value = 0
            End If

            IvaCheckBox.Checked = rstar("iva")

            If rstar("iva") Then
                IvaconsumoCheckBox.Checked = rstar("ivaacon")
                IvaalcantarilladoCheckBox.Checked = rstar("ivaalca")
                IvasaneamientoCheckBox.Checked = rstar("ivasane")
                'IvarecargoCheckBox.Checked = rstar("ivareca")
                'txtiva.Value = rstar("porciva")
            Else
                'AdvTree2.Nodes(5).Visible = False
                IvaconsumoCheckBox.Checked = False
                IvaalcantarilladoCheckBox.Checked = False
                IvasaneamientoCheckBox.Checked = False
                'IvarecargoCheckBox.Checked = False
                'txtiva.Value = 0

            End If

            cmbtipousuario.SelectedValue = rstar("parauso")

            txtmequiv.Value = rstar("mCubEquiv")


            cmbAlgoritmos.SelectedIndex = rstar("memoria")


            ' pro_anual.Value = rstar("pro_anual")
        Else
            MessageBox.Show("Registro no encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiaCtrl()
        End If


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
#Region "Modificadores"
    Public Property id_tar() As String
        Get
            Return _idtar
        End Get
        Set(ByVal value As String)
            _idtar = value
        End Set
    End Property
#End Region
    Private Sub TipfijoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipfijoCheckBox.CheckedChanged
        If TipfijoCheckBox.Checked = True Then
            TipmedidoCheckBox.Checked = False
            txtalertalecturas.Value = 0
            txtconsumo.Value = 0
        End If
        If TipfijoCheckBox.Checked = False Then
            TipmedidoCheckBox.Checked = True
        End If
    End Sub

    Private Sub TipmedidoCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipmedidoCheckBox.CheckedChanged
        If TipmedidoCheckBox.Checked = True Then
            TipfijoCheckBox.Checked = False

            txtalertalecturas.Value = 0
        End If
        If TipmedidoCheckBox.Checked = False Then
            TipfijoCheckBox.Checked = True
        End If
    End Sub

    Private Sub PoralcCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PoralcCheckBox.CheckedChanged
        If PoralcCheckBox.Checked = True Then
            CantalcCheckBox.Checked = False
            txtcuomensualalcantarillado.Value = 0
        End If
        If PoralcCheckBox.Checked = False Then
            CantalcCheckBox.Checked = True
        End If
    End Sub

    Private Sub CantalcCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CantalcCheckBox.CheckedChanged
        If CantalcCheckBox.Checked = True Then
            PoralcCheckBox.Checked = False
            txtporalcanta.Value = 0
        End If
        If CantalcCheckBox.Checked = False Then
            PoralcCheckBox.Checked = True
        End If
    End Sub

    Private Sub PorsanCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorsanCheckBox.CheckedChanged
        If PorsanCheckBox.Checked = True Then
            Me.CantsanCheckBox.Checked = False
            txtcatidadmonetariasaneamiento.Value = 0
        End If
        If PorsanCheckBox.Checked = False Then
            Me.CantsanCheckBox.Checked = True
        End If
    End Sub

    Private Sub CantsanCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CantsanCheckBox.CheckedChanged
        If CantsanCheckBox.Checked = True Then
            PorsanCheckBox.Checked = False
            porcsaneamiento.Value = 0
        End If
        If CantsanCheckBox.Checked = False Then
            PorsanCheckBox.Checked = True
        End If
    End Sub



    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        'Dim param As String = obtenerCampo("select id_tipo_usuario from tipos_usuarios where descripcion=""" & cmbtipousuario.Text & """ ", "id_tipo_usuario")
        If cmbtipousuario.Text = "" Then
            MessageBoxEx.Show("Especifique el tipo de usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Agr = False Then
            Ejecucion("update cuotas  set descripcion_cuota= """ &
                           DescripciónTextBox.Text & """,consumomin='" & txtconsumo.Value & "' ,medido=" & TipmedidoCheckBox.Checked & ", alcantarillado=" & AlcantarilladoCheckBox.Checked & ", saneacuo=" & SaneamientoCheckBox.Checked & ", recargos=" & RecargoCheckBox.Checked & ", iva=" & IvaCheckBox.Checked & ", porcalca=" & txtporalcanta.Value & ", porcrec=" & porcreca.Value & ", porcsanea=" & porcsaneamiento.Value & ", altcap=" &
                           txtalertalecturas.Value & ", sanepporc=" & PorsanCheckBox.Checked & ", sanepcuo=" & CantsanCheckBox.Checked & ", sanecuo=" & txtcatidadmonetariasaneamiento.Value & ", recasocon=" & RecargoconsumoCheckBox.Checked & ", recasotod=" & RecargosobretodoCheckBox.Checked & ", ivaacon=" & IvaconsumoCheckBox.Checked & ", ivaalca=" & IvaalcantarilladoCheckBox.Checked & ", ivasane=" & IvasaneamientoCheckBox.Checked & ", " &
                           "parauso =""" & cmbtipousuario.SelectedValue.ToString & """, mcubequiv =" & txtmequiv.Value & ", Memoria='" & cmbAlgoritmos.SelectedIndex & "' where id_tarifa='" & id_tar & "'")


        Else
            Ejecucion("insert into cuotas(descripcion_cuota,consumomin,medido,alcantarillado,saneacuo,recargos,iva,porcalca,porcrec,porcsanea,id_tarifa,altcap,alcapporc,alcapcuo,alcacuo,sanepporc,sanepcuo,sanecuo,recasocon,recasotod,ivaacon,ivaalca,ivasane,parauso,mCubEquiv, vsmdren, vsmsane, Memoria) values(""" & DescripciónTextBox.Text & """," & txtconsumo.Value & "," & TipmedidoCheckBox.Checked & "," & AlcantarilladoCheckBox.Checked & "," &
                       SaneamientoCheckBox.Checked & "," & RecargoCheckBox.Checked & "," & IvaCheckBox.Checked & "," & txtporalcanta.Value & "," & porcreca.Value & "," & porcsaneamiento.Value & ",""" & Id_Tipo_ServicioTextBox.Text & """," & txtalertalecturas.Value & "," & PoralcCheckBox.Checked & "," & CantalcCheckBox.Checked & "," & txtcuomensualalcantarillado.Value & "," & PorsanCheckBox.Checked & "," &
                       CantsanCheckBox.Checked & "," & txtcatidadmonetariasaneamiento.Value & "," & RecargoconsumoCheckBox.Checked & "," & RecargosobretodoCheckBox.Checked & "," & IvaconsumoCheckBox.Checked & "," & IvaalcantarilladoCheckBox.Checked & "," & IvasaneamientoCheckBox.Checked & ",""" & cmbtipousuario.SelectedValue.ToString & """," & txtmequiv.Value & "," & divsmdren.Value & "," & DIsane.Value & "," & cmbAlgoritmos.SelectedIndex & " )")
        End If
        ' My.Forms.frmCuotasVer.actBase()
        MessageBox.Show("Datos guardados satisfactoriamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Close()
    End Sub


    Public Sub cmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click

        Id_Tipo_ServicioTextBox.ReadOnly = False
        limpiaCtrl()
        Agr = True
        TipmedidoCheckBox.Checked = True
        txtalertalecturas.Value = 15
        txtconsumo.Value = 12

        RecargoCheckBox.Checked = True
        RecargoconsumoCheckBox.Checked = True

        IvaCheckBox.Checked = True

        IvaconsumoCheckBox.Checked = True
        IvaalcantarilladoCheckBox.Checked = True
        IvasaneamientoCheckBox.Checked = True
        'IvarecargoCheckBox.Checked = True
        'txtiva.Value = 15

        AlcantarilladoCheckBox.Checked = True
        PoralcCheckBox.Checked = True

        SaneamientoCheckBox.Checked = True
        PorsanCheckBox.Checked = True

        RecargoCheckBox.Checked = True
        RecargoconsumoCheckBox.Checked = True

        ' Ejecucion("insert into cuotas(descripcion_cuota,consumomin,medido,alcantarillado,saneacuo,recargos,iva,porcalca,porcrec,porciva,porcsanea,id_tarifa,altcap,alcapporc,alcapcuo,alcacuo,sanepporc,sanepcuo,sanecuo,recasocon,recasotod,ivaacon,ivaalca,ivasane,ivareca,consumen) values(""" & DescripciónTextBox.Text & """," & txtconsumo.Value & "," & TipmedidoCheckBox.Checked & "," & AlcantarilladoCheckBox.Checked & "," & _
        '                SaneamientoCheckBox.Checked & "," & RecargoCheckBox.Checked & "," & IvaCheckBox.Checked & "," & txtporalcanta.Value & "," & porcreca.Value & "," & txtiva.Text & "," & porcsaneamiento.Value & ",""" & Id_Tipo_ServicioTextBox.Text & """," & txtalertalecturas.Value & "," & PoralcCheckBox.Checked & "," & CantalcCheckBox.Checked & "," & txtcuomensualalcantarillado.Value & "," & PorsanCheckBox.Checked & "," & _
        '                CantsanCheckBox.Checked & "," & txtcatidadmonetariasaneamiento.Value & "," & RecargoconsumoCheckBox.Checked & "," & RecargosobretodoCheckBox.Checked & "," & IvaconsumoCheckBox.Checked & "," & IvaalcantarilladoCheckBox.Checked & "," & IvasaneamientoCheckBox.Checked & "," & IvarecargoCheckBox.Checked & "," & txtcuofij.Value & ")")

        'MessageBox.Show("La tarifa se ha guardado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Protected Sub limpiaCtrl()
        txtmequiv.Value = 0
        cmbtipousuario.Text = ""
        Id_Tipo_ServicioTextBox.Text = ""
        DescripciónTextBox.Text = ""
        TipmedidoCheckBox.Checked = False
        TipfijoCheckBox.Checked = False

        txtconsumo.Value = 0
        txtalertalecturas.Value = 0
        AlcantarilladoCheckBox.Checked = False

        PoralcCheckBox.Checked = False
        CantalcCheckBox.Checked = False

        txtporalcanta.Value = 0
        txtcuomensualalcantarillado.Value = 0

        SaneamientoCheckBox.Checked = False

        PorsanCheckBox.Checked = False
        CantsanCheckBox.Checked = False

        porcsaneamiento.Value = 0
        txtcatidadmonetariasaneamiento.Value = 0

        RecargoCheckBox.Checked = False
        RecargoconsumoCheckBox.Checked = False
        RecargosobretodoCheckBox.Checked = False
        porcreca.Value = 0

        IvaCheckBox.Checked = False
        IvaconsumoCheckBox.Checked = False
        IvaalcantarilladoCheckBox.Checked = False
        IvasaneamientoCheckBox.Checked = False
        'IvarecargoCheckBox.Checked = False
        'txtiva.Value = 0
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        If MessageBox.Show("¿Desea eliminar la tarifa?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim ia As IDataReader = ConsultaSql("select clave from usuario where id_tarifa='" & Id_Tipo_ServicioTextBox.Text & "'").ExecuteReader
            If ia.Read() Then
                MessageBoxEx.Show("No puedes eleminar esta tarifa hay usuarios asignadas a ella")
                Exit Sub
            End If
            Ejecucion("delete from cuotas where id_tarifa=""" & Id_Tipo_ServicioTextBox.Text & """")
            MessageBox.Show("Tarifa eliminada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiaCtrl()
            'My.Forms.frmCuotasVer.actBase()
        End If
        Me.Close()
    End Sub

    Private Sub btntablamedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntablamedidos.Click
        Dim frm As New frmCuomed(Id_Tipo_ServicioTextBox.Text)
        frm.ShowDialog()
    End Sub


    Private Sub frmConscuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Agr Then
            llenarCombo(cmbtipousuario, "select id_tipo_usuario, descripcion from tipos_usuarios")
        End If
    End Sub

    Private Sub txtcuota1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimprimir.Click
        Dim FORMULA As String = "{cuotas1.id_tarifa}='" & Id_Tipo_ServicioTextBox.Text & "' "
        Dim frmrep As New frmReporte(frmReporte.Lista.Tarifas, FORMULA)
        frmrep.MdiParent = MDIPrincipal
        frmrep.Show()
        frmrep.Text = "Reporte de Cuotas"
        frmrep.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DIVSMAGUA_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SALARIO As Double
        SALARIO = obtenerCampo("SELECT SALARIO FROM empresa", "SALARIO")

    End Sub

    Private Sub divsmdren_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divsmdren.ValueChanged
        Dim SALARIO As Double
        SALARIO = obtenerCampo("SELECT SALARIO FROM empresa", "SALARIO")
        txtcuomensualalcantarillado.Value = Math.Round(SALARIO * divsmdren.Value, 2)
    End Sub

    Private Sub DIsane_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DIsane.ValueChanged
        Dim SALARIO As Double
        SALARIO = obtenerCampo("SELECT SALARIO FROM empresa", "SALARIO")
        txtcatidadmonetariasaneamiento.Value = Math.Round(SALARIO * DIsane.Value, 2)
    End Sub

    Private Sub btnfijas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfijas.Click
        Dim frm As New frmcuofij(Id_Tipo_ServicioTextBox.Text)
        frm.ShowDialog()
    End Sub
End Class