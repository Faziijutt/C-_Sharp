using System;
using System.Security.Cryptography.X509Certificates;
namespace delegat{
    public delegate void addtion(int a, int b);
    class Program{

        public static void add(int a,int b)
        {
            int c =a+b;
            Console.WriteLine($"addtion of a and b is {c}");
        }
        public static void mult(int a,int b)
        {
            int c =a*b;
            Console.WriteLine($"multiplication of a and b is {c}");
        }
        public static void sub(int a,int b)
        {
            int c =a-b;
            Console.WriteLine($"subtraction of a and b is {c}");
        }
        public static void divi(int a,int b)
        {
            int c =a/b;
            Console.WriteLine($"devition of a and b is {c}");
        }

        static void Main()
        {
            // addtion calcuation=new addtion(Program.add);
            // calcuation(3,3);
            // // plus.Invoke(2,2);
            // calcuation=mult;
            // calcuation(3,3);
            // calcuation=divi;
            // calcuation(3,3);
            // calcuation=sub;
            // calcuation(3,3);
            Program.add(3,3);
            Program.divi(3,3);
            Program.mult(3,3);
            Program.sub(3,3);

        }



    }


}