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
			Console.WriteLine("How hot should it be there? (in K)");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			user_planet.temprature = Double.Parse(input);
			Console.WriteLine("Should life be possible there? [y]es/[n]o");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			if (input == "y"){
				user_planet.life = true;
			}
			else
			{
				user_planet.life = false;	
			};
			Console.WriteLine("Should your planet have an atmosphere? [y]es/[n]o");
			input = Console.ReadLine();
			if (input is null){
				Environment.Exit(1);
			};
			if (input == "y"){
				user_planet.atmosphere = true;
			}
			else
			{
				user_planet.atmosphere = false;
			};
			if (user_planet.life){
				Console.WriteLine("How many humans should live there?");
				input = Console.ReadLine();
				if (input is null){
					Environment.Exit(1);
				};
				user_planet.humancount = long.Parse(input);
			}
			Console.WriteLine("===============================");
			Console.WriteLine("Your planet:");
			Console.WriteLine("Name: " + user_planet.name);
			Console.WriteLine("Volume: " + user_planet.volume + "x times Earth");
			Console.WriteLine("Water: " + user_planet.water + "%");
			Console.WriteLine("Temprature: " + user_planet.temprature + "K");
			Console.WriteLine("Life: " + user_planet.life);
			Console.WriteLine("Atmosphere: " + user_planet.atmosphere);
			Console.WriteLine("Humans: " + user_planet.humancount);
			Console.WriteLine("===============================");
			Environment.Exit(0);


		}
	}
}
