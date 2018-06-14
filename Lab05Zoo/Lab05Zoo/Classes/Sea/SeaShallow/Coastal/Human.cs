using System;

namespace Lab05Zoo {
public class Human : CoastalSeaAnimal, IRunFromPredators
{

		public override string Diet { get; set; } = "Cheesy Poofs";

		public override int Depth { get => base.Depth; set => base.Depth = 5; }

		public override string CanDoMath()
		{
			return "Hurr Durr nah tho";
		}

		public override string IntroSound()
		{
			return "Greetings, I am a mortal.";
		}

		public string TheFirstFiveSeconds(string input)
		{
			return input;
		}
	}
}