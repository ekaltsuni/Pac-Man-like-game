namespace PACMAN_2218
{
    partial class Form3
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
            this.results_rich_text_box = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.save_file_button = new System.Windows.Forms.Button();
            this.username_results_label = new System.Windows.Forms.Label();
            this.play_again_button_form3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // results_rich_text_box
            // 
            this.results_rich_text_box.BackColor = System.Drawing.Color.Yellow;
            this.results_rich_text_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results_rich_text_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.results_rich_text_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.results_rich_text_box.Location = new System.Drawing.Point(218, 131);
            this.results_rich_text_box.Margin = new System.Windows.Forms.Padding(4);
            this.results_rich_text_box.Name = "results_rich_text_box";
            this.results_rich_text_box.ReadOnly = true;
            this.results_rich_text_box.Size = new System.Drawing.Size(203, 90);
            this.results_rich_text_box.TabIndex = 0;
            this.results_rich_text_box.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files|*.txt";
            // 
            // save_file_button
            // 
            this.save_file_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_file_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.save_file_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(166)))));
            this.save_file_button.Location = new System.Drawing.Point(68, 249);
            this.save_file_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(171, 39);
            this.save_file_button.TabIndex = 1;
            this.save_file_button.Text = "Save to file";
            this.save_file_button.UseVisualStyleBackColor = true;
            this.save_file_button.Click += new System.EventHandler(this.save_file_button_Click);
            // 
            // username_results_label
            // 
            this.username_results_label.AutoSize = true;
            this.username_results_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.username_results_label.Location = new System.Drawing.Point(20, 134);
            this.username_results_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_results_label.Name = "username_results_label";
            this.username_results_label.Size = new System.Drawing.Size(94, 29);
            this.username_results_label.TabIndex = 2;
            this.username_results_label.Text = "(empty)";
            // 
            // play_again_button_form3
            // 
            this.play_again_button_form3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play_again_button_form3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.play_again_button_form3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(166)))));
            this.play_again_button_form3.Location = new System.Drawing.Point(258, 249);
            this.play_again_button_form3.Margin = new System.Windows.Forms.Padding(4);
            this.play_again_button_form3.Name = "play_again_button_form3";
            this.play_again_button_form3.Size = new System.Drawing.Size(171, 39);
            this.play_again_button_form3.TabIndex = 3;
            this.play_again_button_form3.Text = "Play Again";
            this.play_again_button_form3.UseVisualStyleBackColor = true;
            this.play_again_button_form3.Click += new System.EventHandler(this.play_again_button_form3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PACMAN_2218.Properties.Resources.strawberry;
            this.pictureBox2.Location = new System.Drawing.Point(160, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PACMAN_2218.Properties.Resources.strawberry;
            this.pictureBox1.Location = new System.Drawing.Point(289, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PACMAN_2218.Properties.Resources.strawberry;
            this.pictureBox4.Location = new System.Drawing.Point(226, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(155, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your High Score";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(502, 409);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.play_again_button_form3);
            this.Controls.Add(this.username_results_label);
            this.Controls.Add(this.save_file_button);
            this.Controls.Add(this.results_rich_text_box);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "High Score";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox results_rich_text_box;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button save_file_button;
        private System.Windows.Forms.Label username_results_label;
        private System.Windows.Forms.Button play_again_button_form3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}