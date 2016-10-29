using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
	public static class Stacks
	{

		private const int bracketPairs = 3;

		public static void BalancedBrackets(String[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < t; a0++)
			{
				string expression = Console.ReadLine();
				Console.WriteLine(IsBalanced(expression) ? "YES" : "NO");
			}
		}

		static bool IsBalanced(string message)
		{
			var s = new Stack<char>();
			
			var pairs = new char[,] {
				{'}', '{' }
				, {']', '[' }
				, {')', '('}
			};

			foreach (var c in message)
			{
				for (var i = 0; i < bracketPairs; i++)
				{
					if (pairs[i, 1] == c)
					{
						s.Push(c);
					}
					else if(pairs[i,0] == c)
					{
						if (!s.Any()) return false;
						var last = s.Pop();
						if (last != pairs[i, 1]) return false;

					}
				}
			}

			return !s.Any();
		}

	}
}
