Imports Microsoft.VisualBasic
Imports System.Data.OleDb

Public Class PriceDAO
    Private _priceList As Collection

    Public Sub New()
        _priceList = New Collection
    End Sub

    Public ReadOnly Property priceList As Collection
        Get
            Return _priceList
        End Get
    End Property

    Public Function delete(price As Price) As Integer
        Return BrokerDB.getBroker().update("DELETE FROM Prices WHERE Product=" & price.Product.ProductId & "AND PriceDate = #" & price.PriceDate.Month & "/" & price.PriceDate.Day & "/" & price.PriceDate.Year & "#;")
    End Function

    Public Function insert(price As Price) As Integer
        Return BrokerDB.getBroker().update("INSERT INTO Prices VALUES (" & price.Product.ProductId & ",#" & price.PriceDate.Day & "/" & price.PriceDate.Month & "/" & price.PriceDate.Year & "#," & Replace(price.EurosPerTon.ToString, ",", ".") & ");")
    End Function

    Public Function update(price As Price) As Integer
        Return BrokerDB.getBroker().update("UPDATE Prices SET EurosPerTon= " & Replace(price.EurosPerTon.ToString, ",", ".") & " WHERE Product = " & price.Product.ProductId & " AND PriceDate = #" & price.PriceDate.Day & "/" & price.PriceDate.Month & "/" & price.PriceDate.Year & "#;")
    End Function

    Public Sub read(ByRef price As Price)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker().read("SELECT * FROM Prices WHERE Product = " & price.Product.ProductId & " AND PriceDate=#" & price.PriceDate.Day & "/" & price.PriceDate.Month & "/" & price.PriceDate.Year & "#;")

        For Each aux In col
            price.EurosPerTon = Convert.ToDouble(aux(3))
        Next
    End Sub

    Public Sub readAll(path As String)
        Dim col As Collection
        Dim aux As Collection
        col = BrokerDB.getBroker(path).read("SELECT * FROM Prices ORDER BY Product, PriceDate ASC;")
        Dim price As Price

        For Each aux In col
            Dim product As Product = New Product(Convert.ToInt32(aux(1)))
            product.read()
            Dim date_fecha As Date = Convert.ToDateTime(aux(2))
            price = New Price(product, date_fecha)
            price.EurosPerTon = Convert.ToDouble(aux(3))
            Me._priceList.Add(price)
        Next
    End Sub
End Class