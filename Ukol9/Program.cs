using System;

namespace Ukol9
{
    class Student
    {
        public String Jmeno;
        public String Prijmeni;

        public Student(String jm, String pr)
        {
            this.Jmeno = jm;
            this.Prijmeni = pr;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // určení hodnot
            int cisloA = 10;  // hodnotový typ
            int cisloB = 20;  // hodnotový typ
            Student studentA = new Student("Petr", "Zamecnik");  // referenční typ
            Student studentB = new Student("Petula", "Zamecek");  // referenční typ

            
            
            // vypis1
            Console.WriteLine(cisloA);
            Console.WriteLine(cisloB);
            Console.WriteLine($"Jmeno: {studentA.Jmeno}\n" +
                              $"Prijmeni: {studentA.Prijmeni}");
            Console.WriteLine($"Jmeno: {studentB.Jmeno}\n" +
                              $"Prijmeni: {studentB.Prijmeni}");

            
            
            // zmena hodnot
            cisloA = cisloB;
            studentA = studentB;
            
            
            
            
            // vypis 2
            Console.WriteLine("--------------------------------");
            Console.WriteLine(cisloA);
            Console.WriteLine(cisloB);
            
            Console.WriteLine($"Jmeno: {studentA.Jmeno}\n" +
                              $"Prijmeni: {studentA.Prijmeni}");
            Console.WriteLine($"Jmeno: {studentB.Jmeno}\n" +
                              $"Prijmeni: {studentB.Prijmeni}");
            
            
           /*
            *    POPIS
            * čísla A, B budou 2 různé čísla se stejnou hodnotou
            * studenti (StudentA, StudentB) budou jeden a ten samý objekt
            *     studentA = studentB -> studentA je reference
            * 
            *
            * 
            */
            



        }
    }
}