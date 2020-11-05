Imports Microsoft.VisualBasic

Public Class Price
    Private _Product As Product
    Private _PriceDate As Date
    Private _EurosPerTon As Double

    Private _PriceDAO As PriceDAO

    Public Sub New()
        PriceDAO = New PriceDAO()
    End Sub

    Sub New(ByVal product As Product, ByVal priceDate As Date)
        Me._Product = product
        Me._PriceDate = priceDate
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

    Public Function delete() As Integer
        Return Me._PriceDAO.delete(Me)
    End Function

    Public Function insert() As Integer
        Return Me._PriceDAO.insert(Me)
    End Function

    Public Function update() As Integer
        Return Me._PriceDAO.update(Me)
    End Function

    Public Sub read()
        _PriceDAO.read(Me)
    End Sub

    Public Sub readAll(path As String)
        _PriceDAO.readAll(path)
    End Sub
End Class