using System;

namespace Lab05Zoo
{
	public abstract class SeaAnimal : Animal
	{
		public override string MethodOfMovement {get; set;} = "Swim";
		public virtual int Depth { get; set; } = 10;

	}
}