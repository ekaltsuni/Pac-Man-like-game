namespace PACMAN_2218
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
            this.beginner_button = new System.Windows.Forms.Button();
            this.play_prompt_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advanced_button = new System.Windows.Forms.Button();
            this.mode_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_text_box = new System.Windows.Forms.TextBox();
            this.save_username_button = new System.Windows.Forms.Button();
            this.mute_image = new System.Windows.Forms.PictureBox();
            this.pacman_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // beginner_button
            // 
            this.beginner_button.BackColor = System.Drawing.Color.Yellow;
            this.beginner_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.beginner_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.beginner_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginner_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.beginner_button.Location = new System.Drawing.Point(304, 466);
            this.beginner_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.beginner_button.Name = "beginner_button";
            this.beginner_button.Size = new System.Drawing.Size(165, 47);
            this.beginner_button.TabIndex = 7;
            this.beginner_button.Text = "Beginner";
            this.beginner_button.UseVisualStyleBackColor = false;
            this.beginner_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // play_prompt_label
            // 
            this.play_prompt_label.AutoSize = true;
            this.play_prompt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.play_prompt_label.ForeColor = System.Drawing.Color.Yellow;
            this.play_prompt_label.Location = new System.Drawing.Point(261, 222);
            this.play_prompt_label.Name = "play_prompt_label";
            this.play_prompt_label.Size = new System.Drawing.Size(206, 32);
            this.play_prompt_label.TabIndex = 8;
            this.play_prompt_label.Text = "Ready to Play?";
            this.play_prompt_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(763, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // advanced_button
            // 
            this.advanced_button.BackColor = System.Drawing.Color.Yellow;
            this.advanced_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.advanced_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.advanced_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.advanced_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.advanced_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.advanced_button.Location = new System.Drawing.Point(493, 466);
            this.advanced_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.advanced_button.Name = "advanced_button";
            this.advanced_button.Size = new System.Drawing.Size(165, 47);
            this.advanced_button.TabIndex = 11;
            this.advanced_button.Text = "Advanced";
            this.advanced_button.UseVisualStyleBackColor = false;
            this.advanced_button.Click += new System.EventHandler(this.advanced_button_Click);
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mode_label.ForeColor = System.Drawing.Color.Yellow;
            this.mode_label.Location = new System.Drawing.Point(75, 474);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(190, 29);
            this.mode_label.TabIndex = 13;
            this.mode_label.Text = "Choose a mode:";
            this.mode_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username_label.ForeColor = System.Drawing.Color.Yellow;
            this.username_label.Location = new System.Drawing.Point(244, 314);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(247, 29);
            this.username_label.TabIndex = 14;
            this.username_label.Text = "Enter your  username:";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_text_box
            // 
            this.username_text_box.BackColor = System.Drawing.SystemColors.Info;
            this.username_text_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username_text_box.Location = new System.Drawing.Point(201, 370);
            this.username_text_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_text_box.Name = "username_text_box";
            this.username_text_box.Size = new System.Drawing.Size(273, 28);
            this.username_text_box.TabIndex = 15;
            this.username_text_box.TextChanged += new System.EventHandler(this.username_text_box_TextChanged);
            // 
            // save_username_button
            // 
            this.save_username_button.BackColor = System.Drawing.Color.Yellow;
            this.save_username_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.save_username_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.save_username_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_username_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.save_username_button.Location = new System.Drawing.Point(493, 370);
            this.save_username_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save_username_button.Name = "save_username_button";
            this.save_username_button.Size = new System.Drawing.Size(111, 30);
            this.save_username_button.TabIndex = 18;
            this.save_username_button.Text = "Save";
            this.save_username_button.UseVisualStyleBackColor = false;
            this.save_username_button.Click += new System.EventHandler(this.save_username_button_Click);
            // 
            // mute_image
            // 
            this.mute_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mute_image.Image = global::PACMAN_2218.Properties.Resources.no_sound;
            this.mute_image.Location = new System.Drawing.Point(693, 42);
            this.mute_image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mute_image.Name = "mute_image";
            this.mute_image.Size = new System.Drawing.Size(35, 26);
            this.mute_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute_image.TabIndex = 17;
            this.mute_image.TabStop = false;
            this.mute_image.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pacman_logo
            // 
            this.pacman_logo.Image = global::PACMAN_2218.Properties.Resources.pacman_logo;
            this.pacman_logo.Location = new System.Drawing.Point(181, 98);
            this.pacman_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pacman_logo.Name = "pacman_logo";
            this.pacman_logo.Size = new System.Drawing.Size(377, 95);
            this.pacman_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pacman_logo.TabIndex = 9;
            this.pacman_logo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(763, 581);
            this.Controls.Add(this.save_username_button);
            this.Controls.Add(this.mute_image);
            this.Controls.Add(this.username_text_box);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.mode_label);
            this.Controls.Add(this.advanced_button);
            this.Controls.Add(this.pacman_logo);
            this.Controls.Add(this.play_prompt_label);
            this.Controls.Add(this.beginner_button);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mute_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacman_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beginner_button;
        private System.Windows.Forms.Label play_prompt_label;
        private System.Windows.Forms.PictureBox pacman_logo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button advanced_button;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_text_box;
        private System.Windows.Forms.PictureBox mute_image;
        private System.Windows.Forms.Button save_username_button;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}

