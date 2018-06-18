using System;

namespace Lab05Zoo {
public class Human : CoastalSeaAnimal, IRunFromPredators, IEatPrey
{
		/// <summary>
		/// string override of diet property
		/// </summary>
		public override string Diet { get; set; } = "Cheesy Poofs";

		/// <summary>
		/// string override of depth property
		/// </summary>
		public override int Depth { get => base.Depth; set => base.Depth = 5; }
		public bool LivingThingsAreTasty { get; set; } = true;

		/// <summary>
		/// string of inhereted math method
		/// </summary>
		/// <returns>humans cannot do math</returns>
		public override string CanDoMath()
		{
			return "Hurr Durr nah tho";
		}

		/// <summary>
		/// intro sound
		/// </summary>
		/// <returns>string of sound</returns>
		public override string IntroSound()
		{
			return "Greetings, I am a mortal.";
		}

		/// <summary>
		/// prey interface
		/// </summary>
		/// <param name="input">input string of human response to being hunted</param>
		/// <returns>input string</returns>
		public string TheFirstFiveSeconds(string input)
		{
			return input;
		}
	}
}