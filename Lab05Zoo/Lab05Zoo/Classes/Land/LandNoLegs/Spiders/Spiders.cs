using System;

namespace Lab05Zoo
{
	public abstract class Spiders: LandAnimalWithNoLegs
	{
		public virtual bool HasVenom { get; set; } = true;
		public virtual string SpinsWebs()
		{
			return "I spin webs!";
		}
	}
}