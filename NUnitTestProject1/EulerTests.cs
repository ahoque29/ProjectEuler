using NUnit.Framework;
using ProjectEulerApp;

namespace ProjectEulerTests
{
	public class EulerTests
	{
		Euler _euler = new Euler();

		[TestCase(10, 23)]
		[TestCase(50, 543)]
		[TestCase(1000, 233168)]
		public void Problem1ReturnsCorrectAnswer(int input, int answer)
		{
			Assert.That(_euler.Problem1(input), Is.EqualTo(answer));
		}
	}
}