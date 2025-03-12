namespace expense_tracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0) {
                Console.WriteLine("Please provide a command");
                return;
            }
            args[0] = args[0].ToLower();

            InputFormat inputAttributs = new InputFormat(args);

            string command = args[0];

            switch (command)
            { 
                case "add":
                    Console.WriteLine("Add command");
                    break;
                case "list":
                    Console.WriteLine("List command");
                    break;
                case "delete":
                    Console.WriteLine("Delete command");
                    break;
                case "summary":
                    Console.WriteLine("Summary command");
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
    }
}
