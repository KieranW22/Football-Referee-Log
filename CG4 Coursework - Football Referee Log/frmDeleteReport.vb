'Data is retrieved from the file, then the user can select a record to be deleted and rewrite the file without it

Public Class frmDeleteReport

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean
    Dim ItemtobeDeleted As Integer

    Private Sub frmDeleteReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open Reports file in read-only mode
        FileOpen(1, "Reports.txt", OpenMode.Input)
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, Report(Count).ReportID)            'Read variables stored in the file,
            Input(1, Report(Count).DateofReport)        'into the system
            Input(1, Report(Count).Competition)
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

            'Insert Report variables for each record into the listbox
            lstChooseReport.Items.Add(Report(Count).ReportID & "-" & Report(Count).DateofReport & "-" & Report(Count).Competition & "-" & Report(Count).HomeTeam & "-" & Report(Count).AwayTeam)
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
            If lstChooseReport.SelectedItem = Report(Count).ReportID & "-" & Report(Count).DateofReport & "-" & Report(Count).Competition & "-" & Report(Count).HomeTeam & "-" & Report(Count).AwayTeam Then
                'If Report in listbox = Report in record do:
                Dim information = lstChooseReport.SelectedItem          'Information = String in listbox
                Dim fields = information.Split("-")                     'Split the string at each " - "
                Report(Count).ReportID = fields(0).trim                 'Contents of array = each field
                Report(Count).DateofReport = fields(1).Trim()
                Report(Count).Competition = fields(2).Trim()
                Report(Count).HomeTeam = fields(3).Trim()
                Report(Count).AwayTeam = fields(4).Trim()
                InformationFound = True                                 'Rogue value stops code running
                ItemtobeDeleted = Count                                 'Find the address of the item to be deleted
            End If
        End While
    End Sub

    Private Sub btnDeleteReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteReport.Click
        'Open Report file in Output Mode to overwrite
        FileOpen(1, "Reports.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray - 1             'While Count is not equal to NoIiA do:
            Count = Count + 1                               'Add 1 to number of entries
            If Count <> ItemtobeDeleted Then                    'Skip the selected record to remove it from file
                WriteLine(1, Report(Count).ReportID)            'Write all variables into the file
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
            End If
        End While

        FileClose(1)                    'Close the file

        lstChooseReport.Items.RemoveAt(lstChooseReport.SelectedIndex)   'Remove record from listbox
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub
End Class