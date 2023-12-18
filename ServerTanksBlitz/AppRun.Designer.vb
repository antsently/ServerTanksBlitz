<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AppRun
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
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        ПомощьToolStripMenuItem = New ToolStripMenuItem()
        ПомощьToolStripMenuItem1 = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 262)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 30)
        Button1.TabIndex = 1
        Button1.Text = "Заблокировать"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(44, 41)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Сервер С0"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(44, 71)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(103, 24)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Сервер С1"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(44, 101)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(103, 24)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Сервер С2"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(185, 41)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "Сервер С3"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(185, 71)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(103, 24)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Сервер С4"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(185, 101)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(103, 24)
        CheckBox6.TabIndex = 7
        CheckBox6.Text = "Сервер С5"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(185, 262)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 30)
        Button2.TabIndex = 8
        Button2.Text = "Разблокировать"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ПомощьToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(332, 28)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ПомощьToolStripMenuItem
        ' 
        ПомощьToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ПомощьToolStripMenuItem1})
        ПомощьToolStripMenuItem.Name = "ПомощьToolStripMenuItem"
        ПомощьToolStripMenuItem.Size = New Size(65, 24)
        ПомощьToolStripMenuItem.Text = "Меню"
        ' 
        ' ПомощьToolStripMenuItem1
        ' 
        ПомощьToolStripMenuItem1.Name = "ПомощьToolStripMenuItem1"
        ПомощьToolStripMenuItem1.ShortcutKeys = Keys.F1
        ПомощьToolStripMenuItem1.Size = New Size(176, 26)
        ПомощьToolStripMenuItem1.Text = "Помощь"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 131)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Vertical
        TextBox1.Size = New Size(308, 125)
        TextBox1.TabIndex = 11
        ' 
        ' AppRun
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(332, 303)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "AppRun"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Блокировка серверов Tanks Blitz"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ПомощьToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ПомощьToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox

End Class
