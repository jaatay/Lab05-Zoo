using System;

namespace Lab05Zoo
{
	public class Vampire : VoidLivingAnimal
	{

		public override string Diet { get; set; } = "Blood. Preferrably high in iron content.";
		public override string MethodOfMovement { get; set; } = "Walk, fly, teleport.";
		public override int LestatFactor { get => base.LestatFactor; set => base.LestatFactor = value; }
		public bool AllergicToSun = true;
		public override bool HasConsciousThought()
		{
			return true;
		}
	}
}