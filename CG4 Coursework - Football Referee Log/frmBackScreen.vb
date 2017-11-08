'The Back Screen stays open at all times and forms being opened are docked inside it

Public Class frmBackScreen

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()      'Close the application
        End
    End Sub

    Private Sub PersonalDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PersonalDetailsToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmPersonalDetails.MdiParent = Me               'Open PersonalDetails form
        frmPersonalDetails.Dock = DockStyle.Fill
        frmPersonalDetails.Show()
    End Sub

    Private Sub ViewMatchDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewMatchDetailsToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmViewMatchDetails.MdiParent = Me              'Open ViewMatchDetails form
        frmViewMatchDetails.Dock = DockStyle.Fill
        frmViewMatchDetails.Show()
    End Sub

    Private Sub EnterMatchDetailsToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AddMatchDetailsToolStripMenuItem1.Click
        Call HideAllForms()                             'Run procedure
        frmAddMatchDetails.MdiParent = Me               'Open AddMatchDetails form
        frmAddMatchDetails.Dock = DockStyle.Fill
        frmAddMatchDetails.Show()
    End Sub

    Private Sub EditMatchDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditMatchDetailsToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmEditMatchDetails.MdiParent = Me              'Open EditMatchDetails form
        frmEditMatchDetails.Dock = DockStyle.Fill
        frmEditMatchDetails.Show()
    End Sub

    Private Sub DeleteMatchDetailsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteMatchDetailsToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmDeleteMatchDetails.MdiParent = Me            'Open DeleteMatchDetails form
        frmDeleteMatchDetails.Dock = DockStyle.Fill
        frmDeleteMatchDetails.Show()
    End Sub

    Private Sub ViewReportsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewReportsToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmViewReports.MdiParent = Me                   'Open ViewReports form
        frmViewReports.Dock = DockStyle.Fill
        frmViewReports.Show()
    End Sub

    Private Sub AddReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddReportToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmAddReport.MdiParent = Me                     'Open AddReport form
        frmAddReport.Dock = DockStyle.Fill
        frmAddReport.Show()
    End Sub

    Private Sub EditReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditReportToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmEditReport.MdiParent = Me                    'Open EditReport form
        frmEditReport.Dock = DockStyle.Fill
        frmEditReport.Show()
    End Sub

    Private Sub DeleteReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteReportToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmDeleteMatchDetails.MdiParent = Me            'Open DeleteMatchDetails form
        frmDeleteMatchDetails.Dock = DockStyle.Fill
        frmDeleteMatchDetails.Show()
    End Sub

    Private Sub EmailReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EmailReportToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmEmailReport.MdiParent = Me                   'Open Email Report form
        frmEmailReport.Dock = DockStyle.Fill
        frmEmailReport.Show()
    End Sub

    Private Sub ViewExpensesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewExpensesToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmViewExpenses.MdiParent = Me                  'Open ViewExpenses form
        frmViewExpenses.Dock = DockStyle.Fill
        frmViewExpenses.Show()
    End Sub

    Private Sub AddExpenseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddExpenseToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmAddExpense.MdiParent = Me                    'Open AddExpense form
        frmAddExpense.Dock = DockStyle.Fill
        frmAddExpense.Show()
    End Sub

    Private Sub EditExpenseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditExpenseToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmEditExpense.MdiParent = Me                   'Open EditExpense form
        frmEditExpense.Dock = DockStyle.Fill
        frmEditExpense.Show()
    End Sub

    Private Sub DeleteExpenseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteExpenseToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmDeleteExpense.MdiParent = Me                 'Open DeleteExpense form
        frmDeleteExpense.Dock = DockStyle.Fill
        frmDeleteExpense.Show()
    End Sub

    Private Sub ViewAddressBookToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ViewAddressBookToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmAddressBook.MdiParent = Me                   'Open AddressBook form
        frmAddressBook.Dock = DockStyle.Fill
        frmAddressBook.Show()
    End Sub

    Private Sub AddContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddContactToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmAddContact.MdiParent = Me                    'Open AddContact form
        frmAddContact.Dock = DockStyle.Fill
        frmAddContact.Show()
    End Sub

    Private Sub EditContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditContactToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmEditContact.MdiParent = Me                   'Open EditContact form
        frmEditContact.Dock = DockStyle.Fill
        frmEditContact.Show()
    End Sub

    Private Sub DeleteContactToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DeleteContactToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmDeleteContact.MdiParent = Me                 'Open DeleteContact form
        frmDeleteContact.Dock = DockStyle.Fill
        frmDeleteContact.Show()
    End Sub

    Private Sub MainMenuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem.Click
        Call HideAllForms()                             'Run procedure
        frmMainMenu.MdiParent = Me                      'Open MainMenu form
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
    End Sub

    Private Sub frmBackScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        'Loop through all of the form's controls looking
        'for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                'Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                'Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                'Catch and ignore the error if casting failed.
            End Try
        Next

        frmMainMenu.MdiParent = Me                      'Open MainMenu form
        frmMainMenu.Dock = DockStyle.Fill
        frmMainMenu.Show()
    End Sub

    Private Sub HideAllForms()
        frmMainMenu.Close()                 'Close all forms

        frmPersonalDetails.Close()

        frmViewMatchDetails.Close()
        frmAddMatchDetails.Close()
        frmEditMatchDetails.Close()
        frmDeleteMatchDetails.Close()

        frmViewReports.Close()
        frmAddReport.Close()
        frmEditReport.Close()
        frmDeleteReport.Close()
        frmEmailReport.Close()

        frmViewExpenses.Close()
        frmAddExpense.Close()
        frmEditExpense.Close()
        frmDeleteExpense.Close()

        frmAddressBook.Close()
        frmAddContact.Close()
        frmEditContact.Close()
        frmDeleteContact.Close()
    End Sub
End Class
