using System;

namespace Lab05Zoo
{
	public class Tyranosaur : Dinosaur, IEatPrey
	{
		public override string Diet { get; set; } = "Other creatures. Sometimes license plates.";
		public bool LivingThingsAreTasty { get; set; } = true;

		public override string IntroSound()
		{
			return "Raawwr! WHERE ARE MY ARMS!";
		}
	}
}