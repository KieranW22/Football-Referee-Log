<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteReport))
        Me.lblDeleteReport = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblChooseReport = New System.Windows.Forms.Label()
        Me.lstChooseReport = New System.Windows.Forms.ListBox()
        Me.btnDeleteReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDeleteReport
        '
        Me.lblDeleteReport.AutoSize = True
        Me.lblDeleteReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteReport.Location = New System.Drawing.Point(320, 32)
        Me.lblDeleteReport.Name = "lblDeleteReport"
        Me.lblDeleteReport.Size = New System.Drawing.Size(144, 25)
        Me.lblDeleteReport.TabIndex = 0
        Me.lblDeleteReport.Text = "Delete Report"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 95
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblChooseReport
        '
        Me.lblChooseReport.AutoSize = True
        Me.lblChooseReport.Location = New System.Drawing.Point(12, 115)
        Me.lblChooseReport.Name = "lblChooseReport"
        Me.lblChooseReport.Size = New System.Drawing.Size(115, 13)
        Me.lblChooseReport.TabIndex = 94
        Me.lblChooseReport.Text = "Select a Report below:"
        '
        'lstChooseReport
        '
        Me.lstChooseReport.FormattingEnabled = True
        Me.lstChooseReport.Location = New System.Drawing.Point(12, 131)
        Me.lstChooseReport.Name = "lstChooseReport"
        Me.lstChooseReport.Size = New System.Drawing.Size(593, 264)
        Me.lstChooseReport.TabIndex = 93
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Location = New System.Drawing.Point(621, 216)
        Me.btnDeleteReport.Name = "btnDeleteReport"
        Me.btnDeleteReport.Size = New System.Drawing.Size(151, 61)
        Me.btnDeleteReport.TabIndex = 96
        Me.btnDeleteReport.Text = "Delete Report"
        Me.btnDeleteReport.UseVisualStyleBackColor = True
        '
        'frmDeleteReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDeleteReport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChooseReport)
        Me.Controls.Add(Me.lstChooseReport)
        Me.Controls.Add(Me.lblDeleteReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeleteReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDeleteReport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblChooseReport As System.Windows.Forms.Label
    Friend WithEvents lstChooseReport As System.Windows.Forms.ListBox
    Friend WithEvents btnDeleteReport As System.Windows.Forms.Button
End Class
