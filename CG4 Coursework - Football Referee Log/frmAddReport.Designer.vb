<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddReport))
        Me.lblAddReport = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSavetoFile = New System.Windows.Forms.Button()
        Me.cboTypeofOffence = New System.Windows.Forms.ComboBox()
        Me.cboReportThat = New System.Windows.Forms.ComboBox()
        Me.txtIncident = New System.Windows.Forms.TextBox()
        Me.lblIncident = New System.Windows.Forms.Label()
        Me.txtAsstRefs = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboLaw12 = New System.Windows.Forms.ComboBox()
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
        Me.cboClub = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblAddReport
        '
        Me.lblAddReport.AutoSize = True
        Me.lblAddReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddReport.Location = New System.Drawing.Point(332, 29)
        Me.lblAddReport.Name = "lblAddReport"
        Me.lblAddReport.Size = New System.Drawing.Size(120, 25)
        Me.lblAddReport.TabIndex = 0
        Me.lblAddReport.Text = "Add Report"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 12)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 27)
        Me.btnClose.TabIndex = 68
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSavetoFile
        '
        Me.btnSavetoFile.Location = New System.Drawing.Point(591, 29)
        Me.btnSavetoFile.Name = "btnSavetoFile"
        Me.btnSavetoFile.Size = New System.Drawing.Size(151, 61)
        Me.btnSavetoFile.TabIndex = 69
        Me.btnSavetoFile.Text = "Save to File"
        Me.btnSavetoFile.UseVisualStyleBackColor = True
        '
        'cboTypeofOffence
        '
        Me.cboTypeofOffence.FormattingEnabled = True
        Me.cboTypeofOffence.Items.AddRange(New Object() {"sentoff", "am reporting for misconduct"})
        Me.cboTypeofOffence.Location = New System.Drawing.Point(303, 194)
        Me.cboTypeofOffence.Name = "cboTypeofOffence"
        Me.cboTypeofOffence.Size = New System.Drawing.Size(145, 21)
        Me.cboTypeofOffence.TabIndex = 96
        '
        'cboReportThat
        '
        Me.cboReportThat.FormattingEnabled = True
        Me.cboReportThat.Items.AddRange(New Object() {"I, as the Referee", "the Referee"})
        Me.cboReportThat.Location = New System.Drawing.Point(152, 194)
        Me.cboReportThat.Name = "cboReportThat"
        Me.cboReportThat.Size = New System.Drawing.Size(145, 21)
        Me.cboReportThat.TabIndex = 95
        '
        'txtIncident
        '
        Me.txtIncident.Location = New System.Drawing.Point(97, 301)
        Me.txtIncident.Multiline = True
        Me.txtIncident.Name = "txtIncident"
        Me.txtIncident.Size = New System.Drawing.Size(508, 92)
        Me.txtIncident.TabIndex = 93
        '
        'lblIncident
        '
        Me.lblIncident.AutoSize = True
        Me.lblIncident.Location = New System.Drawing.Point(43, 304)
        Me.lblIncident.Name = "lblIncident"
        Me.lblIncident.Size = New System.Drawing.Size(48, 13)
        Me.lblIncident.TabIndex = 92
        Me.lblIncident.Text = "Incident:"
        '
        'txtAsstRefs
        '
        Me.txtAsstRefs.Location = New System.Drawing.Point(424, 262)
        Me.txtAsstRefs.Name = "txtAsstRefs"
        Me.txtAsstRefs.Size = New System.Drawing.Size(181, 20)
        Me.txtAsstRefs.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Assistant Referees:"
        '
        'cboLaw12
        '
        Me.cboLaw12.FormattingEnabled = True
        Me.cboLaw12.Location = New System.Drawing.Point(163, 262)
        Me.cboLaw12.Name = "cboLaw12"
        Me.cboLaw12.Size = New System.Drawing.Size(150, 21)
        Me.cboLaw12.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Under Law 12 section:"
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.Location = New System.Drawing.Point(296, 233)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Size = New System.Drawing.Size(21, 13)
        Me.lblOf.TabIndex = 87
        Me.lblOf.Text = "Of:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(87, 230)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(189, 20)
        Me.txtName.TabIndex = 86
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(43, 233)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 85
        Me.lblName.Text = "Name:"
        '
        'lblReportThat
        '
        Me.lblReportThat.AutoSize = True
        Me.lblReportThat.Location = New System.Drawing.Point(43, 197)
        Me.lblReportThat.Name = "lblReportThat"
        Me.lblReportThat.Size = New System.Drawing.Size(103, 13)
        Me.lblReportThat.TabIndex = 84
        Me.lblReportThat.Text = "I have to report that:"
        '
        'txtPlayedAt
        '
        Me.txtPlayedAt.Location = New System.Drawing.Point(103, 156)
        Me.txtPlayedAt.Name = "txtPlayedAt"
        Me.txtPlayedAt.Size = New System.Drawing.Size(309, 20)
        Me.txtPlayedAt.TabIndex = 83
        '
        'lblPlayedAt
        '
        Me.lblPlayedAt.AutoSize = True
        Me.lblPlayedAt.Location = New System.Drawing.Point(43, 159)
        Me.lblPlayedAt.Name = "lblPlayedAt"
        Me.lblPlayedAt.Size = New System.Drawing.Size(54, 13)
        Me.lblPlayedAt.TabIndex = 82
        Me.lblPlayedAt.Text = "Played at:"
        '
        'txtAwayTeam
        '
        Me.txtAwayTeam.Location = New System.Drawing.Point(408, 126)
        Me.txtAwayTeam.Name = "txtAwayTeam"
        Me.txtAwayTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtAwayTeam.TabIndex = 81
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.AutoSize = True
        Me.lblAwayTeam.Location = New System.Drawing.Point(336, 129)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(66, 13)
        Me.lblAwayTeam.TabIndex = 80
        Me.lblAwayTeam.Text = "Away Team:"
        '
        'lblCompetition
        '
        Me.lblCompetition.AutoSize = True
        Me.lblCompetition.Location = New System.Drawing.Point(213, 98)
        Me.lblCompetition.Name = "lblCompetition"
        Me.lblCompetition.Size = New System.Drawing.Size(65, 13)
        Me.lblCompetition.TabIndex = 79
        Me.lblCompetition.Text = "Competition:"
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.AutoSize = True
        Me.lblHomeTeam.Location = New System.Drawing.Point(43, 129)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(68, 13)
        Me.lblHomeTeam.TabIndex = 78
        Me.lblHomeTeam.Text = "Home Team:"
        '
        'txtCompetition
        '
        Me.txtCompetition.Location = New System.Drawing.Point(284, 95)
        Me.txtCompetition.Name = "txtCompetition"
        Me.txtCompetition.Size = New System.Drawing.Size(182, 20)
        Me.txtCompetition.TabIndex = 77
        '
        'txtHomeTeam
        '
        Me.txtHomeTeam.Location = New System.Drawing.Point(120, 126)
        Me.txtHomeTeam.Name = "txtHomeTeam"
        Me.txtHomeTeam.Size = New System.Drawing.Size(197, 20)
        Me.txtHomeTeam.TabIndex = 76
        '
        'txtDateofReport
        '
        Me.txtDateofReport.Location = New System.Drawing.Point(82, 95)
        Me.txtDateofReport.Name = "txtDateofReport"
        Me.txtDateofReport.Size = New System.Drawing.Size(100, 20)
        Me.txtDateofReport.TabIndex = 75
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(43, 98)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 74
        Me.lblDate.Text = "Date:"
        '
        'cboClub
        '
        Me.cboClub.FormattingEnabled = True
        Me.cboClub.Location = New System.Drawing.Point(323, 230)
        Me.cboClub.Name = "cboClub"
        Me.cboClub.Size = New System.Drawing.Size(197, 21)
        Me.cboClub.TabIndex = 97
        '
        'frmAddReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboClub)
        Me.Controls.Add(Me.cboTypeofOffence)
        Me.Controls.Add(Me.cboReportThat)
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
        Me.Controls.Add(Me.btnSavetoFile)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAddReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAddReport As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSavetoFile As System.Windows.Forms.Button
    Friend WithEvents cboTypeofOffence As System.Windows.Forms.ComboBox
    Friend WithEvents cboReportThat As System.Windows.Forms.ComboBox
    Friend WithEvents txtIncident As System.Windows.Forms.TextBox
    Friend WithEvents lblIncident As System.Windows.Forms.Label
    Friend WithEvents txtAsstRefs As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboLaw12 As System.Windows.Forms.ComboBox
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
    Friend WithEvents cboClub As System.Windows.Forms.ComboBox
End Class
