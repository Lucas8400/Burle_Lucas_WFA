using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {
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

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            playerStartPosition = player.Location;
            horizontalPlatformStart = horizontalPlatform.Location; // Ajustez selon le nom de votre plateforme
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            if (isGameOver)
                return;

            txtScore.Text = "Score: " + score;

            player.Top += gravity;
            horizontalPlatform.Left += horizontalPlatformSpeed * horizontalPlatformDirection;

            // Inverser la direction si la plateforme a atteint la distance maximale
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

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null)
                {
                    if (x.Tag.ToString() == "Platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && !jumping && player.Bottom < x.Top + (x.Height / 2))
                        {
                            force = 12; // R�initialiser la force lorsque le joueur touche une plateforme
                            player.Top = x.Top - player.Height;
                            gravity = 0;
                        }
                    }

                    if (x.Tag.ToString() == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible)
                        {
                            x.Visible = false; // Cachez la pi�ce
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

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }

            if (e.KeyCode == Keys.R && isGameOver)
            {
                RestartGame();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameOver()
        {
            isGameOver = true;
            gameTimer.Stop(); // Stoppez le timer pour �viter que le jeu ne continue en arri�re-plan

            DialogResult result = MessageBox.Show("Vous avez �t� touch� par un ennemi ! Voulez-vous rejouer ?", "Game Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close(); // Fermez la fen�tre du jeu si le joueur choisit de ne pas rejouer
            }
        }


        private void RestartGame()
        {
            // R�initialisez la position du joueur
            player.Location = playerStartPosition; // supposez que playerStartPosition est la position initiale du joueur

            // R�initialisez le score
            score = 0;

            // R�initialisez l'�tat du jeu
            isGameOver = false;

            // R�initialisez les mouvements du joueur
            goLeft = goRight = goDown = jumping = false;

            // Remettez toutes les pi�ces et les ennemis � leurs positions originales et rendez-les visibles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag != null)
                {
                    if (x.Tag.ToString() == "coin")
                    {
                        x.Visible = true; // Rendez les pi�ces visibles
                                          // x.Location = ...; // Remettez les pi�ces � leurs positions originales si n�cessaire
                    }
                    else if (x.Tag.ToString() == "enemy")
                    {
                        // x.Location = ...; // Remettez les ennemis � leurs positions originales si n�cessaire
                    }
                }
            }

            // Red�marrez le timer
            gameTimer.Start();
        }


    }
}
