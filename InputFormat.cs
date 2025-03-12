using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense_tracker
{
    internal class InputFormat
    {
        int id;
        string description;
        double amount;
        int month;
        public InputFormat(string[] command)
        {
           switch (command[0])
            {
                case "add":
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
                    }
                    break;
                case "delete":
                    if (command[1] == "--id")
                    {
                        id = int.Parse(command[2]);
                    }
                    break;
                case "summary":
                    if (command.Length>1 && command[1] == "--month")
                    {
                        month = int.Parse(command[2]);
                    }
                    else
                    {
                        month = -1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    
}
