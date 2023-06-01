namespace PACMAN_2218
{
    partial class Form2
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
            this.high_score_text_label = new System.Windows.Forms.Label();
            this.high_score_counter_label = new System.Windows.Forms.Label();
            this.Movement = new System.Windows.Forms.Timer(this.components);
            this.Countdown = new System.Windows.Forms.Timer(this.components);
            this.time_left_counter_label = new System.Windows.Forms.Label();
            this.time_left_text_label = new System.Windows.Forms.Label();
            this.mute_image = new System.Windows.Forms.PictureBox();
            this.strawberry_image = new System.Windows.Forms.PictureBox();
            this.pacman_image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawberry_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman_image)).BeginInit();
            this.SuspendLayout();
            // 
            // high_score_text_label
            // 
            this.high_score_text_label.AutoSize = true;
            this.high_score_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.high_score_text_label.ForeColor = System.Drawing.Color.White;
            this.high_score_text_label.Location = new System.Drawing.Point(69, 18);
            this.high_score_text_label.Name = "high_score_text_label";
            this.high_score_text_label.Size = new System.Drawing.Size(83, 29);
            this.high_score_text_label.TabIndex = 2;
            this.high_score_text_label.Text = "Score:";
            this.high_score_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // high_score_counter_label
            // 
            this.high_score_counter_label.AutoSize = true;
            this.high_score_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.high_score_counter_label.ForeColor = System.Drawing.Color.White;
            this.high_score_counter_label.Location = new System.Drawing.Point(158, 21);
            this.high_score_counter_label.Name = "high_score_counter_label";
            this.high_score_counter_label.Size = new System.Drawing.Size(26, 29);
            this.high_score_counter_label.TabIndex = 3;
            this.high_score_counter_label.Text = "0";
            this.high_score_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Movement
            // 
            this.Movement.Enabled = true;
            this.Movement.Interval = 5000;
            this.Movement.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Countdown
            // 
            this.Countdown.Enabled = true;
            this.Countdown.Interval = 1000;
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // time_left_counter_label
            // 
            this.time_left_counter_label.AutoSize = true;
            this.time_left_counter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.time_left_counter_label.ForeColor = System.Drawing.Color.White;
            this.time_left_counter_label.Location = new System.Drawing.Point(105, 63);
            this.time_left_counter_label.Name = "time_left_counter_label";
            this.time_left_counter_label.Size = new System.Drawing.Size(34, 25);
            this.time_left_counter_label.TabIndex = 4;
            this.time_left_counter_label.Text = "60";
            this.time_left_counter_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time_left_text_label
            // 
            this.time_left_text_label.AutoSize = true;
            this.time_left_text_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.time_left_text_label.ForeColor = System.Drawing.Color.White;
            this.time_left_text_label.Location = new System.Drawing.Point(7, 63);
            this.time_left_text_label.Name = "time_left_text_label";
            this.time_left_text_label.Size = new System.Drawing.Size(92, 25);
            this.time_left_text_label.TabIndex = 5;
            this.time_left_text_label.Text = "Time left:";
            this.time_left_text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mute_image
            // 
            this.mute_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute_image.Image = global::PACMAN_2218.Properties.Resources.no_sound;
            this.mute_image.Location = new System.Drawing.Point(12, 21);
            this.mute_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mute_image.Name = "mute_image";
            this.mute_image.Size = new System.Drawing.Size(35, 26);
            this.mute_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute_image.TabIndex = 19;
            this.mute_image.TabStop = false;
            this.mute_image.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // strawberry_image
            // 
            this.strawberry_image.Image = global::PACMAN_2218.Properties.Resources.strawberry;
            this.strawberry_image.Location = new System.Drawing.Point(587, 133);
            this.strawberry_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strawberry_image.Name = "strawberry_image";
            this.strawberry_image.Size = new System.Drawing.Size(33, 34);
            this.strawberry_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.strawberry_image.TabIndex = 1;
            this.strawberry_image.TabStop = false;
            // 
            // pacman_image
            // 
            this.pacman_image.Image = global::PACMAN_2218.Properties.Resources.PACMAN_RIGHT1;
            this.pacman_image.Location = new System.Drawing.Point(423, 124);
            this.pacman_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pacman_image.Name = "pacman_image";
            this.pacman_image.Size = new System.Drawing.Size(53, 57);
            this.pacman_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman_image.TabIndex = 0;
            this.pacman_image.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 21;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(763, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mute_image);
            this.Controls.Add(this.time_left_text_label);
            this.Controls.Add(this.time_left_counter_label);
            this.Controls.Add(this.high_score_counter_label);
            this.Controls.Add(this.high_score_text_label);
            this.Controls.Add(this.strawberry_image);
            this.Controls.Add(this.pacman_image);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Screen";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strawberry_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pacman_image;
        private System.Windows.Forms.PictureBox strawberry_image;
        private System.Windows.Forms.Label high_score_text_label;
        private System.Windows.Forms.Label high_score_counter_label;
        private System.Windows.Forms.Timer Movement;
        private System.Windows.Forms.Timer Countdown;
        private System.Windows.Forms.Label time_left_counter_label;
        private System.Windows.Forms.Label time_left_text_label;
        private System.Windows.Forms.PictureBox mute_image;
        private System.Windows.Forms.Label label1;
    }
}