'Data is retrieved from the file and displayed on the form

Public Class frmViewExpenses

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmViewExpenses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseExpense.Focus()    'Place cursor on lstChooseExpense

        'Open file for Expenses in read-only mode       
        FileOpen(1, "Expenses.txt", OpenMode.Input)
        Count = 0                                       'Set variable 'Count'
        While Not EOF(1)                                'Run until the end of the file is reached
            Count = Count + 1                           'Add 1 to number of entries
            Input(1, Expense(Count).ExpenseID)
            Input(1, Expense(Count).Title)
            Input(1, Expense(Count).Description)
            Input(1, Expense(Count).Amount)
            Input(1, Expense(Count).DateOfExpense)

            'Add the stored variables ExpenseID & DateofExpense into the listbox
            lstChooseExpense.Items.Add(Expense(Count).ExpenseID & " " & Expense(Count).DateOfExpense)
        End While

        FileClose(1)                    'Close the file
        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseExpense_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseExpense.SelectedIndexChanged
        InformationFound = False
        Count = 0

        'Run while the number of entries into the array is less than the number of lines in the array
        'or all information in the array is found
        While Count < NumberofItemsinArray And InformationFound = False
            Count = Count + 1   'Add 1 to number of entries
            'If ExpenseID & DateofExpense in listbox = ExpenseID & DateofExpense in array
            If lstChooseExpense.SelectedItem = Expense(Count).ExpenseID & " " & Expense(Count).DateOfExpense Then
                txtTitle.Text = Expense(Count).Title                'Contents of relevant textbox
                txtDescription.Text = Expense(Count).Description    '= contents of array
                txtAmount.Text = "£" & Expense(Count).Amount
                txtDate.Text = Expense(Count).DateOfExpense
                InformationFound = True                     'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class