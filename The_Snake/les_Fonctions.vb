Module les_Fonctions
    Public etatDuJeu As String = "Play"
    Public tableauDesOrdonneesDesPointsRougesOrigines() As Integer = {16, 57, 98, 139, 180, 221, 262, 303, 344, 385, 426} '{14, 54, 94, 135, 176, 217, 258, 399, 340, 381, 422} 
    Public Function calculerToutesLesPositionsDuPointRouge() As Point()
        'Ici on determiner toutes les positions du point rouges qui peuvent tenir dans la fenetre.
        'Ces differentes positions sont calculées à partir des points d'origines sur l'axe des ordonnees qui ont pour abscisse 0
        Dim tableauDesPositionsDuPointRouge(165) As Point
        Dim lesOrdonnees, lesAbscisses, numeroDesPointsRouges, compteur, valeurDeLabscisse As Integer
        'Dim unPoint As New Point()
        numeroDesPointsRouges = 11 'Poisition à partir delaquelle on va commencer à calculer la position des points.

        For compteur = 0 To 10
            'unPoint.X = 0
            'unPoint.Y = tableauDesOrdonneesDesPointsRougesOrigines(compteur)
            tableauDesPositionsDuPointRouge(compteur).X = 22 '15 'unPoint.X
            tableauDesPositionsDuPointRouge(compteur).Y = tableauDesOrdonneesDesPointsRougesOrigines(compteur) 'unPoint.Y
        Next

        For lesOrdonnees = 0 To 10
            valeurDeLabscisse = tableauDesOrdonneesDesPointsRougesOrigines(lesOrdonnees)
            For lesAbscisses = 1 To 14
                tableauDesPositionsDuPointRouge(numeroDesPointsRouges).Y = tableauDesOrdonneesDesPointsRougesOrigines(lesOrdonnees)
                valeurDeLabscisse = valeurDeLabscisse + 41
                tableauDesPositionsDuPointRouge(numeroDesPointsRouges).X = valeurDeLabscisse
                numeroDesPointsRouges += 1
            Next
        Next

        Return tableauDesPositionsDuPointRouge
    End Function

    Public Sub determinerLaNouvellePositionDuPointRouge()
        While (Form1.choisirNumPositionDuPointRouge = copieDeLaValeurAleatoire)
            Form1.choisirNumPositionDuPointRouge = Form1.valeurAleatoire.Next(2, 163)
        End While
        copieDeLaValeurAleatoire = Form1.choisirNumPositionDuPointRouge
        Form1.pointRougeABouffer.Location = Form1.tableauDesPositionsDuPointRouge(Form1.choisirNumPositionDuPointRouge)
    End Sub

    Public Sub ajouterUneNouvellePartieSurLeSerpent()
        'Ici on Ajoute une partie sur le serpent et on fait en sorte que ces parties se deplacent avec le serpent.
        'nouvellePositionDePartie2DuSerpent = partie1.Location
        'nouvellePositionDePartie3DuSerpent = partie2.Location
        'nouvellePositionDePartie4DuSerpent = partie3.Location
        'nouvellePositionDePartie5DuSerpent = partie4.Location
        'nouvellePositionDePartie6DuSerpent = partie6.Location

        'partie2.Location = nouvellePositionDePartie2DuSerpent
        'partie3.Location = nouvellePositionDePartie3DuSerpent
        'partie4.Location = nouvellePositionDePartie4DuSerpent
        'partie5.Location = nouvellePositionDePartie5DuSerpent
        'partie6.Location = nouvellePositionDePartie6DuSerpent
        lesPartieDuSerpent(1).BackColor = Color.Lime
        For index = 0 To nbreDePartieQuiBouge
            Try
                lesNouvellePositionDeLaPartieDuSerpent(index) = lesPartieDuSerpent(index).Location
                lesPartieDuSerpent(index).BackColor = Color.Lime
            Catch ex As Exception

            End Try
        Next

        For index2 = 0 To nbreDePartieQuiBouge
            Try
                lesPartieDuSerpent(index2 + 1).Location = lesNouvellePositionDeLaPartieDuSerpent(index2)
            Catch ex As Exception

            End Try
        Next
    End Sub
    Public Sub repositionerToutLeMonde()
        Dim pointQuelquonque As New Point(-1, 735)
        lesPartieDuSerpent(1).Location = pointQuelquonque
        lesPartieDuSerpent(1).BackColor = Color.Yellow
        For index = 2 To lesPartieDuSerpent.Length - 1
            pointQuelquonque.X += 46
            lesPartieDuSerpent(index).Location = pointQuelquonque
            lesPartieDuSerpent(index).BackColor = Color.Yellow
        Next

    End Sub
    Public Sub jouerDeLaMusique()
        ' My.Computer.Audio.Play("C:\Users\ARMAND COLLINS MBA\Desktop\The_Snake\The_Snake\sonMouvement2.wav")
    End Sub
End Module
