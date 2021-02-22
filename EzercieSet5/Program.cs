using System;
using System.Collections;
using System.Collections.Generic;

namespace EzercieSet5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esercizio2();
            //Casting();
            // Enumerazione();

            //Write("Buongiorno");
            int x = Sum(1, 2);
            int result;
            Sum(1, 2, out result);
            bool y = Sum(1, 2, out result);
            bool z = Sum(1, 2, out _);//ignoriamo il valore di ritorno dato da out 
            bool q = Sum(1, 2, out var a);

            //Test(in result);
            Test(ref result);
            //Parametri Opzionali
            int i = 10, j = 12, k = 8;
            int res = Sum(i);
            res = Sum(i, j);
            res = Sum(i, j, k);

        }
        static void Esercizio1()
        {
            int age = 18;// contiene il valor 1
                         // age = null; da errore: vaue type non possono essere nli
            bool y = true;//contiene il valore true
            string s1 = "Hello";// si unta ad u area d memoria
            string s2 = null;// string é refrence type->poso usare null. 
            string s3 = "";// punta ad un area di memoria che contiene""

            object obg1 = new object();// crea un nuovo ogetto:indirizz di memoria
            object obg2 = null;// non pnta a nula
            object obg3 = obg1;// obg3 si riferisce alla stessa instanza di obg1
            // iizilizzare
            int i = 1;
            int j = 2;

            int i1 = 1, j1 = 2, h1 = 3;
            // dichirazone
            string a, b, c;

            //costanti
            const double pi = 3.1416;
            //pi = 3.14; da errore 

            // Type inference


            int numero = 120;// no type inference: dichiarazione esplicita del tipo
            var numero2 = 30;// type inference : il compilatore che capisce il tipo di variabile in base al valore assegnato

            string nome = "Alie";









        }
        static void Esercizio2()
        {
            //bool
            bool x, y = true;

            x = true;
            x = !y;// false
            x = (18 > 9);// true

            //ineri
            int i, j, k;
            i = 2;
            j = i + 1;//+ - * / %
            k = i * 2;

            bool isOdd;
            isOdd = (k % 2) != 0;

            int num = 0;
            num = 2 * 3 + 4 * 5;
            num = 2 * (3 + 4) * 5;

            // stringhe

            string hello;
            hello = "Hello" + "World";//Contatenazione


        }
        static void Casting()
        {
            int x = 0;
            byte y = 100;
            byte z;

            x = y;  //Casting inplicito: range di valori byte contenuto in range valori int
            x = 1000;
            y = (byte)x; //Compilazione non da errori-> Runtime da valori un po a caso
            z = (byte)x;




        }
        static void Array()
        {
            string[] HelloWorld = new string[3];
            HelloWorld[0] = "Hello";
            HelloWorld[1] = "World";
            HelloWorld[2] = HelloWorld[0] + HelloWorld[1];

            int[] interi = { 1, 2, 3 };
            int z = interi[1];


            //Type Inference
            var x1 = new[] { 0, 1, 2, 3 };// Array int[]
            var x2 = new[] { 0, 0.5, 1, 1.5 };// Arrat doible[]
            var x3 = new[] { "Alice", "Collela" };
            // Collection
            var x4 = new ArrayList() { 1, "Alice", 2 };// tipizzazione debole
            var lista = new List<string>() { "Alice", "Collela" };
            var x5 = x4[1];

            //Enum:

        }

        enum Gender
        {
            Male,// vale 0(int)
            Famale// vale 1(int)
        }

        enum DayOfWeek : byte
        {
            Lunedi = 1,
            Martedi = 2,
            Mercoledi = 3,
        }
        static void Enumerazione()
        {
            Gender person = Gender.Male;
            DayOfWeek giorno = DayOfWeek.Martedi;
            var giorno2 = DayOfWeek.Mercoledi;

            //Casting 
            int y = 0, z = 2;//y:0

            y = (int)Gender.Famale;//y:1
            Console.WriteLine(y);
            y = (int)person;//y:0
            y = 1;
            person = (Gender)y;// person:female

            person = (Gender)y;// valori interi senza il titolo
            Console.WriteLine(person);


        }

        //Passagio per valore
        // Procedure -> non hanno il valore del ritorno
        static void Write(string text)
        {
            Console.WriteLine(text);
        }

        //Funzione -> ha un valore di ritorno

        static int Sum(int x, int y)
        {
            return x + y;
        }
        //passagio per valore + passagio per riferimento in uscita
        static bool Sum(int x, int y, out int result)
        {
            result = x + y;
            return true;
        }
        //Passagio per riferemento in ingresso
        //static void Test(in int x)
        //{
        //    Console.WriteLine(x);
        //}

        static void Test(ref int x)
        {
            x = 11;
            Console.WriteLine(x);
        }
        static int Sum(int x, int y = 0, int z = 0)
        {
            return x + y + z;
        }
        static void Esercizio3()
        {
            // IsOdd = true se dispari, false se pari
            int i = 2;
            bool isOdd = (i % 2 == 1) ? true : false;
            string x = null;
            string y = "Ciao";
            string z = x ?? y;
        }
        static void Esercizio4()
        {
            // Array di interi e faccoamo la somma di tutti gli elementi contenuti nell'array
            //obbligotorio :while
            int[] x = { 1, 2, 3, 4, 5, 6, };
            int resultat = 0;
            int i = 0;

            while (i < x.Length)
            {
                resultat += x[i];
                i++;
            }
            resultat = 0;
            // for 
            for (i = 0; i < x.Length; i++)
            {
                resultat += x[i];
            }
            //Foreach
            foreach (int item in x)
            {
                resultat += item;
            }
        }
    }
}
