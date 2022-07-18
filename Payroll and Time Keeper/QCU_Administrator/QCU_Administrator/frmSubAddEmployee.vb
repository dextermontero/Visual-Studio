Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmSubAddEmployee
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim cmd2 As New MySqlCommand
    Dim dr As MySqlDataReader
    Private ran As New Random
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif|All files(*.*)|*.*"
            If opf.ShowDialog = DialogResult.OK Then
                Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                pcbProfile.Image = Image.FromFile(opf.FileName)
            End If
        Catch ex As Exception
            MsgBox("Invalid Image Format", MsgBoxStyle.Information, "Choose Image")
        End Try
    End Sub
    Private Function empCode()
        Dim shuff As String = ""
        Dim code As String = "0123456789"
        Dim i As Integer
        While code.Length > 5
            i = ran.Next(0, code.Length)
            shuff &= code.Substring(i, 1)
            code = code.Remove(i, 1)
        End While
        Return shuff
    End Function
    Private Sub frmSubAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmployeeCode.Text = "QCU-" & empCode()
        loadInfoEmployee.loadDepartment()
        txtAge.Text = ""
        dtpHired.Text = Format(Date.Today, "MM/dd/yyyy")
        dtpBirthday.CustomFormat = " "
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Manage Employee Information") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageEmployee.Show()
        End If
    End Sub
    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiddleName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCity.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTotalLeave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalLeave.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtHourRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourRate.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtWorkHour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWorkHour.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMonthly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonthly.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtSSS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSSS.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtTIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTIN.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPagIbig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagIbig.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPhilHealth_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhilHealth.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT employeeCode FROM tbl_personalinfo WHERE employeeCode = '" & txtEmployeeCode.Text & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                frmSubAddEmployee_Load(e, e)
                Refresh()
            Else
                If txtFirstName.Text Is Nothing Or txtLastName.Text Is Nothing Or cbMartialStatus.SelectedItem Is Nothing Or txtAge.Text = Nothing Or txtEmail.Text = Nothing Or txtContact.Text = Nothing Or cbEmployment.SelectedItem Is Nothing Or cbDepartment.SelectedItem Is Nothing Or cbPosition.SelectedItem Is Nothing Or txtPassword.Text = Nothing Or txtTotalLeave.Text = Nothing Or txtHourRate.Text = Nothing Or txtWorkHour.Text = Nothing Or txtMonthly.Text = Nothing Or txtAddress.Text = Nothing Or txtCity.Text = Nothing Or txtZipCode.Text = Nothing Or txtSSS.Text = Nothing Or txtTIN.Text = Nothing Or txtPagIbig.Text = Nothing Or txtPhilHealth.Text = Nothing Then
                    MsgBox("Please fill up all required fields", MsgBoxStyle.Information, "Add Employee")
                Else
                    If emailChecker(txtEmail.Text) = False Then
                        MsgBox("Invalid Emaill Address", MsgBoxStyle.Information, "Add Employee")
                    Else
                        If rbMale.Checked = True Then
                            If rbBachelor.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbBachelor.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    cleartxt()
                                    frmManageEmployee.reload.Enabled = True
                                    frmSubAddEmployee_Load(e, e)
                                    Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            ElseIf rbMasteral.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbMasteral.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    cleartxt()
                                    frmManageEmployee.reload.Enabled = True
                                    frmSubAddEmployee_Load(e, e)
                                    Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            ElseIf rbDoctorate.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbMale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbDoctorate.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    cleartxt()
                                    frmManageEmployee.reload.Enabled = True
                                    frmSubAddEmployee_Load(e, e)
                                    Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            Else
                                MsgBox("Please select your degree", MsgBoxStyle.Information, "Add Employee")
                            End If
                        ElseIf rbFemale.Checked = True Then
                            If rbBachelor.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbBachelor.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    'cleartxt()
                                    'frmManageEmployee.reload.Enabled = True
                                    'frmSubAddEmployee_Load(e, e)
                                    'Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            ElseIf rbMasteral.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbMasteral.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    'cleartxt()
                                    'frmManageEmployee.reload.Enabled = True
                                    'frmSubAddEmployee_Load(e, e)
                                    ' Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            ElseIf rbDoctorate.Checked = True Then
                                conn.close()
                                cmd.Connection = conn.open
                                cmd.CommandText = "INSERT INTO tbl_personalinfo(employeeCode,FirstName,MiddleName,LastName,Gender,Email,Birthday,MartialStatus,Contact,Address,City,zipCode)VALUES(@EmployeeCode,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Birthday,@MartialStatus,@Contact,@Address,@City,@zipCode)"
                                cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd.Parameters.AddWithValue("@Birthday", dtpBirthday.Value.Date)
                                cmd.Parameters.AddWithValue("@MartialStatus", cbMartialStatus.SelectedItem)
                                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                                cmd.Parameters.AddWithValue("@City", txtCity.Text)
                                cmd.Parameters.AddWithValue("@zipCode", txtZipCode.Text)
                                conn.close()
                                Dim ms As New MemoryStream
                                pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
                                cmd1.Connection = conn.open
                                cmd1.CommandText = "INSERT INTO tbl_employee(profile,EmployeeCode,Password,Firstname,MiddleName,LastName,Gender,Email,Degree,leaveLeft,rates,hours,monthlySalary,Department,position,hired,Employment)VALUES(@profile,@EmployeeCode,@Password,@FirstName,@MiddleName,@LastName,@Gender,@Email,@Degree,@leaveLeft,@rates,@hours,@monthlySalary,@Department,@position,@hired,@Employment)"
                                cmd1.Parameters.AddWithValue("@profile", ms.ToArray)
                                cmd1.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd1.Parameters.AddWithValue("@Password", txtPassword.Text)
                                cmd1.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                                cmd1.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
                                cmd1.Parameters.AddWithValue("@LastName", txtLastName.Text)
                                cmd1.Parameters.AddWithValue("@Gender", rbFemale.Text)
                                cmd1.Parameters.AddWithValue("@Email", txtEmail.Text)
                                cmd1.Parameters.AddWithValue("@Degree", rbDoctorate.Text)
                                cmd1.Parameters.AddWithValue("@leaveLeft", txtTotalLeave.Text)
                                cmd1.Parameters.AddWithValue("@rates", txtHourRate.Text)
                                cmd1.Parameters.AddWithValue("@hours", txtWorkHour.Text)
                                cmd1.Parameters.AddWithValue("@monthlySalary", txtMonthly.Text)
                                cmd1.Parameters.AddWithValue("@Department", cbDepartment.Text)
                                cmd1.Parameters.AddWithValue("@position", cbPosition.SelectedItem)
                                cmd1.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
                                cmd1.Parameters.AddWithValue("@Employment", cbEmployment.SelectedItem)
                                conn.close()
                                cmd2.Connection = conn.open
                                cmd2.CommandText = "INSERT INTO tbl_benefits(EmployeeCode,SSS,TIN,pagIbig,philHealth)VALUES(@EmployeeCode,@SSS,@TIN,@pagIbig,@philHealth)"
                                cmd2.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
                                cmd2.Parameters.AddWithValue("@SSS", txtSSS.Text)
                                cmd2.Parameters.AddWithValue("@TIN", txtTIN.Text)
                                cmd2.Parameters.AddWithValue("@pagIbig", txtPagIbig.Text)
                                cmd2.Parameters.AddWithValue("@philHealth", txtPhilHealth.Text)
                                If cmd.ExecuteNonQuery() AndAlso cmd1.ExecuteNonQuery() AndAlso cmd2.ExecuteNonQuery() Then
                                    MsgBox("Added Employee Successfully!", MsgBoxStyle.Information, "Add Employee")
                                    'cleartxt()
                                    'frmManageEmployee.reload.Enabled = True
                                    'frmSubAddEmployee_Load(e, e)
                                    'Refresh()
                                Else
                                    MsgBox("Added Employee not Successfully!", MsgBoxStyle.Information, "Add Employee")
                                End If
                            Else
                                MsgBox("Please select your degree", MsgBoxStyle.Information, "Add Employee")
                            End If
                        Else
                            MsgBox("Please select your gender", MsgBoxStyle.Information, "Add Employee")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd1.Parameters.Clear()
            cmd2.Parameters.Clear()
            cmd1.Dispose()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub dtpBirthday_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthday.ValueChanged
        dtpBirthday.CustomFormat = "MM/dd/yyyy"
        txtAge.Text = Date.Today.Year - dtpBirthday.Value.Year
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        cbMartialStatus.SelectedIndex = -1
        txtEmail.Text = ""
        txtContact.Text = ""
        cbEmployment.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        rbBachelor.Checked = False
        rbMasteral.Checked = False
        rbDoctorate.Checked = False
        txtTotalLeave.Text = ""
        txtHourRate.Text = ""
        txtWorkHour.Text = ""
        txtMonthly.Text = ""
        txtPassword.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtZipCode.Text = ""
        txtSSS.Text = ""
        txtTIN.Text = ""
        txtPhilHealth.Text = ""
        txtPagIbig.Text = ""
        txtAge.Text = ""
        pcbProfile.Image = My.Resources.unknown
        frmSubAddEmployee_Load(e, e)
        Refresh()
    End Sub

    Private Sub cleartxt()
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        rbMale.Checked = False
        rbFemale.Checked = False
        cbMartialStatus.SelectedIndex = -1
        txtEmail.Text = ""
        txtContact.Text = ""
        cbEmployment.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        rbBachelor.Checked = False
        rbMasteral.Checked = False
        rbDoctorate.Checked = False
        txtTotalLeave.Text = ""
        txtHourRate.Text = ""
        txtWorkHour.Text = ""
        txtMonthly.Text = ""
        txtPassword.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtZipCode.Text = ""
        txtSSS.Text = ""
        txtTIN.Text = ""
        txtPhilHealth.Text = ""
        txtPagIbig.Text = ""
        txtAge.Text = ""
        pcbProfile.Image = My.Resources.unknown
    End Sub
    Function emailChecker(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailcheck As Match = Regex.Match(emailaddress, pattern)
        If emailcheck.Success Then
            emailChecker = True
        Else
            emailChecker = False
        End If
    End Function
End Class