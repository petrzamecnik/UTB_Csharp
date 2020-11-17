using System;

namespace CviceniAP1PA
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            char[,] matice = new char[n, n];
            int q = 1; 



            // naplní pole nulama
            for (int row = 0; row < matice.GetLength(0); row++)
            {
                for (int col = 0; col < matice.GetLength(1); col++)
                {
                    matice[row, col] = '0';
                }
            }

            // naplni pole jedničkama
            for (int i = 0; i < matice.GetLength(0) - 1; i++)
            {

                for (int j = 0; j < matice.GetLength(1) - q; j++)
                {
                    matice[i, j] = '1';
                    
                }
                if (q < n - 1)
                {
                    q++;
                }
            }
            
            // vypíše pole
            //Console.WriteLine("------------");
            for (int i = 0; i < matice.GetLength(0); i++)
            {
                //Console.Write("|");
                for (int j = 0; j < matice.GetLength(1); j++)
                {
                    
                    Console.Write(matice[i, j]);
                }
                //Console.Write("|");
                Console.WriteLine();
            }
            //Console.WriteLine("------------");


            
            
            // naplnte matici znaky tak aby nad vedlejsi diagonalou byly znaky '1' a ostatni znaky byly '0'
            // Reseni musi byt platne pro libovolne hodnoty n > 0

            /* 
             * znaky matice potom vypiste na konzoli, tak aby vysup byl nasledujici:
             * 
       
            1111111110
            1111111100
            1111111000
            1111110000
            1111100000
            1111000000
            1110000000
            1100000000
            1000000000
            0000000000
            */
        }
    }
}