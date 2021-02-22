using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiSet5.Classi5Set
{
    public class BankAccaunt
    {
        private static int accountNumberSeed = 1234;
        //Proprietà
        public string Number { get; }
        public string Owner { get; set;}
        public decimal Balance {
            get{
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amout;
                }
                return balance;

            }
        }

        private List<Transaction> allTransactions = new List<Transaction>(); // lista di tipo Transaction

        //Costruttore
        public BankAccaunt(string name, decimal initialBalance)
        {
            Owner = name;

            //Balance = initialBalance;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Deposit(initialBalance, DateTime.Now, "Saldo iniziale");

        }
        //Metodi
        public void Deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount deve essere positivo");
            }
            else
            {
                var deposit = new Transaction(amount, date, note);
                allTransactions.Add(deposit);
            }


        }

        //Prelievo?
        public void Prelievo(decimal amount, DateTime date, string note)
        {
            if (amount<=0)
            {
                Console.WriteLine("Amount deve essere positivo");
                return;
            }
            if (Balance - amount < 0)
            {
                Console.WriteLine("Credito insufficente");
                return;
            }
            var prelievo = new Transaction(-amount, date, note);
            allTransactions.Add(prelievo);
        }
        // avere lo storico delle transazioni
        //List -> List <>1.Creare una classe ad hoc ElementoDelloStorico 2.Tipo Anonimo

        public string GetHistory()
        {
            var storico = new  StringBuilder();
            decimal balance = 0;
            storico.AppendLine("Date\t\tAmount\tBalance\tNote");

            foreach (var item in allTransactions)
            {
                balance = balance + item.Amout;
                storico.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amout}\t{balance}\t{item.Notes}");
               
            }
            return storico.ToString();
        }

    }
}
