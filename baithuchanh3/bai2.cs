using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh3
{
    class bai2
    {
        static void Main(string[] args)
        {
            //code duoc do
            Console.WriteLine("Nhap so nguyen m:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap so nguyen n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {               
                for (int j =1 ; j <=n ; j++)
                {
                    if (i == 1 || j == 1 || i==m ||j==n)
                    {
                        Console.Write(" * ");
                    }else
                    {
                        Console.Write("   ");
                    }                    
                }
                Console.WriteLine();
            }
        }
    }
}
