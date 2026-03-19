using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatihanArrayDanSorting.Models;

namespace LatihanArrayDanSorting.Assets
{
    internal class BubbleSort:SortOption
    {
        public override void Sort(int[] arr)
        {
            bool Sorted = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        Sorted = true;
                    }
                }
                if (!Sorted) break;
            }


            Console.Write("array setelah diurutkan : ");
            int index = 0;
            foreach (var item in arr)
            {
                Console.Write(index<arr.Length-1 ? $"{arr[index]}, " : $"{arr.Length} ");
                index++;
            }
            Console.WriteLine();
        }

    }
}
