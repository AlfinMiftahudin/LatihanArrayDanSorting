using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatihanArrayDanSorting.Models;

namespace LatihanArrayDanSorting.Assets
{
    internal class ReverseElement:OpsArray
    {
        public override void Hitung(int[] arr)
        {
            int index = 0;
                Console.WriteLine("nilai awalnya adalah : ");
            foreach (var item in arr)
            {
                Console.Write(index < arr.Length - 1 ? $"{arr[index]}, " : $"{arr[index]}");
                index++;
            }
            Console.WriteLine();
            for (int i = 0; i < (arr.Length/2); i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;

            }
            index = 0;
            Console.WriteLine("nilai setelah dibalikkan adalah : ");
            foreach (var item in arr)
            {
                Console.Write(index<arr.Length-1 ? $"{arr[index]}, " : $"{arr[index]}");
                index++;
            }
        }
    }
}
