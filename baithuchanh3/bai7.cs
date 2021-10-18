using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh3
{
    class bai7
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao h:");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = h; i >=1 ; i--)
            {
                for (int j = 1; j <=h ; j++)
                {
                    if(j<=h-i)
                    {
                        Console.Write("   ");
                    }else
                    {
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine("\n");

            }
        }
    }
}
