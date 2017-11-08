'Data is retrieved from the file and displayed on the form where the user can then edit it and re-write the file.

Public Class frmPersonalDetails

    Dim SaveButtonClicked, ChangesMade As Boolean

    Private Sub frmPersonalDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SaveButtonClicked = False                                   'Set variables to False
        ChangesMade = False

        txtFANID.Focus()                                            'Move cursor to textbox

        'Open PersonalDetails file in Input Mode
        FileOpen(1, "PersonalDetails.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, PersonalDetails(1).FANID)                      'Until end of the file is reached,
            Input(1, PersonalDetails(1).Name)                       'read all data from the file into
            Input(1, PersonalDetails(1).DateofBirth)                'the system
            Input(1, PersonalDetails(1).Gender)
            Input(1, PersonalDetails(1).Address)
            Input(1, PersonalDetails(1).TelephoneNo)
            Input(1, PersonalDetails(1).MobileNo)
            Input(1, PersonalDetails(1).EmailAddress)
            Input(1, PersonalDetails(1).AffiliationNo)
            Input(1, PersonalDetails(1).CountyFA)
            Input(1, PersonalDetails(1).PromotionReq)
            Input(1, PersonalDetails(1).CurrentLevel)
        End While

        txtFANID.Text = PersonalDetails(1).FANID                    'Contents of relevant textbox
        txtName.Text = PersonalDetails(1).Name                      '= contents of array
        mskDateofBirth.Text = PersonalDetails(1).DateofBirth

        If PersonalDetails(1).Gender = "M" Then                     'Depending on contents of Gender
            radMale.Checked = True                                  'check the relevent textbox
        ElseIf PersonalDetails(1).Gender = "F" Then
            radFemale.Checked = True
        End If

        txtAddress.Text = PersonalDetails(1).Address                'Contents of relevant textbox
        txtTelephoneNo.Text = PersonalDetails(1).TelephoneNo        '= contents of array
        txtMobileNo.Text = PersonalDetails(1).MobileNo
        txtEmailAddress.Text = PersonalDetails(1).EmailAddress
        txtAffiliationNo.Text = PersonalDetails(1).AffiliationNo
        txtCountyFA.Text = PersonalDetails(1).CountyFA

        If PersonalDetails(1).PromotionReq = True Then              'Depending on contents of PromotionReq
            chkPromotion.Checked = True                             'check the relevent checkbox
        Else
            chkPromotion.Checked = False
        End If

        If PersonalDetails(1).CurrentLevel = "1" Then               'Depending on contents of CurrentLevel
            rad1.Checked = True                                     'check the relevent radiobutton
        ElseIf PersonalDetails(1).CurrentLevel = "2" Then
            rad2.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "3" Then
            rad3.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "4" Then
            rad4.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "5" Then
            rad5.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "6" Then
            rad6.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "7" Then
            rad7.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "8" Then
            rad8.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "9" Then
            rad9.Checked = True
        ElseIf PersonalDetails(1).CurrentLevel = "10" Then
            rad10.Checked = True
        End If

        FileClose(1)                                                    'Close the file
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveButtonClicked = True                    'Set variable to True


        If txtFANID.Text = "" Then                      'Presence checks for
            MsgBox("Please enter your FAN")             'textboxes and radio
        End If                                          'buttons

        If txtFANID.Text < 1 Or txtFANID.Text > 99999999 Then   'Range check for
            MsgBox("Please enter a valid FAN")                  'FANID
        End If

        If txtName.Text = "" Then
            MsgBox("Please enter a Name")
        End If

        If mskDateofBirth.Text = "  /  /" Then
            MsgBox("Please enter a Date of Birth")
        End If

        If radMale.Checked = False And radFemale.Checked = False Then
            MsgBox("Please choose a Gender")
        End If

        If txtAddress.Text = "" Then
            MsgBox("Please enter an Address")
        End If

        If txtTelephoneNo.Text = "" Then
            MsgBox("Please enter a Telephone Number")
        End If

        Dim TelLen As Integer = Len(txtTelephoneNo.Text)    'Length check for
        If TelLen <> 11 Then                                'telephone number
            MsgBox("Please enter a valid Telephone Number")
        End If

        If txtMobileNo.Text = "" Then
            MsgBox("Please enter a Mobile Number")
        End If

        Dim MobLen As Integer = Len(txtMobileNo.Text)       'Length check for
        If MobLen <> 11 Then                                'mobile number
            MsgBox("Please enter a valid Mobile Number")
        End If

        If txtEmailAddress.Text = "" Then
            MsgBox("Please enter an Email Address")
        End If

        If txtAffiliationNo.Text = "" Then
            MsgBox("Please enter an Affiliation Number")
        End If

        If txtCountyFA.Text = "" Then
            MsgBox("Please enter a County FA")
        End If

        'Presence check for a checked radio button
        If rad1.Checked = False And rad2.Checked = False And rad3.Checked = False _
            And rad4.Checked = False And rad5.Checked = False And _
            rad6.Checked = False And rad7.Checked = False And rad8.Checked = False _
            And rad9.Checked = False And rad10.Checked = False Then
            MsgBox("Please choose your Current Level")
        End If

        PersonalDetails(1).FANID = txtFANID.Text                        'Write textbox contents
        PersonalDetails(1).Name = txtName.Text                          'into the array of records
        PersonalDetails(1).DateofBirth = mskDateofBirth.Text
        PersonalDetails(1).Address = txtAddress.Text
        PersonalDetails(1).TelephoneNo = txtTelephoneNo.Text
        PersonalDetails(1).MobileNo = txtMobileNo.Text
        PersonalDetails(1).EmailAddress = txtEmailAddress.Text
        PersonalDetails(1).AffiliationNo = txtAffiliationNo.Text
        PersonalDetails(1).CountyFA = txtCountyFA.Text

        If radMale.Checked = True Then                  'Depending on which radiobutton
            PersonalDetails(1).Gender = "M"             'is checked, change Gender to "M"
        Else                                            'or "F"
            PersonalDetails(1).Gender = "F"
        End If

        If chkPromotion.Checked = True Then             'Set PromotionReq to true or false
            PersonalDetails(1).PromotionReq = True      'depending on whether the checkbox
        Else                                            'is checked
            PersonalDetails(1).PromotionReq = False
        End If

        If rad1.Checked = True Then                     'Depending on which radiobutton
            PersonalDetails(1).CurrentLevel = "1"       'is checked, change CurrentLevel
        ElseIf rad2.Checked = True Then
            PersonalDetails(1).CurrentLevel = "2"
        ElseIf rad3.Checked = True Then
            PersonalDetails(1).CurrentLevel = "3"
        ElseIf rad4.Checked = True Then
            PersonalDetails(1).CurrentLevel = "4"
        ElseIf rad5.Checked = True Then
            PersonalDetails(1).CurrentLevel = "5"
        ElseIf rad6.Checked = True Then
            PersonalDetails(1).CurrentLevel = "6"
        ElseIf rad7.Checked = True Then
            PersonalDetails(1).CurrentLevel = "7"
        ElseIf rad8.Checked = True Then
            PersonalDetails(1).CurrentLevel = "8"
        ElseIf rad9.Checked = True Then
            PersonalDetails(1).CurrentLevel = "9"
        ElseIf rad10.Checked = True Then
            PersonalDetails(1).CurrentLevel = "10"
        End If

        'Open PersonalDetails file in Output mode
        FileOpen(1, "PersonalDetails.txt", OpenMode.Output)
        WriteLine(1, PersonalDetails(1).FANID)              'Write variables to the file
        WriteLine(1, PersonalDetails(1).Name)
        WriteLine(1, PersonalDetails(1).DateofBirth)
        WriteLine(1, PersonalDetails(1).Gender)
        WriteLine(1, PersonalDetails(1).Address)
        WriteLine(1, PersonalDetails(1).TelephoneNo)
        WriteLine(1, PersonalDetails(1).MobileNo)
        WriteLine(1, PersonalDetails(1).EmailAddress)
        WriteLine(1, PersonalDetails(1).AffiliationNo)
        WriteLine(1, PersonalDetails(1).CountyFA)
        WriteLine(1, PersonalDetails(1).PromotionReq)
        WriteLine(1, PersonalDetails(1).CurrentLevel)
        FileClose(1)                                        'Close the file
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If chkChanges.Checked = True Then           'Depending on whether the checkbox is checked
            ChangesMade = True                      'set ChangesMade to True or False
        Else
            ChangesMade = False
        End If

        If SaveButtonClicked = False And ChangesMade = True Then        'If the conditions are met
            MsgBox("Are you sure? Please save any changes")             'output message or close the
        ElseIf SaveButtonClicked = False And ChangesMade = False Then   'form
            Me.Close()
        Else
            Me.Close()
        End If

        chkPromotion.Checked = False        'Uncheck both checkboxes
        chkChanges.Checked = False
    End Sub
End Class