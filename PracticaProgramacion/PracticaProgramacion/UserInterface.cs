namespace PracticaProgramacion
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Black;
            System.Console.ForegroundColor = System.ConsoleColor.Blue;
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú Principal");
            System.Console.WriteLine("----------------");
            System.Console.ResetColor();
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatoria de un numero");
            System.Console.WriteLine("3) Calcular el factorial de un numero");
            System.Console.WriteLine("4) Saber si un numero es primo");
            System.Console.WriteLine("5) Imprimir la serie de fibonacci");
            System.Console.WriteLine("0) Salir del programa");
        }

        public static void PrintPotencia2Menu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Cyan;
            System.Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Potencia en base 2");
            System.Console.WriteLine("--------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Calcular 2 elevado a cualquier numero");
        }

        public static void PrintSumatorioMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Gray;
            System.Console.ForegroundColor = System.ConsoleColor.DarkCyan;
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Sumatorio de numeros");
            System.Console.WriteLine("-----------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Calcular el sumatoria de cualquier numero");
        }

        public static void PrintFactorialMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Yellow;
            System.Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Factorial de un numero");
            System.Console.WriteLine("------------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Calcular el factorial de cualquier numero");
        }

        public static void PrintIsPrimeMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.Yellow;
            System.Console.ForegroundColor = System.ConsoleColor.DarkRed;
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Numeros primos");
            System.Console.WriteLine("----------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Saber si un numero es o no primo");
        }

        public static void PrintFibonacciMenu()
        {
            System.Console.BackgroundColor = System.ConsoleColor.DarkCyan;
            System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("-----------------------");
            System.Console.WriteLine("Sucesion de Fibonacci");
            System.Console.WriteLine("-----------------------");
            System.Console.ResetColor();
            System.Console.WriteLine("Mostrar la sucesion de fibonacci hasta cualquier numero");
        }

        /// <summary>
        /// Esta funcion controla que El usuario le pase un numero al programa
        /// </summary>
        /// <returns>Si el usuario le pasa cualquier cosa que no sea un numero al programa la funcion devuelve un -1</returns>
        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            try
            {
                int result = System.Convert.ToInt32(option);
                return result;
            }
            catch
            {
                return -1;
            }
        }
    }
}
