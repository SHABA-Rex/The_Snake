Module les_Variables
    Public index, index2 As Integer
    Public nbreDePartieQuiBouge As Integer = 0 'Partie qui bouge + 1
    Public nbreTotalDePartiesDuSerpent As Integer = 18 'Il y'en a, le nombre reel obtenu en comptant le nombre de partie - 2 ,-2 pour enlever la premiere partie et pour prendre en compte le fait qu'on commence à compter à partir de 0 dans la boucle for  
    Public nouvellePositionDePartie2DuSerpent, nouvellePositionDePartie3DuSerpent, nouvellePositionDePartie4DuSerpent, nouvellePositionDePartie5DuSerpent, nouvellePositionDePartie6DuSerpent, nouvellePositionDePartie7DuSerpent, nouvellePositionDePartie8DuSerpent, nouvellePositionDePartie9DuSerpent, nouvellePositionDePartie10DuSerpent, nouvellePositionDePartie11DuSerpent, nouvellePositionDePartie12DuSerpent, nouvellePositionDePartie13DuSerpent, nouvellePositionDePartie14DuSerpent, nouvellePositionDePartie15DuSerpent, nouvellePositionDePartie16DuSerpent, nouvellePositionDePartie17DuSerpent, nouvellePositionDePartie18DuSerpent, nouvellePositionDePartie19DuSerpent, nouvellePositionDePartie20DuSerpent ', nouvellePositionDePartie21DuSerpent, nouvellePositionDePartie22DuSerpent, nouvellePositionDePartie23DuSerpent, nouvellePositionDePartie24DuSerpent, nouvellePositionDePartie25DuSerpent, nouvellePositionDePartie26DuSerpent, nouvellePositionDePartie27DuSerpent, nouvellePositionDePartie28DuSerpent, nouvellePositionDePartie29DuSerpent, nouvellePositionDePartie30DuSerpent As Point
    Public lesNouvellePositionDeLaPartieDuSerpent() As Point = {nouvellePositionDePartie2DuSerpent, nouvellePositionDePartie3DuSerpent, nouvellePositionDePartie4DuSerpent, nouvellePositionDePartie5DuSerpent, nouvellePositionDePartie6DuSerpent, nouvellePositionDePartie7DuSerpent, nouvellePositionDePartie8DuSerpent, nouvellePositionDePartie9DuSerpent, nouvellePositionDePartie10DuSerpent, nouvellePositionDePartie11DuSerpent, nouvellePositionDePartie12DuSerpent, nouvellePositionDePartie13DuSerpent, nouvellePositionDePartie14DuSerpent, nouvellePositionDePartie15DuSerpent, nouvellePositionDePartie16DuSerpent, nouvellePositionDePartie17DuSerpent, nouvellePositionDePartie18DuSerpent, nouvellePositionDePartie19DuSerpent, nouvellePositionDePartie20DuSerpent} ', nouvellePositionDePartie21DuSerpent, nouvellePositionDePartie22DuSerpent, nouvellePositionDePartie23DuSerpent, nouvellePositionDePartie24DuSerpent, nouvellePositionDePartie25DuSerpent, nouvellePositionDePartie26DuSerpent, nouvellePositionDePartie27DuSerpent, nouvellePositionDePartie28DuSerpent, nouvellePositionDePartie29DuSerpent, nouvellePositionDePartie30DuSerpent} 'nouvellePositionDeLaPartieDuSerpent ce tableau va contenir les valeurs des nouvelles positions de chaque partie du serpent.
    Public lesPartieDuSerpent() As Label = {Form1.partie1, Form1.partie2, Form1.partie3, Form1.partie4, Form1.partie5, Form1.partie6, Form1.partie7, Form1.partie8, Form1.partie9, Form1.partie10, Form1.partie11, Form1.partie12, Form1.partie13, Form1.partie14, Form1.partie15, Form1.partie16, Form1.partie17, Form1.partie18, Form1.partie19, Form1.partie20} ', Form1.partie21, Form1.partie22, Form1.partie23, Form1.partie24, Form1.partie25, Form1.partie26, Form1.partie27, Form1.partie28, Form1.partie29, Form1.partie30} 'Ici on va conserver chaque partie du serpent.MODIFIE LE NOMBRE TOTAL DES PARTIES DU SERPENT LA EN HAUT sur la variable nbreTotalDesPartiesDuSerpent , ceci après avoir ajouter les parties dans le tableau crée pour ça.
    Public marqueurPourLesTouchesDirectionelles As String
    Public positionDeLaTeteDuSerpent As Point = Form1.partie1.Location
    Public positionDeLaPartie2DuSerpent As Point = Form1.partie2.Location
    Public numeroDeLaPartieDuSerpentAactiver As Integer = 0
    Public abscisseDuPointRouge As Integer = 0
    Public anciennePositionDeLaTeteDuSerpent As Point
    Public vitesseDuSerpent As Integer = 200
    Public augmenterLaVitesseEnPasDe As Integer = 2
    'Ci-dessus cette valeur représente l'écart entre les differentes vitesses, elle représente la valeur qu'on ajoute sur la vitesse après chaque rencontre du serpent avec le point rouge 
    'Quand on ajoute sur le timer ça devient beaucoup plus lent, quand on retire ça devient plus rapide.
    Public nouvellePositionDeLaLimiteRouge1, nouvellePositionDeLaLimiteRouge2, nouvellePositionDeLaLimiteRouge3, nouvellePositionDeLaLimiteRouge4 As Point
    Friend copieDeLaValeurAleatoire As Integer = Form1.choisirNumPositionDuPointRouge
    Public limiteANePasDepasser() As Integer = {12, Form1.Width - 30, Form1.Height - 200}
    'On a enregistrer toutes les positions du Point Rouge , donc ici on les choisis
    Public activerDeplacementVersLaDroite, activerDeplacementVersLaGauche, activerDeplacementVersLeHaut, activerDeplacementVersLeBas As Boolean
    Public leSerpentAToucherUneLimite As Boolean = False
    Public scoreDuSerpent As Integer = 0
    Public highScore As Integer = 0
End Module
