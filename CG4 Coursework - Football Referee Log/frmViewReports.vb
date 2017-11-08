'Data is retrieved from the file and displayed on the form

Public Class frmViewReports

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmViewReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstChooseReport.Focus()    'Place cursor on lstChooseMatch

        'Open file for Reports in read-only mode       
        FileOpen(1, "Reports.txt", OpenMode.Input)
        Count = 0                                       'Set variable 'Count'
        While Not EOF(1)                                'Run until the end of the file is reached
            Count = Count + 1                           'Add 1 to number of entries
            Input(1, Report(Count).ReportID)
            Input(1, Report(Count).DateofReport)        'Read variables stroed in the file,
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

            'Add the stored variable ReportID & DateofReport into the listbox
            lstChooseReport.Items.Add(Report(Count).ReportID & " " & Report(Count).DateofReport)
        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseReport_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstChooseReport.SelectedIndexChanged
        InformationFound = False
        Count = 0

        'Run while the number of entries into the array is less than the number of lines in the array_
        'or all information in the array is found
        While Count < NumberofItemsinArray And InformationFound = False
            Count = Count + 1   'Add 1 to number of entries
            'If ReportID & DateofReport in listbox = ReportID & DateofReport in array
            If lstChooseReport.SelectedItem = Report(Count).ReportID & " " & Report(Count).DateofReport Then
                txtDateofReport.Text = Report(Count).DateofReport       'Contents of relevant textbox
                txtCompetition.Text = Report(Count).Competition         '= contents of array
                txtHomeTeam.Text = Report(Count).HomeTeam
                txtAwayTeam.Text = Report(Count).AwayTeam
                txtPlayedAt.Text = Report(Count).PlayedAt
                cboReportThat.Text = Report(Count).ReportThat
                cboTypeofOffence.Text = Report(Count).TypeOfOffence
                txtName.Text = Report(Count).Name
                txtOf.Text = Report(Count).Club
                cboLaw12.Text = Report(Count).Law12Section
                txtAsstRefs.Text = Report(Count).AssistantReferees
                txtIncident.Text = Report(Count).Incident
                InformationFound = True                     'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class