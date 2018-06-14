using System;

namespace Lab05Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
			ReleaseTheKraken();
        }

		/// <summary>
		/// method which tests the instantiation of an animal object
		/// </summary>
		static public void ReleaseTheKraken()
		{
			Kraken myAnimal = new Kraken();

			int krakenDepth = myAnimal.Depth;
			
			Console.WriteLine(myAnimal.IntroSound());
			Console.WriteLine(myAnimal.Diet);
			Console.WriteLine(krakenDepth.ToString());
		}

    }
}
