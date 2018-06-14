using System;

namespace Lab05Zoo {

public class JellyFish : CoastalSeaAnimal, IEatPrey
{
		public override int Depth { get => base.Depth; set => base.Depth = 50; }

		public override string Diet { get; set; } = "Tears";

		public override bool BreathesAir { get; set; } = false;
		public bool LivingThingsAreTasty { get; set; } = true;

		public override string CanDoMath()
		{
			return "Quantum mechanics are boring.";
		}

		public override string IntroSound()
		{
			return "I am Jelly...iJelly...I = gel-e";
		}
	}
}