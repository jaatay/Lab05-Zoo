using System;

namespace Lab05Zoo
{
	public abstract class VoidLivingAnimal : VoidAnimal
	{
		public abstract bool HasConsciousThought();
		public virtual int LestatFactor { get; set; } = 5;
	}
}