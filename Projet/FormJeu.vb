Public Class FormJeu
    Dim CoupsRestants As Integer = 15
    Dim Combinaison(4) As String
    Dim Resultats(4, 14) As Label
    Dim compt As Integer = 0
    Dim CombinaisonGagnante(4) As String
    Dim time As Integer = 0
    Dim indice As Integer = 4


    Private Sub FormJeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Il vous reste " + CoupsRestants.ToString + " coups restants" + " 00:00:00"

        LabelCaractère.Text = FormPattern.LabelCaractère.Text
        CombinaisonGagnante(0) = FormPattern.TextBox1.Text
        CombinaisonGagnante(1) = FormPattern.TextBox2.Text
        CombinaisonGagnante(2) = FormPattern.TextBox3.Text
        CombinaisonGagnante(3) = FormPattern.TextBox4.Text
        CombinaisonGagnante(4) = FormPattern.TextBox5.Text


        Resultats(0, 0) = Me.Label8
        Resultats(1, 0) = Me.Label9
        Resultats(2, 0) = Me.Label10
        Resultats(3, 0) = Me.Label11
        Resultats(4, 0) = Me.Label12

        Resultats(0, 1) = Me.Label13
        Resultats(1, 1) = Me.Label14
        Resultats(2, 1) = Me.Label15
        Resultats(3, 1) = Me.Label16
        Resultats(4, 1) = Me.Label17

        Resultats(0, 2) = Me.Label18
        Resultats(1, 2) = Me.Label19
        Resultats(2, 2) = Me.Label20
        Resultats(3, 2) = Me.Label21
        Resultats(4, 2) = Me.Label22

        Resultats(0, 3) = Me.Label23
        Resultats(1, 3) = Me.Label24
        Resultats(2, 3) = Me.Label25
        Resultats(3, 3) = Me.Label26
        Resultats(4, 3) = Me.Label27

        Resultats(0, 4) = Me.Label28
        Resultats(1, 4) = Me.Label29
        Resultats(2, 4) = Me.Label30
        Resultats(3, 4) = Me.Label31
        Resultats(4, 4) = Me.Label32

        Resultats(0, 5) = Me.Label33
        Resultats(1, 5) = Me.Label34
        Resultats(2, 5) = Me.Label35
        Resultats(3, 5) = Me.Label36
        Resultats(4, 5) = Me.Label37

        Resultats(0, 6) = Me.Label38
        Resultats(1, 6) = Me.Label39
        Resultats(2, 6) = Me.Label40
        Resultats(3, 6) = Me.Label41
        Resultats(4, 6) = Me.Label42

        Resultats(0, 7) = Me.Label43
        Resultats(1, 7) = Me.Label44
        Resultats(2, 7) = Me.Label45
        Resultats(3, 7) = Me.Label46
        Resultats(4, 7) = Me.Label47

        Resultats(0, 8) = Me.Label48
        Resultats(1, 8) = Me.Label49
        Resultats(2, 8) = Me.Label50
        Resultats(3, 8) = Me.Label51
        Resultats(4, 8) = Me.Label52

        Resultats(0, 9) = Me.Label53
        Resultats(1, 9) = Me.Label54
        Resultats(2, 9) = Me.Label55
        Resultats(3, 9) = Me.Label56
        Resultats(4, 9) = Me.Label57

        Resultats(0, 10) = Me.Label58
        Resultats(1, 10) = Me.Label59
        Resultats(2, 10) = Me.Label60
        Resultats(3, 10) = Me.Label61
        Resultats(4, 10) = Me.Label62

        Resultats(0, 11) = Me.Label63
        Resultats(1, 11) = Me.Label64
        Resultats(2, 11) = Me.Label65
        Resultats(3, 11) = Me.Label66
        Resultats(4, 11) = Me.Label67

        Resultats(0, 12) = Me.Label68
        Resultats(1, 12) = Me.Label69
        Resultats(2, 12) = Me.Label70
        Resultats(3, 12) = Me.Label71
        Resultats(4, 12) = Me.Label72

        Resultats(0, 13) = Me.Label73
        Resultats(1, 13) = Me.Label74
        Resultats(2, 13) = Me.Label75
        Resultats(3, 13) = Me.Label76
        Resultats(4, 13) = Me.Label77

        Resultats(0, 14) = Me.Label78
        Resultats(1, 14) = Me.Label79
        Resultats(2, 14) = Me.Label80
        Resultats(3, 14) = Me.Label81
        Resultats(4, 14) = Me.Label82


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGuess.Click
        Dim test As Boolean = True
        Dim bon As Integer = 0
        For Each txbx As TextBox In PanelGuess.Controls
            If txbx.Text = "" Or CoupsRestants <= 0 Then
                test = False
                LabelError.Visible = True
                Exit For
            End If
        Next

        If test = True Then


            Combinaison(0) = TextBox1.Text
            Combinaison(1) = TextBox2.Text
            Combinaison(2) = TextBox3.Text
            Combinaison(3) = TextBox4.Text
            Combinaison(4) = TextBox5.Text

            bon = 0
            For Each txbx As TextBox In PanelGuess.Controls
                Resultats(indice, compt).Text = txbx.Text

                If (txbx.Text = CombinaisonGagnante(indice)) Then
                    txbx.BackColor = Color.Green
                    Resultats(indice, compt).ForeColor = Color.Green
                    bon = bon + 1


                ElseIf CombinaisonGagnante.Contains(txbx.Text) Then
                    txbx.BackColor = Color.Blue
                    Resultats(indice, compt).ForeColor = Color.Blue

                Else
                    txbx.BackColor = Color.White
                    Resultats(indice, compt).ForeColor = Color.Black


                End If
                Resultats(indice, compt).Visible = True
                indice = indice - 1

            Next
            indice = 4
            If bon = 5 Then
                Timer1.Stop()
                LabelVictoite.Visible = True
                ButtonGuess.Enabled = False


                créerJoueur(FormAccueil.ComboBox1.Text, 0, 1, 0, 0)
                créerJoueur(FormAccueil.ComboBox2.Text, 1, 0, 1, time)




                Exit Sub
            End If



            compt = compt + 1
            CoupsRestants = CoupsRestants - 1
            Me.Text = "Il vous reste " & CoupsRestants & " coups restants " & (time \ 3600).ToString("00") & ":" & ((time Mod 3600) \ 60).ToString("00") & ":" & ((time Mod 3600) Mod 60).ToString("00")
            If CoupsRestants <= 0 Then
                créerJoueur(FormAccueil.ComboBox1.Text, 1, 1, 0, 0)
                créerJoueur(FormAccueil.ComboBox2.Text, 0, 0, 1, time)
                LabelDéfaite.Visible = True
                ButtonGuess.Enabled = False
                Exit Sub
            End If
        End If



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged
        If LabelCaractère.Text.Contains(sender.text) Then
            LabelError.Visible = False
            Exit Sub
        Else
            sender.text = ""
            LabelError.Visible = False
        End If

    End Sub


    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim choix As Integer = MsgBox("Voulez vous vraiment quitter ?", MsgBoxStyle.YesNo, "Quitter")

        If choix = 6 Then
            Application.Exit()
            FormAccueil.Ecrire()

        End If

    End Sub

    Private Sub ButtonRejouer_Click(sender As Object, e As EventArgs) Handles ButtonRejouer.Click
        Erase Resultats
        FormAccueil.Show()
        Me.Close()

        time = 0
        LabelTemps.Text = "00:00:00"
        CoupsRestants = 15
        ButtonGuess.Enabled = True
        For Each txbx As TextBox In PanelGuess.Controls
            txbx.Text = ""
            txbx.BackColor = Color.White
        Next
        For Each lbl As Label In PanelReponse.Controls
            lbl.Text = ""
            lbl.ForeColor = Color.White
            lbl.Visible = False
        Next
        For Each txbx As TextBox In FormPattern.PanelCacher.Controls
            txbx.Text = ""
        Next
        LabelDéfaite.Visible = False
        LabelVictoite.Visible = False


        Dim tmp As String = FormAccueil.ComboBox1.Text
        FormAccueil.ComboBox1.Text = FormAccueil.ComboBox2.Text
        FormAccueil.ComboBox2.Text = tmp
        
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time + 1
        Dim h As Integer = time \ 3600
        Dim m As Integer = (time Mod 3600) \ 60
        Dim s As Integer = (time Mod 3600) Mod 60

        Me.Text = "Il vous reste " & CoupsRestants & " coups restants " & h.ToString("00") & ":" & m.ToString("00") & ":" & s.ToString("00")
        LabelTemps.Text = h.ToString("00") & ":" & m.ToString("00") & ":" & s.ToString("00")
    End Sub

    Private Sub Enregistrer_Score_Gagnantj2()
        If Not FormStatistiques.ListBoxNoms.Items.Contains(FormAccueil.ComboBox1.Text) Then
            FormStatistiques.ListBoxNoms.Items.Add(FormAccueil.ComboBox1.Text)
            FormStatistiques.ListBoxScores.Items.Add(0)
            FormStatistiques.ListBoxTemps.Items.Add(0)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Add(1)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Add(0)
        Else
            Dim i As Integer
            i = FormStatistiques.ListBoxNoms.Items.IndexOf(FormAccueil.ComboBox1.Text)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Item(i) = FormStatistiques.ListBoxNbPartiesCreer.Items(i) + 1

        End If



        If Not FormStatistiques.ListBoxNoms.Items.Contains(FormAccueil.ComboBox2.Text) Then
            FormStatistiques.ListBoxNoms.Items.Add(FormAccueil.ComboBox2.Text)
            FormStatistiques.ListBoxScores.Items.Add(1)
            FormStatistiques.ListBoxTemps.Items.Add(time)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Add(0)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Add(1)
        Else
            Dim i As Integer
            i = FormStatistiques.ListBoxNoms.Items.IndexOf(FormAccueil.ComboBox2.Text)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Item(i) = FormStatistiques.ListBoxNbPartiesChercher.Items(i) + 1
            FormStatistiques.ListBoxTemps.Items(i) = FormStatistiques.ListBoxTemps.Items(i) + time
            FormStatistiques.ListBoxScores.Items(i) = FormStatistiques.ListBoxScores.Items(i) + 1
        End If
    End Sub

    Private Sub Enregistrer_Score_Gagnantj1()
        If Not FormStatistiques.ListBoxNoms.Items.Contains(FormAccueil.ComboBox2.Text) Then
            FormStatistiques.ListBoxNoms.Items.Add(FormAccueil.ComboBox2.Text)
            FormStatistiques.ListBoxScores.Items.Add(0)
            FormStatistiques.ListBoxTemps.Items.Add(0)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Add(1)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Add(0)
        Else
            Dim i As Integer
            i = FormStatistiques.ListBoxNoms.Items.IndexOf(FormAccueil.ComboBox2.Text)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Item(i) = FormStatistiques.ListBoxNbPartiesChercher.Items(i) + 1

        End If



        If Not FormStatistiques.ListBoxNoms.Items.Contains(FormAccueil.ComboBox1.Text) Then
            FormStatistiques.ListBoxNoms.Items.Add(FormAccueil.ComboBox1.Text)
            FormStatistiques.ListBoxScores.Items.Add(1)
            FormStatistiques.ListBoxTemps.Items.Add(time)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Add(0)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Add(1)
        Else
            Dim i As Integer
            i = FormStatistiques.ListBoxNoms.Items.IndexOf(FormAccueil.ComboBox1.Text)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Item(i) = FormStatistiques.ListBoxNbPartiesCreer.Items(i) + 1
            FormStatistiques.ListBoxTemps.Items(i) = FormStatistiques.ListBoxTemps.Items(i) + time
            FormStatistiques.ListBoxScores.Items(i) = FormStatistiques.ListBoxScores.Items(i) + 1
        End If
    End Sub

    
End Class