Imports MySql.Data.MySqlClient
Public Class frmSubLeaveMoreInfo
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmSubLeaveMoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLeave()
    End Sub
    Private Sub loadLeave()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_leave"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvLeave.Items.Clear()
            Dim leaves As ListViewItem
            While dr.Read
                leaves = New ListViewItem(dr("EmployeeCode").ToString)
                leaves.SubItems.Add(dr("EmployeeName"))
                leaves.SubItems.Add(dr("Department"))
                leaves.SubItems.Add(dr("leaveType"))
                leaves.SubItems.Add(dr("startDay").ToString)
                leaves.SubItems.Add(dr("endDay").ToString)
                lvLeave.Items.Add(leaves)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
End Class