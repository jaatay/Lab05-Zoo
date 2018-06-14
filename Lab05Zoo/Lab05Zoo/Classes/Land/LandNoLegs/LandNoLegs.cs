using System;

namespace Lab05Zoo
{
	public abstract class LandAnimalWithNoLegs : LandAnimal
	{
		/// <summary>
		/// virtual boolean concerning non-legged animal wish fulfillment
		/// </summary>
		public virtual bool WishesHadLegs { get; set; } = true;
	}
}