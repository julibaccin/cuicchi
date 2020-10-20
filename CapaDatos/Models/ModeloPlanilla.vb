Public Class ModeloPlanilla
    Private _Tomador As String
    Private _Ref As String
    Private _nombreCompania As String
    Private _detalle As String
    Private _patente As String
    Private _fVencimiento As Date
    Private _importe As Integer

    Public Property Tomador As String
        Get
            Return _Tomador
        End Get
        Set(value As String)
            _Tomador = value
        End Set
    End Property

    Public Property Ref As String
        Get
            Return _Ref
        End Get
        Set(value As String)
            _Ref = value
        End Set
    End Property

    Public Property NombreCompania As String
        Get
            Return _nombreCompania
        End Get
        Set(value As String)
            _nombreCompania = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _detalle
        End Get
        Set(value As String)
            _detalle = value
        End Set
    End Property

    Public Property Patente As String
        Get
            Return _patente
        End Get
        Set(value As String)
            _patente = value
        End Set
    End Property

    Public Property FVencimiento As Date
        Get
            Return _fVencimiento
        End Get
        Set(value As Date)
            _fVencimiento = value
        End Set
    End Property

    Public Property Importe As Integer
        Get
            Return _importe
        End Get
        Set(value As Integer)
            _importe = value
        End Set
    End Property
End Class
