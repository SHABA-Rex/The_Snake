Imports System.Drawing
Imports System.IO
Public Class Form1
    ''Condition sur la vitesse , il s'agit d'augmenter la vitesse de deplacement du serpent à chaque fois que le score sera un multiple de 5
    Public limiteANePasDepasser() As Integer = {20, Width - 200, Height - 90, 12}
    Public tableauDesPositionsDuPointRouge() As Point
    Public valeurAleatoire As New Random(0)
    Public choisirNumPositionDuPointRouge As Integer = valeurAleatoire.Next(2, 5)
    Public Const nomDuFichier As String = "HighScore.txt"

    Private Sub Form1_KeyDown(sender As Object, evenement As KeyEventArgs) Handles Me.KeyDown
        'Condition1, dans la condition1 on ne pourra effectuer la montee que si le marqueurQui precede est different de Boutton_Bas ,c'est pour eviter un deplacement interdit.
        'Ici chaque partie fait en sorte d'occuper à chaque fois la position de la partie du serpent qui la précède.

        'ajouterUneNouvellePartieSurLeSerpent()

        'nouvellePositionDePartie2DuSerpent = partie1.Location
        'nouvellePositionDePartie3DuSerpent = partie2.Location
        'nouvellePositionDePartie4DuSerpent = partie3.Location
        'nouvellePositionDePartie5DuSerpent = partie4.Location
        'nouvellePositionDePartie6DuSerpent = partie5.Location

        'partie2.Location = nouvellePositionDePartie2DuSerpent
        'partie3.Location = nouvellePositionDePartie3DuSerpent
        'partie4.Location = nouvellePositionDePartie4DuSerpent
        'partie5.Location = nouvellePositionDePartie5DuSerpent
        'partie6.Location = nouvellePositionDePartie6DuSerpent


        If (evenement.KeyCode = Keys.Up) And positionDeLaTeteDuSerpent.Y > limiteANePasDepasser(0) Then

            'positionDeLaTeteDuSerpent.Y -= 42
            'partie1.Location = positionDeLaTeteDuSerpent

            'nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
            'nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
            'nouvellePositionDeLaLimiteRouge3 = limiteRouge3.Location
            'nouvellePositionDeLaLimiteRouge1.X -= 5
            'nouvellePositionDeLaLimiteRouge2.X -= 5
            'nouvellePositionDeLaLimiteRouge3.Y -= 43
            'nouvellePositionDeLaLimiteRouge3.X += 40
            'nouvellePositionDeLaLimiteRouge1.Y -= 43
            'limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

            'nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location
            'nouvellePositionDeLaLimiteRouge4.X += 40
            'limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
            'limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
            'limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

            ''On va verifier si le pointRouge s'est fait bouffer.
            'If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
            '    statutDuPointRouge.Text = "Bouffer : absc:" & pointRougeABouffer.Location.X & "ord :" & pointRougeABouffer.Location.Y
            'Else
            '    statutDuPointRouge.Text = "Libre"
            'End If

            activerDeplacementVersLeHaut = True
            timerDeplacementHaut_teteDuSerpent.Start()

            If (marqueurPourLesTouchesDirectionelles <> "Boutton_Bas") Then
                'Condition1

                activerDeplacementVersLaGauche = False
                activerDeplacementVersLeBas = False
                activerDeplacementVersLaDroite = False

                timerDeplacementDroite_TeteDuSerpent.Stop()
                timerDeplacementGauche_teteDuSerpent.Stop()
                timerDeplacementBas_teteDuSerpent.Stop()
            End If

            'limiteDeLaBouffeRouge.Width = 40
            'limiteDeLaBouffeRouge.Height = 10
        ElseIf (evenement.KeyCode = Keys.Down) And positionDeLaTeteDuSerpent.Y < limiteANePasDepasser(2)

            '    positionDeLaTeteDuSerpent.Y += 42
            '    partie1.Location = positionDeLaTeteDuSerpent
            '    nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
            '    nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
            '    nouvellePositionDeLaLimiteRouge3 = limiteRouge3.Location
            '    nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location

            '    nouvellePositionDeLaLimiteRouge1.Y += 30
            '    nouvellePositionDeLaLimiteRouge3.X += 40
            '    nouvellePositionDeLaLimiteRouge3.Y += 30

            '    nouvellePositionDeLaLimiteRouge2.Y += 83
            '    nouvellePositionDeLaLimiteRouge4.X += 40
            '    nouvellePositionDeLaLimiteRouge4.Y += 83

            '    limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
            '    limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
            '    limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
            '    limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4


            'If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
            '    statutDuPointRouge.Text = "Bouffer : absc:" & pointRougeABouffer.Location.X & "ord :" & pointRougeABouffer.Location.Y
            'Else
            '    statutDuPointRouge.Text = "Libre"
            'End If

            activerDeplacementVersLeBas = True
            timerDeplacementBas_teteDuSerpent.Start()

            If (marqueurPourLesTouchesDirectionelles <> "Boutton_Haut") Then

                activerDeplacementVersLaGauche = False
                activerDeplacementVersLaDroite = False
                activerDeplacementVersLeHaut = False

                timerDeplacementDroite_TeteDuSerpent.Stop()
                timerDeplacementGauche_teteDuSerpent.Stop()
                timerDeplacementHaut_teteDuSerpent.Stop()
            End If

            'limiteDeLaBouffeRouge.Width = 40
            'limiteDeLaBouffeRouge.Height = 10
        ElseIf (evenement.KeyCode = Keys.Right) And positionDeLaTeteDuSerpent.X < Width - 100

            'positionDeLaTeteDuSerpent.X += 42
            'partie1.Location = positionDeLaTeteDuSerpent
            'nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
            'nouvellePositionDeLaLimiteRouge1.X += 30
            'nouvellePositionDeLaLimiteRouge2.X += 30
            'nouvellePositionDeLaLimiteRouge2.Y += 30
            'nouvellePositionDeLaLimiteRouge3.X += 83
            'nouvellePositionDeLaLimiteRouge4.Y += 30
            'nouvellePositionDeLaLimiteRouge4.X += 83
            'limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
            'limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
            'limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
            'limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

            'If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
            '    statutDuPointRouge.Text = "Bouffer : absc:" & pointRougeABouffer.Location.X & "ord :" & pointRougeABouffer.Location.Y
            'Else
            '    statutDuPointRouge.Text = "Libre"
            'End If

            activerDeplacementVersLaDroite = True
            timerDeplacementDroite_TeteDuSerpent.Start()

            If (marqueurPourLesTouchesDirectionelles <> "Boutton_Gauche") Then

                activerDeplacementVersLaGauche = False
                activerDeplacementVersLeBas = False
                activerDeplacementVersLeHaut = False

                timerDeplacementGauche_teteDuSerpent.Stop()
                timerDeplacementBas_teteDuSerpent.Stop()
                timerDeplacementHaut_teteDuSerpent.Stop()
            End If

            'limiteDeLaBouffeRouge.Width = 10
            'limiteDeLaBouffeRouge.Height = 40
        ElseIf (evenement.KeyCode = Keys.Left) And positionDeLaTeteDuSerpent.X > limiteANePasDepasser(3)

            'positionDeLaTeteDuSerpent.X -= 42
            'partie1.Location = positionDeLaTeteDuSerpent

            'nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location
            'nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
            'nouvellePositionDeLaLimiteRouge4.Y += 30
            'nouvellePositionDeLaLimiteRouge2.Y += 30
            'nouvellePositionDeLaLimiteRouge2.X -= 46
            'nouvellePositionDeLaLimiteRouge1.X -= 46
            'limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
            'limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
            'limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

            'If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
            '    statutDuPointRouge.Text = "Bouffer : absc:" & pointRougeABouffer.Location.X & "ord :" & pointRougeABouffer.Location.Y
            'Else
            '    statutDuPointRouge.Text = "Libre"
            'End If

            activerDeplacementVersLaGauche = True
            timerDeplacementGauche_teteDuSerpent.Start()

            If (marqueurPourLesTouchesDirectionelles <> "Boutton_Droit") Then
                activerDeplacementVersLeBas = False
                activerDeplacementVersLaDroite = False
                activerDeplacementVersLeHaut = False

                timerDeplacementDroite_TeteDuSerpent.Stop()
                timerDeplacementBas_teteDuSerpent.Stop()
                timerDeplacementHaut_teteDuSerpent.Stop()
            End If

            'limiteDeLaBouffeRouge.Width = 10
            'limiteDeLaBouffeRouge.Height = 40
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rectangle As New RectangleF(100, 100, 40, 40)
        limiteRouge1.BackColor = Color.Yellow
        limiteRouge2.BackColor = Color.Yellow
        limiteRouge3.BackColor = Color.Yellow
        limiteRouge4.BackColor = Color.Yellow
        marqueurPourLesTouchesDirectionelles = "Boutton_Droit"
        'ON recupere le highScore ecrit dans le fichier HighScore.txt et on stocke la valeur et dans le label HighScore et dans la variable highScore
        highScore2Joueur.Text = File.ReadAllText(nomDuFichier)
        highScore = Integer.Parse(highScore2Joueur.Text)
        For compteur = 0 To lesPartieDuSerpent.Length - 1
            lesPartieDuSerpent(compteur).Text = ""
        Next
        repositionerToutLeMonde()
        'timerDeplacementDroite_TeteDuSerpent.Start()
        'timerDeplacementHaut_teteDuSerpent.Start()
        tableauDesPositionsDuPointRouge = calculerToutesLesPositionsDuPointRouge()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        limiteANePasDepasser(1) = Width
        limiteANePasDepasser(2) = Height - 110
        change.Text = "large:" & Width & ", long" & Height
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        determinerLaNouvellePositionDuPointRouge()
    End Sub

    Private Sub timeDeplacementDroite_TeteDuSerpent_Tick(sender As Object, e As EventArgs) Handles timerDeplacementDroite_TeteDuSerpent.Tick
        If (Not (leSerpentAToucherUneLimite)) Then

            If (marqueurPourLesTouchesDirectionelles = "Boutton_Droit" Or marqueurPourLesTouchesDirectionelles = "Boutton_Bas" Or marqueurPourLesTouchesDirectionelles = "Boutton_Haut") Then

                'Ici chaque partie fait en sorte d'occuper à chaque fois la position de la partie du serpent qui la précède.
                ajouterUneNouvellePartieSurLeSerpent()
                'nouvellePositionDePartie2DuSerpent = partie1.Location
                'nouvellePositionDePartie3DuSerpent = partie2.Location
                'nouvellePositionDePartie4DuSerpent = partie3.Location
                'nouvellePositionDePartie5DuSerpent = partie4.Location
                'nouvellePositionDePartie6DuSerpent = partie6.Location

                'partie2.Location = nouvellePositionDePartie2DuSerpent
                'partie3.Location = nouvellePositionDePartie3DuSerpent
                'partie4.Location = nouvellePositionDePartie4DuSerpent
                'partie5.Location = nouvellePositionDePartie5DuSerpent
                'partie6.Location = nouvellePositionDePartie5DuSerpent

                nouvellePositionDeLaLimiteRouge1 = partie1.Location
                limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

                nouvellePositionDeLaLimiteRouge2 = partie1.Location
                limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2


                nouvellePositionDeLaLimiteRouge3 = partie1.Location
                limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3

                nouvellePositionDeLaLimiteRouge4 = partie1.Location
                limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4


                If (activerDeplacementVersLaDroite) Then

                    If (positionDeLaTeteDuSerpent.X < Width - 100) Then
                        positionDeLaTeteDuSerpent.X += 42
                        partie1.Location = positionDeLaTeteDuSerpent
                        nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
                        nouvellePositionDeLaLimiteRouge1.X += 30
                        nouvellePositionDeLaLimiteRouge2.X += 30
                        nouvellePositionDeLaLimiteRouge2.Y += 30
                        nouvellePositionDeLaLimiteRouge3.X += 83
                        nouvellePositionDeLaLimiteRouge4.Y += 30
                        nouvellePositionDeLaLimiteRouge4.X += 83
                        limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
                        limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
                        limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
                        limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                        If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
                            scoreDuSerpent += 10
                            statutDuPointRouge.Text = scoreDuSerpent '"Bouffer : absc:" & pointRougeABouffer.Location.X & "ord :" & pointRougeABouffer.Location.Y
                            jouerDeLaMusique() 'Emet le son lorsqu'on touche le point rouge.
                            If ((scoreDuSerpent Mod augmenterLaVitesseEnPasDe) = 0) And vitesseDuSerpent > augmenterLaVitesseEnPasDe Then
                                'Condition sur la vitesse
                                vitesseDuSerpent -= augmenterLaVitesseEnPasDe
                                timerDeplacementBas_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementHaut_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementGauche_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementDroite_TeteDuSerpent.Interval = vitesseDuSerpent
                            End If
                            If (nbreDePartieQuiBouge < nbreTotalDePartiesDuSerpent) Then
                                nbreDePartieQuiBouge += 1
                            End If
                            determinerLaNouvellePositionDuPointRouge()
                        Else
                            'statutDuPointRouge.Text = "Libre"
                        End If
                    Else
                        FenetreDuBoxDuBouttonRecommencer.Show()
                        FenetreDuBoxDuBouttonRecommencer.ScoreJoueur.Text = scoreDuSerpent
                        If (scoreDuSerpent > highScore) Then
                            FenetreDuBoxDuBouttonRecommencer.HighScoreJoueur.Text = scoreDuSerpent
                            highScore2Joueur.Text = scoreDuSerpent
                            highScore = scoreDuSerpent
                            File.WriteAllText(nomDuFichier, highScore)
                        End If
                        leSerpentAToucherUneLimite = True
                        toucherLesBords.Text = "On a toucher le cote droit"
                        activerDeplacementVersLaDroite = False
                        timerDeplacementDroite_TeteDuSerpent.Stop()
                    End If
                End If
                marqueurPourLesTouchesDirectionelles = "Boutton_Droit"
            End If
        End If
    End Sub
    Private Sub timerDeplacementHaut_teteDuSerpent_Tick(sender As Object, e As EventArgs) Handles timerDeplacementHaut_teteDuSerpent.Tick
        If (Not (leSerpentAToucherUneLimite)) Then

            If (marqueurPourLesTouchesDirectionelles = "Boutton_Haut" Or marqueurPourLesTouchesDirectionelles = "Boutton_Droit" Or marqueurPourLesTouchesDirectionelles = "Boutton_Gauche") Then


                'Ici chaque partie fait en sorte d'occuper à chaque fois la position de la partie du serpent qui la précède.
                ajouterUneNouvellePartieSurLeSerpent()
                'nouvellePositionDePartie2DuSerpent = partie1.Location
                'nouvellePositionDePartie3DuSerpent = partie2.Location
                'nouvellePositionDePartie4DuSerpent = partie3.Location
                'nouvellePositionDePartie5DuSerpent = partie4.Location
                'nouvellePositionDePartie6DuSerpent = partie6.Location

                'partie2.Location = nouvellePositionDePartie2DuSerpent
                'partie3.Location = nouvellePositionDePartie3DuSerpent
                'partie4.Location = nouvellePositionDePartie4DuSerpent
                'partie5.Location = nouvellePositionDePartie5DuSerpent
                'partie6.Location = nouvellePositionDePartie5DuSerpent

                nouvellePositionDeLaLimiteRouge1 = partie1.Location
                limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

                nouvellePositionDeLaLimiteRouge2 = partie1.Location
                limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2


                nouvellePositionDeLaLimiteRouge3 = partie1.Location
                limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3

                nouvellePositionDeLaLimiteRouge4 = partie1.Location
                limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                If (activerDeplacementVersLeHaut) Then

                    If (positionDeLaTeteDuSerpent.Y > limiteANePasDepasser(0)) Then
                        positionDeLaTeteDuSerpent.Y -= 42
                        partie1.Location = positionDeLaTeteDuSerpent

                        nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
                        nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
                        nouvellePositionDeLaLimiteRouge3 = limiteRouge3.Location
                        nouvellePositionDeLaLimiteRouge1.X -= 5
                        nouvellePositionDeLaLimiteRouge2.X -= 5
                        nouvellePositionDeLaLimiteRouge3.Y -= 43
                        nouvellePositionDeLaLimiteRouge3.X += 40
                        nouvellePositionDeLaLimiteRouge1.Y -= 43
                        limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

                        nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location
                        nouvellePositionDeLaLimiteRouge4.X += 40
                        limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
                        limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
                        limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                        'On va verifier si le pointRouge s'est fait bouffer.
                        If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
                            scoreDuSerpent += 10
                            statutDuPointRouge.Text = scoreDuSerpent
                            jouerDeLaMusique() 'Emet le son lorsqu'on touche le point rouge.
                            If ((scoreDuSerpent Mod augmenterLaVitesseEnPasDe) = 0) And vitesseDuSerpent > augmenterLaVitesseEnPasDe Then
                                'Condition sur la vitesse
                                vitesseDuSerpent -= augmenterLaVitesseEnPasDe
                                timerDeplacementBas_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementHaut_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementGauche_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementDroite_TeteDuSerpent.Interval = vitesseDuSerpent
                            End If

                            If (nbreDePartieQuiBouge < nbreTotalDePartiesDuSerpent) Then
                                nbreDePartieQuiBouge += 1
                            End If

                            determinerLaNouvellePositionDuPointRouge()
                        Else
                            'statutDuPointRouge.Text = "Libre"
                        End If
                    Else
                        FenetreDuBoxDuBouttonRecommencer.Show()
                        FenetreDuBoxDuBouttonRecommencer.ScoreJoueur.Text = scoreDuSerpent
                        If (scoreDuSerpent > highScore) Then
                            FenetreDuBoxDuBouttonRecommencer.HighScoreJoueur.Text = scoreDuSerpent
                            highScore2Joueur.Text = scoreDuSerpent
                            highScore = scoreDuSerpent
                            File.WriteAllText(nomDuFichier, highScore)
                        End If
                        leSerpentAToucherUneLimite = True
                        toucherLesBords.Text = "On a toucher le Haut"
                        timerDeplacementHaut_teteDuSerpent.Stop()
                        activerDeplacementVersLeHaut = False
                    End If
                End If
                marqueurPourLesTouchesDirectionelles = "Boutton_Haut"
            End If
        End If
    End Sub
    Private Sub timerDeplacementGauche_teteDuSerpent_Tick(sender As Object, e As EventArgs) Handles timerDeplacementGauche_teteDuSerpent.Tick
        If (Not (leSerpentAToucherUneLimite)) Then

            If (marqueurPourLesTouchesDirectionelles = "Boutton_Gauche" Or marqueurPourLesTouchesDirectionelles = "Boutton_Bas" Or marqueurPourLesTouchesDirectionelles = "Boutton_Haut") Then


                'Ici chaque partie fait en sorte d'occuper à chaque fois la position de la partie du serpent qui la précède.
                ajouterUneNouvellePartieSurLeSerpent()
                'nouvellePositionDePartie2DuSerpent = partie1.Location
                'nouvellePositionDePartie3DuSerpent = partie2.Location
                'nouvellePositionDePartie4DuSerpent = partie3.Location
                'nouvellePositionDePartie5DuSerpent = partie4.Location
                'nouvellePositionDePartie6DuSerpent = partie6.Location

                'partie2.Location = nouvellePositionDePartie2DuSerpent
                'partie3.Location = nouvellePositionDePartie3DuSerpent
                'partie4.Location = nouvellePositionDePartie4DuSerpent
                'partie5.Location = nouvellePositionDePartie5DuSerpent
                'partie6.Location = nouvellePositionDePartie5DuSerpent

                nouvellePositionDeLaLimiteRouge1 = partie1.Location
                limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

                nouvellePositionDeLaLimiteRouge2 = partie1.Location
                limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2


                nouvellePositionDeLaLimiteRouge3 = partie1.Location
                limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3

                nouvellePositionDeLaLimiteRouge4 = partie1.Location
                limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4


                If (activerDeplacementVersLaGauche) Then
                    If (positionDeLaTeteDuSerpent.X > limiteANePasDepasser(3)) Then
                        positionDeLaTeteDuSerpent.X -= 42
                        partie1.Location = positionDeLaTeteDuSerpent

                        nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location
                        nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
                        nouvellePositionDeLaLimiteRouge4.Y += 30
                        nouvellePositionDeLaLimiteRouge2.Y += 30
                        nouvellePositionDeLaLimiteRouge2.X -= 46
                        nouvellePositionDeLaLimiteRouge1.X -= 46
                        limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
                        limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
                        limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                        'On verifie si le point rouge s'est fait bouffer.
                        If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
                            scoreDuSerpent += 10
                            statutDuPointRouge.Text = scoreDuSerpent 'Ici on a le score du serpent.
                            jouerDeLaMusique() 'Emet le son lorsqu'on touche le point rouge.
                            If ((scoreDuSerpent Mod augmenterLaVitesseEnPasDe) = 0) And vitesseDuSerpent > augmenterLaVitesseEnPasDe Then
                                'Condition sur la vitesse
                                vitesseDuSerpent -= augmenterLaVitesseEnPasDe
                                timerDeplacementBas_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementHaut_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementGauche_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementDroite_TeteDuSerpent.Interval = vitesseDuSerpent
                            End If

                            If (nbreDePartieQuiBouge < nbreTotalDePartiesDuSerpent) Then
                                nbreDePartieQuiBouge += 1
                            End If

                            determinerLaNouvellePositionDuPointRouge()
                        Else
                            'statutDuPointRouge.Text = "Libre"
                        End If
                    Else
                        FenetreDuBoxDuBouttonRecommencer.Show()
                        FenetreDuBoxDuBouttonRecommencer.ScoreJoueur.Text = scoreDuSerpent
                        If (scoreDuSerpent > highScore) Then
                            FenetreDuBoxDuBouttonRecommencer.HighScoreJoueur.Text = scoreDuSerpent
                            highScore2Joueur.Text = scoreDuSerpent
                            highScore = scoreDuSerpent
                            File.WriteAllText(nomDuFichier, highScore)
                        End If
                        leSerpentAToucherUneLimite = True
                        toucherLesBords.Text = "On a toucher le cote Gauche"
                        activerDeplacementVersLaGauche = False
                        timerDeplacementGauche_teteDuSerpent.Stop()
                    End If
                End If
                marqueurPourLesTouchesDirectionelles = "Boutton_Gauche"
            End If
        End If
    End Sub
    Private Sub timerDeplacementBas_teteDuSerpent_Tick(sender As Object, e As EventArgs) Handles timerDeplacementBas_teteDuSerpent.Tick
        If (Not (leSerpentAToucherUneLimite)) Then
            If (marqueurPourLesTouchesDirectionelles = "Boutton_Bas" Or marqueurPourLesTouchesDirectionelles = "Boutton_Droit" Or marqueurPourLesTouchesDirectionelles = "Boutton_Gauche") Then

                'Ici chaque partie fait en sorte d'occuper à chaque fois la position de la partie du serpent qui la précède.            
                ajouterUneNouvellePartieSurLeSerpent()
                'nouvellePositionDePartie2DuSerpent = partie1.Location
                'nouvellePositionDePartie3DuSerpent = partie2.Location
                'nouvellePositionDePartie4DuSerpent = partie3.Location
                'nouvellePositionDePartie5DuSerpent = partie4.Location
                'nouvellePositionDePartie6DuSerpent = partie6.Location

                'partie2.Location = nouvellePositionDePartie2DuSerpent
                'partie3.Location = nouvellePositionDePartie3DuSerpent
                'partie4.Location = nouvellePositionDePartie4DuSerpent
                'partie5.Location = nouvellePositionDePartie5DuSerpent
                'partie6.Location = nouvellePositionDePartie5DuSerpent

                nouvellePositionDeLaLimiteRouge1 = partie1.Location
                limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1

                nouvellePositionDeLaLimiteRouge2 = partie1.Location
                limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2

                nouvellePositionDeLaLimiteRouge3 = partie1.Location
                limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3

                nouvellePositionDeLaLimiteRouge4 = partie1.Location
                limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                If (activerDeplacementVersLeBas) Then
                    If (positionDeLaTeteDuSerpent.Y < limiteANePasDepasser(2)) Then
                        positionDeLaTeteDuSerpent.Y += 42
                        partie1.Location = positionDeLaTeteDuSerpent
                        nouvellePositionDeLaLimiteRouge1 = limiteRouge1.Location
                        nouvellePositionDeLaLimiteRouge2 = limiteRouge2.Location
                        nouvellePositionDeLaLimiteRouge3 = limiteRouge3.Location
                        nouvellePositionDeLaLimiteRouge4 = limiteRouge4.Location

                        nouvellePositionDeLaLimiteRouge1.Y += 30
                        nouvellePositionDeLaLimiteRouge3.X += 40
                        nouvellePositionDeLaLimiteRouge3.Y += 30

                        nouvellePositionDeLaLimiteRouge2.Y += 83
                        nouvellePositionDeLaLimiteRouge4.X += 40
                        nouvellePositionDeLaLimiteRouge4.Y += 83

                        limiteRouge1.Location = nouvellePositionDeLaLimiteRouge1
                        limiteRouge2.Location = nouvellePositionDeLaLimiteRouge2
                        limiteRouge3.Location = nouvellePositionDeLaLimiteRouge3
                        limiteRouge4.Location = nouvellePositionDeLaLimiteRouge4

                        If (pointRougeABouffer.Location.Y > limiteRouge1.Location.Y) And (pointRougeABouffer.Location.Y > limiteRouge3.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge2.Location.Y) And (pointRougeABouffer.Location.Y < limiteRouge4.Location.Y) And (pointRougeABouffer.Location.X > limiteRouge1.Location.X) And (pointRougeABouffer.Location.X < limiteRouge3.Location.X) Then
                            scoreDuSerpent += 10
                            statutDuPointRouge.Text = scoreDuSerpent
                            jouerDeLaMusique() 'Emet le son lorsqu'on touche le point rouge.
                            If ((scoreDuSerpent Mod augmenterLaVitesseEnPasDe) = 0) And vitesseDuSerpent > augmenterLaVitesseEnPasDe Then
                                'Condition sur la vitesse
                                vitesseDuSerpent -= augmenterLaVitesseEnPasDe
                                timerDeplacementBas_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementHaut_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementGauche_teteDuSerpent.Interval = vitesseDuSerpent
                                timerDeplacementDroite_TeteDuSerpent.Interval = vitesseDuSerpent
                            End If

                            If (nbreDePartieQuiBouge < nbreTotalDePartiesDuSerpent) Then
                                nbreDePartieQuiBouge += 1
                            End If

                            determinerLaNouvellePositionDuPointRouge()
                        Else
                            'statutDuPointRouge.Text = "Libre"
                        End If
                    Else
                        FenetreDuBoxDuBouttonRecommencer.Show()
                        FenetreDuBoxDuBouttonRecommencer.ScoreJoueur.Text = scoreDuSerpent
                        If (scoreDuSerpent > highScore) Then
                            FenetreDuBoxDuBouttonRecommencer.HighScoreJoueur.Text = scoreDuSerpent
                            highScore2Joueur.Text = scoreDuSerpent
                            highScore = scoreDuSerpent
                            File.WriteAllText(nomDuFichier, highScore)
                        End If
                        leSerpentAToucherUneLimite = True
                        toucherLesBords.Text = "On a toucher le bas"
                        activerDeplacementVersLeBas = False
                        timerDeplacementBas_teteDuSerpent.Stop()
                    End If
                End If
                marqueurPourLesTouchesDirectionelles = "Boutton_Bas"
            End If
        End If
    End Sub

    Private Sub bouttonPause_Click(sender As Object, e As EventArgs) Handles bouttonPause.Click
        Select Case etatDuJeu
            Case "Pause"
                etatDuJeu = "Play"
                timerDeplacementBas_teteDuSerpent.Start()
                timerDeplacementDroite_TeteDuSerpent.Start()
                timerDeplacementGauche_teteDuSerpent.Start()
                timerDeplacementHaut_teteDuSerpent.Start()
                bouttonPause.Text = "Pause"
                bouttonPause.BackColor = Color.LawnGreen
            Case "Play"
                etatDuJeu = "Pause"
                timerDeplacementBas_teteDuSerpent.Stop()
                timerDeplacementDroite_TeteDuSerpent.Stop()
                timerDeplacementGauche_teteDuSerpent.Stop()
                timerDeplacementHaut_teteDuSerpent.Stop()
                bouttonPause.Text = "Play"
                bouttonPause.BackColor = Color.Yellow
        End Select
    End Sub
End Class
