using System;

namespace Lab05Zoo
{
	public abstract class Dinosaur : LandAnimalWithLegs
	{
		public virtual bool IsExtinct { get; set; } = true;

		
	}
}