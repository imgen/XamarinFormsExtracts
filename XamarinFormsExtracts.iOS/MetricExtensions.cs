using System;
using PointF = CoreGraphics.CGPoint;
using RectangleF = CoreGraphics.CGRect;
using SizeF = CoreGraphics.CGSize;

namespace XamarinFormsExtracts.iOS
{
	public static class PointExtensions
	{
		public static Point ToPoint(this PointF point)
		{
			return new Point(point.X, point.Y);
		}
	}

	public static class SizeExtensions
	{
		public static SizeF ToSizeF(this Size size)
		{
			return new SizeF((float)size.Width, (float)size.Height);
		}
	}

	public static class RectangleExtensions
	{
		public static Rectangle ToRectangle(this RectangleF rect)
		{
			return new Rectangle(rect.X, rect.Y, rect.Width, rect.Height);
		}

		public static RectangleF ToRectangleF(this Rectangle rect)
		{
			return new RectangleF((nfloat)rect.X, (nfloat)rect.Y, (nfloat)rect.Width, (nfloat)rect.Height);
		}
	}
}
