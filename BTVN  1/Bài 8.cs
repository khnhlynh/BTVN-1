using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_8
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cac so tu 0 den {0}:", num - 1);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
