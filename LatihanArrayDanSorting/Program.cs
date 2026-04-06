using LatihanArrayDanSorting.Assets;
using LatihanArrayDanSorting.Models;
using System;


namespace LatihanArrayDanSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarisBaru();
            TampilanMenu();
            GarisBaru();
            Console.Write("pilih opsi : ");
            SortOption sort;
            OpsArray hitung;
            while (true)
            {
                int[] NilaiArray = { 2, 5, 1, 6, 22, 11, 23, 42, 14, 76, 62 };

                int PilihOpsi = InputAngka();
                switch (PilihOpsi)
                {
                    case 1:
                        int IndexAwal = 0;
                        foreach (var item in NilaiArray)
                        {
                            Console.Write(IndexAwal < NilaiArray.Length - 1 ? $"{item} , " : $"{item} ");
                            IndexAwal++;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        TampilkanMenuHitung(NilaiArray);
                        Console.WriteLine("pilih opsi menu : ");
                        while (true)
                        {
                            int OpsiSorting = InputAngka();
                            switch (OpsiSorting)
                            {
                                case 1:
                                    hitung = new JumlahTotal();
                                    hitung.Hitung(NilaiArray);
                                    break;
                                case 2:
                                    hitung = new MaxMin();
                                    hitung.Hitung(NilaiArray);
                                    break;
                                default:
                                    Console.Write("sorting tidak valid tolong isi kembali : ");
                                    continue;
                            }
                            break;
                        }

                        break;

                    case 3:
                        hitung = new ReverseElement();
                        hitung.Hitung(NilaiArray);
                        break;

                           //sorting
                    case 4:
                        Console.Clear();
                        TampilkanMenuSorting(NilaiArray);
                        Console.Write("pilih opsi sorting : ");
                        while (true)
                        {
                            int OpsiSorting = InputAngka();
                            switch (OpsiSorting)
                            {
                                case 1:
                                    sort = new BubbleSort();
                                    sort.Sort(NilaiArray);
                                    break;
                                case 2:
                                    sort = new SelectionSort();
                                    sort.Sort(NilaiArray);
                                    break;
                                default:
                                    Console.Write("sorting tidak valid tolong isi kembali : ");
                                    continue;
                            }
                            break;
                        }
                        break;
                        //penutup sorting

                    default:
                        Console.Write("opsi tidak valid tolong isi kembali : ");
                        continue;

                }
                break;


            }
        }

        static int InputAngka()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int angka) && angka > 0)
                {
                    return angka;
                }
                Console.Write("pilihan tidak valid, tolong isi kembali : ");
            }
        }

        static void GarisBaru()
        {
            Console.WriteLine("");
            Console.WriteLine(new string('=', 55));
            Console.WriteLine("");
        }
        static void TampilanMenu()
        {
            Console.WriteLine("1. tampilkan nilai array");
            Console.WriteLine("2. tampilkan & hitung nilai array");
            Console.WriteLine("3. membalikkan nilai array");
            Console.WriteLine("4. sorting");
        }
        static void TampilkanMenuHitung(int[] arr)
        {
            GarisBaru();
            Console.WriteLine("1. Hitung total & Nilai rata-rata");
            Console.WriteLine("2. Nilai Max & Min");
            GarisBaru();
            int index = 0;
            Console.WriteLine("nilai awal : ");
            foreach (var item in arr)
            {
                Console.Write(index < arr.Length - 1 ? $"{arr[index]}, " : $"{arr[index]} ");
                index++;
            }
            Console.WriteLine("");
            GarisBaru();

        }
        static void TampilkanMenuSorting(int[] arr)
        {
            GarisBaru();
            Console.WriteLine("Bubble Sort");
            Console.WriteLine("Selection Sort");
            GarisBaru();
            int index = 0;
            Console.WriteLine("nilai awal : ");
            foreach (var item in arr)
            {
                Console.Write(index < arr.Length - 1 ? $"{arr[index]}, " : $"{arr[index]} ");
                index++;
            }
            Console.WriteLine("");
            GarisBaru();

        }
    }
}
