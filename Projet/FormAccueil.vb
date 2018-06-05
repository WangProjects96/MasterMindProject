Imports System.IO
Public Class FormAccueil

    Dim nombrenoms As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As Boolean = False
        If ComboBox1.Text IsNot "" And ComboBox2.Text IsNot "" Then
            If ComboBox1.Text <> ComboBox2.Text Then
                test = True
            End If
        End If

        If test Then
            If ComboBox1.Items.Contains(ComboBox1.Text) = False And ComboBox1.Items.Contains(ComboBox2.Text) = False Then
                ComboBox1.Items.Add(ComboBox1.Text)
                ComboBox1.Items.Add(ComboBox2.Text)
                ComboBox2.Items.Add(ComboBox1.Text)
                ComboBox2.Items.Add(ComboBox2.Text)

            End If

            FormPattern.Show()
            Me.Hide()
        End If

        If test = False Then
            LabelError.Visible = True
        End If

    End Sub





    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged, ComboBox2.TextChanged
        LabelError.Visible = False
    End Sub


    Private Sub ButtonStatistiques_Click(sender As Object, e As EventArgs) Handles ButtonStatistiques.Click
        If getnbj() - 1 > 0 Then
            statsjoueurs()
        End If


        FormStatistiques.Show()
        Me.Hide()
    End Sub


    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim choix As Integer = MsgBox("Voulez vous vraiment quitter ?", MsgBoxStyle.YesNo, "Quitter")

        If choix = 6 Then
            Application.Exit()
            Ecrire()

        End If
    End Sub

    Sub statsjoueurs()
        FormStatistiques.ListBoxScores.Items.Clear()
        FormStatistiques.ListBoxNoms.Items.Clear()
        FormStatistiques.ListBoxNbPartiesCreer.Items.Clear()
        FormStatistiques.ListBoxNbPartiesChercher.Items.Clear()
        FormStatistiques.ListBoxTemps.Items.Clear()

        For i As Integer = 0 To getnbj() - 1

            FormStatistiques.ListBoxNoms.Items.Add(getJoueuri(i).nom)
            FormStatistiques.ListBoxScores.Items.Add(getJoueuri(i).score)
            FormStatistiques.ListBoxNbPartiesCreer.Items.Add(getJoueuri(i).nbPartieJoueur1)
            FormStatistiques.ListBoxNbPartiesChercher.Items.Add(getJoueuri(i).nbPartieJoueur2)
            FormStatistiques.ListBoxTemps.Items.Add(getJoueuri(i).temps)



        Next
    End Sub

    Sub Ecrire()
        Dim sw As StreamWriter = New StreamWriter("z:\Score.txt")
        sw.Write("", False)
        For i As Integer = 0 To getnbj() - 1
            sw.WriteLine(getJoueuri(i).nom)
            sw.WriteLine(getJoueuri(i).score)
            sw.WriteLine(getJoueuri(i).nbPartieJoueur1)
            sw.WriteLine(getJoueuri(i).nbPartieJoueur2)
            sw.WriteLine(getJoueuri(i).temps)
        Next

        sw.Close()
    End Sub



    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recuperer()
        For i As Integer = 0 To getnbj() - 1
            ComboBox1.Items.Add(getJoueuri(i).nom)
            ComboBox2.Items.Add(getJoueuri(i).nom)
        Next
    End Sub

    Sub recuperer()
        Dim sr As StreamReader = New StreamReader("z:\Score.txt")
        Dim lignes As Integer = File.ReadAllLines("z:\Score.txt").Length
        For i As Integer = 0 To lignes / 5
            For j As Integer = 0 To 4
                créerJoueur(sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine())
            Next
        Next
        sr.Close()
    End Sub

End Class