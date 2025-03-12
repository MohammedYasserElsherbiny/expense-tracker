using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_tracker
{
    internal class expenseOpreations
    {
        public void Add(string description, double amount)
        {
            List<Expense> expenses = new jsonFileHandler("expenses.json").readFromFile();
            int id = expenses.Count > 0 ? expenses.Max(e => e.Id) + 1 : 1;
            expenses.Add(new Expense(id, description, amount));
            Console.WriteLine("Expense added successfully");
            new jsonFileHandler("expenses.json").WriteToFile(expenses);
        }
    }
}
