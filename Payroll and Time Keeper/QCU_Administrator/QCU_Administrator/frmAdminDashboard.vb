Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmAdminDashboard
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub pnlAdmin_MouseHover(sender As Object, e As EventArgs) Handles pnlAdmin.MouseHover
        pnlAdmin.ForeColor = Color.White
        pnlAdmin.BackColor = Color.FromArgb(23, 162, 184)
    End Sub
    Private Sub pnlAdmin_MouseLeave(sender As Object, e As EventArgs) Handles pnlAdmin.MouseLeave
        pnlAdmin.BackColor = Color.FromArgb(255, 255, 255)
        pnlAdmin.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub lnkAdminInfo_MouseHover(sender As Object, e As EventArgs) Handles lnkAdminInfo.MouseHover
        pnlAdmin.ForeColor = Color.White
        pnlAdmin.BackColor = Color.FromArgb(23, 162, 184)
        lnkAdminInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub pcbAdmin_MouseHover(sender As Object, e As EventArgs) Handles pcbAdmin.MouseHover
        pnlAdmin.ForeColor = Color.White
        pnlAdmin.BackColor = Color.FromArgb(23, 162, 184)
        lnkAdminInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub lblTotalAdminNo_MouseHover(sender As Object, e As EventArgs) Handles lblTotalAdminNo.MouseHover
        pnlAdmin.ForeColor = Color.White
        pnlAdmin.BackColor = Color.FromArgb(23, 162, 184)
        lnkAdminInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub lblTotalAdmin_MouseHover(sender As Object, e As EventArgs) Handles lblTotalAdmin.MouseHover
        pnlAdmin.ForeColor = Color.White
        pnlAdmin.BackColor = Color.FromArgb(23, 162, 184)
        lnkAdminInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub pnlEmployee_MouseHover(sender As Object, e As EventArgs) Handles pnlEmployee.MouseHover
        pnlEmployee.ForeColor = Color.White
        pnlEmployee.BackColor = Color.FromArgb(23, 162, 184)
    End Sub
    Private Sub pnlEmployee_MouseLeave(sender As Object, e As EventArgs) Handles pnlEmployee.MouseLeave
        pnlEmployee.BackColor = Color.FromArgb(255, 255, 255)
        pnlEmployee.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub lnkEmployeeInfo_MouseHover(sender As Object, e As EventArgs) Handles lnkEmployeeInfo.MouseHover
        pnlEmployee.ForeColor = Color.White
        pnlEmployee.BackColor = Color.FromArgb(23, 162, 184)
        lnkEmployeeInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub pcbEmployee_MouseHover(sender As Object, e As EventArgs) Handles pcbEmployee.MouseHover
        pnlEmployee.ForeColor = Color.White
        pnlEmployee.BackColor = Color.FromArgb(23, 162, 184)
        lnkEmployeeInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub lblTotalEmployeeNo_MouseHover(sender As Object, e As EventArgs) Handles lblTotalEmployeeNo.MouseHover
        pnlEmployee.ForeColor = Color.White
        pnlEmployee.BackColor = Color.FromArgb(23, 162, 184)
        lnkEmployeeInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub lblTotalEmployee_MouseHover(sender As Object, e As EventArgs) Handles lblTotalEmployee.MouseHover
        pnlEmployee.ForeColor = Color.White
        pnlEmployee.BackColor = Color.FromArgb(23, 162, 184)
        lnkEmployeeInfo.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub btnLogout_GotFocus(sender As Object, e As EventArgs) Handles btnLogout.GotFocus
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69)
        btnLogout.ForeColor = Color.FromArgb(220, 53, 69)
        btnLogout.BackColor = Color.FromArgb(224, 224, 224)
        btnLogout.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogout_LostFocus(sender As Object, e As EventArgs) Handles btnLogout.LostFocus
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69)
        btnLogout.ForeColor = Color.White
        btnLogout.BackColor = Color.FromArgb(220, 53, 69)
    End Sub
    Private Sub btnLogout_MouseHover(sender As Object, e As EventArgs) Handles btnLogout.MouseHover
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69)
        btnLogout.ForeColor = Color.FromArgb(220, 53, 69)
        btnLogout.BackColor = Color.Transparent
        btnLogout.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderColor = Color.FromArgb(220, 53, 69)
        btnLogout.ForeColor = Color.White
        btnLogout.BackColor = Color.FromArgb(220, 53, 69)
    End Sub
    Private Sub btnSettings_GotFocus(sender As Object, e As EventArgs) Handles btnSettings.GotFocus
        btnSettings.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnSettings.ForeColor = Color.FromArgb(108, 117, 125)
        btnSettings.BackColor = Color.FromArgb(224, 224, 224)
        btnSettings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnSettings_LostFocus(sender As Object, e As EventArgs) Handles btnSettings.LostFocus
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnSettings.ForeColor = Color.White
        btnSettings.BackColor = Color.FromArgb(108, 117, 125)
    End Sub
    Private Sub btnSettings_MouseHover(sender As Object, e As EventArgs) Handles btnSettings.MouseHover
        btnSettings.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnSettings.ForeColor = Color.FromArgb(108, 117, 125)
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnSettings.ForeColor = Color.White
        btnSettings.BackColor = Color.FromArgb(108, 117, 125)
    End Sub
    Private Sub pnlBackground_Paint(sender As Object, e As PaintEventArgs) Handles pnlBackground.Paint
        pnlBackground.BackColor = Color.FromArgb(39, 174, 96) 'color green
    End Sub
    Private Sub pnlBody_Paint(sender As Object, e As PaintEventArgs) Handles pnlBody.Paint
        pnlBody.BackColor = Color.FromArgb(236, 240, 241) 'color grey
    End Sub
    Private Sub btnAddEmployee_GotFocus(sender As Object, e As EventArgs) Handles btnAddEmployee.GotFocus
        btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.ForeColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.BackColor = Color.FromArgb(224, 224, 224)
        btnAddEmployee.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnAddEmployee_LostFocus(sender As Object, e As EventArgs) Handles btnAddEmployee.LostFocus
        btnAddEmployee.FlatStyle = FlatStyle.Flat
        btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.ForeColor = Color.White
        btnAddEmployee.BackColor = Color.FromArgb(108, 117, 125)
    End Sub
    Private Sub btnAddEmployee_MouseHover(sender As Object, e As EventArgs) Handles btnAddEmployee.MouseHover
        btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.ForeColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.BackColor = Color.FromArgb(224, 224, 224)
        btnAddEmployee.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnAddEmployee_MouseLeave(sender As Object, e As EventArgs) Handles btnAddEmployee.MouseLeave
        btnAddEmployee.FlatStyle = FlatStyle.Flat
        btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAddEmployee.ForeColor = Color.White
        btnAddEmployee.BackColor = Color.FromArgb(108, 117, 125)
    End Sub
    Private Sub btnManageLeave_MouseHover(sender As Object, e As EventArgs) Handles btnManageLeave.MouseHover
        btnManageLeave.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.ForeColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.BackColor = Color.FromArgb(224, 224, 224)
        btnManageLeave.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnManageLeave_MouseLeave(sender As Object, e As EventArgs) Handles btnManageLeave.MouseLeave
        btnManageLeave.FlatStyle = FlatStyle.Flat
        btnManageLeave.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.ForeColor = Color.White
        btnManageLeave.BackColor = Color.FromArgb(108, 117, 125)
    End Sub

    Private Sub btnManageLeave_LostFocus(sender As Object, e As EventArgs) Handles btnManageLeave.LostFocus
        btnManageLeave.FlatStyle = FlatStyle.Flat
        btnManageLeave.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.ForeColor = Color.White
        btnManageLeave.BackColor = Color.FromArgb(108, 117, 125)
    End Sub

    Private Sub btnManageLeave_GotFocus(sender As Object, e As EventArgs) Handles btnManageLeave.GotFocus
        btnManageLeave.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.ForeColor = Color.FromArgb(108, 117, 125)
        btnManageLeave.BackColor = Color.FromArgb(224, 224, 224)
        btnManageLeave.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub loadAdmin()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT COUNT(adminID) FROM tbl_admin"
            lblTotalAdminNo.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Total Administrator could not get!", MsgBoxStyle.Information, "Error : Total Administrator")
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.dispose()
            conn.close()
        End Try
    End Sub
    Private Sub loadData()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE adminID ='" & lblAdminID.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                lblAdminName.Text = dr("adminNickname")
                lblAdminName.Text = lblAdminName.Text.ToUpper
                Dim img() As Byte
                img = dr("adminProfile")
                Dim ms As New MemoryStream(img)
                pcbAdminPic.Image = Image.FromStream(ms)
                pcbAdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Else
                MsgBox("Error data load")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub loadEmployee()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT COUNT(employeeID) FROM tbl_employee"
            lblTotalEmployeeNo.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Total Employee could not get!", MsgBoxStyle.Information, "Error : Total Employee")
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.dispose()
            conn.close()
        End Try
    End Sub
    Private Sub loadDepartment()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT COUNT(departmentID) FROM tbl_department"
            totalDepartmentNo.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Total Department could not get!", MsgBoxStyle.Information, "Error : Total Department")
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.dispose()
            conn.close()
        End Try
    End Sub
    Private Sub loadTimeIn()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT employeeCode,fullname,Department,TimeIn FROM tbl_timein ORDER BY timeID DESC"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvTimeIn.Items.Clear()
            Dim timeIn As ListViewItem
            While dr.Read
                timeIn = New ListViewItem(dr("EmployeeCode").ToString)
                timeIn.SubItems.Add(dr("fullname"))
                timeIn.SubItems.Add(dr("Department"))
                timeIn.SubItems.Add(dr("TimeIn").ToString)
                lvTimeIn.Items.Add(timeIn)
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
    Private Sub loadTimeOut()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT employeeCode,fullname,Department,TimeOut FROM tbl_timein ORDER BY timeID DESC"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvTimeOut.Items.Clear()
            Dim timeOut As ListViewItem
            While dr.Read
                timeOut = New ListViewItem(dr("EmployeeCode").ToString)
                timeOut.SubItems.Add(dr("fullname"))
                timeOut.SubItems.Add(dr("Department"))
                timeOut.SubItems.Add(dr("TimeOut").ToString)
                lvTimeOut.Items.Add(timeOut)
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
    Private Sub loadsched()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT COUNT(scheduleID) FROM tbl_schedule"
            lblScheduleNo.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Total Schedule could not get!", MsgBoxStyle.Information, "Error : Total Schedule")
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.dispose()
            conn.close()
        End Try
    End Sub
    Private Sub loadLeave()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT COUNT(leaveID) FROM tbl_leave"
            lbltotalLeaveNo.Text = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Total Leave could not get!", MsgBoxStyle.Information, "Error : Total Employee")
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.dispose()
            conn.close()
        End Try
    End Sub
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAdmin() ' load total administrator
        loadEmployee() ' load total employee
        loadDepartment() ' load total department
        loadTimeIn() ' load time in logs
        loadTimeOut() ' load time out logs
        loadData() ' load dashboard data
        loadLeave() ' load leave data
        loadsched() ' load schedule data
        timeTick.Enabled = True ' for tick na clock 
        timeData.Enabled = False ' for refresh data
        lblDate.Text = Format(Date.Now, "M/dd/yyy") ' showing the date today
    End Sub
    Private Sub timeTick_Tick(sender As Object, e As EventArgs) Handles timeTick.Tick
        lblTime.Text = Format(Now, "h:mm:s tt")
        frmAdminDashboard_Load(e, e)
        Refresh()
    End Sub
    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvTimeIn.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvTimeIn.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    Private Sub ListView2_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvTimeOut.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvTimeOut.Columns(DCol).Width
            End If
        Next DCol
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        pcbAdminPic.Image = Nothing
        Me.Close()
        frmLoginAdministrator.Show()
    End Sub
    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmAccountSettings.ShowDialog()
    End Sub
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Me.Hide()
        frmReports.ShowDialog()
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        Me.Hide()
        frmManageEmployee.Show()
    End Sub

    Private Sub timeData_Tick(sender As Object, e As EventArgs) Handles timeData.Tick
        frmAdminDashboard_Load(e, e)
        Refresh()
    End Sub
    Private Sub pnlDepartment_MouseHover(sender As Object, e As EventArgs) Handles pnlDepartment.MouseHover
        pnlDepartment.ForeColor = Color.White
        pnlDepartment.BackColor = Color.FromArgb(23, 162, 184)
    End Sub
    Private Sub pnlDepartment_MouseLeave(sender As Object, e As EventArgs) Handles pnlDepartment.MouseLeave
        pnlDepartment.BackColor = Color.FromArgb(255, 255, 255)
        pnlDepartment.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub lnkDepartmentInfo_MouseHover(sender As Object, e As EventArgs) Handles lnkDepartmentInfo.MouseHover
        pnlDepartment.ForeColor = Color.White
        pnlDepartment.BackColor = Color.FromArgb(23, 162, 184)
        pnlDepartment.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub pcbDepartment_MouseHover(sender As Object, e As EventArgs) Handles pcbDepartment.MouseHover
        pnlDepartment.ForeColor = Color.White
        pnlDepartment.BackColor = Color.FromArgb(23, 162, 184)
        pnlDepartment.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub totalDepartmentNo_MouseHover(sender As Object, e As EventArgs) Handles totalDepartmentNo.MouseHover
        pnlDepartment.ForeColor = Color.White
        pnlDepartment.BackColor = Color.FromArgb(23, 162, 184)
        pnlDepartment.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub totalDepartment_MouseHover(sender As Object, e As EventArgs) Handles totalDepartment.MouseHover
        pnlDepartment.ForeColor = Color.White
        pnlDepartment.BackColor = Color.FromArgb(23, 162, 184)
        pnlDepartment.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Hide()
        frmManageSchedule.ShowDialog()
    End Sub
    Private Sub btnManageLeave_Click(sender As Object, e As EventArgs) Handles btnManageLeave.Click
        Me.Hide()
        frmManageLeave.ShowDialog()
    End Sub
    Private Sub lnkLeave_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLeave.LinkClicked
        frmManageLeave.ShowDialog()
    End Sub
    Private Sub btnAdd_MouseHover(sender As Object, e As EventArgs) Handles btnAdd.MouseHover
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAdd.ForeColor = Color.FromArgb(108, 117, 125)
        btnAdd.BackColor = Color.FromArgb(224, 224, 224)
        btnAdd.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnAdd_MouseLeave(sender As Object, e As EventArgs) Handles btnAdd.MouseLeave
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAdd.ForeColor = Color.White
        btnAdd.BackColor = Color.FromArgb(108, 117, 125)
    End Sub

    Private Sub btnAdd_GotFocus(sender As Object, e As EventArgs) Handles btnAdd.GotFocus
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAdd.ForeColor = Color.FromArgb(108, 117, 125)
        btnAdd.BackColor = Color.FromArgb(224, 224, 224)
        btnAdd.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnAdd_LostFocus(sender As Object, e As EventArgs) Handles btnAdd.LostFocus
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.FlatAppearance.BorderColor = Color.FromArgb(108, 117, 125)
        btnAdd.ForeColor = Color.White
        btnAdd.BackColor = Color.FromArgb(108, 117, 125)
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Me.Hide()
        frmMaintenance.Show()
    End Sub

    Private Sub lnkEmployeeInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEmployeeInfo.LinkClicked
        frmManageEmployee.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmManageSalary.ShowDialog()
    End Sub
    Private Sub lnkSchedule_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkSchedule.LinkClicked
        frmManageSchedule.ShowDialog()
    End Sub

    Private Sub lnkAdminInfo_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAdminInfo.LinkClicked
        frmManageAdmin.ShowDialog()
    End Sub
End Class