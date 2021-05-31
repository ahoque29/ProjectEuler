﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEulerApp
{
	public static class Euler
	{
		// Sum of all natural numbers below input that are divisible by 3 or 5.
		public static int Problem1(int input)
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
		public static int Problem2(int input)
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

		// returns the largest prime factor of the given input
		public static int Problem3(long input)
		{

			// variable to store the latest prime extracted
			var prime = 0;

			// intermediary variable to hold in the input (not necessary but leads to readability)
			var a = input;

			// loop starts at 2 and computes a % i until it equals 0
			// when it does, stores i into the the list, sets a to a / i and resets the counter to (i - 1) then continues the loop
			// repeats until a = 1 which happens when a / i is computed when i = a
			for (int i = 2; a != 1; i++)
			{
				if (a % i == 0)
				{
					prime = i;
					a /= i;
					i--;
				}
			}
			
			// the last prime extracted is the largest one
			return prime;
		}

		public static int Problem4()
		{
			// check that an integer is a palindrome
			static bool PalindromeChecker(int integer)
			{
				// store integer as an array of digits
				var digitArray = integer.ToString().ToCharArray();
				var checkNumber = 0;

				for (int i = 0; i <= digitArray.Length / 2; i++)
				{
					if (digitArray[i] != digitArray[digitArray.Length - 1 - i])
					{
						checkNumber++;
					}
				}

				var check = true;

				if (checkNumber > 0)
				{
					check = false;
				}

				return check;
			}

			// make a hashset of all the possible products of 3 digit numbers.
			var products = new HashSet<int>();

			for (int i = 100; i <= 999; i++)
			{
				for (int j = 100; j <= 999; j++)
				{
					products.Add(i * j);
				}
			}

			var palindromes = new List<int>();

			foreach (var integer in products)
			{
				if (PalindromeChecker(integer))
				{
					palindromes.Add(integer);
				}
			}

			return palindromes.Max();
		}
	}
}