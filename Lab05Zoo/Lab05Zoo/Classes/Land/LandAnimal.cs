using System;

namespace Lab05Zoo {
	public abstract class LandAnimal : Animal
	{
		/// <summary>
		/// boolean declaring that land animals live in the not water
		/// </summary>
		public bool LivesOnLand { get; set; } = true;
	}

}
