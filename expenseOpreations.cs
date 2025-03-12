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

        public void list()
        {
            List<Expense> expenses = new jsonFileHandler("expenses.json").readFromFile();
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses found");
            }
            else
            {
                foreach (var expense in expenses)
                {
                    Console.WriteLine(expense.ToString());
                }
            }
        }

        public void delete(int id)
        {
            List<Expense> expenses = new jsonFileHandler("expenses.json").readFromFile();
            var expense = expenses.FirstOrDefault(e => e.Id == id);
            if (expense == null)
            {
                Console.WriteLine("No expense found with the given id");
            }
            else
            {
                expenses.Remove(expense);
                new jsonFileHandler("expenses.json").WriteToFile(expenses);
                Console.WriteLine("Expense deleted successfully");
            }
        }

        public void summary(int month)
        {
            List<Expense> expenses = new jsonFileHandler("expenses.json").readFromFile();
            if (month == -1)
            {
                Console.WriteLine("Total expenses: " + expenses.Sum(e => e.Amount));
            }
            else
            {
                Console.WriteLine("Total expenses for month " + month + ": " + expenses.Where(e => e.Date.Month == month).Sum(e => e.Amount));
            }
        }

    }
}
