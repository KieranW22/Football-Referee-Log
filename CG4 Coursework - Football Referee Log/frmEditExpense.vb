'Data is retrieved from the file and displayed on the form where the user can then edit it and re-write the file

Public Class frmEditExpense

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmEditExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseExpense.Focus()

        FileOpen(1, "Expenses.txt", OpenMode.Input)         'Open Expenses file in read-only mode
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, Expense(Count).ExpenseID)              'Read variables stored in the file,
            Input(1, Expense(Count).Title)                  'into the system
            Input(1, Expense(Count).Description)
            Input(1, Expense(Count).Amount)
            Input(1, Expense(Count).DateOfExpense)

            'Insert ExpenseID & Title for each record into the listbox
            lstChooseExpense.Items.Add(Expense(Count).ExpenseID & " " & Expense(Count).Title)
        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseExpense_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseExpense.SelectedIndexChanged
        InformationFound = False
        Count = 0

        While Count < NumberofItemsinArray And InformationFound = False
            'Run the following until conditions above apply
            Count = Count + 1
            If lstChooseExpense.SelectedItem = Expense(Count).ExpenseID & " " & Expense(Count).Title Then
                'If ExpenseID & Title in listbox = ExpenseID & Title in record do:
                txtTitle.Text = Expense(Count).Title                'Contents of relevant textbox
                txtDescription.Text = Expense(Count).Description    '= contents of array
                txtAmount.Text = Expense(Count).Amount
                txtDate.Text = Expense(Count).DateOfExpense
                InformationFound = True                             'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Expense(Count).Title = txtTitle.Text                    'Write textbox contents
        Expense(Count).Description = txtDescription.Text        'into the array of records
        Expense(Count).Amount = txtAmount.Text
        Expense(Count).DateOfExpense = txtDate.Text

        'Open Expenses file in Output Mode to overwrite
        FileOpen(1, "Expenses.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray         'While Count is not equal to NoIiA do:
            Count = Count + 1                       'Add 1 to number of entries
            WriteLine(1, Expense(Count).ExpenseID)  'Write all variables into the file
            WriteLine(1, Expense(Count).Title)
            WriteLine(1, Expense(Count).Description)
            WriteLine(1, Expense(Count).Amount)
            WriteLine(1, Expense(Count).DateOfExpense)
        End While

        FileClose(1)                    'Close the file

        txtTitle.Clear()                'Clear all textboxes
        txtDescription.Clear()
        txtAmount.Clear()
        txtDate.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class