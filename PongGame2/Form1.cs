using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PongGame2
{

    public partial class Form1 : Form
    {
        SoundPlayer paddleTouch = new SoundPlayer(PongGame2.Properties.Resources.zvuk1);
        SoundPlayer bounce = new SoundPlayer(PongGame2.Properties.Resources.zapsplat_cartoon_twang_bounce_boing_spring_53049__online_audio_converter_com_);
        SoundPlayer hitball = new SoundPlayer(PongGame2.Properties.Resources.Comedy_or_cartoon_accent___crash_broken___breaking_glass_or_breaking_cup___dropping_an_object__online_audio_converter_com_);
        SoundPlayer gameoversound = new SoundPlayer(PongGame2.Properties.Resources.Sped_Up_Oriental_Game_Over_2__online_audio_converter_com_);
        SoundPlayer startGame = new SoundPlayer(PongGame2.Properties.Resources.Comedy_or_cartoon_accent___drum___snare_beat___military_or_marching_snare__online_audio_converter_com_);

        private  static readonly  Color[] colors = new[] { Color.MediumVioletRed, Color.DarkBlue, Color.SpringGreen, Color.PaleGoldenrod };
        private  static readonly Random random = new Random();
        public static Color randomColor=colors[random.Next(0, colors.Length)];
        public int horizontal_speed = 2;
        public int vertical_speed = 2;
        public int score = 0;
        int row=3;
        int col=3;
        
        public PictureBox[,] blocks;
       
        public Form1()
        {
            generateBlocks();
            InitializeComponent();
            setup();
        }


        /*void   proveri(PictureBox block)
        {
            
                foreach (Control x in this.Controls)
                {
                
                    if (x is PictureBox && x.Tag.ToString() == "blocks")
                    {
                    
                        if (block.Bounds.IntersectsWith(x.Bounds))
                        {
                         
                            block.Hide();
                            block.Dispose();
                            this.Controls.Remove(block);
                            generateNewBlock();
                        }
                    }
                else
                {
                   
                    this.Controls.Add(block);
                    block.BringToFront();
                }
            
               
                }
                }  */



/*
        private   bool Delay(int millisecond)
        {

            System.Diagnostics.Stopwatch sw = new Stopwatch();
            sw.Start();
            bool flag = false;
            while (!flag)
            {
                if (sw.ElapsedMilliseconds > millisecond)
                {
                    flag = true;
                }
            }
            sw.Stop();
            return true;

        }
        */


        private async  Task  generateNewBlock(int top, int left)
        {
            int height = 70;
            int width = 140;
            PictureBox block = new PictureBox();
            block.Tag = "blocks";
            
            block.BorderStyle = BorderStyle.Fixed3D;
            block.BackColor = colors[random.Next(0, colors.Length)];
            block.Height = height;
            block.Width = width;
            block.Top = top;
            block.Left = left+random.Next(-120,70);
            await Task.Delay(2000);
            this.Controls.Add(block);
            block.BringToFront();
           
        }

        private void generateBlocks()
        {   
            int height = 90;
            int width = 180;
            blocks = new PictureBox[row, col];

            for (int x = 0; x < row;x++)
            {
                for(int y = 0; y < col; y++)
                {
                    blocks[x, y] = new PictureBox();
                    blocks[x, y].Height = height;
                    blocks[x, y].Width = width;
                    
                    blocks[x, y].Top = (70+(width+50 ))+ (x * (height + 4));
                    blocks[x, y].Left = 70 + (y * (width * 4))+random.Next(width,width+100);
                    
             
                    blocks[x, y].Tag = "blocks";
                    blocks[x, y].BorderStyle = BorderStyle.Fixed3D;
                    blocks[x,y].BackColor= colors[random.Next(0, colors.Length)];
                    this.Controls.Add(blocks[x, y]);
                    blocks[x, y].BringToFront();
                }
            }
        }

        private void GoFullscreen(bool fullscreen)
        {
            Cursor.Hide();
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        private void setup()
        {
            scores_lbl.Hide();
            scores_lbl.Text = "0";
            timer1.Enabled = true;
            startGame.Play();
            score = 0;
            Score.SendToBack();
            gameover.Hide();
            ball.BringToFront();
           
            GoFullscreen(true);

            ball.Top = (Height / 2)+70;
            ball.Left = Width / 2;
            

            playground.BackColor = Color.Black;
            ball.BackColor = colors[random.Next(colors.Length)];
            player.BackColor = ball.BackColor;
            

            player.Top = playground.Bottom - (playground.Bottom / 30);
          
        
        }    
        private void igra()
        {
            
            player.Left = Cursor.Position.X - (player.Width / 2);
            ball.Left += horizontal_speed;
            ball.Top += vertical_speed;
            

            if (ball.Bounds.IntersectsWith(player.Bounds)==true&& player.BackColor==ball.BackColor)
            {
                score += 1;
                scores_lbl.Text = score.ToString();
                Score.Text ="Score: " + scores_lbl.Text;
                paddleTouch.Play();
                vertical_speed += 1;
                horizontal_speed += 1;
                vertical_speed = -vertical_speed;
                
                
                  
                ball.BackColor = colors[random.Next(0, colors.Length)];
               
            }
        
             foreach (Control x in Controls)
            {   
                if(x is PictureBox &&   x.Tag.ToString() == "blocks")
                { 
                    if (ball.Bounds.IntersectsWith(x.Bounds) == true)
                    {
                        if (x.BackColor == ball.BackColor)
                        {
                            
                            hitball.Play();
                            score += 3;
                            scores_lbl.Text = score.ToString();
                            Score.Text = "Score: " + scores_lbl.Text;
                            generateNewBlock(x.Top,x.Left);
                            x.Dispose();

                           // generateNewBlock();


                        }
                        else
                        {   
                            bounce.Play();
                            vertical_speed = -vertical_speed;
                            ball.BackColor = x.BackColor;
                        }
                    }
                }
            }
           
            

            if (ball.Left <= playground.Left || ball.Right >= playground.Right)
            {
                horizontal_speed = -horizontal_speed;
            }
           
            if (ball.Top <= playground.Top)
            {
                vertical_speed = -vertical_speed;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                gameOver();
                
            }
           

        }
        

        private async Task gameOver()
        {   
            gameoversound.Play();
            gameover.Left = (playground.Width / 2) - (gameover.Width / 2);
            gameover.Top = (playground.Height / 2) - (gameover.Height / 2);
            timer1.Enabled = false;
            gameover.AppendText(String.Format("\tYour score: {0} \n\tGame Over \n\tPress R to Restart\n\tPress Esc to Exit", scores_lbl.Text));
            gameover.BringToFront();
            await Task.Delay(2000);
            foreach (Control  x  in Controls  )
            {
                
                if (x is PictureBox)
                        x.Hide();
            }
         
            
            gameover.Show();
            scores_lbl.Hide();
            Score.Hide();
            helppanellabel.Hide();
            ball.Hide();
            player.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            igra();
            
      
          
        }
      
        int i = 0;
        
        public bool paused { get; private set; }
        public bool help { get; set; }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.R)
            {    
           
                Application.Restart();
            }

            if (e.KeyCode == Keys.E)
            {
                i++;

                if (i > colors.Count() - 1)
                {
                    i = 0;
                }
                player.BackColor = colors[i];
            }

            if(e.KeyCode == Keys.P)
            {    
               
                if(paused == false && ball.Bottom  < 300 )
                {
                        
                       
                        timer1.Stop();
                        paused = true;
                        
                    
                   
                }
                else
                {
                    timer1.Start();
                    paused = false;
                }
                
            }
            
            if(e.KeyCode  == Keys.X)
            {
                if (help)
                {
                    helppanellabel.Show();
                    help = false;
                    
                }
                else
                {
                    helppanellabel.Hide();
                    help = true;
                   

                }
               
            }
          
           
        }

    }
}

