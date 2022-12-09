using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7CSharp.Figures
{
	internal class Circle : IFigure
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Radius { get; set; }
		public int Id { get; set; }
		public Color PenColor { get; set; }
		public Circle() { }
		public Circle(int x, int y, int radius, int id, Color penColor)
		{
			X = x;
			Y = y;
			Radius = radius;
			Id = id;
			PenColor = penColor;
		}
		public void draw(Graphics graphics)
		{
			graphics.DrawEllipse(new Pen(PenColor), new System.Drawing.Rectangle(X, Y, 10 * Radius, 10 * Radius));
		}
	}
}

