using System.Collections.Generic;
using Furniture;

namespace BrokenExtensionMethodResolution
{
	class Program
	{
		static void Main()
		{
			var room = new Room
			           	{
			           		CherrywoodHatstands = new List<CherrywoodHatstand>(),
			           		Tablecloths = new List<Tablecloth>()
			           	};

			List<CherrywoodHatstand> cherrywoodHatstands = room.CherrywoodHatstands;
			cherrywoodHatstands.DoFengShui(); // ReSharper is happy with this line now.
			room.Tablecloths.DoFengShui();
		}
	}
}
