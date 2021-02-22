using System;
using ClassiSet5.Classi5Set;

namespace ClassiSet5
{
    class Program
    {
        public static BankAccaunt BankAccaunt { get; private set; }

        static void Main(string[] args)
        {
            // creo l'ogetto studente
            Student studente = new Student();

            // uso le proprietà di student modificando l'ogetto student
            studente.FullName = "Alice Colella";
            studente.Age = 19;

            Console.WriteLine(studente.Matricola);


         
            studente.Age = 25;
           // studente.Matricola = "800";// da errore perche avevamo solo get 

            Student studente2 = new Student("Monica Rossi",20);
            Console.WriteLine(studente2.Matricola);
            Console.WriteLine(studente.GetFirstName());
            Student.GetFirstName(studente.FullName);
            Student.GetFirstName("Edoardo Bianchi");



            //Clasee Bank
            BankAccaunt accauntEdo = new BankAccaunt("Alice Collella", 3000);
            accauntEdo.Deposit(20, DateTime.Now, "Regalo");
            accauntEdo.Prelievo(600, DateTime.Now, "Affito");

            Console.WriteLine(accauntEdo.GetHistory());

           
            BankAccaunt accaunt2 = new BankAccaunt("Mario Rossi", 1000);
            accaunt2.Deposit(200, DateTime.Now, "Regalo papa");
            Console.WriteLine(accaunt2.GetHistory());



        }
    }
}
