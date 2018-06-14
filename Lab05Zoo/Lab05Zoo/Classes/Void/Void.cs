using System;

namespace Lab05Zoo
{
	public abstract class VoidAnimal : Animal
	{
		/// <summary>
		/// void animals tend to appear in many movies, and even TV serials
		/// </summary>
		public virtual bool StarsInMovies { get; set; } = true;
	}
}