using System;
namespace Lab05Zoo
{
	public abstract class ShallowSeaAnimal : SeaAnimal
	{
		/// <summary>
		/// public boolean with default property that can be overriden
		/// </summary>
		public virtual bool BreathesAir { get; set; } = true;
	}
}