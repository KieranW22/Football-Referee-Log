'Data can be inserted on the form and then written to the file

Public Class frmAddReport

    'Declare variables as data types
    Dim Count As Integer

    Private Sub frmAddReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDateofReport.Focus()         'Move pointer to textbox
    End Sub

    Private Sub btnSavetoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavetoFile.Click
        'Open Reports file in read-only mode
        FileOpen(1, "Reports.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, Report(Count).ReportID)
            Input(1, Report(Count).DateofReport)            'Until end of the file is reached,
            Input(1, Report(Count).Competition)             'read all data from the file into
            Input(1, Report(Count).HomeTeam)                'the system
            Input(1, Report(Count).AwayTeam)
            Input(1, Report(Count).PlayedAt)
            Input(1, Report(Count).ReportThat)
            Input(1, Report(Count).TypeOfOffence)
            Input(1, Report(Count).Name)
            Input(1, Report(Count).Club)
            Input(1, Report(Count).Law12Section)
            Input(1, Report(Count).AssistantReferees)
            Input(1, Report(Count).Incident)
        End While

        Report(Count).ReportID = Report(Count).ReportID + 1     'Add 1 to ReportID
        FileClose(1)                                            'Close the file

        Report(Count).DateofReport = txtDateofReport.Text       'Write textbox contents
        Report(Count).Competition = txtCompetition.Text         'into the array of records
        Report(Count).HomeTeam = txtHomeTeam.Text
        Report(Count).AwayTeam = txtAwayTeam.Text
        Report(Count).PlayedAt = txtPlayedAt.Text
        Report(Count).ReportThat = cboReportThat.Text
        Report(Count).TypeOfOffence = cboTypeofOffence.Text
        Report(Count).Name = txtName.Text
        Report(Count).Club = cboClub.Text
        Report(Count).Law12Section = cboLaw12.Text
        Report(Count).AssistantReferees = txtAsstRefs.Text
        Report(Count).Incident = txtIncident.Text

        'Open Reports File in append mode
        FileOpen(1, "Reports.txt", OpenMode.Append)
        WriteLine(1, Report(Count).ReportID)
        WriteLine(1, Report(Count).DateofReport)        'Write all variables into the file
        WriteLine(1, Report(Count).Competition)
        WriteLine(1, Report(Count).HomeTeam)
        WriteLine(1, Report(Count).AwayTeam)
        WriteLine(1, Report(Count).PlayedAt)
        WriteLine(1, Report(Count).ReportThat)
        WriteLine(1, Report(Count).TypeOfOffence)
        WriteLine(1, Report(Count).Name)
        WriteLine(1, Report(Count).Club)
        WriteLine(1, Report(Count).Law12Section)
        WriteLine(1, Report(Count).AssistantReferees)
        WriteLine(1, Report(Count).Incident)
        FileClose(1)                                    'Close the file

        txtDateofReport.Clear()                         'Clear all textboxes & comboboxes
        txtCompetition.Clear()
        txtHomeTeam.Clear()
        txtAwayTeam.Clear()
        txtPlayedAt.Clear()
        cboReportThat.Items.Clear()
        cboReportThat.Text = ""
        cboTypeofOffence.Items.Clear()
        cboTypeofOffence.Text = ""
        txtName.Clear()
        cboClub.Items.Clear()
        cboClub.Text = ""
        cboLaw12.Items.Clear()
        cboLaw12.Text = ""
        txtAsstRefs.Clear()
        txtIncident.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub

    Private Sub txtHomeTeam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHomeTeam.TextChanged
        cboClub.Items.Clear()                       'When HomeTeam textbox text is changed, clear all textboxes
        cboClub.Items.Add(txtHomeTeam.Text)         'and add the contents of HomeTeam & AwayTeam textboxes to the
        cboClub.Items.Add(txtAwayTeam.Text)         'corresponding combobox items
    End Sub

    Private Sub txtAwayTeam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAwayTeam.TextChanged
        cboClub.Items.Clear()                       'When AwayTeam textbox text is changed, clear all textboxes
        cboClub.Items.Add(txtHomeTeam.Text)         'and add the contents of HomeTeam & AwayTeam textboxes to the
        cboClub.Items.Add(txtAwayTeam.Text)         'corresponding combobox items
    End Sub

    Private Sub cboTypeofOffence_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTypeofOffence.SelectedIndexChanged
        If cboTypeofOffence.Text = "sentoff" Then                   'Depending on whether the combobox contains "sentoff" or "am reporting for misconduct",
            cboLaw12.Items.Clear()                                  'change the contents of the Law12 combobox
            cboLaw12.Items.Add("S1 - Serious Foul Play")
            cboLaw12.Items.Add("S2 - Violent Conduct")
            cboLaw12.Items.Add("S3 - Spitting at an opponent or any other person")
            cboLaw12.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboLaw12.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboLaw12.Items.Add("S6 - Uses Offensive, Insulting or Abusive Language")
            cboLaw12.Items.Add("S7 - Receives a second caution in the same match")
        ElseIf cboTypeofOffence.Text = "am reporting for misconduct" Then
            cboLaw12.Items.Clear()
            cboLaw12.Items.Add("1a - Misconduct by Players after the game has ended")
            cboLaw12.Items.Add("1b - Misconduct by Club Official")
            cboLaw12.Items.Add("1c - Misconduct by Spectator")
        End If
    End Sub
End Class