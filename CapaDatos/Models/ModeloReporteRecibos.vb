Public Class ModeloReporteRecibos
    Private _Compania As String
    Private _Entro As Integer
    Private _Salio As Integer
    Private _Total As Integer


    Property Compania As String
        Get
            Return _Compania
        End Get
        Set
            _Compania = Value
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

    Property Total As Integer
        Get
            Return _Total
        End Get
        Set
            _Total = Value
        End Set
    End Property

End Class
