<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        SIGNUP = New Button()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.ForeColor = SystemColors.Control
        TextBox1.Location = New Point(7, 26)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(284, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(6, 29)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(284, 27)
        TextBox2.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("Tahoma", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(341, 307)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(123, 18)
        LinkLabel1.TabIndex = 2
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.FlatAppearance.BorderColor = Color.Lime
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = Color.White
        Button1.Location = New Point(340, 241)
        Button1.Name = "Button1"
        Button1.Size = New Size(124, 44)
        Button1.TabIndex = 3
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SIGNUP
        ' 
        SIGNUP.BackColor = Color.Green
        SIGNUP.ForeColor = Color.White
        SIGNUP.Location = New Point(684, 25)
        SIGNUP.Name = "SIGNUP"
        SIGNUP.Size = New Size(91, 38)
        SIGNUP.TabIndex = 4
        SIGNUP.Text = "SIGN UP"
        SIGNUP.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.ForeColor = SystemColors.Control
        GroupBox1.Location = New Point(206, 99)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(346, 66)
        GroupBox1.TabIndex = 5
        GroupBox1.TabStop = False
        GroupBox1.Text = "Username"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Transparent
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.ForeColor = SystemColors.Control
        GroupBox2.Location = New Point(207, 171)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(345, 64)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(SIGNUP)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents SIGNUP As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class
