using Lab7CharpTest.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CharpTest
{
    public enum Figure
	{
		Circle,
		Sector,
		Rectangle,
		Star
	}
	public partial class Form3 : Form
    {
        List<IFigure> figureList = new List<IFigure>();

        Figure figure = Figure.Circle;
		public Form3()
        {
            InitializeComponent();
        }
        private void button_task1_Click(object sender, EventArgs e)
        {
            MainMenu c = new MainMenu();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
		private void button_draw_Click(object sender, EventArgs e)
		{
            clearGraphics();

            foreach (var figure in figureList)
            {
                figure.draw(pictureBox1.CreateGraphics());
            }
		}
		private void button_add_figure_Click(object sender, EventArgs e)
		{
			var range = 20;
			var x = new Random().Next(range, 100);
			var y = new Random().Next(range, 100);

			switch (figure) 
			{ 
				case(Figure.Circle):
					figureList.Add(new Circle(x, y, Convert.ToInt32(textBox2.Text), figureList.Count + 1, button_setColor.BackColor));
					break; 
				
				case(Figure.Sector):
					figureList.Add(new Sector(x, y, Convert.ToInt32(textBox2.Text), figureList.Count + 1, button_setColor.BackColor));
					break;

				case(Figure.Rectangle):
					figureList.Add(new Figures.Rectangle(x, y, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), figureList.Count + 1, button_setColor.BackColor));
					break;

				case(Figure.Star):
					figureList.Add(new Star(x, y, Convert.ToInt32(textBox2.Text), figureList.Count + 1, button_setColor.BackColor));
					break;
			}

			textBox1.Text = (Convert.ToInt32(textBox1.Text) + 1).ToString();
		}
		private void radioButton_circle_CheckedChanged(object sender, EventArgs e)
		{
			figure = Figure.Circle;
            label2.Text = "Радіус";
			label3.Visible = false;
			textBox3.Visible = false;
		}
		private void radioButton_sector_CheckedChanged(object sender, EventArgs e)
		{
            figure = Figure.Sector;
			label2.Text = "Розмір";
			label3.Visible = false;
			textBox3.Visible = false;
		}
		private void radioButton_rectangle_CheckedChanged(object sender, EventArgs e)
		{
            figure = Figure.Rectangle;
			label2.Text = "Сторона 1";
			label3.Visible = true;
			textBox3.Visible = true;
		}
		private void radioButton_star_CheckedChanged(object sender, EventArgs e)
		{
            figure = Figure.Star;
			label2.Text = "Розмір";
			label3.Visible = false;
			textBox3.Visible = false;
		}
		private void button_setColor_Click(object sender, EventArgs e)
		{
			var col = colorDialog1.ShowDialog();
			if (col == DialogResult.OK)
			{
				button_setColor.BackColor = colorDialog1.Color;
				button_setColor.ForeColor = Color.White;
			}
		}
		private void clearGraphics()
        {
			pictureBox1.CreateGraphics().FillRectangle(new SolidBrush(Color.White), new System.Drawing.Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
		}
	}
}
