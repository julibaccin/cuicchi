Public Class ModeloComprobante
    Private _idTipoComprobante As Integer
    Private _fIngreso As Date
    Private _idCliente As String
    Private _idCompania As String
    Private _obs As String
    Private _numero As String
    Private _idBanco As String
    Private _importe As Integer
    Private _fPago As Date
    Private _idEstado As Integer
    Private _idEstadoOperacion As Integer
    Private _IdUsuario As Integer

    Public Property IdTipoComprobante As Integer
        Get
            Return _idTipoComprobante
        End Get
        Set(value As Integer)
            _idTipoComprobante = value
        End Set
    End Property

    Public Property FIngreso As Date
        Get
            Return _fIngreso
        End Get
        Set(value As Date)
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

    Public Property Importe As Integer
        Get
            Return _importe
        End Get
        Set(value As Integer)
            _importe = value
        End Set
    End Property

    Public Property FPago As Date
        Get
            Return _fPago
        End Get
        Set(value As Date)
            _fPago = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set
            _IdUsuario = Value
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
End Class
