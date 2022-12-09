using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp.Figures
{
	internal class Rectangle : IFigure
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }
		public int Id { get; set; }
		public Color FillColor { get; set; }
		public Rectangle() { }
		public Rectangle(int x, int y, int width, int height, int id, Color fillColor)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
			Id = id;
			FillColor = fillColor;
		}
		public void draw(Graphics graphics)
		{
			graphics.FillRectangle(new SolidBrush(FillColor), new System.Drawing.Rectangle(X, Y, Width, Height));
		}
	}
}
