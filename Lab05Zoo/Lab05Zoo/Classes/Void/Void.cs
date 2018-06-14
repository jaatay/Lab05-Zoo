using System;

namespace Lab05Zoo
{
	public abstract class VoidAnimal : Animal
	{
		public virtual bool StarsInMovies { get; set; } = true;
	}
}