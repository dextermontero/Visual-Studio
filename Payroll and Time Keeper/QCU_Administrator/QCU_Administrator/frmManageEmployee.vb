Imports MySql.Data.MySqlClient
Public Class frmManageEmployee
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Me.Hide()
        frmSubAddEmployee.ShowDialog()
    End Sub

    Private Sub frmManageEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployee()
        reload.Enabled = False
    End Sub
    Private Sub loadEmployee()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvEmployee.Items.Clear()
            Dim employee As ListViewItem
            While dr.Read
                employee = New ListViewItem(dr("EmployeeCode").ToString)
                employee.SubItems.Add(dr("Firstname"))
                employee.SubItems.Add(dr("MiddleName"))
                employee.SubItems.Add(dr("Lastname"))
                employee.SubItems.Add(dr("Department"))
                employee.SubItems.Add(dr("position"))
                employee.SubItems.Add(Format(dr("hired"), "MM/dd/yyyy"))
                employee.SubItems.Add(dr("Employment"))
                lvEmployee.Items.Add(employee)
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

    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvEmployee.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR Firstname LIKE '" & txtSearchEmployee.Text & "%' OR Lastname LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim employee As ListViewItem
            While dr.Read
                employee = New ListViewItem(dr("EmployeeCode").ToString)
                employee.SubItems.Add(dr("Firstname"))
                employee.SubItems.Add(dr("MiddleName"))
                employee.SubItems.Add(dr("Lastname"))
                employee.SubItems.Add(dr("Department"))
                employee.SubItems.Add(dr("position"))
                employee.SubItems.Add(Format(dr("hired"), "MM/dd/yyyy"))
                employee.SubItems.Add(dr("Employment"))
                lvEmployee.Items.Add(employee)
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
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Employee Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmAdminDashboard.Show()
        End If
    End Sub
    Private Sub lvEmployee_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvEmployee.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvEmployee.Columns(DCol).Width
            End If
        Next DCol
    End Sub

    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click
        Me.Close()
        frmMaintenanceEmployee.ShowDialog()
    End Sub

    Private Sub reload_Tick(sender As Object, e As EventArgs) Handles reload.Tick
        frmManageEmployee_Load(e, e)
        Refresh()
    End Sub
End Class