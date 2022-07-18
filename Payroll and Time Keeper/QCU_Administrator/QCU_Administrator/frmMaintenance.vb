Public Class frmMaintenance
    Private Sub btnCourseManage_Click(sender As Object, e As EventArgs)
        frmMaintenanceCourse.ShowDialog()
    End Sub

    Private Sub frmMaintenance_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmAdminDashboard.Show()
    End Sub

    Private Sub btnDepartmentManage_Click(sender As Object, e As EventArgs) Handles btnDepartmentManage.Click
        frmMaintenanceDepartment.ShowDialog()
    End Sub
    Private Sub btnYearManage_Click(sender As Object, e As EventArgs) Handles btnYearManage.Click
        frmMaintenanceYear.ShowDialog()
    End Sub

    Private Sub btnCourseManage_Click_1(sender As Object, e As EventArgs) Handles btnCourseManage.Click
        frmMaintenanceCourse.ShowDialog()
    End Sub

    Private Sub btnRoomManage_Click(sender As Object, e As EventArgs) Handles btnRoomManage.Click
        frmMaintenanceRoom.ShowDialog()
    End Sub

    Private Sub btnSectionManage_Click(sender As Object, e As EventArgs) Handles btnSectionManage.Click
        frmMaintenanceSection.ShowDialog()
    End Sub

    Private Sub btnSubjectManage_Click(sender As Object, e As EventArgs) Handles btnSubjectManage.Click
        frmMaintenanceSubject.ShowDialog()
    End Sub
End Class