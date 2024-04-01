<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label1.Location = New Point(24, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 0
        Label1.Text = "TYPE:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label2.Location = New Point(24, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 1
        Label2.Text = "QUANTITY:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label3.Location = New Point(24, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 2
        Label3.Text = "AMOUNT:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label4.Location = New Point(24, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(48, 20)
        Label4.TabIndex = 3
        Label4.Text = "DATE:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Label5.Location = New Point(335, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 4
        Label5.Text = "TIME:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(160, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(411, 270)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(160, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(126, 270)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(160, 27)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(126, 200)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(160, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(126, 123)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(160, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuBar
        Button1.Location = New Point(591, 373)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 47)
        Button1.TabIndex = 10
        Button1.Text = "SUBMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "SALES "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
End Class
