<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.name0 = New System.Windows.Forms.TextBox()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.name2 = New System.Windows.Forms.TextBox()
        Me.skill0 = New System.Windows.Forms.TextBox()
        Me.dayCount = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'name0
        '
        Me.name0.BackColor = System.Drawing.Color.Black
        Me.name0.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name0.ForeColor = System.Drawing.Color.White
        Me.name0.Location = New System.Drawing.Point(158, 99)
        Me.name0.Name = "name0"
        Me.name0.ReadOnly = True
        Me.name0.Size = New System.Drawing.Size(138, 26)
        Me.name0.TabIndex = 1
        Me.name0.Text = "Günther"
        Me.name0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name1
        '
        Me.name1.BackColor = System.Drawing.Color.Black
        Me.name1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.ForeColor = System.Drawing.Color.White
        Me.name1.Location = New System.Drawing.Point(314, 99)
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        Me.name1.Size = New System.Drawing.Size(138, 26)
        Me.name1.TabIndex = 2
        Me.name1.Text = "Karl"
        Me.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name2
        '
        Me.name2.BackColor = System.Drawing.Color.Black
        Me.name2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name2.ForeColor = System.Drawing.Color.White
        Me.name2.Location = New System.Drawing.Point(472, 99)
        Me.name2.Name = "name2"
        Me.name2.ReadOnly = True
        Me.name2.Size = New System.Drawing.Size(138, 26)
        Me.name2.TabIndex = 3
        Me.name2.Text = "Lisa"
        Me.name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'skill0
        '
        Me.skill0.BackColor = System.Drawing.Color.Black
        Me.skill0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skill0.ForeColor = System.Drawing.Color.White
        Me.skill0.Location = New System.Drawing.Point(12, 203)
        Me.skill0.Name = "skill0"
        Me.skill0.ReadOnly = True
        Me.skill0.Size = New System.Drawing.Size(125, 20)
        Me.skill0.TabIndex = 4
        Me.skill0.Text = "Strength"
        '
        'dayCount
        '
        Me.dayCount.BackColor = System.Drawing.Color.Black
        Me.dayCount.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayCount.ForeColor = System.Drawing.Color.White
        Me.dayCount.Location = New System.Drawing.Point(12, 12)
        Me.dayCount.Name = "dayCount"
        Me.dayCount.ReadOnly = True
        Me.dayCount.Size = New System.Drawing.Size(138, 36)
        Me.dayCount.TabIndex = 6
        Me.dayCount.Text = "DAY 3"
        Me.dayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(579, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(209, 36)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "Rations: 2 (-1)"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(650, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 36)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "GO!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Black
        Me.TextBox2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(12, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(125, 20)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "Intelligence"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Black
        Me.TextBox3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(12, 131)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(125, 26)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "Health"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(12, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(125, 26)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.Text = "Hunger"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(12, 255)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(125, 20)
        Me.TextBox5.TabIndex = 18
        Me.TextBox5.Text = "Agility"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Black
        Me.TextBox6.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(158, 203)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(138, 20)
        Me.TextBox6.TabIndex = 19
        Me.TextBox6.Text = "very strong"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Black
        Me.TextBox7.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(158, 229)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(138, 20)
        Me.TextBox7.TabIndex = 20
        Me.TextBox7.Text = "idiot"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Black
        Me.TextBox8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(158, 255)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(138, 20)
        Me.TextBox8.TabIndex = 21
        Me.TextBox8.Text = "somewhat agile"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Black
        Me.TextBox11.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.ForeColor = System.Drawing.Color.White
        Me.TextBox11.Location = New System.Drawing.Point(314, 162)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(138, 26)
        Me.TextBox11.TabIndex = 24
        Me.TextBox11.Text = "░░░░        +1"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.Color.Black
        Me.TextBox15.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.ForeColor = System.Drawing.Color.White
        Me.TextBox15.Location = New System.Drawing.Point(314, 130)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.ReadOnly = True
        Me.TextBox15.Size = New System.Drawing.Size(138, 26)
        Me.TextBox15.TabIndex = 28
        Me.TextBox15.Text = "░░░░░░░░"
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.Color.Black
        Me.TextBox16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.ForeColor = System.Drawing.Color.White
        Me.TextBox16.Location = New System.Drawing.Point(472, 163)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(138, 26)
        Me.TextBox16.TabIndex = 29
        Me.TextBox16.Text = "░░░░░░░░░░░░"
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.Color.Black
        Me.TextBox17.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.ForeColor = System.Drawing.Color.White
        Me.TextBox17.Location = New System.Drawing.Point(472, 131)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(138, 26)
        Me.TextBox17.TabIndex = 30
        Me.TextBox17.Text = "░░░░"
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.Color.Black
        Me.TextBox18.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.ForeColor = System.Drawing.Color.White
        Me.TextBox18.Location = New System.Drawing.Point(158, 163)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(138, 26)
        Me.TextBox18.TabIndex = 31
        Me.TextBox18.Text = "░░░░"
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.Color.Black
        Me.TextBox19.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.ForeColor = System.Drawing.Color.White
        Me.TextBox19.Location = New System.Drawing.Point(158, 130)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(138, 26)
        Me.TextBox19.TabIndex = 32
        Me.TextBox19.Text = "░░░░░░░░"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Black
        Me.TextBox9.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(12, 281)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(125, 20)
        Me.TextBox9.TabIndex = 33
        Me.TextBox9.Text = "Social"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.Black
        Me.TextBox10.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.ForeColor = System.Drawing.Color.White
        Me.TextBox10.Location = New System.Drawing.Point(12, 307)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(125, 20)
        Me.TextBox10.TabIndex = 34
        Me.TextBox10.Text = "Perception"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.Color.Black
        Me.TextBox12.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.Color.White
        Me.TextBox12.Location = New System.Drawing.Point(158, 281)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(138, 20)
        Me.TextBox12.TabIndex = 35
        Me.TextBox12.Text = "very bad"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.Color.Black
        Me.TextBox13.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.ForeColor = System.Drawing.Color.White
        Me.TextBox13.Location = New System.Drawing.Point(158, 307)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(138, 20)
        Me.TextBox13.TabIndex = 36
        Me.TextBox13.Text = "fantastic"
        Me.TextBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.Color.Black
        Me.TextBox14.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.ForeColor = System.Drawing.Color.White
        Me.TextBox14.Location = New System.Drawing.Point(12, 353)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(125, 26)
        Me.TextBox14.TabIndex = 37
        Me.TextBox14.Text = "Task"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Rest", "Hunt", "Explore", "Trade"})
        Me.ComboBox1.Location = New System.Drawing.Point(472, 349)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 27)
        Me.ComboBox1.TabIndex = 40
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 19
        Me.ListBox1.Items.AddRange(New Object() {"Rest", "Hunt", "Explore", "Trade"})
        Me.ListBox1.Location = New System.Drawing.Point(158, 353)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(138, 23)
        Me.ListBox1.TabIndex = 38
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.ForeColor = System.Drawing.Color.White
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 19
        Me.ListBox2.Items.AddRange(New Object() {"Rest", "Hunt", "Explore", "Trade"})
        Me.ListBox2.Location = New System.Drawing.Point(314, 353)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(138, 23)
        Me.ListBox2.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dayCount)
        Me.Controls.Add(Me.skill0)
        Me.Controls.Add(Me.name2)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.name0)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name0 As TextBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents name2 As TextBox
    Friend WithEvents skill0 As TextBox
    Friend WithEvents dayCount As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
