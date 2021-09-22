<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.change = New Guna.UI.WinForms.GunaLabel()
        Me.timerDeplacementDroite_TeteDuSerpent = New System.Windows.Forms.Timer(Me.components)
        Me.timerDeplacementHaut_teteDuSerpent = New System.Windows.Forms.Timer(Me.components)
        Me.timerDeplacementGauche_teteDuSerpent = New System.Windows.Forms.Timer(Me.components)
        Me.timerDeplacementBas_teteDuSerpent = New System.Windows.Forms.Timer(Me.components)
        Me.toucherLesBords = New Guna.UI.WinForms.GunaLabel()
        Me.limiteRouge4 = New Guna.UI.WinForms.GunaLabel()
        Me.limiteRouge2 = New Guna.UI.WinForms.GunaLabel()
        Me.limiteRouge3 = New Guna.UI.WinForms.GunaLabel()
        Me.limiteRouge1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.statutDuPointRouge = New Guna.UI.WinForms.GunaLabel()
        Me.partie12 = New Guna.UI.WinForms.GunaLabel()
        Me.partie11 = New Guna.UI.WinForms.GunaLabel()
        Me.partie10 = New Guna.UI.WinForms.GunaLabel()
        Me.partie9 = New Guna.UI.WinForms.GunaLabel()
        Me.partie8 = New Guna.UI.WinForms.GunaLabel()
        Me.partie7 = New Guna.UI.WinForms.GunaLabel()
        Me.partie6 = New Guna.UI.WinForms.GunaLabel()
        Me.partie5 = New Guna.UI.WinForms.GunaLabel()
        Me.partie4 = New Guna.UI.WinForms.GunaLabel()
        Me.partie3 = New Guna.UI.WinForms.GunaLabel()
        Me.partie2 = New Guna.UI.WinForms.GunaLabel()
        Me.partie13 = New Guna.UI.WinForms.GunaLabel()
        Me.partie1 = New Guna.UI.WinForms.GunaLabel()
        Me.partie19 = New Guna.UI.WinForms.GunaLabel()
        Me.partie18 = New Guna.UI.WinForms.GunaLabel()
        Me.partie15 = New Guna.UI.WinForms.GunaLabel()
        Me.partie16 = New Guna.UI.WinForms.GunaLabel()
        Me.partie17 = New Guna.UI.WinForms.GunaLabel()
        Me.partie14 = New Guna.UI.WinForms.GunaLabel()
        Me.partie20 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.pointRougeABouffer = New Guna.UI.WinForms.GunaLabel()
        Me.highScore2Joueur = New Guna.UI.WinForms.GunaLabel()
        Me.bouttonPause = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.Lime
        Me.change.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(591, 318)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(221, 28)
        Me.change.TabIndex = 4
        Me.change.Text = "change"
        Me.change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.change.Visible = False
        '
        'timerDeplacementDroite_TeteDuSerpent
        '
        Me.timerDeplacementDroite_TeteDuSerpent.Interval = 200
        '
        'timerDeplacementHaut_teteDuSerpent
        '
        Me.timerDeplacementHaut_teteDuSerpent.Interval = 200
        '
        'timerDeplacementGauche_teteDuSerpent
        '
        Me.timerDeplacementGauche_teteDuSerpent.Interval = 200
        '
        'timerDeplacementBas_teteDuSerpent
        '
        Me.timerDeplacementBas_teteDuSerpent.Interval = 200
        '
        'toucherLesBords
        '
        Me.toucherLesBords.BackColor = System.Drawing.Color.Lime
        Me.toucherLesBords.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toucherLesBords.Location = New System.Drawing.Point(340, 317)
        Me.toucherLesBords.Name = "toucherLesBords"
        Me.toucherLesBords.Size = New System.Drawing.Size(105, 29)
        Me.toucherLesBords.TabIndex = 25
        Me.toucherLesBords.Text = "Utile"
        Me.toucherLesBords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toucherLesBords.Visible = False
        '
        'limiteRouge4
        '
        Me.limiteRouge4.BackColor = System.Drawing.Color.Blue
        Me.limiteRouge4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limiteRouge4.Location = New System.Drawing.Point(559, 193)
        Me.limiteRouge4.Name = "limiteRouge4"
        Me.limiteRouge4.Size = New System.Drawing.Size(10, 10)
        Me.limiteRouge4.TabIndex = 36
        Me.limiteRouge4.Text = "1"
        Me.limiteRouge4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'limiteRouge2
        '
        Me.limiteRouge2.BackColor = System.Drawing.Color.DarkGray
        Me.limiteRouge2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limiteRouge2.Location = New System.Drawing.Point(477, 193)
        Me.limiteRouge2.Name = "limiteRouge2"
        Me.limiteRouge2.Size = New System.Drawing.Size(10, 10)
        Me.limiteRouge2.TabIndex = 35
        Me.limiteRouge2.Text = "1"
        Me.limiteRouge2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'limiteRouge3
        '
        Me.limiteRouge3.BackColor = System.Drawing.Color.Red
        Me.limiteRouge3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limiteRouge3.Location = New System.Drawing.Point(514, 193)
        Me.limiteRouge3.Name = "limiteRouge3"
        Me.limiteRouge3.Size = New System.Drawing.Size(10, 10)
        Me.limiteRouge3.TabIndex = 34
        Me.limiteRouge3.Text = "1"
        Me.limiteRouge3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'limiteRouge1
        '
        Me.limiteRouge1.BackColor = System.Drawing.Color.Green
        Me.limiteRouge1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limiteRouge1.Location = New System.Drawing.Point(435, 193)
        Me.limiteRouge1.Name = "limiteRouge1"
        Me.limiteRouge1.Size = New System.Drawing.Size(10, 10)
        Me.limiteRouge1.TabIndex = 33
        Me.limiteRouge1.Text = "1"
        Me.limiteRouge1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.Yellow
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel1.Location = New System.Drawing.Point(1132, 3)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(95, 36)
        Me.GunaLabel1.TabIndex = 40
        Me.GunaLabel1.Text = "Score : "
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'statutDuPointRouge
        '
        Me.statutDuPointRouge.BackColor = System.Drawing.Color.Yellow
        Me.statutDuPointRouge.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.statutDuPointRouge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.statutDuPointRouge.Location = New System.Drawing.Point(1159, 33)
        Me.statutDuPointRouge.Name = "statutDuPointRouge"
        Me.statutDuPointRouge.Size = New System.Drawing.Size(158, 20)
        Me.statutDuPointRouge.TabIndex = 43
        Me.statutDuPointRouge.Text = "0000000"
        Me.statutDuPointRouge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'partie12
        '
        Me.partie12.BackColor = System.Drawing.Color.Yellow
        Me.partie12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie12.Location = New System.Drawing.Point(447, 704)
        Me.partie12.Name = "partie12"
        Me.partie12.Size = New System.Drawing.Size(40, 40)
        Me.partie12.TabIndex = 64
        Me.partie12.Text = "12"
        Me.partie12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie11
        '
        Me.partie11.BackColor = System.Drawing.Color.Yellow
        Me.partie11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie11.Location = New System.Drawing.Point(401, 704)
        Me.partie11.Name = "partie11"
        Me.partie11.Size = New System.Drawing.Size(40, 40)
        Me.partie11.TabIndex = 65
        Me.partie11.Text = "11"
        Me.partie11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie10
        '
        Me.partie10.BackColor = System.Drawing.Color.Yellow
        Me.partie10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie10.Location = New System.Drawing.Point(355, 704)
        Me.partie10.Name = "partie10"
        Me.partie10.Size = New System.Drawing.Size(40, 40)
        Me.partie10.TabIndex = 66
        Me.partie10.Text = "10"
        Me.partie10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie9
        '
        Me.partie9.BackColor = System.Drawing.Color.Yellow
        Me.partie9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie9.Location = New System.Drawing.Point(309, 704)
        Me.partie9.Name = "partie9"
        Me.partie9.Size = New System.Drawing.Size(40, 40)
        Me.partie9.TabIndex = 67
        Me.partie9.Text = "9"
        Me.partie9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie8
        '
        Me.partie8.BackColor = System.Drawing.Color.Yellow
        Me.partie8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie8.Location = New System.Drawing.Point(263, 704)
        Me.partie8.Name = "partie8"
        Me.partie8.Size = New System.Drawing.Size(40, 40)
        Me.partie8.TabIndex = 68
        Me.partie8.Text = "8"
        Me.partie8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie7
        '
        Me.partie7.BackColor = System.Drawing.Color.Yellow
        Me.partie7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie7.Location = New System.Drawing.Point(-1, 704)
        Me.partie7.Name = "partie7"
        Me.partie7.Size = New System.Drawing.Size(40, 40)
        Me.partie7.TabIndex = 70
        Me.partie7.Text = "7"
        Me.partie7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie6
        '
        Me.partie6.BackColor = System.Drawing.Color.Yellow
        Me.partie6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie6.Location = New System.Drawing.Point(126, 704)
        Me.partie6.Name = "partie6"
        Me.partie6.Size = New System.Drawing.Size(40, 40)
        Me.partie6.TabIndex = 71
        Me.partie6.Text = "6"
        Me.partie6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie5
        '
        Me.partie5.BackColor = System.Drawing.Color.Yellow
        Me.partie5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie5.Location = New System.Drawing.Point(80, 704)
        Me.partie5.Name = "partie5"
        Me.partie5.Size = New System.Drawing.Size(40, 40)
        Me.partie5.TabIndex = 72
        Me.partie5.Text = "5"
        Me.partie5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie4
        '
        Me.partie4.BackColor = System.Drawing.Color.Yellow
        Me.partie4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie4.Location = New System.Drawing.Point(45, 704)
        Me.partie4.Name = "partie4"
        Me.partie4.Size = New System.Drawing.Size(40, 40)
        Me.partie4.TabIndex = 73
        Me.partie4.Text = "4"
        Me.partie4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie3
        '
        Me.partie3.BackColor = System.Drawing.Color.Yellow
        Me.partie3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie3.Location = New System.Drawing.Point(171, 704)
        Me.partie3.Name = "partie3"
        Me.partie3.Size = New System.Drawing.Size(40, 40)
        Me.partie3.TabIndex = 74
        Me.partie3.Text = "3"
        Me.partie3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie2
        '
        Me.partie2.BackColor = System.Drawing.Color.Yellow
        Me.partie2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie2.Location = New System.Drawing.Point(217, 704)
        Me.partie2.Name = "partie2"
        Me.partie2.Size = New System.Drawing.Size(40, 40)
        Me.partie2.TabIndex = 75
        Me.partie2.Text = "2"
        Me.partie2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie13
        '
        Me.partie13.BackColor = System.Drawing.Color.Yellow
        Me.partie13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie13.Location = New System.Drawing.Point(493, 704)
        Me.partie13.Name = "partie13"
        Me.partie13.Size = New System.Drawing.Size(40, 40)
        Me.partie13.TabIndex = 79
        Me.partie13.Text = "13"
        Me.partie13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie1
        '
        Me.partie1.BackColor = System.Drawing.Color.Lime
        Me.partie1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie1.Location = New System.Drawing.Point(3, 3)
        Me.partie1.Name = "partie1"
        Me.partie1.Size = New System.Drawing.Size(40, 40)
        Me.partie1.TabIndex = 80
        Me.partie1.Text = "1"
        Me.partie1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie19
        '
        Me.partie19.BackColor = System.Drawing.Color.Yellow
        Me.partie19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie19.Location = New System.Drawing.Point(757, 704)
        Me.partie19.Name = "partie19"
        Me.partie19.Size = New System.Drawing.Size(40, 40)
        Me.partie19.TabIndex = 92
        Me.partie19.Text = "19"
        Me.partie19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie18
        '
        Me.partie18.BackColor = System.Drawing.Color.Yellow
        Me.partie18.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie18.Location = New System.Drawing.Point(711, 704)
        Me.partie18.Name = "partie18"
        Me.partie18.Size = New System.Drawing.Size(40, 40)
        Me.partie18.TabIndex = 91
        Me.partie18.Text = "18"
        Me.partie18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie15
        '
        Me.partie15.BackColor = System.Drawing.Color.Yellow
        Me.partie15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie15.Location = New System.Drawing.Point(585, 704)
        Me.partie15.Name = "partie15"
        Me.partie15.Size = New System.Drawing.Size(40, 40)
        Me.partie15.TabIndex = 90
        Me.partie15.Text = "15"
        Me.partie15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie16
        '
        Me.partie16.BackColor = System.Drawing.Color.Yellow
        Me.partie16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie16.Location = New System.Drawing.Point(619, 704)
        Me.partie16.Name = "partie16"
        Me.partie16.Size = New System.Drawing.Size(40, 40)
        Me.partie16.TabIndex = 89
        Me.partie16.Text = "16"
        Me.partie16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie17
        '
        Me.partie17.BackColor = System.Drawing.Color.Yellow
        Me.partie17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie17.Location = New System.Drawing.Point(666, 704)
        Me.partie17.Name = "partie17"
        Me.partie17.Size = New System.Drawing.Size(40, 40)
        Me.partie17.TabIndex = 88
        Me.partie17.Text = "17"
        Me.partie17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie14
        '
        Me.partie14.BackColor = System.Drawing.Color.Yellow
        Me.partie14.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie14.Location = New System.Drawing.Point(539, 704)
        Me.partie14.Name = "partie14"
        Me.partie14.Size = New System.Drawing.Size(40, 40)
        Me.partie14.TabIndex = 87
        Me.partie14.Text = "14"
        Me.partie14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'partie20
        '
        Me.partie20.BackColor = System.Drawing.Color.Yellow
        Me.partie20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partie20.Location = New System.Drawing.Point(803, 704)
        Me.partie20.Name = "partie20"
        Me.partie20.Size = New System.Drawing.Size(40, 40)
        Me.partie20.TabIndex = 86
        Me.partie20.Text = "20"
        Me.partie20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaLabel2
        '
        Me.GunaLabel2.BackColor = System.Drawing.Color.Yellow
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Red
        Me.GunaLabel2.Location = New System.Drawing.Point(1159, 65)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(103, 27)
        Me.GunaLabel2.TabIndex = 94
        Me.GunaLabel2.Text = "HighScore : "
        Me.GunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pointRougeABouffer
        '
        Me.pointRougeABouffer.BackColor = System.Drawing.Color.Red
        Me.pointRougeABouffer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointRougeABouffer.Location = New System.Drawing.Point(16, 16)
        Me.pointRougeABouffer.Name = "pointRougeABouffer"
        Me.pointRougeABouffer.Size = New System.Drawing.Size(10, 10)
        Me.pointRougeABouffer.TabIndex = 95
        Me.pointRougeABouffer.Text = "1"
        Me.pointRougeABouffer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'highScore2Joueur
        '
        Me.highScore2Joueur.BackColor = System.Drawing.Color.Yellow
        Me.highScore2Joueur.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.highScore2Joueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.highScore2Joueur.Location = New System.Drawing.Point(1165, 89)
        Me.highScore2Joueur.Name = "highScore2Joueur"
        Me.highScore2Joueur.Size = New System.Drawing.Size(158, 23)
        Me.highScore2Joueur.TabIndex = 96
        Me.highScore2Joueur.Text = "2000"
        Me.highScore2Joueur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bouttonPause
        '
        Me.bouttonPause.AutoSize = True
        Me.bouttonPause.BackColor = System.Drawing.Color.LawnGreen
        Me.bouttonPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bouttonPause.Location = New System.Drawing.Point(1169, 116)
        Me.bouttonPause.Name = "bouttonPause"
        Me.bouttonPause.Size = New System.Drawing.Size(63, 24)
        Me.bouttonPause.TabIndex = 97
        Me.bouttonPause.Text = "Pause"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(1354, 733)
        Me.Controls.Add(Me.bouttonPause)
        Me.Controls.Add(Me.highScore2Joueur)
        Me.Controls.Add(Me.pointRougeABouffer)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.partie19)
        Me.Controls.Add(Me.partie18)
        Me.Controls.Add(Me.partie15)
        Me.Controls.Add(Me.partie16)
        Me.Controls.Add(Me.partie17)
        Me.Controls.Add(Me.partie14)
        Me.Controls.Add(Me.partie20)
        Me.Controls.Add(Me.partie1)
        Me.Controls.Add(Me.partie13)
        Me.Controls.Add(Me.partie2)
        Me.Controls.Add(Me.partie3)
        Me.Controls.Add(Me.partie4)
        Me.Controls.Add(Me.partie5)
        Me.Controls.Add(Me.partie6)
        Me.Controls.Add(Me.partie7)
        Me.Controls.Add(Me.partie8)
        Me.Controls.Add(Me.partie9)
        Me.Controls.Add(Me.partie10)
        Me.Controls.Add(Me.partie11)
        Me.Controls.Add(Me.partie12)
        Me.Controls.Add(Me.statutDuPointRouge)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.limiteRouge4)
        Me.Controls.Add(Me.limiteRouge2)
        Me.Controls.Add(Me.limiteRouge3)
        Me.Controls.Add(Me.limiteRouge1)
        Me.Controls.Add(Me.toucherLesBords)
        Me.Controls.Add(Me.change)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Snake"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents change As Guna.UI.WinForms.GunaLabel
    Friend WithEvents timerDeplacementDroite_TeteDuSerpent As Timer
    Friend WithEvents timerDeplacementHaut_teteDuSerpent As Timer
    Friend WithEvents timerDeplacementGauche_teteDuSerpent As Timer
    Friend WithEvents timerDeplacementBas_teteDuSerpent As Timer
    Friend WithEvents toucherLesBords As Guna.UI.WinForms.GunaLabel
    Friend WithEvents limiteRouge4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents limiteRouge2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents limiteRouge3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents limiteRouge1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents statutDuPointRouge As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie17 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents partie20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pointRougeABouffer As Guna.UI.WinForms.GunaLabel
    Friend WithEvents highScore2Joueur As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bouttonPause As Label
End Class
