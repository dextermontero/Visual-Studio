Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmMaintenanceEmployee
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close this form?", MsgBoxStyle.YesNo, "Maintenance Employee") = MsgBoxResult.Yes Then
            Me.Close()
            frmManageEmployee.Show()
        End If
    End Sub
    Private Sub frmMaintenanceEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmployee()
        clearload()
        loadInfoEmployee.loadMainDepartment()
        dtpHired.CustomFormat = " "
    End Sub
    Private Sub loadEmployee()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            lvEmployee.Items.Clear()
            Dim employee As ListViewItem
            While dr.Read
                Dim val As Integer = dr("monthlySalary")
                employee = New ListViewItem(dr("EmployeeCode").ToString)
                employee.SubItems.Add(dr("Firstname"))
                employee.SubItems.Add(dr("MiddleName"))
                employee.SubItems.Add(dr("Lastname"))
                employee.SubItems.Add(dr("Email"))
                employee.SubItems.Add(dr("Department"))
                employee.SubItems.Add(dr("position"))
                employee.SubItems.Add(Format(dr("hired"), "MM/dd/yyyy"))
                employee.SubItems.Add(dr("Employment"))
                employee.SubItems.Add(dr("leaveLeft"))
                employee.SubItems.Add(dr("rates"))
                employee.SubItems.Add(dr("hours"))
                employee.SubItems.Add(val.ToString("###,###,###"))
                lvEmployee.Items.Add(employee)
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
    Private Sub txtSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles txtSearchEmployee.TextChanged
        Try
            lvEmployee.Items.Clear()
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode LIKE '" & txtSearchEmployee.Text & "%' OR Firstname LIKE '" & txtSearchEmployee.Text & "%' OR Lastname LIKE '" & txtSearchEmployee.Text & "%'"
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim employee As ListViewItem
            While dr.Read
                employee = New ListViewItem(dr("EmployeeCode").ToString)
                employee.SubItems.Add(dr("Firstname"))
                employee.SubItems.Add(dr("MiddleName"))
                employee.SubItems.Add(dr("Lastname"))
                employee.SubItems.Add(dr("Email"))
                employee.SubItems.Add(dr("Department"))
                employee.SubItems.Add(dr("position"))
                employee.SubItems.Add(Format(dr("hired"), "MM/dd/yyyy"))
                employee.SubItems.Add(dr("Employment"))
                employee.SubItems.Add(dr("leaveLeft"))
                employee.SubItems.Add(dr("rates"))
                employee.SubItems.Add(dr("hours"))
                employee.SubItems.Add(dr("monthlySalary"))
                lvEmployee.Items.Add(employee)
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
    Private Sub lvEmployee_MouseClick(sender As Object, e As MouseEventArgs) Handles lvEmployee.MouseClick
        Dim id As String = lvEmployee.SelectedItems(0).SubItems(0).Text
        Dim firstname As String = lvEmployee.SelectedItems(0).SubItems(1).Text
        Dim middlename As String = lvEmployee.SelectedItems(0).SubItems(2).Text
        Dim lastname As String = lvEmployee.SelectedItems(0).SubItems(3).Text
        Dim email As String = lvEmployee.SelectedItems(0).SubItems(4).Text
        Dim department As String = lvEmployee.SelectedItems(0).SubItems(5).Text
        Dim position As String = lvEmployee.SelectedItems(0).SubItems(6).Text
        Dim hired As String = lvEmployee.SelectedItems(0).SubItems(7).Text
        Dim employment As String = lvEmployee.SelectedItems(0).SubItems(8).Text
        Dim leave As String = lvEmployee.SelectedItems(0).SubItems(9).Text
        Dim rates As String = lvEmployee.SelectedItems(0).SubItems(10).Text
        Dim hour As String = lvEmployee.SelectedItems(0).SubItems(11).Text
        Dim monthly As String = lvEmployee.SelectedItems(0).SubItems(12).Text
        txtSearchEmployee.Text = id
        txtEmployeeCode.Text = id
        txtFirstName.Text = firstname
        txtMiddleName.Text = middlename
        txtLastName.Text = lastname
        txtEmail.Text = email
        cbDepartment.Text = department
        cbPosition.Text = position
        dtpHired.Text = hired
        cbEmployment.Text = employment
        txtLeave.Text = leave
        txtRates.Text = rates
        txtHours.Text = hour
        txtMonthly.Text = monthly
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_employee WHERE EmployeeCode = '" & id & "'"
            dr = cmd.ExecuteReader
            While dr.Read
                lblID.Text = dr("employeeID")
                Dim img() As Byte
                img = dr("profile")
                Dim ms As New MemoryStream(img)
                pcbProfile.Image = Image.FromStream(ms)
                pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
    Private Sub clearload()
        txtEmployeeCode.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        cbDepartment.SelectedIndex = -1
        cbPosition.SelectedIndex = -1
        cbEmployment.SelectedIndex = -1
        txtLeave.Text = ""
        txtRates.Text = ""
        txtHours.Text = ""
        txtMonthly.Text = ""
        lblID.Text = ""
        lblValidate.Text = ""
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
    Private Sub txtLeave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeave.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRates_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRates.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtHours_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHours.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtMonthly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonthly.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Close()
        frmSubAddEmployee.Show()
    End Sub
    Private Sub dtpHired_ValueChanged(sender As Object, e As EventArgs) Handles dtpHired.ValueChanged
        dtpHired.CustomFormat = "MM/dd/yyyy"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim ms As New MemoryStream
            pcbProfile.Image.Save(ms, pcbProfile.Image.RawFormat)
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "UPDATE tbl_employee SET profile=@profile,EmployeeCode=@EmployeeCode,FirstName=@FirstName,MiddleName=@MiddleName,LastName=@LastName,Email=@Email,leaveLeft=@leaveLeft,rates=@rates,hours=@hours,monthlySalary=@monthly,Department=@Department,position=@position,hired=@hired,Employment=@Employment WHERE EmployeeCode=@EmployeeCode"
            cmd.Parameters.AddWithValue("@profile", ms.ToArray)
            cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmd.Parameters.AddWithValue("@MiddleName", txtMiddleName.Text)
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            cmd.Parameters.AddWithValue("@leaveLeft", txtLeave.Text)
            cmd.Parameters.AddWithValue("@rates", txtRates.Text)
            cmd.Parameters.AddWithValue("@hours", txtHours.Text)
            cmd.Parameters.AddWithValue("@monthly", txtMonthly.Text)
            cmd.Parameters.AddWithValue("@Department", cbDepartment.Text)
            cmd.Parameters.AddWithValue("@position", cbPosition.Text)
            cmd.Parameters.AddWithValue("@hired", dtpHired.Value.Date)
            cmd.Parameters.AddWithValue("@Employment", cbEmployment.Text)
            conn.close()
            cmd1.Connection = conn.open
            cmd1.CommandText = "UPDATE tbl_personalinfo SET FirstName= '" & txtFirstName.Text & "', MiddleName = '" & txtMiddleName.Text & "', LastName = '" & txtLastName.Text & "', Email = '" & txtEmail.Text & "' WHERE employeeCode = '" & txtEmployeeCode.Text & "'"
            cmd.ExecuteNonQuery()
            cmd1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd1.Parameters.Clear()
            cmd.Dispose()
            cmd1.Dispose()
            frmMaintenanceEmployee_Load(e, e)
            Refresh()
            conn.close()
            pcbProfile.Image = My.Resources.unknown
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        validateEmployeeDelete.ShowDialog()
        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE adminID = @id AND Password = @Password"
            cmd.Parameters.AddWithValue("@id", adminID.Text)
            cmd.Parameters.AddWithValue("@Password", lblValidate.Text)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                conn.close()
                cmd.Connection = conn.open()
                cmd.CommandText = "DELETE FROM tbl_employee WHERE EmployeeCode = '" & txtEmployeeCode.Text & "' AND employeeID = '" & lblID.Text & "'"
                If txtEmployeeCode.Text = Nothing Then
                    MsgBox("Select the Employee Code to delete!", MsgBoxStyle.Information, "Maintenance Employee")
                Else
                    If MsgBox("Are you sure you want to delete this information?", MsgBoxStyle.YesNo, "Maintenance Employee") = MsgBoxResult.Yes Then
                        cmd.ExecuteNonQuery()
                        MsgBox("Employee information has been deleted!", MsgBoxStyle.Information, "Maintenance Employee")
                    Else
                        MsgBox("Employee information did not delete!", MsgBoxStyle.Information, "Maintenance Employee")
                    End If
                End If
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            frmMaintenanceEmployee_Load(e, e)
            Refresh()
            conn.close()
            clearload()
        End Try
    End Sub
End Class