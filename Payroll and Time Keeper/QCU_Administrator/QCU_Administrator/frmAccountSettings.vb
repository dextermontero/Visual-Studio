Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmAccountSettings
    Dim conn As New Database
    Dim dr As MySqlDataReader
    Dim cmd As New MySqlCommand
    Private Sub btnChangePassword_MouseHover(sender As Object, e As EventArgs) Handles btnChangePassword.MouseHover
        btnChangePassword.BackColor = Color.FromArgb(255, 193, 7)
        btnChangePassword.ForeColor = Color.Black
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7)
    End Sub
    Private Sub btnChangePassword_MouseLeave(sender As Object, e As EventArgs) Handles btnChangePassword.MouseLeave
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7)
        btnChangePassword.BackColor = Color.Transparent
        btnChangePassword.ForeColor = Color.FromArgb(255, 193, 7)
    End Sub
    Private Sub btnChangePassword_GotFocus(sender As Object, e As EventArgs) Handles btnChangePassword.GotFocus
        btnChangePassword.BackColor = Color.FromArgb(255, 193, 7)
        btnChangePassword.ForeColor = Color.Black
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7)
    End Sub
    Private Sub btnChangePassword_LostFocus(sender As Object, e As EventArgs) Handles btnChangePassword.LostFocus
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.FlatAppearance.BorderColor = Color.FromArgb(255, 193, 7)
        btnChangePassword.BackColor = Color.Transparent
        btnChangePassword.ForeColor = Color.FromArgb(255, 193, 7)
    End Sub
    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Try
            Dim ms As New MemoryStream
            pcbAdminPic.Image.Save(ms, pcbAdminPic.Image.RawFormat)
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "Update tbl_admin Set adminProfile=@img,adminName='" & txtFullName.Text & "',adminNickname='" & txtNickname.Text & "',Email='" & txtEmail.Text & "',Password='" & txtPassword.Text & "' WHERE adminID='" & id.Text & "'"
            cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray()
            If MsgBox("Do you want to update your profile information?", MsgBoxStyle.YesNo, "Account Settings") = MsgBoxResult.Yes Then
                cmd.ExecuteNonQuery()
                If MsgBox("Profile Updated, Do you want to go to Dashboard?", MsgBoxStyle.YesNo, "Account Settings") = MsgBoxResult.Yes Then
                    frmAdminDashboard.timeData.Enabled = True
                    Me.Close()
                Else
                    frmAccountSettings_Load(e, e)
                    Refresh()
                    MsgBox("Successfully Changed!", MsgBoxStyle.Information, "Account Settings")
                End If
            Else
                MsgBox("Your Information did not change!", MsgBoxStyle.Information, "Account Settings")
                frmAccountSettings_Load(e, e)
                Refresh()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Parameters.Clear()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub btnSelectProfile_Click(sender As Object, e As EventArgs) Handles btnSelectProfile.Click
        Try
            Dim opf As New OpenFileDialog
            opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif|All files(*.*)|*.*"
            If opf.ShowDialog = DialogResult.OK Then
                Me.pcbAdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                pcbAdminPic.Image = Image.FromFile(opf.FileName)
            End If
        Catch ex As Exception
            MsgBox("Invalid Image Format", MsgBoxStyle.Information, "Choose Image")
        End Try
    End Sub
    Private Sub loadInfo()
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE adminID='" & frmAdminDashboard.lblAdminID.Text & "'"
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                id.Text = dr("adminID")
                Dim img() As Byte
                img = dr("adminProfile")
                Dim ms As New MemoryStream(img)
                pcbAdminPic.Image = Image.FromStream(ms)
                pcbAdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                lblDrUsername.Text = dr("Username")
                txtFullName.Text = dr("adminName")
                txtNickname.Text = dr("adminNickname")
                txtEmail.Text = dr("Email")
                txtPassword.Text = dr("Password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub

    Private Sub frmAccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadInfo() ' load data from database
        disableLoad(True) ' set the tools disabled
    End Sub
    Sub disableLoad(bool As Boolean)
        txtFullName.Enabled = False
        txtNickname.Enabled = False
        txtEmail.Enabled = False
        txtPassword.Enabled = False
    End Sub

    Private Sub lnkFullname_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkFullname.LinkClicked
        txtFullName.Enabled = True
    End Sub

    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEmail.LinkClicked
        txtEmail.Enabled = True
    End Sub

    Private Sub lnkPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkPassword.LinkClicked
        txtPassword.Enabled = True
    End Sub

    Private Sub lnkNickname_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNickname.LinkClicked
        txtNickname.Enabled = True
    End Sub
End Class