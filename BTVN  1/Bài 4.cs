using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_4
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Nhap num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cac so tu 0 den {0}:", num - 1);
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(i + " ");
                sum += i;
            }
            Console.Write("Tong cac so chan tu 1 den {0} la : {1}", num - 1, sum);
            Console.ReadKey();
        }
    }
}
