namespace PongGame2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.gameover = new System.Windows.Forms.RichTextBox();
            this.helppanellabel = new System.Windows.Forms.Label();
            this.scores_lbl = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.helppanellabel);
            this.playground.Controls.Add(this.scores_lbl);
            this.playground.Controls.Add(this.Score);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.player);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameover.ForeColor = System.Drawing.Color.Gray;
            this.gameover.Location = new System.Drawing.Point(251, 168);
            this.gameover.Name = "gameover";
            this.gameover.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.gameover.Size = new System.Drawing.Size(353, 163);
            this.gameover.TabIndex = 13;
            this.gameover.Text = "";
            // 
            // helppanellabel
            // 
            this.helppanellabel.AutoSize = true;
            this.helppanellabel.BackColor = System.Drawing.Color.Transparent;
            this.helppanellabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.helppanellabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helppanellabel.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helppanellabel.ForeColor = System.Drawing.Color.Olive;
            this.helppanellabel.Location = new System.Drawing.Point(471, 95);
            this.helppanellabel.Name = "helppanellabel";
            this.helppanellabel.Padding = new System.Windows.Forms.Padding(30);
            this.helppanellabel.Size = new System.Drawing.Size(329, 245);
            this.helppanellabel.TabIndex = 12;
            this.helppanellabel.Text = "\"P\" - Pause\r\n\"R\"  -  Reset\r\n\"Esc\" -  Exit\r\n\"E\" - Change  Color\r\n\"X\" -  Hide ";
            this.helppanellabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // scores_lbl
            // 
            this.scores_lbl.AutoSize = true;
            this.scores_lbl.BackColor = System.Drawing.Color.Transparent;
            this.scores_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scores_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scores_lbl.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores_lbl.ForeColor = System.Drawing.Color.Gray;
            this.scores_lbl.Location = new System.Drawing.Point(0, 375);
            this.scores_lbl.Name = "scores_lbl";
            this.scores_lbl.Size = new System.Drawing.Size(0, 75);
            this.scores_lbl.TabIndex = 3;
            this.scores_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scores_lbl.Visible = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Dock = System.Windows.Forms.DockStyle.Top;
            this.Score.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Yellow;
            this.Score.Location = new System.Drawing.Point(0, 0);
            this.Score.Name = "Score";
            this.Score.Padding = new System.Windows.Forms.Padding(10);
            this.Score.Size = new System.Drawing.Size(257, 95);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.Location = new System.Drawing.Point(368, 264);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(55, 39);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Location = new System.Drawing.Point(298, 419);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(265, 19);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label scores_lbl;
        private System.Windows.Forms.Label helppanellabel;
        protected System.Windows.Forms.RichTextBox gameover;
    }
}

