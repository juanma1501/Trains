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

    Public Sub readAll(path As String)
        Dim prod As Product
        Dim col, aux As Collection
        col = BrokerDB.getBroker(path).read("SELECT * FROM Products ORDER BY ProductID")
        For Each aux In col
            prod = New Product(Convert.ToInt32(aux(1)))
            prod.ProductDescription = aux(2).ToString
            Me.productList.Add(prod)
        Next
    End Sub

    Public Sub read(ByRef product As Product)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT * FROM Products WHERE ProductID=" & product.ProductId & ";")
        For Each aux In col
            product.ProductDescription = aux(2).ToString
        Next
    End Sub

    Public Function insert(ByVal product As Product) As Integer
        Return BrokerDB.getBroker.update("INSERT INTO Products(ProductDescription) VALUES('" & product.ProductDescription & "');")

    End Function

    Public Function update(ByVal product As Product) As Integer
        Return BrokerDB.getBroker.update("UPDATE Products SET ProductDescription='" & product.ProductDescription & "' WHERE ProductID=" & product.ProductId & ";")

    End Function

    Public Function delete(ByVal product As Product) As Integer
        Return BrokerDB.getBroker.update("DELETE FROM Products WHERE ProductID=" & product.ProductId & ";")
    End Function

    Public Sub get_productRank_between_dates(startDate As Date, finishDate As Date)
        Dim col As Collection : Dim aux As Collection
        col = BrokerDB.getBroker.read("SELECT ProductID, count(*)
                                       FROM (SELECT p.ProductID, t.TripDate 
                                             FROM Trips t 
                                             RIGHT OUTER JOIN Products p ON p.ProductID = t.Product WHERE t.TripDate 
                                             BETWEEN #" & startDate.Month & "/" & startDate.Day & "/" & startDate.Year & "# AND #" & finishDate.Month & "/" & finishDate.Day & "/" & finishDate.Year & "#)
                                       GROUP BY ProductID 
                                       ORDER BY count(*) DESC;")
        For Each aux In col
            Dim product As Product = New Product(Convert.ToInt32(aux(1)))
            product.read()
            productList.Add(product.ProductDescription)
        Next
    End Sub


End Class