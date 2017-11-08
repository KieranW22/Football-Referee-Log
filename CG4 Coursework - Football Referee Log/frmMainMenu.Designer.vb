<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.btnPersonalDetails = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnViewMatchDetails = New System.Windows.Forms.Button()
        Me.btnAddMatchDetails = New System.Windows.Forms.Button()
        Me.btnEditMatchDetails = New System.Windows.Forms.Button()
        Me.btnDeleteMatchDetails = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grpMatchDetails = New System.Windows.Forms.GroupBox()
        Me.grpMisconductReports = New System.Windows.Forms.GroupBox()
        Me.btnEmailReport = New System.Windows.Forms.Button()
        Me.btnDeleteReport = New System.Windows.Forms.Button()
        Me.btnEditReport = New System.Windows.Forms.Button()
        Me.btnAddReport = New System.Windows.Forms.Button()
        Me.btnViewReports = New System.Windows.Forms.Button()
        Me.grpExpenses = New System.Windows.Forms.GroupBox()
        Me.btnDeleteExpense = New System.Windows.Forms.Button()
        Me.btnEditExpense = New System.Windows.Forms.Button()
        Me.btnAddExpense = New System.Windows.Forms.Button()
        Me.btnViewExpenses = New System.Windows.Forms.Button()
        Me.grpAddressBook = New System.Windows.Forms.GroupBox()
        Me.btnDeleteContact = New System.Windows.Forms.Button()
        Me.btnEditContact = New System.Windows.Forms.Button()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.btnAddressBook = New System.Windows.Forms.Button()
        Me.grpPersonalDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMatchDetails.SuspendLayout()
        Me.grpMisconductReports.SuspendLayout()
        Me.grpExpenses.SuspendLayout()
        Me.grpAddressBook.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.Controls.Add(Me.btnPersonalDetails)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(46, 158)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(137, 274)
        Me.grpPersonalDetails.TabIndex = 0
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal Details"
        '
        'btnPersonalDetails
        '
        Me.btnPersonalDetails.Location = New System.Drawing.Point(6, 115)
        Me.btnPersonalDetails.Name = "btnPersonalDetails"
        Me.btnPersonalDetails.Size = New System.Drawing.Size(125, 45)
        Me.btnPersonalDetails.TabIndex = 3
        Me.btnPersonalDetails.Text = "Personal Details"
        Me.btnPersonalDetails.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(231, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(338, 39)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Football Referee Log"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(69, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnViewMatchDetails
        '
        Me.btnViewMatchDetails.Location = New System.Drawing.Point(6, 40)
        Me.btnViewMatchDetails.Name = "btnViewMatchDetails"
        Me.btnViewMatchDetails.Size = New System.Drawing.Size(125, 45)
        Me.btnViewMatchDetails.TabIndex = 4
        Me.btnViewMatchDetails.Text = "View Match Details"
        Me.btnViewMatchDetails.UseVisualStyleBackColor = True
        '
        'btnAddMatchDetails
        '
        Me.btnAddMatchDetails.Location = New System.Drawing.Point(6, 91)
        Me.btnAddMatchDetails.Name = "btnAddMatchDetails"
        Me.btnAddMatchDetails.Size = New System.Drawing.Size(125, 45)
        Me.btnAddMatchDetails.TabIndex = 5
        Me.btnAddMatchDetails.Text = "Add Match Details"
        Me.btnAddMatchDetails.UseVisualStyleBackColor = True
        '
        'btnEditMatchDetails
        '
        Me.btnEditMatchDetails.Location = New System.Drawing.Point(6, 142)
        Me.btnEditMatchDetails.Name = "btnEditMatchDetails"
        Me.btnEditMatchDetails.Size = New System.Drawing.Size(125, 45)
        Me.btnEditMatchDetails.TabIndex = 6
        Me.btnEditMatchDetails.Text = "Edit Match Details"
        Me.btnEditMatchDetails.UseVisualStyleBackColor = True
        '
        'btnDeleteMatchDetails
        '
        Me.btnDeleteMatchDetails.Location = New System.Drawing.Point(6, 193)
        Me.btnDeleteMatchDetails.Name = "btnDeleteMatchDetails"
        Me.btnDeleteMatchDetails.Size = New System.Drawing.Size(125, 45)
        Me.btnDeleteMatchDetails.TabIndex = 7
        Me.btnDeleteMatchDetails.Text = "Delete Match Details"
        Me.btnDeleteMatchDetails.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(618, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(114, 95)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'grpMatchDetails
        '
        Me.grpMatchDetails.Controls.Add(Me.btnViewMatchDetails)
        Me.grpMatchDetails.Controls.Add(Me.btnDeleteMatchDetails)
        Me.grpMatchDetails.Controls.Add(Me.btnAddMatchDetails)
        Me.grpMatchDetails.Controls.Add(Me.btnEditMatchDetails)
        Me.grpMatchDetails.Location = New System.Drawing.Point(189, 158)
        Me.grpMatchDetails.Name = "grpMatchDetails"
        Me.grpMatchDetails.Size = New System.Drawing.Size(137, 274)
        Me.grpMatchDetails.TabIndex = 1
        Me.grpMatchDetails.TabStop = False
        Me.grpMatchDetails.Text = "Match Details"
        '
        'grpMisconductReports
        '
        Me.grpMisconductReports.Controls.Add(Me.btnEmailReport)
        Me.grpMisconductReports.Controls.Add(Me.btnDeleteReport)
        Me.grpMisconductReports.Controls.Add(Me.btnEditReport)
        Me.grpMisconductReports.Controls.Add(Me.btnAddReport)
        Me.grpMisconductReports.Controls.Add(Me.btnViewReports)
        Me.grpMisconductReports.Location = New System.Drawing.Point(332, 158)
        Me.grpMisconductReports.Name = "grpMisconductReports"
        Me.grpMisconductReports.Size = New System.Drawing.Size(137, 274)
        Me.grpMisconductReports.TabIndex = 4
        Me.grpMisconductReports.TabStop = False
        Me.grpMisconductReports.Text = "Misconduct Reports"
        '
        'btnEmailReport
        '
        Me.btnEmailReport.Location = New System.Drawing.Point(6, 223)
        Me.btnEmailReport.Name = "btnEmailReport"
        Me.btnEmailReport.Size = New System.Drawing.Size(125, 45)
        Me.btnEmailReport.TabIndex = 12
        Me.btnEmailReport.Text = "Email Report"
        Me.btnEmailReport.UseVisualStyleBackColor = True
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Location = New System.Drawing.Point(6, 172)
        Me.btnDeleteReport.Name = "btnDeleteReport"
        Me.btnDeleteReport.Size = New System.Drawing.Size(125, 45)
        Me.btnDeleteReport.TabIndex = 11
        Me.btnDeleteReport.Text = "Delete Report"
        Me.btnDeleteReport.UseVisualStyleBackColor = True
        '
        'btnEditReport
        '
        Me.btnEditReport.Location = New System.Drawing.Point(6, 121)
        Me.btnEditReport.Name = "btnEditReport"
        Me.btnEditReport.Size = New System.Drawing.Size(125, 45)
        Me.btnEditReport.TabIndex = 10
        Me.btnEditReport.Text = "Edit Report"
        Me.btnEditReport.UseVisualStyleBackColor = True
        '
        'btnAddReport
        '
        Me.btnAddReport.Location = New System.Drawing.Point(6, 70)
        Me.btnAddReport.Name = "btnAddReport"
        Me.btnAddReport.Size = New System.Drawing.Size(125, 45)
        Me.btnAddReport.TabIndex = 9
        Me.btnAddReport.Text = "Add Report"
        Me.btnAddReport.UseVisualStyleBackColor = True
        '
        'btnViewReports
        '
        Me.btnViewReports.Location = New System.Drawing.Point(6, 19)
        Me.btnViewReports.Name = "btnViewReports"
        Me.btnViewReports.Size = New System.Drawing.Size(125, 45)
        Me.btnViewReports.TabIndex = 8
        Me.btnViewReports.Text = "View Reports"
        Me.btnViewReports.UseVisualStyleBackColor = True
        '
        'grpExpenses
        '
        Me.grpExpenses.Controls.Add(Me.btnDeleteExpense)
        Me.grpExpenses.Controls.Add(Me.btnEditExpense)
        Me.grpExpenses.Controls.Add(Me.btnAddExpense)
        Me.grpExpenses.Controls.Add(Me.btnViewExpenses)
        Me.grpExpenses.Location = New System.Drawing.Point(475, 158)
        Me.grpExpenses.Name = "grpExpenses"
        Me.grpExpenses.Size = New System.Drawing.Size(137, 274)
        Me.grpExpenses.TabIndex = 5
        Me.grpExpenses.TabStop = False
        Me.grpExpenses.Text = "Expenses"
        '
        'btnDeleteExpense
        '
        Me.btnDeleteExpense.Location = New System.Drawing.Point(6, 193)
        Me.btnDeleteExpense.Name = "btnDeleteExpense"
        Me.btnDeleteExpense.Size = New System.Drawing.Size(125, 45)
        Me.btnDeleteExpense.TabIndex = 11
        Me.btnDeleteExpense.Text = "Delete Expense"
        Me.btnDeleteExpense.UseVisualStyleBackColor = True
        '
        'btnEditExpense
        '
        Me.btnEditExpense.Location = New System.Drawing.Point(6, 142)
        Me.btnEditExpense.Name = "btnEditExpense"
        Me.btnEditExpense.Size = New System.Drawing.Size(125, 45)
        Me.btnEditExpense.TabIndex = 10
        Me.btnEditExpense.Text = "Edit Expense"
        Me.btnEditExpense.UseVisualStyleBackColor = True
        '
        'btnAddExpense
        '
        Me.btnAddExpense.Location = New System.Drawing.Point(6, 91)
        Me.btnAddExpense.Name = "btnAddExpense"
        Me.btnAddExpense.Size = New System.Drawing.Size(125, 45)
        Me.btnAddExpense.TabIndex = 9
        Me.btnAddExpense.Text = "Add Expense"
        Me.btnAddExpense.UseVisualStyleBackColor = True
        '
        'btnViewExpenses
        '
        Me.btnViewExpenses.Location = New System.Drawing.Point(6, 40)
        Me.btnViewExpenses.Name = "btnViewExpenses"
        Me.btnViewExpenses.Size = New System.Drawing.Size(125, 45)
        Me.btnViewExpenses.TabIndex = 8
        Me.btnViewExpenses.Text = "View Expenses"
        Me.btnViewExpenses.UseVisualStyleBackColor = True
        '
        'grpAddressBook
        '
        Me.grpAddressBook.Controls.Add(Me.btnDeleteContact)
        Me.grpAddressBook.Controls.Add(Me.btnEditContact)
        Me.grpAddressBook.Controls.Add(Me.btnAddContact)
        Me.grpAddressBook.Controls.Add(Me.btnAddressBook)
        Me.grpAddressBook.Location = New System.Drawing.Point(618, 158)
        Me.grpAddressBook.Name = "grpAddressBook"
        Me.grpAddressBook.Size = New System.Drawing.Size(137, 274)
        Me.grpAddressBook.TabIndex = 1
        Me.grpAddressBook.TabStop = False
        Me.grpAddressBook.Text = "Address Book"
        '
        'btnDeleteContact
        '
        Me.btnDeleteContact.Location = New System.Drawing.Point(6, 193)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(125, 45)
        Me.btnDeleteContact.TabIndex = 15
        Me.btnDeleteContact.Text = "Delete Contact"
        Me.btnDeleteContact.UseVisualStyleBackColor = True
        '
        'btnEditContact
        '
        Me.btnEditContact.Location = New System.Drawing.Point(6, 142)
        Me.btnEditContact.Name = "btnEditContact"
        Me.btnEditContact.Size = New System.Drawing.Size(125, 45)
        Me.btnEditContact.TabIndex = 14
        Me.btnEditContact.Text = "Edit Contact"
        Me.btnEditContact.UseVisualStyleBackColor = True
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(6, 91)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(125, 45)
        Me.btnAddContact.TabIndex = 13
        Me.btnAddContact.Text = "Add Contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'btnAddressBook
        '
        Me.btnAddressBook.Location = New System.Drawing.Point(6, 40)
        Me.btnAddressBook.Name = "btnAddressBook"
        Me.btnAddressBook.Size = New System.Drawing.Size(125, 45)
        Me.btnAddressBook.TabIndex = 12
        Me.btnAddressBook.Text = "Address Book"
        Me.btnAddressBook.UseVisualStyleBackColor = True
        '
        'frmMainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpAddressBook)
        Me.Controls.Add(Me.grpExpenses)
        Me.Controls.Add(Me.grpMisconductReports)
        Me.Controls.Add(Me.grpMatchDetails)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpPersonalDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.grpPersonalDetails.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMatchDetails.ResumeLayout(False)
        Me.grpMisconductReports.ResumeLayout(False)
        Me.grpExpenses.ResumeLayout(False)
        Me.grpAddressBook.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPersonalDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnDeleteMatchDetails As System.Windows.Forms.Button
    Friend WithEvents btnPersonalDetails As System.Windows.Forms.Button
    Friend WithEvents btnEditMatchDetails As System.Windows.Forms.Button
    Friend WithEvents btnViewMatchDetails As System.Windows.Forms.Button
    Friend WithEvents btnAddMatchDetails As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents grpMatchDetails As System.Windows.Forms.GroupBox
    Friend WithEvents grpMisconductReports As System.Windows.Forms.GroupBox
    Friend WithEvents grpExpenses As System.Windows.Forms.GroupBox
    Friend WithEvents grpAddressBook As System.Windows.Forms.GroupBox
    Friend WithEvents btnEmailReport As System.Windows.Forms.Button
    Friend WithEvents btnDeleteReport As System.Windows.Forms.Button
    Friend WithEvents btnEditReport As System.Windows.Forms.Button
    Friend WithEvents btnAddReport As System.Windows.Forms.Button
    Friend WithEvents btnViewReports As System.Windows.Forms.Button
    Friend WithEvents btnDeleteExpense As System.Windows.Forms.Button
    Friend WithEvents btnEditExpense As System.Windows.Forms.Button
    Friend WithEvents btnAddExpense As System.Windows.Forms.Button
    Friend WithEvents btnViewExpenses As System.Windows.Forms.Button
    Friend WithEvents btnDeleteContact As System.Windows.Forms.Button
    Friend WithEvents btnEditContact As System.Windows.Forms.Button
    Friend WithEvents btnAddContact As System.Windows.Forms.Button
    Friend WithEvents btnAddressBook As System.Windows.Forms.Button
End Class
