<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddressBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddressBook))
        Me.lblAddressBook = New System.Windows.Forms.Label()
        Me.lstChooseContact = New System.Windows.Forms.ListBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.lblAssociation = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtAssociation = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAddressBook
        '
        Me.lblAddressBook.AutoSize = True
        Me.lblAddressBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressBook.Location = New System.Drawing.Point(319, 43)
        Me.lblAddressBook.Name = "lblAddressBook"
        Me.lblAddressBook.Size = New System.Drawing.Size(146, 25)
        Me.lblAddressBook.TabIndex = 0
        Me.lblAddressBook.Text = "Address Book"
        '
        'lstChooseContact
        '
        Me.lstChooseContact.FormattingEnabled = True
        Me.lstChooseContact.Location = New System.Drawing.Point(12, 96)
        Me.lstChooseContact.Name = "lstChooseContact"
        Me.lstChooseContact.Size = New System.Drawing.Size(226, 303)
        Me.lstChooseContact.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(265, 119)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(265, 162)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(47, 13)
        Me.lblPosition.TabIndex = 3
        Me.lblPosition.Text = "Position:"
        '
        'lblAssociation
        '
        Me.lblAssociation.AutoSize = True
        Me.lblAssociation.Location = New System.Drawing.Point(265, 205)
        Me.lblAssociation.Name = "lblAssociation"
        Me.lblAssociation.Size = New System.Drawing.Size(64, 13)
        Me.lblAssociation.TabIndex = 4
        Me.lblAssociation.Text = "Association:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(265, 249)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(265, 294)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 6
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Location = New System.Drawing.Point(265, 338)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(41, 13)
        Me.lblMobile.TabIndex = 7
        Me.lblMobile.Text = "Mobile:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(335, 116)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(340, 20)
        Me.txtName.TabIndex = 8
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(335, 159)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(340, 20)
        Me.txtPosition.TabIndex = 9
        '
        'txtAssociation
        '
        Me.txtAssociation.Location = New System.Drawing.Point(335, 202)
        Me.txtAssociation.Name = "txtAssociation"
        Me.txtAssociation.Size = New System.Drawing.Size(340, 20)
        Me.txtAssociation.TabIndex = 10
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(335, 246)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(340, 20)
        Me.txtEmail.TabIndex = 11
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(335, 291)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(340, 20)
        Me.txtTelephone.TabIndex = 12
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(335, 335)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(340, 20)
        Me.txtMobile.TabIndex = 13
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmAddressBook
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
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
        Me.Controls.Add(Me.lblAddressBook)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddressBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddressBook As System.Windows.Forms.Label
    Friend WithEvents lstChooseContact As System.Windows.Forms.ListBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblAssociation As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblTelephone As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents txtAssociation As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
