using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_2
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Ban muon in ra bao nhieu bang cuu chuong? ");
            num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("--- Cuu chuong {0} ---", i);

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, (i * j));
                }
            }
            Console.ReadLine();
        }
    }
}
