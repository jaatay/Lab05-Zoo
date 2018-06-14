using System;

namespace Lab05Zoo
{
	public class Tyranosaur : Dinosaur
	{
		public override string Diet { get; set; } = "Other creatures. Sometimes license plates.";

		public override string IntroSound()
		{
			return "Raawwr! WHERE ARE MY ARMS!";
		}
	}
}