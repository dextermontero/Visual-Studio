Option Explicit On

Imports MySql.Data.MySqlClient
Public Class frmSubAddLeave
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim dr As MySqlDataReader
    Dim da As New MySqlDataAdapter
    Dim table As New DataTable()
    Dim fname As String
    Dim sname As String
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Add Leave") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageLeave.Show()
        End If
    End Sub
    Private Sub btnDelete_MouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover
        btnAdd.BackColor = Color.FromArgb(40, 167, 69)
        btnAdd.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.BackColor = Color.Transparent
        btnAdd.ForeColor = Color.FromArgb(40, 167, 69)
    End Sub
    Private Sub loadEmp()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT EmployeeCode,CONCAT(FirstName, '" & " " & "', LastName) AS EmployeeName FROM tbl_employee", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (cbList)
                .DataSource = table
                cbList.ValueMember = "EmployeeCode"
                cbList.DisplayMember = "EmployeeName"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Private Sub loadData()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode = '" & txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                txtFirstName.Text = dr("FirstName")
                txtLastName.Text = dr("LastName")
                txtDepartment.Text = dr("Department")
                txtLeaveLeft.Text = dr("leaveLeft")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub frmSubAddLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmp()
        loadLeave()
        loadData()
        tmrReload.Enabled = False
    End Sub
    Private Sub cbList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbList.SelectedIndexChanged
        txtEmployeeCode.Text = cbList.SelectedValue.ToString
    End Sub
    Private Sub txtEmployeeCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeCode.TextChanged
        loadData()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If cbLeave.SelectedItem Is Nothing Or txtReason.Text Is Nothing Then
                MsgBox("Fill up the required fields", MsgBoxStyle.Information, "Add Employee Leave")
            Else
                conn.close()
                cmd.Connection = conn.open
                cmd.CommandText = "INSERT INTO tbl_leave(EmployeeCode,FirstName,LastName,Department,LeaveType,leaveLeft,startDay,endDay,reasons)VALUES(@EmployeeCode,@FirstName,@LastName,@Department,@LeaveType,@leaveLeft,@startDay,@endDay,@reasons)"
                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
                cmd.Parameters.AddWithValue("@LeaveType", cbLeave.Text)
                cmd.Parameters.AddWithValue("@leaveLeft", Val(txtLeaveLeft.Text) - 1)
                cmd.Parameters.AddWithValue("@startDay", dtpStart.Value.Date)
                cmd.Parameters.AddWithValue("@endDay", dtpEnd.Value.Date)
                cmd.Parameters.AddWithValue("@reasons", txtReason.Text)
                conn.close()
                cmd1.Connection = conn.open
                cmd1.CommandText = "UPDATE tbl_employee SET leaveLeft = '" & Val(txtLeaveLeft.Text) - 1 & "' WHERE EmployeeCode = '" & txtEmployeeCode.Text & "'"
                cmd.ExecuteNonQuery()
                dr = cmd1.ExecuteReader()
                frmManageLeave.reload.Enabled = True
                frmMaintenanceLeave.tmrReload.Enabled = True
                cleartxt()
                cbList.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd1.Dispose()
            cmd1.Parameters.Clear()
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmSubAddLeave_Load(e, e)
            Refresh()
        End Try
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
    Private Sub cleartxt()
        cbLeave.SelectedIndex = -1
        txtReason.Text = ""
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