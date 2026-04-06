using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LatihanArrayDanSorting.Models;

namespace LatihanArrayDanSorting.Assets
{
    internal class JumlahTotal:OpsArray
    {
        public override void Hitung(int[] arr)
        {
            int total = 0 ;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            Console.WriteLine($"total keseluruhan dari arraynya adalah : {total}");
            Console.WriteLine($"nilai rata-rata dari arraynya adalah : {total/arr.Length}");
        }
    }
}
