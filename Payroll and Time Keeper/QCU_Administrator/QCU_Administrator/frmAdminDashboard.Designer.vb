<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminDashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminDashboard))
        Me.gbMenu = New System.Windows.Forms.GroupBox()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.lblAdminID = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnManageLeave = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblAdminName = New System.Windows.Forms.Label()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.pcbAdminPic = New System.Windows.Forms.PictureBox()
        Me.pnlBackground = New System.Windows.Forms.Panel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pnlSchedule = New System.Windows.Forms.Panel()
        Me.lnkSchedule = New System.Windows.Forms.LinkLabel()
        Me.lblScheduleNo = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.pcbSchedule = New System.Windows.Forms.PictureBox()
        Me.pnlAdmin = New System.Windows.Forms.Panel()
        Me.lnkAdminInfo = New System.Windows.Forms.LinkLabel()
        Me.lblTotalAdminNo = New System.Windows.Forms.Label()
        Me.lblTotalAdmin = New System.Windows.Forms.Label()
        Me.pcbAdmin = New System.Windows.Forms.PictureBox()
        Me.pnlDepartment = New System.Windows.Forms.Panel()
        Me.lnkDepartmentInfo = New System.Windows.Forms.LinkLabel()
        Me.totalDepartmentNo = New System.Windows.Forms.Label()
        Me.totalDepartment = New System.Windows.Forms.Label()
        Me.pcbDepartment = New System.Windows.Forms.PictureBox()
        Me.pnlLeave = New System.Windows.Forms.Panel()
        Me.lnkLeave = New System.Windows.Forms.LinkLabel()
        Me.lbltotalLeaveNo = New System.Windows.Forms.Label()
        Me.lbltotalLeave = New System.Windows.Forms.Label()
        Me.pcbLeave = New System.Windows.Forms.PictureBox()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.pnlEmployee = New System.Windows.Forms.Panel()
        Me.lnkEmployeeInfo = New System.Windows.Forms.LinkLabel()
        Me.lblTotalEmployeeNo = New System.Windows.Forms.Label()
        Me.lblTotalEmployee = New System.Windows.Forms.Label()
        Me.pcbEmployee = New System.Windows.Forms.PictureBox()
        Me.gbLogs = New System.Windows.Forms.GroupBox()
        Me.lblTimeoutlogs = New System.Windows.Forms.Label()
        Me.lblTimeinlogs = New System.Windows.Forms.Label()
        Me.lvTimeOut = New System.Windows.Forms.ListView()
        Me.chCode_out = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName_out = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDepartment_out = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTime_out = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTimeIn = New System.Windows.Forms.ListView()
        Me.chCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.timeTick = New System.Windows.Forms.Timer(Me.components)
        Me.timeData = New System.Windows.Forms.Timer(Me.components)
        Me.gbMenu.SuspendLayout()
        CType(Me.pcbAdminPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackground.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSchedule.SuspendLayout()
        CType(Me.pcbSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAdmin.SuspendLayout()
        CType(Me.pcbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDepartment.SuspendLayout()
        CType(Me.pcbDepartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLeave.SuspendLayout()
        CType(Me.pcbLeave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlEmployee.SuspendLayout()
        CType(Me.pcbEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbLogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMenu
        '
        Me.gbMenu.Controls.Add(Me.btnMaintenance)
        Me.gbMenu.Controls.Add(Me.lblAdminID)
        Me.gbMenu.Controls.Add(Me.btnLogout)
        Me.gbMenu.Controls.Add(Me.btnReports)
        Me.gbMenu.Controls.Add(Me.btnSettings)
        Me.gbMenu.Controls.Add(Me.Button4)
        Me.gbMenu.Controls.Add(Me.btnManageLeave)
        Me.gbMenu.Controls.Add(Me.btnAddEmployee)
        Me.gbMenu.Controls.Add(Me.btnAdd)
        Me.gbMenu.Controls.Add(Me.lblAdminName)
        Me.gbMenu.Controls.Add(Me.lblAccount)
        Me.gbMenu.Controls.Add(Me.pcbAdminPic)
        Me.gbMenu.Location = New System.Drawing.Point(13, 13)
        Me.gbMenu.Name = "gbMenu"
        Me.gbMenu.Size = New System.Drawing.Size(224, 643)
        Me.gbMenu.TabIndex = 0
        Me.gbMenu.TabStop = False
        '
        'btnMaintenance
        '
        Me.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnMaintenance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaintenance.Location = New System.Drawing.Point(15, 533)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(191, 34)
        Me.btnMaintenance.TabIndex = 11
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = False
        '
        'lblAdminID
        '
        Me.lblAdminID.AutoSize = True
        Me.lblAdminID.Location = New System.Drawing.Point(12, 26)
        Me.lblAdminID.Name = "lblAdminID"
        Me.lblAdminID.Size = New System.Drawing.Size(0, 13)
        Me.lblAdminID.TabIndex = 10
        Me.lblAdminID.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(15, 593)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(191, 34)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnReports.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(15, 483)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(191, 34)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(15, 433)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(191, 34)
        Me.btnSettings.TabIndex = 7
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(15, 383)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(191, 34)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Generate Salary"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnManageLeave
        '
        Me.btnManageLeave.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnManageLeave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnManageLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageLeave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageLeave.ForeColor = System.Drawing.Color.White
        Me.btnManageLeave.Location = New System.Drawing.Point(15, 333)
        Me.btnManageLeave.Name = "btnManageLeave"
        Me.btnManageLeave.Size = New System.Drawing.Size(191, 34)
        Me.btnManageLeave.TabIndex = 5
        Me.btnManageLeave.Text = "Manage Leave"
        Me.btnManageLeave.UseVisualStyleBackColor = False
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEmployee.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmployee.ForeColor = System.Drawing.Color.White
        Me.btnAddEmployee.Location = New System.Drawing.Point(15, 283)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Size = New System.Drawing.Size(191, 34)
        Me.btnAddEmployee.TabIndex = 4
        Me.btnAddEmployee.Text = "Manage Employee"
        Me.btnAddEmployee.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(15, 233)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(191, 34)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Schedule"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblAdminName
        '
        Me.lblAdminName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAdminName.Location = New System.Drawing.Point(18, 201)
        Me.lblAdminName.Name = "lblAdminName"
        Me.lblAdminName.Size = New System.Drawing.Size(188, 20)
        Me.lblAdminName.TabIndex = 2
        Me.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccount.Location = New System.Drawing.Point(40, 20)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(137, 26)
        Me.lblAccount.TabIndex = 1
        Me.lblAccount.Text = "My Account"
        '
        'pcbAdminPic
        '
        Me.pcbAdminPic.BackColor = System.Drawing.Color.White
        Me.pcbAdminPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbAdminPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbAdminPic.Location = New System.Drawing.Point(15, 59)
        Me.pcbAdminPic.Name = "pcbAdminPic"
        Me.pcbAdminPic.Size = New System.Drawing.Size(191, 132)
        Me.pcbAdminPic.TabIndex = 0
        Me.pcbAdminPic.TabStop = False
        '
        'pnlBackground
        '
        Me.pnlBackground.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.pnlBackground.Controls.Add(Me.gbMenu)
        Me.pnlBackground.Location = New System.Drawing.Point(0, 0)
        Me.pnlBackground.Name = "pnlBackground"
        Me.pnlBackground.Size = New System.Drawing.Size(252, 670)
        Me.pnlBackground.TabIndex = 1
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.Panel5)
        Me.pnlBody.Controls.Add(Me.pnlSchedule)
        Me.pnlBody.Controls.Add(Me.pnlAdmin)
        Me.pnlBody.Controls.Add(Me.pnlDepartment)
        Me.pnlBody.Controls.Add(Me.pnlLeave)
        Me.pnlBody.Controls.Add(Me.pnlDashboard)
        Me.pnlBody.Controls.Add(Me.pnlEmployee)
        Me.pnlBody.Controls.Add(Me.gbLogs)
        Me.pnlBody.Location = New System.Drawing.Point(252, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(855, 667)
        Me.pnlBody.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.LinkLabel5)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Location = New System.Drawing.Point(573, 233)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(255, 132)
        Me.Panel5.TabIndex = 6
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(149, 92)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(63, 16)
        Me.LinkLabel5.TabIndex = 3
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "More Info"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(149, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 36)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "150"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(123, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Employee"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.employee
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(0, 15)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 102)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'pnlSchedule
        '
        Me.pnlSchedule.BackColor = System.Drawing.Color.White
        Me.pnlSchedule.Controls.Add(Me.lnkSchedule)
        Me.pnlSchedule.Controls.Add(Me.lblScheduleNo)
        Me.pnlSchedule.Controls.Add(Me.lblSchedule)
        Me.pnlSchedule.Controls.Add(Me.pcbSchedule)
        Me.pnlSchedule.Location = New System.Drawing.Point(297, 233)
        Me.pnlSchedule.Name = "pnlSchedule"
        Me.pnlSchedule.Size = New System.Drawing.Size(255, 132)
        Me.pnlSchedule.TabIndex = 5
        '
        'lnkSchedule
        '
        Me.lnkSchedule.AutoSize = True
        Me.lnkSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSchedule.Location = New System.Drawing.Point(149, 92)
        Me.lnkSchedule.Name = "lnkSchedule"
        Me.lnkSchedule.Size = New System.Drawing.Size(63, 16)
        Me.lnkSchedule.TabIndex = 3
        Me.lnkSchedule.TabStop = True
        Me.lnkSchedule.Text = "More Info"
        '
        'lblScheduleNo
        '
        Me.lblScheduleNo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduleNo.Location = New System.Drawing.Point(149, 51)
        Me.lblScheduleNo.Name = "lblScheduleNo"
        Me.lblScheduleNo.Size = New System.Drawing.Size(63, 36)
        Me.lblScheduleNo.TabIndex = 2
        Me.lblScheduleNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(141, 26)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(98, 19)
        Me.lblSchedule.TabIndex = 1
        Me.lblSchedule.Text = "Total Schedule"
        '
        'pcbSchedule
        '
        Me.pcbSchedule.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.schedule
        Me.pcbSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbSchedule.Location = New System.Drawing.Point(8, 15)
        Me.pcbSchedule.Name = "pcbSchedule"
        Me.pcbSchedule.Size = New System.Drawing.Size(100, 102)
        Me.pcbSchedule.TabIndex = 0
        Me.pcbSchedule.TabStop = False
        '
        'pnlAdmin
        '
        Me.pnlAdmin.BackColor = System.Drawing.Color.White
        Me.pnlAdmin.Controls.Add(Me.lnkAdminInfo)
        Me.pnlAdmin.Controls.Add(Me.lblTotalAdminNo)
        Me.pnlAdmin.Controls.Add(Me.lblTotalAdmin)
        Me.pnlAdmin.Controls.Add(Me.pcbAdmin)
        Me.pnlAdmin.Location = New System.Drawing.Point(297, 80)
        Me.pnlAdmin.Name = "pnlAdmin"
        Me.pnlAdmin.Size = New System.Drawing.Size(255, 132)
        Me.pnlAdmin.TabIndex = 4
        '
        'lnkAdminInfo
        '
        Me.lnkAdminInfo.AutoSize = True
        Me.lnkAdminInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAdminInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkAdminInfo.Location = New System.Drawing.Point(149, 92)
        Me.lnkAdminInfo.Name = "lnkAdminInfo"
        Me.lnkAdminInfo.Size = New System.Drawing.Size(63, 16)
        Me.lnkAdminInfo.TabIndex = 3
        Me.lnkAdminInfo.TabStop = True
        Me.lnkAdminInfo.Text = "More Info"
        '
        'lblTotalAdminNo
        '
        Me.lblTotalAdminNo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAdminNo.Location = New System.Drawing.Point(149, 51)
        Me.lblTotalAdminNo.Name = "lblTotalAdminNo"
        Me.lblTotalAdminNo.Size = New System.Drawing.Size(63, 36)
        Me.lblTotalAdminNo.TabIndex = 2
        Me.lblTotalAdminNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalAdmin
        '
        Me.lblTotalAdmin.AutoSize = True
        Me.lblTotalAdmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAdmin.Location = New System.Drawing.Point(123, 26)
        Me.lblTotalAdmin.Name = "lblTotalAdmin"
        Me.lblTotalAdmin.Size = New System.Drawing.Size(124, 19)
        Me.lblTotalAdmin.TabIndex = 1
        Me.lblTotalAdmin.Text = "Total Administrator"
        '
        'pcbAdmin
        '
        Me.pcbAdmin.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.administrator
        Me.pcbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbAdmin.Location = New System.Drawing.Point(0, 15)
        Me.pcbAdmin.Name = "pcbAdmin"
        Me.pcbAdmin.Size = New System.Drawing.Size(100, 102)
        Me.pcbAdmin.TabIndex = 0
        Me.pcbAdmin.TabStop = False
        '
        'pnlDepartment
        '
        Me.pnlDepartment.BackColor = System.Drawing.Color.White
        Me.pnlDepartment.Controls.Add(Me.lnkDepartmentInfo)
        Me.pnlDepartment.Controls.Add(Me.totalDepartmentNo)
        Me.pnlDepartment.Controls.Add(Me.totalDepartment)
        Me.pnlDepartment.Controls.Add(Me.pcbDepartment)
        Me.pnlDepartment.Location = New System.Drawing.Point(573, 80)
        Me.pnlDepartment.Name = "pnlDepartment"
        Me.pnlDepartment.Size = New System.Drawing.Size(255, 132)
        Me.pnlDepartment.TabIndex = 5
        '
        'lnkDepartmentInfo
        '
        Me.lnkDepartmentInfo.AutoSize = True
        Me.lnkDepartmentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkDepartmentInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkDepartmentInfo.Location = New System.Drawing.Point(149, 92)
        Me.lnkDepartmentInfo.Name = "lnkDepartmentInfo"
        Me.lnkDepartmentInfo.Size = New System.Drawing.Size(63, 16)
        Me.lnkDepartmentInfo.TabIndex = 3
        Me.lnkDepartmentInfo.TabStop = True
        Me.lnkDepartmentInfo.Text = "More Info"
        '
        'totalDepartmentNo
        '
        Me.totalDepartmentNo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDepartmentNo.Location = New System.Drawing.Point(149, 51)
        Me.totalDepartmentNo.Name = "totalDepartmentNo"
        Me.totalDepartmentNo.Size = New System.Drawing.Size(63, 36)
        Me.totalDepartmentNo.TabIndex = 2
        Me.totalDepartmentNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalDepartment
        '
        Me.totalDepartment.AutoSize = True
        Me.totalDepartment.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalDepartment.Location = New System.Drawing.Point(123, 26)
        Me.totalDepartment.Name = "totalDepartment"
        Me.totalDepartment.Size = New System.Drawing.Size(114, 19)
        Me.totalDepartment.TabIndex = 1
        Me.totalDepartment.Text = "Total Department"
        '
        'pcbDepartment
        '
        Me.pcbDepartment.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.department
        Me.pcbDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbDepartment.Location = New System.Drawing.Point(7, 15)
        Me.pcbDepartment.Name = "pcbDepartment"
        Me.pcbDepartment.Size = New System.Drawing.Size(100, 102)
        Me.pcbDepartment.TabIndex = 0
        Me.pcbDepartment.TabStop = False
        '
        'pnlLeave
        '
        Me.pnlLeave.BackColor = System.Drawing.Color.White
        Me.pnlLeave.Controls.Add(Me.lnkLeave)
        Me.pnlLeave.Controls.Add(Me.lbltotalLeaveNo)
        Me.pnlLeave.Controls.Add(Me.lbltotalLeave)
        Me.pnlLeave.Controls.Add(Me.pcbLeave)
        Me.pnlLeave.Location = New System.Drawing.Point(21, 233)
        Me.pnlLeave.Name = "pnlLeave"
        Me.pnlLeave.Size = New System.Drawing.Size(255, 132)
        Me.pnlLeave.TabIndex = 4
        '
        'lnkLeave
        '
        Me.lnkLeave.AutoSize = True
        Me.lnkLeave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLeave.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkLeave.Location = New System.Drawing.Point(149, 92)
        Me.lnkLeave.Name = "lnkLeave"
        Me.lnkLeave.Size = New System.Drawing.Size(63, 16)
        Me.lnkLeave.TabIndex = 3
        Me.lnkLeave.TabStop = True
        Me.lnkLeave.Text = "More Info"
        '
        'lbltotalLeaveNo
        '
        Me.lbltotalLeaveNo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalLeaveNo.Location = New System.Drawing.Point(149, 51)
        Me.lbltotalLeaveNo.Name = "lbltotalLeaveNo"
        Me.lbltotalLeaveNo.Size = New System.Drawing.Size(63, 36)
        Me.lbltotalLeaveNo.TabIndex = 2
        Me.lbltotalLeaveNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotalLeave
        '
        Me.lbltotalLeave.AutoSize = True
        Me.lbltotalLeave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalLeave.Location = New System.Drawing.Point(139, 26)
        Me.lbltotalLeave.Name = "lbltotalLeave"
        Me.lbltotalLeave.Size = New System.Drawing.Size(80, 19)
        Me.lbltotalLeave.TabIndex = 1
        Me.lbltotalLeave.Text = "Total Leave"
        '
        'pcbLeave
        '
        Me.pcbLeave.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.leave
        Me.pcbLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbLeave.Location = New System.Drawing.Point(8, 15)
        Me.pcbLeave.Name = "pcbLeave"
        Me.pcbLeave.Size = New System.Drawing.Size(100, 102)
        Me.pcbLeave.TabIndex = 0
        Me.pcbLeave.TabStop = False
        '
        'pnlDashboard
        '
        Me.pnlDashboard.BackColor = System.Drawing.Color.White
        Me.pnlDashboard.Controls.Add(Me.lblTime)
        Me.pnlDashboard.Controls.Add(Me.lblDate)
        Me.pnlDashboard.Controls.Add(Me.lblDashboard)
        Me.pnlDashboard.Location = New System.Drawing.Point(0, 2)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(855, 57)
        Me.pnlDashboard.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(751, 31)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 19)
        Me.lblTime.TabIndex = 5
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(755, 6)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 19)
        Me.lblDate.TabIndex = 4
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.Location = New System.Drawing.Point(21, 11)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(220, 36)
        Me.lblDashboard.TabIndex = 4
        Me.lblDashboard.Text = "DASHBOARD"
        '
        'pnlEmployee
        '
        Me.pnlEmployee.BackColor = System.Drawing.Color.White
        Me.pnlEmployee.Controls.Add(Me.lnkEmployeeInfo)
        Me.pnlEmployee.Controls.Add(Me.lblTotalEmployeeNo)
        Me.pnlEmployee.Controls.Add(Me.lblTotalEmployee)
        Me.pnlEmployee.Controls.Add(Me.pcbEmployee)
        Me.pnlEmployee.Location = New System.Drawing.Point(21, 80)
        Me.pnlEmployee.Name = "pnlEmployee"
        Me.pnlEmployee.Size = New System.Drawing.Size(255, 132)
        Me.pnlEmployee.TabIndex = 0
        '
        'lnkEmployeeInfo
        '
        Me.lnkEmployeeInfo.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkEmployeeInfo.AutoSize = True
        Me.lnkEmployeeInfo.BackColor = System.Drawing.Color.Transparent
        Me.lnkEmployeeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmployeeInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkEmployeeInfo.LinkColor = System.Drawing.Color.Blue
        Me.lnkEmployeeInfo.Location = New System.Drawing.Point(149, 92)
        Me.lnkEmployeeInfo.Name = "lnkEmployeeInfo"
        Me.lnkEmployeeInfo.Size = New System.Drawing.Size(63, 16)
        Me.lnkEmployeeInfo.TabIndex = 3
        Me.lnkEmployeeInfo.TabStop = True
        Me.lnkEmployeeInfo.Text = "More Info"
        '
        'lblTotalEmployeeNo
        '
        Me.lblTotalEmployeeNo.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployeeNo.Location = New System.Drawing.Point(149, 51)
        Me.lblTotalEmployeeNo.Name = "lblTotalEmployeeNo"
        Me.lblTotalEmployeeNo.Size = New System.Drawing.Size(63, 36)
        Me.lblTotalEmployeeNo.TabIndex = 2
        Me.lblTotalEmployeeNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalEmployee
        '
        Me.lblTotalEmployee.AutoSize = True
        Me.lblTotalEmployee.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalEmployee.Location = New System.Drawing.Point(123, 26)
        Me.lblTotalEmployee.Name = "lblTotalEmployee"
        Me.lblTotalEmployee.Size = New System.Drawing.Size(103, 19)
        Me.lblTotalEmployee.TabIndex = 1
        Me.lblTotalEmployee.Text = "Total Employee"
        '
        'pcbEmployee
        '
        Me.pcbEmployee.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.employee
        Me.pcbEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbEmployee.Location = New System.Drawing.Point(0, 15)
        Me.pcbEmployee.Name = "pcbEmployee"
        Me.pcbEmployee.Size = New System.Drawing.Size(100, 102)
        Me.pcbEmployee.TabIndex = 0
        Me.pcbEmployee.TabStop = False
        '
        'gbLogs
        '
        Me.gbLogs.BackColor = System.Drawing.Color.White
        Me.gbLogs.Controls.Add(Me.lblTimeoutlogs)
        Me.gbLogs.Controls.Add(Me.lblTimeinlogs)
        Me.gbLogs.Controls.Add(Me.lvTimeOut)
        Me.gbLogs.Controls.Add(Me.lvTimeIn)
        Me.gbLogs.Location = New System.Drawing.Point(6, 383)
        Me.gbLogs.Name = "gbLogs"
        Me.gbLogs.Size = New System.Drawing.Size(837, 277)
        Me.gbLogs.TabIndex = 10
        Me.gbLogs.TabStop = False
        '
        'lblTimeoutlogs
        '
        Me.lblTimeoutlogs.AutoSize = True
        Me.lblTimeoutlogs.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeoutlogs.Location = New System.Drawing.Point(431, 14)
        Me.lblTimeoutlogs.Name = "lblTimeoutlogs"
        Me.lblTimeoutlogs.Size = New System.Drawing.Size(151, 26)
        Me.lblTimeoutlogs.TabIndex = 10
        Me.lblTimeoutlogs.Text = "Time-out logs"
        '
        'lblTimeinlogs
        '
        Me.lblTimeinlogs.AutoSize = True
        Me.lblTimeinlogs.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeinlogs.Location = New System.Drawing.Point(16, 14)
        Me.lblTimeinlogs.Name = "lblTimeinlogs"
        Me.lblTimeinlogs.Size = New System.Drawing.Size(138, 26)
        Me.lblTimeinlogs.TabIndex = 4
        Me.lblTimeinlogs.Text = "Time-in logs"
        '
        'lvTimeOut
        '
        Me.lvTimeOut.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCode_out, Me.chName_out, Me.chDepartment_out, Me.chTime_out})
        Me.lvTimeOut.GridLines = True
        Me.lvTimeOut.Location = New System.Drawing.Point(431, 43)
        Me.lvTimeOut.MaximumSize = New System.Drawing.Size(391, 216)
        Me.lvTimeOut.MinimumSize = New System.Drawing.Size(391, 216)
        Me.lvTimeOut.Name = "lvTimeOut"
        Me.lvTimeOut.Size = New System.Drawing.Size(391, 216)
        Me.lvTimeOut.TabIndex = 8
        Me.lvTimeOut.UseCompatibleStateImageBehavior = False
        Me.lvTimeOut.View = System.Windows.Forms.View.Details
        '
        'chCode_out
        '
        Me.chCode_out.Text = "Employee Code"
        Me.chCode_out.Width = 90
        '
        'chName_out
        '
        Me.chName_out.Text = "Employee Name"
        Me.chName_out.Width = 110
        '
        'chDepartment_out
        '
        Me.chDepartment_out.Text = "Department"
        Me.chDepartment_out.Width = 126
        '
        'chTime_out
        '
        Me.chTime_out.Text = "Time Out"
        '
        'lvTimeIn
        '
        Me.lvTimeIn.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCode, Me.chName, Me.chDepartment, Me.chTime})
        Me.lvTimeIn.GridLines = True
        Me.lvTimeIn.Location = New System.Drawing.Point(15, 43)
        Me.lvTimeIn.MaximumSize = New System.Drawing.Size(391, 216)
        Me.lvTimeIn.MinimumSize = New System.Drawing.Size(391, 216)
        Me.lvTimeIn.Name = "lvTimeIn"
        Me.lvTimeIn.Size = New System.Drawing.Size(391, 216)
        Me.lvTimeIn.TabIndex = 9
        Me.lvTimeIn.UseCompatibleStateImageBehavior = False
        Me.lvTimeIn.View = System.Windows.Forms.View.Details
        '
        'chCode
        '
        Me.chCode.Text = "Employee Code"
        Me.chCode.Width = 90
        '
        'chName
        '
        Me.chName.Text = "Employee Name"
        Me.chName.Width = 110
        '
        'chDepartment
        '
        Me.chDepartment.Text = "Department"
        Me.chDepartment.Width = 126
        '
        'chTime
        '
        Me.chTime.Text = "Time In"
        '
        'timeTick
        '
        Me.timeTick.Interval = 1000
        '
        'timeData
        '
        Me.timeData.Interval = 10
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 667)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlBackground)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1123, 706)
        Me.MinimumSize = New System.Drawing.Size(1123, 706)
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Administrator Dashboard"
        Me.gbMenu.ResumeLayout(False)
        Me.gbMenu.PerformLayout()
        CType(Me.pcbAdminPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackground.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSchedule.ResumeLayout(False)
        Me.pnlSchedule.PerformLayout()
        CType(Me.pcbSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAdmin.ResumeLayout(False)
        Me.pnlAdmin.PerformLayout()
        CType(Me.pcbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDepartment.ResumeLayout(False)
        Me.pnlDepartment.PerformLayout()
        CType(Me.pcbDepartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLeave.ResumeLayout(False)
        Me.pnlLeave.PerformLayout()
        CType(Me.pcbLeave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlDashboard.PerformLayout()
        Me.pnlEmployee.ResumeLayout(False)
        Me.pnlEmployee.PerformLayout()
        CType(Me.pcbEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbLogs.ResumeLayout(False)
        Me.gbLogs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents pcbAdminPic As PictureBox
    Friend WithEvents lblAccount As Label
    Friend WithEvents lblAdminName As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnManageLeave As Button
    Friend WithEvents btnAddEmployee As Button
    Friend WithEvents pnlBackground As Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents lblDashboard As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents timeTick As Timer
    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents lblTotalEmployeeNo As Label
    Friend WithEvents lblTotalEmployee As Label
    Friend WithEvents pcbEmployee As PictureBox
    Friend WithEvents lnkEmployeeInfo As LinkLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pnlSchedule As Panel
    Friend WithEvents lnkSchedule As LinkLabel
    Friend WithEvents lblScheduleNo As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents pcbSchedule As PictureBox
    Friend WithEvents pnlAdmin As Panel
    Friend WithEvents lnkAdminInfo As LinkLabel
    Friend WithEvents lblTotalAdminNo As Label
    Friend WithEvents lblTotalAdmin As Label
    Friend WithEvents pcbAdmin As PictureBox
    Friend WithEvents pnlDepartment As Panel
    Friend WithEvents lnkDepartmentInfo As LinkLabel
    Friend WithEvents totalDepartmentNo As Label
    Friend WithEvents totalDepartment As Label
    Friend WithEvents pcbDepartment As PictureBox
    Friend WithEvents pnlLeave As Panel
    Friend WithEvents lnkLeave As LinkLabel
    Friend WithEvents lbltotalLeaveNo As Label
    Friend WithEvents lbltotalLeave As Label
    Friend WithEvents pcbLeave As PictureBox
    Friend WithEvents lvTimeOut As ListView
    Friend WithEvents lvTimeIn As ListView
    Friend WithEvents chCode As ColumnHeader
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chDepartment As ColumnHeader
    Friend WithEvents chTime As ColumnHeader
    Friend WithEvents chCode_out As ColumnHeader
    Friend WithEvents chName_out As ColumnHeader
    Friend WithEvents chDepartment_out As ColumnHeader
    Friend WithEvents chTime_out As ColumnHeader
    Friend WithEvents gbLogs As GroupBox
    Friend WithEvents lblTimeoutlogs As Label
    Friend WithEvents lblTimeinlogs As Label
    Friend WithEvents lblAdminID As Label
    Friend WithEvents timeData As Timer
    Friend WithEvents btnMaintenance As Button
End Class
