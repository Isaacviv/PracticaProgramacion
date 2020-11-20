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
                int result = 2;
                for (int a = 1; a < number; a++)
                {
                    result *= 2;
                }
                System.Console.WriteLine("El resultado es: " + result);
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
                int result = 0;
                for (int a = 0; a < number; a++)
                {
                    int sumatorio = 0;
                    for (int b = 0; b < a + 1; b++)
                    {
                        sumatorio += 1;
                    }
                    result += sumatorio;
                }
                System.Console.WriteLine("El resultado es: " + result);
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
                int result = 1;
                for (int a = 0; a < number; a++)
                {
                    int factorial = 0;
                    for (int b = 0; b <= a; b++)
                    {
                        factorial += 1;
                    }
                    result *= factorial;
                }
                System.Console.WriteLine("El resultado es: " + result);
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
                Model.Fibonacci(number);
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
