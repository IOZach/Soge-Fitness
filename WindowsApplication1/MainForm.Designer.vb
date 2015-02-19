<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fitnessappform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fitnessappform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prebtn = New System.Windows.Forms.Button()
        Me.nxtbtn = New System.Windows.Forms.Button()
        Me.fntxt = New System.Windows.Forms.TextBox()
        Me.sntxt = New System.Windows.Forms.TextBox()
        Me.mntxt = New System.Windows.Forms.TextBox()
        Me.fnlbl = New System.Windows.Forms.Label()
        Me.snlbl = New System.Windows.Forms.Label()
        Me.mnlbl = New System.Windows.Forms.Label()
        Me.sexlbl = New System.Windows.Forms.Label()
        Me.mthlbl = New System.Windows.Forms.Label()
        Me.doblbl = New System.Windows.Forms.Label()
        Me.dobtxt = New System.Windows.Forms.TextBox()
        Me.mtlbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.srchlblf = New System.Windows.Forms.Label()
        Me.srchbtn = New System.Windows.Forms.Button()
        Me.srchtxtbox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMemberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mslbl = New System.Windows.Forms.Label()
        Me.clcbtn = New System.Windows.Forms.Button()
        Me.avrgtlblf = New System.Windows.Forms.Label()
        Me.sttsbtn = New System.Windows.Forms.Button()
        Me.exitmbtn = New System.Windows.Forms.Button()
        Me.fmleprcntlbl = New System.Windows.Forms.Label()
        Me.savemembersdb = New System.Windows.Forms.SaveFileDialog()
        Me.loadmembersdb = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.picboxshow = New System.Windows.Forms.PictureBox()
        Me.hidebutton1 = New System.Windows.Forms.Button()
        Me.hidebutton2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxshow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Soge Fitness Club"
        '
        'prebtn
        '
        Me.prebtn.Location = New System.Drawing.Point(77, 330)
        Me.prebtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prebtn.Name = "prebtn"
        Me.prebtn.Size = New System.Drawing.Size(87, 30)
        Me.prebtn.TabIndex = 1
        Me.prebtn.Text = "<< Previous"
        Me.prebtn.UseVisualStyleBackColor = True
        '
        'nxtbtn
        '
        Me.nxtbtn.Location = New System.Drawing.Point(182, 330)
        Me.nxtbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nxtbtn.Name = "nxtbtn"
        Me.nxtbtn.Size = New System.Drawing.Size(87, 30)
        Me.nxtbtn.TabIndex = 2
        Me.nxtbtn.Text = "Next >>"
        Me.nxtbtn.UseVisualStyleBackColor = True
        '
        'fntxt
        '
        Me.fntxt.Location = New System.Drawing.Point(38, 108)
        Me.fntxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.fntxt.Name = "fntxt"
        Me.fntxt.ReadOnly = True
        Me.fntxt.Size = New System.Drawing.Size(116, 22)
        Me.fntxt.TabIndex = 3
        '
        'sntxt
        '
        Me.sntxt.Location = New System.Drawing.Point(38, 192)
        Me.sntxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sntxt.Name = "sntxt"
        Me.sntxt.ReadOnly = True
        Me.sntxt.Size = New System.Drawing.Size(116, 22)
        Me.sntxt.TabIndex = 4
        '
        'mntxt
        '
        Me.mntxt.Location = New System.Drawing.Point(38, 277)
        Me.mntxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mntxt.Name = "mntxt"
        Me.mntxt.ReadOnly = True
        Me.mntxt.Size = New System.Drawing.Size(116, 22)
        Me.mntxt.TabIndex = 5
        '
        'fnlbl
        '
        Me.fnlbl.AutoSize = True
        Me.fnlbl.Location = New System.Drawing.Point(62, 84)
        Me.fnlbl.Name = "fnlbl"
        Me.fnlbl.Size = New System.Drawing.Size(70, 17)
        Me.fnlbl.TabIndex = 6
        Me.fnlbl.Text = "First Name"
        '
        'snlbl
        '
        Me.snlbl.AutoSize = True
        Me.snlbl.Location = New System.Drawing.Point(65, 167)
        Me.snlbl.Name = "snlbl"
        Me.snlbl.Size = New System.Drawing.Size(60, 17)
        Me.snlbl.TabIndex = 7
        Me.snlbl.Text = "Surname"
        '
        'mnlbl
        '
        Me.mnlbl.AutoSize = True
        Me.mnlbl.Location = New System.Drawing.Point(43, 254)
        Me.mnlbl.Name = "mnlbl"
        Me.mnlbl.Size = New System.Drawing.Size(104, 17)
        Me.mnlbl.TabIndex = 8
        Me.mnlbl.Text = "Member Number"
        '
        'sexlbl
        '
        Me.sexlbl.AutoSize = True
        Me.sexlbl.Location = New System.Drawing.Point(232, 254)
        Me.sexlbl.Name = "sexlbl"
        Me.sexlbl.Size = New System.Drawing.Size(29, 17)
        Me.sexlbl.TabIndex = 10
        Me.sexlbl.Text = "Sex"
        '
        'mthlbl
        '
        Me.mthlbl.AutoSize = True
        Me.mthlbl.Location = New System.Drawing.Point(206, 169)
        Me.mthlbl.Name = "mthlbl"
        Me.mthlbl.Size = New System.Drawing.Size(85, 17)
        Me.mthlbl.TabIndex = 16
        Me.mthlbl.Text = "Member Type"
        '
        'doblbl
        '
        Me.doblbl.AutoSize = True
        Me.doblbl.Location = New System.Drawing.Point(196, 84)
        Me.doblbl.Name = "doblbl"
        Me.doblbl.Size = New System.Drawing.Size(114, 17)
        Me.doblbl.TabIndex = 15
        Me.doblbl.Text = "DOB(dd/mm/yyyy)"
        '
        'dobtxt
        '
        Me.dobtxt.Location = New System.Drawing.Point(192, 108)
        Me.dobtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dobtxt.Name = "dobtxt"
        Me.dobtxt.ReadOnly = True
        Me.dobtxt.Size = New System.Drawing.Size(116, 22)
        Me.dobtxt.TabIndex = 12
        '
        'mtlbl
        '
        Me.mtlbl.AutoSize = True
        Me.mtlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtlbl.Location = New System.Drawing.Point(216, 198)
        Me.mtlbl.Name = "mtlbl"
        Me.mtlbl.Size = New System.Drawing.Size(0, 24)
        Me.mtlbl.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(364, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Member Picture"
        '
        'srchlblf
        '
        Me.srchlblf.AutoSize = True
        Me.srchlblf.Location = New System.Drawing.Point(332, 369)
        Me.srchlblf.Name = "srchlblf"
        Me.srchlblf.Size = New System.Drawing.Size(79, 17)
        Me.srchlblf.TabIndex = 20
        Me.srchlblf.Text = "Search Field"
        '
        'srchbtn
        '
        Me.srchbtn.Location = New System.Drawing.Point(428, 396)
        Me.srchbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchbtn.Name = "srchbtn"
        Me.srchbtn.Size = New System.Drawing.Size(87, 30)
        Me.srchbtn.TabIndex = 21
        Me.srchbtn.Text = "Search"
        Me.srchbtn.UseVisualStyleBackColor = True
        '
        'srchtxtbox
        '
        Me.srchtxtbox.Location = New System.Drawing.Point(415, 366)
        Me.srchtxtbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.srchtxtbox.Name = "srchtxtbox"
        Me.srchtxtbox.Size = New System.Drawing.Size(116, 22)
        Me.srchtxtbox.TabIndex = 22
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(571, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMemberToolStripMenuItem, Me.SaveMembersToolStripMenuItem, Me.LoadMembersToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddMemberToolStripMenuItem
        '
        Me.AddMemberToolStripMenuItem.Name = "AddMemberToolStripMenuItem"
        Me.AddMemberToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddMemberToolStripMenuItem.Text = "Add Member"
        Me.AddMemberToolStripMenuItem.ToolTipText = "Click here to add a member to the system"
        '
        'SaveMembersToolStripMenuItem
        '
        Me.SaveMembersToolStripMenuItem.Name = "SaveMembersToolStripMenuItem"
        Me.SaveMembersToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SaveMembersToolStripMenuItem.Text = "Save Members"
        Me.SaveMembersToolStripMenuItem.ToolTipText = "Click here to save the members to the file"
        '
        'LoadMembersToolStripMenuItem
        '
        Me.LoadMembersToolStripMenuItem.Name = "LoadMembersToolStripMenuItem"
        Me.LoadMembersToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LoadMembersToolStripMenuItem.Text = "Load Members"
        Me.LoadMembersToolStripMenuItem.ToolTipText = "Click here to load the members from a file"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AboutToolStripMenuItem.Text = "About App"
        Me.AboutToolStripMenuItem.ToolTipText = "About the Soge Application"
        '
        'mslbl
        '
        Me.mslbl.AutoSize = True
        Me.mslbl.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mslbl.Location = New System.Drawing.Point(227, 283)
        Me.mslbl.Name = "mslbl"
        Me.mslbl.Size = New System.Drawing.Size(0, 17)
        Me.mslbl.TabIndex = 24
        '
        'clcbtn
        '
        Me.clcbtn.Location = New System.Drawing.Point(21, 477)
        Me.clcbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.clcbtn.Name = "clcbtn"
        Me.clcbtn.Size = New System.Drawing.Size(101, 30)
        Me.clcbtn.TabIndex = 26
        Me.clcbtn.Text = "Average Type"
        Me.clcbtn.UseVisualStyleBackColor = True
        '
        'avrgtlblf
        '
        Me.avrgtlblf.AutoSize = True
        Me.avrgtlblf.Location = New System.Drawing.Point(125, 486)
        Me.avrgtlblf.Name = "avrgtlblf"
        Me.avrgtlblf.Size = New System.Drawing.Size(0, 17)
        Me.avrgtlblf.TabIndex = 27
        '
        'sttsbtn
        '
        Me.sttsbtn.Location = New System.Drawing.Point(21, 441)
        Me.sttsbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sttsbtn.Name = "sttsbtn"
        Me.sttsbtn.Size = New System.Drawing.Size(60, 30)
        Me.sttsbtn.TabIndex = 29
        Me.sttsbtn.Text = "Stats"
        Me.sttsbtn.UseVisualStyleBackColor = True
        '
        'exitmbtn
        '
        Me.exitmbtn.Location = New System.Drawing.Point(403, 477)
        Me.exitmbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitmbtn.Name = "exitmbtn"
        Me.exitmbtn.Size = New System.Drawing.Size(137, 34)
        Me.exitmbtn.TabIndex = 30
        Me.exitmbtn.Text = "Exit Program"
        Me.exitmbtn.UseVisualStyleBackColor = True
        '
        'fmleprcntlbl
        '
        Me.fmleprcntlbl.AutoSize = True
        Me.fmleprcntlbl.Location = New System.Drawing.Point(92, 448)
        Me.fmleprcntlbl.Name = "fmleprcntlbl"
        Me.fmleprcntlbl.Size = New System.Drawing.Size(0, 17)
        Me.fmleprcntlbl.TabIndex = 31
        '
        'savemembersdb
        '
        Me.savemembersdb.ValidateNames = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Copyright © 2012 Zakaria Abushima All rights reserved"
        '
        'logo
        '
        Me.logo.Image = Global.ifcs.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(199, 424)
        Me.logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(143, 98)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 39
        Me.logo.TabStop = False
        '
        'picboxshow
        '
        Me.picboxshow.Image = Global.ifcs.My.Resources.Resources.man_256
        Me.picboxshow.Location = New System.Drawing.Point(338, 141)
        Me.picboxshow.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picboxshow.Name = "picboxshow"
        Me.picboxshow.Size = New System.Drawing.Size(177, 198)
        Me.picboxshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxshow.TabIndex = 18
        Me.picboxshow.TabStop = False
        '
        'hidebutton1
        '
        Me.hidebutton1.Location = New System.Drawing.Point(21, 441)
        Me.hidebutton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hidebutton1.Name = "hidebutton1"
        Me.hidebutton1.Size = New System.Drawing.Size(60, 30)
        Me.hidebutton1.TabIndex = 40
        Me.hidebutton1.Text = "Stats"
        Me.hidebutton1.UseVisualStyleBackColor = True
        '
        'hidebutton2
        '
        Me.hidebutton2.Location = New System.Drawing.Point(21, 477)
        Me.hidebutton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hidebutton2.Name = "hidebutton2"
        Me.hidebutton2.Size = New System.Drawing.Size(101, 30)
        Me.hidebutton2.TabIndex = 41
        Me.hidebutton2.Text = "Average Type"
        Me.hidebutton2.UseVisualStyleBackColor = True
        '
        'fitnessappform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 545)
        Me.Controls.Add(Me.clcbtn)
        Me.Controls.Add(Me.sttsbtn)
        Me.Controls.Add(Me.hidebutton2)
        Me.Controls.Add(Me.hidebutton1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.fmleprcntlbl)
        Me.Controls.Add(Me.exitmbtn)
        Me.Controls.Add(Me.avrgtlblf)
        Me.Controls.Add(Me.mslbl)
        Me.Controls.Add(Me.srchtxtbox)
        Me.Controls.Add(Me.srchbtn)
        Me.Controls.Add(Me.srchlblf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.picboxshow)
        Me.Controls.Add(Me.mtlbl)
        Me.Controls.Add(Me.mthlbl)
        Me.Controls.Add(Me.doblbl)
        Me.Controls.Add(Me.dobtxt)
        Me.Controls.Add(Me.sexlbl)
        Me.Controls.Add(Me.mnlbl)
        Me.Controls.Add(Me.snlbl)
        Me.Controls.Add(Me.fnlbl)
        Me.Controls.Add(Me.mntxt)
        Me.Controls.Add(Me.sntxt)
        Me.Controls.Add(Me.fntxt)
        Me.Controls.Add(Me.nxtbtn)
        Me.Controls.Add(Me.prebtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "fitnessappform"
        Me.Text = "Soge Fitness Club"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxshow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prebtn As System.Windows.Forms.Button
    Friend WithEvents nxtbtn As System.Windows.Forms.Button
    Friend WithEvents fntxt As System.Windows.Forms.TextBox
    Friend WithEvents sntxt As System.Windows.Forms.TextBox
    Friend WithEvents mntxt As System.Windows.Forms.TextBox
    Friend WithEvents fnlbl As System.Windows.Forms.Label
    Friend WithEvents snlbl As System.Windows.Forms.Label
    Friend WithEvents mnlbl As System.Windows.Forms.Label
    Friend WithEvents sexlbl As System.Windows.Forms.Label
    Friend WithEvents mthlbl As System.Windows.Forms.Label
    Friend WithEvents doblbl As System.Windows.Forms.Label
    Friend WithEvents dobtxt As System.Windows.Forms.TextBox
    Friend WithEvents mtlbl As System.Windows.Forms.Label
    Friend WithEvents picboxshow As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents srchlblf As System.Windows.Forms.Label
    Friend WithEvents srchbtn As System.Windows.Forms.Button
    Friend WithEvents srchtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMemberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mslbl As System.Windows.Forms.Label
    Friend WithEvents clcbtn As System.Windows.Forms.Button
    Friend WithEvents avrgtlblf As System.Windows.Forms.Label
    Friend WithEvents sttsbtn As System.Windows.Forms.Button
    Friend WithEvents exitmbtn As System.Windows.Forms.Button
    Friend WithEvents fmleprcntlbl As System.Windows.Forms.Label
    Friend WithEvents savemembersdb As System.Windows.Forms.SaveFileDialog
    Friend WithEvents loadmembersdb As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents hidebutton1 As System.Windows.Forms.Button
    Friend WithEvents hidebutton2 As System.Windows.Forms.Button

End Class
