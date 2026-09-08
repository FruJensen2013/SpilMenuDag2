namespace spilmenuDag2BasisProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //spilmenu 
            Console.WriteLine("SPILMENU");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Settings");
            Console.WriteLine("3. Highscore");
            Console.WriteLine("4. Credits");
            Console.WriteLine("5. Exit");

            Console. WriteLine("\nPlease select an option (1-5):");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Starting game...");
                    break;
                case "2":
                    Console.WriteLine("Opening settings...");
                    break;
                case "3":
                    Console.WriteLine("Showing highscore...");
                    break;
                case "4":
                    Console.WriteLine("Showing credits...");
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a number between 1 and 5.");
                    break;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
