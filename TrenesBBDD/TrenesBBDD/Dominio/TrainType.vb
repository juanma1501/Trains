Imports Microsoft.VisualBasic

Public Class TrainType
    Private _TrainTypeID As Integer
    Private _TrainTypeDescriptor As String
    Private _MaxCapacity As Integer

    Private _trains As Collection

    Private _trainsTypeDAO As TrainTypeDAO

    Sub New()
        Me.TrainsTypeDAO = New TrainTypeDAO()
    End Sub
    Public Property TrainTypeID As Integer
        Get
            Return _TrainTypeID
        End Get
        Set(value As Integer)
            _TrainTypeID = value
        End Set
    End Property

    Public Property TrainTypeDescriptor As String
        Get
            Return _TrainTypeDescriptor
        End Get
        Set(value As String)
            _TrainTypeDescriptor = value
        End Set
    End Property

    Public Property MaxCapacity As Integer
        Get
            Return _MaxCapacity
        End Get
        Set(value As Integer)
            _MaxCapacity = value
        End Set
    End Property

    Public Property TrainsTypeDAO As TrainTypeDAO
        Get
            Return _trainsTypeDAO
        End Get
        Set(value As TrainTypeDAO)
            _trainsTypeDAO = value
        End Set
    End Property

    Public Property Trains As Collection
        Get
            Return _trains
        End Get
        Set(value As Collection)
            _trains = value
        End Set
    End Property

    Sub New(ByVal TrainTypeID As Integer, ByVal TrainTypeDescriptor As String, ByVal MaxCapacity As Integer)
        Me._TrainTypeID = TrainTypeID
        Me._TrainTypeDescriptor = TrainTypeDescriptor
        Me._MaxCapacity = MaxCapacity

        Me._TrainsTypeDAO = New TrainTypeDAO
        Me._trains = New Collection
    End Sub

    Sub New(ByVal TrainTypeDescriptor As String, ByVal MaxCapacity As Integer)
        Me._TrainTypeDescriptor = TrainTypeDescriptor
        Me._MaxCapacity = MaxCapacity

        Me._TrainsTypeDAO = New TrainTypeDAO
        Me._trains = New Collection
    End Sub

    Sub New(ByVal des As String)
        Me._trainsTypeDAO = New TrainTypeDAO
        Me.TrainTypeDescriptor = des
    End Sub

    Public Sub delete()
        _trainsTypeDAO.delete(Me)
    End Sub

    Public Sub insert()
        _trainsTypeDAO.insert(Me)
    End Sub

    Public Sub modify()
        _trainsTypeDAO.update(Me)
    End Sub

    Public Sub read()
        _trainsTypeDAO.read(Me)
    End Sub

    Public Sub readAll()
        _trainsTypeDAO.readAll()

    End Sub

    Public Sub get_Rank_type_by_trips_betweenDates(startDate As Date, finishDate As Date)
        _trainsTypeDAO.get_Rank_type_by_trips_betweenDates(startDate, finishDate)
    End Sub
End Class
