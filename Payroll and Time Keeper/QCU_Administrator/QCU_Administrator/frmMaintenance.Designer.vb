<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYearManage = New System.Windows.Forms.Button()
        Me.btnSubjectManage = New System.Windows.Forms.Button()
        Me.btnSectionManage = New System.Windows.Forms.Button()
        Me.btnRoomManage = New System.Windows.Forms.Button()
        Me.btnDepartmentManage = New System.Windows.Forms.Button()
        Me.btnCourseManage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(235, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Maintenance"
        '
        'btnYearManage
        '
        Me.btnYearManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnYearManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnYearManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYearManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYearManage.ForeColor = System.Drawing.Color.White
        Me.btnYearManage.Location = New System.Drawing.Point(452, 213)
        Me.btnYearManage.Name = "btnYearManage"
        Me.btnYearManage.Size = New System.Drawing.Size(181, 99)
        Me.btnYearManage.TabIndex = 13
        Me.btnYearManage.Text = "Year Manage"
        Me.btnYearManage.UseVisualStyleBackColor = False
        '
        'btnSubjectManage
        '
        Me.btnSubjectManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnSubjectManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnSubjectManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubjectManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectManage.ForeColor = System.Drawing.Color.White
        Me.btnSubjectManage.Location = New System.Drawing.Point(241, 213)
        Me.btnSubjectManage.Name = "btnSubjectManage"
        Me.btnSubjectManage.Size = New System.Drawing.Size(181, 99)
        Me.btnSubjectManage.TabIndex = 12
        Me.btnSubjectManage.Text = "Subject Manage"
        Me.btnSubjectManage.UseVisualStyleBackColor = False
        '
        'btnSectionManage
        '
        Me.btnSectionManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnSectionManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnSectionManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSectionManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSectionManage.ForeColor = System.Drawing.Color.White
        Me.btnSectionManage.Location = New System.Drawing.Point(29, 213)
        Me.btnSectionManage.Name = "btnSectionManage"
        Me.btnSectionManage.Size = New System.Drawing.Size(181, 99)
        Me.btnSectionManage.TabIndex = 11
        Me.btnSectionManage.Text = "Section Manage"
        Me.btnSectionManage.UseVisualStyleBackColor = False
        '
        'btnRoomManage
        '
        Me.btnRoomManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnRoomManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnRoomManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomManage.ForeColor = System.Drawing.Color.White
        Me.btnRoomManage.Location = New System.Drawing.Point(452, 88)
        Me.btnRoomManage.Name = "btnRoomManage"
        Me.btnRoomManage.Size = New System.Drawing.Size(181, 99)
        Me.btnRoomManage.TabIndex = 10
        Me.btnRoomManage.Text = "Room Manage"
        Me.btnRoomManage.UseVisualStyleBackColor = False
        '
        'btnDepartmentManage
        '
        Me.btnDepartmentManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnDepartmentManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnDepartmentManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepartmentManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartmentManage.ForeColor = System.Drawing.Color.White
        Me.btnDepartmentManage.Location = New System.Drawing.Point(241, 88)
        Me.btnDepartmentManage.Name = "btnDepartmentManage"
        Me.btnDepartmentManage.Size = New System.Drawing.Size(181, 99)
        Me.btnDepartmentManage.TabIndex = 9
        Me.btnDepartmentManage.Text = "Department Manage"
        Me.btnDepartmentManage.UseVisualStyleBackColor = False
        '
        'btnCourseManage
        '
        Me.btnCourseManage.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnCourseManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnCourseManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseManage.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseManage.ForeColor = System.Drawing.Color.White
        Me.btnCourseManage.Location = New System.Drawing.Point(29, 88)
        Me.btnCourseManage.Name = "btnCourseManage"
        Me.btnCourseManage.Size = New System.Drawing.Size(181, 99)
        Me.btnCourseManage.TabIndex = 8
        Me.btnCourseManage.Text = "Course Manage"
        Me.btnCourseManage.UseVisualStyleBackColor = False
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 327)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnYearManage)
        Me.Controls.Add(Me.btnSubjectManage)
        Me.Controls.Add(Me.btnSectionManage)
        Me.Controls.Add(Me.btnRoomManage)
        Me.Controls.Add(Me.btnDepartmentManage)
        Me.Controls.Add(Me.btnCourseManage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Maintenance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnYearManage As Button
    Friend WithEvents btnSubjectManage As Button
    Friend WithEvents btnSectionManage As Button
    Friend WithEvents btnRoomManage As Button
    Friend WithEvents btnDepartmentManage As Button
    Friend WithEvents btnCourseManage As Button
End Class
