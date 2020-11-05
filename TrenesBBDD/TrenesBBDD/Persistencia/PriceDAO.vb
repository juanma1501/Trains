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

    Public Sub delete(price As Price)
        BrokerDB.getBroker().update("DELETE FROM Prices WHERE Product=" & price.Product.ProductId & "AND PriceDate = #" & price.PriceDate.Month & "/" & price.PriceDate.Day & "/" & price.PriceDate.Year & "#;")
    End Sub

    Public Sub insert(price As Price)
        BrokerDB.getBroker().update("INSERT INTO Prices VALUES (" & price.Product.ProductId & ",'" & price.PriceDate.Day & "-" & price.PriceDate.Month & "-" & price.PriceDate.Year & "'," & Replace(price.EurosPerTon.ToString, ",", ".") & ");")
    End Sub

    Public Sub update(price As Price)
        BrokerDB.getBroker().update("UPDATE Prices SET EurosPerTon= " & Replace(price.EurosPerTon.ToString, ",", ".") & " WHERE Product = " & price.Product.ProductId & " AND Fecha = #" & price.PriceDate.Day & "/" & price.PriceDate.Month & "/" & price.PriceDate.Year & "#;")
    End Sub

    Public Sub read(ByRef price As Price)
        Dim list As OleDbDataReader
        Dim prod_list As OleDbDataReader
        Dim product As Product
        list = BrokerDB.getBroker().read("SELECT * FROM Prices WHERE Product = " & price.Product.ProductId & " AND PriceDate=#" & price.PriceDate.Day & "/" & price.PriceDate.Month & "/" & price.PriceDate.Year & "#;")
        If list.Read() Then
            prod_list = BrokerDB.getBroker().read("SELECT * FROM Products WHERE ProductID=" & list(0) & ";")
            If prod_list.Read() Then
                product = New Product(prod_list(0), prod_list(1))
                price.Product = product
                price.EurosPerTon = list(2)
            End If
        End If
    End Sub



    Public Sub readAll()
        Dim list As OleDbDataReader = BrokerDB.getBroker().read("SELECT * FROM Prices ORDER BY Product, PriceDate ASC;")
        Dim prod_list As OleDbDataReader
        Dim product As Product

        While list.Read()
            prod_list = BrokerDB.getBroker().read("SELECT * FROM Products WHERE ProductID=" & list(0) & ";")
            If prod_list.Read() Then
                product = New Product(prod_list(0), prod_list(1))
                _priceList.Add(New Price(product, list(1), list(2)))
            End If
        End While
    End Sub
End Class
