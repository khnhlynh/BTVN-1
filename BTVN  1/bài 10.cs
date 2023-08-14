using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN__1
{
    internal class bài_10
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, SecondNumber = 1, nextNumber, numberOfElements;
            Console.Write("Nhap vao so phan tu day Fibonacci ban muon in: ");
            numberOfElements = int.Parse(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.Write("Vui long nhap so phan tu lon hon 2: ");
            }
            else
            {
                Console.Write("Day Fibonacci: " + firstNumber + " " + SecondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }
    }
}
