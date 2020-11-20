namespace PracticaProgramacion
{
    class Model
    {
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

        public static void Fibonacci(int number)
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
