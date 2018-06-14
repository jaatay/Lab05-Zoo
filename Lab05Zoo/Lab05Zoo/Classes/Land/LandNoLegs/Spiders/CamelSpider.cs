using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Zoo {

	public class CamelSpider : Spiders, IEatPrey
	{
		public override string Diet { get; set; } = "Sand.";
		public override string MethodOfMovement { get; set; } = "Eight legs";
		public override bool HasVenom { get; set; } = false;
		public bool LivingThingsAreTasty { get; set; } = true;

		public override string SpinsWebs()
		{
			return "I don't spin webs";
		}

		public override string IntroSound()
		{
			return "Technically speaking, I'm not even a spider";
		}
	}

}