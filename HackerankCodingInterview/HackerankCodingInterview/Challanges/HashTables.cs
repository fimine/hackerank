using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
	public static class HashTables
	{
		public static void RansomNote()
		{
			//string[] tokens_m = Console.ReadLine().Split(' ');
			//int m = Convert.ToInt32(tokens_m[0]);
			//int n = Convert.ToInt32(tokens_m[1]);
			//string[] magazine = Console.ReadLine().Split(' ');
			//string[] ransom = Console.ReadLine().Split(' ');

			int m = 6;
			int n = 4;
			string[] magazine = "give me one grand today night today one".Split(' ');
			string[] ransom = "give one grand today".Split(' ');

			if (n > m || m <= 0 || n <= 0 || 30000 < m || 30000 < n)
			{
				Console.WriteLine("No");
				return;
	
			}

			var mD = magazine.Distinct().ToDictionary(p=>p, p => 0);
			
			foreach (var word in magazine)
				mD[word]++;
			foreach (var word in ransom)
			{
				var c = mD[word];
				if (c == 0)
				{
					Console.WriteLine("No");
					return;
				}
				mD[word]--;

			}
			Console.WriteLine("Yes");
		}
	}
}
