<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDecrypt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDecrypt))
        Me.txtRealMessage = New System.Windows.Forms.TextBox
        Me.ssMainStatus = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.pbProgressIndicator = New System.Windows.Forms.ToolStripProgressBar
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnDecrypt = New System.Windows.Forms.Button
        Me.rdNormal = New System.Windows.Forms.RadioButton
        Me.rdSlow = New System.Windows.Forms.RadioButton
        Me.chkSlowDisable = New System.Windows.Forms.CheckBox
        Me.chkSlowEnable = New System.Windows.Forms.CheckBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnEnterPassword = New System.Windows.Forms.Button
        Me.lblPassword = New System.Windows.Forms.Label
        Me.gbSlow = New System.Windows.Forms.GroupBox
        Me.Slow = New System.Windows.Forms.Timer(Me.components)
        Me.ssMainStatus.SuspendLayout()
        Me.gbSlow.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRealMessage
        '
        Me.txtRealMessage.AcceptsTab = True
        Me.txtRealMessage.BackColor = System.Drawing.Color.White
        Me.txtRealMessage.Location = New System.Drawing.Point(-1, 1)
        Me.txtRealMessage.MaxLength = 1000000
        Me.txtRealMessage.Multiline = True
        Me.txtRealMessage.Name = "txtRealMessage"
        Me.txtRealMessage.ReadOnly = True
        Me.txtRealMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRealMessage.Size = New System.Drawing.Size(552, 260)
        Me.txtRealMessage.TabIndex = 1
        '
        'ssMainStatus
        '
        Me.ssMainStatus.BackColor = System.Drawing.Color.White
        Me.ssMainStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ssMainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.pbProgressIndicator})
        Me.ssMainStatus.Location = New System.Drawing.Point(0, 395)
        Me.ssMainStatus.Name = "ssMainStatus"
        Me.ssMainStatus.Size = New System.Drawing.Size(552, 22)
        Me.ssMainStatus.SizingGrip = False
        Me.ssMainStatus.TabIndex = 4
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(435, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Secret Message- Decrypt"
        '
        'pbProgressIndicator
        '
        Me.pbProgressIndicator.Name = "pbProgressIndicator"
        Me.pbProgressIndicator.Size = New System.Drawing.Size(100, 16)
        Me.pbProgressIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(267, 325)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 62)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnDecrypt
        '
        Me.btnDecrypt.BackColor = System.Drawing.Color.White
        Me.btnDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Image = CType(resources.GetObject("btnDecrypt.Image"), System.Drawing.Image)
        Me.btnDecrypt.Location = New System.Drawing.Point(104, 325)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(157, 62)
        Me.btnDecrypt.TabIndex = 7
        Me.btnDecrypt.Text = "&Receive Message"
        Me.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDecrypt.UseVisualStyleBackColor = False
        '
        'rdNormal
        '
        Me.rdNormal.AutoSize = True
        Me.rdNormal.BackColor = System.Drawing.Color.Transparent
        Me.rdNormal.Checked = True
        Me.rdNormal.Location = New System.Drawing.Point(6, 55)
        Me.rdNormal.Name = "rdNormal"
        Me.rdNormal.Size = New System.Drawing.Size(64, 17)
        Me.rdNormal.TabIndex = 6
        Me.rdNormal.TabStop = True
        Me.rdNormal.Text = "Normal"
        Me.rdNormal.UseVisualStyleBackColor = False
        '
        'rdSlow
        '
        Me.rdSlow.AutoSize = True
        Me.rdSlow.BackColor = System.Drawing.Color.Transparent
        Me.rdSlow.Location = New System.Drawing.Point(6, 32)
        Me.rdSlow.Name = "rdSlow"
        Me.rdSlow.Size = New System.Drawing.Size(52, 17)
        Me.rdSlow.TabIndex = 5
        Me.rdSlow.Text = "Slow"
        Me.rdSlow.UseVisualStyleBackColor = False
        '
        'chkSlowDisable
        '
        Me.chkSlowDisable.AutoSize = True
        Me.chkSlowDisable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSlowDisable.Location = New System.Drawing.Point(280, 273)
        Me.chkSlowDisable.Name = "chkSlowDisable"
        Me.chkSlowDisable.Size = New System.Drawing.Size(141, 17)
        Me.chkSlowDisable.TabIndex = 4
        Me.chkSlowDisable.Text = "Disable Slow Motion"
        Me.chkSlowDisable.UseVisualStyleBackColor = True
        Me.chkSlowDisable.Visible = False
        '
        'chkSlowEnable
        '
        Me.chkSlowEnable.AutoSize = True
        Me.chkSlowEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSlowEnable.Location = New System.Drawing.Point(280, 273)
        Me.chkSlowEnable.Name = "chkSlowEnable"
        Me.chkSlowEnable.Size = New System.Drawing.Size(138, 17)
        Me.chkSlowEnable.TabIndex = 3
        Me.chkSlowEnable.Text = "Enable Slow Motion"
        Me.chkSlowEnable.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(99, 270)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Visible = False
        '
        'btnEnterPassword
        '
        Me.btnEnterPassword.BackColor = System.Drawing.Color.White
        Me.btnEnterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterPassword.Location = New System.Drawing.Point(205, 270)
        Me.btnEnterPassword.Name = "btnEnterPassword"
        Me.btnEnterPassword.Size = New System.Drawing.Size(69, 23)
        Me.btnEnterPassword.TabIndex = 2
        Me.btnEnterPassword.Text = "Activate"
        Me.btnEnterPassword.UseVisualStyleBackColor = False
        Me.btnEnterPassword.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(-2, 273)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(95, 13)
        Me.lblPassword.TabIndex = 0
        Me.lblPassword.Text = "Enter Password"
        Me.lblPassword.Visible = False
        '
        'gbSlow
        '
        Me.gbSlow.BackColor = System.Drawing.Color.White
        Me.gbSlow.BackgroundImage = CType(resources.GetObject("gbSlow.BackgroundImage"), System.Drawing.Image)
        Me.gbSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbSlow.Controls.Add(Me.rdSlow)
        Me.gbSlow.Controls.Add(Me.rdNormal)
        Me.gbSlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSlow.ForeColor = System.Drawing.Color.Black
        Me.gbSlow.Location = New System.Drawing.Point(438, 267)
        Me.gbSlow.Name = "gbSlow"
        Me.gbSlow.Size = New System.Drawing.Size(102, 79)
        Me.gbSlow.TabIndex = 14
        Me.gbSlow.TabStop = False
        Me.gbSlow.Text = "Slow Motion Speed"
        Me.gbSlow.Visible = False
        '
        'Slow
        '
        Me.Slow.Interval = 1
        '
        'frmDecrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(552, 417)
        Me.Controls.Add(Me.gbSlow)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnEnterPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.chkSlowEnable)
        Me.Controls.Add(Me.chkSlowDisable)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDecrypt)
        Me.Controls.Add(Me.ssMainStatus)
        Me.Controls.Add(Me.txtRealMessage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDecrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secret Message- Receive Message"
        Me.ssMainStatus.ResumeLayout(False)
        Me.ssMainStatus.PerformLayout()
        Me.gbSlow.ResumeLayout(False)
        Me.gbSlow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRealMessage As System.Windows.Forms.TextBox
    Friend WithEvents ssMainStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pbProgressIndicator As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents rdNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rdSlow As System.Windows.Forms.RadioButton
    Friend WithEvents chkSlowDisable As System.Windows.Forms.CheckBox
    Friend WithEvents chkSlowEnable As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterPassword As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents gbSlow As System.Windows.Forms.GroupBox
    Friend WithEvents Slow As System.Windows.Forms.Timer

End Class
