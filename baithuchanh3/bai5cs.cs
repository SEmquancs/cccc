using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh3
{
    class bai5cs
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao h:");
            int h = Convert.ToInt32(Console.ReadLine());
            if (h > 0)
            {
                for (int i = h; i >= 1; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine("\n");
                }
            }else
                Console.WriteLine("Nhập h lớn hơn 0");
            
        }
    }
}
