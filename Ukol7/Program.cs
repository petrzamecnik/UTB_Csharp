using System;

namespace Ukol7
{
    class Student
    {
        // určím proměnné
        public String Jmeno;
        public String Prijmeni;
        public readonly int Id;  // "readonly" slouží aby proměnnou nebylo možné změnit z venčí

        // konstruktor pro proměnnou "id"
        public Student(int id)
        {
            Id = id;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            // zavolám třídu "student" do které přiřadím "Jmeno" a "Prijmeni"
            Student student = new Student(1)
            {
                Jmeno = "Petr",
                Prijmeni = "Zamecnik"
            };
            
            // výpis výsledku
            Console.WriteLine($" id: {student.Id} \n jmeno: {student.Jmeno} \n prijmeni: {student.Prijmeni}");

            // student.Id = 2;
            // Console.WriteLine($" id: {student.Id} \n jmeno: {student.Jmeno} \n prijmeni: {student.Prijmeni}");

        }
    }
}