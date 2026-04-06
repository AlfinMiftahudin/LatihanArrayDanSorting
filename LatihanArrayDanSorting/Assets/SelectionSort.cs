using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatihanArrayDanSorting.Models;

namespace LatihanArrayDanSorting.Assets
{
    internal class SelectionSort:SortOption
    {
        public override void Sort(int[] arr)
        {
            int min;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                min = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (i != min)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }


            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
