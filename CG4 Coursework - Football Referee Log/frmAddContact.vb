'Data can be inserted on the form and then written to the file

Public Class frmAddContact

    'Declare variables as data types
    Dim Count As Integer

    Private Sub frmAddContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Focus()     'Move pointer to textbox
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Open Contacts file in read-only mode
        FileOpen(1, "Contacts.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, Contact(Count).ContactID)      'Until end of the file is reached,
            Input(1, Contact(Count).Name)           'read all data from the file into
            Input(1, Contact(Count).Position)       'the system
            Input(1, Contact(Count).Association)
            Input(1, Contact(Count).Email)
            Input(1, Contact(Count).TelephoneNo)
            Input(1, Contact(Count).MobileNo)
        End While

        Contact(Count).ContactID = Contact(Count).ContactID + 1 'Add 1 to ContactID

        FileClose(1)    'Close the file

        Contact(Count).Name = txtName.Text                  'Write textbox contents
        Contact(Count).Position = txtPosition.Text          'into the array of records
        Contact(Count).Association = txtAssociation.Text
        Contact(Count).Email = txtEmail.Text
        Contact(Count).TelephoneNo = txtTelephone.Text
        Contact(Count).MobileNo = txtMobile.Text

        'Open Contacts File in append mode
        FileOpen(1, "Contacts.txt", OpenMode.Append)
        WriteLine(1, Contact(Count).ContactID)          'Write all variables into the file
        WriteLine(1, Contact(Count).Name)
        WriteLine(1, Contact(Count).Position)
        WriteLine(1, Contact(Count).Association)
        WriteLine(1, Contact(Count).Email)
        WriteLine(1, Contact(Count).TelephoneNo)
        WriteLine(1, Contact(Count).MobileNo)
        FileClose(1)                                    'Close the file

        txtName.Clear()                                 'Clear all textboxes
        txtPosition.Clear()
        txtAssociation.Clear()
        txtEmail.Clear()
        txtTelephone.Clear()
        txtMobile.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()      'Close the form
    End Sub
End Class