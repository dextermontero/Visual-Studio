<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoginAdministrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoginAdministrator))
        Me.gbBorder = New System.Windows.Forms.GroupBox()
        Me.lnkRegister = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pcbHeader = New System.Windows.Forms.PictureBox()
        Me.reload = New System.Windows.Forms.Timer(Me.components)
        Me.gbBorder.SuspendLayout()
        CType(Me.pcbHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbBorder
        '
        Me.gbBorder.Controls.Add(Me.lnkRegister)
        Me.gbBorder.Controls.Add(Me.btnLogin)
        Me.gbBorder.Controls.Add(Me.txtPassword)
        Me.gbBorder.Controls.Add(Me.txtUsername)
        Me.gbBorder.Controls.Add(Me.lblPassword)
        Me.gbBorder.Controls.Add(Me.lblUsername)
        Me.gbBorder.Location = New System.Drawing.Point(12, 174)
        Me.gbBorder.Name = "gbBorder"
        Me.gbBorder.Size = New System.Drawing.Size(367, 195)
        Me.gbBorder.TabIndex = 1
        Me.gbBorder.TabStop = False
        '
        'lnkRegister
        '
        Me.lnkRegister.AutoSize = True
        Me.lnkRegister.Location = New System.Drawing.Point(140, 165)
        Me.lnkRegister.Name = "lnkRegister"
        Me.lnkRegister.Size = New System.Drawing.Size(99, 13)
        Me.lnkRegister.TabIndex = 5
        Me.lnkRegister.TabStop = True
        Me.lnkRegister.Text = "Create an Account!"
        '
        'btnLogin
        '
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(6, 103)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(355, 47)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "L O G I N"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(143, 59)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(218, 29)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(143, 22)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(218, 29)
        Me.txtUsername.TabIndex = 2
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(9, 62)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(128, 24)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password : "
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(6, 25)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(131, 24)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username : "
        '
        'pcbHeader
        '
        Me.pcbHeader.BackgroundImage = Global.QCU_Administrator.My.Resources.Resources.header
        Me.pcbHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbHeader.Location = New System.Drawing.Point(-1, -1)
        Me.pcbHeader.Name = "pcbHeader"
        Me.pcbHeader.Size = New System.Drawing.Size(392, 169)
        Me.pcbHeader.TabIndex = 0
        Me.pcbHeader.TabStop = False
        '
        'reload
        '
        Me.reload.Interval = 1000
        '
        'frmLoginAdministrator
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 381)
        Me.Controls.Add(Me.gbBorder)
        Me.Controls.Add(Me.pcbHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmLoginAdministrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QCU - Administrator Login"
        Me.gbBorder.ResumeLayout(False)
        Me.gbBorder.PerformLayout()
        CType(Me.pcbHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pcbHeader As PictureBox
    Friend WithEvents gbBorder As GroupBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkRegister As LinkLabel
    Friend WithEvents reload As Timer
End Class
