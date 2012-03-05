using System.Collections.Generic;
using Furniture;

namespace BrokenExtensionMethodResolution
{
	static class TableclothFengShui
	{
		public static decimal DoFengShui(this IEnumerable<Tablecloth> tablecloths)
		{
			return 1m;
		}
	}
}
