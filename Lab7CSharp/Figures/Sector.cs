using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab7CSharp.Figures
{
	internal class Sector : IFigure
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Size { get; set; }
		public int Id { get; set; }
		public Color PenColor { get; set; }
		public Sector() { }
		public Sector(int x, int y, int size, int id, Color penColor)
		{
			X = x;
			Y = y;
			Size = size;
			Id = id;
			PenColor = penColor;
		}
		public void draw(Graphics graphics)
		{
			graphics.DrawArc(new Pen(PenColor), X, Y, Size, Size, 0, 90);
			int value = Size / 2;
			graphics.DrawLine(new Pen(PenColor), X + value, Y + value, X + value * 2, Y + value);
			graphics.DrawLine(new Pen(PenColor), X + value, Y + value, X + value, Y + value * 2);
		}
	}
}
