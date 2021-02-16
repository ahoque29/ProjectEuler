using System;
using System.Collections.Generic;

namespace ProjectEulerApp
{
	public class Euler
	{
		// Sum of all natural numbers below input that are divisible by 3 or 5.
		public int Problem1(int input)
		{
			var total = 0;

			for (int n = 1; n < input; n++)
			{
				if (n % 3 == 0 || n % 5 == 0)
				{
					total += n;
				}
			}

			return total;
		}

		// Sum of all even fibonacci numbers in a fibonacci sequence where last member is below input.
		public int Problem2(int input)
		{
			// as the list is already populated by 1 and 2, if input is 1 , return results directly
			if (input == 1)
			{
				return 0;
			}

			// make a list of fibonacci numbers
			var FibonacciNumbers = new List<int>() { 1, 2 };

			int a = 1;
			int b = 2;
			int lastMember = 2;

			for (int n = 3; lastMember < input; n++)
			{
				lastMember = a + b;
				FibonacciNumbers.Add(lastMember);
				a = b;
				b = lastMember;
			}

			// sum up the even number numbers of the list
			var total = 0;

			foreach (var m in FibonacciNumbers)
			{
				if (m % 2 == 0)
				{
					total += m;
				}
			}
			
			return total;
		}
	}
}