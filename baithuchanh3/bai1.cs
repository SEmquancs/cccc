using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }

        }
    }
}
