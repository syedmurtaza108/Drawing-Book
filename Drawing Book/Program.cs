using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);
            Console.WriteLine(result);
        }

        static int pageCount(int n, int p)
        {
            int page1 = Math.Abs((p) / 2);
            if (n % 2 == 0)
            {
                n++;
            }
            int page2 = Math.Abs((p - (n)) / 2);
            return Math.Min(page1, page2);
            }
        }
    }

