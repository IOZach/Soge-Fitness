Public Class addmemberform

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitaddbtn.Click
        Me.Hide() ' a function for the Exit button once you have added a members you want then you can exit the adding form
    End Sub

    Private Sub loadpicbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadpicbtn.Click

        dialogldpic.ShowDialog() ' dialog to load the member image
        picldnm = dialogldpic.FileName ' a string to be equal to the member loaded image path
        If Len(picldnm) > 0 Then ' if statemnet to avoid errors and to see whether the user chose image or not yet
            disappaer.Visible = False ' this something extra for hiding the current picture which as a symbol like member picture icon and load and display the actual member picture
            picboxadd.Image = Image.FromFile(picldnm) ' here to display the loaded picture in the appropriate picture box
        End If

    End Sub

    Private Sub picboxadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxadd.Click

        ' the below is just to determine the size of the loaded member picture to display in specific width and height
        picboxadd.Height = 208
        picboxadd.Width = 183

    End Sub

    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click

        ' if statment to see whather you can add more members or not as it's bound to the maximum number of members that determinded in the global module
        If fitnessmembersnums + 1 > maxmembers Then

            ' the below message box tells that you can't add more member if you are trying to go over the maximum number of members
            MsgBox("Sorry! you have reached the limit of members", MsgBoxStyle.Exclamation, "Maximum Members")

        Else

            ' if statement to see whather there is at least one member field is filled to be able to add new member if not then you cant add member unless fill at least on field
            If Len(addfntxt.Text) > 0 Or Len(addsntxt.Text) > 0 Or Len(adddobtxt.Text) > 0 Or Len(addmemntxt.Text) > 0 Or Len(picldnm) > 0 Or male.Checked = True Or female.Checked = True Or Len(addmtcombo.Text) > 0 Then

                ' the below case statemnet is for the member type to see which number get chose from the combo box and then equal the member type string to a number of starts equal to the chosen number 
                Select Case addmtcombo.Text
                    Case "1"
                        memtypef = "*"
                        starmtone = starmtone + 1
                    Case "2"
                        memtypef = "**"
                        starmttwo = starmttwo + 1
                    Case "3"
                        memtypef = "***"
                        starmtthre = starmtthre + 1
                    Case "4"
                        memtypef = "****"
                        starmtfour = starmtfour + 1
                    Case "5"
                        memtypef = "*****"
                        starmtfive = starmtfive + 1
                End Select

                ' the below if statement is for the member gender to determine which type of gender the user chose and add it the checked gender
                If male.Checked = True Then
                    memsexf = male.Text
                ElseIf female.Checked = True Then
                    memsexf = female.Text
                    femaleaver = femaleaver + 1
                End If

                disappaer.Visible = True ' this something extra for hiding the current picture which as a symbol like member picture icon and load and display the actual member picture

                ' the below is the member structure that will get the requested information from the text box and hold it in the structure memory
                With Members(fitnessmembersnums)
                    .fmfirstName = addfntxt.Text
                    .fmlastName = addsntxt.Text
                    .fmemdob = adddobtxt.Text
                    .fmemnum = Val(addmemntxt.Text)
                    .fmtype = memtypef
                    .fmsex = memsexf
                    .picpat = picldnm
                End With

                fitnessmembersnums = fitnessmembersnums + 1 ' this function simply as a counter to count the number of members

                ' the below sub procedure is to empty the text boxes once you have fill when you added the first member and make it ready for you to add a new member
                addfntxt.Text = empty
                addsntxt.Text = empty
                adddobtxt.Text = empty
                addmtcombo.SelectedItem = Nothing
                addmemntxt.Text = empty
                memtypef = empty
                female.Checked = False
                male.Checked = False
                picboxadd.Image = Nothing
                picldnm = empty
                memsexf = empty
            Else

                ' this below message box is connected to the pre-top if statement which is tells that you have to fill at least one field in case all the fields are empty
                MsgBox("Sorry! you have to fill at least one of the members details fields", MsgBoxStyle.Exclamation, "Can't add member")

            End If

        End If

    End Sub

End Class