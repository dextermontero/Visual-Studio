Imports MySql.Data.MySqlClient
Public Class frmManageLeave
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
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
                leaves.SubItems.Add(dr("FirstName"))
                leaves.SubItems.Add(dr("LastName"))
                leaves.SubItems.Add(dr("Department"))
                leaves.SubItems.Add(dr("leaveType"))
                leaves.SubItems.Add(dr("leaveLeft"))
                leaves.SubItems.Add(Format(dr("startDay"), "MM/dd/yyyy"))
                leaves.SubItems.Add(Format(dr("endDay"), "MM/dd/yyyy"))
                leaves.SubItems.Add(dr("reasons"))
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
    Private Sub frmManageLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLeave() ' load the data of leave's
        reload.Enabled = False
    End Sub
    Private Sub frmManageLeave_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAdminDashboard.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddLeave.Click
        frmSubAddLeave.ShowDialog()
    End Sub
    Private Sub reload_Tick(sender As Object, e As EventArgs) Handles reload.Tick
        frmManageLeave_Load(e, e)
        Refresh()
    End Sub
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvLeave.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_leave WHERE EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR FirstName LIKE '" & txtSearchEmployee.Text & "%' OR LastName LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim leaves As ListViewItem
            While dr.Read
                leaves = New ListViewItem(dr("EmployeeCode").ToString)
                leaves.SubItems.Add(dr("FirstName"))
                leaves.SubItems.Add(dr("LastName"))
                leaves.SubItems.Add(dr("Department"))
                leaves.SubItems.Add(dr("leaveType"))
                leaves.SubItems.Add(dr("leaveLeft"))
                leaves.SubItems.Add(Format(dr("startDay"), "MM/dd/yyyy"))
                leaves.SubItems.Add(Format(dr("endDay"), "MM/dd/yyyy"))
                leaves.SubItems.Add(dr("reasons"))
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
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Leave Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmAdminDashboard.Show()
        End If
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        Me.Hide()
        frmMaintenanceLeave.ShowDialog()
    End Sub
    Private Sub lvLeave_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvLeave.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvLeave.Columns(DCol).Width
            End If
        Next DCol
    End Sub

    Private Sub lblSearchEmployee_Click(sender As Object, e As EventArgs) Handles lblSearchEmployee.Click

    End Sub
End Class