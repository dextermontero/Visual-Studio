Imports MySql.Data.MySqlClient
Public Class frmReports
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmReports_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAdminDashboard.Show()
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReport()
    End Sub
    Private Sub loadReport()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT tbl_salary.EmployeeCode,tbl_salary.FirstName,tbl_salary.LastName,tbl_employee.monthlySalary,tbl_salary.hours,tbl_salary.work,tbl_salary.sss,tbl_salary.tin,tbl_salary.pagibig,tbl_salary.philhealth,tbl_salary.net FROM tbl_salary LEFT JOIN tbl_employee ON tbl_salary.EmployeeCode = tbl_employee.EmployeeCode"
            dr = cmd.ExecuteReader
            lvReports.Items.Clear()
            Dim report As ListViewItem
            While dr.Read
                report = New ListViewItem(dr("EmployeeCode").ToString)
                report.SubItems.Add(dr("FirstName"))
                report.SubItems.Add(dr("LastName"))
                report.SubItems.Add(dr("monthlySalary"))
                report.SubItems.Add(dr("hours"))
                report.SubItems.Add(dr("work"))
                report.SubItems.Add(dr("sss"))
                report.SubItems.Add(dr("tin"))
                report.SubItems.Add(dr("pagibig"))
                report.SubItems.Add(dr("philhealth"))
                report.SubItems.Add(dr("net"))
                lvReports.Items.Add(report)
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
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Maintenance Leave") = MsgBoxResult.Yes Then
            Me.Close()
            frmAdminDashboard.Show()
        End If
    End Sub

    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvReports.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT tbl_salary.EmployeeCode,tbl_salary.FirstName,tbl_salary.LastName,tbl_employee.monthlySalary,tbl_salary.hours,tbl_salary.work,tbl_salary.sss,tbl_salary.tin,tbl_salary.pagibig,tbl_salary.philhealth,tbl_salary.net FROM tbl_salary LEFT JOIN tbl_employee ON tbl_salary.EmployeeCode = tbl_employee.EmployeeCode WHERE tbl_employee.EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR tbl_employee.FirstName LIKE '" & txtSearchEmployee.Text & "%' OR tbl_employee.LastName LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim report As ListViewItem
            While dr.Read
                report = New ListViewItem(dr("EmployeeCode").ToString)
                report.SubItems.Add(dr("FirstName"))
                report.SubItems.Add(dr("LastName"))
                report.SubItems.Add(dr("monthlySalary"))
                report.SubItems.Add(dr("hours"))
                report.SubItems.Add(dr("work"))
                report.SubItems.Add(dr("sss"))
                report.SubItems.Add(dr("tin"))
                report.SubItems.Add(dr("pagibig"))
                report.SubItems.Add(dr("philhealth"))
                report.SubItems.Add(dr("net"))
                lvReports.Items.Add(report)
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