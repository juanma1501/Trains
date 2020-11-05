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
    Public Function insert(trip As Trip) As Integer
        Return BrokerDB.getBroker.update("INSERT INTO Trips VALUES ('" & trip.TripDate.Day & "/" & trip.TripDate.Month & "/" & trip.TripDate.Year & "','" & trip.Train.TrainID & "'," & trip.Product.ProductId & "," & trip.TonsTransported & ");")
    End Function

    Public Function update(trip As Trip) As Integer
        Return BrokerDB.getBroker.update("UPDATE Trips SET TonsTransported=" & trip.TonsTransported & " WHERE TripDate=#" & trip.TripDate.Day & "/" & trip.TripDate.Month & "/" & trip.TripDate.Year & "# AND Train='" & trip.Train.TrainID & "' AND Product=" & trip.Product.ProductId & ";")
    End Function

    'Eliminar Viaje'
    Public Function delete(trip As Trip) As Integer
        Return BrokerDB.getBroker.update("DELETE FROM Trips WHERE TripDate=#" & trip.TripDate.Day & "/" & trip.TripDate.Month & "/" & trip.TripDate.Year & "# AND Train='" & trip.Train.TrainID & "' AND Product=" & trip.Product.ProductId & ";")
    End Function

    Public Sub read(ByRef trip As Trip)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker().read("SELECT * FROM Trips WHERE TripDate=#" & trip.TripDate.Month & "/" & trip.TripDate.Day & "/" & trip.TripDate.Year & "# AND Train='" & trip.Train.TrainID & "';")
        For Each aux In col
            trip.Train = New Train(aux(2).ToString)
            trip.Train.read()
            trip.Product = New Product(Convert.ToInt32(aux(3)))
            trip.Product.read()
            trip.TonsTransported = Convert.ToInt32(aux(4))
        Next
    End Sub

    Public Sub readAll(path As String)
        Dim trip As Trip
        Dim product As Product
        Dim col As Collection
        Dim aux As Collection
        Dim train As Train
        col = BrokerDB.getBroker(path).read("SELECT * FROM Trips ORDER BY TripDate, Train")

        For Each aux In col
            product = New Product(Convert.ToInt32(aux(3)))
            product.read()
            train = New Train(aux(2).ToString)
            train.read()
            trip = New Trip(Convert.ToDateTime(aux(1)), train, product)
            trip.TonsTransported = Convert.ToInt32(aux(4))
            Me.tripList.Add(trip)
        Next

    End Sub

    Public Function profit(ByVal trip As Trip) As Collection
        Dim data As New Collection

        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT TOP 1 (t.TonsTransported * p.EurosPerTon), p.EurosPerTon
                                       FROM Trips t, Prices p 
                                       WHERE t.Train ='" & trip.Train.TrainID & "' 
                                       AND p.PriceDate <= #" & trip.TripDate.Month & "/" & trip.TripDate.Day & "/" & trip.TripDate.Year & "#  
                                       AND p.Product = " & trip.Product.ProductId & " 
                                       AND t.tripDate = #" & trip.TripDate.Month & "/" & trip.TripDate.Day & "/" & trip.TripDate.Year & "#;")

        If col.Count <> 0 Then
            For Each aux In col
                data.Add(aux(1))
                data.Add(aux(2))
            Next
        Else
            data.Add(0)
            data.Add(0)
        End If

        Return data

    End Function

End Class