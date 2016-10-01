using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
	class ArrayRotation
	{
		public static void LeftRotation(String[] args)
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
	}
}
