using System;

namespace Ukol10
{
    class Program
    {
        
        
        static void PrikladRef(ref int vnitrniPromenna)
        {
            // zde používám "ref", takže nemusím proměnnou inicializovat
            vnitrniPromenna = vnitrniPromenna + 10;
        }   
        
        
        static void PrikladOut(out int vnitrniPromenna)
        {
            // zde používám "out", takže musím proměnnou inicializovat
            vnitrniPromenna = 0;
            vnitrniPromenna = vnitrniPromenna + 30;
        }
        
        
        static void Main(string[] args)
        {
            int promenna = 10;
            Console.WriteLine(promenna);  // vypis promenne
            
            // pouziti "ref"
            PrikladRef(ref promenna);  
            Console.WriteLine(promenna);
            
            // pouziti "out"
            PrikladOut(out promenna);
            Console.WriteLine(promenna);
        }
        
        /*    POPIS
         * klíčová slova "ref", "out" slouží pro předání proměnné pomocí reference
         *
         * rozdíl mezi "ref" a "out" je ten, že:
         *     -> při použití "ref" není nutné inicializovat proměnnou ve vnější funkci / metodě ...
         *     -> při použití "out" je nutné inicializovat proměnnou ve vnějši funkci / metodě ...
         * 
         */
        
    }
}