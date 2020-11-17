﻿using System;
using System.Linq;

namespace Ukol3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = {1, 9, 4, 7, 6, 9, 2};
            int x = 0;
            int prvek = 7;
            string puvodni_pole = "";
            string nove_pole = "";

            
            // najdete a vypiste na konzoli index prvku s hodnotou 7 v poli (reseni: index 3)
            for (int i = 0; i < pole.Length - 1; i++)
            {
                if (pole[i] == prvek)
                {
                    Console.WriteLine($"Index prvku s hodnotou {prvek} je: {i}");
                }
            }


            // seradte hodnoty prvku v poli vzestupne pomoci algoritmu Bubble Sort a vypiste serazene hodnoty na konzoli" 
            foreach (var _index in pole)
            { 
                puvodni_pole += _index + ", ";
               
            }
            puvodni_pole = puvodni_pole.Remove(puvodni_pole.Length - 2);
            Console.Write($"Původní pole:  {{ {puvodni_pole} }} ");

            for (int i = 0; i < pole.Length - 1; i++)
            {
                for (int j = 0; j < pole.Length - 1; j++)
                {
                    if (pole[j] > pole[j + 1])
                    {
                        x = pole[j];  // prvek pole[j] si uložím do dočasné proměnné x
                        pole[j] = pole[j + 1];  // prvek "vlevo" dosadím za prvek "vpravo"
                        pole[j + 1] = x;  // prvek "vpravo" dosadím za prvek "vlevo"
                    }
                    
                }
            }
            
            foreach (var _index in pole)
            { 
                nove_pole += _index + ", ";
               
            }

            nove_pole = nove_pole.Remove(nove_pole.Length - 2);
            Console.Write($"\nSeřazené pole: {{ {nove_pole} }} ");


        }
    }
}