Public Class ModeloReporteComprobantes
    Private _Comprobante As String
    Private _Entro As Integer
    Private _Salio As Integer
    Private _Total As Integer

    Property Comprobante As String
        Get
            Return _Comprobante
        End Get
        Set
            _Comprobante = Value
        End Set
    End Property

    Property Entro As Integer
        Get
            Return _Entro
        End Get
        Set
            _Entro = Value
        End Set
    End Property

    Property Salio As Integer
        Get
            Return _Salio
        End Get
        Set
            _Salio = Value
        End Set
    End Property
End Class
