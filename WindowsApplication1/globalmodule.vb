Imports System.IO

Module globalmodule

    ' the below is the declared member structre fields and variable
    Structure FitnessMembers

        Public fmfirstName As String ' a structure field to hold the member first name
        Public fmlastName As String ' a structure field to hold the member last name
        Public fmemdob As String ' a structure field to hold the member date of birth
        Public fmemnum As Decimal ' a structure field to hold the member number
        Public fmtype As String ' a structure field to hold the member type
        Public fmsex As String ' a structure field to hold the member gender
        Public picpat As String ' a structure field to hold the member picture path

    End Structure

    ' the below are the declared variable for the fitness club system
    Public Const maxmembers As Integer = 99 ' a variable to determine the maximum number of members the user are able to add
    Public Members(maxmembers) As FitnessMembers ' the structure arrays with the determination of maximum number to add variable
    Public picldnm As String ' a string used to hold picture member path when we load the picture in the adding form at the begining for the member to add to the structure field which this one (picpat)
    Public fitnessmembersnums As Integer ' a variable used to be a counter to count how many members in the fitness club added
    Public nxtprecycle As Integer = -1 ' a variable for the cycling function which is to cycle through th member next and previous
    Public femaleaver As Integer ' a variable to count how many female members have been added to the system
    Public memsexf As String ' a variable for the member gender once you adding the member this variable will see which radio button are checked then it will be equal to
    Public memtypef As String ' this variable the same of the above but it works for the member type to see for example you have chose number 4 from the combo box once you adding the member then it will be equal to 4 stars
    Public starmtone As Integer ' this variable to count how many members are with one star type
    Public starmttwo As Integer ' this variable to count how many members are with two star type
    Public starmtthre As Integer ' this variable to count how many members are with three star type
    Public starmtfour As Integer ' this variable to count how many members are with four star type
    Public starmtfive As Integer ' this variable to count how many members are with five star type
    Public intmemnum As Integer ' this variable for the search box declared for searching for a member number
    Public intmemfis As String ' this variable for the search box declared for searching for a member first name
    Public membersaver As StreamWriter ' variable for the stream writer which is to write to a file we have used it to save members details
    Public memberloader As StreamReader ' variable for the stream reader which is to read from a file we have used it to load members details
    Public loadingdata As String ' string variable used for the dialog to load the specific file that has been selected once the load dialog box appeared
    Public savingdata As String ' string variable used for the dialog to save the file with a specific name that has been written once the save dialog box appeared
    Public empty As String = "" ' a string we have used it for the adding form which is to empty the adding form fields once you have added a member to make it ready to add another member

End Module
