'Data is retrieved from the file and displayed on the form where the user can then edit it and re-write the file

Public Class frmEditReport

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmEditReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseReport.Focus()

        'Open Reports file in read-only mode
        FileOpen(1, "Reports.txt", OpenMode.Input)
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, Report(Count).ReportID)
            Input(1, Report(Count).DateofReport)        'Read variables stored in the file,
            Input(1, Report(Count).Competition)         'into the system
            Input(1, Report(Count).HomeTeam)
            Input(1, Report(Count).AwayTeam)
            Input(1, Report(Count).PlayedAt)
            Input(1, Report(Count).ReportThat)
            Input(1, Report(Count).TypeOfOffence)
            Input(1, Report(Count).Name)
            Input(1, Report(Count).Club)
            Input(1, Report(Count).Law12Section)
            Input(1, Report(Count).AssistantReferees)
            Input(1, Report(Count).Incident)

            'Insert ReportID & DateofReport for each record into the listbox
            lstChooseReport.Items.Add(Report(Count).ReportID & " " & Report(Count).DateofReport)
        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseReport.SelectedIndexChanged
        InformationFound = False
        Count = 0

        While Count < NumberofItemsinArray And InformationFound = False
            'Run the following until conditions above apply
            Count = Count + 1
            If lstChooseReport.SelectedItem = Report(Count).ReportID & " " & Report(Count).DateofReport Then
                'If ReportID & DateofReport in listbox = ReportID & DateofReport in record do:
                txtDateofReport.Text = Report(Count).DateofReport       'Contents of relevant textbox
                txtCompetition.Text = Report(Count).Competition         '= contents of array
                txtHomeTeam.Text = Report(Count).HomeTeam
                txtAwayTeam.Text = Report(Count).AwayTeam
                txtPlayedAt.Text = Report(Count).PlayedAt
                txtReportThat.Text = Report(Count).ReportThat
                txtTypeOfOffence.Text = Report(Count).TypeOfOffence
                txtName.Text = Report(Count).Name
                txtOf.Text = Report(Count).Club
                txtLaw12.Text = Report(Count).Law12Section
                txtAsstRefs.Text = Report(Count).AssistantReferees
                txtIncident.Text = Report(Count).Incident
                InformationFound = True                                 'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnSavetoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavetoFile.Click
        Report(Count).DateofReport = txtDateofReport.Text               'Write textbox contents
        Report(Count).Competition = txtCompetition.Text                 'into the array of records
        Report(Count).HomeTeam = txtHomeTeam.Text
        Report(Count).AwayTeam = txtAwayTeam.Text
        Report(Count).PlayedAt = txtPlayedAt.Text
        Report(Count).ReportThat = txtReportThat.Text
        Report(Count).TypeOfOffence = txtTypeOfOffence.Text
        Report(Count).Name = txtName.Text
        Report(Count).Club = txtOf.Text
        Report(Count).Law12Section = txtLaw12.Text
        Report(Count).AssistantReferees = txtAsstRefs.Text
        Report(Count).Incident = txtIncident.Text

        'Open Reports file in Output Mode to overwrite
        FileOpen(1, "Reports.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray         'While Count is not equal to NoIiA do:
            Count = Count + 1                       'Add 1 to number of entries
            WriteLine(1, Report(Count).ReportID)        'Write all variables into the file
            WriteLine(1, Report(Count).DateofReport)
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
        End While

        FileClose(1)                        'Close the file

        txtDateofReport.Clear()             'Clear all textboxes
        txtHomeTeam.Clear()
        txtAwayTeam.Clear()
        txtPlayedAt.Clear()
        txtReportThat.Clear()
        txtTypeOfOffence.Clear()
        txtName.Clear()
        txtOf.Clear()
        txtLaw12.Clear()
        txtAsstRefs.Clear()
        txtIncident.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub
End Class