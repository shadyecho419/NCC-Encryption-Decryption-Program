<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncyrptMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncyrptMain))
        Me.btnEncrypt = New System.Windows.Forms.Button
        Me.txtMessageToEncrypt = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtEncryptedMessage = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.ssMainStatus = New System.Windows.Forms.StatusStrip
        Me.lblMessage = New System.Windows.Forms.ToolStripStatusLabel
        Me.pbProgressIndicator = New System.Windows.Forms.ToolStripProgressBar
        Me.Slow = New System.Windows.Forms.Timer(Me.components)
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnEnterPassword = New System.Windows.Forms.Button
        Me.chkSlowEnable = New System.Windows.Forms.CheckBox
        Me.gbSlow = New System.Windows.Forms.GroupBox
        Me.rdSlow = New System.Windows.Forms.RadioButton
        Me.rdNormal = New System.Windows.Forms.RadioButton
        Me.chkSlowDisable = New System.Windows.Forms.CheckBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.ssMainStatus.SuspendLayout()
        Me.gbSlow.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEncrypt
        '
        Me.btnEncrypt.BackColor = System.Drawing.Color.White
        Me.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.Image = CType(resources.GetObject("btnEncrypt.Image"), System.Drawing.Image)
        Me.btnEncrypt.Location = New System.Drawing.Point(12, 319)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(92, 45)
        Me.btnEncrypt.TabIndex = 1
        Me.btnEncrypt.Text = "Hide Message"
        Me.btnEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncrypt.UseVisualStyleBackColor = False
        '
        'txtMessageToEncrypt
        '
        Me.txtMessageToEncrypt.AcceptsTab = True
        Me.txtMessageToEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessageToEncrypt.ForeColor = System.Drawing.Color.Black
        Me.txtMessageToEncrypt.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtMessageToEncrypt.Location = New System.Drawing.Point(0, 370)
        Me.txtMessageToEncrypt.MaxLength = 1000000
        Me.txtMessageToEncrypt.Multiline = True
        Me.txtMessageToEncrypt.Name = "txtMessageToEncrypt"
        Me.txtMessageToEncrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessageToEncrypt.Size = New System.Drawing.Size(554, 164)
        Me.txtMessageToEncrypt.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.Location = New System.Drawing.Point(229, 319)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 45)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtEncryptedMessage
        '
        Me.txtEncryptedMessage.AcceptsTab = True
        Me.txtEncryptedMessage.BackColor = System.Drawing.Color.White
        Me.txtEncryptedMessage.Location = New System.Drawing.Point(0, -1)
        Me.txtEncryptedMessage.MaxLength = 1000000
        Me.txtEncryptedMessage.Multiline = True
        Me.txtEncryptedMessage.Name = "txtEncryptedMessage"
        Me.txtEncryptedMessage.ReadOnly = True
        Me.txtEncryptedMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEncryptedMessage.Size = New System.Drawing.Size(554, 269)
        Me.txtEncryptedMessage.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(110, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 45)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Send Message"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'ssMainStatus
        '
        Me.ssMainStatus.BackColor = System.Drawing.Color.White
        Me.ssMainStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblMessage, Me.pbProgressIndicator})
        Me.ssMainStatus.Location = New System.Drawing.Point(0, 537)
        Me.ssMainStatus.Name = "ssMainStatus"
        Me.ssMainStatus.Size = New System.Drawing.Size(554, 22)
        Me.ssMainStatus.SizingGrip = False
        Me.ssMainStatus.TabIndex = 5
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(437, 17)
        Me.lblMessage.Spring = True
        Me.lblMessage.Text = "Secret Message- Encrypt"
        '
        'pbProgressIndicator
        '
        Me.pbProgressIndicator.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pbProgressIndicator.Name = "pbProgressIndicator"
        Me.pbProgressIndicator.Size = New System.Drawing.Size(100, 16)
        Me.pbProgressIndicator.Step = 1
        Me.pbProgressIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Slow
        '
        Me.Slow.Interval = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(79, 282)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(89, 20)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.Visible = False
        '
        'btnEnterPassword
        '
        Me.btnEnterPassword.BackColor = System.Drawing.Color.White
        Me.btnEnterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterPassword.Location = New System.Drawing.Point(174, 282)
        Me.btnEnterPassword.Name = "btnEnterPassword"
        Me.btnEnterPassword.Size = New System.Drawing.Size(66, 23)
        Me.btnEnterPassword.TabIndex = 13
        Me.btnEnterPassword.Text = "Activate"
        Me.btnEnterPassword.UseVisualStyleBackColor = False
        Me.btnEnterPassword.Visible = False
        '
        'chkSlowEnable
        '
        Me.chkSlowEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSlowEnable.Location = New System.Drawing.Point(339, 274)
        Me.chkSlowEnable.Name = "chkSlowEnable"
        Me.chkSlowEnable.Size = New System.Drawing.Size(104, 43)
        Me.chkSlowEnable.TabIndex = 14
        Me.chkSlowEnable.Text = "Enable Slow Motion"
        Me.chkSlowEnable.UseVisualStyleBackColor = True
        '
        'gbSlow
        '
        Me.gbSlow.BackColor = System.Drawing.Color.White
        Me.gbSlow.BackgroundImage = CType(resources.GetObject("gbSlow.BackgroundImage"), System.Drawing.Image)
        Me.gbSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbSlow.Controls.Add(Me.rdSlow)
        Me.gbSlow.Controls.Add(Me.rdNormal)
        Me.gbSlow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSlow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSlow.ForeColor = System.Drawing.Color.Black
        Me.gbSlow.Location = New System.Drawing.Point(449, 276)
        Me.gbSlow.Name = "gbSlow"
        Me.gbSlow.Size = New System.Drawing.Size(93, 82)
        Me.gbSlow.TabIndex = 15
        Me.gbSlow.TabStop = False
        Me.gbSlow.Text = "Slow Motion Speed"
        Me.gbSlow.Visible = False
        '
        'rdSlow
        '
        Me.rdSlow.AutoSize = True
        Me.rdSlow.BackColor = System.Drawing.Color.Transparent
        Me.rdSlow.Location = New System.Drawing.Point(6, 34)
        Me.rdSlow.Name = "rdSlow"
        Me.rdSlow.Size = New System.Drawing.Size(52, 17)
        Me.rdSlow.TabIndex = 10
        Me.rdSlow.Text = "Slow"
        Me.rdSlow.UseVisualStyleBackColor = False
        '
        'rdNormal
        '
        Me.rdNormal.AutoSize = True
        Me.rdNormal.BackColor = System.Drawing.Color.Transparent
        Me.rdNormal.Checked = True
        Me.rdNormal.Location = New System.Drawing.Point(6, 57)
        Me.rdNormal.Name = "rdNormal"
        Me.rdNormal.Size = New System.Drawing.Size(64, 17)
        Me.rdNormal.TabIndex = 9
        Me.rdNormal.TabStop = True
        Me.rdNormal.Text = "Normal"
        Me.rdNormal.UseVisualStyleBackColor = False
        '
        'chkSlowDisable
        '
        Me.chkSlowDisable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSlowDisable.Location = New System.Drawing.Point(339, 274)
        Me.chkSlowDisable.Name = "chkSlowDisable"
        Me.chkSlowDisable.Size = New System.Drawing.Size(104, 40)
        Me.chkSlowDisable.TabIndex = 16
        Me.chkSlowDisable.Text = "Disable Slow Motion"
        Me.chkSlowDisable.UseVisualStyleBackColor = True
        Me.chkSlowDisable.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(12, 276)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(67, 34)
        Me.lblPassword.TabIndex = 17
        Me.lblPassword.Text = "Enter Password"
        Me.lblPassword.Visible = False
        '
        'frmEncyrptMain
        '
        Me.AcceptButton = Me.btnEncrypt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(554, 559)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.chkSlowDisable)
        Me.Controls.Add(Me.gbSlow)
        Me.Controls.Add(Me.chkSlowEnable)
        Me.Controls.Add(Me.btnEnterPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.ssMainStatus)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtEncryptedMessage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtMessageToEncrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEncyrptMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secret Message- Send Message"
        Me.ssMainStatus.ResumeLayout(False)
        Me.ssMainStatus.PerformLayout()
        Me.gbSlow.ResumeLayout(False)
        Me.gbSlow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents txtMessageToEncrypt As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtEncryptedMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents ssMainStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents lblMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pbProgressIndicator As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Slow As System.Windows.Forms.Timer
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnEnterPassword As System.Windows.Forms.Button
    Friend WithEvents chkSlowEnable As System.Windows.Forms.CheckBox
    Friend WithEvents gbSlow As System.Windows.Forms.GroupBox
    Friend WithEvents rdNormal As System.Windows.Forms.RadioButton
    Friend WithEvents chkSlowDisable As System.Windows.Forms.CheckBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents rdSlow As System.Windows.Forms.RadioButton

End Class
