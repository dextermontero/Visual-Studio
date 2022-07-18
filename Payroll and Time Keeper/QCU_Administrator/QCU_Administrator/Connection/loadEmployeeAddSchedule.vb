Imports MySql.Data.MySqlClient
Module loadEmployeeAddSchedule
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public Sub loadEmp()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT EmployeeCode,CONCAT(FirstName, '" & " " & "', LastName) AS EmployeeName FROM tbl_employee", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbList)
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
    Public Sub loadData()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode = '" & frmSubAddClass.txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                frmSubAddClass.txtFirstName.Text = dr("FirstName")
                frmSubAddClass.txtLastName.Text = dr("LastName")
                frmSubAddClass.txtDepartment.Text = dr("Department")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub loadCourse()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_course", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbCourse)
                .DataSource = table
                .ValueMember = "courseCode"
                .DisplayMember = "courseDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Public Sub loadSection()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_section", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbSection)
                .DataSource = table
                .ValueMember = "sectionCode"
                .DisplayMember = "sectionDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Public Sub loadYear()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_year", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbYear)
                .DataSource = table
                .ValueMember = "yearCode"
                .DisplayMember = "yearDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Public Sub loadSubject()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_subject", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbSubject)
                .DataSource = table
                .ValueMember = "subjectCode"
                .DisplayMember = "subjectDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
    Public Sub loadRoom()
        Try
            conn.close()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_room", conn.open)
            Dim da As New MySqlDataAdapter(cmd)
            Dim table As New DataTable
            da.Fill(table)
            With (frmSubAddClass.cbRoom)
                .DataSource = table
                .ValueMember = "roomCode"
                .DisplayMember = "roomDesc"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.close()
        End Try
    End Sub
End Module
