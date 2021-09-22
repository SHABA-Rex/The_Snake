Imports System.IO
Public Class FenetreDuBoxDuBouttonRecommencer

    Private Sub bouttonRecommencer_Click(sender As Object, e As EventArgs) Handles bouttonRecommencer.Click
        Dim pointQuelquonque As New Point(16, 16)
        Form1.pointRougeABouffer.Location = pointQuelquonque
        scoreDuSerpent = 0
        pointQuelquonque.X = 3
        pointQuelquonque.Y = 3
        positionDeLaTeteDuSerpent = pointQuelquonque
        Form1.partie1.Location = positionDeLaTeteDuSerpent
        nbreDePartieQuiBouge = 0
        Form1.statutDuPointRouge.Text = "0000000"
        repositionerToutLeMonde()
        marqueurPourLesTouchesDirectionelles = "Boutton_Droit"
        vitesseDuSerpent = 200
        Form1.timerDeplacementBas_teteDuSerpent.Interval = vitesseDuSerpent
        Form1.timerDeplacementHaut_teteDuSerpent.Interval = vitesseDuSerpent
        Form1.timerDeplacementGauche_teteDuSerpent.Interval = vitesseDuSerpent
        Form1.timerDeplacementDroite_TeteDuSerpent.Interval = vitesseDuSerpent

        Form1.timerDeplacementBas_teteDuSerpent.Stop()
        Form1.timerDeplacementHaut_teteDuSerpent.Stop()
        Form1.timerDeplacementGauche_teteDuSerpent.Stop()
        Form1.timerDeplacementDroite_TeteDuSerpent.Stop()

        augmenterLaVitesseEnPasDe = 2
        leSerpentAToucherUneLimite = False
        Me.Hide()
    End Sub

    Private Sub FenetreDuBoxDuBouttonRecommencer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HighScoreJoueur.Text = File.ReadAllText(Form1.nomDuFichier)
    End Sub
End Class