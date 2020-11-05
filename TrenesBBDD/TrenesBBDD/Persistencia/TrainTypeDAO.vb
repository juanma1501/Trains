Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class TrainTypeDAO
    Private _trainTypeList As Collection

    Sub New()
        Me._trainTypeList = New Collection
    End Sub

    Public ReadOnly Property trainsList As Collection
        Get
            Return _trainTypeList
        End Get
    End Property

    Public Sub delete(trainType As TrainType)
        BrokerDB.getBroker().update("DELETE FROM TrainTypes WHERE TrainTypeID=" & trainType.TrainTypeID & ";")
    End Sub

    Public Function update(trainType As TrainType) As Integer
        Return BrokerDB.getBroker().update("UPDATE Trains SET TrainTypeDescriptor='" & trainType.TrainTypeDescriptor & "', MaxCapacity='" & trainType.MaxCapacity & ";")
    End Function

    Public Sub insert(trainType As TrainType)
        BrokerDB.getBroker().update("INSERT INTO TrainTypes ([TrainTypeDescriptor],[MaxCapacity]) VALUES ('" & trainType.TrainTypeDescriptor & "','" & trainType.MaxCapacity & "');")
    End Sub

    Public Sub read(ByRef trainType As TrainType)
        Dim list As OleDbDataReader
        list = BrokerDB.getBroker().read("SELECT * FROM TrainTypes WHERE TrainTypeDescription = '" & trainType.TrainTypeDescriptor & "';")
        If list.Read() Then
            trainType.TrainTypeID = list(0)
            trainType.MaxCapacity = list(2)
        End If
    End Sub

    Public Sub readID(ByRef trainType As TrainType)

        Dim list As OleDbDataReader
        list = BrokerDB.getBroker().read("SELECT * FROM TrainTypes WHERE TrainTypeID = (SELECT MAX(TrainTypeID) from TrainTypes);")
        If list.Read() Then
            trainType.TrainTypeID = list(0)
        End If

    End Sub

    Public Sub readAll()
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT * FROM TrainTypes ORDER BY TrainTypeID;")
        Dim trainType As TrainType

        While list.Read()
            trainType = New TrainType(list(0), list(1), list(2))
            _trainTypeList.Add(trainType)
        End While


    End Sub

    Public Sub readTrains(ByRef trainType As TrainType)
        Dim list As OleDbDataReader
        list = BrokerDB.getBroker().read("SELECT TrainID FROM Trains WHERE TrainType=" & trainType.TrainTypeID & ";")
        Dim train As New Train
        While list.Read()
            train = New Train
            train.TrainType = list(0)
            train.read()
            trainType.Trains.Add(train)
        End While
    End Sub

    'query 2:Show a ranking of the type of train that has made the most trips
    'between 2 dates that can be chosen
    'si falla esto es por el alias---> number of trips
    Public Sub get_Rank_type_by_trips_betweenDates(startDate As Date, finishDate As Date)
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT TrainType, COUNT(*) FROM(SELECT t.TrainID, t.TrainType FROM Trains t RIGHT JOIN Trips tr ON(t.TrainID = tr.Train) WHERE tr.TripDate BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "#) GROUP BY TrainType ORDER BY COUNT (*) DESC;")
        Dim trainType As TrainType
        While list.Read()
            trainType = New TrainType()
            trainType.TrainTypeID = list(0)
            trainType.read()
            'esto tambien es posible que falle, pero hasta que no se pruebe no lo toco
            '_trainTypeList.Add(New TrainType(list(0), trainType.TrainsTypeDAO._trainTypeList.Item(1).TrainTypeDescriptor))
            'esto para mostrar descripcion
            'probar esto si falla
            _trainTypeList.Add(trainType)
        End While
    End Sub

End Class
