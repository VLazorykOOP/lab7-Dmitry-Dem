namespace Lab7CharpTest
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
			this.button_task1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton_star = new System.Windows.Forms.RadioButton();
			this.radioButton_rectangle = new System.Windows.Forms.RadioButton();
			this.radioButton_sector = new System.Windows.Forms.RadioButton();
			this.radioButton_circle = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button_draw = new System.Windows.Forms.Button();
			this.button_add_figure = new System.Windows.Forms.Button();
			this.button_setColor = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_task1
			// 
			this.button_task1.Location = new System.Drawing.Point(12, 602);
			this.button_task1.Name = "button_task1";
			this.button_task1.Size = new System.Drawing.Size(400, 39);
			this.button_task1.TabIndex = 6;
			this.button_task1.Text = "Main Menu";
			this.button_task1.UseVisualStyleBackColor = true;
			this.button_task1.Click += new System.EventHandler(this.button_task1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.Location = new System.Drawing.Point(418, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(552, 629);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(263, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Кількість елементів малюнку";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(281, 54);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(61, 27);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton_star);
			this.panel1.Controls.Add(this.radioButton_rectangle);
			this.panel1.Controls.Add(this.radioButton_sector);
			this.panel1.Controls.Add(this.radioButton_circle);
			this.panel1.Location = new System.Drawing.Point(29, 100);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 142);
			this.panel1.TabIndex = 10;
			// 
			// radioButton_star
			// 
			this.radioButton_star.AutoSize = true;
			this.radioButton_star.Location = new System.Drawing.Point(21, 102);
			this.radioButton_star.Name = "radioButton_star";
			this.radioButton_star.Size = new System.Drawing.Size(66, 24);
			this.radioButton_star.TabIndex = 14;
			this.radioButton_star.TabStop = true;
			this.radioButton_star.Text = "Зірка";
			this.radioButton_star.UseVisualStyleBackColor = true;
			this.radioButton_star.CheckedChanged += new System.EventHandler(this.radioButton_star_CheckedChanged);
			// 
			// radioButton_rectangle
			// 
			this.radioButton_rectangle.AutoSize = true;
			this.radioButton_rectangle.Location = new System.Drawing.Point(21, 72);
			this.radioButton_rectangle.Name = "radioButton_rectangle";
			this.radioButton_rectangle.Size = new System.Drawing.Size(123, 24);
			this.radioButton_rectangle.TabIndex = 13;
			this.radioButton_rectangle.TabStop = true;
			this.radioButton_rectangle.Text = "Прямокутник";
			this.radioButton_rectangle.UseVisualStyleBackColor = true;
			this.radioButton_rectangle.CheckedChanged += new System.EventHandler(this.radioButton_rectangle_CheckedChanged);
			// 
			// radioButton_sector
			// 
			this.radioButton_sector.AutoSize = true;
			this.radioButton_sector.Location = new System.Drawing.Point(21, 42);
			this.radioButton_sector.Name = "radioButton_sector";
			this.radioButton_sector.Size = new System.Drawing.Size(78, 24);
			this.radioButton_sector.TabIndex = 12;
			this.radioButton_sector.TabStop = true;
			this.radioButton_sector.Text = "Сектор";
			this.radioButton_sector.UseVisualStyleBackColor = true;
			this.radioButton_sector.CheckedChanged += new System.EventHandler(this.radioButton_sector_CheckedChanged);
			// 
			// radioButton_circle
			// 
			this.radioButton_circle.AutoSize = true;
			this.radioButton_circle.Checked = true;
			this.radioButton_circle.Location = new System.Drawing.Point(21, 12);
			this.radioButton_circle.Name = "radioButton_circle";
			this.radioButton_circle.Size = new System.Drawing.Size(61, 24);
			this.radioButton_circle.TabIndex = 11;
			this.radioButton_circle.TabStop = true;
			this.radioButton_circle.Text = "Круг";
			this.radioButton_circle.UseVisualStyleBackColor = true;
			this.radioButton_circle.CheckedChanged += new System.EventHandler(this.radioButton_circle_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(205, 98);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(193, 144);
			this.panel2.TabIndex = 11;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(107, 46);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(69, 27);
			this.textBox3.TabIndex = 3;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox3.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Сторона 2";
			this.label3.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(107, 13);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(69, 27);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Радіус";
			// 
			// button_draw
			// 
			this.button_draw.Location = new System.Drawing.Point(217, 557);
			this.button_draw.Name = "button_draw";
			this.button_draw.Size = new System.Drawing.Size(195, 39);
			this.button_draw.TabIndex = 12;
			this.button_draw.Text = "Намалювати";
			this.button_draw.UseVisualStyleBackColor = true;
			this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
			// 
			// button_add_figure
			// 
			this.button_add_figure.Location = new System.Drawing.Point(12, 557);
			this.button_add_figure.Name = "button_add_figure";
			this.button_add_figure.Size = new System.Drawing.Size(199, 39);
			this.button_add_figure.TabIndex = 13;
			this.button_add_figure.Text = "Додати фігуру";
			this.button_add_figure.UseVisualStyleBackColor = true;
			this.button_add_figure.Click += new System.EventHandler(this.button_add_figure_Click);
			// 
			// button_setColor
			// 
			this.button_setColor.Location = new System.Drawing.Point(29, 275);
			this.button_setColor.Name = "button_setColor";
			this.button_setColor.Size = new System.Drawing.Size(369, 46);
			this.button_setColor.TabIndex = 14;
			this.button_setColor.Text = "Колір";
			this.button_setColor.UseVisualStyleBackColor = true;
			this.button_setColor.Click += new System.EventHandler(this.button_setColor_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(982, 653);
			this.Controls.Add(this.button_setColor);
			this.Controls.Add(this.button_add_figure);
			this.Controls.Add(this.button_draw);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button_task1);
			this.Name = "Form3";
			this.Text = "Task3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Button button_task1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel1;
		private RadioButton radioButton_circle;
		private Panel panel2;
		private Button button_draw;
		private Button button_add_figure;
		private RadioButton radioButton_star;
		private RadioButton radioButton_rectangle;
		private RadioButton radioButton_sector;
		private TextBox textBox2;
		private Label label2;
		private Button button_setColor;
		private TextBox textBox3;
		private Label label3;
		private ColorDialog colorDialog1;
	}
}