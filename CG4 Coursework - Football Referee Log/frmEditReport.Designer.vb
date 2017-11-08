<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditReport))
        Me.lblEditReport = New System.Windows.Forms.Label()
        Me.btnSavetoFile = New System.Windows.Forms.Button()
        Me.lblChooseReport = New System.Windows.Forms.Label()
        Me.lstChooseReport = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtOf = New System.Windows.Forms.TextBox()
        Me.txtIncident = New System.Windows.Forms.TextBox()
        Me.lblIncident = New System.Windows.Forms.Label()
        Me.txtAsstRefs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOf = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblReportThat = New System.Windows.Forms.Label()
        Me.txtPlayedAt = New System.Windows.Forms.TextBox()
        Me.lblPlayedAt = New System.Windows.Forms.Label()
        Me.txtAwayTeam = New System.Windows.Forms.TextBox()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.lblCompetition = New System.Windows.Forms.Label()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.txtCompetition = New System.Windows.Forms.TextBox()
        Me.txtHomeTeam = New System.Windows.Forms.TextBox()
        Me.txtDateofReport = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtReportThat = New System.Windows.Forms.TextBox()
        Me.txtTypeOfOffence = New System.Windows.Forms.TextBox()
        Me.txtLaw12 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEditReport
        '
        Me.lblEditReport.AutoSize = True
        Me.lblEditReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditReport.Location = New System.Drawing.Point(333, 29)
        Me.lblEditReport.Name = "lblEditReport"
        Me.lblEditReport.Size = New System.Drawing.Size(119, 25)
        Me.lblEditReport.TabIndex = 0
        Me.lblEditReport.Text = "Edit Report"
        '
        'btnSavetoFile
        '
        Me.btnSavetoFile.Location = New System.Drawing.Point(606, 29)
        Me.btnSavetoFile.Name = "btnSavetoFile"
        Me.btnSavetoFile.Size = New System.Drawing.Size(151, 61)
        Me.btnSavetoFile.TabIndex = 47
        Me.btnSavetoFile.Text = "Save to File"
        Me.btnSavetoFile.UseVisualStyleBackColor = True
        '
        'lblChooseReport
        '
        Me.lblChooseReport.AutoSize = True
        Me.lblChooseReport.Location = New System.Drawing.Point(12, 115)
        Me.lblChooseReport.Name = "lblChooseReport"
        Me.lblChooseReport.Size = New System.Drawing.Size(115, 13)
        Me.lblChooseReport.TabIndex = 91
        Me.lblChooseReport.Text = "Select a Report below:"
        '
        'lstChooseReport
        '
        Me.lstChooseReport.FormattingEnabled = True
        Me.lstChooseReport.Location = New System.Drawing.Point(12, 131)
        Me.lstChooseReport.Name = "lstChooseReport"
        Me.lstChooseReport.Size = New System.Drawing.Size(120, 264)
        Me.lstChooseReport.TabIndex = 90
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 92
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtOf
        '
        Me.txtOf.Location = New System.Drawing.Point(440, 237)
        Me.txtOf.Name = "txtOf"
        Me.txtOf.Size = New System.Drawing.Size(197, 20)
        Me.txtOf.TabIndex = 113
        '
        'txtIncident
        '
        Me.txtIncident.Location = New System.Drawing.Point(214, 308)
        Me.txtIncident.Multiline = True
        Me.txtIncident.Name = "txtIncident"
        Me.txtIncident.Size = New System.Drawing.Size(508, 92)
        Me.txtIncident.TabIndex = 112
        '
        'lblIncident
        '
        Me.lblIncident.AutoSize = True
        Me.lblIncident.Location = New System.Drawing.Point(160, 311)
        Me.lblIncident.Name = "lblIncident"
        Me.lblIncident.Size = New System.Drawing.Size(48, 13)
        Me.lblIncident.TabIndex = 111
        Me.lblIncident.Text = "Incident:"
        '
        'txtAsstRefs
        '
        Me.txtAsstRefs.Location = New System.Drawing.Point(541, 265)
        Me.txtAsstRefs.Name = "txtAsstRefs"
        Me.txtAsstRefs.Size = New System.Drawing.Size(181, 20)
        Me.txtAsstRefs.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(437, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Assistant Referees:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Under Law 12 section:"
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.Location = New System.Drawing.Point(413, 240)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Size = New System.Drawing.Size(21, 13)
        Me.lblOf.TabIndex = 106
        Me.lblOf.Text = "Of:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(204, 237)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 20)
        Me.txtName.TabIndex = 105
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(160, 240)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 104
        Me.lblName.Text = "Name:"
        '
        'lblReportThat
        '
        Me.lblReportThat.AutoSize = True
        Me.lblReportThat.Location = New System.Drawing.Point(160, 204)
        Me.lblReportThat.Name = "lblReportThat"
        Me.lblReportThat.Size = New System.Drawing.Size(103, 13)
        Me.lblReportThat.TabIndex = 103
        Me.lblReportThat.Text = "I have to report that:"
        '
        'txtPlayedAt
        '
        Me.txtPlayedAt.Location = New System.Drawing.Point(220, 165)
        Me.txtPlayedAt.Name = "txtPlayedAt"
        Me.txtPlayedAt.Size = New System.Drawing.Size(309, 20)
        Me.txtPlayedAt.TabIndex = 102
        '
        'lblPlayedAt
        '
        Me.lblPlayedAt.AutoSize = True
        Me.lblPlayedAt.Location = New System.Drawing.Point(160, 168)
        Me.lblPlayedAt.Name = "lblPlayedAt"
        Me.lblPlayedAt.Size = New System.Drawing.Size(54, 13)
        Me.lblPlayedAt.TabIndex = 101
        Me.lblPlayedAt.Text = "Played at:"
        '
        'txtAwayTeam
        '
        Me.txtAwayTeam.Location = New System.Drawing.Point(525, 133)
        Me.txtAwayTeam.Name = "txtAwayTeam"
        Me.txtAwayTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtAwayTeam.TabIndex = 100
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(453, 136)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(66, 13)
        Me.lblAwayTeam.TabIndex = 99
        Me.lblAwayTeam.Text = "Away Team:"
        '
        'lblCompetition
        '
        Me.lblCompetition.AutoSize = True
        Me.lblCompetition.Location = New System.Drawing.Point(330, 105)
        Me.lblCompetition.Name = "lblCompetition"
        Me.lblCompetition.Size = New System.Drawing.Size(65, 13)
        Me.lblCompetition.TabIndex = 98
        Me.lblCompetition.Text = "Competition:"
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(160, 136)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(68, 13)
        Me.lblHomeTeam.TabIndex = 97
        Me.lblHomeTeam.Text = "Home Team:"
        '
        'txtCompetition
        '
        Me.txtCompetition.Location = New System.Drawing.Point(401, 102)
        Me.txtCompetition.Name = "txtCompetition"
        Me.txtCompetition.Size = New System.Drawing.Size(182, 20)
        Me.txtCompetition.TabIndex = 96
        '
        'txtHomeTeam
        '
        Me.txtHomeTeam.Location = New System.Drawing.Point(237, 133)
        Me.txtHomeTeam.Name = "txtHomeTeam"
        Me.txtHomeTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtHomeTeam.TabIndex = 95
        '
        'txtDateofReport
        '
        Me.txtDateofReport.Location = New System.Drawing.Point(199, 102)
        Me.txtDateofReport.Name = "txtDateofReport"
        Me.txtDateofReport.Size = New System.Drawing.Size(100, 20)
        Me.txtDateofReport.TabIndex = 94
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(160, 105)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 93
        Me.lblDate.Text = "Date:"
        '
        'txtReportThat
        '
        Me.txtReportThat.Location = New System.Drawing.Point(269, 201)
        Me.txtReportThat.Name = "txtReportThat"
        Me.txtReportThat.Size = New System.Drawing.Size(145, 20)
        Me.txtReportThat.TabIndex = 116
        '
        'txtTypeOfOffence
        '
        Me.txtTypeOfOffence.Location = New System.Drawing.Point(420, 201)
        Me.txtTypeOfOffence.Name = "txtTypeOfOffence"
        Me.txtTypeOfOffence.Size = New System.Drawing.Size(145, 20)
        Me.txtTypeOfOffence.TabIndex = 117
        '
        'txtLaw12
        '
        Me.txtLaw12.Location = New System.Drawing.Point(280, 269)
        Me.txtLaw12.Name = "txtLaw12"
        Me.txtLaw12.Size = New System.Drawing.Size(150, 20)
        Me.txtLaw12.TabIndex = 118
        '
        'frmEditReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLaw12)
        Me.Controls.Add(Me.txtTypeOfOffence)
        Me.Controls.Add(Me.txtReportThat)
        Me.Controls.Add(Me.txtOf)
        Me.Controls.Add(Me.txtIncident)
        Me.Controls.Add(Me.lblIncident)
        Me.Controls.Add(Me.txtAsstRefs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOf)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblReportThat)
        Me.Controls.Add(Me.txtPlayedAt)
        Me.Controls.Add(Me.lblPlayedAt)
        Me.Controls.Add(Me.txtAwayTeam)
        Me.Controls.Add(Me.lblAwayTeam)
        Me.Controls.Add(Me.lblCompetition)
        Me.Controls.Add(Me.lblHomeTeam)
        Me.Controls.Add(Me.txtCompetition)
        Me.Controls.Add(Me.txtHomeTeam)
        Me.Controls.Add(Me.txtDateofReport)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChooseReport)
        Me.Controls.Add(Me.lstChooseReport)
        Me.Controls.Add(Me.btnSavetoFile)
        Me.Controls.Add(Me.lblEditReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEditReport As System.Windows.Forms.Label
    Friend WithEvents btnSavetoFile As System.Windows.Forms.Button
    Friend WithEvents lblChooseReport As System.Windows.Forms.Label
    Friend WithEvents lstChooseReport As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtOf As System.Windows.Forms.TextBox
    Friend WithEvents txtIncident As System.Windows.Forms.TextBox
    Friend WithEvents lblIncident As System.Windows.Forms.Label
    Friend WithEvents txtAsstRefs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOf As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblReportThat As System.Windows.Forms.Label
    Friend WithEvents txtPlayedAt As System.Windows.Forms.TextBox
    Friend WithEvents lblPlayedAt As System.Windows.Forms.Label
    Friend WithEvents txtAwayTeam As System.Windows.Forms.TextBox
    Friend WithEvents lblAwayTeam As System.Windows.Forms.Label
    Friend WithEvents lblCompetition As System.Windows.Forms.Label
    Friend WithEvents lblHomeTeam As System.Windows.Forms.Label
    Friend WithEvents txtCompetition As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtDateofReport As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtReportThat As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeOfOffence As System.Windows.Forms.TextBox
    Friend WithEvents txtLaw12 As System.Windows.Forms.TextBox
End Class
