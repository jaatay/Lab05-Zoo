using System;

namespace Lab05Zoo
{
	public class BlackWidow : Spiders, IEatPrey
	{

		public override string Diet { get; set; } = "Anything I can kill with poison.";
		public override string MethodOfMovement { get; set; } = "I don't move, I wait.";
		public override bool WishesHadLegs { get => base.WishesHadLegs; set => base.WishesHadLegs = value;}
		public bool LivingThingsAreTasty { get; set; } = false;

		public override string IntroSound()
		{
			return "I wound you with a kiss.";
		}
	}
}