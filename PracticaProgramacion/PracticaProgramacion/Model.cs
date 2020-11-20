namespace PracticaProgramacion
{
    class Model
    {
        public static int CalcularPotencia2(int number)
        {
            int result = 2;
            for (int a = 1; a < number; a++)
            {
                result *= 2;
            }
            return result;
        }

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

        public static int CalcularFactorial(int number)
        {
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
            return result;
        }

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
