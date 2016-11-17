using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
public static	class Sorting
	{
		public static void IceCreamParlor(String[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < t; a0++)
			{
				int m = Convert.ToInt32(Console.ReadLine());
				int n = Convert.ToInt32(Console.ReadLine());
				string[] a_temp = Console.ReadLine().Split(' ');
				int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			}
		}
	}
}
