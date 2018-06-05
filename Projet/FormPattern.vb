Public Class FormPattern

    Dim CaractèresAutorisés As String = "#$£%@"
    Dim Jeu As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged, TextBox4.TextChanged, TextBox5.TextChanged
        If CaractèresAutorisés.Contains(sender.text) Then
            LabelError.Visible = False
            Exit Sub
        Else
            sender.text = ""
            LabelError.Visible = False
        End If


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As Boolean = True
        For Each txbx As TextBox In PanelCacher.Controls
            If txbx.Text = "" Then
                test = False
                LabelError.Visible = True
            End If
        Next

        If test = True Then
            For Each txbx As TextBox In PanelCacher.Controls
                Jeu = Jeu + txbx.Text
            Next

            Me.Hide()
            FormJeu.LabelComb.Text = Jeu
            FormJeu.Show()
            FormJeu.Timer1.Start()

        End If

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelCaractère.Text = CaractèresAutorisés

    End Sub
End Class
