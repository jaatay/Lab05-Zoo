using System;

namespace Lab05Zoo
{
	public abstract class VoidUndeadAnimal : VoidAnimal
	{
		/// <summary>
		/// string setting the primary motivation of undead void animals
		/// </summary>
		public virtual string SoleMotivation { get; set; } = "Eat stuff.";
	}
}