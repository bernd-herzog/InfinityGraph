using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HLGraph
{
	public partial class ucGraph : UserControl
	{


		public ucGraph()
		{
			InitializeComponent();
		}



		protected override void OnPaint(PaintEventArgs e)
		{
			try
			{


				base.OnPaint(e);
				e.Graphics.Clear(Color.White);
				Pen pen = new Pen(Color.Black);

				for (int i = 0; i < this.Width; i++)
				{
					double x = ItoD(i, this.Width);
					//int iX = (int)Math.Floor(x);
					if (x == 0)
						continue;


					double y = (Math.Pow(-1, x) * x * x * x + x) / (x * x * x + 1);
					if (!double.IsNaN(y))
					{
						int j = DToI(y, this.Height);
						e.Graphics.DrawLine(pen, KarPToScreen(new Point(i, j)), KarPToScreen(new Point(i, 0)));
					}
				}

				//e.Graphics.DrawLine(pen, KarPToScreen(new Point(50, 50)), KarPToScreen(new Point(100, 100)));
			}
			catch
			{


			}
		}

		double ItoD(int i, int pb)
		{
			if (i < pb / 2)
			{
				return (double)i / (pb / 2);
			}
			else
			{
				double f = (double)(pb - i) / (pb / 2);
				if (f == 0)
					return pb;
				return 1 / f;
			}
		}

		int DToI(double d, int pb)
		{
			if (d < 1)
			{
				return (int)Math.Floor(d * pb / 2);
			}
			else
			{
				return (pb - (int)Math.Floor((1 / d) * (pb / 2)));
			}
		}

		Point KarPToScreen(Point p)
		{
			return new Point(p.X, this.Height - p.Y);
		}
	}
}
