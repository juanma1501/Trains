Imports Microsoft.VisualBasic

Public Class Price
    Private _Product As Product
    Private _PriceDate As Date
    Private _EurosPerTon As Double

    Private _PriceDAO As PriceDAO

    Public Sub New()
        PriceDAO = New PriceDAO()
    End Sub

    Sub New(ByVal id As Integer)
        Me._Product = New Product(id)
        Me._PriceDAO = New PriceDAO
    End Sub

    Sub New(ByVal product As Product, ByVal priceDate As Date, ByVal eurosPerTon As Double)
        Me._Product = product
        Me._PriceDate = priceDate
        Me._EurosPerTon = eurosPerTon
        Me._PriceDAO = New PriceDAO
    End Sub

    Public Property Product As Product
        Get
            Return _Product
        End Get
        Set(value As Product)
            _Product = value
        End Set
    End Property

    Public Property PriceDate As Date
        Get
            Return _PriceDate
        End Get
        Set(value As Date)
            _PriceDate = value
        End Set
    End Property

    Public Property EurosPerTon As Double
        Get
            Return _EurosPerTon
        End Get
        Set(value As Double)
            _EurosPerTon = value
        End Set
    End Property

    Public Property PriceDAO As PriceDAO
        Get
            Return _PriceDAO
        End Get
        Set(value As PriceDAO)
            _PriceDAO = value
        End Set
    End Property

    Public Sub delete()
        _PriceDAO.delete(Me)
    End Sub

    Public Sub insert()
        _PriceDAO.insert(Me)
    End Sub

    Public Sub update()
        _PriceDAO.update(Me)
    End Sub

    Public Sub read()
        _PriceDAO.read(Me)
    End Sub

    Public Sub readAll()
        _PriceDAO.readAll()
    End Sub
End Class