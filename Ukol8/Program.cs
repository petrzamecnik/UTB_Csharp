using System;

namespace Ukol8
{
    class Trida
    {
        public int cislo;

        public Trida(int cislo)
        {
            this.cislo = cislo;
        }
    }


    struct Struktura
    {
        public int cislo;

        public Struktura(int cislo)
        {
            this.cislo = cislo;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Trida t1 = new Trida(1);
            Trida t2 = t1;
            t2.cislo = 2;

            Struktura s1 = new Struktura(1);
            Struktura s2 = s1;
            s2.cislo = 2;

            Console.WriteLine("Třída: ");
            Console.WriteLine($"{t1.cislo} {t2.cislo}");
            Console.WriteLine("Struktura");
            Console.WriteLine($"{s1.cislo} {s2.cislo}");
            
            // Vysvetlete proc je u prakticky stejneho klientskeho kodu vysledek jiny pro strukturu a jiny pro tridu

            // Třídu můžeme brát jako referenční typ, takže se hodnota změní u obou výstupů při změně jedné hodnoty,
            // všechny referenční typy jsou uloženy v heapu
            
            // Strukturu považujeme za hodnotový typ -> ukládá si každou hodnotu do vlastního místa v paměti,
            // takže při změně jedné hodnoty, druhá zůstane stejná
            // všechny hodnotové typy jsou uloženy ve stacku

        }
    }
}