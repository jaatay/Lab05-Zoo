using System;

namespace Lab05Zoo
{
	public class Zombie : VoidUndeadAnimal, IEatPrey
	{

		public override string Diet { get; set; } = "I eat brains!";
		public override string MethodOfMovement { get; set; } = "Shuffling walk.";
		public bool LivingThingsAreTasty { get; set; } = true;

		public override string IntroSound()
		{
			return "..*unintelligible grunting*...";
		}
	}
}