using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baithuchanh3
{
    class bai6
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập chiều cao h");
            int h = Convert.ToInt32(Console.ReadLine());
            if(h>0)
            {
                for (int i = 1; i <= h; i++)
                {
                    for (int j = 1; j <=h; j++)
                    {
                        if (j <= h - i)
                        {
                            Console.Write("   ");
                        }else
                        {
                            Console.Write(" * ");
                        }                            
                    }
                    Console.WriteLine("\n");
                }
            }else
            {
                Console.WriteLine("Vui lòng nhập h lớn hơn 0");
            }    
        }
    }
}
