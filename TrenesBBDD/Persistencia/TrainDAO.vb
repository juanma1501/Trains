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

    Public Sub Read(ByRef train As Train)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT * FROM Trains WHERE TrainID='" & train.TrainID & "';")
        For Each aux In col
            Dim type As TrainType = New TrainType(Convert.ToInt32(aux(2)))
            type.read()
            train.TrainType = type
        Next
    End Sub

    Public Sub ReadAll(ByRef path As String)
        Dim train As Train
        Dim col, aux As Collection
        col = BrokerDB.getBroker(path).read("SELECT * FROM Trains ORDER BY TrainID")
        For Each aux In col
            train = New Train(aux(1).ToString)
            Dim type As TrainType = New TrainType(Convert.ToInt32(aux(2)))
            type.read()
            train.TrainType = type
            Me.trainList.Add(train)
        Next
    End Sub

    Public Function Insert(ByVal train As Train) As Integer
        Return BrokerDB.getBroker.update("INSERT INTO Trains VALUES('" & train.TrainID & "', '" & train.TrainType.TrainTypeID & "');")
    End Function

    Public Function Update(ByVal train As Train) As Integer
        Return BrokerDB.getBroker.update("UPDATE Trains SET  TrainType=" & train.TrainType.TrainTypeID & " WHERE TrainID='" & train.TrainID & "';")
    End Function

    Public Function Delete(ByVal train As Train) As Integer
        Return BrokerDB.getBroker.update("DELETE FROM Trains WHERE TrainID='" & train.TrainID & "';")
    End Function

    Public Sub get_trips_and_products(ByRef train As Train, d1 As Date, d2 As Date)
        Dim col, product As Collection
        col = BrokerDB.getBroker.read("SELECT COUNT( * ) As 'Number Of trips' 
                                       FROM Trips 
                                       WHERE Train='" & train.TrainID & "' AND TripDate BETWEEN #" & d1.Month & "/" & d1.Day & "/" & d1.Year & "# AND #" & d2.Month & "/" & d2.Day & "/" & d2.Year & "# 

                                        UNION 

                                        SELECT  Products.ProductDescription as 'Products' 
                                        FROM  Trips INNER JOIN Products ON Trips.Product = Products.ProductID 
                                        WHERE Train = '" & train.TrainID & "' AND TripDate BETWEEN #" & d1.Month & "/" & d1.Day & "/" & d1.Year & "# AND #" & d2.Month & "/" & d2.Day & "/" & d2.Year & "#;")
        For Each product In col
            Me.trainList.Add(product(1))
        Next
    End Sub

End Class