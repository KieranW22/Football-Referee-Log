'Data is retrieved from the file, then the user can select a record to be deleted and rewrite the file without it

Public Class frmDeleteExpense

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean
    Dim ItemtobeDeleted As Integer

    Private Sub frmDeleteExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open Expenses file in read-only mode
        FileOpen(1, "Expenses.txt", OpenMode.Input)
        Count = 0
        While Not EOF(1)                                    'Until end of file is reached
            Count = Count + 1                               'Add 1 to Count
            Input(1, Expense(Count).ExpenseID)              'Read variables stored in the file,
            Input(1, Expense(Count).Title)                  'into the system
            Input(1, Expense(Count).Description)
            Input(1, Expense(Count).Amount)
            Input(1, Expense(Count).DateOfExpense)

            'Insert Expense variables for each record into the listbox
            lstChooseExpense.Items.Add(Expense(Count).ExpenseID & "-" & Expense(Count).Title & "-" & Expense(Count).Description & "-" & "£" & Expense(Count).Amount & "-" & Expense(Count).DateOfExpense)
        End While

        FileClose(1)
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
            If lstChooseExpense.SelectedItem = Expense(Count).ExpenseID & "-" & Expense(Count).Title & "-" & Expense(Count).Description & "-" & "£" & Expense(Count).Amount & "-" & Expense(Count).DateOfExpense Then
                'If Expense in listbox = Expense in record do:
                Dim information = lstChooseExpense.SelectedItem         'Information = String in listbox
                Dim fields = information.Split("-")                     'Split the string at each " - "
                Expense(Count).ExpenseID = fields(0).trim               'Contents of array = each field
                Expense(Count).Title = fields(1).Trim()
                Expense(Count).Description = fields(2).Trim()
                Expense(Count).Amount = fields(3).Trim()
                Expense(Count).DateOfExpense = fields(4).Trim()
                InformationFound = True                                 'Rogue value stops code running
                ItemtobeDeleted = Count                                 'Find the address of the item to be deleted
            End If
        End While
    End Sub

    Private Sub btnDeleteExpense_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteExpense.Click
        'Open Expenses file in Output Mode to overwrite
        FileOpen(1, "Expenses.txt", OpenMode.Output)
        Count = 0                                           'Add 1 to Count
        While Count <> NumberofItemsinArray - 1             'While Count is not equal to NoIiA do:
            Count = Count + 1                               'Add 1 to number of entries
            If Count <> ItemtobeDeleted Then                'Skip the selected record to remove it from file
                WriteLine(1, Expense(Count).ExpenseID)      'Write variables to the file
                WriteLine(1, Expense(Count).Title)
                WriteLine(1, Expense(Count).Description)
                WriteLine(1, Expense(Count).Amount)
                WriteLine(1, Expense(Count).DateOfExpense)
            End If
        End While

        FileClose(1)                    'Close the file

        lstChooseExpense.Items.RemoveAt(lstChooseExpense.SelectedIndex)     'Remove record from listbox
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub
End Class