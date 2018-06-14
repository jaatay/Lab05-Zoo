using System;

namespace Lab05Zoo
{
	public abstract class NotASpider : LandAnimalWithNoLegs
	{
		public abstract bool DefinitelyNotASpider { get; set; }
	}
}