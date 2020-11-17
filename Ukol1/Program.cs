using System;

namespace Ukol1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 20; i += 2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("");

            // 1. prepiste cyklus for s pomoci cyklu while
            int j = 2;
            while (j < 20)
            {
                Console.Write(j + ", ");
                j += 2;
            }
            Console.WriteLine("");

            
            // 2. prepiste cyklus for s pomoci cyklu do-while
            int k = 2;
            do
            {
                Console.Write(k + ", ");
                k += 2;
            } while (k < 20);
            Console.WriteLine("");

            
            int t1 = 0;
            int t2 = 60;
            int t3 = 70;
            if ((t1 > 50 && t2 > 50) || t3 > 50)
            {
                Console.WriteLine("uspel");
            }
            
            // 3. Prepiste podminku pouze s pouzitim prikazu if, else a if-else a bez && (AND), || (OR) a bez pomocne promenne
            if (t3 > 50)
            {
                Console.WriteLine("uspel");
            }
            else if (t1 > 50)
            {
                if (t2 > 50)
                    Console.WriteLine("uspel");
            }
        }
        
    }
}