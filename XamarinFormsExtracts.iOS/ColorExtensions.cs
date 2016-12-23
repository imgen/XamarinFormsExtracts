using System;
using CoreGraphics;
using UIKit;

namespace XamarinFormsExtracts.iOS
{
	public static class ColorExtensions
	{
		internal static readonly UIColor Black = UIColor.Black;
		internal static readonly UIColor SeventyPercentGrey = new UIColor(0.7f, 0.7f, 0.7f, 1);

		public static CGColor ToCGColor(this Color color)
		{
			return new CGColor((float)color.R, (float)color.G, (float)color.B, (float)color.A);
		}

		public static Color ToColor(this UIColor color)
		{
			nfloat red;
			nfloat green;
			nfloat blue;
			nfloat alpha;
			color.GetRGBA(out red, out green, out blue, out alpha);
			return new Color(red, green, blue, alpha);
		}

		public static UIColor ToUIColor(this Color color)
		{
			return new UIColor((float)color.R, (float)color.G, (float)color.B, (float)color.A);
		}

		public static UIColor ToUIColor(this Color color, Color defaultColor)
		{
			if (color.IsDefault)
				return defaultColor.ToUIColor();

			return color.ToUIColor();
		}

		public static UIColor ToUIColor(this Color color, UIColor defaultColor)
		{
			if (color.IsDefault)
				return defaultColor;

			return color.ToUIColor();
		}
	}
}
