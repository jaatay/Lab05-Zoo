using System;

namespace Lab05Zoo
{
	interface IEatPrey
	{
		/// <summary>
		/// interface for predators, defining whether or not they find their food tasty
		/// </summary>
		bool LivingThingsAreTasty { get; set; }

	}
}