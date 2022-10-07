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
			var input = Console.ReadLine();
			if (input == "n"){
				Environment.Exit(0);
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
			Console.WriteLine("How should I call your planet?");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			user_planet.name = input;
			Console.WriteLine("How big should your planet be?"); 
			Console.WriteLine("Please enter a number. (Multiple of earth Volume)");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			user_planet.volume = Double.Parse(input);
			Console.WriteLine("How much % of your Planet should be water?");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			user_planet.water = Double.Parse(input);
			




		}
	}
}
