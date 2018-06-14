using System;

namespace Lab05Zoo
{
	public class BlackWidow : Spiders, IEatPrey
	{
		/// <summary>
		/// string override of diet property
		/// </summary>
		public override string Diet { get; set; } = "Anything I can kill with poison.";

		/// <summary>
		/// string override of movement property
		/// </summary>
		public override string MethodOfMovement { get; set; } = "I don't move, I wait.";

		/// <summary>
		/// boolean returning base property of wishing it had legs
		/// </summary>
		public override bool WishesHadLegs { get => base.WishesHadLegs; set => base.WishesHadLegs = value;}

		/// <summary>
		/// predator interface. A black widow doesn't enjoy its food since its injected with poison
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = false;

		/// <summary>
		/// string override of sound property
		/// </summary>
		/// <returns>returns black widow response</returns>
		public override string IntroSound()
		{
			return "I wound you with a kiss.";
		}
	}
}