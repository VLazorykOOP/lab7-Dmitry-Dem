using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab7CSharp.Figures
{
	internal class Star : IFigure
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Size { get; set; }
		public int Id { get; set; }
		public Color PenColor { get; set; }
		public Star() { }
		public Star(int x, int y, int size, int id, Color penColor)
		{
			X = x;
			Y = y;
			Size = size;
			Id = id;
			PenColor = penColor;
		}
		public void draw(Graphics graphics)
		{
			graphics.DrawLine(new Pen(PenColor), 51 *Size +X,  1  *Size +Y, 71 *Size +X, 51 *Size +Y);
			graphics.DrawLine(new Pen(PenColor), 71 *Size +X,  51 *Size +Y, 101*Size +X, 101*Size +Y);
			graphics.DrawLine(new Pen(PenColor), 101*Size +X, 101 *Size +Y, 51 *Size +X, 91 *Size +Y);
			graphics.DrawLine(new Pen(PenColor), 51 *Size +X, 91  *Size +Y, 1  *Size +X, 101*Size +Y);
			graphics.DrawLine(new Pen(PenColor), 1  *Size +X, 101 *Size +Y, 31 *Size +X, 51 *Size +Y);
			graphics.DrawLine(new Pen(PenColor), 31 *Size +X, 51  *Size +Y, 51 *Size +X, 1  *Size +Y);
		}
	}
}
