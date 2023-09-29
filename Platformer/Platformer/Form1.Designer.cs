namespace Platformer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainPlatform = new PictureBox();
            FinalPlatform = new PictureBox();
            horizontalPlatform = new PictureBox();
            MovingPlatform1 = new PictureBox();
            BigPlatform = new PictureBox();
            verticalPlatform = new PictureBox();
            pictureBox1 = new PictureBox();
            enemyOne = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            coin = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            player = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MainPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FinalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horizontalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MovingPlatform1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BigPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MainPlatform
            // 
            MainPlatform.BackColor = Color.SaddleBrown;
            MainPlatform.BackgroundImageLayout = ImageLayout.None;
            MainPlatform.Location = new Point(0, 606);
            MainPlatform.Name = "MainPlatform";
            MainPlatform.Size = new Size(289, 66);
            MainPlatform.TabIndex = 0;
            MainPlatform.TabStop = false;
            MainPlatform.Tag = "Platform";
            // 
            // FinalPlatform
            // 
            FinalPlatform.BackColor = Color.SaddleBrown;
            FinalPlatform.Location = new Point(954, 621);
            FinalPlatform.Name = "FinalPlatform";
            FinalPlatform.Size = new Size(147, 39);
            FinalPlatform.TabIndex = 1;
            FinalPlatform.TabStop = false;
            FinalPlatform.Tag = "Platform";
            // 
            // horizontalPlatform
            // 
            horizontalPlatform.BackColor = Color.SaddleBrown;
            horizontalPlatform.BackgroundImageLayout = ImageLayout.None;
            horizontalPlatform.Location = new Point(288, 506);
            horizontalPlatform.Name = "horizontalPlatform";
            horizontalPlatform.Size = new Size(176, 33);
            horizontalPlatform.TabIndex = 2;
            horizontalPlatform.TabStop = false;
            horizontalPlatform.Tag = "Platform";
            // 
            // MovingPlatform1
            // 
            MovingPlatform1.BackColor = Color.SaddleBrown;
            MovingPlatform1.BackgroundImageLayout = ImageLayout.None;
            MovingPlatform1.Location = new Point(54, 396);
            MovingPlatform1.Name = "MovingPlatform1";
            MovingPlatform1.Size = new Size(176, 33);
            MovingPlatform1.TabIndex = 3;
            MovingPlatform1.TabStop = false;
            MovingPlatform1.Tag = "Platform";
            // 
            // BigPlatform
            // 
            BigPlatform.BackColor = Color.SaddleBrown;
            BigPlatform.BackgroundImageLayout = ImageLayout.None;
            BigPlatform.Location = new Point(315, 293);
            BigPlatform.Name = "BigPlatform";
            BigPlatform.Size = new Size(400, 33);
            BigPlatform.TabIndex = 4;
            BigPlatform.TabStop = false;
            BigPlatform.Tag = "Platform";
            // 
            // verticalPlatform
            // 
            verticalPlatform.BackColor = Color.SaddleBrown;
            verticalPlatform.BackgroundImageLayout = ImageLayout.None;
            verticalPlatform.Location = new Point(787, 447);
            verticalPlatform.Name = "verticalPlatform";
            verticalPlatform.Size = new Size(69, 33);
            verticalPlatform.TabIndex = 5;
            verticalPlatform.TabStop = false;
            verticalPlatform.Tag = "Platform";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(969, 490);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 125);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "chest";
            // 
            // enemyOne
            // 
            enemyOne.BackColor = Color.Transparent;
            enemyOne.BackgroundImage = (Image)resources.GetObject("enemyOne.BackgroundImage");
            enemyOne.BackgroundImageLayout = ImageLayout.Stretch;
            enemyOne.Location = new Point(100, 345);
            enemyOne.Name = "enemyOne";
            enemyOne.Size = new Size(50, 50);
            enemyOne.TabIndex = 8;
            enemyOne.TabStop = false;
            enemyOne.Tag = "enemy";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.SaddleBrown;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Location = new Point(54, 211);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(176, 33);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "Platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.SaddleBrown;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Location = new Point(906, 174);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(205, 33);
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "Platform";
            // 
            // coin
            // 
            coin.BackColor = Color.Transparent;
            coin.BackgroundImage = (Image)resources.GetObject("coin.BackgroundImage");
            coin.BackgroundImageLayout = ImageLayout.Stretch;
            coin.Location = new Point(300, 455);
            coin.Name = "coin";
            coin.Size = new Size(76, 45);
            coin.TabIndex = 12;
            coin.TabStop = false;
            coin.Tag = "coin";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Transparent;
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(382, 455);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(76, 45);
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "coin";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Transparent;
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(100, 162);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(76, 45);
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.Transparent;
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(590, 236);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(76, 45);
            pictureBox10.TabIndex = 15;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(1010, 123);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(76, 45);
            pictureBox11.TabIndex = 16;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "coin";
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(0, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(220, 66);
            txtScore.TabIndex = 17;
            txtScore.Tag = "txtScore";
            txtScore.Text = "Score : 0\r\n";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.BackgroundImage = (Image)resources.GetObject("player.BackgroundImage");
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.InitialImage = null;
            player.Location = new Point(31, 506);
            player.Margin = new Padding(0);
            player.Name = "player";
            player.Size = new Size(75, 97);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 18;
            player.TabStop = false;
            player.Tag = "character";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(482, 241);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "enemy";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(954, 120);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "enemy";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 755);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(enemyOne);
            Controls.Add(FinalPlatform);
            Controls.Add(pictureBox5);
            Controls.Add(verticalPlatform);
            Controls.Add(BigPlatform);
            Controls.Add(horizontalPlatform);
            Controls.Add(pictureBox4);
            Controls.Add(MovingPlatform1);
            Controls.Add(MainPlatform);
            Controls.Add(player);
            Controls.Add(txtScore);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(coin);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)MainPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)FinalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)horizontalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)MovingPlatform1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BigPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private PictureBox MainPlatform;
        private PictureBox FinalPlatform;
        private PictureBox horizontalPlatform;
        private PictureBox MovingPlatform1;
        private PictureBox BigPlatform;
        private PictureBox verticalPlatform;
        private PictureBox pictureBox1;
        private PictureBox enemyOne;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox coin;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox player;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}