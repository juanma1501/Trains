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

    Public Sub ReadAll(path As String)
        Dim train_type As TrainType
        Dim col, aux As Collection
        col = BrokerDB.getBroker(path).read("SELECT * FROM TrainTypes ORDER BY TrainTypeID")
        For Each aux In col
            train_type = New TrainType(Convert.ToInt32(aux(1)))
            train_type.TrainTypeDescriptor = aux(2).ToString
            train_type.MaxCapacity = Convert.ToInt32(aux(3))
            Me.trainsList.Add(train_type)
        Next
    End Sub
    Public Sub Read(ByRef train_type As TrainType)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT * FROM TrainTypes WHERE TrainTypeID=" & train_type.TrainTypeID & ";")
        For Each aux In col
            train_type.TrainTypeDescriptor = aux(2).ToString
            train_type.MaxCapacity = Convert.ToInt32(aux(3))
        Next
    End Sub

    Public Function Insert(ByVal train_type As TrainType) As Integer
        Return BrokerDB.getBroker.update("INSERT INTO TrainTypes(TrainTypeDescription, MaxCapacity) VALUES('" & train_type.TrainTypeDescriptor & "' , " & train_type.MaxCapacity & ");")
    End Function

    Public Function Update(ByVal train_type As TrainType) As Integer
        Return BrokerDB.getBroker.update("UPDATE TrainTypes SET TrainTypeDescription='" & train_type.TrainTypeDescriptor & "', MaxCapacity=" & train_type.MaxCapacity & " WHERE TrainTypeID=" & train_type.TrainTypeID & ";")

    End Function

    Public Function Delete(ByVal train_type As TrainType) As Integer
        Return BrokerDB.getBroker.update("DELETE FROM TrainTypes WHERE TrainTypeID=" & train_type.TrainTypeID & ";")
    End Function

    'query 2:Show a ranking of the type of train that has made the most trips
    'between 2 dates that can be chosen
    Public Sub get_Rank_type_by_trips_betweenDates(startDate As Date, finishDate As Date)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT TrainType, COUNT(*) FROM(Select t.TrainID, t.TrainType 
                                       FROM Trains t RIGHT JOIN Trips tr On(t.TrainID = tr.Train) 
                                       WHERE tr.TripDate BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "#) 
                                       GROUP BY TrainType 
                                       ORDER BY COUNT (*) DESC;")
        Dim collection As Collection = New Collection
        Dim trainType As TrainType
        For Each aux In col
            trainType = New TrainType(Convert.ToInt32(aux(1)))
            trainType.read()
            _trainTypeList.Add(trainType.TrainTypeDescriptor)
        Next
    End Sub




End Class
