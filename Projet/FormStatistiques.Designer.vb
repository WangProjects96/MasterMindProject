<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStatistiques
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxNoms = New System.Windows.Forms.ListBox()
        Me.ListBoxScores = New System.Windows.Forms.ListBox()
        Me.ListBoxNbPartiesCreer = New System.Windows.Forms.ListBox()
        Me.ListBoxNbPartiesChercher = New System.Windows.Forms.ListBox()
        Me.ListBoxTemps = New System.Windows.Forms.ListBox()
        Me.ButtonTriAlphabetique = New System.Windows.Forms.Button()
        Me.ButtonTriParScore = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.PanelListBox = New System.Windows.Forms.Panel()
        Me.PanelListBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Noms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de parties (créer combi)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(536, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre de parties (trouver combi)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(713, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Temps total (en seconde)"
        '
        'ListBoxNoms
        '
        Me.ListBoxNoms.FormattingEnabled = True
        Me.ListBoxNoms.Location = New System.Drawing.Point(10, 0)
        Me.ListBoxNoms.Name = "ListBoxNoms"
        Me.ListBoxNoms.Size = New System.Drawing.Size(128, 355)
        Me.ListBoxNoms.TabIndex = 5
        '
        'ListBoxScores
        '
        Me.ListBoxScores.FormattingEnabled = True
        Me.ListBoxScores.Location = New System.Drawing.Point(173, 0)
        Me.ListBoxScores.Name = "ListBoxScores"
        Me.ListBoxScores.Size = New System.Drawing.Size(128, 355)
        Me.ListBoxScores.TabIndex = 6
        '
        'ListBoxNbPartiesCreer
        '
        Me.ListBoxNbPartiesCreer.FormattingEnabled = True
        Me.ListBoxNbPartiesCreer.Location = New System.Drawing.Point(339, 0)
        Me.ListBoxNbPartiesCreer.Name = "ListBoxNbPartiesCreer"
        Me.ListBoxNbPartiesCreer.Size = New System.Drawing.Size(128, 355)
        Me.ListBoxNbPartiesCreer.TabIndex = 7
        '
        'ListBoxNbPartiesChercher
        '
        Me.ListBoxNbPartiesChercher.FormattingEnabled = True
        Me.ListBoxNbPartiesChercher.Location = New System.Drawing.Point(527, 0)
        Me.ListBoxNbPartiesChercher.Name = "ListBoxNbPartiesChercher"
        Me.ListBoxNbPartiesChercher.Size = New System.Drawing.Size(128, 355)
        Me.ListBoxNbPartiesChercher.TabIndex = 8
        '
        'ListBoxTemps
        '
        Me.ListBoxTemps.FormattingEnabled = True
        Me.ListBoxTemps.Location = New System.Drawing.Point(704, 0)
        Me.ListBoxTemps.Name = "ListBoxTemps"
        Me.ListBoxTemps.Size = New System.Drawing.Size(128, 355)
        Me.ListBoxTemps.TabIndex = 9
        '
        'ButtonTriAlphabetique
        '
        Me.ButtonTriAlphabetique.Location = New System.Drawing.Point(57, 434)
        Me.ButtonTriAlphabetique.Name = "ButtonTriAlphabetique"
        Me.ButtonTriAlphabetique.Size = New System.Drawing.Size(123, 23)
        Me.ButtonTriAlphabetique.TabIndex = 10
        Me.ButtonTriAlphabetique.Text = "Par ordre alphabétique"
        Me.ButtonTriAlphabetique.UseVisualStyleBackColor = True
        '
        'ButtonTriParScore
        '
        Me.ButtonTriParScore.Location = New System.Drawing.Point(266, 433)
        Me.ButtonTriParScore.Name = "ButtonTriParScore"
        Me.ButtonTriParScore.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTriParScore.TabIndex = 11
        Me.ButtonTriParScore.Text = "Par score"
        Me.ButtonTriParScore.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Location = New System.Drawing.Point(455, 420)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(101, 51)
        Me.ButtonRetour.TabIndex = 12
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'PanelListBox
        '
        Me.PanelListBox.Controls.Add(Me.ListBoxNbPartiesChercher)
        Me.PanelListBox.Controls.Add(Me.ListBoxNoms)
        Me.PanelListBox.Controls.Add(Me.ListBoxScores)
        Me.PanelListBox.Controls.Add(Me.ListBoxNbPartiesCreer)
        Me.PanelListBox.Controls.Add(Me.ListBoxTemps)
        Me.PanelListBox.Location = New System.Drawing.Point(3, 50)
        Me.PanelListBox.Name = "PanelListBox"
        Me.PanelListBox.Size = New System.Drawing.Size(842, 364)
        Me.PanelListBox.TabIndex = 13
        '
        'FormStatistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 486)
        Me.Controls.Add(Me.PanelListBox)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonTriParScore)
        Me.Controls.Add(Me.ButtonTriAlphabetique)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormStatistiques"
        Me.Text = "FormStatistiques"
        Me.PanelListBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxNoms As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxScores As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNbPartiesCreer As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxNbPartiesChercher As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxTemps As System.Windows.Forms.ListBox
    Friend WithEvents ButtonTriAlphabetique As System.Windows.Forms.Button
    Friend WithEvents ButtonTriParScore As System.Windows.Forms.Button
    Friend WithEvents ButtonRetour As System.Windows.Forms.Button
    Friend WithEvents PanelListBox As System.Windows.Forms.Panel
End Class
