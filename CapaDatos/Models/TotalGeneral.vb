Public Class TotalGeneral
    Private _Entro As Integer
    Private _Salio As Integer
    Private _Total As Integer
    Private _Compañia As String

    Public Property Entro As Integer
        Get
            Return _Entro
        End Get
        Set(value As Integer)
            _Entro = value
        End Set
    End Property

    Public Property Salio As Integer
        Get
            Return _Salio
        End Get
        Set(value As Integer)
            _Salio = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            _Total = value
        End Set
    End Property

    Public Property Compañia As String
        Get
            Return _Compañia
        End Get
        Set(value As String)
            _Compañia = value
        End Set
    End Property
End Class
