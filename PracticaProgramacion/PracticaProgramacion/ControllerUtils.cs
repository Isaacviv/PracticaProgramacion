namespace PracticaProgramacion
{
    class ControllerUtils
    {
        public static int ReadIntegerInput(string Message)
        {
            while (true)
            {
                System.Console.WriteLine(Message);
                string number = System.Console.ReadLine();
                try
                {
                    int result = System.Convert.ToInt32(number);
                    return result;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("La entrada que has introducido es incorrecta");
                }
            }
        }
    }
}
