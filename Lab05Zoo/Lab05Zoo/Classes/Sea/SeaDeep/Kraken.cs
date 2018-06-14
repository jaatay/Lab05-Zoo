using System;

namespace Lab05Zoo
{
	public class Kraken : DeepSeaAnimal, IRunFromPredators
	{
		public override string Diet { get; set; } = "Shrimp and volanic rock";

		public override string IntroSound()
		{
			return "MooooooInTheWater";
		}

		public string TheFirstFiveSeconds(string input)
		{
			input = "You might be surprised to learn I don't consider myself a predator.";
			return input;
		}
	}
}