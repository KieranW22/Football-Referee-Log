<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewExpenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewExpenses))
        Me.lblViewExpenses = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblChooseExpense = New System.Windows.Forms.Label()
        Me.lstChooseExpense = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblViewExpenses
        '
        Me.lblViewExpenses.AutoSize = True
        Me.lblViewExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewExpenses.Location = New System.Drawing.Point(313, 51)
        Me.lblViewExpenses.Name = "lblViewExpenses"
        Me.lblViewExpenses.Size = New System.Drawing.Size(159, 25)
        Me.lblViewExpenses.TabIndex = 0
        Me.lblViewExpenses.Text = "View Expenses"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblChooseExpense
        '
        Me.lblChooseExpense.AutoSize = True
        Me.lblChooseExpense.Location = New System.Drawing.Point(9, 120)
        Me.lblChooseExpense.Name = "lblChooseExpense"
        Me.lblChooseExpense.Size = New System.Drawing.Size(130, 13)
        Me.lblChooseExpense.TabIndex = 49
        Me.lblChooseExpense.Text = "Select an Expense below:"
        '
        'lstChooseExpense
        '
        Me.lstChooseExpense.FormattingEnabled = True
        Me.lstChooseExpense.Location = New System.Drawing.Point(12, 136)
        Me.lstChooseExpense.Name = "lstChooseExpense"
        Me.lstChooseExpense.Size = New System.Drawing.Size(120, 264)
        Me.lstChooseExpense.TabIndex = 48
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(231, 165)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 50
        Me.lblTitle.Text = "Title:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(231, 194)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 51
        Me.lblDescription.Text = "Description:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(231, 271)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(46, 13)
        Me.lblAmount.TabIndex = 52
        Me.lblAmount.Text = "Amount:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(231, 303)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 53
        Me.lblDate.Text = "Date:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(303, 162)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(333, 20)
        Me.txtTitle.TabIndex = 55
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(303, 194)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(333, 60)
        Me.txtDescription.TabIndex = 56
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(303, 268)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(140, 20)
        Me.txtAmount.TabIndex = 57
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(303, 300)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(140, 20)
        Me.txtDate.TabIndex = 58
        '
        'frmViewExpenses
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblChooseExpense)
        Me.Controls.Add(Me.lstChooseExpense)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblViewExpenses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewExpenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblViewExpenses As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblChooseExpense As System.Windows.Forms.Label
    Friend WithEvents lstChooseExpense As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
End Class
