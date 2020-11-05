Imports Microsoft.VisualBasic

Public Class Train
    Private _TrainID As Integer
    Private _TrainType As TrainType

    Private _TrainDAO As TrainDAO

    Private _trips As Collection

    Sub New(ByVal trainID As Integer, ByVal trainType As TrainType)
        Me.TrainID = trainID
        Me.TrainType = trainType

        Me.TrainDAO = New TrainDAO()
        Me.Trips = New Collection
    End Sub

    Sub New()
        Me.TrainDAO = New TrainDAO()
        Me.Trips = New Collection
    End Sub

    Sub New(ByVal trainID As Integer)
        Me.TrainDAO = New TrainDAO()
        Me.TrainID = trainID
    End Sub

    Public Property TrainID As Integer
        Get
            Return _TrainID
        End Get
        Set(value As Integer)
            _TrainID = value
        End Set
    End Property

    Public Property TrainType As TrainType
        Get
            Return _TrainType
        End Get
        Set(value As TrainType)
            _TrainType = value
        End Set
    End Property

    Public Property TrainDAO As TrainDAO
        Get
            Return _TrainDAO
        End Get
        Set(value As TrainDAO)
            _TrainDAO = value
        End Set
    End Property

    Public Property Trips As Collection
        Get
            Return _trips
        End Get
        Set(value As Collection)
            _trips = value
        End Set
    End Property

    Public Sub delete()
        _TrainDAO.delete(Me)
    End Sub

    Public Sub insert()
        _TrainDAO.insert(Me)
    End Sub

    Public Sub update()
        _TrainDAO.update(Me)
    End Sub

    Public Sub read()
        _TrainDAO.read(Me)
    End Sub

    Public Sub readAll()
        _TrainDAO.readAll()
    End Sub

    Public Function get_Number_Of_Trips_Between_Dates(startDate As Date, finishDate As Date) As Integer
        Return TrainDAO.get_Number_Of_Trips_Between_Dates(Me, startDate, finishDate)
    End Function

    Public Function get_trasported_product(train As Train, startDate As Date, finishDate As Date) As Collection
        Return TrainDAO.get_trasported_product(Me, startDate, finishDate)
    End Function
End Class
