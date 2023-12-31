﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kombinatorika_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var FindNumber = from a in Enumerable.Range(1, 9)
                             from b in Enumerable.Range(1, 9)
                             where b != a
                             from c in Enumerable.Range(1, 9)
                             where c != b && c != a
                             from d in Enumerable.Range(1, 9)
                             where d != a && d != b && d != c
                             from e in Enumerable.Range(1, 9)
                             where e != a && e != b && e != c && e != d
                             from f in Enumerable.Range(1, 9)
                             where f != a && f != b && f != c && f != d && f != e
                             from g in Enumerable.Range(1, 9)
                             where g != a && g != b && g != c && g != d && g != e && g != f
                             from h in Enumerable.Range(1, 9)
                             where h != a && h != b && h != c && h != d && h != e && h != f && h != g
                             from i in Enumerable.Range(1, 9)
                             where i != a && i != b && i != c && i != d && i != e && i != f && i != g && i != h
                             where (a * 10 + b) % 2 == 0 &&
                                   (a * 100 + b * 10 + c) % 3 == 0 &&
                                   (a * 1000 + b * 100 + c * 10 + d) % 4 == 0 &&
                                   (a * 10000 + b * 1000 + c * 100 + d * 10 + e) % 5 == 0 &&
                                   (a * 100000 + b * 10000 + c * 1000 + d * 100 + e * 10 + f) % 6 == 0 &&
                                   (a * 1000000 + b * 100000 + c * 10000 + d * 1000 + e * 100 + f * 10 + g) % 7 == 0 &&
                                   (a * 10000000 + b * 1000000 + c * 100000 + d * 10000 + e * 1000 + f * 100 + g * 10 + h) % 8 == 0 &&
                                   (a * 100000000 + b * 10000000 + c * 1000000 + d * 100000 + e * 10000 + f * 1000 + g * 100 + h * 10 + i) % 9 == 0
                             select (a * 100000000 + b * 10000000 + c * 1000000 + d * 100000 + e * 10000 + f * 1000 + g * 100 + h * 10 + i);

            foreach (var n in FindNumber) 
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
