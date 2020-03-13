﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.splash = New System.Windows.Forms.TabPage()
        Me.newGameBtn = New System.Windows.Forms.Button()
        Me.loadGameBtn = New System.Windows.Forms.Button()
        Me.newgame = New System.Windows.Forms.TabPage()
        Me.Back = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.Difficulty = New System.Windows.Forms.ComboBox()
        Me.manual = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.main = New System.Windows.Forms.TabPage()
        Me.manualBtn = New System.Windows.Forms.Button()
        Me.charSkills2 = New System.Windows.Forms.ListBox()
        Me.charSkills1 = New System.Windows.Forms.ListBox()
        Me.charSkills0 = New System.Windows.Forms.ListBox()
        Me.foodCounter = New System.Windows.Forms.TextBox()
        Me.dayCounter = New System.Windows.Forms.TextBox()
        Me.task0 = New System.Windows.Forms.ComboBox()
        Me.GO = New System.Windows.Forms.Button()
        Me.task2 = New System.Windows.Forms.ComboBox()
        Me.name2 = New System.Windows.Forms.TextBox()
        Me.hungerbar2 = New System.Windows.Forms.TextBox()
        Me.healthBar2 = New System.Windows.Forms.TextBox()
        Me.charPic2 = New System.Windows.Forms.PictureBox()
        Me.task1 = New System.Windows.Forms.ComboBox()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.hungerBar1 = New System.Windows.Forms.TextBox()
        Me.healthBar1 = New System.Windows.Forms.TextBox()
        Me.charPic1 = New System.Windows.Forms.PictureBox()
        Me.name0 = New System.Windows.Forms.TextBox()
        Me.hungerBar0 = New System.Windows.Forms.TextBox()
        Me.healthBar0 = New System.Windows.Forms.TextBox()
        Me.charPic0 = New System.Windows.Forms.PictureBox()
        Me.eventPage = New System.Windows.Forms.TabPage()
        Me.eventGoBack = New System.Windows.Forms.Button()
        Me.eventOutcomeBox = New System.Windows.Forms.RichTextBox()
        Me.eventTextBox = New System.Windows.Forms.RichTextBox()
        Me.eventAction1 = New System.Windows.Forms.Button()
        Me.eventAction0 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.splash.SuspendLayout()
        Me.newgame.SuspendLayout()
        Me.manual.SuspendLayout()
        Me.main.SuspendLayout()
        CType(Me.charPic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.charPic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.charPic0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.eventPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.splash)
        Me.TabControl.Controls.Add(Me.newgame)
        Me.TabControl.Controls.Add(Me.manual)
        Me.TabControl.Controls.Add(Me.main)
        Me.TabControl.Controls.Add(Me.eventPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(776, 426)
        Me.TabControl.TabIndex = 0
        '
        'splash
        '
        Me.splash.Controls.Add(Me.newGameBtn)
        Me.splash.Controls.Add(Me.loadGameBtn)
        Me.splash.Location = New System.Drawing.Point(4, 22)
        Me.splash.Name = "splash"
        Me.splash.Padding = New System.Windows.Forms.Padding(3)
        Me.splash.Size = New System.Drawing.Size(768, 400)
        Me.splash.TabIndex = 0
        Me.splash.Text = "Start"
        Me.splash.UseVisualStyleBackColor = True
        '
        'newGameBtn
        '
        Me.newGameBtn.Location = New System.Drawing.Point(29, 157)
        Me.newGameBtn.Name = "newGameBtn"
        Me.newGameBtn.Size = New System.Drawing.Size(297, 86)
        Me.newGameBtn.TabIndex = 3
        Me.newGameBtn.Text = "Neues Spiel"
        Me.newGameBtn.UseVisualStyleBackColor = True
        '
        'loadGameBtn
        '
        Me.loadGameBtn.Location = New System.Drawing.Point(442, 157)
        Me.loadGameBtn.Name = "loadGameBtn"
        Me.loadGameBtn.Size = New System.Drawing.Size(297, 86)
        Me.loadGameBtn.TabIndex = 2
        Me.loadGameBtn.Text = "Spiel laden"
        Me.loadGameBtn.UseVisualStyleBackColor = True
        '
        'newgame
        '
        Me.newgame.Controls.Add(Me.Back)
        Me.newgame.Controls.Add(Me.Start)
        Me.newgame.Controls.Add(Me.Difficulty)
        Me.newgame.Location = New System.Drawing.Point(4, 22)
        Me.newgame.Name = "newgame"
        Me.newgame.Size = New System.Drawing.Size(768, 400)
        Me.newgame.TabIndex = 3
        Me.newgame.Text = "start"
        Me.newgame.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(29, 244)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(297, 86)
        Me.Back.TabIndex = 7
        Me.Back.Text = "Zurück"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(442, 244)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(297, 86)
        Me.Start.TabIndex = 6
        Me.Start.Text = "Spiel starten"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Difficulty
        '
        Me.Difficulty.FormattingEnabled = True
        Me.Difficulty.Items.AddRange(New Object() {"Leicht (Ø Skill =15)", "Mittel (Ø Skill =10)", "Schwer (Ø Skill = 5)", "Unmöglich (Alle Skills = 0)"})
        Me.Difficulty.Location = New System.Drawing.Point(442, 70)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(297, 21)
        Me.Difficulty.TabIndex = 5
        '
        'manual
        '
        Me.manual.Controls.Add(Me.Label1)
        Me.manual.Location = New System.Drawing.Point(4, 22)
        Me.manual.Name = "manual"
        Me.manual.Padding = New System.Windows.Forms.Padding(3)
        Me.manual.Size = New System.Drawing.Size(768, 400)
        Me.manual.TabIndex = 1
        Me.manual.Text = "Anleitung"
        Me.manual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(264, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hier entsteht bald eine Anleitung"
        '
        'main
        '
        Me.main.BackColor = System.Drawing.Color.DarkSlateGray
        Me.main.Controls.Add(Me.manualBtn)
        Me.main.Controls.Add(Me.charSkills2)
        Me.main.Controls.Add(Me.charSkills1)
        Me.main.Controls.Add(Me.charSkills0)
        Me.main.Controls.Add(Me.foodCounter)
        Me.main.Controls.Add(Me.dayCounter)
        Me.main.Controls.Add(Me.task0)
        Me.main.Controls.Add(Me.GO)
        Me.main.Controls.Add(Me.task2)
        Me.main.Controls.Add(Me.name2)
        Me.main.Controls.Add(Me.hungerbar2)
        Me.main.Controls.Add(Me.healthBar2)
        Me.main.Controls.Add(Me.charPic2)
        Me.main.Controls.Add(Me.task1)
        Me.main.Controls.Add(Me.name1)
        Me.main.Controls.Add(Me.hungerBar1)
        Me.main.Controls.Add(Me.healthBar1)
        Me.main.Controls.Add(Me.charPic1)
        Me.main.Controls.Add(Me.name0)
        Me.main.Controls.Add(Me.hungerBar0)
        Me.main.Controls.Add(Me.healthBar0)
        Me.main.Controls.Add(Me.charPic0)
        Me.main.Location = New System.Drawing.Point(4, 22)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(768, 400)
        Me.main.TabIndex = 2
        Me.main.Text = "main"
        '
        'manualBtn
        '
        Me.manualBtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.manualBtn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.manualBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.manualBtn.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manualBtn.ForeColor = System.Drawing.Color.White
        Me.manualBtn.Location = New System.Drawing.Point(731, 3)
        Me.manualBtn.Name = "manualBtn"
        Me.manualBtn.Size = New System.Drawing.Size(34, 36)
        Me.manualBtn.TabIndex = 72
        Me.manualBtn.Text = "?"
        Me.manualBtn.UseVisualStyleBackColor = False
        '
        'charSkills2
        '
        Me.charSkills2.BackColor = System.Drawing.Color.Black
        Me.charSkills2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charSkills2.ForeColor = System.Drawing.Color.White
        Me.charSkills2.FormattingEnabled = True
        Me.charSkills2.ItemHeight = 18
        Me.charSkills2.Location = New System.Drawing.Point(562, 105)
        Me.charSkills2.Name = "charSkills2"
        Me.charSkills2.Size = New System.Drawing.Size(158, 238)
        Me.charSkills2.TabIndex = 67
        '
        'charSkills1
        '
        Me.charSkills1.BackColor = System.Drawing.Color.Black
        Me.charSkills1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charSkills1.ForeColor = System.Drawing.Color.White
        Me.charSkills1.FormattingEnabled = True
        Me.charSkills1.ItemHeight = 18
        Me.charSkills1.Items.AddRange(New Object() {""})
        Me.charSkills1.Location = New System.Drawing.Point(296, 105)
        Me.charSkills1.Name = "charSkills1"
        Me.charSkills1.Size = New System.Drawing.Size(158, 238)
        Me.charSkills1.TabIndex = 66
        '
        'charSkills0
        '
        Me.charSkills0.BackColor = System.Drawing.Color.Black
        Me.charSkills0.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.charSkills0.ForeColor = System.Drawing.Color.White
        Me.charSkills0.FormattingEnabled = True
        Me.charSkills0.ItemHeight = 18
        Me.charSkills0.Location = New System.Drawing.Point(30, 105)
        Me.charSkills0.Name = "charSkills0"
        Me.charSkills0.Size = New System.Drawing.Size(158, 238)
        Me.charSkills0.TabIndex = 5
        '
        'foodCounter
        '
        Me.foodCounter.BackColor = System.Drawing.Color.White
        Me.foodCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.foodCounter.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodCounter.ForeColor = System.Drawing.Color.Black
        Me.foodCounter.Location = New System.Drawing.Point(194, 12)
        Me.foodCounter.Name = "foodCounter"
        Me.foodCounter.ReadOnly = True
        Me.foodCounter.Size = New System.Drawing.Size(181, 39)
        Me.foodCounter.TabIndex = 71
        Me.foodCounter.Text = "0 RATIONEN"
        Me.foodCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dayCounter
        '
        Me.dayCounter.BackColor = System.Drawing.Color.White
        Me.dayCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.dayCounter.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayCounter.ForeColor = System.Drawing.Color.Black
        Me.dayCounter.Location = New System.Drawing.Point(30, 12)
        Me.dayCounter.Name = "dayCounter"
        Me.dayCounter.ReadOnly = True
        Me.dayCounter.Size = New System.Drawing.Size(158, 39)
        Me.dayCounter.TabIndex = 70
        Me.dayCounter.Text = "TAG 0"
        '
        'task0
        '
        Me.task0.BackColor = System.Drawing.Color.Black
        Me.task0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task0.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task0.ForeColor = System.Drawing.Color.White
        Me.task0.FormattingEnabled = True
        Me.task0.Location = New System.Drawing.Point(30, 306)
        Me.task0.Name = "task0"
        Me.task0.Size = New System.Drawing.Size(158, 32)
        Me.task0.TabIndex = 69
        '
        'GO
        '
        Me.GO.BackColor = System.Drawing.Color.White
        Me.GO.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GO.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GO.ForeColor = System.Drawing.Color.Black
        Me.GO.Location = New System.Drawing.Point(613, 347)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(138, 36)
        Me.GO.TabIndex = 68
        Me.GO.Text = "GO!"
        Me.GO.UseVisualStyleBackColor = False
        '
        'task2
        '
        Me.task2.BackColor = System.Drawing.Color.Black
        Me.task2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task2.ForeColor = System.Drawing.Color.White
        Me.task2.FormattingEnabled = True
        Me.task2.Location = New System.Drawing.Point(562, 306)
        Me.task2.Name = "task2"
        Me.task2.Size = New System.Drawing.Size(158, 32)
        Me.task2.TabIndex = 65
        '
        'name2
        '
        Me.name2.BackColor = System.Drawing.Color.Black
        Me.name2.Cursor = System.Windows.Forms.Cursors.Default
        Me.name2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name2.ForeColor = System.Drawing.Color.White
        Me.name2.Location = New System.Drawing.Point(562, 70)
        Me.name2.Name = "name2"
        Me.name2.ReadOnly = True
        Me.name2.Size = New System.Drawing.Size(158, 32)
        Me.name2.TabIndex = 64
        Me.name2.Text = "NODATA"
        Me.name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hungerbar2
        '
        Me.hungerbar2.BackColor = System.Drawing.Color.Black
        Me.hungerbar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerbar2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerbar2.ForeColor = System.Drawing.Color.White
        Me.hungerbar2.Location = New System.Drawing.Point(562, 268)
        Me.hungerbar2.Name = "hungerbar2"
        Me.hungerbar2.ReadOnly = True
        Me.hungerbar2.Size = New System.Drawing.Size(158, 32)
        Me.hungerbar2.TabIndex = 63
        Me.hungerbar2.Text = "NODATA"
        '
        'healthBar2
        '
        Me.healthBar2.BackColor = System.Drawing.Color.Black
        Me.healthBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar2.ForeColor = System.Drawing.Color.Red
        Me.healthBar2.Location = New System.Drawing.Point(562, 230)
        Me.healthBar2.Name = "healthBar2"
        Me.healthBar2.ReadOnly = True
        Me.healthBar2.Size = New System.Drawing.Size(158, 32)
        Me.healthBar2.TabIndex = 62
        Me.healthBar2.Text = "NODATA"
        '
        'charPic2
        '
        Me.charPic2.Image = CType(resources.GetObject("charPic2.Image"), System.Drawing.Image)
        Me.charPic2.InitialImage = CType(resources.GetObject("charPic2.InitialImage"), System.Drawing.Image)
        Me.charPic2.Location = New System.Drawing.Point(562, 105)
        Me.charPic2.Name = "charPic2"
        Me.charPic2.Size = New System.Drawing.Size(158, 119)
        Me.charPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.charPic2.TabIndex = 61
        Me.charPic2.TabStop = False
        '
        'task1
        '
        Me.task1.BackColor = System.Drawing.Color.Black
        Me.task1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task1.ForeColor = System.Drawing.Color.White
        Me.task1.FormattingEnabled = True
        Me.task1.Location = New System.Drawing.Point(296, 306)
        Me.task1.Name = "task1"
        Me.task1.Size = New System.Drawing.Size(158, 32)
        Me.task1.TabIndex = 60
        '
        'name1
        '
        Me.name1.BackColor = System.Drawing.Color.Black
        Me.name1.Cursor = System.Windows.Forms.Cursors.Default
        Me.name1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.ForeColor = System.Drawing.Color.White
        Me.name1.Location = New System.Drawing.Point(296, 70)
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        Me.name1.Size = New System.Drawing.Size(158, 32)
        Me.name1.TabIndex = 59
        Me.name1.Text = "NODATA"
        Me.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hungerBar1
        '
        Me.hungerBar1.BackColor = System.Drawing.Color.Black
        Me.hungerBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerBar1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerBar1.ForeColor = System.Drawing.Color.White
        Me.hungerBar1.Location = New System.Drawing.Point(296, 268)
        Me.hungerBar1.Name = "hungerBar1"
        Me.hungerBar1.ReadOnly = True
        Me.hungerBar1.Size = New System.Drawing.Size(158, 32)
        Me.hungerBar1.TabIndex = 58
        Me.hungerBar1.Text = "NODATA"
        '
        'healthBar1
        '
        Me.healthBar1.BackColor = System.Drawing.Color.Black
        Me.healthBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar1.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar1.ForeColor = System.Drawing.Color.Red
        Me.healthBar1.Location = New System.Drawing.Point(296, 230)
        Me.healthBar1.Name = "healthBar1"
        Me.healthBar1.ReadOnly = True
        Me.healthBar1.Size = New System.Drawing.Size(158, 32)
        Me.healthBar1.TabIndex = 57
        Me.healthBar1.Text = "NODATA"
        '
        'charPic1
        '
        Me.charPic1.Image = CType(resources.GetObject("charPic1.Image"), System.Drawing.Image)
        Me.charPic1.InitialImage = CType(resources.GetObject("charPic1.InitialImage"), System.Drawing.Image)
        Me.charPic1.Location = New System.Drawing.Point(296, 105)
        Me.charPic1.Name = "charPic1"
        Me.charPic1.Size = New System.Drawing.Size(158, 119)
        Me.charPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.charPic1.TabIndex = 56
        Me.charPic1.TabStop = False
        '
        'name0
        '
        Me.name0.BackColor = System.Drawing.Color.Black
        Me.name0.Cursor = System.Windows.Forms.Cursors.Default
        Me.name0.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name0.ForeColor = System.Drawing.Color.White
        Me.name0.Location = New System.Drawing.Point(30, 70)
        Me.name0.Name = "name0"
        Me.name0.ReadOnly = True
        Me.name0.Size = New System.Drawing.Size(158, 32)
        Me.name0.TabIndex = 35
        Me.name0.Text = "NODATA"
        Me.name0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hungerBar0
        '
        Me.hungerBar0.BackColor = System.Drawing.Color.Black
        Me.hungerBar0.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerBar0.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerBar0.ForeColor = System.Drawing.Color.White
        Me.hungerBar0.Location = New System.Drawing.Point(30, 268)
        Me.hungerBar0.Name = "hungerBar0"
        Me.hungerBar0.ReadOnly = True
        Me.hungerBar0.Size = New System.Drawing.Size(158, 32)
        Me.hungerBar0.TabIndex = 34
        Me.hungerBar0.Text = "NODATA"
        '
        'healthBar0
        '
        Me.healthBar0.BackColor = System.Drawing.Color.Black
        Me.healthBar0.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar0.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar0.ForeColor = System.Drawing.Color.Red
        Me.healthBar0.Location = New System.Drawing.Point(30, 230)
        Me.healthBar0.Name = "healthBar0"
        Me.healthBar0.ReadOnly = True
        Me.healthBar0.Size = New System.Drawing.Size(158, 32)
        Me.healthBar0.TabIndex = 33
        Me.healthBar0.Text = "NODATA"
        '
        'charPic0
        '
        Me.charPic0.Image = CType(resources.GetObject("charPic0.Image"), System.Drawing.Image)
        Me.charPic0.InitialImage = CType(resources.GetObject("charPic0.InitialImage"), System.Drawing.Image)
        Me.charPic0.Location = New System.Drawing.Point(30, 105)
        Me.charPic0.Name = "charPic0"
        Me.charPic0.Size = New System.Drawing.Size(158, 119)
        Me.charPic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.charPic0.TabIndex = 2
        Me.charPic0.TabStop = False
        '
        'eventPage
        '
        Me.eventPage.BackColor = System.Drawing.Color.DarkSlateGray
        Me.eventPage.Controls.Add(Me.eventGoBack)
        Me.eventPage.Controls.Add(Me.eventOutcomeBox)
        Me.eventPage.Controls.Add(Me.eventTextBox)
        Me.eventPage.Controls.Add(Me.eventAction1)
        Me.eventPage.Controls.Add(Me.eventAction0)
        Me.eventPage.Controls.Add(Me.Label3)
        Me.eventPage.Location = New System.Drawing.Point(4, 22)
        Me.eventPage.Name = "eventPage"
        Me.eventPage.Size = New System.Drawing.Size(768, 400)
        Me.eventPage.TabIndex = 4
        Me.eventPage.Text = "eventPage"
        '
        'eventGoBack
        '
        Me.eventGoBack.BackColor = System.Drawing.Color.White
        Me.eventGoBack.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.eventGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eventGoBack.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventGoBack.ForeColor = System.Drawing.Color.Black
        Me.eventGoBack.Location = New System.Drawing.Point(540, 340)
        Me.eventGoBack.Name = "eventGoBack"
        Me.eventGoBack.Size = New System.Drawing.Size(199, 36)
        Me.eventGoBack.TabIndex = 73
        Me.eventGoBack.Text = "OK"
        Me.eventGoBack.UseVisualStyleBackColor = False
        '
        'eventOutcomeBox
        '
        Me.eventOutcomeBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.eventOutcomeBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.eventOutcomeBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventOutcomeBox.ForeColor = System.Drawing.Color.White
        Me.eventOutcomeBox.Location = New System.Drawing.Point(27, 158)
        Me.eventOutcomeBox.Name = "eventOutcomeBox"
        Me.eventOutcomeBox.Size = New System.Drawing.Size(712, 126)
        Me.eventOutcomeBox.TabIndex = 72
        Me.eventOutcomeBox.Text = ""
        '
        'eventTextBox
        '
        Me.eventTextBox.BackColor = System.Drawing.Color.DarkSlateGray
        Me.eventTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.eventTextBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventTextBox.ForeColor = System.Drawing.Color.White
        Me.eventTextBox.Location = New System.Drawing.Point(27, 26)
        Me.eventTextBox.Name = "eventTextBox"
        Me.eventTextBox.Size = New System.Drawing.Size(712, 126)
        Me.eventTextBox.TabIndex = 71
        Me.eventTextBox.Text = "Nothing happened, this is the place where Text for an event would be placed"
        '
        'eventAction1
        '
        Me.eventAction1.BackColor = System.Drawing.Color.White
        Me.eventAction1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.eventAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eventAction1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventAction1.ForeColor = System.Drawing.Color.Black
        Me.eventAction1.Location = New System.Drawing.Point(232, 314)
        Me.eventAction1.Name = "eventAction1"
        Me.eventAction1.Size = New System.Drawing.Size(199, 36)
        Me.eventAction1.TabIndex = 70
        Me.eventAction1.Text = "Action 1"
        Me.eventAction1.UseVisualStyleBackColor = False
        '
        'eventAction0
        '
        Me.eventAction0.BackColor = System.Drawing.Color.White
        Me.eventAction0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.eventAction0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eventAction0.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eventAction0.ForeColor = System.Drawing.Color.Black
        Me.eventAction0.Location = New System.Drawing.Point(27, 314)
        Me.eventAction0.Name = "eventAction0"
        Me.eventAction0.Size = New System.Drawing.Size(199, 36)
        Me.eventAction0.TabIndex = 69
        Me.eventAction0.Text = "Action 0"
        Me.eventAction0.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 1
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.TabControl.ResumeLayout(False)
        Me.splash.ResumeLayout(False)
        Me.newgame.ResumeLayout(False)
        Me.manual.ResumeLayout(False)
        Me.manual.PerformLayout()
        Me.main.ResumeLayout(False)
        Me.main.PerformLayout()
        CType(Me.charPic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.charPic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.charPic0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.eventPage.ResumeLayout(False)
        Me.eventPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents splash As TabPage
    Friend WithEvents manual As TabPage
    Friend WithEvents main As TabPage
    Friend WithEvents newgame As TabPage
    Friend WithEvents newGameBtn As Button
    Friend WithEvents loadGameBtn As Button
    Friend WithEvents Back As Button
    Friend WithEvents Start As Button
    Friend WithEvents Difficulty As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents charPic0 As PictureBox
    Friend WithEvents charSkills0 As ListBox
    Friend WithEvents healthBar0 As TextBox
    Friend WithEvents hungerBar0 As TextBox
    Friend WithEvents name0 As TextBox
    Friend WithEvents task2 As ComboBox
    Friend WithEvents name2 As TextBox
    Friend WithEvents hungerbar2 As TextBox
    Friend WithEvents healthBar2 As TextBox
    Friend WithEvents charPic2 As PictureBox
    Friend WithEvents task1 As ComboBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents hungerBar1 As TextBox
    Friend WithEvents healthBar1 As TextBox
    Friend WithEvents charPic1 As PictureBox
    Friend WithEvents charSkills2 As ListBox
    Friend WithEvents charSkills1 As ListBox
    Friend WithEvents GO As Button
    Friend WithEvents task0 As ComboBox
    Friend WithEvents foodCounter As TextBox
    Friend WithEvents dayCounter As TextBox
    Friend WithEvents manualBtn As Button
    Friend WithEvents eventPage As TabPage
    Friend WithEvents eventTextBox As RichTextBox
    Friend WithEvents eventAction1 As Button
    Friend WithEvents eventAction0 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents eventOutcomeBox As RichTextBox
    Friend WithEvents eventGoBack As Button
End Class