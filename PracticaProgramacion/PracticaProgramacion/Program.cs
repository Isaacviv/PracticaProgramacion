namespace PracticaProgramacion
{
    class Program
    {
        
        public static void LaunchPotencia2Menu()
        {
            int number = ControllerUtils.ReadIntegerInput("Dime el exponente:");
            for (int a = 0; a < number; a++)
            {
                int result = 2 * 2;
            }
            System.Console.WriteLine();
        }

        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 1)
                {
                    LaunchPotencia2Menu();
                }
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("La entrada que has introducido es incorrecta");
                }
                else if (option == 0)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
        
    }
}
