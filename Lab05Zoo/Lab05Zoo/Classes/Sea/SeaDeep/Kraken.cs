using System;

namespace Lab05Zoo
{
	public class Kraken : DeepSeaAnimal
	{
		public override string Diet { get; set; } = "Shrimp and volanic rock";

		public override string IntroSound()
		{
			return "MooooooInTheWater";
		}
	}
}