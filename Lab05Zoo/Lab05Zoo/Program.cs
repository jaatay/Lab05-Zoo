using System;

namespace Lab05Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
			Console.WriteLine();
			ReleaseTheKraken();
        }

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
