Imports MySql.Data.MySqlClient
Module loadInfoEmployee
    Dim conn As New Database
    Public Sub loadDepartment()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_department ORDER BY departmentCode ASC", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddEmployee.cbDepartment)
                .DataSource = table
                .ValueMember = "departmentCode"
                .DisplayMember = "departmentDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Public Sub loadMainDepartment()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_department ORDER BY departmentCode ASC", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmMaintenanceEmployee.cbDepartment)
                .DataSource = table
                .ValueMember = "departmentCode"
                .DisplayMember = "departmentDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
End Module
