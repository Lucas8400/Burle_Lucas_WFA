using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
        // Déclarations des variables pour les mouvements, la gravité, le score, etc.
        bool goLeft, goRight, jumping, isGameOver, goDown;
        int jumpSpeed = 10;
        int force = 12;
        int gravity = 5;
        int score = 0;
        int playerSpeed = 5;
        Point playerStartPosition;
        int horizontalPlatformSpeed = 5;
        int distanceToMove = 150;
        int horizontalPlatformDirection = 1;
        Point horizontalPlatformStart;

        // Le constructeur initialise le jeu
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            playerStartPosition = player.Location;
            horizontalPlatformStart = horizontalPlatform.Location;
        }

        // Gère les mouvements du jeu, les collisions, la gravité, etc.
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            // Si le jeu est terminé, sortez de cette fonction
            if (isGameOver) return;

            txtScore.Text = "Score: " + score;

            player.Top += gravity;
            horizontalPlatform.Left += horizontalPlatformSpeed * horizontalPlatformDirection;

            if (Math.Abs(horizontalPlatform.Left - horizontalPlatformStart.Left) >= distanceToMove)
            {
                horizontalPlatformDirection *= -1;
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                gravity = -jumpSpeed;
                force -= 1;
            }
            else
            {
                gravity = 5;
            }

            if (goDown)
            {
                player.Top += playerSpeed;
            }

            if (goLeft && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }

            if (goRight && player.Right < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            // Vérification des collisions avec les plateformes, pièces et ennemis
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null)
                {
                    if (x.Tag.ToString() == "Platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && !jumping && player.Bottom < x.Top + (x.Height / 2))
                        {
                            force = 12;
                            player.Top = x.Top - player.Height;
                            gravity = 0;
                        }
                    }

                    if (x.Tag.ToString() == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                        {
                            x.Visible = false;
                            score++;
                        }
                    }

                    if (x.Tag.ToString() == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOver();
                        }
                    }
                }
            }
        }

        // Détecte les touches pressées pour déplacer le joueur
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Space && !jumping) jumping = true;
            if (e.KeyCode == Keys.Down) goDown = true;
            if (e.KeyCode == Keys.R && isGameOver) RestartGame();
        }

        // Détecte les touches relâchées pour arrêter le mouvement du joueur
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }

        // Gère la fin du jeu lorsqu'un ennemi touche le joueur
        private void GameOver()
        {
            isGameOver = true;
            gameTimer.Stop();

            DialogResult result = MessageBox.Show("Vous avez été touché par un ennemi ! Voulez-vous rejouer ?", "Game Over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) RestartGame();
            else this.Close();
        }

        // Réinitialise le jeu après un game over
        private void RestartGame()
        {
            player.Location = playerStartPosition;
            score = 0;
            isGameOver = false;
            goLeft = goRight = goDown = jumping = false;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null)
                {
                    if (x.Tag.ToString() == "coin") x.Visible = true;
                    // Repositionnement des pièces et ennemis ici si nécessaire
                }
            }

            gameTimer.Start();
        }
    }
}
