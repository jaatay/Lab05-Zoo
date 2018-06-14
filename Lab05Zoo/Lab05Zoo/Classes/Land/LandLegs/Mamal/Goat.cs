using System;

namespace Lab05Zoo
{
	public class Goat : Mammal
	{
		public override string Diet { get; set; } = "Grass.";
		public sealed override int LitersOfGrassEaten { get; set; } = 50;
		public bool IsABoringAnimal = true;

		public override string IntroSound()
		{
			return "Baa goat like grass";
		}
	}
}