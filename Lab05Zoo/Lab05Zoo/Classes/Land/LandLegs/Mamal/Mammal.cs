using System;

namespace Lab05Zoo
{
	public abstract class Mammal : LandAnimalWithLegs
	{
		public virtual bool NotExtinctDontCare { get; set; } = true;

		public virtual int LitersOfGrassEaten { get; set; } = 5;
	}
}