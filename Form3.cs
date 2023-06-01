using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PACMAN_2218.Program;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace PACMAN_2218
{

    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();

        }

        private void save_file_button_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory =  Application.StartupPath +"\\textfiles";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                results_rich_text_box.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("File saved at " + saveFileDialog1.FileName);
            }
        }
        private void play_again_button_form3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            username_results_label.Text = Global.username;
            results_rich_text_box.Text = Global.high_score;

        }
    }
}
