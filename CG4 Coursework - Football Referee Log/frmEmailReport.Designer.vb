<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmailReport))
        Me.lblEmailReport = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lblChooseReport = New System.Windows.Forms.Label()
        Me.lstChooseReport = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.radOutlook = New System.Windows.Forms.RadioButton()
        Me.grpEmail = New System.Windows.Forms.GroupBox()
        Me.radGmail = New System.Windows.Forms.RadioButton()
        Me.rad365 = New System.Windows.Forms.RadioButton()
        Me.grpEmail.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEmailReport
        '
        Me.lblEmailReport.AutoSize = True
        Me.lblEmailReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailReport.Location = New System.Drawing.Point(325, 36)
        Me.lblEmailReport.Name = "lblEmailReport"
        Me.lblEmailReport.Size = New System.Drawing.Size(135, 25)
        Me.lblEmailReport.TabIndex = 0
        Me.lblEmailReport.Text = "Email Report"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 96
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(354, 117)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 97
        Me.lblTo.Text = "To:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(354, 144)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 13)
        Me.lblSubject.TabIndex = 98
        Me.lblSubject.Text = "Subject:"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(354, 173)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblMessage.TabIndex = 99
        Me.lblMessage.Text = "Message:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Location = New System.Drawing.Point(354, 89)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 100
        Me.lblFrom.Text = "From:"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(383, 114)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(389, 20)
        Me.txtTo.TabIndex = 103
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(406, 141)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(366, 20)
        Me.txtSubject.TabIndex = 104
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(413, 170)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(359, 203)
        Me.txtMessage.TabIndex = 105
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(393, 86)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(379, 20)
        Me.txtFrom.TabIndex = 106
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(520, 382)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lblChooseReport
        '
        Me.lblChooseReport.AutoSize = True
        Me.lblChooseReport.Location = New System.Drawing.Point(9, 70)
        Me.lblChooseReport.Name = "lblChooseReport"
        Me.lblChooseReport.Size = New System.Drawing.Size(115, 13)
        Me.lblChooseReport.TabIndex = 111
        Me.lblChooseReport.Text = "Select a Report below:"
        '
        'lstChooseReport
        '
        Me.lstChooseReport.FormattingEnabled = True
        Me.lstChooseReport.Location = New System.Drawing.Point(12, 86)
        Me.lstChooseReport.Name = "lstChooseReport"
        Me.lstChooseReport.Size = New System.Drawing.Size(319, 225)
        Me.lstChooseReport.TabIndex = 110
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(601, 382)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 112
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(9, 319)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(38, 13)
        Me.lblLogin.TabIndex = 113
        Me.lblLogin.Text = "Login"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 341)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 114
        Me.lblUsername.Text = "Username:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 363)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 115
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(73, 338)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 20)
        Me.txtUsername.TabIndex = 117
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(73, 360)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(258, 20)
        Me.txtPassword.TabIndex = 118
        '
        'radOutlook
        '
        Me.radOutlook.AutoSize = True
        Me.radOutlook.Location = New System.Drawing.Point(6, 8)
        Me.radOutlook.Name = "radOutlook"
        Me.radOutlook.Size = New System.Drawing.Size(62, 17)
        Me.radOutlook.TabIndex = 119
        Me.radOutlook.TabStop = True
        Me.radOutlook.Text = "Outlook"
        Me.radOutlook.UseVisualStyleBackColor = True
        '
        'grpEmail
        '
        Me.grpEmail.Controls.Add(Me.rad365)
        Me.grpEmail.Controls.Add(Me.radGmail)
        Me.grpEmail.Controls.Add(Me.radOutlook)
        Me.grpEmail.Location = New System.Drawing.Point(73, 377)
        Me.grpEmail.Name = "grpEmail"
        Me.grpEmail.Size = New System.Drawing.Size(203, 28)
        Me.grpEmail.TabIndex = 120
        Me.grpEmail.TabStop = False
        '
        'radGmail
        '
        Me.radGmail.AutoSize = True
        Me.radGmail.Location = New System.Drawing.Point(74, 8)
        Me.radGmail.Name = "radGmail"
        Me.radGmail.Size = New System.Drawing.Size(51, 17)
        Me.radGmail.TabIndex = 120
        Me.radGmail.TabStop = True
        Me.radGmail.Text = "Gmail"
        Me.radGmail.UseVisualStyleBackColor = True
        '
        'rad365
        '
        Me.rad365.AutoSize = True
        Me.rad365.Location = New System.Drawing.Point(131, 8)
        Me.rad365.Name = "rad365"
        Me.rad365.Size = New System.Drawing.Size(71, 17)
        Me.rad365.TabIndex = 121
        Me.rad365.TabStop = True
        Me.rad365.Text = "Office365"
        Me.rad365.UseVisualStyleBackColor = True
        '
        'frmEmailReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblChooseReport)
        Me.Controls.Add(Me.lstChooseReport)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lblFrom)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblEmailReport)
        Me.Controls.Add(Me.grpEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmailReport"
        Me.grpEmail.ResumeLayout(False)
        Me.grpEmail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmailReport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTo As System.Windows.Forms.Label
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblFrom As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents lblChooseReport As System.Windows.Forms.Label
    Friend WithEvents lstChooseReport As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents radOutlook As System.Windows.Forms.RadioButton
    Friend WithEvents grpEmail As System.Windows.Forms.GroupBox
    Friend WithEvents radGmail As System.Windows.Forms.RadioButton
    Friend WithEvents rad365 As System.Windows.Forms.RadioButton
End Class
