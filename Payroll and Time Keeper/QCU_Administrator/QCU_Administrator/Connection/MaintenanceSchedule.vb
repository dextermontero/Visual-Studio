Imports MySql.Data.MySqlClient
Module MaintenanceSchedule
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Public Sub loadSched()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_schedule"
            dr = cmd.ExecuteReader
            frmMaintenanceSchedule.lvSchedule.Items.Clear()
            Dim sched As ListViewItem
            While dr.Read
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
                frmMaintenanceSchedule.lvSchedule.Items.Add(sched)
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
            With (frmMaintenanceSchedule.cbCourse)
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
            With (frmMaintenanceSchedule.cbSection)
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
            With (frmMaintenanceSchedule.cbYear)
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
            With (frmMaintenanceSchedule.cbSubject)
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
            With (frmMaintenanceSchedule.cbRoom)
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
