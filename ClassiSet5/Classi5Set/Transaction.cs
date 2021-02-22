using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiSet5.Classi5Set
{
    public class Transaction
    {
        //Proprietà
        public decimal Amout { get; }
        public DateTime Date { get; }
        public string Notes { get; }
        public Transaction(decimal amount, DateTime date, string note)
        {
            Amout = amount;
            Date = date;
            Notes = note;
        }
}
}
