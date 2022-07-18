Imports MySql.Data.MySqlClient
Public Class frmSubAddClass
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Add Schedule Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageSchedule.Show()
        End If
    End Sub
    Private Sub frmSubAddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmp()
        loadEmployeeAddSchedule.loadEmp() ' this is a module that can load into Combobox
        loadEmployeeAddSchedule.loadCourse() ' this is a module that can load course into Combobox
        loadEmployeeAddSchedule.loadSection() ' this is a module that can load section into Combobox
        loadEmployeeAddSchedule.loadYear() ' this is a module that can load year into Combobox
        loadEmployeeAddSchedule.loadSubject() ' this is a module that can load subject into Combobox
        loadEmployeeAddSchedule.loadRoom() ' this is a module that can load subject into Combobox
        lvSchedule.Items.Clear()
    End Sub
    Private Sub loadData()
    End Sub
    Private Sub cbList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbList.SelectedIndexChanged
        txtEmployeeCode.Text = cbList.SelectedValue.ToString
    End Sub
    Private Sub txtEmployeeCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeCode.TextChanged
        loadEmployeeAddSchedule.loadData() ' this is a module that can load the data into textbox
    End Sub
    Private Sub lvSchedule_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvSchedule.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvSchedule.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    Private Sub txtUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_schedule WHERE EmployeeCode = '" & txtEmployeeCode.Text & "' AND Day = '" & cbDay.SelectedItem & "' AND Course = '" & cbCourse.Text & "' AND Section = '" & cbSection.Text & "' AND Subject = '" & cbSubject.Text & "' AND Room = '" & cbRoom.Text & "' AND startTime < '" & dtpStart.Value.ToString("h:mm tt") & "' AND endTime > '" & dtpEnd.Value.ToString("h:mm tt") & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                MsgBox("you are already has schedule this day and time", MsgBoxStyle.Information, "QCU - Add Employee Schedule")
            Else
                If cbDay.SelectedItem Is Nothing Or txtUnit.Text = "" Then
                    MsgBox("Fill up the empty fields", MsgBoxStyle.Information, "QCU - Add Employee Schedule")
                Else
                    conn.close()
                    cmd.Connection = conn.open
                    cmd.CommandText = "INSERT INTO tbl_schedule(EmployeeCode,Code,FirstName,LastName,Department,Year,Section,courseCode,Course,Subject,Unit,Room,Day,StartTime,EndTime)VALUES(@EmployeeCode,@Code,@FirstName,@LastName,@Department,@Year,@Section,@courseCode,@Course,@Subject,@Unit,@Room,@Day,@StartTime,@EndTime)"
                    cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                    cmd.Parameters.AddWithValue("@Code", cbSubject.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
                    cmd.Parameters.AddWithValue("@Year", cbYear.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@Section", cbSection.Text)
                    cmd.Parameters.AddWithValue("@courseCode", cbCourse.SelectedValue.ToString)
                    cmd.Parameters.AddWithValue("@Course", cbCourse.Text)
                    cmd.Parameters.AddWithValue("@Subject", cbSubject.Text)
                    cmd.Parameters.AddWithValue("@Unit", txtUnit.Text)
                    cmd.Parameters.AddWithValue("@Room", cbRoom.Text)
                    cmd.Parameters.AddWithValue("@Day", cbDay.SelectedItem)
                    cmd.Parameters.AddWithValue("@StartTime", dtpStart.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@EndTime", dtpEnd.Value.TimeOfDay)
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfully added schedule", MsgBoxStyle.Information, "QCU - Add Employee Schedule")
                    frmManageSchedule.reload.Enabled = True
                    Dim lvshow As ListViewItem
                    lvshow = New ListViewItem(txtEmployeeCode.Text)
                    lvshow.SubItems.Add(cbSubject.SelectedValue.ToString)
                    lvshow.SubItems.Add(txtFirstName.Text)
                    lvshow.SubItems.Add(txtLastName.Text)
                    lvshow.SubItems.Add(txtDepartment.Text)
                    lvshow.SubItems.Add(cbDay.SelectedItem)
                    lvshow.SubItems.Add(cbCourse.SelectedValue.ToString)
                    lvshow.SubItems.Add(cbSection.Text)
                    lvshow.SubItems.Add(cbYear.SelectedValue)
                    lvshow.SubItems.Add(cbSubject.Text)
                    lvshow.SubItems.Add(cbRoom.Text)
                    lvshow.SubItems.Add(txtUnit.Text)
                    lvshow.SubItems.Add(dtpStart.Value.ToShortTimeString)
                    lvshow.SubItems.Add(dtpEnd.Value.ToShortTimeString)
                    lvSchedule.Items.Add(lvshow)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            dr.Dispose()
            dr.Close()
            conn.close()
        End Try
    End Sub
End Class