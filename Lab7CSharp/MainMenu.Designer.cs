namespace Lab7CharpTest
{
    partial class MainMenu
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
            this.button_task3 = new System.Windows.Forms.Button();
            this.button_task2 = new System.Windows.Forms.Button();
            this.button_task1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_task3
            // 
            this.button_task3.Location = new System.Drawing.Point(313, 219);
            this.button_task3.Name = "button_task3";
            this.button_task3.Size = new System.Drawing.Size(150, 39);
            this.button_task3.TabIndex = 8;
            this.button_task3.Text = "Task3";
            this.button_task3.UseVisualStyleBackColor = true;
            this.button_task3.Click += new System.EventHandler(this.button_task3_Click_1);
            // 
            // button_task2
            // 
            this.button_task2.Location = new System.Drawing.Point(313, 174);
            this.button_task2.Name = "button_task2";
            this.button_task2.Size = new System.Drawing.Size(150, 39);
            this.button_task2.TabIndex = 7;
            this.button_task2.Text = "Task2";
            this.button_task2.UseVisualStyleBackColor = true;
            this.button_task2.Click += new System.EventHandler(this.button_task2_Click_1);
            // 
            // button_task1
            // 
            this.button_task1.Location = new System.Drawing.Point(313, 129);
            this.button_task1.Name = "button_task1";
            this.button_task1.Size = new System.Drawing.Size(150, 39);
            this.button_task1.TabIndex = 6;
            this.button_task1.Text = "Task1";
            this.button_task1.UseVisualStyleBackColor = true;
            this.button_task1.Click += new System.EventHandler(this.button_task1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_task3);
            this.Controls.Add(this.button_task2);
            this.Controls.Add(this.button_task1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_task3;
        private Button button_task2;
        private Button button_task1;
    }
}