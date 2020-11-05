Imports Microsoft.VisualBasic

Public Class Product
    Private _ProductId As Integer
    Private _ProductDescription As String



    Private _productDAO As ProductDAO

    Public Sub New()
        Me._productDAO = New ProductDAO()
    End Sub

    Public Sub New(ByVal des As String)
        Me._productDAO = New ProductDAO()
        Me.ProductDescription = des
    End Sub

    Public Sub New(ByVal id As Integer)
        Me._productDAO = New ProductDAO()
        Me._ProductId = id
    End Sub

    Public Sub New(ByVal ProductId As Integer, ByVal ProductDescription As String)
        Me.ProductDescription = ProductDescription
        Me.ProductId = ProductId

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

    Public Property ProductDAO As ProductDAO
        Get
            Return _productDAO
        End Get
        Set(value As ProductDAO)
            _productDAO = value
        End Set
    End Property

    Public Function insert() As Integer
        Return Me._productDAO.insert(Me)
    End Function


    Public Function update() As Integer
        Return Me._productDAO.update(Me)
    End Function


    Public Function delete() As Integer
        Return Me._productDAO.delete(Me)
    End Function


    Public Sub read()
        _productDAO.read(Me)
    End Sub

    Public Sub readAll(path As String)
        _productDAO.readAll(path)
    End Sub

    Public Sub get_productRank_between_dates(startDate As Date, finishDate As Date)
        ProductDAO.get_productRank_between_dates(startDate, finishDate)
    End Sub
End Class
