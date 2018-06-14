using System;

namespace Lab05Zoo
{
	public class Snake : NotASpider, IEatPrey
	{
		/// <summary>
		/// a snake is not a spider
		/// </summary>
		public override bool DefinitelyNotASpider { get; set; } = true;

		/// <summary>
		/// string override of diet
		/// </summary>
		public override string Diet { get; set; } = "I eat mices.";

		/// <summary>
		/// string override of movement method
		/// </summary>
		public override string MethodOfMovement { get; set; } = "Slither";

		/// <summary>
		/// predator interface
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = true;

		/// <summary>
		/// sound override
		/// </summary>
		/// <returns>returns snake response</returns>
		public override string IntroSound()
		{
			return "Hissss";
		}
	}
}