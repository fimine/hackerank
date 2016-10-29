using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
	public static class Stacks
	{
		static void BalancedBrackets(String[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < t; a0++)
			{
				string expression = Console.ReadLine();
			}

			
		}

		static string IsBalanced(string message)
		{
			var s = new Stack<char>[3];
			
			var lefts = new List<string> { "{", "[", "(" };
			var rights = new string[] { "}", "]", ")" };

			foreach (var s in message)
			{
				if(lefts.Contains(s))
				{
					stackMessage.Push()
				}
			}
			return "";
		}



	}
}
