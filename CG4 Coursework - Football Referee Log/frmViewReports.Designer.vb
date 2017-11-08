<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewReports))
        Me.lblViewReports = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtAwayTeam = New System.Windows.Forms.TextBox()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.lblCompetition = New System.Windows.Forms.Label()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.txtCompetition = New System.Windows.Forms.TextBox()
        Me.txtHomeTeam = New System.Windows.Forms.TextBox()
        Me.txtDateofReport = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblPlayedAt = New System.Windows.Forms.Label()
        Me.txtPlayedAt = New System.Windows.Forms.TextBox()
        Me.lblReportThat = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblOf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboLaw12 = New System.Windows.Forms.ComboBox()
        Me.txtAsstRefs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIncident = New System.Windows.Forms.Label()
        Me.txtIncident = New System.Windows.Forms.TextBox()
        Me.txtOf = New System.Windows.Forms.TextBox()
        Me.lblChooseReport = New System.Windows.Forms.Label()
        Me.lstChooseReport = New System.Windows.Forms.ListBox()
        Me.cboTypeofOffence = New System.Windows.Forms.ComboBox()
        Me.cboReportThat = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblViewReports
        '
        Me.lblViewReports.AutoSize = True
        Me.lblViewReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblViewReports.Location = New System.Drawing.Point(323, 29)
        Me.lblViewReports.Name = "lblViewReports"
        Me.lblViewReports.Size = New System.Drawing.Size(139, 25)
        Me.lblViewReports.TabIndex = 0
        Me.lblViewReports.Text = "View Reports"
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
        'txtAwayTeam
        '
        Me.txtAwayTeam.Location = New System.Drawing.Point(521, 126)
        Me.txtAwayTeam.Name = "txtAwayTeam"
        Me.txtAwayTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtAwayTeam.TabIndex = 29
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(449, 129)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(66, 13)
        Me.lblAwayTeam.TabIndex = 28
        Me.lblAwayTeam.Text = "Away Team:"
        '
        'lblCompetition
        '
        Me.lblCompetition.AutoSize = True
        Me.lblCompetition.Location = New System.Drawing.Point(326, 98)
        Me.lblCompetition.Name = "lblCompetition"
        Me.lblCompetition.Size = New System.Drawing.Size(65, 13)
        Me.lblCompetition.TabIndex = 27
        Me.lblCompetition.Text = "Competition:"
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(156, 129)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(68, 13)
        Me.lblHomeTeam.TabIndex = 26
        Me.lblHomeTeam.Text = "Home Team:"
        '
        'txtCompetition
        '
        Me.txtCompetition.Location = New System.Drawing.Point(397, 95)
        Me.txtCompetition.Name = "txtCompetition"
        Me.txtCompetition.Size = New System.Drawing.Size(182, 20)
        Me.txtCompetition.TabIndex = 25
        '
        'txtHomeTeam
        '
        Me.txtHomeTeam.Location = New System.Drawing.Point(233, 126)
        Me.txtHomeTeam.Name = "txtHomeTeam"
        Me.txtHomeTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtHomeTeam.TabIndex = 24
        '
        'txtDateofReport
        '
        Me.txtDateofReport.Location = New System.Drawing.Point(195, 95)
        Me.txtDateofReport.Name = "txtDateofReport"
        Me.txtDateofReport.Size = New System.Drawing.Size(100, 20)
        Me.txtDateofReport.TabIndex = 23
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(156, 98)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 22
        Me.lblDate.Text = "Date:"
        '
        'lblPlayedAt
        '
        Me.lblPlayedAt.AutoSize = True
        Me.lblPlayedAt.Location = New System.Drawing.Point(156, 159)
        Me.lblPlayedAt.Name = "lblPlayedAt"
        Me.lblPlayedAt.Size = New System.Drawing.Size(54, 13)
        Me.lblPlayedAt.TabIndex = 30
        Me.lblPlayedAt.Text = "Played at:"
        '
        'txtPlayedAt
        '
        Me.txtPlayedAt.Location = New System.Drawing.Point(216, 156)
        Me.txtPlayedAt.Name = "txtPlayedAt"
        Me.txtPlayedAt.Size = New System.Drawing.Size(309, 20)
        Me.txtPlayedAt.TabIndex = 31
        '
        'lblReportThat
        '
        Me.lblReportThat.AutoSize = True
        Me.lblReportThat.Location = New System.Drawing.Point(156, 197)
        Me.lblReportThat.Name = "lblReportThat"
        Me.lblReportThat.Size = New System.Drawing.Size(103, 13)
        Me.lblReportThat.TabIndex = 32
        Me.lblReportThat.Text = "I have to report that:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(156, 233)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 34
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(200, 230)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 20)
        Me.txtName.TabIndex = 35
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.Location = New System.Drawing.Point(409, 233)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Size = New System.Drawing.Size(21, 13)
        Me.lblOf.TabIndex = 36
        Me.lblOf.Text = "Of:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Under Law 12 section:"
        '
        'cboLaw12
        '
        Me.cboLaw12.FormattingEnabled = True
        Me.cboLaw12.Location = New System.Drawing.Point(276, 262)
        Me.cboLaw12.Name = "cboLaw12"
        Me.cboLaw12.Size = New System.Drawing.Size(150, 21)
        Me.cboLaw12.TabIndex = 40
        '
        'txtAsstRefs
        '
        Me.txtAsstRefs.Location = New System.Drawing.Point(537, 258)
        Me.txtAsstRefs.Name = "txtAsstRefs"
        Me.txtAsstRefs.Size = New System.Drawing.Size(181, 20)
        Me.txtAsstRefs.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(433, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Assistant Referees:"
        '
        'lblIncident
        '
        Me.lblIncident.AutoSize = True
        Me.lblIncident.Location = New System.Drawing.Point(156, 304)
        Me.lblIncident.Name = "lblIncident"
        Me.lblIncident.Size = New System.Drawing.Size(48, 13)
        Me.lblIncident.TabIndex = 43
        Me.lblIncident.Text = "Incident:"
        '
        'txtIncident
        '
        Me.txtIncident.Location = New System.Drawing.Point(210, 301)
        Me.txtIncident.Multiline = True
        Me.txtIncident.Name = "txtIncident"
        Me.txtIncident.Size = New System.Drawing.Size(508, 92)
        Me.txtIncident.TabIndex = 44
        '
        'txtOf
        '
        Me.txtOf.Location = New System.Drawing.Point(436, 230)
        Me.txtOf.Name = "txtOf"
        Me.txtOf.Size = New System.Drawing.Size(197, 20)
        Me.txtOf.TabIndex = 45
        '
        'lblChooseReport
        '
        Me.lblChooseReport.AutoSize = True
        Me.lblChooseReport.Location = New System.Drawing.Point(12, 113)
        Me.lblChooseReport.Name = "lblChooseReport"
        Me.lblChooseReport.Size = New System.Drawing.Size(115, 13)
        Me.lblChooseReport.TabIndex = 47
        Me.lblChooseReport.Text = "Select a Report below:"
        '
        'lstChooseReport
        '
        Me.lstChooseReport.FormattingEnabled = True
        Me.lstChooseReport.Location = New System.Drawing.Point(12, 129)
        Me.lstChooseReport.Name = "lstChooseReport"
        Me.lstChooseReport.Size = New System.Drawing.Size(120, 264)
        Me.lstChooseReport.TabIndex = 46
        '
        'cboTypeofOffence
        '
        Me.cboTypeofOffence.FormattingEnabled = True
        Me.cboTypeofOffence.Items.AddRange(New Object() {"sentoff", "am reporting for misconduct"})
        Me.cboTypeofOffence.Location = New System.Drawing.Point(416, 194)
        Me.cboTypeofOffence.Name = "cboTypeofOffence"
        Me.cboTypeofOffence.Size = New System.Drawing.Size(145, 21)
        Me.cboTypeofOffence.TabIndex = 73
        '
        'cboReportThat
        '
        Me.cboReportThat.FormattingEnabled = True
        Me.cboReportThat.Items.AddRange(New Object() {"I, as the Referee", "the Referee"})
        Me.cboReportThat.Location = New System.Drawing.Point(265, 194)
        Me.cboReportThat.Name = "cboReportThat"
        Me.cboReportThat.Size = New System.Drawing.Size(145, 21)
        Me.cboReportThat.TabIndex = 72
        '
        'frmViewReports
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboTypeofOffence)
        Me.Controls.Add(Me.cboReportThat)
        Me.Controls.Add(Me.lblChooseReport)
        Me.Controls.Add(Me.lstChooseReport)
        Me.Controls.Add(Me.txtOf)
        Me.Controls.Add(Me.txtIncident)
        Me.Controls.Add(Me.lblIncident)
        Me.Controls.Add(Me.txtAsstRefs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboLaw12)
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
        Me.Controls.Add(Me.lblViewReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewReports"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblViewReports As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtAwayTeam As System.Windows.Forms.TextBox
    Friend WithEvents lblAwayTeam As System.Windows.Forms.Label
    Friend WithEvents lblCompetition As System.Windows.Forms.Label
    Friend WithEvents lblHomeTeam As System.Windows.Forms.Label
    Friend WithEvents txtCompetition As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtDateofReport As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblPlayedAt As System.Windows.Forms.Label
    Friend WithEvents txtPlayedAt As System.Windows.Forms.TextBox
    Friend WithEvents lblReportThat As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblOf As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLaw12 As System.Windows.Forms.ComboBox
    Friend WithEvents txtAsstRefs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblIncident As System.Windows.Forms.Label
    Friend WithEvents txtIncident As System.Windows.Forms.TextBox
    Friend WithEvents txtOf As System.Windows.Forms.TextBox
    Friend WithEvents lblChooseReport As System.Windows.Forms.Label
    Friend WithEvents lstChooseReport As System.Windows.Forms.ListBox
    Friend WithEvents cboTypeofOffence As System.Windows.Forms.ComboBox
    Friend WithEvents cboReportThat As System.Windows.Forms.ComboBox
End Class
