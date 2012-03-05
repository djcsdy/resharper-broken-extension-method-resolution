using System.Collections.Generic;
using Furniture;

namespace BrokenExtensionMethodResolution
{
	static class HatstandFengShui
	{
		public static decimal DoFengShui(this IEnumerable<Hatstand> hatstands)
		{
			return 0m; 
		}
	}
}
