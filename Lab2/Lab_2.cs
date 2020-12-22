using System;

namespace Lab2
{
    class A
    {
        private int a = 4, b = 6;

        public int C1 => a *= b;
        public int C2 => a - b;
		public int C3 => a++;

        public A (int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public A() {}
    }

    class B : A
    {
        private int d;

        public int C3
        {
            get
            {
                do 
				{
				d++;
				}
				while(d<10);
				
				return d;
            }
        }
    
        public B (int a, int b, int d) : base(a, b)
        {
            this.d = d;
        }
        public B (int d)
        {
            this.d = d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A(4, 6);
            B obj2 = new B(4, 6, 5);
            B obj3 = new B(5);
            
            Console.WriteLine($"obj1:\tC1: {obj1.C1}\n\tC2: {obj1.C2}\n");
            Console.WriteLine($"obj2:\tC1: {obj2.C1}\n\tC2: {obj2.C2}\n\tC3: {obj2.C3}\n");
            Console.WriteLine($"obj3:\tC1: {obj3.C1}\n\tC2: {obj3.C2}\n\tC3: {obj3.C3}\n");
        }
    }
}
