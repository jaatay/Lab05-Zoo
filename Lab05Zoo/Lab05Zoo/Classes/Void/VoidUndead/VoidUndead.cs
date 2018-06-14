using System;

namespace Lab05Zoo
{
	public abstract class VoidUndeadAnimal : VoidAnimal
	{
		public virtual string SoleMotivation { get; set; } = "Eat stuff.";
	}
}