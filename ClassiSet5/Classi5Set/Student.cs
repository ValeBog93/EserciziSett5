using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiSet5.Classi5Set
{
    public class Student
    {
        //// Campi 
        //private string firstName;
        ////Proprietà
        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}


        //Proprietà
        public string FullName { get; set; }

        public int Age { get; set; }

        public string Matricola { get; }

        private static int MatricolaSeed = 800000;

        //Costruttore di base che non acceta nessun parametro
        public Student()
        {
            this.FullName = string.Empty; 
            Age = 18;
            Matricola = MatricolaSeed.ToString();
            MatricolaSeed++;
        }

        //Costruttore n2(OverLoad)

        public Student(string name, int age)
        {
            FullName = name;
            Age = age;
            Matricola = MatricolaSeed.ToString();
            MatricolaSeed++;
        }

        //Comportamento
        //Metodi  d'istanza 
        public string GetFirstName()
        {
            return FullName.Split(" ")[0]; //[0] prendo il termine con indice 0 (nel nostro es prendo solo Alice)
        }

        //Metodo Statico
        public static string GetFirstName(string name)
        {
            return name.Split(" ")[0];
        }
    }
}
