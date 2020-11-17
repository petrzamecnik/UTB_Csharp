using System;

namespace Ukol6
{
    
    class Pocitadlo
    {
        
        public int a;  // proměnná

        public Pocitadlo(int cislo)  // konstruktor -> přijme proměnnou z externí třídy a dosadí ji za lokálni proměnnou
        {
            a = cislo;
        }
        

        public int VratPocet()  // metoda, vrací hodnotu "a"
        {
            return a;
        }

        public void Zvys()  // metoda, zvýší proměnnou "a"
        {
            a++;
        }

        public void Vynuluj()  // metoda, vynuluje proměnnou "a"
        {
            a = 0;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Pocitadlo pocitadlo = new Pocitadlo(10);
            
            Console.WriteLine(pocitadlo.VratPocet());
            
            pocitadlo.Zvys();
            Console.WriteLine(pocitadlo.VratPocet());
            
            pocitadlo.Zvys();
            Console.WriteLine(pocitadlo.VratPocet());

            pocitadlo.Vynuluj();
            Console.WriteLine(pocitadlo.VratPocet());
        }
    }
}