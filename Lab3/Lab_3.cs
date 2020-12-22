using System;

namespace Lab3
{
    class A
    {
        private int a;

        public A (int a)
        {
            this.a = a;
        }
        public A() {}
    }

    class B : A
    {
        private float d;
        private float[] arr;

        public float[] Arr => arr;

        public float C2
        {
            get
            {
                if (d >= 3.33)
                {
                    return d;
                }
                else
                {
                    return 1.4f;
                }
            }
        }
    
        public B (int a, float d) : this(d, a)
        {
            arr = new float[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = C2 * i;
            }
        }
        public B (float d, int a) : base(a)
        {
            this.d = d;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            B obj = new B(4, 9.92f);
            foreach (var n in obj.Arr) Console.Write(n + "\t");
            Console.WriteLine();
            obj = new B(4, 2.2f);
            foreach (var n in obj.Arr) Console.Write(n + "\t");
        }
    }
}