using System;

namespace Lab05Zoo
{
	public class Zombie : VoidUndeadAnimal
	{

		public override string Diet { get; set; } = "I eat brains!";
		public override string MethodOfMovement { get; set; } = "Shuffling walk.";

		public override string IntroSound()
		{
			return "..*unintelligible grunting*...";
		}
	}
}