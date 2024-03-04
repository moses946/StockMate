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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(252, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Username"
        TextBox1.Size = New Size(202, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(252, 177)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Password"
        TextBox2.Size = New Size(202, 27)
        TextBox2.TabIndex = 1
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Location = New Point(252, 217)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(125, 20)
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
        Button1.Location = New Point(262, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 53)
        Button1.TabIndex = 3
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = StockMate.Resources.WhatsApp_Image_2024_02_27_at_14_44_08_f896450f
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button

End Class
