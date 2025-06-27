Public Interface IFormatos(Of UsuarioDTO)

    Function GenerarContratoAguaPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarContratoAlcantarilladoPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarContratoAguaProvisionalPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarCambioTarifaPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarCambioMedidorPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarCambioNombrePDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarPrimeraNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarSegundaNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarTerceraNotificacionPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarNotificacionSuspensionPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarConstanciaNoAdeudoPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarBajaTemporalPDF(objetoModelo As UsuarioDTO) As Boolean
    Function GenerarBajaDefinitivaPDF(objetoModelo As UsuarioDTO) As Boolean

End Interface
