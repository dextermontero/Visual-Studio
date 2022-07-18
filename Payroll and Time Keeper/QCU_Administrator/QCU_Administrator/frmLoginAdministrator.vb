Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmLoginAdministrator
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Dim conn As New Database
    Dim dr As MySqlDataReader
    Dim strID As New frmAdminDashboard
    Private Sub btnLogin_GotFocus(sender As Object, e As EventArgs) Handles btnLogin.GotFocus
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        btnLogin.ForeColor = Color.White
        btnLogin.BackColor = Color.FromArgb(23, 162, 184)
    End Sub
    Private Sub btnLogin_LostFocus(sender As Object, e As EventArgs) Handles btnLogin.LostFocus
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        btnLogin.ForeColor = Color.FromArgb(23, 162, 184)
        btnLogin.BackColor = Color.Transparent
        btnLogin.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogin_MouseHover(sender As Object, e As EventArgs) Handles btnLogin.MouseHover
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        btnLogin.ForeColor = Color.White
        btnLogin.BackColor = Color.FromArgb(23, 162, 184)
    End Sub
    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(23, 162, 184)
        btnLogin.ForeColor = Color.FromArgb(23, 162, 184)
        btnLogin.BackColor = Color.Transparent
        btnLogin.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE Username='" & txtUsername.Text & "' AND Password= '" & txtPassword.Text & "' LIMIT 1"
            dr = cmd.ExecuteReader()
            If dr.Read = True Then
                frmAdminDashboard.lblAdminID.Text = dr("adminID")
                frmMaintenanceLeave.adminID.Text = dr("adminID")
                validateMaintenanceDelete.lblID.Text = dr("adminID")
                validateEmployeeDelete.lblID.Text = dr("adminID")
                frmMaintenanceSchedule.adminID.Text = dr("adminID")
                frmAdminDashboard.Show()
                Me.Hide()
                conn.close()
                cmd.Parameters.Clear()
            ElseIf dr.HasRows = False Then
                Try
                    dr.Close()
                    cmd.Dispose()
                    conn.close()
                    cmd.Connection = conn.open()
                    cmd.CommandText = "SELECT Username FROM tbl_admin WHERE Username='" & txtUsername.Text & "'"
                    dr = cmd.ExecuteReader
                    If dr.HasRows = True Then
                        MsgBox("Username is already exist!", MsgBoxStyle.Information, "Login Administrator")
                    Else
                        MsgBox("Username does not exist!", MsgBoxStyle.Information, "Login Administrator")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    dr.Close()
                    cmd.Dispose()
                    conn.close()
                End Try
            Else
                MsgBox("Incorrect Username and Password, Try again!", MsgBoxStyle.Information, "Login Administrator")
                conn.close()
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.close()
            cmd.Parameters.Clear()
            txtUsername.Clear()
            txtPassword.Clear()
        End Try
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Me.Hide()
        frmRegisterAdministrator.Show()
    End Sub

    Private Sub frmLoginAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            conn.close()
            cmd.Connection = conn.open
            cmd.CommandText = "SELECT * FROM tbl_admin"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                lnkRegister.Visible = False
            Else
                lnkRegister.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
        reload.Enabled = False
    End Sub
End Class
