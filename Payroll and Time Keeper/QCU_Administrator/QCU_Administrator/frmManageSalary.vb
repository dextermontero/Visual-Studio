Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmManageSalary
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub loadSalaray()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_salary"
            dr = cmd.ExecuteReader
            lvSalary.Items.Clear()
            Dim salary As New ListViewItem
            While dr.Read
                salary = New ListViewItem(dr("EmployeeCode").ToString)
                salary.SubItems.Add(dr("FirstName"))
                salary.SubItems.Add(dr("LastName"))
                salary.SubItems.Add(dr("Department"))
                salary.SubItems.Add(dr("Position"))
                salary.SubItems.Add(dr("gross"))
                salary.SubItems.Add(dr("deduction"))
                salary.SubItems.Add(dr("net"))
                lvSalary.Items.Add(salary)
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
    Private Sub frmManageSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployeeSalary.loadSalaryEmp()
        loadSalaray()
    End Sub
    Private Sub cbEmployee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmployee.SelectedIndexChanged
        txtEmployeeCode.Text = cbEmployee.SelectedValue.ToString
        loadinfo()
        loadTime()
    End Sub
    Private Sub loadinfo()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode = '" & txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                Dim img() As Byte
                img = dr("profile")
                Dim ms As New MemoryStream(img)
                pcbProfile.Image = Image.FromStream(ms)
                pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                txtFirstName.Text = dr("FirstName")
                txtMiddleName.Text = dr("MiddleName")
                txtLastName.Text = dr("LastName")
                txtDepartment.Text = dr("Department")
                txtPosition.Text = dr("position")
                'txtMonthly.Text = dr("monthlySalary")
                txtRate.Text = dr("rates")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub loadTime()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT SUM(totalHours) as total FROM tbl_timein WHERE EmployeeCode = @EmployeeCode AND Month = @Month AND Year = @Year GROUP BY EmployeeCode"
            cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
            cmd.Parameters.AddWithValue("@Month", Date.Today.Month)
            cmd.Parameters.AddWithValue("@Year", Date.Today.Year)
            dr = cmd.ExecuteReader
            While dr.Read
                txtHour.Text = dr("total")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            cmd.Parameters.Clear()
            conn.close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim gross As Integer
            Dim hph As Integer
            Dim hsss As Integer
            Dim hpag As Integer
            Dim htin As Integer
            Dim hdec As Integer
            Dim hnet As Integer
            gross = Val(txtRate.Text) * Val(txtHour.Text) * Val(txtWork.Text)
            hph = gross * 0.0275
            hsss = gross * 0.3
            hpag = gross * 0.0275
            htin = gross * 0.11
            hdec = Val(hph) + Val(hsss) + Val(hpag) + Val(htin)
            hnet = Val(gross) - Val(hdec)

            txtPhil.Text = hph
            txtsss.Text = hsss
            txtPagIbig.Text = hpag
            txtTIN.Text = htin
            txtTotalGross.Text = gross

            txtDeduction.Text = hdec
            txtNet.Text = hnet
            txtGross.Text = gross
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "INSERT INTO tbl_salary(EmployeeCode,FirstName,MiddleName,LastName,Department,Position,rates,hours,work,sss,tin,pagibig,philhealth,gross,deduction,net)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Department,@Position,@rates,@hours,@work,@sss,@tin,@pag,@phil,@gross,@deduction,@net)"
            cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Department", txtDepartment.Text)
            cmd.Parameters.AddWithValue("@Position", txtPosition.Text)
            cmd.Parameters.AddWithValue("@rates", txtRate.Text)
            cmd.Parameters.AddWithValue("@hours", txtHour.Text)
            cmd.Parameters.AddWithValue("@work", txtWork.Text)
            cmd.Parameters.AddWithValue("@sss", txtsss.Text)
            cmd.Parameters.AddWithValue("@tin", txtTIN.Text)
            cmd.Parameters.AddWithValue("@pag", txtPagIbig.Text)
            cmd.Parameters.AddWithValue("@phil", txtPhil.Text)
            cmd.Parameters.AddWithValue("@gross", txtGross.Text)
            cmd.Parameters.AddWithValue("@deduction", txtDeduction.Text)
            cmd.Parameters.AddWithValue("@net", txtNet.Text)
            If cmd.ExecuteNonQuery Then
                MsgBox("Generating Salary Complete", MsgBoxStyle.Information, "Salary Management")
            Else
                MsgBox("Generating Salary not Complete", MsgBoxStyle.Information, "Salary")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
            frmManageSalary_Load(e, e)
            Refresh()
        End Try
    End Sub
    Private Sub txtHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHour.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtWork_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWork.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class