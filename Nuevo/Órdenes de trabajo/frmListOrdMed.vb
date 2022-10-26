Public Class frmListOrdMed

    Private Sub frmListOrdMed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CatControl1.filtrar("select ordenestrabajo.clave as Clave, ordenestrabajo.cuenta as Cuenta, ordenestrabajo.comunidad as Comunidad, ordenestrabajo.nombre as Nombre, ordenestrabajo.direccion as Dirección, trabajadores.nombre as Responsable, ordenestrabajo.observacion as Observación, ordenestrabajo.fecha as Fecha from ordenestrabajo,trabajadores where ordenestrabajo.responsable=trabajadores.idtrab;select ordenestrabajo.clave as Clave, ordenestrabajo.cuenta as Cuenta, ordenestrabajo.comunidad as Comunidad, ordenestrabajo.nombre as Nombre, ordenestrabajo.direccion as Dirección, trabajadores.nombre as Responsable, ordenestrabajo.observacion as Observación, ordenestrabajo.fecha as Fecha from ordenestrabajo,trabajadores where ordenestrabajo.responsable=trabajadores.idtrab")
    End Sub
End Class