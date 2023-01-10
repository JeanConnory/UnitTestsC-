using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
	[TestFixture]
	public class FizzBuzzTests
	{
		[Test]
		[TestCase(15)]
		public void GetOutput_NumberDivisibleByThreeAndFive_ReturnFizzBuzz(int number)
		{
			var result = FizzBuzz.GetOutput(number);

			Assert.That(result, Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void GetOutput_NumberDivisibleByThree_ReturnFizz()
		{
			var result = FizzBuzz.GetOutput(9);

			Assert.That(result, Is.EqualTo("Fizz"));
		}

		[Test]
		public void GetOutput_NumberDivisibleByFive_ReturnFizz()
		{
			var result = FizzBuzz.GetOutput(10);

			Assert.That(result, Is.EqualTo("Buzz"));
		}

		[Test]
		[TestCase(8)]
		public void GetOutput_NumberNotDivisibleByThreeAndFive_ReturnFizz(int number)
		{
			var result = FizzBuzz.GetOutput(number);

			Assert.That(result, Is.EqualTo("8"));
		}
	}
}
