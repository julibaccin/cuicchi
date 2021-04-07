Public Class ModeloComprobante
    Private _idTipoComprobante As Integer
    Private _fIngreso As Integer
    Private _idCliente As String
    Private _idCompania As String
    Private _obs As String
    Private _obsBaja As String
    Private _numero As String
    Private _idBanco As String
    Private _importe As Double
    Private _fPago As Integer
    Private _idEstado As Integer
    Private _idEstadoOperacion As Integer
    Private _IdUsuario As Integer
    Private _tomador As String
    Private _ref As String
    Private _detalle As String
    Private _patente As String
    Private _fVencimiento As Integer
    Private _idPlanilla As Integer

    Public Property IdTipoComprobante As Integer
        Get
            Return _idTipoComprobante
        End Get
        Set(value As Integer)
            _idTipoComprobante = value
        End Set
    End Property

    Public Property FIngreso As Integer
        Get
            Return _fIngreso
        End Get
        Set(value As Integer)
            _fIngreso = value
        End Set
    End Property

    Public Property IdCliente As String
        Get
            Return _idCliente
        End Get
        Set(value As String)
            _idCliente = value
        End Set
    End Property

    Public Property IdCompania As String
        Get
            Return _idCompania
        End Get
        Set(value As String)
            _idCompania = value
        End Set
    End Property

    Public Property Obs As String
        Get
            Return _obs
        End Get
        Set(value As String)
            _obs = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property IdBanco As String
        Get
            Return _idBanco
        End Get
        Set(value As String)
            _idBanco = value
        End Set
    End Property

    Public Property Importe As Double
        Get
            Return _importe
        End Get
        Set(value As Double)
            _importe = value
        End Set
    End Property

    Public Property FPago As Integer
        Get
            Return _fPago
        End Get
        Set(value As Integer)
            _fPago = value
        End Set
    End Property
    Public Property IdEstado As Integer
        Get
            Return _idEstado
        End Get
        Set(value As Integer)
            _idEstado = value
        End Set
    End Property

    Public Property IdEstadoOperacion As Integer
        Get
            Return _idEstadoOperacion
        End Get
        Set(value As Integer)
            _idEstadoOperacion = value
        End Set
    End Property

    Public Property FVencimiento As Integer
        Get
            Return _fVencimiento
        End Get
        Set(value As Integer)
            _fVencimiento = value
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

    Public Property Detalle As String
        Get
            Return _detalle
        End Get
        Set(value As String)
            _detalle = value
        End Set
    End Property

    Public Property Ref As String
        Get
            Return _ref
        End Get
        Set(value As String)
            _ref = value
        End Set
    End Property

    Public Property Tomador As String
        Get
            Return _tomador
        End Get
        Set(value As String)
            _tomador = value
        End Set
    End Property

    Public Property ObsBaja As String
        Get
            Return _obsBaja
        End Get
        Set(value As String)
            _obsBaja = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property IdPlanilla As Integer
        Get
            Return _idPlanilla
        End Get
        Set(value As Integer)
            _idPlanilla = value
        End Set
    End Property
End Class
