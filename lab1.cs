using System;

namespace Lab1
{
    class A
    {
        private int a = 4, b = 6;

        public int C1 => a *= b;
        public int C2 => a - b;
		public int C3 => a++;
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new A();
            Console.WriteLine(obj.C1);
            Console.WriteLine(obj.C2);
			Console.WriteLine(obj.C3);
        }
    }
}
