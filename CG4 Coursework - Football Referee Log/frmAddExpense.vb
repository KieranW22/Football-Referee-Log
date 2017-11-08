'Data can be inserted on the form and then written to the file

Public Class frmAddExpense

    'Declare variables as data types
    Dim Count As Integer

    Private Sub frmAddExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTitle.Focus()     'Move pointer to textbox
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        FileOpen(1, "Expenses.txt", OpenMode.Input)     'Open Expenses file in read-only mode
        While Not EOF(1)
            Input(1, Expense(Count).ExpenseID)          'Until end of the file is reached,
            Input(1, Expense(Count).Title)              'read all data from the file into
            Input(1, Expense(Count).Description)        'the system
            Input(1, Expense(Count).Amount)
            Input(1, Expense(Count).DateOfExpense)
        End While

        Expense(Count).ExpenseID = Expense(Count).ExpenseID + 1     'Add 1 to ExpenseID
        FileClose(1)                                                'Close the file

        Expense(Count).Title = txtTitle.Text                    'Write textbox contents
        Expense(Count).Description = txtDescription.Text        'into the array of records
        Expense(Count).Amount = txtAmount.Text
        Expense(Count).DateOfExpense = txtDate.Text

        FileOpen(1, "Expenses.txt", OpenMode.Append)    'Open Expenses File in append mode
        WriteLine(1, Expense(Count).ExpenseID)          'Write all variables to file
        WriteLine(1, Expense(Count).Title)
        WriteLine(1, Expense(Count).Description)
        WriteLine(1, Expense(Count).Amount)
        WriteLine(1, Expense(Count).DateOfExpense)
        FileClose(1)                                    'Close the file

        txtTitle.Clear()                'Clear all textboxes
        txtDescription.Clear()
        txtAmount.Clear()
        txtDate.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub
End Class