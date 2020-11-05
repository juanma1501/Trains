Imports Microsoft.VisualBasic

Public Class Product
    Private _ProductId As Integer
    Private _ProductDescription As String

    Private _trips As Collection
    Private _prices As Collection

    Private _productDAO As ProductDAO

    Public Sub New()
        Me._productDAO = New ProductDAO()
        Me._prices = New Collection()
    End Sub
    Public Sub New(ByVal des As String)
        Me._productDAO = New ProductDAO()
        Me._prices = New Collection()
        Me.ProductDescription = des
    End Sub

    Public Sub New(ByVal id As Integer)
        Me._productDAO = New ProductDAO()
        Me._prices = New Collection()
        Me._ProductId = id
    End Sub

    Public Sub New(ByVal ProductId As Integer, ByVal ProductDescription As String)
        Me.ProductDescription = ProductDescription
        Me.ProductId = ProductId

        Me.Trips = New Collection
        Me.Prices = New Collection
        Me.ProductDAO = New ProductDAO
    End Sub

    Public Property ProductId As Integer
        Get
            Return _ProductId
        End Get
        Set(value As Integer)
            _ProductId = value
        End Set
    End Property

    Public Property ProductDescription As String
        Get
            Return _ProductDescription
        End Get
        Set(value As String)
            _ProductDescription = value
        End Set
    End Property

    Public Property Trips As Collection
        Get
            Return _trips
        End Get
        Set(value As Collection)
            _trips = value
        End Set
    End Property

    Public Property Prices As Collection
        Get
            Return _prices
        End Get
        Set(value As Collection)
            _prices = value
        End Set
    End Property

    Public Property ProductDAO As ProductDAO
        Get
            Return _productDAO
        End Get
        Set(value As ProductDAO)
            _productDAO = value
        End Set
    End Property
    Public Sub insert()
        _productDAO.insert(Me)
    End Sub


    Public Sub update()
        _productDAO.update(Me)
    End Sub


    Public Sub delete()
        _productDAO.delete(Me)
    End Sub


    Public Sub read()
        _productDAO.read(Me)
    End Sub


    Public Sub readAll()
        _productDAO.readAll()
    End Sub

    Public Function get_productRank_between_dates(startDate As Date, finishDate As Date)
        ProductDAO.get_productRank_between_dates(startDate, finishDate)
    End Function
End Class
