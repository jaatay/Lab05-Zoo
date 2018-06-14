using System;

namespace Lab05Zoo
{
	public abstract class Mammal : LandAnimalWithLegs
	{
		/// <summary>
		/// the derived class doesn't care whether it exists or not
		/// </summary>
		public virtual bool NotExtinctDontCare { get; set; } = true;

		/// <summary>
		/// the amount of grass eaten by mammals, integer representing liters
		/// </summary>
		public virtual int LitersOfGrassEaten { get; set; } = 5;
	}
}