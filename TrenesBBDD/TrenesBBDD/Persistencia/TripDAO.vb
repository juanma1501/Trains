Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Public Class TripDAO
    Private _tripList As Collection

    Public Sub New()
        _tripList = New Collection
    End Sub

    Public ReadOnly Property tripList As Collection
        Get
            Return _tripList
        End Get
    End Property

    'Inserta un viaje'
    Public Function insert(trip As Trip)
        BrokerDB.getBroker.read("INSERT INTO Trips VALUES ('" & trip.TripDate.Day & "/" & trip.TripDate.Month & "/" & trip.TripDate.Year & "'," & trip.Train.TrainID & "'," & trip.Product.ProductId & "'," & trip.TonsTransported & ");")
    End Function

    Public Function update(trip As Trip)
        BrokerDB.getBroker.read("UPDATE Viajes SET TonsTransported=#" & trip.TripDate.Day & "/" & trip.TripDate.Month & "/" & trip.TripDate.Year & "#," & trip.Train.TrainID & "'," & trip.Product.ProductId & "'," & trip.TonsTransported & ";")
    End Function

    'Eliminar Viaje'
    Public Function delete(trip As Trip)
        BrokerDB.getBroker.read("DELETE FROM VIAJES WHERE TripDate=#" & trip.TripDate.Month & "/" & trip.TripDate.Day & "/" & trip.TripDate.Year & "# AND Train='" & trip.Train.TrainID & "';")
    End Function

    Public Sub read(ByRef trip As Trip)
        Dim list As OleDbDataReader
        list = BrokerDB.getBroker().read("SELECT * FROM Prices WHERE TripDate=#" & trip.TripDate.Month & "/" & trip.TripDate.Day & "/" & trip.TripDate.Year & "# AND Train='" & trip.Train.TrainID & "# AND Prouct='" & trip.Product.ProductId & "';")

        If list.Read() Then
            trip.TonsTransported = list(3)
        End If
    End Sub

    Public Sub readAll()
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT * FROM Trips ORDER BY TripDate, Train, Product")
        Dim train_list As OleDbDataReader
        Dim prod_list As OleDbDataReader
        Dim train As Train
        Dim product As Product

        While list.Read()
            train_list = BrokerDB.getBroker().read("SELECT * FROM Train WHERE TrainID='" & list(1) & "';")
            If train_list.Read() Then
                train = New Train(train_list(0))
                train.read()
                prod_list = BrokerDB.getBroker.read("SELECT * FROM Products WHERE ProductID='" & list(2) & ";")
                If prod_list.Read() Then
                    product = New Product(prod_list(0), prod_list(1))
                    _tripList.Add(New Trip(list(0), train, product, list(3)))
                End If
            End If
        End While
    End Sub

    Public Function greatestBenefit() As Trip
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT t.TripDate, t.Train, tr.TrainType, t.Product, t.TonsTransported, p.EurosPerTon, t.TonsTransported * p.EurosPerTon FROM (Trips t INNER JOIN Trains tr ON t.Train = tr.TrainID) INNER JOIN Prices p ON t.tripDate = p.priceDate and t.product= p.product WHERE t.TonsTransported * p.EurosPerTon = (SELECT MAX(t.TonsTransported * p.EurosPerTon) AS price_per_trip FROM Trips t, Trains tr, Prices p WHERE t.TripDate = p.PriceDate AND t.Train = tr.TrainID AND t.Product = p.product)")
        Dim trip As Trip = New Trip()
        If list.Read() Then
            trip.Product = list(3)
            trip.Train = list(1)
            trip.TripDate = list(0)
            trip.read()
        End If
        Return trip
    End Function
End Class
