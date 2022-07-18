Imports MySql.Data.MySqlClient
Public Class Database
    Public conn As New MySqlConnection("Server=localhost;Username=root;Password=;Database=payrollandtimekeeperdb")
    Public Function open()
        Try
            conn.open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conn
    End Function
    Public Function close()
        Try
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conn
    End Function
    Public Function dispose()
        Try
            conn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conn
    End Function
End Class