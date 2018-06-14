using System;

namespace Lab05Zoo
{
	public class Kraken : DeepSeaAnimal, IRunFromPredators
	{

		/// <summary>
		/// string override of diet property
		/// </summary>
		public override string Diet { get; set; } = "Shrimp and volanic rock";

		/// <summary>
		/// string of kraken sound
		/// </summary>
		/// <returns>returns kraken response</returns>
		public override string IntroSound()
		{
			return "MooooooInTheWater";
		}

		/// <summary>
		/// prey interface
		/// </summary>
		/// <param name="input">string input of how a kraken finds the first five seconds of being hunted. Likely involves laughing.</param>
		/// <returns>string input</returns>
		public string TheFirstFiveSeconds(string input)
		{
			
			return input;
		}
	}
}