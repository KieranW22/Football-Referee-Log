'Data can be inserted in to an email message then sent to a recipient

Imports System.Net.Mail     'Import Mail Class

Public Class frmEmailReport

    'Declare variables as data type
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmEmailReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseReport.Focus()    'Place cursor on lstChooseMatch

        'Open file for Reports in read-only mode       
        FileOpen(1, "Reports.txt", OpenMode.Input)
        Count = 0                                       'Set variable 'Count'
        While Not EOF(1)                                'Run until the end of the file is reached
            Count = Count + 1                           'Add 1 to number of entries
            Input(1, Report(Count).ReportID)            'Read variables stroed in the file,
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

            'Add the stored variables ReportID & DateofReport into the listbox
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

        'Run while the number of entries into the array is less than the number of lines in the array_
        'or all information in the array is found
        While Count < NumberofItemsinArray And InformationFound = False
            Count = Count + 1   'Add 1 to number of entries
            'If ReportID & DateofReport in listbox = ReportID & DateofReport in array
            If lstChooseReport.SelectedItem = Report(Count).ReportID & " " & Report(Count).DateofReport Then
                'set textbox text to:
                txtMessage.Text = ("The match was played between " & Report(Count).HomeTeam & " and " & Report(Count).AwayTeam & " in the " & _
                    Report(Count).Competition & " played at " & Report(Count).PlayedAt & " on " & Report(Count).DateofReport & "." & Environment.NewLine & _
                    Environment.NewLine & "I have to report that " & Report(Count).ReportThat & " " & Report(Count).TypeOfOffence & ", " & Report(Count).Name & _
                    " of " & Report(Count).Club & "." & Environment.NewLine & Environment.NewLine & "Assistant Referees present were " _
                    & Report(Count).AssistantReferees & "." & Environment.NewLine & Environment.NewLine & "I am reporting under " & Report(Count).Law12Section _
                    & " the incident which came under my notice as follows: " & Report(Count).Incident)
                InformationFound = True                     'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False       'Set credentials to user entered data
            Smtp_Server.Credentials = New Net.NetworkCredential(txtUsername.Text, txtPassword.Text)
            Smtp_Server.Port = 587                          'Set SMTP port
            Smtp_Server.EnableSsl = True                    'Enable security
            If radGmail.Checked = True Then                 'Depending on which radio button is checked,
                Smtp_Server.Host = "smtp.gmail.com"         'change the SMTP Server Host
            ElseIf radOutlook.Checked = True Then
                Smtp_Server.Host = "smtp.live.com"
            ElseIf rad365.Checked = True Then
                Smtp_Server.Host = "smtp.office365.com"
            End If

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(txtFrom.Text)     'From address = Text in From textbox
            e_mail.To.Add(txtTo.Text)                       'To address = Text in To textbox
            e_mail.Subject = txtSubject.Text                'Email Subject = Text in Subject textbox
            e_mail.IsBodyHtml = False
            e_mail.Body = txtMessage.Text                   'Email Body = Text in Message textbox
            Smtp_Server.Send(e_mail)                        'Send Email
            MsgBox("Report Sent")                           'Output "Report Sent"
        Catch error_t As Exception
            MsgBox(error_t.ToString)                        'Output error message
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsername.TextChanged
        txtFrom.Text = txtUsername.Text         'As Username text changes, change From text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtTo.Clear()           'Clear all textboxes
        txtSubject.Clear()
        txtMessage.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()              'Close the form
    End Sub
End Class