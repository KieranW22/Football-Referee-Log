<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalDetails))
        Me.lblFANID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblDateofBirth = New System.Windows.Forms.Label()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkChanges = New System.Windows.Forms.CheckBox()
        Me.txtCountyFA = New System.Windows.Forms.TextBox()
        Me.lblCountyFA = New System.Windows.Forms.Label()
        Me.txtAffiliationNo = New System.Windows.Forms.TextBox()
        Me.chkPromotion = New System.Windows.Forms.CheckBox()
        Me.grpLevel = New System.Windows.Forms.GroupBox()
        Me.rad7 = New System.Windows.Forms.RadioButton()
        Me.rad5 = New System.Windows.Forms.RadioButton()
        Me.rad6 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad4 = New System.Windows.Forms.RadioButton()
        Me.lblLevelNos = New System.Windows.Forms.Label()
        Me.lblAffiliationNo = New System.Windows.Forms.Label()
        Me.lblPromotion = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.grpGender = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.mskDateofBirth = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtTelephoneNo = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtFANID = New System.Windows.Forms.TextBox()
        Me.lblEmailAddress = New System.Windows.Forms.Label()
        Me.lblMobileNumber = New System.Windows.Forms.Label()
        Me.lblTelephoneNumber = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPersonalDetails = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rad8 = New System.Windows.Forms.RadioButton()
        Me.rad9 = New System.Windows.Forms.RadioButton()
        Me.rad10 = New System.Windows.Forms.RadioButton()
        Me.grpPersonalDetails.SuspendLayout()
        Me.grpLevel.SuspendLayout()
        Me.grpGender.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFANID
        '
        Me.lblFANID.AutoSize = True
        Me.lblFANID.Location = New System.Drawing.Point(62, 16)
        Me.lblFANID.Name = "lblFANID"
        Me.lblFANID.Size = New System.Drawing.Size(45, 13)
        Me.lblFANID.TabIndex = 1
        Me.lblFANID.Text = "FAN ID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(62, 137)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(45, 13)
        Me.lblGender.TabIndex = 7
        Me.lblGender.Text = "Gender:"
        '
        'lblDateofBirth
        '
        Me.lblDateofBirth.AutoSize = True
        Me.lblDateofBirth.Location = New System.Drawing.Point(38, 92)
        Me.lblDateofBirth.Name = "lblDateofBirth"
        Me.lblDateofBirth.Size = New System.Drawing.Size(69, 13)
        Me.lblDateofBirth.TabIndex = 5
        Me.lblDateofBirth.Text = "Date of Birth:"
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.Controls.Add(Me.btnSave)
        Me.grpPersonalDetails.Controls.Add(Me.chkChanges)
        Me.grpPersonalDetails.Controls.Add(Me.txtCountyFA)
        Me.grpPersonalDetails.Controls.Add(Me.lblCountyFA)
        Me.grpPersonalDetails.Controls.Add(Me.txtAffiliationNo)
        Me.grpPersonalDetails.Controls.Add(Me.chkPromotion)
        Me.grpPersonalDetails.Controls.Add(Me.grpLevel)
        Me.grpPersonalDetails.Controls.Add(Me.lblAffiliationNo)
        Me.grpPersonalDetails.Controls.Add(Me.lblPromotion)
        Me.grpPersonalDetails.Controls.Add(Me.lblLevel)
        Me.grpPersonalDetails.Controls.Add(Me.grpGender)
        Me.grpPersonalDetails.Controls.Add(Me.mskDateofBirth)
        Me.grpPersonalDetails.Controls.Add(Me.txtEmailAddress)
        Me.grpPersonalDetails.Controls.Add(Me.txtMobileNo)
        Me.grpPersonalDetails.Controls.Add(Me.txtTelephoneNo)
        Me.grpPersonalDetails.Controls.Add(Me.txtAddress)
        Me.grpPersonalDetails.Controls.Add(Me.txtName)
        Me.grpPersonalDetails.Controls.Add(Me.txtFANID)
        Me.grpPersonalDetails.Controls.Add(Me.lblEmailAddress)
        Me.grpPersonalDetails.Controls.Add(Me.lblMobileNumber)
        Me.grpPersonalDetails.Controls.Add(Me.lblTelephoneNumber)
        Me.grpPersonalDetails.Controls.Add(Me.lblAddress)
        Me.grpPersonalDetails.Controls.Add(Me.lblFANID)
        Me.grpPersonalDetails.Controls.Add(Me.lblDateofBirth)
        Me.grpPersonalDetails.Controls.Add(Me.lblName)
        Me.grpPersonalDetails.Controls.Add(Me.lblGender)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(12, 99)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(764, 333)
        Me.grpPersonalDetails.TabIndex = 6
        Me.grpPersonalDetails.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(607, 266)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(151, 61)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkChanges
        '
        Me.chkChanges.AutoSize = True
        Me.chkChanges.Location = New System.Drawing.Point(609, 243)
        Me.chkChanges.Name = "chkChanges"
        Me.chkChanges.Size = New System.Drawing.Size(151, 17)
        Me.chkChanges.TabIndex = 30
        Me.chkChanges.Text = "Changes have been made"
        Me.chkChanges.UseVisualStyleBackColor = True
        '
        'txtCountyFA
        '
        Me.txtCountyFA.Location = New System.Drawing.Point(458, 50)
        Me.txtCountyFA.Name = "txtCountyFA"
        Me.txtCountyFA.Size = New System.Drawing.Size(130, 20)
        Me.txtCountyFA.TabIndex = 33
        '
        'lblCountyFA
        '
        Me.lblCountyFA.AutoSize = True
        Me.lblCountyFA.Location = New System.Drawing.Point(393, 53)
        Me.lblCountyFA.Name = "lblCountyFA"
        Me.lblCountyFA.Size = New System.Drawing.Size(59, 13)
        Me.lblCountyFA.TabIndex = 32
        Me.lblCountyFA.Text = "County FA:"
        '
        'txtAffiliationNo
        '
        Me.txtAffiliationNo.Location = New System.Drawing.Point(458, 13)
        Me.txtAffiliationNo.Name = "txtAffiliationNo"
        Me.txtAffiliationNo.Size = New System.Drawing.Size(100, 20)
        Me.txtAffiliationNo.TabIndex = 29
        '
        'chkPromotion
        '
        Me.chkPromotion.AutoSize = True
        Me.chkPromotion.Location = New System.Drawing.Point(458, 92)
        Me.chkPromotion.Name = "chkPromotion"
        Me.chkPromotion.Size = New System.Drawing.Size(15, 14)
        Me.chkPromotion.TabIndex = 28
        Me.chkPromotion.UseVisualStyleBackColor = True
        '
        'grpLevel
        '
        Me.grpLevel.Controls.Add(Me.rad10)
        Me.grpLevel.Controls.Add(Me.rad9)
        Me.grpLevel.Controls.Add(Me.rad8)
        Me.grpLevel.Controls.Add(Me.rad7)
        Me.grpLevel.Controls.Add(Me.rad5)
        Me.grpLevel.Controls.Add(Me.rad6)
        Me.grpLevel.Controls.Add(Me.rad1)
        Me.grpLevel.Controls.Add(Me.rad2)
        Me.grpLevel.Controls.Add(Me.rad3)
        Me.grpLevel.Controls.Add(Me.rad4)
        Me.grpLevel.Controls.Add(Me.lblLevelNos)
        Me.grpLevel.Location = New System.Drawing.Point(458, 118)
        Me.grpLevel.Name = "grpLevel"
        Me.grpLevel.Size = New System.Drawing.Size(210, 49)
        Me.grpLevel.TabIndex = 27
        Me.grpLevel.TabStop = False
        '
        'rad7
        '
        Me.rad7.AutoSize = True
        Me.rad7.Location = New System.Drawing.Point(126, 12)
        Me.rad7.Name = "rad7"
        Me.rad7.Size = New System.Drawing.Size(14, 13)
        Me.rad7.TabIndex = 33
        Me.rad7.TabStop = True
        Me.rad7.UseVisualStyleBackColor = True
        '
        'rad5
        '
        Me.rad5.AutoSize = True
        Me.rad5.Location = New System.Drawing.Point(86, 12)
        Me.rad5.Name = "rad5"
        Me.rad5.Size = New System.Drawing.Size(14, 13)
        Me.rad5.TabIndex = 34
        Me.rad5.TabStop = True
        Me.rad5.UseVisualStyleBackColor = True
        '
        'rad6
        '
        Me.rad6.AutoSize = True
        Me.rad6.Location = New System.Drawing.Point(106, 12)
        Me.rad6.Name = "rad6"
        Me.rad6.Size = New System.Drawing.Size(14, 13)
        Me.rad6.TabIndex = 32
        Me.rad6.TabStop = True
        Me.rad6.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(6, 12)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(14, 13)
        Me.rad1.TabIndex = 28
        Me.rad1.TabStop = True
        Me.rad1.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Location = New System.Drawing.Point(26, 12)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(14, 13)
        Me.rad2.TabIndex = 29
        Me.rad2.TabStop = True
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(46, 12)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(14, 13)
        Me.rad3.TabIndex = 30
        Me.rad3.TabStop = True
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad4
        '
        Me.rad4.AutoSize = True
        Me.rad4.Location = New System.Drawing.Point(66, 12)
        Me.rad4.Name = "rad4"
        Me.rad4.Size = New System.Drawing.Size(14, 13)
        Me.rad4.TabIndex = 31
        Me.rad4.TabStop = True
        Me.rad4.UseVisualStyleBackColor = True
        '
        'lblLevelNos
        '
        Me.lblLevelNos.AutoSize = True
        Me.lblLevelNos.Location = New System.Drawing.Point(6, 28)
        Me.lblLevelNos.Name = "lblLevelNos"
        Me.lblLevelNos.Size = New System.Drawing.Size(196, 13)
        Me.lblLevelNos.TabIndex = 24
        Me.lblLevelNos.Text = "1     2    3     4     5    6     7     8     9   10"
        '
        'lblAffiliationNo
        '
        Me.lblAffiliationNo.AutoSize = True
        Me.lblAffiliationNo.Location = New System.Drawing.Point(360, 16)
        Me.lblAffiliationNo.Name = "lblAffiliationNo"
        Me.lblAffiliationNo.Size = New System.Drawing.Size(92, 13)
        Me.lblAffiliationNo.TabIndex = 26
        Me.lblAffiliationNo.Text = "Affiliation Number:"
        '
        'lblPromotion
        '
        Me.lblPromotion.AutoSize = True
        Me.lblPromotion.Location = New System.Drawing.Point(340, 92)
        Me.lblPromotion.Name = "lblPromotion"
        Me.lblPromotion.Size = New System.Drawing.Size(112, 13)
        Me.lblPromotion.TabIndex = 25
        Me.lblPromotion.Text = "Promotion Requested:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(379, 137)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(73, 13)
        Me.lblLevel.TabIndex = 23
        Me.lblLevel.Text = "Current Level:"
        '
        'grpGender
        '
        Me.grpGender.Controls.Add(Me.radFemale)
        Me.grpGender.Controls.Add(Me.radMale)
        Me.grpGender.Location = New System.Drawing.Point(113, 118)
        Me.grpGender.Name = "grpGender"
        Me.grpGender.Size = New System.Drawing.Size(200, 47)
        Me.grpGender.TabIndex = 22
        Me.grpGender.TabStop = False
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(104, 19)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(59, 17)
        Me.radFemale.TabIndex = 9
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(16, 19)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(48, 17)
        Me.radMale.TabIndex = 8
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'mskDateofBirth
        '
        Me.mskDateofBirth.Location = New System.Drawing.Point(113, 89)
        Me.mskDateofBirth.Mask = "00/00/0000"
        Me.mskDateofBirth.Name = "mskDateofBirth"
        Me.mskDateofBirth.Size = New System.Drawing.Size(100, 20)
        Me.mskDateofBirth.TabIndex = 6
        Me.mskDateofBirth.ValidatingType = GetType(Date)
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(113, 298)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtEmailAddress.TabIndex = 17
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(113, 260)
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(142, 20)
        Me.txtMobileNo.TabIndex = 15
        '
        'txtTelephoneNo
        '
        Me.txtTelephoneNo.Location = New System.Drawing.Point(113, 221)
        Me.txtTelephoneNo.Name = "txtTelephoneNo"
        Me.txtTelephoneNo.Size = New System.Drawing.Size(142, 20)
        Me.txtTelephoneNo.TabIndex = 13
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(113, 179)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtAddress.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 50)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 4
        '
        'txtFANID
        '
        Me.txtFANID.Location = New System.Drawing.Point(113, 13)
        Me.txtFANID.Name = "txtFANID"
        Me.txtFANID.Size = New System.Drawing.Size(100, 20)
        Me.txtFANID.TabIndex = 2
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(31, 301)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblEmailAddress.TabIndex = 16
        Me.lblEmailAddress.Text = "Email Address:"
        '
        'lblMobileNumber
        '
        Me.lblMobileNumber.AutoSize = True
        Me.lblMobileNumber.Location = New System.Drawing.Point(26, 263)
        Me.lblMobileNumber.Name = "lblMobileNumber"
        Me.lblMobileNumber.Size = New System.Drawing.Size(81, 13)
        Me.lblMobileNumber.TabIndex = 14
        Me.lblMobileNumber.Text = "Mobile Number:"
        '
        'lblTelephoneNumber
        '
        Me.lblTelephoneNumber.AutoSize = True
        Me.lblTelephoneNumber.Location = New System.Drawing.Point(6, 224)
        Me.lblTelephoneNumber.Name = "lblTelephoneNumber"
        Me.lblTelephoneNumber.Size = New System.Drawing.Size(101, 13)
        Me.lblTelephoneNumber.TabIndex = 12
        Me.lblTelephoneNumber.Text = "Telephone Number:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(59, 182)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "Address:"
        '
        'lblPersonalDetails
        '
        Me.lblPersonalDetails.AutoSize = True
        Me.lblPersonalDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalDetails.Location = New System.Drawing.Point(310, 27)
        Me.lblPersonalDetails.Name = "lblPersonalDetails"
        Me.lblPersonalDetails.Size = New System.Drawing.Size(169, 25)
        Me.lblPersonalDetails.TabIndex = 0
        Me.lblPersonalDetails.Text = "Personal Details"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rad8
        '
        Me.rad8.AutoSize = True
        Me.rad8.Location = New System.Drawing.Point(146, 12)
        Me.rad8.Name = "rad8"
        Me.rad8.Size = New System.Drawing.Size(14, 13)
        Me.rad8.TabIndex = 35
        Me.rad8.TabStop = True
        Me.rad8.UseVisualStyleBackColor = True
        '
        'rad9
        '
        Me.rad9.AutoSize = True
        Me.rad9.Location = New System.Drawing.Point(166, 12)
        Me.rad9.Name = "rad9"
        Me.rad9.Size = New System.Drawing.Size(14, 13)
        Me.rad9.TabIndex = 36
        Me.rad9.TabStop = True
        Me.rad9.UseVisualStyleBackColor = True
        '
        'rad10
        '
        Me.rad10.AutoSize = True
        Me.rad10.Location = New System.Drawing.Point(186, 12)
        Me.rad10.Name = "rad10"
        Me.rad10.Size = New System.Drawing.Size(14, 13)
        Me.rad10.TabIndex = 37
        Me.rad10.TabStop = True
        Me.rad10.UseVisualStyleBackColor = True
        '
        'frmPersonalDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblPersonalDetails)
        Me.Controls.Add(Me.grpPersonalDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersonalDetails"
        Me.ShowIcon = False
        Me.Text = " "
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.grpPersonalDetails.PerformLayout()
        Me.grpLevel.ResumeLayout(False)
        Me.grpLevel.PerformLayout()
        Me.grpGender.ResumeLayout(False)
        Me.grpGender.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFANID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblGender As System.Windows.Forms.Label
    Friend WithEvents lblDateofBirth As System.Windows.Forms.Label
    Friend WithEvents grpPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblPersonalDetails As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpGender As System.Windows.Forms.GroupBox
    Friend WithEvents radFemale As System.Windows.Forms.RadioButton
    Friend WithEvents radMale As System.Windows.Forms.RadioButton
    Friend WithEvents mskDateofBirth As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtFANID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblMobileNumber As System.Windows.Forms.Label
    Friend WithEvents lblTelephoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblAffiliationNo As System.Windows.Forms.Label
    Friend WithEvents lblPromotion As System.Windows.Forms.Label
    Friend WithEvents lblLevelNos As System.Windows.Forms.Label
    Friend WithEvents rad7 As System.Windows.Forms.RadioButton
    Friend WithEvents rad6 As System.Windows.Forms.RadioButton
    Friend WithEvents grpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents rad5 As System.Windows.Forms.RadioButton
    Friend WithEvents rad1 As System.Windows.Forms.RadioButton
    Friend WithEvents rad2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad3 As System.Windows.Forms.RadioButton
    Friend WithEvents rad4 As System.Windows.Forms.RadioButton
    Friend WithEvents chkPromotion As System.Windows.Forms.CheckBox
    Friend WithEvents txtAffiliationNo As System.Windows.Forms.TextBox
    Friend WithEvents chkChanges As System.Windows.Forms.CheckBox
    Friend WithEvents txtCountyFA As System.Windows.Forms.TextBox
    Friend WithEvents lblCountyFA As System.Windows.Forms.Label
    Friend WithEvents rad10 As System.Windows.Forms.RadioButton
    Friend WithEvents rad9 As System.Windows.Forms.RadioButton
    Friend WithEvents rad8 As System.Windows.Forms.RadioButton
End Class
