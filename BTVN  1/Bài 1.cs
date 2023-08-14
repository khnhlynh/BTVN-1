using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Nhap n = ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 3 == 0)
            {
                Console.WriteLine("{0} chia het cho 3", num);
            }
            else
            {
                Console.WriteLine("{0} ko chia het cho 3", num);
            }
            Console.ReadKey(); 
        } 
    }
}