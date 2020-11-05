Imports Microsoft.VisualBasic

Public Class Trip
    Private _TripDate As Date
    Private _Train As Train
    Private _listProducts As Collection
    Private _TonsTransported As Integer

    Private _tripsDAO As TripDAO


    Public Sub New(tripDate As Date, train As Train, product As Collection, tonsTransported As Integer)
        _TripDate = tripDate
        _Train = train
        _listProducts = product
        _TonsTransported = tonsTransported

        Me.TripsDAO = New TripDAO()
    End Sub

    Public Sub New()
        Me.TripsDAO = New TripDAO()
    End Sub

    Public Property TripDate As Date
        Get
            Return _TripDate
        End Get
        Set(value As Date)
            _TripDate = value
        End Set
    End Property

    Public Property Train As Train
        Get
            Return _Train
        End Get
        Set(value As Train)
            _Train = value
        End Set
    End Property



    Public Property TonsTransported As Integer
        Get
            Return _TonsTransported
        End Get
        Set(value As Integer)
            _TonsTransported = value
        End Set
    End Property

    Public Property TripsDAO As TripDAO
        Get
            Return _tripsDAO
        End Get
        Set(value As TripDAO)
            _tripsDAO = value
        End Set
    End Property

    Public Property ListProducts As Collection
        Get
            Return _listProducts
        End Get
        Set(value As Collection)
            _listProducts = value
        End Set
    End Property

    Public Sub delete()
        _tripsDAO.delete(Me)
    End Sub

    Public Sub insert()
        _tripsDAO.insert(Me)
    End Sub

    Public Sub update()
        _tripsDAO.update(Me)
    End Sub

    Public Sub read()
        _tripsDAO.read(Me)
    End Sub

    Public Sub readAll()
        _tripsDAO.readAll()
    End Sub
    Public Function get_MaxBenefit() As Trip
        Dim trip As Trip = New Trip
        trip = TripsDAO.greatestBenefit()
        Return trip
    End Function
End Class
