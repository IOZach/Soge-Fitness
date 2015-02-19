Imports System.IO ' this namespace to deal with stream writer or stream reader

Public Class fitnessappform

    ' the below sub is a confirmation msgbox whether you sure or not that you want to close the application
    Private Sub fitnessappform_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        Dim closealrt As DialogResult ' a variable we are going to use it to determine you have clicked yes or not
        closealrt = MessageBox.Show("Are you sure that you want to close the application?" & vbNewLine & "Please make sure you do save members details!", "Application Close Confirmation", MessageBoxButtons.YesNo)
        ' the below if statemnet we have used with the above variable to do close the application if you clicked yes and don't close the application if you clicked no
        If closealrt <> DialogResult.Yes Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    ' the below sub is a shortening way to reduce codes as much as possible which is for the next and previous and search functions and when we need the 
    ' specific member details we will not need to repeat the code many times jsut with one time and we can use it as much as we like later on with calling the function
    Public Sub filltheboxes()
        With Members(nxtprecycle)
            fntxt.Text = .fmfirstName
            sntxt.Text = .fmlastName
            dobtxt.Text = .fmemdob
            If Not .fmemnum = Nothing Then
                mntxt.Text = .fmemnum
            Else
                mntxt.Text = empty
            End If
            mtlbl.Text = .fmtype
            mslbl.Text = .fmsex
            If Len(.picpat) > 0 Then
                picboxshow.Image = Image.FromFile(.picpat)
            Else
                picboxshow.Image = Nothing
            End If
        End With

    End Sub


    Private Sub AddMemberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMemberToolStripMenuItem.Click

        addmemberform.ShowDialog() ' this function will do the following >> when you click the add member from the menu then the adding member form will appear

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitmbtn.Click

        Me.Close() ' this function for the exit button to close the programme

    End Sub

    Private Sub picboxshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picboxshow.Click

        ' the below is just to determine the size of the members pictures to display in specific width and height
        picboxshow.Height = 186
        picboxshow.Width = 177

    End Sub

    Private Sub nxtbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nxtbtn.Click

        If fitnessmembersnums > 0 Then ' if statemnet to see if there is members or not to cycle through the next members

            If nxtprecycle = fitnessmembersnums - 1 Then ' if statemnet to determine which member we are in that if we are diplaying the last member then we need to cycle from the start again
                nxtprecycle = 0 ' if we are in the last member after we clicked next few times then the members counter will start from the begining 
            Else
                nxtprecycle = nxtprecycle + 1 ' if we still not reached the last member yet then keep adding 1 to the counter to cycle through member until the end
            End If

            Call filltheboxes() ' we are calling now the function to display the member details

        Else
            ' the below massage box tells that there is no members which is connected to the top statement in this sub
            MsgBox("Sorry, There is no member to cycle through", MsgBoxStyle.Exclamation, "Cycling Result")
        End If

    End Sub

    Private Sub prebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prebtn.Click

        ' the below code it's the same of the above code just this one for previous and the other one for the next basiclly this 
        'one goes backwards and you can see we have used the (-) sign istead of + and a little bit of code in the if statemnet
        If fitnessmembersnums > 0 Then

            If nxtprecycle <= 0 Then
                nxtprecycle = fitnessmembersnums - 1
            Else
                nxtprecycle = nxtprecycle - 1
            End If

            Call filltheboxes()

        Else
            MsgBox("Sorry, There is no member to cycle through", MsgBoxStyle.Exclamation, "Cycling Result")
        End If

    End Sub

    Private Sub sttsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sttsbtn.Click
        ' the below code is to find out how many members in the club with a how many female are in percentage
        If fitnessmembersnums > 0 Then ' if statement to see whether there is a member or not to display the stats of

            ' this below code related to extra function which is display and hide instead of the stats shows the logo if you click the button twice
            logo.Visible = False
            sttsbtn.Visible = False
            fmleprcntlbl.Visible = True
            hidebutton1.Visible = True

            ' this below code to work out and display in a label how many members in the club are and how many female in percentage
            fmleprcntlbl.Text = "There are " & fitnessmembersnums & " members in the club " & Mid$((CDec(femaleaver / fitnessmembersnums * 100)), 1, 5) & "% are female"
        Else
            ' the below message box connected with the top if statemnet to determine weather there is members to see the stats of or not
            MsgBox("There is no members to find the stats of", MsgBoxStyle.Exclamation, "Stats Result")
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hidebutton1.Click

        ' this below code related to extra function which is display and hide instead of the stats shows the logo if you click the button twice
        logo.Visible = True
        hidebutton1.Visible = False
        fmleprcntlbl.Visible = False
        sttsbtn.Visible = True
        hidebutton2.Visible = False
        avrgtlblf.Visible = False
        clcbtn.Visible = True

    End Sub

    Private Sub clcbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clcbtn.Click
        ' the below code is to find out the member average type
        If fitnessmembersnums > 0 Then ' if statement to see whether there is a member or not to display the average type of

            ' this below code related to extra function which is display and hide instead of the stats shows the logo if you click the button twice
            logo.Visible = False
            clcbtn.Visible = False
            avrgtlblf.Visible = True
            hidebutton2.Visible = True

            ' this below code to work out and display in a label the member average type
            avrgtlblf.Text = "The member type average is " & Mid$((CDec(((starmtone * 1) + (starmttwo * 2) + (starmtthre * 3) + (starmtfour * 4) + (starmtfive * 5)) / fitnessmembersnums)), 1, 5)
        Else
            ' the below message box connected with the top if statemnet to determine weather there is members to see the average type of
            MsgBox("There is no members to find the type average of", MsgBoxStyle.Exclamation, "Member Average Type")
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hidebutton2.Click

        ' this below code related to extra function which is display and hide instead of the stats shows the logo if you click the button twice
        logo.Visible = True
        hidebutton2.Visible = False
        avrgtlblf.Visible = False
        clcbtn.Visible = True
        hidebutton1.Visible = False
        fmleprcntlbl.Visible = False
        sttsbtn.Visible = True
        avrgtlblf.Visible = False

    End Sub

    Private Sub SaveMembersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveMembersToolStripMenuItem.Click

        savemembersdb.ShowDialog() ' this to show the saving dialog 
        If Len(savemembersdb.FileName) > 0 Then ' if statment to see whether you have wrote the data members file name or not to also avoid an error in some cases
            savingdata = savemembersdb.FileName ' this a declared string variable equal to the chosen file name that we will save the data to
            membersaver = File.CreateText(savingdata & ".txt") ' create the file with the chosen name the user made in the saving dialog
            ' the below is a function writing the members data to the file such as adding first of all how many members in the club are then start with the structure and loop to write every single member
            ' and his information togather and then loop for the next members
            membersaver.WriteLine(fitnessmembersnums)
            membersaver.WriteLine(femaleaver)
            membersaver.WriteLine(starmtone)
            membersaver.WriteLine(starmttwo)
            membersaver.WriteLine(starmtthre)
            membersaver.WriteLine(starmtfour)
            membersaver.WriteLine(starmtfive)
            For i = 0 To fitnessmembersnums - 1
                With Members(i)
                    membersaver.WriteLine(.fmfirstName)
                    membersaver.WriteLine(.fmlastName)
                    membersaver.WriteLine(.fmemdob)
                    membersaver.WriteLine(.fmemnum)
                    membersaver.WriteLine(.fmtype)
                    membersaver.WriteLine(.fmsex)
                    membersaver.WriteLine(.picpat)
                    membersaver.WriteLine(empty)
                End With
            Next i
            membersaver.Close() ' close the saving process when it reaches the end of members in the structure
        End If

    End Sub

    Private Sub LoadMembersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadMembersToolStripMenuItem.Click

        loadmembersdb.ShowDialog() ' this to show the loading dialog 
        If Len(loadmembersdb.FileName) > 0 Then  ' if statment to see whether you have chose the file name or not to load the members details from
            loadingdata = loadmembersdb.FileName  ' a declared string equal to the chosen file name to load the data from
            memberloader = File.OpenText(loadingdata) ' to open the specified file with the string that equal to the chosen file name and path to load
            ' the below is loading the members data from the file such as loading first of all how many members in the club are then start with the structure and loop to read with the same order of write every single member
            ' and his information togather and then loop for the next member
            fitnessmembersnums = memberloader.ReadLine()
            femaleaver = memberloader.ReadLine()
            starmtone = memberloader.ReadLine()
            starmttwo = memberloader.ReadLine()
            starmtthre = memberloader.ReadLine()
            starmtfour = memberloader.ReadLine()
            starmtfive = memberloader.ReadLine()
            For i = 0 To fitnessmembersnums - 1
                With Members(i)
                    .fmfirstName = memberloader.ReadLine()
                    .fmlastName = memberloader.ReadLine()
                    .fmemdob = memberloader.ReadLine()
                    .fmemnum = memberloader.ReadLine()
                    .fmtype = memberloader.ReadLine()
                    .fmsex = memberloader.ReadLine()
                    .picpat = memberloader.ReadLine()
                    empty = memberloader.ReadLine()
                End With
            Next i
            memberloader.Close() ' close the loading process when it reaches the last line of the data file
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        ' something extra just a message box about the application
        MsgBox("This was the first actual application that made by zakaria hands" & vbNewLine & "which was for his first Programming unit assignment in his university foundation year Which is about an example of fitness club identification system that covers Arrays, Structures and File O/I.", MsgBoxStyle.Information, "About App")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srchbtn.Click
        ' the below code for the search box that will search for the first name or the member number using loop and structure to display the member once it get found

        Dim csdsearch As Char ' a variable to take what was written in the search box and convert it to a unicode character for a case statment
        Dim i As Integer ' variable for the next loop counter
        intmemfis = srchtxtbox.Text ' a variable for the first name that equal to what have been wrote in the search box
        intmemnum = Val(srchtxtbox.Text) ' a variable for the member number that equal to what have been wrote in the search box

        If Len(srchtxtbox.Text) > 0 Then ' if statemnet to see if you have entered a something in the text box or not
            For i = 0 To fitnessmembersnums ' a next loop to cycle through the members in searching
                If fitnessmembersnums > 0 Then ' if statemnet to see if there is members have been added or not then if there is search for it

                    ' the below function is a solution for the case statement problem because it does ignore number 9 and letter z when searching but when we bring what have been written
                    ' in the search box as a char and with mid function then add to the case statment selection to look on it does work and look for number 9 and z aswell
                    csdsearch = Mid(srchtxtbox.Text, 1, Len(srchtxtbox.Text))
                    ' this the below select case that I have talked about with the issue ignoring 9 and z that I didn't find the reason for yet I found the solution for however
                    ' the select case will determine what have entered in the box is a character or number so if charater search for the member first name and if not then member number and so on
                    Select Case csdsearch
                        ' if what have been entered in the text box a number then case statment will process here
                        Case "0" To "9"
                            ' this below code is a if statemnet for the loop and it's about that if what have been entered in search box equal to this member number then display the member details and stop the loop'
                            ' with an addition to change the next and previous variable to current member that have got this member number and call the filltheboxes sub that I have mentioned about at the top before
                            If intmemnum = Members(i).fmemnum Then
                                nxtprecycle = i ' once we have found the member then their details will get displayed and will be a controduction whilst we click next or prevous but with this we will set the next and previous to the current member we found and it will work probably then
                                Call filltheboxes() ' bring the filltheboxes sub here once we have found the member by calling it
                                Exit For ' exit the loop once we found the member
                            ElseIf Not intmemnum = Members(i).fmemnum And i = fitnessmembersnums - 1 Then ' if statemnet to see if this member number doesnt exist in all members 
                                MsgBox("This member number doesn't exist", MsgBoxStyle.Exclamation, "Search Result") ' this message box once we didn't find the member number will appear
                            End If
                            ' the below code are the same of the top but instead of looking for a member number it will look for a member first name we just difference with the lowerd case function
                        Case "a" To "z", "A" To "Z"
                            If LCase(intmemfis) = LCase(Members(i).fmfirstName) Then
                                nxtprecycle = i
                                Call filltheboxes()
                                Exit For
                            ElseIf Not LCase(intmemfis) = LCase(Members(i).fmfirstName) And i = fitnessmembersnums - 1 Then
                                MsgBox("This member firstname doesn't exist", MsgBoxStyle.Exclamation, "Search Result")
                            End If
                            ' the below case it's for the other cases for example the user by mistake could enter a nor number or letter then this case will sort it out with msgbox tells 
                        Case Else
                            MsgBox("This member doesn't exist", MsgBoxStyle.Exclamation, "Search Result")
                    End Select


                Else
                    ' the below message box is connected to the pre-top if statemnet to see if there is a members to search for
                    MsgBox("There is no members to search for", MsgBoxStyle.Exclamation, "Search Result")
                End If
            Next i
        Else
            ' the below message box is connected to the top of the if statemnet to see if you have typed something in the search box or not
            MsgBox("please make sure to write something in search field to search for!", MsgBoxStyle.Exclamation, "Search Result")
        End If
    End Sub

End Class
