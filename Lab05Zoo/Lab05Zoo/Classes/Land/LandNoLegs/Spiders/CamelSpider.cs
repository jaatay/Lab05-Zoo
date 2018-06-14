using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05Zoo {

	public class CamelSpider : Spiders
	{
		public override string Diet { get; set; } = "Sand.";
		public override string MethodOfMovement { get; set; } = "Eight legs";
		public override bool HasVenom { get; set; } = false;

		public override string SpinsWebs()
		{
			return "I don't spin webs";
		}
	}

}