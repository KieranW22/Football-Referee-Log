'Data is retrieved from the file, then the user can select a record to be deleted and rewrite the file without it

Public Class frmDeleteMatchDetails

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean
    Dim ItemtobeDeleted As Integer

    Private Sub frmDeleteMatchDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Open Match Details file in read-only mode
        FileOpen(1, "MatchDetails.txt", OpenMode.Input)
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, MatchDetails(Count).MatchID)           'Read variables stroed in the file,
            Input(1, MatchDetails(Count).DateofMatch)       'into the system
            Input(1, MatchDetails(Count).Competition)
            Input(1, MatchDetails(Count).HomeTeam)
            Input(1, MatchDetails(Count).AwayTeam)
            Input(1, MatchDetails(Count).HomeScore)
            Input(1, MatchDetails(Count).AwayScore)
            Input(1, MatchDetails(Count).Surname1)
            Input(1, MatchDetails(Count).Surname2)
            Input(1, MatchDetails(Count).Surname3)
            Input(1, MatchDetails(Count).Surname4)
            Input(1, MatchDetails(Count).Surname5)
            Input(1, MatchDetails(Count).Forename1)
            Input(1, MatchDetails(Count).Forename2)
            Input(1, MatchDetails(Count).Forename3)
            Input(1, MatchDetails(Count).Forename4)
            Input(1, MatchDetails(Count).Forename5)
            Input(1, MatchDetails(Count).Club1)
            Input(1, MatchDetails(Count).Club2)
            Input(1, MatchDetails(Count).Club3)
            Input(1, MatchDetails(Count).Club4)
            Input(1, MatchDetails(Count).Club5)
            Input(1, MatchDetails(Count).CautionSendoff1)
            Input(1, MatchDetails(Count).CautionSendoff2)
            Input(1, MatchDetails(Count).CautionSendoff3)
            Input(1, MatchDetails(Count).CautionSendoff4)
            Input(1, MatchDetails(Count).CautionSendoff5)
            Input(1, MatchDetails(Count).Code1)
            Input(1, MatchDetails(Count).Code2)
            Input(1, MatchDetails(Count).Code3)
            Input(1, MatchDetails(Count).Code4)
            Input(1, MatchDetails(Count).Code5)
            Input(1, MatchDetails(Count).FACode1)
            Input(1, MatchDetails(Count).FACode2)
            Input(1, MatchDetails(Count).FACode3)
            Input(1, MatchDetails(Count).FACode4)
            Input(1, MatchDetails(Count).FACode5)
            Input(1, MatchDetails(Count).Time1)
            Input(1, MatchDetails(Count).Time2)
            Input(1, MatchDetails(Count).Time3)
            Input(1, MatchDetails(Count).Time4)
            Input(1, MatchDetails(Count).Time5)
            Input(1, MatchDetails(Count).Referee)
            Input(1, MatchDetails(Count).AssistantReferee1)
            Input(1, MatchDetails(Count).AssistantReferee2)
            Input(1, MatchDetails(Count).FourthOfficial)
            Input(1, MatchDetails(Count).Notes)

            'Insert Match variables for each record into the listbox
            lstChooseMatch.Items.Add(MatchDetails(Count).MatchID & "-" & MatchDetails(Count).DateofMatch & "-" & MatchDetails(Count).Competition & "-" & MatchDetails(Count).HomeTeam & "-" & MatchDetails(Count).AwayTeam)
        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseMatch_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstChooseMatch.SelectedIndexChanged
        InformationFound = False
        Count = 0

        While Count < NumberofItemsinArray And InformationFound = False
            'Run the following until conditions above apply
            Count = Count + 1
            If lstChooseMatch.SelectedItem = MatchDetails(Count).MatchID & "-" & MatchDetails(Count).DateofMatch & "-" & MatchDetails(Count).Competition & "-" & MatchDetails(Count).HomeTeam & "-" & MatchDetails(Count).AwayTeam Then
                'If MatchDetails in listbox = MatchDetails in record do:
                Dim information = lstChooseMatch.SelectedItem           'Information = String in listbox
                Dim fields = information.Split("-")                     'Split the string at each " - "
                MatchDetails(Count).MatchID = fields(0).trim            'Contents of array = each field
                MatchDetails(Count).DateofMatch = fields(1).Trim()
                MatchDetails(Count).Competition = fields(2).Trim()
                MatchDetails(Count).HomeTeam = fields(3).Trim()
                MatchDetails(Count).AwayTeam = fields(4).Trim()
                InformationFound = True                                 'Rogue value stops code running
                ItemtobeDeleted = Count                                 'Find the address of the item to be deleted
            End If
        End While
    End Sub

    Private Sub btnDeleteMatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteMatch.Click
        'Open MatchDetails file in Output Mode to overwrite
        FileOpen(1, "MatchDetails.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray - 1             'While Count is not equal to NoIiA do:
            Count = Count + 1                               'Add 1 to number of entries
            If Count <> ItemtobeDeleted Then                    'Skip the selected record to remove it from file
                WriteLine(1, MatchDetails(Count).MatchID)       'Write all variables into the file
                WriteLine(1, MatchDetails(Count).DateofMatch)
                WriteLine(1, MatchDetails(Count).Competition)
                WriteLine(1, MatchDetails(Count).HomeTeam)
                WriteLine(1, MatchDetails(Count).AwayTeam)
                WriteLine(1, MatchDetails(Count).HomeScore)
                WriteLine(1, MatchDetails(Count).AwayScore)
                WriteLine(1, MatchDetails(Count).Surname1)
                WriteLine(1, MatchDetails(Count).Surname2)
                WriteLine(1, MatchDetails(Count).Surname3)
                WriteLine(1, MatchDetails(Count).Surname4)
                WriteLine(1, MatchDetails(Count).Surname5)
                WriteLine(1, MatchDetails(Count).Forename1)
                WriteLine(1, MatchDetails(Count).Forename2)
                WriteLine(1, MatchDetails(Count).Forename3)
                WriteLine(1, MatchDetails(Count).Forename4)
                WriteLine(1, MatchDetails(Count).Forename5)
                WriteLine(1, MatchDetails(Count).Club1)
                WriteLine(1, MatchDetails(Count).Club2)
                WriteLine(1, MatchDetails(Count).Club3)
                WriteLine(1, MatchDetails(Count).Club4)
                WriteLine(1, MatchDetails(Count).Club5)
                WriteLine(1, MatchDetails(Count).CautionSendoff1)
                WriteLine(1, MatchDetails(Count).CautionSendoff2)
                WriteLine(1, MatchDetails(Count).CautionSendoff3)
                WriteLine(1, MatchDetails(Count).CautionSendoff4)
                WriteLine(1, MatchDetails(Count).CautionSendoff5)
                WriteLine(1, MatchDetails(Count).Code1)
                WriteLine(1, MatchDetails(Count).Code2)
                WriteLine(1, MatchDetails(Count).Code3)
                WriteLine(1, MatchDetails(Count).Code4)
                WriteLine(1, MatchDetails(Count).Code5)
                WriteLine(1, MatchDetails(Count).FACode1)
                WriteLine(1, MatchDetails(Count).FACode2)
                WriteLine(1, MatchDetails(Count).FACode3)
                WriteLine(1, MatchDetails(Count).FACode4)
                WriteLine(1, MatchDetails(Count).FACode5)
                WriteLine(1, MatchDetails(Count).Time1)
                WriteLine(1, MatchDetails(Count).Time2)
                WriteLine(1, MatchDetails(Count).Time3)
                WriteLine(1, MatchDetails(Count).Time4)
                WriteLine(1, MatchDetails(Count).Time5)
                WriteLine(1, MatchDetails(Count).Referee)
                WriteLine(1, MatchDetails(Count).AssistantReferee1)
                WriteLine(1, MatchDetails(Count).AssistantReferee2)
                WriteLine(1, MatchDetails(Count).FourthOfficial)
                WriteLine(1, MatchDetails(Count).Notes)
            End If
        End While

        FileClose(1)                    'Close the file

        lstChooseMatch.Items.RemoveAt(lstChooseMatch.SelectedIndex)     'Remove record from listbox
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class