Imports MySql.Data.MySqlClient
Module loadEmployeeSalary
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public Sub loadSalaryEmp()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT EmployeeCode,CONCAT(FirstName, '" & " " & "', LastName) AS EmployeeName FROM tbl_employee", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmManageSalary.cbEmployee)
                .DataSource = table
                .ValueMember = "EmployeeCode"
                .DisplayMember = "EmployeeName"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
End Module
