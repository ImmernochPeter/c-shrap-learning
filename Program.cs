// See https://aka.ms/new-console-template for more information
namespace Planets
{
	struct Planet{
		public string name;
		public double volume; // as multiple of earth volume
		public double water; // water in %
		public double temprature; // in K
		public bool life;
		public bool atmosphere;
		public long humancount;
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello an welcome!");
			Console.WriteLine("Do you wan't to build a Planet? [y]es/[n]o");
			string input = Console.ReadLine();
			if (input == "n"){
			};
			var user_planet = new Planet{
				name = "",
				volume = 1.0,
				water = 100.0,
				temprature = 273.15,
				life = false,
				atmosphere = false,
				humancount = 2,
			};
			Console.WriteLine("How should I call your Planet?");
			input = console.ReadLine();
			user_planet.name = input;


		}
	}
}
