Public Class FormStatistiques


    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        FormAccueil.Show()
        Me.Hide()
    End Sub


    Private Sub ListBoxNbPartiesCreer_TabIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNbPartiesCreer.SelectedIndexChanged, ListBoxNbPartiesChercher.SelectedIndexChanged, ListBoxNoms.SelectedIndexChanged, ListBoxScores.SelectedIndexChanged, ListBoxTemps.SelectedIndexChanged
        Dim tmp As Integer = sender.SelectedIndex

        ListBoxNbPartiesCreer.SelectedIndex = tmp
        ListBoxNbPartiesChercher.SelectedIndex = tmp
        ListBoxNoms.SelectedIndex = tmp
        ListBoxScores.SelectedIndex = tmp
        ListBoxTemps.SelectedIndex = tmp


    End Sub




    Private Sub ButtonTriParScore_Click(sender As Object, e As EventArgs) Handles ButtonTriParScore.Click
        Dim a As String
        For i As Integer = 0 To ListBoxScores.Items.Count - 2 Step 1
            For j As Integer = i + 1 To ListBoxScores.Items.Count - 1 Step 1
                If ListBoxScores.Items(i) < ListBoxScores.Items(j) Then
                    For Each c As ListBox In PanelListBox.Controls
                        a = c.Items(i)
                        c.Items(i) = c.Items(j)
                        c.Items(j) = a
                    Next
                End If
            Next
        Next
    End Sub

    Private Sub ButtonTriAlphabetique_Click(sender As Object, e As EventArgs) Handles ButtonTriAlphabetique.Click
        ListBoxNoms.Items.Clear()
        ListBoxNbPartiesChercher.Items.Clear()
        ListBoxScores.Items.Clear()
        ListBoxNbPartiesCreer.Items.Clear()
        ListBoxScores.Items.Clear()

        Joueurs.trierParAlphabetique()
        FormAccueil.statsjoueurs()
        Me.Refresh()

    End Sub





    Private Sub ListBoxNbPartiesChercher_TabIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNbPartiesChercher.TabIndexChanged, ListBoxNbPartiesCreer.TabIndexChanged, ListBoxNoms.TabIndexChanged, ListBoxScores.TabIndexChanged, ListBoxTemps.TabIndexChanged
        Dim tmp As Integer = sender.Tabindex
        ListBoxNbPartiesCreer.TabIndex = tmp
        ListBoxNbPartiesChercher.TabIndex = tmp
        ListBoxNoms.TabIndex = tmp
        ListBoxScores.TabIndex = tmp
        ListBoxTemps.TabIndex = tmp

    End Sub


    Private Sub FormStatistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class