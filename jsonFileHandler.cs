using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace expense_tracker
{
    internal class jsonFileHandler
    {
        private string _filePath;

        public jsonFileHandler(string fileName)
        {
            _filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        public List<Expense> readFromFile()
        {
            string jsonData = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Expense>>(jsonData,new JsonSerializerOptions { IncludeFields = true }) ?? new List<Expense>();
        }

        public void WriteToFile(List<Expense> expenses)
        {
            string jsonData = JsonSerializer.Serialize(expenses, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, jsonData);
        }
    }
}
