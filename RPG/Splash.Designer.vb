<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.Manual = New System.Windows.Forms.TabPage()
        Me.SelectGame = New System.Windows.Forms.TabPage()
        Me.loadGame = New System.Windows.Forms.Button()
        Me.newGame = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Difficulty = New System.Windows.Forms.ComboBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.SelectGame.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Manual
        '
        Me.Manual.Location = New System.Drawing.Point(4, 22)
        Me.Manual.Name = "Manual"
        Me.Manual.Size = New System.Drawing.Size(779, 400)
        Me.Manual.TabIndex = 2
        Me.Manual.Text = "Anleitung"
        Me.Manual.UseVisualStyleBackColor = True
        '
        'SelectGame
        '
        Me.SelectGame.Controls.Add(Me.Back)
        Me.SelectGame.Controls.Add(Me.Start)
        Me.SelectGame.Controls.Add(Me.Difficulty)
        Me.SelectGame.Controls.Add(Me.newGame)
        Me.SelectGame.Controls.Add(Me.loadGame)
        Me.SelectGame.Location = New System.Drawing.Point(4, 22)
        Me.SelectGame.Name = "SelectGame"
        Me.SelectGame.Padding = New System.Windows.Forms.Padding(3)
        Me.SelectGame.Size = New System.Drawing.Size(779, 400)
        Me.SelectGame.TabIndex = 0
        Me.SelectGame.Text = "Start"
        Me.SelectGame.UseVisualStyleBackColor = True
        '
        'loadGame
        '
        Me.loadGame.Location = New System.Drawing.Point(447, 152)
        Me.loadGame.Name = "loadGame"
        Me.loadGame.Size = New System.Drawing.Size(297, 86)
        Me.loadGame.TabIndex = 0
        Me.loadGame.Text = "Spiel laden"
        Me.loadGame.UseVisualStyleBackColor = True
        '
        'newGame
        '
        Me.newGame.Location = New System.Drawing.Point(34, 152)
        Me.newGame.Name = "newGame"
        Me.newGame.Size = New System.Drawing.Size(297, 86)
        Me.newGame.TabIndex = 1
        Me.newGame.Text = "Neues Spiel"
        Me.newGame.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SelectGame)
        Me.TabControl1.Controls.Add(Me.Manual)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 426)
        Me.TabControl1.TabIndex = 2
        '
        'Difficulty
        '
        Me.Difficulty.FormattingEnabled = True
        Me.Difficulty.Items.AddRange(New Object() {"Leicht (Ø Skill =15)", "Mittel (Ø Skill =10)", "Schwer (Ø Skill = 5)", "Unmöglich (Alle Skills = 0)"})
        Me.Difficulty.Location = New System.Drawing.Point(447, 70)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(297, 21)
        Me.Difficulty.TabIndex = 2
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(447, 244)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(297, 86)
        Me.Start.TabIndex = 3
        Me.Start.Text = "Spiel starten"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(34, 244)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(297, 86)
        Me.Back.TabIndex = 4
        Me.Back.Text = "Zurück"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Splash"
        Me.Text = "Splash"
        Me.SelectGame.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Manual As TabPage
    Friend WithEvents SelectGame As TabPage
    Friend WithEvents newGame As Button
    Friend WithEvents loadGame As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Back As Button
    Friend WithEvents Start As Button
    Friend WithEvents Difficulty As ComboBox
End Class
