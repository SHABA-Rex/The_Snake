<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FenetreDuBoxDuBouttonRecommencer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetreDuBoxDuBouttonRecommencer))
        Me.bouttonRecommencer = New Guna.UI.WinForms.GunaAdvenceTileButton()
        Me.Hs = New Guna.UI.WinForms.GunaLabel()
        Me.HighScoreJoueur = New Guna.UI.WinForms.GunaLabel()
        Me.Sc = New Guna.UI.WinForms.GunaLabel()
        Me.ScoreJoueur = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'bouttonRecommencer
        '
        Me.bouttonRecommencer.AnimationHoverSpeed = 0.07!
        Me.bouttonRecommencer.AnimationSpeed = 0.03!
        Me.bouttonRecommencer.BackColor = System.Drawing.Color.Transparent
        Me.bouttonRecommencer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bouttonRecommencer.BorderColor = System.Drawing.Color.Black
        Me.bouttonRecommencer.CheckedBaseColor = System.Drawing.Color.Gray
        Me.bouttonRecommencer.CheckedBorderColor = System.Drawing.Color.Black
        Me.bouttonRecommencer.CheckedForeColor = System.Drawing.Color.White
        Me.bouttonRecommencer.CheckedImage = CType(resources.GetObject("bouttonRecommencer.CheckedImage"), System.Drawing.Image)
        Me.bouttonRecommencer.CheckedLineColor = System.Drawing.Color.DimGray
        Me.bouttonRecommencer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bouttonRecommencer.FocusedColor = System.Drawing.Color.Empty
        Me.bouttonRecommencer.Font = New System.Drawing.Font("Segoe UI Light", 15.75!)
        Me.bouttonRecommencer.ForeColor = System.Drawing.Color.White
        Me.bouttonRecommencer.Image = CType(resources.GetObject("bouttonRecommencer.Image"), System.Drawing.Image)
        Me.bouttonRecommencer.ImageSize = New System.Drawing.Size(52, 52)
        Me.bouttonRecommencer.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bouttonRecommencer.Location = New System.Drawing.Point(9, 10)
        Me.bouttonRecommencer.Name = "bouttonRecommencer"
        Me.bouttonRecommencer.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bouttonRecommencer.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bouttonRecommencer.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bouttonRecommencer.OnHoverImage = Nothing
        Me.bouttonRecommencer.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bouttonRecommencer.OnPressedColor = System.Drawing.Color.Black
        Me.bouttonRecommencer.Radius = 25
        Me.bouttonRecommencer.Size = New System.Drawing.Size(222, 128)
        Me.bouttonRecommencer.TabIndex = 102
        Me.bouttonRecommencer.Text = "Recommencer"
        '
        'Hs
        '
        Me.Hs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hs.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hs.ForeColor = System.Drawing.Color.Red
        Me.Hs.Location = New System.Drawing.Point(259, 77)
        Me.Hs.Name = "Hs"
        Me.Hs.Size = New System.Drawing.Size(103, 28)
        Me.Hs.TabIndex = 100
        Me.Hs.Text = "HighScore : "
        Me.Hs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HighScoreJoueur
        '
        Me.HighScoreJoueur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.HighScoreJoueur.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HighScoreJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.HighScoreJoueur.Location = New System.Drawing.Point(267, 105)
        Me.HighScoreJoueur.Name = "HighScoreJoueur"
        Me.HighScoreJoueur.Size = New System.Drawing.Size(97, 24)
        Me.HighScoreJoueur.TabIndex = 101
        Me.HighScoreJoueur.Text = "500"
        Me.HighScoreJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Sc
        '
        Me.Sc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sc.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Sc.ForeColor = System.Drawing.Color.Red
        Me.Sc.Location = New System.Drawing.Point(261, 24)
        Me.Sc.Name = "Sc"
        Me.Sc.Size = New System.Drawing.Size(95, 26)
        Me.Sc.TabIndex = 98
        Me.Sc.Text = "Score : "
        '
        'ScoreJoueur
        '
        Me.ScoreJoueur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ScoreJoueur.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ScoreJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ScoreJoueur.Location = New System.Drawing.Point(261, 52)
        Me.ScoreJoueur.Name = "ScoreJoueur"
        Me.ScoreJoueur.Size = New System.Drawing.Size(88, 21)
        Me.ScoreJoueur.TabIndex = 99
        Me.ScoreJoueur.Text = "0000000"
        Me.ScoreJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FenetreDuBoxDuBouttonRecommencer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 151)
        Me.Controls.Add(Me.Hs)
        Me.Controls.Add(Me.bouttonRecommencer)
        Me.Controls.Add(Me.HighScoreJoueur)
        Me.Controls.Add(Me.Sc)
        Me.Controls.Add(Me.ScoreJoueur)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FenetreDuBoxDuBouttonRecommencer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FenetreDuBoxDuBouttonRecommencer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bouttonRecommencer As Guna.UI.WinForms.GunaAdvenceTileButton
    Friend WithEvents Hs As Guna.UI.WinForms.GunaLabel
    Friend WithEvents HighScoreJoueur As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Sc As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ScoreJoueur As Guna.UI.WinForms.GunaLabel
End Class
