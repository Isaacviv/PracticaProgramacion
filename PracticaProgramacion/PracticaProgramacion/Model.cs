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
    }
    

}
