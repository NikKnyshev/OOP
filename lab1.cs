using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.c);
            Console.WriteLine(obj.e);
            Console.WriteLine(obj.f);
            Console.ReadKey();
        }
    }
    class A
    {
        private int a = 4;
        private int b = 6;

        public int c
        {
            get
            {
                return a - b;
            }
        }
        public int e
        {
            get
            {
                a *= b;
                return a;
            }
        }
        public int f
        {
            get
            {
                a++;
               // b++;
                return a;
            }
        }
    }
}
