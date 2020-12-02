namespace PracticaProgramacion
{
    class Program
    {
        
        public static void LaunchPotencia2Menu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintPotencia2Menu();
                int number = ControllerUtils.ReadIntegerInput("Dime el exponente:");
                System.Console.WriteLine("El resultado es: " + Model.CalcularPotencia2(number));
                System.Console.WriteLine("Pulsa cualquier tecla para volver al menu principal");
                System.Console.ReadLine();
                break;
            }
        }
        public static void LaunchSumatorioMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintSumatorioMenu();
                int number = ControllerUtils.ReadIntegerInput("Dime el numero del que quieres que realice el sumatorio");
                System.Console.WriteLine("El resultado es: " + Model.CalcularSumatorio(number));
                System.Console.WriteLine("Pulsa cualquier tecla para volver al menu principal");
                System.Console.ReadLine();
                break;
            }
        }

        public static void LaunchFactorialMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintFactorialMenu();
                int number = ControllerUtils.ReadIntegerInput("Dime el numero del que deseas saber el factorial");
                System.Console.WriteLine("El resultado es: " + Model.CalcularFactorial(number));
                System.Console.WriteLine("Pulsa cualquier tecla para volver al menu principal");
                System.Console.ReadLine();
                break;
            }
        }

        public static void LaunchIsPrimeMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintIsPrimeMenu();
                int number = ControllerUtils.ReadIntegerInput("Dime el numero del que quieres saber si es primo");
                if (Model.IsPrime(number) == false)
                {
                    System.Console.WriteLine("El numero que has escrito no es primo");
                }
                else
                {
                    System.Console.WriteLine("El numero que has escrito es primo");
                }
                System.Console.WriteLine("Pulsa cualquier tecla para volver al menu principal");
                System.Console.ReadLine();
                break;
            }
        }

        public static void LaunchFibonacciMenu()
        {
            while (true)
            {
                System.Console.Clear();
                UserInterface.PrintFibonacciMenu();
                int number = ControllerUtils.ReadIntegerInput("Dime hasta que numero quiers que te muestre la sucesion de fibonacci");
                Model.SucesionFibonacci(number);
                System.Console.WriteLine("Pulsa cualquier tecla para volver al menu principal");
                System.Console.ReadLine();
                break;
            }
        }

        public static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 1)
                    LaunchPotencia2Menu();
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("La entrada que has introducido es incorrecta");
                }
                else if (option == 0)
                    break;
                else if (option == 2)
                    LaunchSumatorioMenu();
                else if (option == 3)
                    LaunchFactorialMenu();
                else if (option == 4)
                    LaunchIsPrimeMenu();
                else if (option == 5)
                    LaunchFibonacciMenu();
            }
        }
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
        
    }
}
