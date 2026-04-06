using LatihanArrayDanSorting.Models;
using System;

namespace LatihanArrayDanSorting.Assets
{
    internal class MaxMin : OpsArray
    {

        public override void Hitung(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"nilai minimum dari arraynya adalah : {min}");
            Console.WriteLine($"nilai maximum dari arraynya adalah : {max}");


        }
    }
}
