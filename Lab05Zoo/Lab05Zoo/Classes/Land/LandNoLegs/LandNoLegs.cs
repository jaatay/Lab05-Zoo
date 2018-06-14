using System;

namespace Lab05Zoo
{
	public abstract class LandAnimalWithNoLegs : LandAnimal
	{
		public virtual bool WishesHadLegs { get; set; } = true;
	}
}