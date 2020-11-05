Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Public Class ProductDAO
    Private _productList As Collection

    Public Sub New()
        _productList = New Collection
    End Sub

    'PROPERTIES
    Public ReadOnly Property productList As Collection
        Get
            Return _productList
        End Get
    End Property

    Public Sub delete(product As Product)
        BrokerDB.getBroker.read("DELETE FROM Products WHERE ProductID=" & product.ProductId & ";")
    End Sub

    Public Sub insert(product As Product)
        BrokerDB.getBroker.read("INSERT INTO Products VALUES (" & product.ProductId & ",'" & product.ProductDescription & "');")
    End Sub

    Public Sub update(product As Product)
        BrokerDB.getBroker.read("UPDATE Products SET DescripProducto='" & product.ProductDescription & "' WHERE ProductID =" & product.ProductId & ";")
    End Sub

    Public Sub read(product As Product)
        Dim list As OleDbDataReader = BrokerDB.getBroker.read("SELECT * FROM Products WHERE ProductDescription='" & product.ProductDescription & "';")
        If list.Read() Then
            product.ProductId = list(0)
        End If
    End Sub

    'LEER TODOS LOS PRODUCTOS EXISTENTES
    Public Sub readAll()
        Dim list As OleDbDataReader = BrokerDB.getBroker.read("SELECT * FROM Products ORDER BY ProductID;")
        Dim product As Product
        While list.Read()
            product = New Product(list(0), list(1))
            _productList.Add(product)
        End While
    End Sub

    'QUERY 3: Show a ranking of the products that have been sent the most between 2
    'dates that can be chosen
    Public Sub get_productRank_between_dates(startDate As Date, finishDate As Date)

        Dim list As OleDbDataReader = BrokerDB.getBroker.read("SELECT ProductID, count(*) FROM (SELECT p.ProductID, t.TripDate FROM Trips t RIGHT OUTER JOIN Products p ON p.ProductID = t.Product WHERE t.TripDate BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "#) GROUP BY ProductID ORDER BY count(*) DESC;")
        Dim product As Product = New Product()
        Dim price_list As Price = New Price()
        While list.Read()
            product.ProductId = list(0)
            product.read()
            product.ProductDescription = product.ProductDAO.productList.Item(1).ProductDescription
            price_list.Product = product
            price_list.readAll()
            For Each price In price_list.PriceDAO.priceList
                product.Prices.Add(price)
            Next
            _productList.Add(product)
        End While
    End Sub
End Class