using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_tracker
{
    internal class InputFormat
    {
        int id {  get; set; }
        string description { get; set; }
        double amount { get; set; }
        int month { get; set; }
        string catagory { get; set; }
        public InputFormat(string[] command)
        {
            month = -1;
           
            for (int i = 0; i < command.Length - 1; i++)
            {
                if(command[i] == "--description")
                {
                    description = command[i + 1];
                }
                else if (command[i] == "--amount")
                {
                    amount = double.Parse(command[i + 1]);
                }
                else if(command[i] == "--id")
                {
                    id = int.Parse(command[2]);
                }
                else if(command[i] == "--month")
                {
                    month = int.Parse(command[2]);
                }
                else if( command[i] ==)
            }
                    
        }
    }
    
}
