'In each subroutine, the BackScreen is set as the parent form and the form being opened is docked inside it.

Public Class frmMainMenu
    Private Sub btnPersonalDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonalDetails.Click
        frmPersonalDetails.MdiParent = frmBackScreen        'set the form's parent as frmBackScreen
        frmPersonalDetails.Dock = DockStyle.Fill            'set the dock style to Fill
        frmPersonalDetails.Show()                           'show the form
    End Sub

    Private Sub btnViewMatchDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnViewMatchDetails.Click
        frmViewMatchDetails.MdiParent = frmBackScreen       'set the form's parent as frmBackScreen
        frmViewMatchDetails.Dock = DockStyle.Fill           'set the dock style to Fill
        frmViewMatchDetails.Show()                          'show the form
    End Sub

    Private Sub btnAddMatchDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnAddMatchDetails.Click
        frmAddMatchDetails.MdiParent = frmBackScreen        'set the form's parent as frmBackScreen
        frmAddMatchDetails.Dock = DockStyle.Fill            'set the dock style to Fill
        frmAddMatchDetails.Show()                           'show the form
    End Sub

    Private Sub btnEditMatchDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnEditMatchDetails.Click
        frmEditMatchDetails.MdiParent = frmBackScreen       'set the form's parent as frmBackScreen
        frmEditMatchDetails.Dock = DockStyle.Fill           'set the dock style to Fill
        frmEditMatchDetails.Show()                          'show the form
    End Sub

    Private Sub btnDeleteMatchDetails_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteMatchDetails.Click
        frmDeleteMatchDetails.MdiParent = frmBackScreen     'set the form's parent as frmBackScreen
        frmDeleteMatchDetails.Dock = DockStyle.Fill         'set the dock style to Fill
        frmDeleteMatchDetails.Show()                        'show the form
    End Sub

    Private Sub btnViewReports_Click(sender As System.Object, e As System.EventArgs) Handles btnViewReports.Click
        frmViewReports.MdiParent = frmBackScreen            'set the form's parent as frmBackScreen
        frmViewReports.Dock = DockStyle.Fill                'set the dock style to Fill
        frmViewReports.Show()                               'show the form
    End Sub

    Private Sub btnAddReport_Click(sender As System.Object, e As System.EventArgs) Handles btnAddReport.Click
        frmAddReport.MdiParent = frmBackScreen              'set the form's parent as frmBackScreen
        frmAddReport.Dock = DockStyle.Fill                  'set the dock style to Fill
        frmAddReport.Show()                                 'show the form
    End Sub

    Private Sub btnEditReport_Click(sender As System.Object, e As System.EventArgs) Handles btnEditReport.Click
        frmEditReport.MdiParent = frmBackScreen             'set the form's parent as frmBackScreen
        frmEditReport.Dock = DockStyle.Fill                 'set the dock style to Fill
        frmEditReport.Show()                                'show the form
    End Sub

    Private Sub btnDeleteReport_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteReport.Click
        frmDeleteReport.MdiParent = frmBackScreen           'set the form's parent as frmBackScreen
        frmDeleteReport.Dock = DockStyle.Fill               'set the dock style to Fill
        frmDeleteReport.Show()                              'show the form
    End Sub

    Private Sub btnEmailReport_Click(sender As System.Object, e As System.EventArgs) Handles btnEmailReport.Click
        frmEmailReport.MdiParent = frmBackScreen            'set the form's parent as frmBackScreen
        frmEmailReport.Dock = DockStyle.Fill                'set the dock style to Fill
        frmEmailReport.Show()                               'show the form
    End Sub

    Private Sub btnViewExpenses_Click(sender As System.Object, e As System.EventArgs) Handles btnViewExpenses.Click
        frmViewExpenses.MdiParent = frmBackScreen           'set the form's parent as frmBackScreen
        frmViewExpenses.Dock = DockStyle.Fill               'set the dock style to Fill
        frmViewExpenses.Show()                              'show the form
    End Sub

    Private Sub btnAddExpense_Click(sender As System.Object, e As System.EventArgs) Handles btnAddExpense.Click
        frmAddExpense.MdiParent = frmBackScreen             'set the form's parent as frmBackScreen
        frmAddExpense.Dock = DockStyle.Fill                 'set the dock style to Fill
        frmAddExpense.Show()                                'show the form
    End Sub

    Private Sub btnEditExpense_Click(sender As System.Object, e As System.EventArgs) Handles btnEditExpense.Click
        frmEditExpense.MdiParent = frmBackScreen            'set the form's parent as frmBackScreen
        frmEditExpense.Dock = DockStyle.Fill                'set the dock style to Fill
        frmEditExpense.Show()                               'show the form
    End Sub

    Private Sub btnDeleteExpense_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteExpense.Click
        frmDeleteExpense.MdiParent = frmBackScreen          'set the form's parent as frmBackScreen
        frmDeleteExpense.Dock = DockStyle.Fill              'set the dock style to Fill
        frmDeleteExpense.Show()                             'show the form
    End Sub

    Private Sub btnAddressBook_Click(sender As System.Object, e As System.EventArgs) Handles btnAddressBook.Click
        frmAddressBook.MdiParent = frmBackScreen            'set the form's parent as frmBackScreen
        frmAddressBook.Dock = DockStyle.Fill                'set the dock style to Fill
        frmAddressBook.Show()                               'show the form
    End Sub

    Private Sub btnAddContact_Click(sender As System.Object, e As System.EventArgs) Handles btnAddContact.Click
        frmAddContact.MdiParent = frmBackScreen             'set the form's parent as frmBackScreen
        frmAddContact.Dock = DockStyle.Fill                 'set the dock style to Fill
        frmAddContact.Show()                                'show the form
    End Sub

    Private Sub btnEditContact_Click(sender As System.Object, e As System.EventArgs) Handles btnEditContact.Click
        frmEditContact.MdiParent = frmBackScreen            'set the form's parent as frmBackScreen
        frmEditContact.Dock = DockStyle.Fill                'set the dock style to Fill
        frmEditContact.Show()                               'show the form
    End Sub

    Private Sub btnDeleteContact_Click(sender As System.Object, e As System.EventArgs) Handles btnDeleteContact.Click
        frmDeleteContact.MdiParent = frmBackScreen          'set the form's parent as frmBackScreen
        frmDeleteContact.Dock = DockStyle.Fill              'set the dock style to Fill
        frmDeleteContact.Show()                             'show the form
    End Sub
End Class