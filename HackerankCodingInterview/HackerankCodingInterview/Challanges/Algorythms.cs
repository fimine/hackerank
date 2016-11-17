using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HackerankCodingInterview.Challanges
{
	public static class Algorythms
	{
		static int c = 0;
		
		public static void CountingInversions(string[] args)
		{



			int t = Convert.ToInt32(Console.ReadLine());
			for (int a0 = 0; a0 < t; a0++)
			{
				c = 0;
				int n = Convert.ToInt32(Console.ReadLine());
				string[] arr_temp = Console.ReadLine().Trim().Split(' ');
				int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
				var arrTemp = new int[arr.Length];

				c = MergeSort(arr, arrTemp, 0, arr.Length - 1);
				Console.WriteLine(c);
				
			}



		}

		private static int MergeSort(int[] arr, int[] arrTemp, int start, int end)
		{
			if (start >= end)
				return 0;
			var count = 0;
			int mid = start / 2 + end / 2;
		
			count += MergeSort(arr, arrTemp, start, mid);
			count += MergeSort(arr, arrTemp, mid + 1, end);
			count += MergeHalves(arr, arrTemp, start, end);

			return count;

		}

		private static int MergeHalves(int[] arr, int[] arrTemp, int left, int end)
		{
			int leftEnd = left/2 + end/2;
			int right = leftEnd + 1;
			int i = left;
			int length = end - left + 1;
			var count = 0;

			while (left <= leftEnd && right <= end)
			{
				if (arr[left] > arr[right])
				{count += leftEnd + 1 - right;
					arrTemp[i] = arr[right];
					left++;
				

				}
				else
				{
					if (arr[left] < arr[right])
					{
					
						arrTemp[i] = arr[left];
						
					}

					
					right ++;

				}
				i++;
			}
			
			Array.Copy(arr, left, arrTemp, i,   leftEnd-left+1);
			Array.Copy(arr, right, arrTemp, i, end - right + 1);
			Array.Copy(arrTemp, arr, length);
			return count;

		}

	}
}