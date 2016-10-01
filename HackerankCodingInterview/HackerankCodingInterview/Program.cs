using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview
{
	public static class Program
	{
		static void Main(string[] args)
		{
			//ArrayRotation(args);
			Ngram();
			Ngram2();
			Console.ReadLine();
		}

		static int Equilibrium(int[] A)
		{
			throw new NotImplementedException();


			for (var i = 0; i < A.Length; i++)
			{


			}


		}

		static void ArrayRotation(String[] args)
		{
			var tokens_n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
			var a_temp = Console.ReadLine().Split(' ');
			var a = Array.ConvertAll(a_temp, Int32.Parse);
			var totalRotations = tokens_n.Sum();
			if (a.Length == 0) return;

			var moveBy = a.Length - (totalRotations % a.Length);
			if (moveBy > 0)
			{
				var maxIndex = a.Length - 1;

				for (var i = 0; i <= maxIndex; i++)
				{
					var newI = (i - moveBy) < 0
						? a.Length + i - moveBy
						: i - moveBy;

					Console.Write(a[newI] + " ");
				}
			}
		}

		static void Ngram()
		{
			//var a = Console.ReadLine().ToCharArray();
			//var b = Console.ReadLine().ToCharArray();
			var a = new char[] { 'c', 'd', 'e', 'e', 'e' };
			var b = new char[] { 'a', 'b', 'c', 'c', 'e' };

			var inter = b.Intersect(a);
			var diffMatch = b.Intersect(a).Sum(i => Math.Abs(a.Where(p => p == i).Count() - b.Where(p => p == i).Count()));
			var cnt = a.Concat(b).Count(p => !inter.Contains(p)) + diffMatch;

			Console.Write(cnt);

		}

		static void Ngram2()
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
