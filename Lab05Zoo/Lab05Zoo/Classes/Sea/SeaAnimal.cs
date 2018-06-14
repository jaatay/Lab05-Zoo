using System;

namespace Lab05Zoo
{
	public abstract class SeaAnimal : Animal
	{
		/// <summary>
		/// movement override for sea animals
		/// </summary>
		public override string MethodOfMovement {get; set;} = "Swim";

		/// <summary>
		/// depth set for sea animals as default, can be overriden by derived classes
		/// </summary>
		public virtual int Depth { get; set; } = 10;

	}
}