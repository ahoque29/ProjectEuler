using System;

namespace ProjectEulerApp
{
	public class Euler
	{
		// Sum of all natural numbers below input that are divisible by 3 or 5.
		public int Problem1(int input)
		{
			int total = 0;

			for (int n = 1; n < input; n++)
			{
				if (n % 3 == 0 || n % 5 == 0)
				{
					total += n;
				}
			}

			return total;
		}
	}
}