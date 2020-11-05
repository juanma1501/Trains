Imports Microsoft.VisualBasic

Public Class TrainType
    Private _TrainTypeID As Integer
    Private _TrainTypeDescriptor As String
    Private _MaxCapacity As Integer

    Private _trainsTypeDAO As TrainTypeDAO

    Sub New()
        Me.TrainsTypeDAO = New TrainTypeDAO()
    End Sub
    Public Property TrainTypeID As Integer
        Get
            Return _TrainTypeID
        End Get
        Set(value As Integer)
            _TrainTypeID = value
        End Set
    End Property

    Public Property TrainTypeDescriptor As String
        Get
            Return _TrainTypeDescriptor
        End Get
        Set(value As String)
            _TrainTypeDescriptor = value
        End Set
    End Property

    Public Property MaxCapacity As Integer
        Get
            Return _MaxCapacity
        End Get
        Set(value As Integer)
            _MaxCapacity = value
        End Set
    End Property

    Public Property TrainsTypeDAO As TrainTypeDAO
        Get
            Return _trainsTypeDAO
        End Get
        Set(value As TrainTypeDAO)
            _trainsTypeDAO = value
        End Set
    End Property

    Sub New(ByVal TrainTypeDescriptor As String, ByVal MaxCapacity As Integer)
        Me._TrainTypeDescriptor = TrainTypeDescriptor
        Me._MaxCapacity = MaxCapacity

        Me._trainsTypeDAO = New TrainTypeDAO
    End Sub

    Sub New(ByVal id As Integer)
        Me._trainsTypeDAO = New TrainTypeDAO
        Me.TrainTypeID = id
    End Sub

    Public Function delete() As Integer
        Return Me._trainsTypeDAO.Delete(Me)
    End Function

    Public Function insert() As Integer
        Return Me._trainsTypeDAO.Insert(Me)
    End Function

    Public Function update() As Integer
        Return Me._trainsTypeDAO.Update(Me)
    End Function

    Public Sub read()
        _trainsTypeDAO.read(Me)
    End Sub

    Public Sub readAll(path As String)
        _trainsTypeDAO.ReadAll(path)

    End Sub

    Public Sub get_Rank_type_by_trips_betweenDates(startDate As Date, finishDate As Date)
        _trainsTypeDAO.get_Rank_type_by_trips_betweenDates(startDate, finishDate)
    End Sub
End Class
