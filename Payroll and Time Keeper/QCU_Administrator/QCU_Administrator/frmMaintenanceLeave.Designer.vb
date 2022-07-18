<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaintenanceLeave
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenanceLeave))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearchEmployee = New System.Windows.Forms.TextBox()
        Me.lvLeave = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.adminID = New System.Windows.Forms.Label()
        Me.lblValidate = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.txtEndDay = New System.Windows.Forms.TextBox()
        Me.lblEndDay = New System.Windows.Forms.Label()
        Me.txtStartDay = New System.Windows.Forms.TextBox()
        Me.lblStartDay = New System.Windows.Forms.Label()
        Me.txtLeaveLeft = New System.Windows.Forms.TextBox()
        Me.lblLeaveLeft = New System.Windows.Forms.Label()
        Me.cbLeave = New System.Windows.Forms.ComboBox()
        Me.lblLeave = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmployeeCode = New System.Windows.Forms.TextBox()
        Me.lblEmployeeCode = New System.Windows.Forms.Label()
        Me.lblSearchEmployee = New System.Windows.Forms.Label()
        Me.tmrReload = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(900, 655)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(118, 33)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(14, 653)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 33)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add Leave"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSearchEmployee
        '
        Me.txtSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEmployee.Location = New System.Drawing.Point(14, 317)
        Me.txtSearchEmployee.Name = "txtSearchEmployee"
        Me.txtSearchEmployee.Size = New System.Drawing.Size(244, 27)
        Me.txtSearchEmployee.TabIndex = 9
        '
        'lvLeave
        '
        Me.lvLeave.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader9, Me.ColumnHeader5, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvLeave.GridLines = True
        Me.lvLeave.Location = New System.Drawing.Point(14, 360)
        Me.lvLeave.Name = "lvLeave"
        Me.lvLeave.Size = New System.Drawing.Size(1004, 283)
        Me.lvLeave.TabIndex = 8
        Me.lvLeave.UseCompatibleStateImageBehavior = False
        Me.lvLeave.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Employee Code"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "First Name"
        Me.ColumnHeader2.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Last Name"
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Department"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Leave"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Leave Left"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 73
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Starting Day"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Last Day"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 93
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Reason"
        Me.ColumnHeader8.Width = 170
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(853, 213)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 33)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete Leave"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.adminID)
        Me.GroupBox1.Controls.Add(Me.lblValidate)
        Me.GroupBox1.Controls.Add(Me.txtReason)
        Me.GroupBox1.Controls.Add(Me.lblReason)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.txtEndDay)
        Me.GroupBox1.Controls.Add(Me.lblEndDay)
        Me.GroupBox1.Controls.Add(Me.txtStartDay)
        Me.GroupBox1.Controls.Add(Me.lblStartDay)
        Me.GroupBox1.Controls.Add(Me.txtLeaveLeft)
        Me.GroupBox1.Controls.Add(Me.lblLeaveLeft)
        Me.GroupBox1.Controls.Add(Me.cbLeave)
        Me.GroupBox1.Controls.Add(Me.lblLeave)
        Me.GroupBox1.Controls.Add(Me.txtDepartment)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeCode)
        Me.GroupBox1.Controls.Add(Me.lblEmployeeCode)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1003, 267)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.White
        Me.lblID.Location = New System.Drawing.Point(971, 176)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 38
        Me.lblID.Visible = False
        '
        'adminID
        '
        Me.adminID.AutoSize = True
        Me.adminID.ForeColor = System.Drawing.Color.White
        Me.adminID.Location = New System.Drawing.Point(908, 162)
        Me.adminID.Name = "adminID"
        Me.adminID.Size = New System.Drawing.Size(0, 13)
        Me.adminID.TabIndex = 37
        Me.adminID.Visible = False
        '
        'lblValidate
        '
        Me.lblValidate.AutoSize = True
        Me.lblValidate.ForeColor = System.Drawing.Color.White
        Me.lblValidate.Location = New System.Drawing.Point(917, 28)
        Me.lblValidate.Name = "lblValidate"
        Me.lblValidate.Size = New System.Drawing.Size(0, 13)
        Me.lblValidate.TabIndex = 36
        Me.lblValidate.Visible = False
        '
        'txtReason
        '
        Me.txtReason.Enabled = False
        Me.txtReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.Location = New System.Drawing.Point(581, 54)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(390, 82)
        Me.txtReason.TabIndex = 35
        '
        'lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReason.ForeColor = System.Drawing.Color.White
        Me.lblReason.Location = New System.Drawing.Point(577, 33)
        Me.lblReason.Name = "lblReason"
        Me.lblReason.Size = New System.Drawing.Size(65, 20)
        Me.lblReason.TabIndex = 34
        Me.lblReason.Text = "Reason"
        '
        'txtEndDay
        '
        Me.txtEndDay.Enabled = False
        Me.txtEndDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndDay.Location = New System.Drawing.Point(303, 215)
        Me.txtEndDay.Name = "txtEndDay"
        Me.txtEndDay.Size = New System.Drawing.Size(244, 27)
        Me.txtEndDay.TabIndex = 33
        '
        'lblEndDay
        '
        Me.lblEndDay.AutoSize = True
        Me.lblEndDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDay.ForeColor = System.Drawing.Color.White
        Me.lblEndDay.Location = New System.Drawing.Point(299, 192)
        Me.lblEndDay.Name = "lblEndDay"
        Me.lblEndDay.Size = New System.Drawing.Size(70, 20)
        Me.lblEndDay.TabIndex = 32
        Me.lblEndDay.Text = "End Day"
        '
        'txtStartDay
        '
        Me.txtStartDay.Enabled = False
        Me.txtStartDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartDay.Location = New System.Drawing.Point(303, 162)
        Me.txtStartDay.Name = "txtStartDay"
        Me.txtStartDay.Size = New System.Drawing.Size(244, 27)
        Me.txtStartDay.TabIndex = 31
        '
        'lblStartDay
        '
        Me.lblStartDay.AutoSize = True
        Me.lblStartDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartDay.ForeColor = System.Drawing.Color.White
        Me.lblStartDay.Location = New System.Drawing.Point(299, 139)
        Me.lblStartDay.Name = "lblStartDay"
        Me.lblStartDay.Size = New System.Drawing.Size(76, 20)
        Me.lblStartDay.TabIndex = 30
        Me.lblStartDay.Text = "Start Day"
        '
        'txtLeaveLeft
        '
        Me.txtLeaveLeft.Enabled = False
        Me.txtLeaveLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeaveLeft.Location = New System.Drawing.Point(303, 109)
        Me.txtLeaveLeft.Name = "txtLeaveLeft"
        Me.txtLeaveLeft.Size = New System.Drawing.Size(244, 27)
        Me.txtLeaveLeft.TabIndex = 29
        '
        'lblLeaveLeft
        '
        Me.lblLeaveLeft.AutoSize = True
        Me.lblLeaveLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaveLeft.ForeColor = System.Drawing.Color.White
        Me.lblLeaveLeft.Location = New System.Drawing.Point(299, 86)
        Me.lblLeaveLeft.Name = "lblLeaveLeft"
        Me.lblLeaveLeft.Size = New System.Drawing.Size(84, 20)
        Me.lblLeaveLeft.TabIndex = 28
        Me.lblLeaveLeft.Text = "Leave Left"
        '
        'cbLeave
        '
        Me.cbLeave.Enabled = False
        Me.cbLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLeave.FormattingEnabled = True
        Me.cbLeave.Location = New System.Drawing.Point(303, 55)
        Me.cbLeave.Name = "cbLeave"
        Me.cbLeave.Size = New System.Drawing.Size(244, 26)
        Me.cbLeave.TabIndex = 27
        '
        'lblLeave
        '
        Me.lblLeave.AutoSize = True
        Me.lblLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeave.ForeColor = System.Drawing.Color.White
        Me.lblLeave.Location = New System.Drawing.Point(299, 33)
        Me.lblLeave.Name = "lblLeave"
        Me.lblLeave.Size = New System.Drawing.Size(52, 20)
        Me.lblLeave.TabIndex = 26
        Me.lblLeave.Text = "Leave"
        '
        'txtDepartment
        '
        Me.txtDepartment.Enabled = False
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(26, 215)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(244, 27)
        Me.txtDepartment.TabIndex = 23
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.White
        Me.lblDepartment.Location = New System.Drawing.Point(22, 192)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(94, 20)
        Me.lblDepartment.TabIndex = 24
        Me.lblDepartment.Text = "Department"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(26, 162)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(244, 27)
        Me.txtLastName.TabIndex = 21
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.White
        Me.lblLastName.Location = New System.Drawing.Point(22, 139)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(86, 20)
        Me.lblLastName.TabIndex = 22
        Me.lblLastName.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(26, 109)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(244, 27)
        Me.txtFirstName.TabIndex = 19
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.White
        Me.lblFirstName.Location = New System.Drawing.Point(22, 86)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(86, 20)
        Me.lblFirstName.TabIndex = 20
        Me.lblFirstName.Text = "First Name"
        '
        'txtEmployeeCode
        '
        Me.txtEmployeeCode.Enabled = False
        Me.txtEmployeeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeCode.Location = New System.Drawing.Point(26, 56)
        Me.txtEmployeeCode.Name = "txtEmployeeCode"
        Me.txtEmployeeCode.Size = New System.Drawing.Size(244, 27)
        Me.txtEmployeeCode.TabIndex = 18
        '
        'lblEmployeeCode
        '
        Me.lblEmployeeCode.AutoSize = True
        Me.lblEmployeeCode.BackColor = System.Drawing.Color.Transparent
        Me.lblEmployeeCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCode.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeCode.Location = New System.Drawing.Point(22, 33)
        Me.lblEmployeeCode.Name = "lblEmployeeCode"
        Me.lblEmployeeCode.Size = New System.Drawing.Size(121, 20)
        Me.lblEmployeeCode.TabIndex = 18
        Me.lblEmployeeCode.Text = "Employee Code"
        '
        'lblSearchEmployee
        '
        Me.lblSearchEmployee.AutoSize = True
        Me.lblSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchEmployee.ForeColor = System.Drawing.Color.White
        Me.lblSearchEmployee.Location = New System.Drawing.Point(11, 294)
        Me.lblSearchEmployee.Name = "lblSearchEmployee"
        Me.lblSearchEmployee.Size = New System.Drawing.Size(134, 20)
        Me.lblSearchEmployee.TabIndex = 17
        Me.lblSearchEmployee.Text = "Search Employee"
        '
        'tmrReload
        '
        Me.tmrReload.Interval = 1000
        '
        'frmMaintenanceLeave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1030, 697)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSearchEmployee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearchEmployee)
        Me.Controls.Add(Me.lvLeave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1046, 736)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1046, 736)
        Me.Name = "frmMaintenanceLeave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Maintenance Leave "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearchEmployee As TextBox
    Friend WithEvents lvLeave As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSearchEmployee As Label
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmployeeCode As TextBox
    Friend WithEvents lblEmployeeCode As Label
    Friend WithEvents cbLeave As ComboBox
    Friend WithEvents lblLeave As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents txtReason As TextBox
    Friend WithEvents lblReason As Label
    Friend WithEvents txtEndDay As TextBox
    Friend WithEvents lblEndDay As Label
    Friend WithEvents txtStartDay As TextBox
    Friend WithEvents lblStartDay As Label
    Friend WithEvents txtLeaveLeft As TextBox
    Friend WithEvents lblLeaveLeft As Label
    Friend WithEvents lblValidate As Label
    Friend WithEvents tmrReload As Timer
    Friend WithEvents adminID As Label
    Friend WithEvents lblID As Label
End Class
