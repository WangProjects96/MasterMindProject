Module Joueurs
    Dim joueurs(5) As joueur
    Dim nbJoueurs As Integer = 0
    Structure joueur
        Dim nom As String
        Dim score As Integer
        Dim nbPartieJoueur1 As Integer
        Dim nbPartieJoueur2 As Integer
        Dim temps As Integer

    End Structure

    Sub créerJoueur(nom As String, score As Integer, nbJoueur1 As Integer, nbJoueur2 As Integer, temps As Integer)
        Dim trouvé As Boolean = False
        For i As Integer = 0 To UBound(joueurs)
            If joueurs(i).nom = nom Then
                trouvé = True
                joueurs(i).score = joueurs(i).score + score
                joueurs(i).nbPartieJoueur1 = joueurs(i).nbPartieJoueur1 + nbJoueur1
                joueurs(i).nbPartieJoueur2 = joueurs(i).nbPartieJoueur2 + nbJoueur2
                joueurs(i).temps = joueurs(i).temps + temps

            End If

        Next
        If trouvé = False Then
            Dim persn As joueur
            persn.nom = nom
            persn.score = score
            persn.nbPartieJoueur1 = nbJoueur1
            persn.nbPartieJoueur2 = nbJoueur2
            persn.temps = temps
            If (nbJoueurs + 1 = joueurs.Length) Then
                ReDim Preserve joueurs(UBound(joueurs) + 5)
            End If
            joueurs(nbJoueurs) = persn
            nbJoueurs = nbJoueurs + 1
        End If
    End Sub

    Function getnbj() As Integer
        Return nbJoueurs
    End Function



    Sub enregistrerjoueur2gagnant()

    End Sub

    Function existe(name As String) As Integer
        For i As Integer = 0 To UBound(joueurs) Step (+1)
            If joueurs(i).nom = name Then
                Return i
            End If
        Next

        Return vbNull
    End Function

    Function getJoueuri(i As Integer) As joueur
        Return joueurs(i)
    End Function

    Public Sub trierParAlphabetique()
        Dim a As joueur

        For i = 0 To nbJoueurs - 1
            For j = i To nbJoueurs - 1
                If Compare(joueurs(i).nom, joueurs(j).nom) = True Then
                    a = joueurs(i)
                    joueurs(i) = joueurs(j)
                    joueurs(j) = a
                End If
            Next
        Next
    End Sub

    Function Compare(Chaine1 As String, Chaine2 As String) As Boolean
        If Trim(Chaine1) > Trim(Chaine2) Then
            Return True
        Else : Return False
        End If
    End Function

End Module
