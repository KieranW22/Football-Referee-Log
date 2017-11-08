'Data is retrieved from the file and displayed on the form

Public Class frmAddressBook

    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmAddressBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseContact.Focus()    'Place cursor on lstChooseExpense

        'Open file for Contacts in read-only mode       
        FileOpen(1, "Contacts.txt", OpenMode.Input)
        Count = 0                                       'Set variable 'Count'
        While Not EOF(1)                                'Run until the end of the file is reached
            Count = Count + 1                           'Add 1 to number of entries
            Input(1, Contact(Count).ContactID)
            Input(1, Contact(Count).Name)
            Input(1, Contact(Count).Position)
            Input(1, Contact(Count).Association)
            Input(1, Contact(Count).Email)
            Input(1, Contact(Count).TelephoneNo)
            Input(1, Contact(Count).MobileNo)
            'Add the stored variables ContactID & Name into the listbox
            lstChooseContact.Items.Add(Contact(Count).ContactID & " " & Contact(Count).Name)
        End While

        FileClose(1)                    'Close the file

        NumberofItemsinArray = Count    'Variable 'NumberofItemsinArray'= the number of entries
        Count = 0                       'Reset Variable 'Count'
        InformationFound = False        'Reset Variable 'InformationFound'
    End Sub

    Private Sub lstChooseContact_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChooseContact.SelectedIndexChanged
        InformationFound = False
        Count = 0

        'Run while the number of entries into the array is less than the number of lines in the array_
        'or all information in the array is found
        While Count < NumberofItemsinArray And InformationFound = False
            Count = Count + 1   'Add 1 to number of entries
            'If ContactID & Name in listbox = ContactID & Name in array
            If lstChooseContact.SelectedItem = Contact(Count).ContactID & " " & Contact(Count).Name Then
                txtName.Text = Contact(Count).Name                      'Insert variables into
                txtPosition.Text = Contact(Count).Position              'textboxes
                txtAssociation.Text = Contact(Count).Association
                txtEmail.Text = Contact(Count).Email
                txtTelephone.Text = Contact(Count).TelephoneNo
                txtMobile.Text = Contact(Count).MobileNo
                InformationFound = True                     'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class