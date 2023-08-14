using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class Bài_9
    {
        static void Main(string[] args)
        {
            int i, j, bien_dem, so_hang, k;

            Console.Write("Nhap so hang: ");
            so_hang = Convert.ToInt32(Console.ReadLine());
            bien_dem = so_hang + 4 - 1;
            for (i = 1; i <= so_hang; i++)
            {
                for (k = bien_dem; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                for (j = 1; j <= i; j++)
                    Console.Write("* ");
                Console.Write("\n");
                bien_dem--;
            }
            Console.ReadKey();
        }

    }
}
