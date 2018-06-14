using System;

namespace Lab05Zoo
{
	public abstract class VoidLivingAnimal : VoidAnimal
	{
		/// <summary>
		/// abstract boolean of whether a void animal thinks or not
		/// </summary>
		/// <returns></returns>
		public abstract bool HasConsciousThought();

		/// <summary>
		/// default lestat factor, likely higher for vampires
		/// </summary>
		public virtual int LestatFactor { get; set; } = 5;
	}
}