using System;
namespace Lab05Zoo
{
	public abstract class ShallowSeaAnimal : SeaAnimal
	{
		public virtual bool BreathesAir { get; set; } = true;
	}
}