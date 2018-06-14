using System;
using Xunit;
using Lab05Zoo;

namespace lab
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateAnimal()
        {
			//arrange
			Zombie WalkingDead = new Zombie();
			//act

			//assert
			Assert.Equal("I eat brains!", WalkingDead.Diet);
        }

		[Fact]
		public void HasDerivedClass()
		{
			//arrange
			Human OneHuman = new Human();
			//act

			//assert
			Assert.True(OneHuman is Animal);
		}

		[Fact]
		public void HasPreyInterFaceProperties()
		{
			//arrange
			Kraken WeakKraken = new Kraken();
			//act
			string input = "Oh no!";

			//assert
			Assert.Equal(input, WeakKraken.TheFirstFiveSeconds(input));
		}

		[Fact]
		public void HasPredatorInterFaceProperties()
		{
			//arrange
			Tyranosaur JesseVentura = new Tyranosaur();
			//act
			
			//assert
			Assert.True(JesseVentura.LivingThingsAreTasty);
		}

		[Fact]
		public void InheretsPropertiesFromAnimalBase()
		{
			//arrange
			JellyFish JelloFish = new JellyFish();
			//act
	
			//assert
			Assert.True(JelloFish.NotAPlant);
		}

		[Fact]
		public void IsDerivedFromClassAbove()
		{
			//arrange
			Vampire LeStat = new Vampire();
			//act
	
			//assert
			Assert.Equal(5, LeStat.LestatFactor);
		}

		[Fact]
		public void CanPlayIntroSound()
		{
			//arrange
			BlackWidow Charlotte = new BlackWidow();
			//act

			//assert
			Assert.Equal("I wound you with a kiss.", Charlotte.IntroSound());
		}

		[Fact]
		public void CanOverride()
		{
			//arrange
			CamelSpider Kebob = new CamelSpider();
			//act

			//assert
			Assert.Equal("I don't spin webs", Kebob.SpinsWebs());
		}

	}
}
