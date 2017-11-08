<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteMatchDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteMatchDetails))
        Me.lblDeleteMatchDetails = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblChooseMatch = New System.Windows.Forms.Label()
        Me.btnDeleteMatch = New System.Windows.Forms.Button()
        Me.lstChooseMatch = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblDeleteMatchDetails
        '
        Me.lblDeleteMatchDetails.AutoSize = True
        Me.lblDeleteMatchDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteMatchDetails.Location = New System.Drawing.Point(287, 41)
        Me.lblDeleteMatchDetails.Name = "lblDeleteMatchDetails"
        Me.lblDeleteMatchDetails.Size = New System.Drawing.Size(211, 25)
        Me.lblDeleteMatchDetails.TabIndex = 0
        Me.lblDeleteMatchDetails.Text = "Delete Match Details"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblChooseMatch
        '
        Me.lblChooseMatch.AutoSize = True
        Me.lblChooseMatch.Location = New System.Drawing.Point(12, 102)
        Me.lblChooseMatch.Name = "lblChooseMatch"
        Me.lblChooseMatch.Size = New System.Drawing.Size(113, 13)
        Me.lblChooseMatch.TabIndex = 12
        Me.lblChooseMatch.Text = "Select a Match below:"
        '
        'btnDeleteMatch
        '
        Me.btnDeleteMatch.Location = New System.Drawing.Point(614, 214)
        Me.btnDeleteMatch.Name = "btnDeleteMatch"
        Me.btnDeleteMatch.Size = New System.Drawing.Size(151, 61)
        Me.btnDeleteMatch.TabIndex = 47
        Me.btnDeleteMatch.Text = "Delete Match"
        Me.btnDeleteMatch.UseVisualStyleBackColor = True
        '
        'lstChooseMatch
        '
        Me.lstChooseMatch.FormattingEnabled = True
        Me.lstChooseMatch.Location = New System.Drawing.Point(15, 118)
        Me.lstChooseMatch.Name = "lstChooseMatch"
        Me.lstChooseMatch.Size = New System.Drawing.Size(577, 277)
        Me.lstChooseMatch.TabIndex = 48
        '
        'frmDeleteMatchDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstChooseMatch)
        Me.Controls.Add(Me.btnDeleteMatch)
        Me.Controls.Add(Me.lblChooseMatch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDeleteMatchDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeleteMatchDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDeleteMatchDetails As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblChooseMatch As System.Windows.Forms.Label
    Friend WithEvents btnDeleteMatch As System.Windows.Forms.Button
    Friend WithEvents lstChooseMatch As System.Windows.Forms.ListBox
End Class
