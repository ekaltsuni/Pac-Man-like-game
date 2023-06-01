using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PACMAN_2218.Program;

namespace PACMAN_2218
{
    
    public partial class Form2 : Form
    {
        Random r;
        double distance = 30;
        int score;
        SoundPlayer playerEatFruit = new SoundPlayer("sounds\\pacman_eatfruit.wav");
        SoundPlayer playerChomp = new SoundPlayer("sounds\\pacman_chomp.wav");
        int seconds = 60;
        public Form2(int movement_interval, int form_size_X, int form_size_Y, 
            int pacman_size_X, int pacman_size_Y, int strawb_size_X, int strawb_size_Y)
        {
            InitializeComponent();
            this.Movement.Interval = movement_interval;
            this.ClientSize = new System.Drawing.Size(form_size_X, form_size_Y);
            this.pacman_image.Size = new System.Drawing.Size(pacman_size_X, pacman_size_Y);
            this.strawberry_image.Size = new System.Drawing.Size(strawb_size_X, strawb_size_Y);
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            r = new Random();
           
        }

        // Check how mute sound pictureBox affects playerChomp and playerEatFruit
        private bool pictureBox3_WasClicked = false;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3_WasClicked = true;
        }
        private void checkSoundClickChomp()
        {
            if (pictureBox3_WasClicked == true)
            {
                playerChomp.Stop();
            }
            else
            {
                playerChomp.Play();
            }
        }
        private void checkSoundClickEatFruit()
        {
            if (pictureBox3_WasClicked == true)
            {
                playerEatFruit.Stop();
            }
            else
            {
                playerEatFruit.Play();
            }
        }

        // KeyDown activity in relation to images' locations and sound effects
        private void Form2_KeyDown_1(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode.ToString() == "Right")
            {
                pacman_image.ImageLocation = "images/PACMAN_RIGHT.png";
                pacman_image.Location = new Point(pacman_image.Location.X + 20, pacman_image.Location.Y); ;
                checkSoundClickChomp();
            }
            else if (e.KeyCode.ToString() == "Left")
            {
                pacman_image.ImageLocation = "images/PACMAN_LEFT.png";
                pacman_image.Location = new Point(pacman_image.Location.X - 20, pacman_image.Location.Y); ;
                checkSoundClickChomp();
            }
            else if (e.KeyCode.ToString() == "Up")
            {
                pacman_image.ImageLocation = "images/PACMAN_UP.png";
                pacman_image.Location = new Point(pacman_image.Location.X, pacman_image.Location.Y - 20); ;
                checkSoundClickChomp();
            }
            else if (e.KeyCode.ToString() == "Down")
            {
                pacman_image.ImageLocation = "images/PACMAN_DOWN.png";
                pacman_image.Location = new Point(pacman_image.Location.X, pacman_image.Location.Y + 20); ;
                checkSoundClickChomp();
            }


            double pacmanX, pacmanY, foodX, foodY;
            pacmanX = pacman_image.Location.X + (pacman_image.Width / 2);
            pacmanY = pacman_image.Location.Y + (pacman_image.Height / 2);
            foodX = strawberry_image.Location.X + (strawberry_image.Width / 2);
            foodY = strawberry_image.Location.Y + (strawberry_image.Height / 2);
            double r = Math.Sqrt(Math.Pow(pacmanX - foodX, 2) + Math.Pow(pacmanY - foodY, 2));
            if (r < distance)
            {
                checkSoundClickEatFruit();
                score += 100;
                high_score_counter_label.Text = score.ToString();
                Global.high_score = high_score_counter_label.Text;
                timer1_Tick_1(this, null);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            strawberry_image.Location = new Point(r.Next(Width - strawberry_image.Width), r.Next(Height - strawberry_image.Height));
        }

        private void Countdown_Tick(object sender, EventArgs e)
        {   
            time_left_counter_label.Text = seconds.ToString();
            seconds--;
            if (seconds == -1)
            {
                Countdown.Stop();
                this.Hide();
                Form4 f4 = new Form4();
                f4.ShowDialog();
                this.Close();
            }
        }
    }
}
