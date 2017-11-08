<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditContact))
        Me.lblEditContact = New System.Windows.Forms.Label()
        Me.lstChooseContact = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAssociation = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblAssociation = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEditContact
        '
        Me.lblEditContact.AutoSize = True
        Me.lblEditContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditContact.Location = New System.Drawing.Point(328, 44)
        Me.lblEditContact.Name = "lblEditContact"
        Me.lblEditContact.Size = New System.Drawing.Size(129, 25)
        Me.lblEditContact.TabIndex = 0
        Me.lblEditContact.Text = "Edit Contact"
        '
        'lstChooseContact
        '
        Me.lstChooseContact.FormattingEnabled = True
        Me.lstChooseContact.Location = New System.Drawing.Point(12, 96)
        Me.lstChooseContact.Name = "lstChooseContact"
        Me.lstChooseContact.Size = New System.Drawing.Size(226, 303)
        Me.lstChooseContact.TabIndex = 16
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(318, 323)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(340, 20)
        Me.txtMobile.TabIndex = 28
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(318, 279)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(340, 20)
        Me.txtTelephone.TabIndex = 27
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(318, 234)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(340, 20)
        Me.txtEmail.TabIndex = 26
        '
        'txtAssociation
        '
        Me.txtAssociation.Location = New System.Drawing.Point(318, 190)
        Me.txtAssociation.Name = "txtAssociation"
        Me.txtAssociation.Size = New System.Drawing.Size(340, 20)
        Me.txtAssociation.TabIndex = 25
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(318, 147)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(340, 20)
        Me.txtPosition.TabIndex = 24
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(318, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 20)
        Me.txtName.TabIndex = 23
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(248, 326)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(41, 13)
        Me.lblMobile.TabIndex = 22
        Me.lblMobile.Text = "Mobile:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(248, 282)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 21
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(248, 237)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 20
        Me.lblEmail.Text = "Email:"
        '
        'lblAssociation
        '
        Me.lblAssociation.AutoSize = True
        Me.lblAssociation.Location = New System.Drawing.Point(248, 193)
        Me.lblAssociation.Name = "lblAssociation"
        Me.lblAssociation.Size = New System.Drawing.Size(64, 13)
        Me.lblAssociation.TabIndex = 19
        Me.lblAssociation.Text = "Association:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(248, 150)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 18
        Me.lblPosition.Text = "Position:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(248, 107)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(668, 353)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(104, 47)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEditContact
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lstChooseContact)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtTelephone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtAssociation)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.lblTelephone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAssociation)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblEditContact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditContact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEditContact As System.Windows.Forms.Label
    Friend WithEvents lstChooseContact As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtAssociation As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblAssociation As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
