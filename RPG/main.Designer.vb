﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Me.name0 = New System.Windows.Forms.TextBox()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.name2 = New System.Windows.Forms.TextBox()
        Me.strengthTitle = New System.Windows.Forms.TextBox()
        Me.dayCounter = New System.Windows.Forms.TextBox()
        Me.foodCounter = New System.Windows.Forms.TextBox()
        Me.GO = New System.Windows.Forms.Button()
        Me.intelligenceTitle = New System.Windows.Forms.TextBox()
        Me.healthTitle = New System.Windows.Forms.TextBox()
        Me.hungerTitle = New System.Windows.Forms.TextBox()
        Me.agilityTitle = New System.Windows.Forms.TextBox()
        Me.strength0 = New System.Windows.Forms.TextBox()
        Me.intelligence0 = New System.Windows.Forms.TextBox()
        Me.agility0 = New System.Windows.Forms.TextBox()
        Me.hungerBar1 = New System.Windows.Forms.TextBox()
        Me.healthBar1 = New System.Windows.Forms.TextBox()
        Me.hungerBar2 = New System.Windows.Forms.TextBox()
        Me.healthBar2 = New System.Windows.Forms.TextBox()
        Me.hungerBar0 = New System.Windows.Forms.TextBox()
        Me.healthBar0 = New System.Windows.Forms.TextBox()
        Me.mentalTitle = New System.Windows.Forms.TextBox()
        Me.perceptionTitle = New System.Windows.Forms.TextBox()
        Me.mental0 = New System.Windows.Forms.TextBox()
        Me.perception0 = New System.Windows.Forms.TextBox()
        Me.taskTitle = New System.Windows.Forms.TextBox()
        Me.strength1 = New System.Windows.Forms.TextBox()
        Me.intelligence1 = New System.Windows.Forms.TextBox()
        Me.agility1 = New System.Windows.Forms.TextBox()
        Me.mental1 = New System.Windows.Forms.TextBox()
        Me.perception1 = New System.Windows.Forms.TextBox()
        Me.strength2 = New System.Windows.Forms.TextBox()
        Me.intelligence2 = New System.Windows.Forms.TextBox()
        Me.agility2 = New System.Windows.Forms.TextBox()
        Me.mental2 = New System.Windows.Forms.TextBox()
        Me.perception2 = New System.Windows.Forms.TextBox()
        Me.MainDataSet1 = New RPG.mainDataSet1()
        Me.CharacterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CharacterTableAdapter = New RPG.mainDataSet1TableAdapters.CharacterTableAdapter()
        Me.TaskBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDataSet = New RPG.mainDataSet()
        Me.TaskTableAdapter = New RPG.mainDataSetTableAdapters.TaskTableAdapter()
        Me.task0 = New System.Windows.Forms.ComboBox()
        Me.task1 = New System.Windows.Forms.ComboBox()
        Me.task2 = New System.Windows.Forms.ComboBox()
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name0
        '
        Me.name0.BackColor = System.Drawing.Color.Black
        Me.name0.Cursor = System.Windows.Forms.Cursors.Default
        Me.name0.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name0.ForeColor = System.Drawing.Color.White
        Me.name0.Location = New System.Drawing.Point(158, 99)
        Me.name0.Name = "name0"
        Me.name0.ReadOnly = True
        Me.name0.Size = New System.Drawing.Size(138, 26)
        Me.name0.TabIndex = 1
        Me.name0.Text = "NO DATA"
        Me.name0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name1
        '
        Me.name1.BackColor = System.Drawing.Color.Black
        Me.name1.Cursor = System.Windows.Forms.Cursors.Default
        Me.name1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name1.ForeColor = System.Drawing.Color.White
        Me.name1.Location = New System.Drawing.Point(314, 99)
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        Me.name1.Size = New System.Drawing.Size(138, 26)
        Me.name1.TabIndex = 2
        Me.name1.Text = "NO DATA"
        Me.name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name2
        '
        Me.name2.BackColor = System.Drawing.Color.Black
        Me.name2.Cursor = System.Windows.Forms.Cursors.Default
        Me.name2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name2.ForeColor = System.Drawing.Color.White
        Me.name2.Location = New System.Drawing.Point(472, 99)
        Me.name2.Name = "name2"
        Me.name2.ReadOnly = True
        Me.name2.Size = New System.Drawing.Size(138, 26)
        Me.name2.TabIndex = 3
        Me.name2.Text = "NO DATA"
        Me.name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'strengthTitle
        '
        Me.strengthTitle.BackColor = System.Drawing.Color.Black
        Me.strengthTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.strengthTitle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strengthTitle.ForeColor = System.Drawing.Color.White
        Me.strengthTitle.Location = New System.Drawing.Point(12, 203)
        Me.strengthTitle.Name = "strengthTitle"
        Me.strengthTitle.ReadOnly = True
        Me.strengthTitle.Size = New System.Drawing.Size(125, 20)
        Me.strengthTitle.TabIndex = 4
        Me.strengthTitle.Text = "Stärke"
        '
        'dayCounter
        '
        Me.dayCounter.BackColor = System.Drawing.Color.Black
        Me.dayCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.dayCounter.Dock = System.Windows.Forms.DockStyle.Left
        Me.dayCounter.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayCounter.ForeColor = System.Drawing.Color.White
        Me.dayCounter.Location = New System.Drawing.Point(0, 0)
        Me.dayCounter.Name = "dayCounter"
        Me.dayCounter.ReadOnly = True
        Me.dayCounter.Size = New System.Drawing.Size(138, 36)
        Me.dayCounter.TabIndex = 6
        Me.dayCounter.Text = "DAY NO DATA"
        Me.dayCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foodCounter
        '
        Me.foodCounter.BackColor = System.Drawing.Color.Black
        Me.foodCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.foodCounter.Dock = System.Windows.Forms.DockStyle.Right
        Me.foodCounter.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodCounter.ForeColor = System.Drawing.Color.White
        Me.foodCounter.Location = New System.Drawing.Point(613, 0)
        Me.foodCounter.Name = "foodCounter"
        Me.foodCounter.ReadOnly = True
        Me.foodCounter.Size = New System.Drawing.Size(209, 36)
        Me.foodCounter.TabIndex = 7
        Me.foodCounter.Text = "Rationen: NO DATA"
        Me.foodCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GO
        '
        Me.GO.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GO.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GO.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GO.ForeColor = System.Drawing.Color.White
        Me.GO.Location = New System.Drawing.Point(650, 389)
        Me.GO.Name = "GO"
        Me.GO.Size = New System.Drawing.Size(138, 36)
        Me.GO.TabIndex = 8
        Me.GO.Text = "GO!"
        Me.GO.UseVisualStyleBackColor = False
        '
        'intelligenceTitle
        '
        Me.intelligenceTitle.BackColor = System.Drawing.Color.Black
        Me.intelligenceTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.intelligenceTitle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intelligenceTitle.ForeColor = System.Drawing.Color.White
        Me.intelligenceTitle.Location = New System.Drawing.Point(12, 229)
        Me.intelligenceTitle.Name = "intelligenceTitle"
        Me.intelligenceTitle.ReadOnly = True
        Me.intelligenceTitle.Size = New System.Drawing.Size(125, 20)
        Me.intelligenceTitle.TabIndex = 9
        Me.intelligenceTitle.Text = "Intelligenz"
        '
        'healthTitle
        '
        Me.healthTitle.BackColor = System.Drawing.Color.Black
        Me.healthTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthTitle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthTitle.ForeColor = System.Drawing.Color.White
        Me.healthTitle.Location = New System.Drawing.Point(12, 131)
        Me.healthTitle.Name = "healthTitle"
        Me.healthTitle.ReadOnly = True
        Me.healthTitle.Size = New System.Drawing.Size(125, 26)
        Me.healthTitle.TabIndex = 11
        Me.healthTitle.Text = "Gesundheit"
        '
        'hungerTitle
        '
        Me.hungerTitle.BackColor = System.Drawing.Color.Black
        Me.hungerTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerTitle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerTitle.ForeColor = System.Drawing.Color.White
        Me.hungerTitle.Location = New System.Drawing.Point(12, 162)
        Me.hungerTitle.Name = "hungerTitle"
        Me.hungerTitle.ReadOnly = True
        Me.hungerTitle.Size = New System.Drawing.Size(125, 26)
        Me.hungerTitle.TabIndex = 12
        Me.hungerTitle.Text = "Hunger"
        '
        'agilityTitle
        '
        Me.agilityTitle.BackColor = System.Drawing.Color.Black
        Me.agilityTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.agilityTitle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agilityTitle.ForeColor = System.Drawing.Color.White
        Me.agilityTitle.Location = New System.Drawing.Point(12, 255)
        Me.agilityTitle.Name = "agilityTitle"
        Me.agilityTitle.ReadOnly = True
        Me.agilityTitle.Size = New System.Drawing.Size(125, 20)
        Me.agilityTitle.TabIndex = 18
        Me.agilityTitle.Text = "Geschicklichkeit"
        '
        'strength0
        '
        Me.strength0.BackColor = System.Drawing.Color.Black
        Me.strength0.Cursor = System.Windows.Forms.Cursors.Default
        Me.strength0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strength0.ForeColor = System.Drawing.Color.White
        Me.strength0.Location = New System.Drawing.Point(158, 203)
        Me.strength0.Name = "strength0"
        Me.strength0.ReadOnly = True
        Me.strength0.Size = New System.Drawing.Size(138, 20)
        Me.strength0.TabIndex = 19
        Me.strength0.Text = "NO DATA"
        Me.strength0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'intelligence0
        '
        Me.intelligence0.BackColor = System.Drawing.Color.Black
        Me.intelligence0.Cursor = System.Windows.Forms.Cursors.Default
        Me.intelligence0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intelligence0.ForeColor = System.Drawing.Color.White
        Me.intelligence0.Location = New System.Drawing.Point(158, 229)
        Me.intelligence0.Name = "intelligence0"
        Me.intelligence0.ReadOnly = True
        Me.intelligence0.Size = New System.Drawing.Size(138, 20)
        Me.intelligence0.TabIndex = 20
        Me.intelligence0.Text = "NO DATA"
        Me.intelligence0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'agility0
        '
        Me.agility0.BackColor = System.Drawing.Color.Black
        Me.agility0.Cursor = System.Windows.Forms.Cursors.Default
        Me.agility0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agility0.ForeColor = System.Drawing.Color.White
        Me.agility0.Location = New System.Drawing.Point(158, 255)
        Me.agility0.Name = "agility0"
        Me.agility0.ReadOnly = True
        Me.agility0.Size = New System.Drawing.Size(138, 20)
        Me.agility0.TabIndex = 21
        Me.agility0.Text = "NO DATA"
        Me.agility0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'hungerBar1
        '
        Me.hungerBar1.BackColor = System.Drawing.Color.Black
        Me.hungerBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerBar1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerBar1.ForeColor = System.Drawing.Color.White
        Me.hungerBar1.Location = New System.Drawing.Point(314, 162)
        Me.hungerBar1.Name = "hungerBar1"
        Me.hungerBar1.ReadOnly = True
        Me.hungerBar1.Size = New System.Drawing.Size(138, 26)
        Me.hungerBar1.TabIndex = 24
        Me.hungerBar1.Text = "NO DATA"
        '
        'healthBar1
        '
        Me.healthBar1.BackColor = System.Drawing.Color.Black
        Me.healthBar1.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar1.ForeColor = System.Drawing.Color.Red
        Me.healthBar1.Location = New System.Drawing.Point(314, 130)
        Me.healthBar1.Name = "healthBar1"
        Me.healthBar1.ReadOnly = True
        Me.healthBar1.Size = New System.Drawing.Size(138, 26)
        Me.healthBar1.TabIndex = 28
        Me.healthBar1.Text = "NO DATA"
        '
        'hungerBar2
        '
        Me.hungerBar2.BackColor = System.Drawing.Color.Black
        Me.hungerBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerBar2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerBar2.ForeColor = System.Drawing.Color.White
        Me.hungerBar2.Location = New System.Drawing.Point(472, 163)
        Me.hungerBar2.Name = "hungerBar2"
        Me.hungerBar2.ReadOnly = True
        Me.hungerBar2.Size = New System.Drawing.Size(138, 26)
        Me.hungerBar2.TabIndex = 29
        Me.hungerBar2.Text = "NO DATA"
        '
        'healthBar2
        '
        Me.healthBar2.BackColor = System.Drawing.Color.Black
        Me.healthBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar2.ForeColor = System.Drawing.Color.Red
        Me.healthBar2.Location = New System.Drawing.Point(472, 131)
        Me.healthBar2.Name = "healthBar2"
        Me.healthBar2.ReadOnly = True
        Me.healthBar2.Size = New System.Drawing.Size(138, 26)
        Me.healthBar2.TabIndex = 30
        Me.healthBar2.Text = "NO DATA"
        '
        'hungerBar0
        '
        Me.hungerBar0.BackColor = System.Drawing.Color.Black
        Me.hungerBar0.Cursor = System.Windows.Forms.Cursors.Default
        Me.hungerBar0.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hungerBar0.ForeColor = System.Drawing.Color.White
        Me.hungerBar0.Location = New System.Drawing.Point(158, 163)
        Me.hungerBar0.Name = "hungerBar0"
        Me.hungerBar0.ReadOnly = True
        Me.hungerBar0.Size = New System.Drawing.Size(138, 26)
        Me.hungerBar0.TabIndex = 31
        Me.hungerBar0.Text = "NO DATA"
        '
        'healthBar0
        '
        Me.healthBar0.BackColor = System.Drawing.Color.Black
        Me.healthBar0.Cursor = System.Windows.Forms.Cursors.Default
        Me.healthBar0.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.healthBar0.ForeColor = System.Drawing.Color.Red
        Me.healthBar0.Location = New System.Drawing.Point(158, 130)
        Me.healthBar0.Name = "healthBar0"
        Me.healthBar0.ReadOnly = True
        Me.healthBar0.Size = New System.Drawing.Size(138, 26)
        Me.healthBar0.TabIndex = 32
        Me.healthBar0.Text = "NO DATA"
        '
        'mentalTitle
        '
        Me.mentalTitle.BackColor = System.Drawing.Color.Black
        Me.mentalTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.mentalTitle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mentalTitle.ForeColor = System.Drawing.Color.White
        Me.mentalTitle.Location = New System.Drawing.Point(12, 281)
        Me.mentalTitle.Name = "mentalTitle"
        Me.mentalTitle.ReadOnly = True
        Me.mentalTitle.Size = New System.Drawing.Size(125, 20)
        Me.mentalTitle.TabIndex = 33
        Me.mentalTitle.Text = "Mental"
        '
        'perceptionTitle
        '
        Me.perceptionTitle.BackColor = System.Drawing.Color.Black
        Me.perceptionTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.perceptionTitle.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perceptionTitle.ForeColor = System.Drawing.Color.White
        Me.perceptionTitle.Location = New System.Drawing.Point(12, 307)
        Me.perceptionTitle.Name = "perceptionTitle"
        Me.perceptionTitle.ReadOnly = True
        Me.perceptionTitle.Size = New System.Drawing.Size(125, 20)
        Me.perceptionTitle.TabIndex = 34
        Me.perceptionTitle.Text = "Wahrnehmung"
        '
        'mental0
        '
        Me.mental0.BackColor = System.Drawing.Color.Black
        Me.mental0.Cursor = System.Windows.Forms.Cursors.Default
        Me.mental0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mental0.ForeColor = System.Drawing.Color.White
        Me.mental0.Location = New System.Drawing.Point(158, 281)
        Me.mental0.Name = "mental0"
        Me.mental0.ReadOnly = True
        Me.mental0.Size = New System.Drawing.Size(138, 20)
        Me.mental0.TabIndex = 35
        Me.mental0.Text = "NO DATA"
        Me.mental0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'perception0
        '
        Me.perception0.BackColor = System.Drawing.Color.Black
        Me.perception0.Cursor = System.Windows.Forms.Cursors.Default
        Me.perception0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perception0.ForeColor = System.Drawing.Color.White
        Me.perception0.Location = New System.Drawing.Point(158, 307)
        Me.perception0.Name = "perception0"
        Me.perception0.ReadOnly = True
        Me.perception0.Size = New System.Drawing.Size(138, 20)
        Me.perception0.TabIndex = 36
        Me.perception0.Text = "NO DATA"
        Me.perception0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'taskTitle
        '
        Me.taskTitle.BackColor = System.Drawing.Color.Black
        Me.taskTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.taskTitle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taskTitle.ForeColor = System.Drawing.Color.White
        Me.taskTitle.Location = New System.Drawing.Point(12, 353)
        Me.taskTitle.Name = "taskTitle"
        Me.taskTitle.ReadOnly = True
        Me.taskTitle.Size = New System.Drawing.Size(125, 26)
        Me.taskTitle.TabIndex = 37
        Me.taskTitle.Text = "Aufgabe"
        '
        'strength1
        '
        Me.strength1.BackColor = System.Drawing.Color.Black
        Me.strength1.Cursor = System.Windows.Forms.Cursors.Default
        Me.strength1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strength1.ForeColor = System.Drawing.Color.White
        Me.strength1.Location = New System.Drawing.Point(314, 203)
        Me.strength1.Name = "strength1"
        Me.strength1.ReadOnly = True
        Me.strength1.Size = New System.Drawing.Size(138, 20)
        Me.strength1.TabIndex = 41
        Me.strength1.Text = "NO DATA"
        Me.strength1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'intelligence1
        '
        Me.intelligence1.BackColor = System.Drawing.Color.Black
        Me.intelligence1.Cursor = System.Windows.Forms.Cursors.Default
        Me.intelligence1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intelligence1.ForeColor = System.Drawing.Color.White
        Me.intelligence1.Location = New System.Drawing.Point(314, 229)
        Me.intelligence1.Name = "intelligence1"
        Me.intelligence1.ReadOnly = True
        Me.intelligence1.Size = New System.Drawing.Size(138, 20)
        Me.intelligence1.TabIndex = 42
        Me.intelligence1.Text = "NO DATA"
        Me.intelligence1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'agility1
        '
        Me.agility1.BackColor = System.Drawing.Color.Black
        Me.agility1.Cursor = System.Windows.Forms.Cursors.Default
        Me.agility1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agility1.ForeColor = System.Drawing.Color.White
        Me.agility1.Location = New System.Drawing.Point(314, 255)
        Me.agility1.Name = "agility1"
        Me.agility1.ReadOnly = True
        Me.agility1.Size = New System.Drawing.Size(138, 20)
        Me.agility1.TabIndex = 43
        Me.agility1.Text = "NO DATA"
        Me.agility1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mental1
        '
        Me.mental1.BackColor = System.Drawing.Color.Black
        Me.mental1.Cursor = System.Windows.Forms.Cursors.Default
        Me.mental1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mental1.ForeColor = System.Drawing.Color.White
        Me.mental1.Location = New System.Drawing.Point(314, 281)
        Me.mental1.Name = "mental1"
        Me.mental1.ReadOnly = True
        Me.mental1.Size = New System.Drawing.Size(138, 20)
        Me.mental1.TabIndex = 44
        Me.mental1.Text = "NO DATA"
        Me.mental1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'perception1
        '
        Me.perception1.BackColor = System.Drawing.Color.Black
        Me.perception1.Cursor = System.Windows.Forms.Cursors.Default
        Me.perception1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perception1.ForeColor = System.Drawing.Color.White
        Me.perception1.Location = New System.Drawing.Point(314, 307)
        Me.perception1.Name = "perception1"
        Me.perception1.ReadOnly = True
        Me.perception1.Size = New System.Drawing.Size(138, 20)
        Me.perception1.TabIndex = 45
        Me.perception1.Text = "NO DATA"
        Me.perception1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'strength2
        '
        Me.strength2.BackColor = System.Drawing.Color.Black
        Me.strength2.Cursor = System.Windows.Forms.Cursors.Default
        Me.strength2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strength2.ForeColor = System.Drawing.Color.White
        Me.strength2.Location = New System.Drawing.Point(472, 203)
        Me.strength2.Name = "strength2"
        Me.strength2.ReadOnly = True
        Me.strength2.Size = New System.Drawing.Size(138, 20)
        Me.strength2.TabIndex = 46
        Me.strength2.Text = "NO DATA"
        Me.strength2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'intelligence2
        '
        Me.intelligence2.BackColor = System.Drawing.Color.Black
        Me.intelligence2.Cursor = System.Windows.Forms.Cursors.Default
        Me.intelligence2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intelligence2.ForeColor = System.Drawing.Color.White
        Me.intelligence2.Location = New System.Drawing.Point(472, 229)
        Me.intelligence2.Name = "intelligence2"
        Me.intelligence2.ReadOnly = True
        Me.intelligence2.Size = New System.Drawing.Size(138, 20)
        Me.intelligence2.TabIndex = 47
        Me.intelligence2.Text = "NO DATA"
        Me.intelligence2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'agility2
        '
        Me.agility2.BackColor = System.Drawing.Color.Black
        Me.agility2.Cursor = System.Windows.Forms.Cursors.Default
        Me.agility2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agility2.ForeColor = System.Drawing.Color.White
        Me.agility2.Location = New System.Drawing.Point(472, 255)
        Me.agility2.Name = "agility2"
        Me.agility2.ReadOnly = True
        Me.agility2.Size = New System.Drawing.Size(138, 20)
        Me.agility2.TabIndex = 48
        Me.agility2.Text = "NO DATA"
        Me.agility2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mental2
        '
        Me.mental2.BackColor = System.Drawing.Color.Black
        Me.mental2.Cursor = System.Windows.Forms.Cursors.Default
        Me.mental2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mental2.ForeColor = System.Drawing.Color.White
        Me.mental2.Location = New System.Drawing.Point(472, 281)
        Me.mental2.Name = "mental2"
        Me.mental2.ReadOnly = True
        Me.mental2.Size = New System.Drawing.Size(138, 20)
        Me.mental2.TabIndex = 49
        Me.mental2.Text = "NO DATA"
        Me.mental2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'perception2
        '
        Me.perception2.BackColor = System.Drawing.Color.Black
        Me.perception2.Cursor = System.Windows.Forms.Cursors.Default
        Me.perception2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perception2.ForeColor = System.Drawing.Color.White
        Me.perception2.Location = New System.Drawing.Point(472, 307)
        Me.perception2.Name = "perception2"
        Me.perception2.ReadOnly = True
        Me.perception2.Size = New System.Drawing.Size(138, 20)
        Me.perception2.TabIndex = 50
        Me.perception2.Text = "NO DATA"
        Me.perception2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainDataSet1
        '
        Me.MainDataSet1.DataSetName = "mainDataSet1"
        Me.MainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CharacterBindingSource
        '
        Me.CharacterBindingSource.DataMember = "Character"
        Me.CharacterBindingSource.DataSource = Me.MainDataSet1
        '
        'CharacterTableAdapter
        '
        Me.CharacterTableAdapter.ClearBeforeFill = True
        '
        'TaskBindingSource
        '
        Me.TaskBindingSource.DataMember = "Task"
        Me.TaskBindingSource.DataSource = Me.MainDataSet
        '
        'MainDataSet
        '
        Me.MainDataSet.DataSetName = "mainDataSet"
        Me.MainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaskTableAdapter
        '
        Me.TaskTableAdapter.ClearBeforeFill = True
        '
        'task0
        '
        Me.task0.BackColor = System.Drawing.Color.Black
        Me.task0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task0.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task0.ForeColor = System.Drawing.Color.White
        Me.task0.FormattingEnabled = True
        Me.task0.Location = New System.Drawing.Point(158, 353)
        Me.task0.Name = "task0"
        Me.task0.Size = New System.Drawing.Size(138, 27)
        Me.task0.TabIndex = 54
        '
        'task1
        '
        Me.task1.BackColor = System.Drawing.Color.Black
        Me.task1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task1.ForeColor = System.Drawing.Color.White
        Me.task1.FormattingEnabled = True
        Me.task1.Location = New System.Drawing.Point(314, 352)
        Me.task1.Name = "task1"
        Me.task1.Size = New System.Drawing.Size(138, 27)
        Me.task1.TabIndex = 55
        '
        'task2
        '
        Me.task2.BackColor = System.Drawing.Color.Black
        Me.task2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.task2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.task2.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.task2.ForeColor = System.Drawing.Color.White
        Me.task2.FormattingEnabled = True
        Me.task2.Location = New System.Drawing.Point(472, 352)
        Me.task2.Name = "task2"
        Me.task2.Size = New System.Drawing.Size(138, 27)
        Me.task2.TabIndex = 56
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(822, 450)
        Me.Controls.Add(Me.task2)
        Me.Controls.Add(Me.task1)
        Me.Controls.Add(Me.task0)
        Me.Controls.Add(Me.perception2)
        Me.Controls.Add(Me.mental2)
        Me.Controls.Add(Me.agility2)
        Me.Controls.Add(Me.intelligence2)
        Me.Controls.Add(Me.strength2)
        Me.Controls.Add(Me.perception1)
        Me.Controls.Add(Me.mental1)
        Me.Controls.Add(Me.agility1)
        Me.Controls.Add(Me.intelligence1)
        Me.Controls.Add(Me.strength1)
        Me.Controls.Add(Me.taskTitle)
        Me.Controls.Add(Me.perception0)
        Me.Controls.Add(Me.mental0)
        Me.Controls.Add(Me.perceptionTitle)
        Me.Controls.Add(Me.mentalTitle)
        Me.Controls.Add(Me.healthBar0)
        Me.Controls.Add(Me.hungerBar0)
        Me.Controls.Add(Me.healthBar2)
        Me.Controls.Add(Me.hungerBar2)
        Me.Controls.Add(Me.healthBar1)
        Me.Controls.Add(Me.hungerBar1)
        Me.Controls.Add(Me.agility0)
        Me.Controls.Add(Me.intelligence0)
        Me.Controls.Add(Me.strength0)
        Me.Controls.Add(Me.agilityTitle)
        Me.Controls.Add(Me.hungerTitle)
        Me.Controls.Add(Me.healthTitle)
        Me.Controls.Add(Me.intelligenceTitle)
        Me.Controls.Add(Me.GO)
        Me.Controls.Add(Me.foodCounter)
        Me.Controls.Add(Me.dayCounter)
        Me.Controls.Add(Me.strengthTitle)
        Me.Controls.Add(Me.name2)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.name0)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "main"
        Me.Text = "Form1"
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaskBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name0 As TextBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents name2 As TextBox
    Friend WithEvents strengthTitle As TextBox
    Friend WithEvents dayCounter As TextBox
    Friend WithEvents foodCounter As TextBox
    Friend WithEvents GO As Button
    Friend WithEvents intelligenceTitle As TextBox
    Friend WithEvents healthTitle As TextBox
    Friend WithEvents hungerTitle As TextBox
    Friend WithEvents agilityTitle As TextBox
    Friend WithEvents strength0 As TextBox
    Friend WithEvents intelligence0 As TextBox
    Friend WithEvents agility0 As TextBox
    Friend WithEvents hungerBar1 As TextBox
    Friend WithEvents healthBar1 As TextBox
    Friend WithEvents hungerBar2 As TextBox
    Friend WithEvents healthBar2 As TextBox
    Friend WithEvents hungerBar0 As TextBox
    Friend WithEvents healthBar0 As TextBox
    Friend WithEvents mentalTitle As TextBox
    Friend WithEvents perceptionTitle As TextBox
    Friend WithEvents mental0 As TextBox
    Friend WithEvents perception0 As TextBox
    Friend WithEvents taskTitle As TextBox
    Friend WithEvents strength1 As TextBox
    Friend WithEvents intelligence1 As TextBox
    Friend WithEvents agility1 As TextBox
    Friend WithEvents mental1 As TextBox
    Friend WithEvents perception1 As TextBox
    Friend WithEvents strength2 As TextBox
    Friend WithEvents intelligence2 As TextBox
    Friend WithEvents agility2 As TextBox
    Friend WithEvents mental2 As TextBox
    Friend WithEvents perception2 As TextBox
    Friend WithEvents MainDataSet1 As mainDataSet1
    Friend WithEvents CharacterBindingSource As BindingSource
    Friend WithEvents CharacterTableAdapter As mainDataSet1TableAdapters.CharacterTableAdapter
    Friend WithEvents MainDataSet As mainDataSet
    Friend WithEvents TaskBindingSource As BindingSource
    Friend WithEvents TaskTableAdapter As mainDataSetTableAdapters.TaskTableAdapter
    Friend WithEvents task0 As ComboBox
    Friend WithEvents task1 As ComboBox
    Friend WithEvents task2 As ComboBox
End Class
