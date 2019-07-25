using System;

namespace T1809E_CSharp
{
    public class Timn
    {
        
        static void Main(String[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("So fibonaci thu n "+n+" la: "+Fibonaci(n));
        }

        static int Fibonaci(int n)
        {
            if (n == 1 || n == 2) return 1;
            if (n == 2) return 2;
            int x1 = 1, x2 = 1, x3 = 2;
            for (int i = 4; i <=n ; i++)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
            }

            return x3;
        }
    }
}