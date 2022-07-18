Imports MySql.Data.MySqlClient
Public Class frmManageSchedule
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmManageSchedule_load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSub()
        reload.Enabled = False
    End Sub
    Private Sub loadSub()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT EmployeeCode,Code,FirstName,LastName,CONCAT(courseCode, '" & "" & "', Year,'" & "" & "', Section ,' - " & " " & "',Subject) as section_subject,Unit,Room,Day,CONCAT(StartTime,'  - " & " " & "', EndTime) as Time FROM tbl_schedule"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvReports.Items.Clear()
            Dim show As ListViewItem
            While dr.Read
                show = New ListViewItem(dr("EmployeeCode").ToString)
                show.SubItems.Add(dr("Code"))
                show.SubItems.Add(dr("FirstName"))
                show.SubItems.Add(dr("LastName"))
                show.SubItems.Add(dr("section_subject"))
                show.SubItems.Add(dr("Unit"))
                show.SubItems.Add(dr("Room"))
                show.SubItems.Add(dr("Day"))
                show.SubItems.Add(dr("Time").ToString)
                lvReports.Items.Add(show)
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

    Private Sub txtEmployeeCode_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeCode.TextChanged
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT EmployeeCode,Code,FirstName,LastName,CONCAT(Year,'" & "" & "', Section ,' - " & " " & "',Subject) as section_subject,Unit,Room,Day,CONCAT(StartTime,'  - " & " " & "', EndTime) as Time FROM tbl_schedule WHERE EmployeeCode LIKE '%" & txtEmployeeCode.Text & "%' OR FirstName LIKE '" & txtEmployeeCode.Text & "%' OR LastName LIKE '" & txtEmployeeCode.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvReports.Items.Clear()
            Dim show As ListViewItem
            While dr.Read
                show = New ListViewItem(dr("EmployeeCode").ToString)
                show.SubItems.Add(dr("Code"))
                show.SubItems.Add(dr("FirstName"))
                show.SubItems.Add(dr("LastName"))
                show.SubItems.Add(dr("section_subject"))
                show.SubItems.Add(dr("Unit"))
                show.SubItems.Add(dr("Room"))
                show.SubItems.Add(dr("Day"))
                show.SubItems.Add(dr("Time"))
                lvReports.Items.Add(show)
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
    Private Sub frmAddClass_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAdminDashboard.Show()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Add Schedule Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmAdminDashboard.Show()
        End If
    End Sub

    Private Sub btnAddClass_Click_1(sender As Object, e As EventArgs) Handles btnAddClass.Click
        Me.Hide()
        frmSubAddClass.Show()
    End Sub
    Private Sub lvSubject_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvReports.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5, 6, 7, 8}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvReports.Columns(DCol).Width
            End If
        Next DCol
    End Sub
    Private Sub reload_Tick(sender As Object, e As EventArgs) Handles reload.Tick
        frmManageSchedule_load(e, e)
        Refresh
    End Sub
    Private Sub btnManageAdd_Click(sender As Object, e As EventArgs) Handles btnManageAdd.Click
        Me.Hide()
        frmMaintenanceSchedule.Show()
    End Sub
End Class