using System;

namespace Lab05Zoo
{
	public class Goat : Mammal, IRunFromPredators
	{
		/// <summary>
		/// override of inhereted string
		/// </summary>
		public override string Diet { get; set; } = "Grass.";

		/// <summary>
		/// sealed override concerning liters of grass eaten
		/// </summary>
		public sealed override int LitersOfGrassEaten { get; set; } = 50;

		/// <summary>
		/// a goat is a boring animal
		/// </summary>
		public bool IsABoringAnimal = true;

		/// <summary>
		/// intro sound of a goat
		/// </summary>
		/// <returns>string</returns>
		public override string IntroSound()
		{
			return "Baa goat like grass";
		}

		/// <summary>
		/// interface 
		/// </summary>
		/// <param name="input">no matter what is input, a goat still likes grass</param>
		/// <returns></returns>
		public string TheFirstFiveSeconds(string input)
		{
			input = "I still like grass.";
			return input;
		}
	}
}