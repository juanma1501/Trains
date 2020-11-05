Public Class DataBaseBroker
    Public Sub New()
        checkDDBB()

    End Sub


    Public Sub checkDDBB()
        readTrainTypes()
        readTrains()
        readPrices()
        readProducts()
        readTrips()
    End Sub

    Public Sub readTrainTypes()
        BrokerDB.getBroker().read("SELECT * FROM TrainTypes")
    End Sub

    Public Sub readTrains()
        BrokerDB.getBroker().read("SELECT * FROM Trains")
    End Sub

    Public Sub readPrices()
        BrokerDB.getBroker().read("SELECT * FROM Prices")
    End Sub

    Public Sub readProducts()
        BrokerDB.getBroker().read("SELECT * FROM Products")
    End Sub

    Public Sub readTrips()
        BrokerDB.getBroker().read("SELECT * FROM Trips")
    End Sub


End Class
