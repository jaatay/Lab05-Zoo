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
			string krakenDiet = myAnimal.Diet;
			string krakenSound = myAnimal.IntroSound();
			Console.WriteLine(krakenDepth.ToString(), krakenDiet, krakenSound);
		}

    }
}
