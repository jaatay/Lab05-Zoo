using System;

namespace Lab05Zoo
{
	public abstract class Animal
	{
		/// <summary>
		/// boolean declaring animals are not plants
		/// </summary>
		public bool NotAPlant = true;

		/// <summary>
		/// abstract string regarding what's tasty to a particular animal
		/// </summary>
		public abstract string Diet { get; set; }

		/// <summary>
		/// abstract string of how an animal moves
		/// </summary>
		public abstract string MethodOfMovement { get; set; }

		/// <summary>
		/// abstract string of sound an animal makes
		/// </summary>
		/// <returns>default string, unless overridden</returns>
		public virtual string IntroSound()
		{
			return "Hi, I am a animal.";
		}
	}
}