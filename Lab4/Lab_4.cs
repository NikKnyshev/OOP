using System;

namespace Lab4
{
    class B
    {
        public float[] arr = new [] {2.5f, 5.55f, 23.2f, 11.2f, 16.16f};
        public int[] arr2 = new [] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        public float this[int ind1]
	    {
		    get{ return arr[ind1]; }
		    set{ arr[ind1] = value; }
	    }
        public int this[int ind2, int plug] 
	    {
		    get{ return arr2[ind2]; }
		    set{ arr2[ind2] = value; }
	    }

    }

    class C<T>    
    {
        public T variable = default(T);
        public static string banner = "╔═══════════════════════════════════╗\n" +
                                      "║             HELLO WORLD           ║\n" +
                                      "╚═══════════════════════════════════╝\n";

        public void PrintBanner()
        {
            Console.WriteLine(banner);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            B bObj = new B();

            for (int i = 0; i < bObj.arr.Length; i++)
            {
                Console.Write($"{bObj[i]}\t");
            }
            Console.WriteLine();
            for (int i = 0; i < bObj.arr2.Length; i++)
            {
                Console.Write($"{bObj[i,1]}\t");
            }
            Console.WriteLine();
            
            
            C<string> cObj_1 = new C<string>();
            C<int> cObj_2 = new C<int>();       

            Console.WriteLine("C<int>.banner:");
            Console.WriteLine(C<int>.banner);

            cObj_1.variable = "Hello world!";
            cObj_2.variable = 255;
            
            Console.WriteLine("cObj_1.PrintBanner():");
            cObj_1.PrintBanner();
            Console.WriteLine("cObj_2.PrintBanner():");
            cObj_2.PrintBanner();
            
            C<int>.banner = "╔═══════════════════╗\n" +
                            "║ New banner saved! ║\n" + 
                            "╚═══════════════════╝\n";
            
            Console.WriteLine("cObj_1.PrintBanner():");
            cObj_1.PrintBanner();
            Console.WriteLine("cObj_2.PrintBanner():");
            cObj_2.PrintBanner();
        }
    }
}