using System;

namespace Lab05Zoo
{
	public class Vampire : VoidLivingAnimal, IEatPrey
	{
		/// <summary>
		/// diet string override
		/// </summary>
		public override string Diet { get; set; } = "Blood. Preferrably high in iron content.";

		/// <summary>
		/// method of movement override
		/// </summary>
		public override string MethodOfMovement { get; set; } = "Walk, fly, teleport.";

		/// <summary>
		/// letstat factor override, unique to vampires
		/// </summary>
		public override int LestatFactor { get => base.LestatFactor; set => base.LestatFactor = value; }

		/// <summary>
		/// predator interface
		/// </summary>
		public bool LivingThingsAreTasty { get; set; } = true;

		/// <summary>
		/// boolean declaring vampire allergies
		/// </summary>
		public bool AllergicToSun = true;

		/// <summary>
		/// override of inhereted property regarding void animals
		/// </summary>
		/// <returns></returns>
		public override bool HasConsciousThought()
		{
			return true;
		}

		/// <summary>
		/// intro sound
		/// </summary>
		/// <returns>string of vampire response</returns>
		public override string IntroSound()
		{
			return "Queen and/or King of the Damned";
		}
	}
}