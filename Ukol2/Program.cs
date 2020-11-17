using System;


namespace Ukol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[] { 1, 9, 4, 5, 6, 9, 2 };
            int a = 0;
            int suma = 0;

            // vypiste na konzoli hodnotu prvniho prvku
            Console.WriteLine($"Hodnota prvního prvku: {pole[0]}");  // nultý index -> první prvek

            // vypiste na konzoli hodnotu posledniho prvku
            Console.WriteLine($"Hodnota posledního prvku v poli: {pole[pole.Length - 1]}");
            
            // najdete a vypiste hodnotu nejvyssiho prvku v poli
            foreach (var prvek in pole)
            {
                if (prvek > a)
                    a = prvek;
                
            }
            Console.WriteLine($"Nejvyšší prvek pole: {a}");

            
            // najdete a vypiste sumu prvku v poli
            foreach (var prvek in pole)
            {
                suma += prvek;
            }
            Console.WriteLine($"Suma prvků v poli: {suma}");
        }
    }
}