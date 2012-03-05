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

			room.CherrywoodHatstands.DoFengShui(); // ReSharper reports an error on this line.
			room.Tablecloths.DoFengShui();
		}
	}
}
