using System;

namespace Lab05Zoo
{
	public abstract class NotASpider : LandAnimalWithNoLegs
	{	
		/// <summary>
	/// abstract boolean confirming that animals which are not spiders are indeed not spiders
	/// </summary>
		public abstract bool DefinitelyNotASpider { get; set; }
	}
}