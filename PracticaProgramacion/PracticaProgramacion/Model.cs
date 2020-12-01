namespace PracticaProgramacion
{
    class Model
    {
        /// <summary>
        /// Esta funcion sirve para poder calcular 2 elevado a cualquier numero entero
        /// </summary>
        /// <param name="number">El numero que el usuario quiere que se eleve el 2</param>
        /// <returns>Devuelve el resultado de 2 elevado a cualquier numero entero</returns>
        public static int CalcularPotencia2(int number)
        {
            int result = 2;
            for (int a = 1; a < number; a++)
            {
                result *= 2;
            }
            return result;
        }
        /// <summary>
        /// Esta funcion realiza el sumatorio de cualquier numero entero
        /// </summary>
        /// <param name="number">El numero del que se desea calcular el sumatorio</param>
        /// <returns>Devuelve el resultado del sumatorio</returns>
        public static int CalcularSumatorio(int number)
        {
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
            return result;
        }
        /// <summary>
        /// Esta funcion realiza el factorial de cualquier numero entero
        /// </summary>
        /// <param name="number">El numero del que se desea calcular el factorial</param>
        /// <returns>Devuelve el resultado del factorial</returns>
        public static long CalcularFactorial(long number)
        {
            long result = 1;
            for (long a = 0; a < number; a++)
            {
                long factorial = 0;
                for (long b = 0; b <= a; b++)
                {
                    factorial += 1;
                }
                result *= factorial;
            }
            return result;
        }
        /// <summary>
        /// Esta funcion calcula si un numero es o no primo
        /// </summary>
        /// <param name="number">El numero del que se desea saber si es o no primo</param>
        /// <returns>Devuelve un boolean diciendo si el numero es o no primo</returns>
        public static bool IsPrime(int number)
        {
            int i = 2;
            while (i < number)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        /// <summary>
        /// Esta funcion escribe la sucesion de fibonacci
        /// </summary>
        /// <param name="number">El numero hasta el cual se desea ver la sucesion de fibonacci</param>
        public static void SucesionFibonacci(int number)
        {
            int number1 = 0;
            int number2 = 1;
            for (int i = 0; i < number; i++)
            {
                System.Console.Write(number1 + ", ");
                number1 = number2 - number1;
                number2 = number1 + number2; 
            }
        }
    }
    

}
