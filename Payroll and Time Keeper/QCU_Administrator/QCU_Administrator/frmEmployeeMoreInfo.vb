Imports MySql.Data.MySqlClient
Public Class frmEmployeeMoreInfo
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmEmployeeMoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployeeInfo()
    End Sub
    Private Sub loadEmployeeInfo()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT tbl_personalinfo.employeeCode,tbl_personalinfo.FirstName,tbl_personalinfo.MiddleName,tbl_personalinfo.LastName,tbl_personalinfo.Gender,tbl_personalinfo.Birthday,tbl_personalinfo.MartialStatus,tbl_personalinfo.Contact,tbl_personalinfo.Email,tbl_employee.Department,tbl_employee.positionType,tbl_employee.DOJ FROM tbl_personalinfo LEFT JOIN tbl_employee on tbl_personalinfo.employeeCode = tbl_employee.EmployeeCode"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvEmployeeInfo.Items.Clear()
            Dim load As ListViewItem
            While dr.Read
                load = New ListViewItem(dr("employeeCode").ToString)
                load.SubItems.Add(dr("FirstName"))
                load.SubItems.Add(dr("MiddleName"))
                load.SubItems.Add(dr("LastName"))
                load.SubItems.Add(dr("Gender"))
                load.SubItems.Add(dr("Birthday"))
                load.SubItems.Add(dr("MartialStatus"))
                load.SubItems.Add(dr("Contact"))
                load.SubItems.Add(dr("Email"))
                lvEmployeeInfo.Items.Add(load)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class