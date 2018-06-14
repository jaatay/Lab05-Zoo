using System;

namespace Lab05Zoo {

public class JellyFish : CoastalSeaAnimal, IEatPrey
{

		/// <summary>
		/// public override of depth property
		/// </summary>
		public override int Depth { get => base.Depth; set => base.Depth = 50; }

		/// <summary>
		/// public override of diet property
		/// </summary>
		public override string Diet { get; set; } = "Tears";

		/// <summary>
		/// override of boolean, a jellyfish does not breath air
		/// </summary>
		public override bool BreathesAir { get; set; } = false;

		/// <summary>
		/// predator interface
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = true;

		/// <summary>
		/// override of inhereted math method
		/// </summary>
		/// <returns>returns string indicating jellyfish are quite smart</returns>
		public override string CanDoMath()
		{
			return "Quantum mechanics are boring.";
		}

		/// <summary>
		/// intro sound
		/// </summary>
		/// <returns>string of jellyfish intro sound</returns>
		public override string IntroSound()
		{
			return "I am Jelly...iJelly...I = gel-e";
		}
	}
}