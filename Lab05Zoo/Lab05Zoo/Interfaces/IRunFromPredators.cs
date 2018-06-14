using System;

namespace Lab05Zoo
{
	interface IRunFromPredators
	{
		/// <summary>
		/// interface for prey
		/// </summary>
		/// <param name="input">takes a string argument</param>
		/// <returns>returns response of prey</returns>
		string TheFirstFiveSeconds(string input);
	}
}