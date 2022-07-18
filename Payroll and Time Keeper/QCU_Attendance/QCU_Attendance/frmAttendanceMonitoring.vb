Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.ComponentModel

Public Class frmAttendanceMonitoring
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub frmAttendanceMonitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblToday.Text = Format(Date.Today, "MM/dd/yyyy")
        timeTick.Enabled = True
        loadTimeIn()
    End Sub

    Private Sub timeTick_Tick(sender As Object, e As EventArgs) Handles timeTick.Tick
        lblTime.Text = Format(Date.Now, "h:mm:s tt")
    End Sub
    Private Sub btnTimeIn_Click(sender As Object, e As EventArgs) Handles btnTimeIn.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT profile,CONCAT(FirstName, '" & " " & "', LastName) AS EmployeeName,Employment,Department FROM tbl_employee WHERE EmployeeCode = '" & txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read Then
                Dim img() As Byte
                img = dr("profile")
                Dim ms As New MemoryStream(img)
                pcbProfile.Image = Image.FromStream(ms)
                pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                txtEmployeeName.Text = dr("EmployeeName")
                txtPosition.Text = dr("Employment")
                txtDepartment.Text = dr("Department")
                Try
                    conn.close()
                    cmd.Connection = conn.open
                    cmd.CommandText = "INSERT INTO tbl_timein(EmployeeCode,fullname,Department,Day,Month,year,Date,TimeIn)VALUES(@EmployeeCode,@fullname,@Department,@Day,@Month,@year,@Date,@TimeIn) LIMIT 1"
                    cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                    cmd.Parameters.AddWithValue("@fullname", txtEmployeeName.Text)
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
                    cmd.Parameters.AddWithValue("@Day", Date.Now.DayOfWeek.ToString)
                    cmd.Parameters.AddWithValue("@Month", Date.Today.Month)
                    cmd.Parameters.AddWithValue("@year", Date.Today.Year)
                    cmd.Parameters.AddWithValue("@Date", Date.Today)
                    cmd.Parameters.AddWithValue("@TimeIn", Format(Date.Now, "h:mm:s tt"))
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cmd.Dispose()
                    cmd.Parameters.Clear()
                    conn.close()
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            dr.Dispose()
            cmd.Dispose()
            conn.close()
            frmAttendanceMonitoring_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub loadTimeIn()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT employeeCode,fullname,Date,TimeIn,TimeOut FROM tbl_timein"
            dr = cmd.ExecuteReader
            lvTimeIne.Items.Clear()
            Dim show As ListViewItem
            While dr.Read
                show = New ListViewItem(dr("EmployeeCode").ToString)
                show.SubItems.Add(dr("fullname"))
                show.SubItems.Add(Format(dr("Date"), "MM/dd/yyyy"))
                show.SubItems.Add(dr("TimeIn").ToString)
                show.SubItems.Add(dr("TimeOut").ToString)
                lvTimeIne.Items.Add(show)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            dr.Dispose()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub btnTimeOut_Click(sender As Object, e As EventArgs) Handles btnTimeOut.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT CONCAT(FirstName, '" & " " & "', LastName) AS EmployeeName,Employment,Department FROM tbl_employee WHERE EmployeeCode = '" & txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read Then
                Dim img() As Byte
                img = dr("profile")
                Dim ms As New MemoryStream(img)
                pcbProfile.Image = Image.FromStream(ms)
                pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                txtEmployeeName.Text = dr("EmployeeName")
                txtPosition.Text = dr("Employment")
                txtDepartment.Text = dr("Department")
                Try
                    conn.close()
                    cmd.Connection = conn.open
                    cmd.CommandText = "UPDATE tbl_timein SET TimeOut = @timeOut WHERE employeeCode = @EmployeeCode AND Date = @Date"
                    cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                    cmd.Parameters.AddWithValue("@timeOut", Format(Date.Now, "h:mm:s tt"))
                    cmd.Parameters.AddWithValue("@Date", Date.Today)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    cmd.Dispose()
                    cmd.Parameters.Clear()
                    conn.close()
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            dr.Dispose()
            cmd.Dispose()
            conn.close()
            frmAttendanceMonitoring_Load(e, e)
            Refresh()

        End Try
    End Sub
    Private Sub clear()
        txtEmployeeCode.Clear()
        txtDepartment.Clear()
        txtEmployeeName.Clear()
        txtPosition.Clear()
    End Sub
    Private Sub reload_Tick(sender As Object, e As EventArgs)
        clear()
    End Sub
    Private Sub lvTimeIne_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles lvTimeIne.ColumnWidthChanging
        Dim DisableColumns As Integer() = {0, 1, 2, 3, 4, 5}
        For Each DCol As Integer In DisableColumns
            If e.ColumnIndex = DCol Then
                e.Cancel = True
                e.NewWidth = lvTimeIne.Columns(DCol).Width
            End If
        Next DCol
    End Sub
End Class
