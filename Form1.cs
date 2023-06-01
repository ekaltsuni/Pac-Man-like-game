using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using static PACMAN_2218.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PACMAN_2218
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer("sounds\\pacman_beginning.wav");
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Play();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            /* custom parameters for beginner level: interval, form_size_X, form_size_Y,
               pacman_size_X, pacman_size_Y, strawb_size_X, strawb_size_Y) */
            Form2 f2 = new Form2(5000, 572, 472, 55, 61, 36, 39);
            f2.ShowDialog();
            this.Close();
        }

        private void advanced_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            /* custom parameters for advanced level: interval, form_size_X, form_size_Y,
              pacman_size_X, pacman_size_Y, strawb_size_X, strawb_size_Y) */
            Form2 f2 = new Form2(4000, 672, 572, 45, 51, 30, 33);
            f2.ShowDialog();
            this.Close();
        }

        private void save_username_button_Click(object sender, EventArgs e)
        {
            Global.username = username_text_box.Text;
            MessageBox.Show("Username saved!"); 
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Instructions f = new Form_Instructions();
            f.ShowDialog();
            this.Close();
        }

        private void username_text_box_TextChanged(object sender, EventArgs e)
        {
            username_text_box.MaxLength = 14;
        }
    }
}
