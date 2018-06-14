using System;

namespace Lab05Zoo
{
	public class Tyranosaur : Dinosaur, IEatPrey
	{
		/// <summary>
		/// string override of diet property
		/// </summary>
		public override string Diet { get; set; } = "Other creatures. Sometimes license plates.";

		/// <summary>
		/// predator interface property
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = true;

		/// <summary>
		/// string of animal sound
		/// </summary>
		/// <returns>returns T-Rex response</returns>
		public override string IntroSound()
		{
			return "Raawwr! WHERE ARE MY ARMS!";
		}
	}
}