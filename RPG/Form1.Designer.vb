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
        Me.components = New System.ComponentModel.Container()
        Me.name0 = New System.Windows.Forms.TextBox()
        Me.name1 = New System.Windows.Forms.TextBox()
        Me.name2 = New System.Windows.Forms.TextBox()
        Me.skillTitle0 = New System.Windows.Forms.TextBox()
        Me.dayCounter = New System.Windows.Forms.TextBox()
        Me.foodCounter = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.skillTitle1 = New System.Windows.Forms.TextBox()
        Me.healthTitle = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.skillTitle2 = New System.Windows.Forms.TextBox()
        Me.strength0 = New System.Windows.Forms.TextBox()
        Me.intelligence0 = New System.Windows.Forms.TextBox()
        Me.agility0 = New System.Windows.Forms.TextBox()
        Me.hungerBar1 = New System.Windows.Forms.TextBox()
        Me.healthBar1 = New System.Windows.Forms.TextBox()
        Me.hungerBar2 = New System.Windows.Forms.TextBox()
        Me.healthBar2 = New System.Windows.Forms.TextBox()
        Me.hungerBar0 = New System.Windows.Forms.TextBox()
        Me.healthBar0 = New System.Windows.Forms.TextBox()
        Me.skillTitle3 = New System.Windows.Forms.TextBox()
        Me.skillTitle4 = New System.Windows.Forms.TextBox()
        Me.social0 = New System.Windows.Forms.TextBox()
        Me.perception0 = New System.Windows.Forms.TextBox()
        Me.taskTitle = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.strength1 = New System.Windows.Forms.TextBox()
        Me.intelligence1 = New System.Windows.Forms.TextBox()
        Me.agility1 = New System.Windows.Forms.TextBox()
        Me.social1 = New System.Windows.Forms.TextBox()
        Me.perception1 = New System.Windows.Forms.TextBox()
        Me.strength2 = New System.Windows.Forms.TextBox()
        Me.intelligence2 = New System.Windows.Forms.TextBox()
        Me.agility2 = New System.Windows.Forms.TextBox()
        Me.social2 = New System.Windows.Forms.TextBox()
        Me.perception2 = New System.Windows.Forms.TextBox()
        Me.MainDataSet1 = New RPG.mainDataSet1()
        Me.CharacterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CharacterTableAdapter = New RPG.mainDataSet1TableAdapters.CharacterTableAdapter()
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'skillTitle0
        '
        Me.skillTitle0.BackColor = System.Drawing.Color.Black
        Me.skillTitle0.Cursor = System.Windows.Forms.Cursors.Default
        Me.skillTitle0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skillTitle0.ForeColor = System.Drawing.Color.White
        Me.skillTitle0.Location = New System.Drawing.Point(12, 203)
        Me.skillTitle0.Name = "skillTitle0"
        Me.skillTitle0.ReadOnly = True
        Me.skillTitle0.Size = New System.Drawing.Size(125, 20)
        Me.skillTitle0.TabIndex = 4
        Me.skillTitle0.Text = "Strength"
        '
        'dayCounter
        '
        Me.dayCounter.BackColor = System.Drawing.Color.Black
        Me.dayCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.dayCounter.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dayCounter.ForeColor = System.Drawing.Color.White
        Me.dayCounter.Location = New System.Drawing.Point(12, 12)
        Me.dayCounter.Name = "dayCounter"
        Me.dayCounter.ReadOnly = True
        Me.dayCounter.Size = New System.Drawing.Size(138, 36)
        Me.dayCounter.TabIndex = 6
        Me.dayCounter.Text = "DAY 3"
        Me.dayCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'foodCounter
        '
        Me.foodCounter.BackColor = System.Drawing.Color.Black
        Me.foodCounter.Cursor = System.Windows.Forms.Cursors.Default
        Me.foodCounter.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodCounter.ForeColor = System.Drawing.Color.White
        Me.foodCounter.Location = New System.Drawing.Point(579, 12)
        Me.foodCounter.Name = "foodCounter"
        Me.foodCounter.ReadOnly = True
        Me.foodCounter.Size = New System.Drawing.Size(209, 36)
        Me.foodCounter.TabIndex = 7
        Me.foodCounter.Text = "Rations: 2 (-1)"
        Me.foodCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'skillTitle1
        '
        Me.skillTitle1.BackColor = System.Drawing.Color.Black
        Me.skillTitle1.Cursor = System.Windows.Forms.Cursors.Default
        Me.skillTitle1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skillTitle1.ForeColor = System.Drawing.Color.White
        Me.skillTitle1.Location = New System.Drawing.Point(12, 229)
        Me.skillTitle1.Name = "skillTitle1"
        Me.skillTitle1.ReadOnly = True
        Me.skillTitle1.Size = New System.Drawing.Size(125, 20)
        Me.skillTitle1.TabIndex = 9
        Me.skillTitle1.Text = "Intelligence"
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
        Me.healthTitle.Text = "Health"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Black
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(12, 162)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(125, 26)
        Me.TextBox4.TabIndex = 12
        Me.TextBox4.Text = "Hunger"
        '
        'skillTitle2
        '
        Me.skillTitle2.BackColor = System.Drawing.Color.Black
        Me.skillTitle2.Cursor = System.Windows.Forms.Cursors.Default
        Me.skillTitle2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skillTitle2.ForeColor = System.Drawing.Color.White
        Me.skillTitle2.Location = New System.Drawing.Point(12, 255)
        Me.skillTitle2.Name = "skillTitle2"
        Me.skillTitle2.ReadOnly = True
        Me.skillTitle2.Size = New System.Drawing.Size(125, 20)
        Me.skillTitle2.TabIndex = 18
        Me.skillTitle2.Text = "Agility"
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
        Me.healthBar1.ForeColor = System.Drawing.Color.White
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
        Me.healthBar2.ForeColor = System.Drawing.Color.White
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
        Me.healthBar0.ForeColor = System.Drawing.Color.White
        Me.healthBar0.Location = New System.Drawing.Point(158, 130)
        Me.healthBar0.Name = "healthBar0"
        Me.healthBar0.ReadOnly = True
        Me.healthBar0.Size = New System.Drawing.Size(138, 26)
        Me.healthBar0.TabIndex = 32
        Me.healthBar0.Text = "NO DATA"
        '
        'skillTitle3
        '
        Me.skillTitle3.BackColor = System.Drawing.Color.Black
        Me.skillTitle3.Cursor = System.Windows.Forms.Cursors.Default
        Me.skillTitle3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skillTitle3.ForeColor = System.Drawing.Color.White
        Me.skillTitle3.Location = New System.Drawing.Point(12, 281)
        Me.skillTitle3.Name = "skillTitle3"
        Me.skillTitle3.ReadOnly = True
        Me.skillTitle3.Size = New System.Drawing.Size(125, 20)
        Me.skillTitle3.TabIndex = 33
        Me.skillTitle3.Text = "Social"
        '
        'skillTitle4
        '
        Me.skillTitle4.BackColor = System.Drawing.Color.Black
        Me.skillTitle4.Cursor = System.Windows.Forms.Cursors.Default
        Me.skillTitle4.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.skillTitle4.ForeColor = System.Drawing.Color.White
        Me.skillTitle4.Location = New System.Drawing.Point(12, 307)
        Me.skillTitle4.Name = "skillTitle4"
        Me.skillTitle4.ReadOnly = True
        Me.skillTitle4.Size = New System.Drawing.Size(125, 20)
        Me.skillTitle4.TabIndex = 34
        Me.skillTitle4.Text = "Perception"
        '
        'social0
        '
        Me.social0.BackColor = System.Drawing.Color.Black
        Me.social0.Cursor = System.Windows.Forms.Cursors.Default
        Me.social0.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.social0.ForeColor = System.Drawing.Color.White
        Me.social0.Location = New System.Drawing.Point(158, 281)
        Me.social0.Name = "social0"
        Me.social0.ReadOnly = True
        Me.social0.Size = New System.Drawing.Size(138, 20)
        Me.social0.TabIndex = 35
        Me.social0.Text = "NO DATA"
        Me.social0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.taskTitle.Text = "Task"
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
        'social1
        '
        Me.social1.BackColor = System.Drawing.Color.Black
        Me.social1.Cursor = System.Windows.Forms.Cursors.Default
        Me.social1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.social1.ForeColor = System.Drawing.Color.White
        Me.social1.Location = New System.Drawing.Point(314, 281)
        Me.social1.Name = "social1"
        Me.social1.ReadOnly = True
        Me.social1.Size = New System.Drawing.Size(138, 20)
        Me.social1.TabIndex = 44
        Me.social1.Text = "NO DATA"
        Me.social1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'social2
        '
        Me.social2.BackColor = System.Drawing.Color.Black
        Me.social2.Cursor = System.Windows.Forms.Cursors.Default
        Me.social2.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.social2.ForeColor = System.Drawing.Color.White
        Me.social2.Location = New System.Drawing.Point(472, 281)
        Me.social2.Name = "social2"
        Me.social2.ReadOnly = True
        Me.social2.Size = New System.Drawing.Size(138, 20)
        Me.social2.TabIndex = 49
        Me.social2.Text = "NO DATA"
        Me.social2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.perception2)
        Me.Controls.Add(Me.social2)
        Me.Controls.Add(Me.agility2)
        Me.Controls.Add(Me.intelligence2)
        Me.Controls.Add(Me.strength2)
        Me.Controls.Add(Me.perception1)
        Me.Controls.Add(Me.social1)
        Me.Controls.Add(Me.agility1)
        Me.Controls.Add(Me.intelligence1)
        Me.Controls.Add(Me.strength1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.taskTitle)
        Me.Controls.Add(Me.perception0)
        Me.Controls.Add(Me.social0)
        Me.Controls.Add(Me.skillTitle4)
        Me.Controls.Add(Me.skillTitle3)
        Me.Controls.Add(Me.healthBar0)
        Me.Controls.Add(Me.hungerBar0)
        Me.Controls.Add(Me.healthBar2)
        Me.Controls.Add(Me.hungerBar2)
        Me.Controls.Add(Me.healthBar1)
        Me.Controls.Add(Me.hungerBar1)
        Me.Controls.Add(Me.agility0)
        Me.Controls.Add(Me.intelligence0)
        Me.Controls.Add(Me.strength0)
        Me.Controls.Add(Me.skillTitle2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.healthTitle)
        Me.Controls.Add(Me.skillTitle1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.foodCounter)
        Me.Controls.Add(Me.dayCounter)
        Me.Controls.Add(Me.skillTitle0)
        Me.Controls.Add(Me.name2)
        Me.Controls.Add(Me.name1)
        Me.Controls.Add(Me.name0)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.MainDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CharacterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name0 As TextBox
    Friend WithEvents name1 As TextBox
    Friend WithEvents name2 As TextBox
    Friend WithEvents skillTitle0 As TextBox
    Friend WithEvents dayCounter As TextBox
    Friend WithEvents foodCounter As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents skillTitle1 As TextBox
    Friend WithEvents healthTitle As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents skillTitle2 As TextBox
    Friend WithEvents strength0 As TextBox
    Friend WithEvents intelligence0 As TextBox
    Friend WithEvents agility0 As TextBox
    Friend WithEvents hungerBar1 As TextBox
    Friend WithEvents healthBar1 As TextBox
    Friend WithEvents hungerBar2 As TextBox
    Friend WithEvents healthBar2 As TextBox
    Friend WithEvents hungerBar0 As TextBox
    Friend WithEvents healthBar0 As TextBox
    Friend WithEvents skillTitle3 As TextBox
    Friend WithEvents skillTitle4 As TextBox
    Friend WithEvents social0 As TextBox
    Friend WithEvents perception0 As TextBox
    Friend WithEvents taskTitle As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents strength1 As TextBox
    Friend WithEvents intelligence1 As TextBox
    Friend WithEvents agility1 As TextBox
    Friend WithEvents social1 As TextBox
    Friend WithEvents perception1 As TextBox
    Friend WithEvents strength2 As TextBox
    Friend WithEvents intelligence2 As TextBox
    Friend WithEvents agility2 As TextBox
    Friend WithEvents social2 As TextBox
    Friend WithEvents perception2 As TextBox
    Friend WithEvents MainDataSet1 As mainDataSet1
    Friend WithEvents CharacterBindingSource As BindingSource
    Friend WithEvents CharacterTableAdapter As mainDataSet1TableAdapters.CharacterTableAdapter
End Class
