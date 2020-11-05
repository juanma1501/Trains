Imports Microsoft.VisualBasic
Imports System.Data.OleDb


Public Class BrokerDB

    Private Shared CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD
    Private Shared _ruta As String

    Private Sub New(ByVal ruta As String)
        Me._ruta = ruta
        AgenteBD.mConexion = New OleDbConnection(CadConexion + _ruta)
        AgenteBD.mConexion.Open()
    End Sub

    Private Sub New()
        AgenteBD.mConexion = New OleDbConnection(CadConexion + _ruta)
        AgenteBD.mConexion.Open()
    End Sub

    Public Property Ruta As String
        Get
            Return _ruta

        End Get
        Set(value As String)
            _ruta = value

        End Set
    End Property

    Public Shared Function getAgente(ByVal ruta As String) As AgenteBD
        If (mInstancia Is Nothing) Then
            mInstancia = New AgenteBD(ruta)
        End If
    End Function


    Public Shared Function getAgente() As AgenteBD
        If (mInstancia Is Nothing) Then
            mInstancia = New AgenteBD()
        End If

        Return mInstancia
    End Function

    Public Function leer(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function

    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function
End Class