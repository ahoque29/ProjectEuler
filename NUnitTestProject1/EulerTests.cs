using System;
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

		[TestCase(1, 0)]
		[TestCase(2, 2)]
		[TestCase(9, 10)]
		[TestCase(35, 44)]
		[TestCase(4000000, 4613732)]
		public void Problem2ReturnsCorrectAnswer(int input, int answer)
		{
			Assert.That(_euler.Problem2(input), Is.EqualTo(answer));
		}
	}
}