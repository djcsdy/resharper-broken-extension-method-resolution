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

			var cherrywoodHatstands = room.CherrywoodHatstands;
			cherrywoodHatstands.DoFengShui(); // ReSharper reports an error on this line.
			room.Tablecloths.DoFengShui();
		}
	}
}
