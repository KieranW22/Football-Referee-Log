'Data is retrieved from the file and displayed on the form where the user can then edit it and re-write the file

Public Class frmEditContact

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean

    Private Sub frmEditContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstChooseContact.Focus()            'Move cursor to listbox

        FileOpen(1, "Contacts.txt", OpenMode.Input)         'Open Contacts file in read-only mode
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, Contact(Count).ContactID)              'Read variables stored in the file,
            Input(1, Contact(Count).Name)                  'into the system
            Input(1, Contact(Count).Position)
            Input(1, Contact(Count).Association)
            Input(1, Contact(Count).Email)
            Input(1, Contact(Count).TelephoneNo)
            Input(1, Contact(Count).MobileNo)

            'Insert ContactID & Name for each record into the listbox
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
        While Count < NumberofItemsinArray And InformationFound = False
            'Run the following until conditions above apply
            Count = Count + 1
            If lstChooseContact.SelectedItem = Contact(Count).ContactID & " " & Contact(Count).Name Then
                'If ContactID & Name in listbox = ContactID & Name in record do:
                txtName.Text = Contact(Count).Name                  'Contents of relevant textbox
                txtPosition.Text = Contact(Count).Position          '= contents of array
                txtAssociation.Text = Contact(Count).Association
                txtEmail.Text = Contact(Count).Email
                txtTelephone.Text = Contact(Count).TelephoneNo
                txtMobile.Text = Contact(Count).MobileNo
                InformationFound = True                             'Rogue value stops code running
            End If
        End While
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Contact(Count).Name = txtName.Text                  'Write textbox contents
        Contact(Count).Position = txtPosition.Text          'into the array of records
        Contact(Count).Association = txtAssociation.Text
        Contact(Count).Email = txtEmail.Text
        Contact(Count).TelephoneNo = txtTelephone.Text
        Contact(Count).MobileNo = txtMobile.Text

        'Open Contacts file in Output Mode to overwrite
        FileOpen(1, "Contacts.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray             'While Count is not equal to NoIiA do:
            Count = Count + 1                           'Add 1 to number of entries
            WriteLine(1, Contact(Count).ContactID)      'Write all variables into the file
            WriteLine(1, Contact(Count).Name)
            WriteLine(1, Contact(Count).Position)
            WriteLine(1, Contact(Count).Association)
            WriteLine(1, Contact(Count).Email)
            WriteLine(1, Contact(Count).TelephoneNo)
            WriteLine(1, Contact(Count).MobileNo)
        End While

        FileClose(1)                    'Close the file

        txtName.Clear()                 'Clear all textboxes
        txtPosition.Clear()
        txtAssociation.Clear()
        txtEmail.Clear()
        txtTelephone.Clear()
        txtMobile.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Close the form
    End Sub
End Class