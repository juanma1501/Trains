Imports Microsoft.VisualBasic

Public Class Train
    Private _TrainID As String
    Private _TrainType As TrainType


    Private _TrainDAO As TrainDAO

    Private _trips As Collection

    Sub New(ByVal trainID As String, ByVal trainType As TrainType)
        Me.TrainID = trainID
        Me.TrainType = trainType

        Me.TrainDAO = New TrainDAO()
        Me.Trips = New Collection
    End Sub

    Sub New()
        Me.TrainDAO = New TrainDAO()
    End Sub

    Sub New(ByVal trainID As String)
        Me.TrainDAO = New TrainDAO()
        Me.TrainID = trainID
    End Sub

    Public Property TrainID As String
        Get
            Return _TrainID
        End Get
        Set(value As String)
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

    Public Function delete() As Integer
        Return Me._TrainDAO.Delete(Me)
    End Function

    Public Function insert() As Integer
        Return Me._TrainDAO.Insert(Me)
    End Function

    Public Function update() As Integer
        Return Me._TrainDAO.Update(Me)
    End Function

    Public Sub read()
        _TrainDAO.read(Me)
    End Sub

    Public Sub readAll(path As String)
        _TrainDAO.ReadAll(path)
    End Sub

    Public Sub get_trips_and_products(d1 As Date, d2 As Date)
        _TrainDAO.get_trips_and_products(Me, d1, d2)
    End Sub


End Class
