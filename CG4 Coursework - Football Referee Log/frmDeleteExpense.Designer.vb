<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteExpense
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteExpense))
        Me.lblDeleteExpense = New System.Windows.Forms.Label()
        Me.btnDeleteExpense = New System.Windows.Forms.Button()
        Me.lblChooseExpense = New System.Windows.Forms.Label()
        Me.lstChooseExpense = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDeleteExpense
        '
        Me.lblDeleteExpense.AutoSize = True
        Me.lblDeleteExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteExpense.Location = New System.Drawing.Point(318, 70)
        Me.lblDeleteExpense.Name = "lblDeleteExpense"
        Me.lblDeleteExpense.Size = New System.Drawing.Size(164, 25)
        Me.lblDeleteExpense.TabIndex = 0
        Me.lblDeleteExpense.Text = "Delete Expense"
        '
        'btnDeleteExpense
        '
        Me.btnDeleteExpense.Location = New System.Drawing.Point(621, 259)
        Me.btnDeleteExpense.Name = "btnDeleteExpense"
        Me.btnDeleteExpense.Size = New System.Drawing.Size(151, 61)
        Me.btnDeleteExpense.TabIndex = 99
        Me.btnDeleteExpense.Text = "Delete Expense"
        Me.btnDeleteExpense.UseVisualStyleBackColor = True
        '
        'lblChooseExpense
        '
        Me.lblChooseExpense.AutoSize = True
        Me.lblChooseExpense.Location = New System.Drawing.Point(12, 158)
        Me.lblChooseExpense.Name = "lblChooseExpense"
        Me.lblChooseExpense.Size = New System.Drawing.Size(130, 13)
        Me.lblChooseExpense.TabIndex = 98
        Me.lblChooseExpense.Text = "Select an Expense below:"
        '
        'lstChooseExpense
        '
        Me.lstChooseExpense.FormattingEnabled = True
        Me.lstChooseExpense.Location = New System.Drawing.Point(12, 174)
        Me.lstChooseExpense.Name = "lstChooseExpense"
        Me.lstChooseExpense.Size = New System.Drawing.Size(593, 264)
        Me.lstChooseExpense.TabIndex = 97
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 100
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmDeleteExpense
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeleteExpense)
        Me.Controls.Add(Me.lblChooseExpense)
        Me.Controls.Add(Me.lstChooseExpense)
        Me.Controls.Add(Me.lblDeleteExpense)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeleteExpense"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDeleteExpense As System.Windows.Forms.Label
    Friend WithEvents btnDeleteExpense As System.Windows.Forms.Button
    Friend WithEvents lblChooseExpense As System.Windows.Forms.Label
    Friend WithEvents lstChooseExpense As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
