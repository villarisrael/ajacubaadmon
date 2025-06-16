Public Interface IOrdenesTrabajo(Of T)

    Function GenerarOrdenTrabajo(id As Integer) As T

    Function GenerarPDF(ordenTrabajo As T) As Boolean

End Interface
