Imports Microsoft.VisualBasic
Imports System.Data.OleDb


Public Class BrokerDB

    Private Shared StrConnection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared myConnection As OleDbConnection
    Private Shared myInstance As BrokerDB
    Private Shared _path As String

    Private Sub New(ByVal path As String)
        Me.Ruta = path
        BrokerDB.myConnection = New OleDbConnection(StrConnection + _path)
        BrokerDB.myConnection.Open()
    End Sub

    Private Sub New()
        BrokerDB.myConnection = New OleDbConnection(StrConnection + _path)
        BrokerDB.myConnection.Open()
    End Sub

    Public Property Ruta As String
        Get
            Return _path

        End Get
        Set(value As String)
            _path = value

        End Set
    End Property

    Public Shared Function getBroker(ByVal ruta As String) As BrokerDB
        If (myInstance Is Nothing) Then
            myInstance = New BrokerDB(ruta)
        End If
    End Function


    Public Shared Function getBroker() As BrokerDB
        If (myInstance Is Nothing) Then
            myInstance = New BrokerDB()
        End If

        Return myInstance
    End Function

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, myConnection)
        Return com.ExecuteReader()
    End Function

    Public Function update(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, myConnection)
        Return com.ExecuteNonQuery()
    End Function
End Class