Imports Microsoft.VisualBasic

Public Class Trip
    Private _TripDate As Date
    Private _Train As Train
    Private _product As Product
    Private _TonsTransported As Integer

    Private _tripDAO As TripDAO


    Public Sub New(tripDate As Date, train As Train, product As Product, tonsTransported As Integer)
        _TripDate = tripDate
        _Train = train
        _product = product
        _TonsTransported = tonsTransported

        Me.TripsDAO = New TripDAO()
    End Sub

    Public Sub New(tripDate As Date, train As Train, product As Product)
        _TripDate = tripDate
        _Train = train
        _product = product

        Me.TripsDAO = New TripDAO()
    End Sub

    Public Sub New(tripDate As Date, train As Train)
        _TripDate = tripDate
        _Train = train
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
            Return _tripDAO
        End Get
        Set(value As TripDAO)
            _tripDAO = value
        End Set
    End Property

    Public Property Product As Product
        Get
            Return _product
        End Get
        Set(value As Product)
            _product = value
        End Set
    End Property

    Public Function delete() As Integer
        Return Me._tripDAO.delete(Me)
    End Function

    Public Function insert() As Integer
        Return Me._tripDAO.insert(Me)
    End Function

    Public Function update() As Integer
        Return Me._tripDAO.update(Me)
    End Function

    Public Sub read()
        _tripDAO.read(Me)
    End Sub

    Public Sub readAll(path As String)
        _tripDAO.readAll(path)
    End Sub

    Public Function getProfit() As Collection
        Return Me._tripDAO.profit(Me)
    End Function

    Public Function getMostProfit() As Collection
        Dim data As New Collection

        Dim trip As New Trip()
        Dim max_benefit As Double = 0
        Dim price_product As Double
        trip.readAll(Connection_UI.ofdPath.FileName)

        For Each t As Trip In trip.TripsDAO.tripList()
            If Convert.ToDouble(t.getProfit()(1)) > max_benefit Then
                trip = t
                max_benefit = Convert.ToDouble(t.getProfit()(1))
                price_product = Convert.ToDouble(t.getProfit()(2))
            End If
        Next

        'Add the information about the trip with biggest profit to the collection to be shown in Ranking Interface
        data.Add(max_benefit)
        data.Add(price_product)
        data.Add(trip.TripDate)
        data.Add(trip.Train.TrainID)
        data.Add(trip.Train.TrainType.TrainTypeDescriptor)
        data.Add(trip.Product.ProductDescription)
        data.Add(trip.TonsTransported)

        Return data

    End Function


End Class
