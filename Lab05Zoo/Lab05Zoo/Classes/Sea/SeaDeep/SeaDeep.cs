﻿using System;

namespace Lab05Zoo
{
	public abstract class DeepSeaAnimal : SeaAnimal
	{
		public virtual string HomeTerritory { get; set; } = "No Light Zone";
		public override int Depth {get; set;} = 500;
	}
}