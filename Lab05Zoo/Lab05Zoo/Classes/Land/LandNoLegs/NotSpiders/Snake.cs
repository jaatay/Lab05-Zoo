using System;

namespace Lab05Zoo
{
	public class Snake : NotASpider
	{

		public override bool DefinitelyNotASpider { get; set; } = true;
		public override string Diet { get; set; } = "I eat mices.";
		public override string MethodOfMovement { get; set; } = "Slither";

		public override string IntroSound()
		{
			return "Hissss";
		}
	}
}