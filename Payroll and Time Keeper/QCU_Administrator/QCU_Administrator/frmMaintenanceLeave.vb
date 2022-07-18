Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class frmMaintenanceLeave
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnDelete.MouseHover
        btnDelete.BackColor = Color.FromArgb(255, 193, 7)
        btnDelete.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackColor = Color.Transparent
        btnDelete.ForeColor = Color.FromArgb(255, 193, 7)
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Maintenance Leave") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageLeave.Show()
        End If
    End Sub
    Private Sub frmMaintenanceLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clearload()
        loadleave()
        tmrReload.Enabled = False
        lblID.Text = ""
        lblValidate.Text = ""
    End Sub
    Private Sub loadleave()
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
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvLeave.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_leave WHERE EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR FirstName LIKE '" & txtSearchEmployee.Text & "%' OR LastName LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim leaves As ListViewItem
            While dr.Read
                lblID.Text = dr("leaveID")
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
    Private Sub lvLeave_MouseClick(sender As Object, e As MouseEventArgs) Handles lvLeave.MouseClick
        Dim id As String = lvLeave.SelectedItems(0).SubItems(0).Text
        Dim firstname As String = lvLeave.SelectedItems(0).SubItems(1).Text
        Dim lastname As String = lvLeave.SelectedItems(0).SubItems(2).Text
        Dim department As String = lvLeave.SelectedItems(0).SubItems(3).Text
        Dim leave As String = lvLeave.SelectedItems(0).SubItems(4).Text
        Dim leaveCount As String = lvLeave.SelectedItems(0).SubItems(5).Text
        Dim startDay As String = lvLeave.SelectedItems(0).SubItems(6).Text
        Dim endDay As String = lvLeave.SelectedItems(0).SubItems(7).Text
        Dim reason As String = lvLeave.SelectedItems(0).SubItems(8).Text
        txtEmployeeCode.Text = id
        txtSearchEmployee.Text = id
        txtFirstName.Text = firstname
        txtLastName.Text = lastname
        txtDepartment.Text = department
        cbLeave.Text = leave
        txtLeaveLeft.Text = leaveCount
        txtStartDay.Text = startDay
        txtEndDay.Text = endDay
        txtReason.Text = reason
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        validateMaintenanceDelete.ShowDialog()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE adminID = @id AND Password = @Password"
            cmd.Parameters.AddWithValue("@id", adminID.Text)
            cmd.Parameters.AddWithValue("@Password", lblValidate.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                conn.close()
                cmd.Connection = conn.open()
                cmd.CommandText = "DELETE FROM tbl_leave WHERE EmployeeCode = '" & txtEmployeeCode.Text & "' AND leaveID = '" & lblID.Text & "'"
                If txtEmployeeCode.Text = Nothing Then
                    MsgBox("Select the Employee Code to delete!", MsgBoxStyle.Information, "Maintenance Leave")
                Else
                    If MsgBox("Are you sure you want to delete this information?", MsgBoxStyle.YesNo, "Maintenance Leave") = MsgBoxResult.Yes Then
                        cmd.ExecuteNonQuery()
                        MsgBox("Employee Leave information has been deleted!", MsgBoxStyle.Information, "Maintenance Leave")
                        cleartxt()
                        frmManageLeave.reload.Enabled = True
                    Else
                        MsgBox("Employee Leave information did not delete!", MsgBoxStyle.Information, "Maintenance Leave")
                    End If
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            cmd.Parameters.Clear()
            dr.Dispose()
            dr.Close()
            conn.close()
            frmMaintenanceLeave_Load(e, e)
            Refresh()
            cleartxt()
        End Try
    End Sub
    Private Sub cleartxt()
        txtEmployeeCode.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDepartment.Text = ""
        cbLeave.Text = ""
        txtLeaveLeft.Text = ""
        txtReason.Text = ""
        txtStartDay.Text = ""
        txtEndDay.Text = ""
    End Sub

    Private Sub tmrReload_Tick(sender As Object, e As EventArgs) Handles tmrReload.Tick
        frmMaintenanceLeave_Load(e, e)
        Refresh()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Close()
        frmSubAddLeave.Show()
    End Sub
    Private Sub clearload()
        txtEmployeeCode.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDepartment.Text = ""
        cbLeave.Text = ""
        txtLeaveLeft.Text = ""
        txtStartDay.Text = ""
        txtEndDay.Text = ""
        txtReason.Text = ""
        txtSearchEmployee.Text = ""
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
End Class