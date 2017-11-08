'Data is retrieved from the file and displayed on the form where the user can then edit it and re-write the file

Public Class frmEditMatchDetails

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmEditMatchDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseMatch.Focus()

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

            'Insert DateofMatch for each record into the listbox
            lstChooseMatch.Items.Add(MatchDetails(Count).DateofMatch)

        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseMatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseMatch.SelectedIndexChanged
        InformationFound = False
        Count = 0

        While Count < NumberofItemsinArray And InformationFound = False
            'Run the following until conditions above apply
            Count = Count + 1                                   'Add 1 to Count
            If lstChooseMatch.SelectedItem = MatchDetails(Count).DateofMatch Then
                'If DateofMatch in listbox = DateofMatch in record do:
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
                cboClub1.Text = MatchDetails(Count).Club1
                cboClub2.Text = MatchDetails(Count).Club2
                cboClub3.Text = MatchDetails(Count).Club3
                cboClub4.Text = MatchDetails(Count).Club4
                cboClub5.Text = MatchDetails(Count).Club5
                cboYellowRed1.Text = MatchDetails(Count).CautionSendoff1
                cboYellowRed2.Text = MatchDetails(Count).CautionSendoff2
                cboYellowRed3.Text = MatchDetails(Count).CautionSendoff3
                cboYellowRed4.Text = MatchDetails(Count).CautionSendoff4
                cboYellowRed5.Text = MatchDetails(Count).CautionSendoff5
                cboCode1.Text = MatchDetails(Count).Code1
                cboCode2.Text = MatchDetails(Count).Code2
                cboCode3.Text = MatchDetails(Count).Code3
                cboCode4.Text = MatchDetails(Count).Code4
                cboCode5.Text = MatchDetails(Count).Code5
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
                InformationFound = True                                         'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnSavetoFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavetoFile.Click
        MatchDetails(Count).DateofMatch = txtDateofMatch.Text               'Write textbox contents
        MatchDetails(Count).Competition = txtCompetition.Text               'into the array of records
        MatchDetails(Count).HomeTeam = txtHomeTeam.Text
        MatchDetails(Count).AwayTeam = txtAwayTeam.Text
        MatchDetails(Count).HomeScore = txtHomeScore.Text
        MatchDetails(Count).AwayScore = txtAwayScore.Text
        MatchDetails(Count).Surname1 = txtSurname1.Text
        MatchDetails(Count).Surname2 = txtSurname2.Text
        MatchDetails(Count).Surname3 = txtSurname3.Text
        MatchDetails(Count).Surname4 = txtSurname4.Text
        MatchDetails(Count).Surname5 = txtSurname5.Text
        MatchDetails(Count).Forename1 = txtForename1.Text
        MatchDetails(Count).Forename2 = txtForename2.Text
        MatchDetails(Count).Forename3 = txtForename3.Text
        MatchDetails(Count).Forename4 = txtForename4.Text
        MatchDetails(Count).Forename5 = txtForename5.Text
        MatchDetails(Count).Club1 = cboClub1.Text
        MatchDetails(Count).Club2 = cboClub2.Text
        MatchDetails(Count).Club3 = cboClub3.Text
        MatchDetails(Count).Club4 = cboClub4.Text
        MatchDetails(Count).Club5 = cboClub5.Text
        MatchDetails(Count).CautionSendoff1 = cboYellowRed1.Text
        MatchDetails(Count).CautionSendoff2 = cboYellowRed2.Text
        MatchDetails(Count).CautionSendoff3 = cboYellowRed3.Text
        MatchDetails(Count).CautionSendoff4 = cboYellowRed4.Text
        MatchDetails(Count).CautionSendoff5 = cboYellowRed5.Text
        MatchDetails(Count).Code1 = cboCode1.Text
        MatchDetails(Count).Code2 = cboCode2.Text
        MatchDetails(Count).Code3 = cboCode3.Text
        MatchDetails(Count).Code4 = cboCode4.Text
        MatchDetails(Count).Code5 = cboCode5.Text
        MatchDetails(Count).FACode1 = txtFACode1.Text
        MatchDetails(Count).FACode2 = txtFACode2.Text
        MatchDetails(Count).FACode3 = txtFACode3.Text
        MatchDetails(Count).FACode4 = txtFACode4.Text
        MatchDetails(Count).FACode5 = txtFACode5.Text
        MatchDetails(Count).Time1 = txtTime1.Text
        MatchDetails(Count).Time2 = txtTime2.Text
        MatchDetails(Count).Time3 = txtTime3.Text
        MatchDetails(Count).Time4 = txtTime4.Text
        MatchDetails(Count).Time5 = txtTime5.Text
        MatchDetails(Count).Referee = txtReferee.Text
        MatchDetails(Count).AssistantReferee1 = txtAsstRef1.Text
        MatchDetails(Count).AssistantReferee2 = txtAsstRef2.Text
        MatchDetails(Count).FourthOfficial = txtFourthOfficial.Text
        MatchDetails(Count).Notes = txtNotes.Text

        'Open MatchDetails file in Output Mode to overwrite
        FileOpen(1, "MatchDetails.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray                 'While Count is not equal to NoIiA do:
            Count = Count + 1                               'Add 1 to number of entries
            WriteLine(1, MatchDetails(Count).MatchID)                   'Write all variables into the file
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
        End While

        FileClose(1)                        'Close the file

        txtDateofMatch.Clear()              'Clear all textboxes
        txtCompetition.Clear()
        txtHomeTeam.Clear()
        txtAwayTeam.Clear()
        txtHomeScore.Clear()
        txtAwayScore.Clear()
        txtSurname1.Clear()
        txtSurname2.Clear()
        txtSurname3.Clear()
        txtSurname4.Clear()
        txtSurname5.Clear()
        txtForename1.Clear()
        txtForename2.Clear()
        txtForename3.Clear()
        txtForename4.Clear()
        txtForename5.Clear()
        cboClub1.Items.Clear()
        cboClub2.Items.Clear()
        cboClub3.Items.Clear()
        cboClub4.Items.Clear()
        cboClub5.Items.Clear()
        cboClub1.Text = ""
        cboClub2.Text = ""
        cboClub3.Text = ""
        cboClub4.Text = ""
        cboClub5.Text = ""
        cboYellowRed1.Text = ""
        cboYellowRed2.Text = ""
        cboYellowRed3.Text = ""
        cboYellowRed4.Text = ""
        cboYellowRed5.Text = ""
        cboCode1.Items.Clear()
        cboCode2.Items.Clear()
        cboCode3.Items.Clear()
        cboCode4.Items.Clear()
        cboCode5.Items.Clear()
        cboCode1.Text = ""
        cboCode2.Text = ""
        cboCode3.Text = ""
        cboCode4.Text = ""
        cboCode5.Text = ""
        txtFACode1.Clear()
        txtFACode2.Clear()
        txtFACode3.Clear()
        txtFACode4.Clear()
        txtFACode5.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        txtTime4.Clear()
        txtTime5.Clear()
        txtReferee.Clear()
        txtAsstRef1.Clear()
        txtAsstRef2.Clear()
        txtFourthOfficial.Clear()
        txtNotes.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class