﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum3_2_23051214152
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int laporan, kuis, mid, uas;
            float NA;

            Console.Write("masukkan nilai laporan : ");
            laporan = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai kuis : ");
            kuis = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai mid : ");
            mid = int.Parse(Console.ReadLine());
            Console.Write("masukkan nilai uas : ");
            uas = int.Parse(Console.ReadLine());

            NA = Convert.ToInt32((0.15 * laporan) + (0.15 * kuis) + (0.3 * mid) + (0.4 * uas));

            Console.Write("Nilai akhir anda adalah " + NA);

            switch (NA)
            {
                case float i when (NA > 85 && NA <= 100):
                    Console.Write(" nilai A");
                    Console.ReadLine();
                    break;

                case float i when (NA > 70 && NA <= 85):
                    Console.Write(" nilai B");
                    Console.ReadLine();
                    break;

                case float i when (NA > 55 && NA <= 70):
                    Console.Write(" nilai C");
                    Console.ReadLine();
                    break;

                case float i when (NA > 45 && NA <= 55):
                    Console.Write(" nilai D");
                    Console.ReadLine();
                    break;

                default:
                    Console.Write(" nilai E");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
