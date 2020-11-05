Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class TrainDAO
    Private _trainList As Collection

    Public Sub New()
        _trainList = New Collection
    End Sub

    Public ReadOnly Property trainList As Collection
        Get
            Return _trainList
        End Get
    End Property

    Public Sub delete(train As Train)
        BrokerDB.getBroker().update("DELETE FROM Trains WHERE TrainID=" & train.TrainID & ";")
    End Sub

    Public Sub insert(train As Train)
        BrokerDB.getBroker().update("INSERT INTO Trains VALUES ('" & train.TrainID & "','" & train.TrainType.TrainTypeID & "');")
    End Sub

    Public Function update(train As Train) As Integer
        Return BrokerDB.getBroker().update("UPDATE Trains SET TrainType='" & train.TrainType.TrainTypeID & "' WHERE TrainID=" & train.TrainID & ";")
    End Function

    Public Sub read(ByRef train As Train)

        Dim list As OleDbDataReader
        Dim trainType As OleDbDataReader
        Dim type As TrainType
        list = BrokerDB.getBroker().read("SELECT * FROM Trains WHERE TrainID='" & train.TrainID & "';")

        If list.Read() Then
            trainType = BrokerDB.getBroker().read("SELECT * FROM TrainTypes WHERE TrainTypeID=" & list(1) & ";")
            If trainType.Read() Then
                type = New TrainType(trainType(0), trainType(1), trainType(2))
                train.TrainType = type
            End If
        End If

    End Sub

    Public Sub readAll()
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT * FROM Trains ORDER BY TrainID;")
        Dim trainType As OleDbDataReader
        Dim type As TrainType

        While list.Read()
            trainType = BrokerDB.getBroker().read("SELECT * FROM TrainTypes WHERE TrainTypeID=" & list(1) & ";")
            If trainType.Read() Then
                type = New TrainType(trainType(0), trainType(1), trainType(2))
                _trainList.Add(New Train(list(0), type))
            End If
        End While
    End Sub


    'Query 1:Show the number of trips and a list of the products transported by a
    'train between 2 dates (the train And dates must be chosen by the user)
    Public Function get_Number_Of_Trips_Between_Dates(train As Train, startDate As Date, finishDate As Date) As Integer
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT count(*) FROM(SELECT v.TripDate FROM trips t WHERE v.Train='" & train.TrainID & "'AND v.TripDate BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "# GROUP BY v.fechaViaje);")
        If list.Read() Then
            Return list(0)
        End If
    End Function

    Public Function get_trasported_product(train As Train, startDate As Date, finishDate As Date) As Collection
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT DISTINCT v.Product FROM Trips t WHERE v.Train='" & train.TrainID & "'AND v.TripDate BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "#;")
        Dim prod_list As Collection = New Collection
        While list.Read()
            Dim product As New Product
            product.ProductId = list(0)
            product.read()
            _trainList.Add(product.ProductDAO.productList)
        End While
        Return _trainList
    End Function

End Class