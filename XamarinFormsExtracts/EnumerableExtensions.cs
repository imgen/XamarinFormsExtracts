using System;
using System.Collections.Generic;

namespace XamarinFormsExtracts
{
	internal static class EnumerableExtensions
	{
		internal static IEnumerable<T> Append<T>(this IEnumerable<T> enumerable, T item)
		{
			foreach (T x in enumerable)
				yield return x;

			yield return item;
		}

		internal static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
		{
			foreach (T item in enumeration)
			{
				action(item);
			}
		}

		internal static int IndexOf<T>(this IEnumerable<T> enumerable, T item)
		{
			if (enumerable == null)
				throw new ArgumentNullException("enumerable");

			var i = 0;
			foreach (T element in enumerable)
			{
				if (Equals(element, item))
					return i;

				i++;
			}

			return -1;
		}

		internal static int IndexOf<T>(this IEnumerable<T> enumerable, Func<T, bool> predicate)
		{
			var i = 0;
			foreach (T element in enumerable)
			{
				if (predicate(element))
					return i;

				i++;
			}

			return -1;
		}

		internal static IEnumerable<T> Prepend<T>(this IEnumerable<T> enumerable, T item)
		{
			yield return item;

			foreach (T x in enumerable)
				yield return x;
		}
	}
}