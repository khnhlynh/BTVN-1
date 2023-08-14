using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_3
    {
        static bool soCP(int n)
        {
            int sqr = (int)Math.Sqrt(n);
            if (sqr * sqr == n)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            Console.Write("\n Nhap vao so can kiem tra: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (soCP(n))
            {
                Console.WriteLine("\n So {0} la so chinh phuong.", n);
            }
            else
            {
                Console.WriteLine("\n So {0} khong phai la so chinh phuong.", n);
            }
        }
    }
}
