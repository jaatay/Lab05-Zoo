using System;

namespace Lab05Zoo
{
	public abstract class CoastalSeaAnimal : ShallowSeaAnimal
	{
		public virtual bool CloseToShore { get; set; } = true;
		public abstract string CanDoMath();
		
	}
}