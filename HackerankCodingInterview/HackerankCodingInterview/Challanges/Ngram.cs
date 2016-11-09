using System;
using System.Linq;

namespace HackerankCodingInterview.Challanges
{
	public static class Ngram
	{
		public static void NgramDotNet()
		{
			var a = new char[] { 'c', 'd', 'e', 'e', 'e' };
			var b = new char[] { 'a', 'b', 'c', 'c', 'e' };

			var inter = b.Intersect(a);
			var diffMatch = b.Intersect(a).Sum(i => Math.Abs(a.Where(p => p == i).Count() - b.Where(p => p == i).Count()));
			var cnt = a.Concat(b).Count(p => !inter.Contains(p)) + diffMatch;

			Console.Write(cnt);
		}

		public static void NgramStringBased()
		{

			var a = "cceefe";
			var b = "abcasc";
			var pairs = 0;
			var cnt = a.Length + b.Length;
			foreach (var t in a)
			{
				for (var j = 0; j < b.Length; j++)
					if (t == b[j])
					{
						pairs++;
						b = b.Remove(j, 1);
						break;

					}
			}

			Console.Write(cnt - pairs * 2);

		}
	}
}
