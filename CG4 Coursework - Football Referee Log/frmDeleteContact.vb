'Data is retrieved from the file, then the user can select a record to be deleted and rewrite the file without it

Public Class frmDeleteContact

    'Declare variables as data types
    Dim Count As Integer
    Dim NumberofItemsinArray As Integer
    Dim InformationFound As Boolean
    Dim ItemtobeDeleted As Integer

    Private Sub frmDeleteContact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open Contacts file in read-only mode
        FileOpen(1, "Contacts.txt", OpenMode.Input)
        Count = 0
        While Not EOF(1)
            Count = Count + 1
            Input(1, Contact(Count).ContactID)              'Read variables stored in the file,
            Input(1, Contact(Count).Name)                   'into the system
            Input(1, Contact(Count).Position)
            Input(1, Contact(Count).Association)
            Input(1, Contact(Count).Email)
            Input(1, Contact(Count).TelephoneNo)
            Input(1, Contact(Count).MobileNo)

            'Insert Contact variables for each record into the listbox
            lstChooseContact.Items.Add(Contact(Count).ContactID & "-" & Contact(Count).Name & "-" & Contact(Count).Position & "-" & Contact(Count).Association)
        End While

        FileClose(1)
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
            If lstChooseContact.SelectedItem = Contact(Count).ContactID & "-" & Contact(Count).Name & "-" & Contact(Count).Position & "-" & Contact(Count).Association Then
                'If Contact in listbox = Contact in record do:
                Dim information = lstChooseContact.SelectedItem         'Information = String in listbox
                Dim fields = information.Split("-")                     'Split the string at each " - "
                Contact(Count).ContactID = fields(0).trim               'Contents of array = each field
                Contact(Count).Name = fields(1).Trim()
                Contact(Count).Position = fields(2).Trim()
                Contact(Count).Association = fields(3).Trim()
                InformationFound = True                                 'Rogue value stops code running
                ItemtobeDeleted = Count                                 'Find the address of the item to be deleted
            End If
        End While
    End Sub

    Private Sub btnDeleteContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteContact.Click
        'Open Contacts file in Output Mode to overwrite
        FileOpen(1, "Contacts.txt", OpenMode.Output)
        Count = 0
        While Count <> NumberofItemsinArray - 1             'While Count is not equal to NoIiA do:
            Count = Count + 1                               'Add 1 to number of entries
            If Count <> ItemtobeDeleted Then                'Skip the selected record to remove it from file
                WriteLine(1, Contact(Count).ContactID)      'Write all variables into the file
                WriteLine(1, Contact(Count).Name)
                WriteLine(1, Contact(Count).Position)
                WriteLine(1, Contact(Count).Association)
                WriteLine(1, Contact(Count).Email)
                WriteLine(1, Contact(Count).TelephoneNo)
                WriteLine(1, Contact(Count).MobileNo)
            End If
        End While

        FileClose(1)                    'Close the file

        lstChooseContact.Items.RemoveAt(lstChooseContact.SelectedIndex)     'Remove record from listbox
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()        'Close the form
    End Sub
End Class