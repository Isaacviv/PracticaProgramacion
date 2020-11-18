namespace PracticaProgramacion
{
    class UserInterface
    {
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("Menú Principal");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatoria de un numero");
            System.Console.WriteLine("3) Calcular el factorial de un numero");
            System.Console.WriteLine("4) Saber si un numero es primo");
            System.Console.WriteLine("5) Imprimir la serie de fibonacci");
            System.Console.WriteLine("0) Salir del programa");
        }

        public static void PrintPotencia2Menu()
        {
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Potencia en base 2");
            System.Console.WriteLine("--------------------");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
