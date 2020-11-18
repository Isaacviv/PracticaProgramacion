namespace PracticaProgramacion
{
    class Model
    {
        public static bool IsPrime(int number)
        {
            int aux = 1;
            for (int i = 0; i < number; i++)
            {
                int aux2 = 1;
                for (int j = 0; j < i; j++)
                {
                    aux2 += 1;
                }
                aux /= aux2;
            }
            if (aux == 1)
                return true;
            else
                return false;
        }
    }
    

}
