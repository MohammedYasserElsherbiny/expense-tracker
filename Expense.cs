using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_tracker
{
    internal class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }

        public Expense(int id, string description, double amount, DateTime date)
        {
            Id = id;
            Description = description;
            Amount = amount;
            Date = date;
        }

        public Expense(int id, string description, double amount)
        {
            Id = id;
            Description = description;
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}
