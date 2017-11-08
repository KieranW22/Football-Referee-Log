'Data is retrieved from the file and displayed on the form

Public Class frmViewMatchDetails

    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmViewMatchDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseMatch.Focus()    'Place cursor on lstChooseMatch

        'Open file for MatchDetails in read-only mode       
        FileOpen(1, "MatchDetails.txt", OpenMode.Input)
        Count = 0                                       'Set variable 'Count'
        While Not EOF(1)                                'Run until the end of the file is reached
            Count = Count + 1                           'Add 1 to number of entries
            Input(1, MatchDetails(Count).MatchID)       'Read variables stroed in the file,
            Input(1, MatchDetails(Count).DateofMatch)   'into the system
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

            'Add the stored variables MatchID & DateofMatch into the listbox
            lstChooseMatch.Items.Add(MatchDetails(Count).MatchID & " " & MatchDetails(Count).DateofMatch)

        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseMatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseMatch.SelectedIndexChanged
        InformationFound = False
        Count = 0

        'Run while the number of entries into the array is less than the number of lines in the array_
        'or all information in the array is found
        While Count < NumberofItemsinArray And InformationFound = False
            Count = Count + 1   'Add 1 to number of entries
            'If DateofMatch in listbox = DateofMatch in array
            If lstChooseMatch.SelectedItem = MatchDetails(Count).MatchID & " " & MatchDetails(Count).DateofMatch Then
                txtDateofMatch.Text = MatchDetails(Count).DateofMatch   'Contents of relevant textbox
                txtCompetition.Text = MatchDetails(Count).Competition   '= contents of array
                txtHomeTeam.Text = MatchDetails(Count).HomeTeam
                txtAwayTeam.Text = MatchDetails(Count).AwayTeam
                txtHomeScore.Text = MatchDetails(Count).HomeScore
                txtAwayScore.Text = MatchDetails(Count).AwayScore
                txtSurname1.Text = MatchDetails(Count).Surname1
                txtSurname2.Text = MatchDetails(Count).Surname2
                txtSurname3.Text = MatchDetails(Count).Surname3
                txtSurname4.Text = MatchDetails(Count).Surname4
                txtSurname5.Text = MatchDetails(Count).Surname5
                txtForename1.Text = MatchDetails(Count).Forename1
                txtForename2.Text = MatchDetails(Count).Forename2
                txtForename3.Text = MatchDetails(Count).Forename3
                txtForename4.Text = MatchDetails(Count).Forename4
                txtForename5.Text = MatchDetails(Count).Forename5
                txtClub1.Text = MatchDetails(Count).Club1
                txtClub2.Text = MatchDetails(Count).Club2
                txtClub3.Text = MatchDetails(Count).Club3
                txtClub4.Text = MatchDetails(Count).Club4
                txtClub5.Text = MatchDetails(Count).Club5
                cboYellowRed1.Text = MatchDetails(Count).CautionSendoff1
                cboYellowRed2.Text = MatchDetails(Count).CautionSendoff2
                cboYellowRed3.Text = MatchDetails(Count).CautionSendoff3
                cboYellowRed4.Text = MatchDetails(Count).CautionSendoff4
                cboYellowRed5.Text = MatchDetails(Count).CautionSendoff5
                txtCode1.Text = MatchDetails(Count).Code1
                txtCode2.Text = MatchDetails(Count).Code2
                txtCode3.Text = MatchDetails(Count).Code3
                txtCode4.Text = MatchDetails(Count).Code4
                txtCode5.Text = MatchDetails(Count).Code5
                txtFACode1.Text = MatchDetails(Count).FACode1
                txtFACode2.Text = MatchDetails(Count).FACode2
                txtFACode3.Text = MatchDetails(Count).FACode3
                txtFACode4.Text = MatchDetails(Count).FACode4
                txtFACode5.Text = MatchDetails(Count).FACode5
                txtTime1.Text = MatchDetails(Count).Time1
                txtTime2.Text = MatchDetails(Count).Time2
                txtTime3.Text = MatchDetails(Count).Time3
                txtTime4.Text = MatchDetails(Count).Time4
                txtTime5.Text = MatchDetails(Count).Time5
                txtReferee.Text = MatchDetails(Count).Referee
                txtAsstRef1.Text = MatchDetails(Count).AssistantReferee1
                txtAsstRef2.Text = MatchDetails(Count).AssistantReferee2
                txtFourthOfficial.Text = MatchDetails(Count).FourthOfficial
                txtNotes.Text = MatchDetails(Count).Notes
                InformationFound = True                     'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class