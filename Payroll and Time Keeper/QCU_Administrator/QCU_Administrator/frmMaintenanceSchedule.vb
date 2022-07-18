Imports MySql.Data.MySqlClient
Public Class frmMaintenanceSchedule
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Me.Close()
        frmSubAddClass.Show()
    End Sub
    Private Sub frmMaintenanceSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaintenanceSchedule.loadSched()
        MaintenanceSchedule.loadCourse() ' this is a module that can load course into Combobox
        MaintenanceSchedule.loadSection() ' this is a module that can load section into Combobox
        MaintenanceSchedule.loadYear() ' this is a module that can load year into Combobox
        MaintenanceSchedule.loadSubject() ' this is a module that can load subject into Combobox
        MaintenanceSchedule.loadRoom() ' this is a module that can load subject into Combobox
        lblID.Text = ""
        lblValidate.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Add Schedule Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageSchedule.Show()
        End If
    End Sub
    Private Sub lvSchedule_MouseClick(sender As Object, e As MouseEventArgs) Handles lvSchedule.MouseClick
        Dim id As String = lvSchedule.SelectedItems(0).SubItems(0).Text
        Dim code As String = lvSchedule.SelectedItems(0).SubItems(1).Text
        Dim firstname As String = lvSchedule.SelectedItems(0).SubItems(2).Text
        Dim lastname As String = lvSchedule.SelectedItems(0).SubItems(3).Text
        Dim department As String = lvSchedule.SelectedItems(0).SubItems(4).Text
        Dim day As String = lvSchedule.SelectedItems(0).SubItems(5).Text
        Dim section As String = lvSchedule.SelectedItems(0).SubItems(7).ToString
        Dim unit As Integer = lvSchedule.SelectedItems(0).SubItems(11).Text
        txtEmployeeCode.Text = id
        txtCode.Text = code
        txtFirstName.Text = firstname
        txtLastName.Text = lastname
        txtDepartment.Text = department
        cbDay.SelectedItem = day
        txtUnit.Text = unit
        cbSection.Text = section
        txtSearchEmployee.Text = id
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        validateScheduleDelete.ShowDialog()
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
                cmd.CommandText = "DELETE FROM tbl_schedule WHERE EmployeeCode = '" & txtEmployeeCode.Text & "' AND scheduleID = '" & lblID.Text & "'"
                If txtEmployeeCode.Text = Nothing Then
                    MsgBox("Select the Employee Code to delete!", MsgBoxStyle.Information, "Maintenance Leave")
                Else
                    If MsgBox("Are you sure you want to delete this information?", MsgBoxStyle.YesNo, "Maintenance Leave") = MsgBoxResult.Yes Then
                        MsgBox("Employee Leave information has been deleted!", MsgBoxStyle.Information, "Maintenance Leave")
                        cmd.ExecuteNonQuery()
                        frmManageSchedule.reload.Enabled = True
                    Else
                        MsgBox("Employee Leave information did not delete!", MsgBoxStyle.Information, "Maintenance Leave")
                    End If
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            cmd.Parameters.Clear()
            frmMaintenanceSchedule_Load(e, e)
            Refresh()
            conn.close()
        End Try
    End Sub

    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvSchedule.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_schedule WHERE EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR FirstName LIKE '" & txtSearchEmployee.Text & "%' OR LastName LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim sched As ListViewItem
            While dr.Read
                lblID.Text = dr("scheduleID")
                sched = New ListViewItem(dr("EmployeeCode").ToString)
                sched.SubItems.Add(dr("Code"))
                sched.SubItems.Add(dr("FirstName"))
                sched.SubItems.Add(dr("LastName"))
                sched.SubItems.Add(dr("Department"))
                sched.SubItems.Add(dr("Day"))
                sched.SubItems.Add(dr("Course"))
                sched.SubItems.Add(dr("Section"))
                sched.SubItems.Add(dr("Year"))
                sched.SubItems.Add(dr("Subject"))
                sched.SubItems.Add(dr("Room"))
                sched.SubItems.Add(dr("Unit"))
                sched.SubItems.Add(dr("StartTime").ToString)
                sched.SubItems.Add(dr("EndTime").ToString)
                lvSchedule.Items.Add(sched)
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        validateScheduleDelete.ShowDialog()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "UPDATE tbl_schedule SET EmployeeCode = '" & txtEmployeeCode.Text & "', Code = '" & txtCode.Text & "', FirstName = '" & txtFirstName.Text & "', LastName = '" & txtLastName.Text & "', Department = '" & txtDepartment.Text & "', Day = '" & cbDay.SelectedItem & "', courseCode = '" & cbCourse.SelectedValue.ToString & "', Course = '" & cbCourse.Text & "', Section = '" & cbSection.Text & "', Year = '" & cbYear.SelectedValue.ToString & "', Subject = '" & cbSubject.Text & "', Room = '" & cbRoom.Text & "', Unit = '" & txtUnit.Text & "', StartTime = '" & dtpStart.Value.ToShortTimeString & "', EndTime = '" & dtpEnd.Value.ToShortTimeString & "' WHERE EmployeeCode = '" & txtEmployeeCode.Text & "' AND scheduleID = '" & lblID.Text & "'"
            If txtEmployeeCode.Text = Nothing Then
                MsgBox("Select the Employee Code to delete!", MsgBoxStyle.Information, "Maintenance Schedule")
            Else
                If MsgBox("Are you sure you want to update this schedule?", MsgBoxStyle.YesNo, "QCU - Maintenance Schedule") = MsgBoxResult.Yes Then
                    dr = cmd.ExecuteReader
                    MsgBox("Employee Schedule has been updated!", MsgBoxStyle.Information, "Maintenance Schedule")
                    frmManageSchedule.reload.Enabled = True
                    cleartxt()
                Else
                    MsgBox("Employee Schedule has not been updated!", MsgBoxStyle.Information, "Maintenance Schedule")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
            frmMaintenanceSchedule_Load(e, e)
            Refresh()
        End Try
    End Sub

    Private Sub cbSubject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSubject.SelectedIndexChanged
        txtCode.Text = cbSubject.SelectedValue.ToString
    End Sub
    Private Sub cleartxt()
        txtEmployeeCode.Text = ""
        txtSearchEmployee.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtDepartment.Text = ""
        cbDay.SelectedIndex = -1
        txtCode.Text = ""
        txtUnit.Text = ""
    End Sub
End Class