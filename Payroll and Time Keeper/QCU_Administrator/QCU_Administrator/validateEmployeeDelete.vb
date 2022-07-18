Imports MySql.Data.MySqlClient
Public Class validateEmployeeDelete
    Dim conn As New Database
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.close()
            cmd.Connection = conn.open()
            cmd.CommandText = "SELECT * FROM tbl_admin WHERE Password = '" & txtPassword.Text & "'"
            dr = cmd.ExecuteReader
            If txtPassword.Text = Nothing Then
                MsgBox("The Field is empty. Please Try again!!!", MsgBoxStyle.Information, "Verify Password")
            Else
                If dr.Read Then
                    frmMaintenanceEmployee.lblValidate.Text = dr("Password")
                    frmMaintenanceEmployee.adminID.Text = dr("adminID")
                    Me.Hide()
                Else
                    MsgBox("Password did not match!. Please Try again!!!", MsgBoxStyle.Information, "Verify Password")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Dispose()
            dr.Close()
            cmd.Dispose()
            conn.close()
        End Try
    End Sub
    Private Sub validateEmployeeDelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Text = ""
    End Sub
End Class