using System;
using System.Linq;

namespace CviceniAP1PA
{
    class Program
    {
        static void Main(string[] args)
        {
            // mate pole s prvky jiz serazenymy vzestupne
            // vlozte do pole promennou prvek, tak aby bylo pole opet serazeno, nejvyssi prvek po vlozeni z pole odstrante
            // vase reseni musi byt platne pro ruzne dlouhe pole a ruzne hodnoty prvku

            // priklady:
            // pokud vlozite prvek s hodnotou  3, tak vysledne pole bude mit hodnotu  1, 3, 5, 7,  9, 11, 12
            // pokud vlozite prvek s hodnotou 10, tak vysledne pole bude mit hodnotu  1, 5, 7, 9, 10, 11, 12
            // pokud vlozite prvek s hodnotou  1, tak vysledne pole bude mit hodnotu  1, 1, 5, 7,  9, 11, 12

            // zde napiste reseni
            
            int[] pole = new int[] { 1, 5, 7, 9, 11, 12, 15 };
            int prvek = 3;
            int pomocna;
            

            // výpis původního pole
            Console.WriteLine("Původní pole: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
    
            Console.WriteLine("\n--------------------------");
            
            pole = pole.Concat(new int[] {prvek}).ToArray();  // Do pole přidám proměnnou "prvek"
            
            // seřadím pole 
            for (int j = 0; j < pole.Length - 1; j++)
            {
                for (int i = 0; i < pole.Length - 1; i++)
                {

                    if (pole[i] > pole[i + 1])
                    {
                        pomocna = pole[i + 1];
                        pole[i + 1] = pole[i];
                        pole[i] = pomocna;
                    }
                }
            }

            pole = pole.SkipLast(1).ToArray();  // z pole odstraním nejvyšší prvek 

            // výpis pole po provedení operací
            Console.WriteLine("Nové pole: ");
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
        }
    }
}