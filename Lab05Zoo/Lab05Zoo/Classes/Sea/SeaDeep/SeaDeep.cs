using System;

namespace Lab05Zoo
{
	public abstract class DeepSeaAnimal : SeaAnimal
	{
		/// <summary>
		/// string regarding where in the sea a deep sea animal lives
		/// </summary>
		public virtual string HomeTerritory { get; set; } = "No Light Zone";

		/// <summary>
		/// override of depth property
		/// </summary>
		public override int Depth {get; set;} = 500;
	}
}