<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeleteContact))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDeleteContact = New System.Windows.Forms.Button()
        Me.lblChooseConatct = New System.Windows.Forms.Label()
        Me.lstChooseContact = New System.Windows.Forms.ListBox()
        Me.lblDeleteContact = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 105
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnDeleteContact
        '
        Me.btnDeleteContact.Location = New System.Drawing.Point(621, 221)
        Me.btnDeleteContact.Name = "btnDeleteContact"
        Me.btnDeleteContact.Size = New System.Drawing.Size(151, 61)
        Me.btnDeleteContact.TabIndex = 104
        Me.btnDeleteContact.Text = "Delete Contact"
        Me.btnDeleteContact.UseVisualStyleBackColor = True
        '
        'lblChooseConatct
        '
        Me.lblChooseConatct.AutoSize = True
        Me.lblChooseConatct.Location = New System.Drawing.Point(12, 120)
        Me.lblChooseConatct.Name = "lblChooseConatct"
        Me.lblChooseConatct.Size = New System.Drawing.Size(120, 13)
        Me.lblChooseConatct.TabIndex = 103
        Me.lblChooseConatct.Text = "Select a Contact below:"
        '
        'lstChooseContact
        '
        Me.lstChooseContact.FormattingEnabled = True
        Me.lstChooseContact.Location = New System.Drawing.Point(12, 136)
        Me.lstChooseContact.Name = "lstChooseContact"
        Me.lstChooseContact.Size = New System.Drawing.Size(593, 264)
        Me.lstChooseContact.TabIndex = 102
        '
        'lblDeleteContact
        '
        Me.lblDeleteContact.AutoSize = True
        Me.lblDeleteContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeleteContact.Location = New System.Drawing.Point(310, 51)
        Me.lblDeleteContact.Name = "lblDeleteContact"
        Me.lblDeleteContact.Size = New System.Drawing.Size(154, 25)
        Me.lblDeleteContact.TabIndex = 101
        Me.lblDeleteContact.Text = "Delete Contact"
        '
        'frmDeleteContact
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDeleteContact)
        Me.Controls.Add(Me.lblChooseConatct)
        Me.Controls.Add(Me.lstChooseContact)
        Me.Controls.Add(Me.lblDeleteContact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDeleteContact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDeleteContact As System.Windows.Forms.Button
    Friend WithEvents lblChooseConatct As System.Windows.Forms.Label
    Friend WithEvents lstChooseContact As System.Windows.Forms.ListBox
    Friend WithEvents lblDeleteContact As System.Windows.Forms.Label
End Class
