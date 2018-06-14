using System;

namespace Lab05Zoo
{
	public abstract class Animal
	{
		public bool NotAPlant = true;

		public abstract string Diet { get; set; }

		public abstract string MethodOfMovement { get; set; }

		public virtual string IntroSound()
		{
			return "Hi, I am a animal.";
		}
	}
}