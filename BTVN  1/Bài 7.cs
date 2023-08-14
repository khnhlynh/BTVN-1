using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_6
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Nhap vao so number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Cac so le tu 1 den {num} la :");
            for (int i = 1; i <= num; i += 2)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.Write($"\nTong cac so le tu 1 den {num} la : {sum}");
            Console.ReadKey();
        }
    }
}
