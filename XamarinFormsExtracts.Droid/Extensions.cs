﻿using Android.Content.Res;
using Android.Views;

namespace XamarinFormsExtracts.Droid
{
	public static class Extensions
	{
		internal static IMenuItem FindMenuItemByNameOrIcon(this IMenu menu, string menuName, string iconName)
		{
			if (menu.Size() == 1)
				return menu.GetItem(0);

			for (var i = 0; i < menu.Size(); i++)
			{
				IMenuItem menuItem = menu.GetItem(i);
				if (menuItem.TitleFormatted != null && menuName == menuItem.TitleFormatted.ToString())
					return menuItem;

				if (!string.IsNullOrEmpty(iconName))
				{
					// TODO : search by iconName
				}
			}
			return null;
		}
	}
}