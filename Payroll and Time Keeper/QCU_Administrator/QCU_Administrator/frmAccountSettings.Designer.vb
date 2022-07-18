<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccountSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountSettings))
        Me.gbBorder = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkNickname = New System.Windows.Forms.LinkLabel()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.lnkPassword = New System.Windows.Forms.LinkLabel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lnkFullname = New System.Windows.Forms.LinkLabel()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lnkEmail = New System.Windows.Forms.LinkLabel()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblDrUsername = New System.Windows.Forms.Label()
        Me.btnSelectProfile = New System.Windows.Forms.Button()
        Me.pcbAdminPic = New System.Windows.Forms.PictureBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.gbBorder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pcbAdminPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBorder
        '
        Me.gbBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gbBorder.Controls.Add(Me.GroupBox1)
        Me.gbBorder.Controls.Add(Me.btnSelectProfile)
        Me.gbBorder.Controls.Add(Me.pcbAdminPic)
        Me.gbBorder.Controls.Add(Me.btnChangePassword)
        Me.gbBorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.gbBorder.Location = New System.Drawing.Point(12, 12)
        Me.gbBorder.Name = "gbBorder"
        Me.gbBorder.Size = New System.Drawing.Size(576, 424)
        Me.gbBorder.TabIndex = 1
        Me.gbBorder.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.lnkNickname)
        Me.GroupBox1.Controls.Add(Me.txtNickname)
        Me.GroupBox1.Controls.Add(Me.lblNickname)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.lnkPassword)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lnkFullname)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.lnkEmail)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblfullname)
        Me.GroupBox1.Controls.Add(Me.lblUsername)
        Me.GroupBox1.Controls.Add(Me.lblDrUsername)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 344)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'lnkNickname
        '
        Me.lnkNickname.AutoSize = True
        Me.lnkNickname.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkNickname.Location = New System.Drawing.Point(292, 180)
        Me.lnkNickname.Name = "lnkNickname"
        Me.lnkNickname.Size = New System.Drawing.Size(76, 13)
        Me.lnkNickname.TabIndex = 25
        Me.lnkNickname.TabStop = True
        Me.lnkNickname.Text = "Edit Nickname"
        '
        'txtNickname
        '
        Me.txtNickname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickname.Location = New System.Drawing.Point(23, 173)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(263, 26)
        Me.txtNickname.TabIndex = 24
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickname.Location = New System.Drawing.Point(19, 151)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(77, 19)
        Me.lblNickname.TabIndex = 23
        Me.lblNickname.Text = "Nickname"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(328, 16)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(0, 13)
        Me.id.TabIndex = 22
        Me.id.Visible = False
        '
        'lnkPassword
        '
        Me.lnkPassword.AutoSize = True
        Me.lnkPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkPassword.Location = New System.Drawing.Point(293, 308)
        Me.lnkPassword.Name = "lnkPassword"
        Me.lnkPassword.Size = New System.Drawing.Size(74, 13)
        Me.lnkPassword.TabIndex = 21
        Me.lnkPassword.TabStop = True
        Me.lnkPassword.Text = "Edit Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(24, 301)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(263, 26)
        Me.txtPassword.TabIndex = 20
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Password"
        '
        'lnkFullname
        '
        Me.lnkFullname.AutoSize = True
        Me.lnkFullname.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkFullname.Location = New System.Drawing.Point(293, 114)
        Me.lnkFullname.Name = "lnkFullname"
        Me.lnkFullname.Size = New System.Drawing.Size(75, 13)
        Me.lnkFullname.TabIndex = 18
        Me.lnkFullname.TabStop = True
        Me.lnkFullname.Text = "Edit Full Name"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.Location = New System.Drawing.Point(24, 107)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(263, 26)
        Me.txtFullName.TabIndex = 17
        '
        'lnkEmail
        '
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkEmail.Location = New System.Drawing.Point(293, 245)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(53, 13)
        Me.lnkEmail.TabIndex = 16
        Me.lnkEmail.TabStop = True
        Me.lnkEmail.Text = "Edit Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(24, 238)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 26)
        Me.txtEmail.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(20, 216)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(105, 19)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email Address"
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.Location = New System.Drawing.Point(20, 85)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(78, 19)
        Me.lblfullname.TabIndex = 12
        Me.lblfullname.Text = "Full Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(20, 25)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(77, 19)
        Me.lblUsername.TabIndex = 10
        Me.lblUsername.Text = "Username"
        '
        'lblDrUsername
        '
        Me.lblDrUsername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrUsername.Location = New System.Drawing.Point(20, 53)
        Me.lblDrUsername.Name = "lblDrUsername"
        Me.lblDrUsername.Size = New System.Drawing.Size(267, 19)
        Me.lblDrUsername.TabIndex = 11
        Me.lblDrUsername.Text = "monterodexter09"
        Me.lblDrUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSelectProfile
        '
        Me.btnSelectProfile.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectProfile.Location = New System.Drawing.Point(20, 146)
        Me.btnSelectProfile.Name = "btnSelectProfile"
        Me.btnSelectProfile.Size = New System.Drawing.Size(140, 29)
        Me.btnSelectProfile.TabIndex = 9
        Me.btnSelectProfile.Text = "Choose Profile"
        Me.btnSelectProfile.UseVisualStyleBackColor = True
        '
        'pcbAdminPic
        '
        Me.pcbAdminPic.BackColor = System.Drawing.Color.White
        Me.pcbAdminPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbAdminPic.Location = New System.Drawing.Point(20, 26)
        Me.pcbAdminPic.Name = "pcbAdminPic"
        Me.pcbAdminPic.Size = New System.Drawing.Size(140, 114)
        Me.pcbAdminPic.TabIndex = 8
        Me.pcbAdminPic.TabStop = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.btnChangePassword.Location = New System.Drawing.Point(171, 375)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(386, 36)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Update Information"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'frmAccountSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(601, 448)
        Me.Controls.Add(Me.gbBorder)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(617, 487)
        Me.MinimumSize = New System.Drawing.Size(617, 487)
        Me.Name = "frmAccountSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Settings"
        Me.gbBorder.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pcbAdminPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbBorder As GroupBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnSelectProfile As Button
    Friend WithEvents pcbAdminPic As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblDrUsername As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblfullname As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lnkEmail As LinkLabel
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lnkFullname As LinkLabel
    Friend WithEvents lnkPassword As LinkLabel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As Label
    Friend WithEvents lnkNickname As LinkLabel
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents lblNickname As Label
End Class
