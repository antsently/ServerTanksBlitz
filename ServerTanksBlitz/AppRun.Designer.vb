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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppRun))
        BlockButton = New Button()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        UnblockButton = New Button()
        TextBoxOutput = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        КопироватьToolStripMenuItem = New ToolStripMenuItem()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' BlockButton
        ' 
        BlockButton.Location = New Point(12, 262)
        BlockButton.Name = "BlockButton"
        BlockButton.Size = New Size(135, 30)
        BlockButton.TabIndex = 1
        BlockButton.Text = "Заблокировать"
        BlockButton.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Location = New Point(44, 172)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 2
        CheckBox1.Text = "Сервер С0"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(44, 202)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(103, 24)
        CheckBox2.TabIndex = 3
        CheckBox2.Text = "Сервер С1"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(44, 232)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(103, 24)
        CheckBox3.TabIndex = 4
        CheckBox3.Text = "Сервер С2"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.Location = New Point(185, 172)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(103, 24)
        CheckBox4.TabIndex = 5
        CheckBox4.Text = "Сервер С3"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(185, 202)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(139, 24)
        CheckBox5.TabIndex = 6
        CheckBox5.Text = "Сервер С4 (Rip)"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(185, 232)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(103, 24)
        CheckBox6.TabIndex = 7
        CheckBox6.Text = "Сервер С5"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' UnblockButton
        ' 
        UnblockButton.Enabled = False
        UnblockButton.Location = New Point(185, 262)
        UnblockButton.Name = "UnblockButton"
        UnblockButton.Size = New Size(135, 30)
        UnblockButton.TabIndex = 8
        UnblockButton.Text = "Разблокировать"
        UnblockButton.UseVisualStyleBackColor = True
        ' 
        ' TextBoxOutput
        ' 
        TextBoxOutput.BackColor = Color.AliceBlue
        TextBoxOutput.BorderStyle = BorderStyle.None
        TextBoxOutput.ContextMenuStrip = ContextMenuStrip1
        TextBoxOutput.Location = New Point(12, 12)
        TextBoxOutput.Multiline = True
        TextBoxOutput.Name = "TextBoxOutput"
        TextBoxOutput.ScrollBars = ScrollBars.Vertical
        TextBoxOutput.ShortcutsEnabled = False
        TextBoxOutput.Size = New Size(308, 154)
        TextBoxOutput.TabIndex = 11
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {КопироватьToolStripMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(163, 28)
        ' 
        ' КопироватьToolStripMenuItem
        ' 
        КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        КопироватьToolStripMenuItem.Size = New Size(162, 24)
        КопироватьToolStripMenuItem.Text = "Копировать"
        ' 
        ' AppRun
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(332, 303)
        Controls.Add(TextBoxOutput)
        Controls.Add(UnblockButton)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(BlockButton)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AppRun"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Блокировка серверов Tanks Blitz"
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BlockButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents UnblockButton As Button
    Friend WithEvents TextBoxOutput As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents КопироватьToolStripMenuItem As ToolStripMenuItem

End Class
