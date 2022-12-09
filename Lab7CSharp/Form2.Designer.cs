namespace Lab7CharpTest
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
            this.button_task1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_open_img = new System.Windows.Forms.Button();
            this.button_save_img = new System.Windows.Forms.Button();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_task1
            // 
            this.button_task1.Location = new System.Drawing.Point(36, 38);
            this.button_task1.Name = "button_task1";
            this.button_task1.Size = new System.Drawing.Size(150, 39);
            this.button_task1.TabIndex = 6;
            this.button_task1.Text = "Main Menu";
            this.button_task1.UseVisualStyleBackColor = true;
            this.button_task1.Click += new System.EventHandler(this.button_task1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(192, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 319);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(540, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(332, 319);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button_open_img
            // 
            this.button_open_img.Location = new System.Drawing.Point(248, 38);
            this.button_open_img.Name = "button_open_img";
            this.button_open_img.Size = new System.Drawing.Size(229, 39);
            this.button_open_img.TabIndex = 11;
            this.button_open_img.Text = "Open img";
            this.button_open_img.UseVisualStyleBackColor = true;
            this.button_open_img.Click += new System.EventHandler(this.button_open_img_Click);
            // 
            // button_save_img
            // 
            this.button_save_img.Location = new System.Drawing.Point(599, 38);
            this.button_save_img.Name = "button_save_img";
            this.button_save_img.Size = new System.Drawing.Size(229, 39);
            this.button_save_img.TabIndex = 12;
            this.button_save_img.Text = "Save img";
            this.button_save_img.UseVisualStyleBackColor = true;
            this.button_save_img.Click += new System.EventHandler(this.button_save_img_Click);
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Checked = true;
            this.radioButton_red.Location = new System.Drawing.Point(540, 478);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(56, 24);
            this.radioButton_red.TabIndex = 13;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "Red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            this.radioButton_red.CheckedChanged += new System.EventHandler(this.radioButton_red_CheckedChanged);
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(674, 478);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(69, 24);
            this.radioButton_green.TabIndex = 14;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "Green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            this.radioButton_green.CheckedChanged += new System.EventHandler(this.radioButton_green_CheckedChanged);
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(813, 478);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(59, 24);
            this.radioButton_blue.TabIndex = 15;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "Blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            this.radioButton_blue.CheckedChanged += new System.EventHandler(this.radioButton_blue_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trackBar1.Location = new System.Drawing.Point(540, 425);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(332, 56);
            this.trackBar1.TabIndex = 17;
            // 
            // button_set
            // 
            this.button_set.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_set.Location = new System.Drawing.Point(540, 519);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(332, 41);
            this.button_set.TabIndex = 18;
            this.button_set.Text = "Set";
            this.button_set.UseVisualStyleBackColor = false;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.radioButton_blue);
            this.Controls.Add(this.radioButton_green);
            this.Controls.Add(this.radioButton_red);
            this.Controls.Add(this.button_save_img);
            this.Controls.Add(this.button_open_img);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_task1);
            this.Name = "Form2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_task1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button_open_img;
        private Button button_save_img;
        private RadioButton radioButton_red;
        private RadioButton radioButton_green;
        private RadioButton radioButton_blue;
        private TrackBar trackBar1;
        private Button button_set;
    }
}