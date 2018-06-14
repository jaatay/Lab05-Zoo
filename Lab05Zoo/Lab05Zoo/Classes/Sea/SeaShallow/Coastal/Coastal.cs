using System;

namespace Lab05Zoo
{
	public abstract class CoastalSeaAnimal : ShallowSeaAnimal
	{
		/// <summary>
		/// virtual boolean of littoral sea creatures distance from shore
		/// </summary>
		public virtual bool CloseToShore { get; set; } = true;

		/// <summary>
		/// abstract method of whether a coastal sea creature can do math
		/// </summary>
		/// <returns></returns>
		public abstract string CanDoMath();
		
	}
}