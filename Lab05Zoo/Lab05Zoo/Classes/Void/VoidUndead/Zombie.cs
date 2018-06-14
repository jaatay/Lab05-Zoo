using System;

namespace Lab05Zoo
{
	public class Zombie : VoidUndeadAnimal, IEatPrey
	{
		/// <summary>
		/// override of inhereted diet property
		/// </summary>
		public override string Diet { get; set; } = "I eat brains!";

		/// <summary>
		/// override of inhereted movement property
		/// </summary>
		public override string MethodOfMovement { get; set; } = "Shuffling walk.";

		/// <summary>
		/// predator interface
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = true;


		/// <summary>
		/// intro sound
		/// </summary>
		/// <returns>string of zombie sounds</returns>
		public override string IntroSound()
		{
			return "..*unintelligible grunting*...";
		}
	}
}