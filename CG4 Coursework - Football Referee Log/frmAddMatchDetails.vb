'Data can be inserted on the form and then written to the file

Public Class frmAddMatchDetails

    'Declare variables as data types
    Dim Count As Integer

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub

    Private Sub btnSavetoFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSavetoFile.Click
        'Open Match Details file in read-only mode
        FileOpen(1, "MatchDetails.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, MatchDetails(Count).MatchID)                   'Until end of the file is reached,
            Input(1, MatchDetails(Count).DateofMatch)               'read all data from the file into
            Input(1, MatchDetails(Count).Competition)               'the system
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
        End While

        MatchDetails(Count).MatchID = MatchDetails(Count).MatchID + 1       'Add 1 to MatchID
        FileClose(1)                                                        'Close the file

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

        'Open MatchDetails File in append mode
        FileOpen(1, "MatchDetails.txt", OpenMode.Append)
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
        FileClose(1)                                                'Close the file

        txtDateofMatch.Clear()                                      'Clear all textboxes & comboboxes
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

    Private Sub frmAddMatchDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtDateofMatch.Focus()          'Move pointer to textbox
    End Sub

    Private Sub txtHomeTeam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHomeTeam.TextChanged
        cboClub1.Items.Clear()                      'When HomeTeam textbox text is changed, clear all textboxes
        cboClub1.Items.Add(txtHomeTeam.Text)        'and add the contents of HomeTeam & AwayTeam textboxes to the
        cboClub1.Items.Add(txtAwayTeam.Text)        'corresponding combobox items

        cboClub2.Items.Clear()
        cboClub2.Items.Add(txtHomeTeam.Text)
        cboClub2.Items.Add(txtAwayTeam.Text)

        cboClub3.Items.Clear()
        cboClub3.Items.Add(txtHomeTeam.Text)
        cboClub3.Items.Add(txtAwayTeam.Text)

        cboClub4.Items.Clear()
        cboClub4.Items.Add(txtHomeTeam.Text)
        cboClub4.Items.Add(txtAwayTeam.Text)

        cboClub5.Items.Clear()
        cboClub5.Items.Add(txtHomeTeam.Text)
        cboClub5.Items.Add(txtAwayTeam.Text)
    End Sub

    Private Sub txtAwayTeam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAwayTeam.TextChanged
        cboClub1.Items.Clear()                      'When AwayTeam textbox text is changed, clear all textboxes
        cboClub1.Items.Add(txtHomeTeam.Text)        'and add the contents of HomeTeam & AwayTeam textboxes to the
        cboClub1.Items.Add(txtAwayTeam.Text)        'corresponding combobox items

        cboClub2.Items.Clear()
        cboClub2.Items.Add(txtHomeTeam.Text)
        cboClub2.Items.Add(txtAwayTeam.Text)

        cboClub3.Items.Clear()
        cboClub3.Items.Add(txtHomeTeam.Text)
        cboClub3.Items.Add(txtAwayTeam.Text)

        cboClub4.Items.Clear()
        cboClub4.Items.Add(txtHomeTeam.Text)
        cboClub4.Items.Add(txtAwayTeam.Text)

        cboClub5.Items.Clear()
        cboClub5.Items.Add(txtHomeTeam.Text)
        cboClub5.Items.Add(txtAwayTeam.Text)
    End Sub

    Private Sub cboYellowRed1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYellowRed1.SelectedIndexChanged
        If cboYellowRed1.Text = "Yellow" Then                                                   'Depending on whether the combobox contains "Yellow" or
            cboCode1.Items.Clear()                                                              '"Red", change the contents of the Code combobox
            cboCode1.Items.Add("C1 - Unsporting Behaviour")
            cboCode1.Items.Add("C2 - Shows dissent by Word or Action")
            cboCode1.Items.Add("C3 - Persistently infringing the Laws of the Game")
            cboCode1.Items.Add("C4 - Delays the restart of play")
            cboCode1.Items.Add("C5 - Fails to respect the required distance at a restart")
            cboCode1.Items.Add("C6 - Enters or Re-enters the Field of Play without the Referee's permission")
            cboCode1.Items.Add("C7 - Deliberately leaves the Field of Play without the Referee's permission")
        ElseIf cboYellowRed1.Text = "Red" Then
            cboCode1.Items.Clear()
            cboCode1.Items.Add("S1 - Serious Foul Play")
            cboCode1.Items.Add("S2 - Violent Conduct")
            cboCode1.Items.Add("S3 - Spitting at an opponent or any other person")
            cboCode1.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboCode1.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboCode1.Items.Add("S6 - Use of Offensive or Insulting or abusive Language and or gestures")
            cboCode1.Items.Add("S7 - Receiving a second caution in the same match")
        End If
    End Sub

    Private Sub cboYellowRed2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYellowRed2.SelectedIndexChanged
        If cboYellowRed2.Text = "Yellow" Then                                                   'Depending on whether the combobox contains "Yellow" or
            cboCode2.Items.Clear()                                                              '"Red", change the contents of the Code combobox
            cboCode2.Items.Add("C1 - Unsporting Behaviour")
            cboCode2.Items.Add("C2 - Shows dissent by Word or Action")
            cboCode2.Items.Add("C3 - Persistently infringing the Laws of the Game")
            cboCode2.Items.Add("C4 - Delays the restart of play")
            cboCode2.Items.Add("C5 - Fails to respect the required distance at a restart")
            cboCode2.Items.Add("C6 - Enters or Re-enters the Field of Play without the Referee's permission")
            cboCode2.Items.Add("C7 - Deliberately leaves the Field of Play without the Referee's permission")
        ElseIf cboYellowRed2.Text = "Red" Then
            cboCode2.Items.Clear()
            cboCode2.Items.Add("S1 - Serious Foul Play")
            cboCode2.Items.Add("S2 - Violent Conduct")
            cboCode2.Items.Add("S3 - Spitting at an opponent or any other person")
            cboCode2.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboCode2.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboCode2.Items.Add("S6 - Use of Offensive or Insulting or abusive Language and or gestures")
            cboCode2.Items.Add("S7 - Receiving a second caution in the same match")
        End If
    End Sub

    Private Sub cboYellowRed3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYellowRed3.SelectedIndexChanged
        If cboYellowRed3.Text = "Yellow" Then                                                   'Depending on whether the combobox contains "Yellow" or
            cboCode3.Items.Clear()                                                              '"Red", change the contents of the Code combobox
            cboCode3.Items.Add("C1 - Unsporting Behaviour")
            cboCode3.Items.Add("C2 - Shows dissent by Word or Action")
            cboCode3.Items.Add("C3 - Persistently infringing the Laws of the Game")
            cboCode3.Items.Add("C4 - Delays the restart of play")
            cboCode3.Items.Add("C5 - Fails to respect the required distance at a restart")
            cboCode3.Items.Add("C6 - Enters or Re-enters the Field of Play without the Referee's permission")
            cboCode3.Items.Add("C7 - Deliberately leaves the Field of Play without the Referee's permission")
        ElseIf cboYellowRed3.Text = "Red" Then
            cboCode3.Items.Clear()
            cboCode3.Items.Add("S1 - Serious Foul Play")
            cboCode3.Items.Add("S2 - Violent Conduct")
            cboCode3.Items.Add("S3 - Spitting at an opponent or any other person")
            cboCode3.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboCode3.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboCode3.Items.Add("S6 - Use of Offensive or Insulting or abusive Language and or gestures")
            cboCode3.Items.Add("S7 - Receiving a second caution in the same match")
        End If
    End Sub

    Private Sub cboYellowRed4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYellowRed4.SelectedIndexChanged
        If cboYellowRed4.Text = "Yellow" Then                                                   'Depending on whether the combobox contains "Yellow" or
            cboCode4.Items.Clear()                                                              '"Red", change the contents of the Code combobox
            cboCode4.Items.Add("C1 - Unsporting Behaviour")
            cboCode4.Items.Add("C2 - Shows dissent by Word or Action")
            cboCode4.Items.Add("C3 - Persistently infringing the Laws of the Game")
            cboCode4.Items.Add("C4 - Delays the restart of play")
            cboCode4.Items.Add("C5 - Fails to respect the required distance at a restart")
            cboCode4.Items.Add("C6 - Enters or Re-enters the Field of Play without the Referee's permission")
            cboCode4.Items.Add("C7 - Deliberately leaves the Field of Play without the Referee's permission")
        ElseIf cboYellowRed4.Text = "Red" Then
            cboCode4.Items.Clear()
            cboCode4.Items.Add("S1 - Serious Foul Play")
            cboCode4.Items.Add("S2 - Violent Conduct")
            cboCode4.Items.Add("S3 - Spitting at an opponent or any other person")
            cboCode4.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboCode4.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboCode4.Items.Add("S6 - Use of Offensive or Insulting or abusive Language and or gestures")
            cboCode4.Items.Add("S7 - Receiving a second caution in the same match")
        End If
    End Sub

    Private Sub cboYellowRed5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYellowRed5.SelectedIndexChanged
        If cboYellowRed5.Text = "Yellow" Then                                                   'Depending on whether the combobox contains "Yellow" or
            cboCode5.Items.Clear()                                                              '"Red", change the contents of the Code combobox
            cboCode5.Items.Add("C1 - Unsporting Behaviour")
            cboCode5.Items.Add("C2 - Shows dissent by Word or Action")
            cboCode5.Items.Add("C3 - Persistently infringing the Laws of the Game")
            cboCode5.Items.Add("C4 - Delays the restart of play")
            cboCode5.Items.Add("C5 - Fails to respect the required distance at a restart")
            cboCode5.Items.Add("C6 - Enters or Re-enters the Field of Play without the Referee's permission")
            cboCode5.Items.Add("C7 - Deliberately leaves the Field of Play without the Referee's permission")
        ElseIf cboYellowRed5.Text = "Red" Then
            cboCode5.Items.Clear()
            cboCode5.Items.Add("S1 - Serious Foul Play")
            cboCode5.Items.Add("S2 - Violent Conduct")
            cboCode5.Items.Add("S3 - Spitting at an opponent or any other person")
            cboCode5.Items.Add("S4 - Denying an obvious goal scoring opportunity by deliberately handling the ball")
            cboCode5.Items.Add("S5 - Denying an obvious goal scoring opportunity by an offence punishable by a free kick or penalty kick")
            cboCode5.Items.Add("S6 - Use of Offensive or Insulting or abusive Language and or gestures")
            cboCode5.Items.Add("S7 - Receiving a second caution in the same match")
        End If
    End Sub
End Class