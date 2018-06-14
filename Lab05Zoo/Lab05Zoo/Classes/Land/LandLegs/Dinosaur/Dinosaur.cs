using System;

namespace Lab05Zoo
{
	public abstract class Dinosaur : LandAnimalWithLegs
	{
		/// <summary>
		/// boolean statement which has been true for 65 million years
		/// </summary>
		public virtual bool IsExtinct { get; set; } = true;

		
	}
}