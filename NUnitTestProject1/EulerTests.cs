using System;
using NUnit.Framework;
using ProjectEulerApp;

namespace ProjectEulerTests
{
	public class EulerTests
	{

		[TestCase(10, 23)]
		[TestCase(50, 543)]
		[TestCase(1000, 233168)]
		public void Problem1ReturnsCorrectAnswer(int input, int answer)
		{
			Assert.That(Euler.Problem1(input), Is.EqualTo(answer));
		}

		[TestCase(1, 0)]
		[TestCase(2, 2)]
		[TestCase(9, 10)]
		[TestCase(35, 44)]
		[TestCase(4000000, 4613732)]
		public void Problem2ReturnsCorrectAnswer(int input, int answer)
		{
			Assert.That(Euler.Problem2(input), Is.EqualTo(answer));
		}

		[TestCase(60, 5)]
		[TestCase(13195, 29)]
		[TestCase(600851475143, 6857)]
		[TestCase(64, 2)]
		public void Problem3ReturnsCorrectAnswer(long input, int answer)
		{
			Assert.That(Euler.Problem3(input), Is.EqualTo(answer));
		}
	}
}