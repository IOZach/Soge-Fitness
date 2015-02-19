<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addmemberform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addmemberform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addmtlbl = New System.Windows.Forms.Label()
        Me.adddoblbl = New System.Windows.Forms.Label()
        Me.adddobtxt = New System.Windows.Forms.TextBox()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.addsexlbl = New System.Windows.Forms.Label()
        Me.addmnlbl = New System.Windows.Forms.Label()
        Me.addrnlbl = New System.Windows.Forms.Label()
        Me.addfnlbl = New System.Windows.Forms.Label()
        Me.addmemntxt = New System.Windows.Forms.TextBox()
        Me.addsntxt = New System.Windows.Forms.TextBox()
        Me.addfntxt = New System.Windows.Forms.TextBox()
        Me.loadpicbtn = New System.Windows.Forms.Button()
        Me.addmtcombo = New System.Windows.Forms.ComboBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.exitaddbtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dialogldpic = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.picboxadd = New System.Windows.Forms.PictureBox()
        Me.disappaer = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disappaer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Soge Fitness Club - Add Member"
        '
        'addmtlbl
        '
        Me.addmtlbl.AutoSize = True
        Me.addmtlbl.Location = New System.Drawing.Point(257, 180)
        Me.addmtlbl.Name = "addmtlbl"
        Me.addmtlbl.Size = New System.Drawing.Size(97, 16)
        Me.addmtlbl.TabIndex = 29
        Me.addmtlbl.Text = "Member Type"
        '
        'adddoblbl
        '
        Me.adddoblbl.AutoSize = True
        Me.adddoblbl.Location = New System.Drawing.Point(242, 82)
        Me.adddoblbl.Name = "adddoblbl"
        Me.adddoblbl.Size = New System.Drawing.Size(132, 16)
        Me.adddoblbl.TabIndex = 28
        Me.adddoblbl.Text = "DOB(dd/mm/yyyy)"
        '
        'adddobtxt
        '
        Me.adddobtxt.Location = New System.Drawing.Point(232, 111)
        Me.adddobtxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.adddobtxt.Name = "adddobtxt"
        Me.adddobtxt.Size = New System.Drawing.Size(154, 23)
        Me.adddobtxt.TabIndex = 27
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(304, 307)
        Me.female.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(73, 20)
        Me.female.TabIndex = 25
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(232, 307)
        Me.male.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(59, 20)
        Me.male.TabIndex = 26
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'addsexlbl
        '
        Me.addsexlbl.AutoSize = True
        Me.addsexlbl.Location = New System.Drawing.Point(279, 277)
        Me.addsexlbl.Name = "addsexlbl"
        Me.addsexlbl.Size = New System.Drawing.Size(30, 16)
        Me.addsexlbl.TabIndex = 24
        Me.addsexlbl.Text = "Sex"
        '
        'addmnlbl
        '
        Me.addmnlbl.AutoSize = True
        Me.addmnlbl.Location = New System.Drawing.Point(45, 279)
        Me.addmnlbl.Name = "addmnlbl"
        Me.addmnlbl.Size = New System.Drawing.Size(118, 16)
        Me.addmnlbl.TabIndex = 23
        Me.addmnlbl.Text = "Member Number"
        '
        'addrnlbl
        '
        Me.addrnlbl.AutoSize = True
        Me.addrnlbl.Location = New System.Drawing.Point(68, 180)
        Me.addrnlbl.Name = "addrnlbl"
        Me.addrnlbl.Size = New System.Drawing.Size(65, 16)
        Me.addrnlbl.TabIndex = 22
        Me.addrnlbl.Text = "Surname"
        '
        'addfnlbl
        '
        Me.addfnlbl.AutoSize = True
        Me.addfnlbl.Location = New System.Drawing.Point(68, 82)
        Me.addfnlbl.Name = "addfnlbl"
        Me.addfnlbl.Size = New System.Drawing.Size(76, 16)
        Me.addfnlbl.TabIndex = 21
        Me.addfnlbl.Text = "First Name"
        '
        'addmemntxt
        '
        Me.addmemntxt.Location = New System.Drawing.Point(26, 306)
        Me.addmemntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.addmemntxt.Name = "addmemntxt"
        Me.addmemntxt.Size = New System.Drawing.Size(154, 23)
        Me.addmemntxt.TabIndex = 20
        '
        'addsntxt
        '
        Me.addsntxt.Location = New System.Drawing.Point(26, 208)
        Me.addsntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.addsntxt.Name = "addsntxt"
        Me.addsntxt.Size = New System.Drawing.Size(154, 23)
        Me.addsntxt.TabIndex = 19
        '
        'addfntxt
        '
        Me.addfntxt.Location = New System.Drawing.Point(26, 111)
        Me.addfntxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.addfntxt.Name = "addfntxt"
        Me.addfntxt.Size = New System.Drawing.Size(154, 23)
        Me.addfntxt.TabIndex = 18
        '
        'loadpicbtn
        '
        Me.loadpicbtn.Location = New System.Drawing.Point(481, 322)
        Me.loadpicbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.loadpicbtn.Name = "loadpicbtn"
        Me.loadpicbtn.Size = New System.Drawing.Size(99, 28)
        Me.loadpicbtn.TabIndex = 32
        Me.loadpicbtn.Text = "Load Picture"
        Me.loadpicbtn.UseVisualStyleBackColor = True
        '
        'addmtcombo
        '
        Me.addmtcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.addmtcombo.FormattingEnabled = True
        Me.addmtcombo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.addmtcombo.Location = New System.Drawing.Point(232, 207)
        Me.addmtcombo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addmtcombo.Name = "addmtcombo"
        Me.addmtcombo.Size = New System.Drawing.Size(154, 24)
        Me.addmtcombo.TabIndex = 33
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(231, 348)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(145, 28)
        Me.addbtn.TabIndex = 34
        Me.addbtn.Text = "Add Member"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'exitaddbtn
        '
        Me.exitaddbtn.Location = New System.Drawing.Point(533, 382)
        Me.exitaddbtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitaddbtn.Name = "exitaddbtn"
        Me.exitaddbtn.Size = New System.Drawing.Size(99, 28)
        Me.exitaddbtn.TabIndex = 35
        Me.exitaddbtn.Text = "Exit"
        Me.exitaddbtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(469, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Member Picture"
        '
        'dialogldpic
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 423)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Copyright © 2012 Zakaria Abushima All rights reserved"
        '
        'logo
        '
        Me.logo.Image = Global.ifcs.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(26, 348)
        Me.logo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(121, 81)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 38
        Me.logo.TabStop = False
        '
        'picboxadd
        '
        Me.picboxadd.Location = New System.Drawing.Point(420, 99)
        Me.picboxadd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.picboxadd.Name = "picboxadd"
        Me.picboxadd.Size = New System.Drawing.Size(209, 208)
        Me.picboxadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxadd.TabIndex = 31
        Me.picboxadd.TabStop = False
        '
        'disappaer
        '
        Me.disappaer.Image = Global.ifcs.My.Resources.Resources.man_256
        Me.disappaer.Location = New System.Drawing.Point(420, 99)
        Me.disappaer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.disappaer.Name = "disappaer"
        Me.disappaer.Size = New System.Drawing.Size(209, 208)
        Me.disappaer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.disappaer.TabIndex = 39
        Me.disappaer.TabStop = False
        '
        'addmemberform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 445)
        Me.Controls.Add(Me.disappaer)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitaddbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.addmtcombo)
        Me.Controls.Add(Me.loadpicbtn)
        Me.Controls.Add(Me.picboxadd)
        Me.Controls.Add(Me.addmtlbl)
        Me.Controls.Add(Me.adddoblbl)
        Me.Controls.Add(Me.adddobtxt)
        Me.Controls.Add(Me.female)
        Me.Controls.Add(Me.male)
        Me.Controls.Add(Me.addsexlbl)
        Me.Controls.Add(Me.addmnlbl)
        Me.Controls.Add(Me.addrnlbl)
        Me.Controls.Add(Me.addfnlbl)
        Me.Controls.Add(Me.addmemntxt)
        Me.Controls.Add(Me.addsntxt)
        Me.Controls.Add(Me.addfntxt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "addmemberform"
        Me.Text = "Soge Fitness Club - Add Memeber"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disappaer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents addmtlbl As System.Windows.Forms.Label
    Friend WithEvents adddoblbl As System.Windows.Forms.Label
    Friend WithEvents adddobtxt As System.Windows.Forms.TextBox
    Friend WithEvents female As System.Windows.Forms.RadioButton
    Friend WithEvents male As System.Windows.Forms.RadioButton
    Friend WithEvents addsexlbl As System.Windows.Forms.Label
    Friend WithEvents addmnlbl As System.Windows.Forms.Label
    Friend WithEvents addrnlbl As System.Windows.Forms.Label
    Friend WithEvents addfnlbl As System.Windows.Forms.Label
    Friend WithEvents addmemntxt As System.Windows.Forms.TextBox
    Friend WithEvents addsntxt As System.Windows.Forms.TextBox
    Friend WithEvents addfntxt As System.Windows.Forms.TextBox
    Friend WithEvents picboxadd As System.Windows.Forms.PictureBox
    Friend WithEvents loadpicbtn As System.Windows.Forms.Button
    Friend WithEvents addmtcombo As System.Windows.Forms.ComboBox
    Friend WithEvents addbtn As System.Windows.Forms.Button
    Friend WithEvents exitaddbtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dialogldpic As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents disappaer As System.Windows.Forms.PictureBox
End Class
