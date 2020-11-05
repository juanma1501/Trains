Imports Microsoft.VisualBasic
Imports System.Data.OleDb


Public Class BrokerDB

    Private Shared _Instance As BrokerDB
    Private Shared connection As OleDb.OleDbConnection
    Private Shared connectionString As String

    Private Sub New()
        BrokerDB.connection = New OleDb.OleDbConnection(BrokerDB.connectionString)
    End Sub

    Public Shared Function getBroker() As BrokerDB
        If BrokerDB._Instance Is Nothing Then
            BrokerDB._Instance = New BrokerDB
        End If
        Return BrokerDB._Instance
    End Function

    Public Shared Function getBroker(path As String) As BrokerDB
        BrokerDB.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & path
        BrokerDB.connection = New OleDb.OleDbConnection(BrokerDB.connectionString)
        Return BrokerDB.getBroker
    End Function

    Public Function read(sql As String) As Collection
        Dim result As New Collection
        Dim row As Collection
        Dim i As Integer
        Dim reader As OleDb.OleDbDataReader
        Dim com As New OleDb.OleDbCommand(sql, BrokerDB.connection)
        Connect()
        reader = com.ExecuteReader
        While reader.Read
            row = New Collection
            For i = 0 To reader.FieldCount - 1
                row.Add(reader(i).ToString)
            Next
            result.Add(row)
        End While
        Disconnect()
        Return result
    End Function

    Public Function update(sql As String) As Integer
        Dim com As New OleDb.OleDbCommand(sql, BrokerDB.connection)
        Dim result As Integer
        Connect()
        result = com.ExecuteNonQuery
        Disconnect()
        Return result
    End Function

    Private Sub Connect()
        If BrokerDB.connection.State = ConnectionState.Closed Then
            BrokerDB.connection.Open()
        End If
    End Sub

    Private Sub Disconnect()
        If BrokerDB.connection.State = ConnectionState.Open Then
            BrokerDB.connection.Close()
        End If
    End Sub

End Class