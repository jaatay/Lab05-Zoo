using System;

namespace Lab05Zoo
{
	public abstract class LandAnimalWithLegs : LandAnimal
	{
		/// <summary>
		/// public override of movement class from LandAnimal
		/// </summary>
		public override string MethodOfMovement { get; set; } = "Legs 'n stuff.";

	}
}