using System;

namespace Lab05Zoo
{
	public abstract class Spiders: LandAnimalWithNoLegs
	{
		/// <summary>
		/// boolean that can be overriden by choice
		/// </summary>
		public virtual bool HasVenom { get; set; } = true;

		/// <summary>
		/// string returning that spiders spin webs, can be overriden
		/// </summary>
		/// <returns></returns>
		public virtual string SpinsWebs()
		{
			return "I spin webs!";
		}
	}
}