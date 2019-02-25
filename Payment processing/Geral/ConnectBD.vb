Imports System.Data.OleDb


Public Class ConnectBD

    Private Shared connectDb As ConnectBD = Nothing
    Private dbProvider As String
    Private dbSource As String
    Private connection As New OleDbConnection

    Private Sub New()
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        'dbSource = "Data Source = " & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\GestaoBoleto.mdb"
        dbSource = "Data Source = GestaoBoleto.mdb"
        connection.ConnectionString = dbProvider & dbSource
        connection.Open()
    End Sub

    Sub dispose()
        connection.Close()
    End Sub

    Public Shared Function Instancia() As ConnectBD
        If connectDb Is Nothing Then
            connectDb = New ConnectBD()
        End If

        Return connectDb

    End Function

    Public Function executeQuery(strSql As String) As DataSet
        Dim adp As New OleDbDataAdapter(strSql, connection)
        Dim ds As New DataSet()
        adp.Fill(ds)
        Return ds
    End Function

    Public Function executeNonQuery(cmd As OleDbCommand) As Integer
        cmd.Connection = connection
        Return cmd.ExecuteNonQuery()
    End Function

End Class
