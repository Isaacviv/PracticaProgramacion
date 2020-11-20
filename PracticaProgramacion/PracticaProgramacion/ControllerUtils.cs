namespace PracticaProgramacion
{
    class ControllerUtils
    {
        /// <summary>
        /// Esta funcion controla que se pase un numero al programa y si no se le pasara al programa cualquier cosa que no sea un numero
        /// se le volveria a pedir un numero al usuario
        /// </summary>
        /// <param name="Message">El texto que debe aparecer para pedir un numero al usuario</param>
        /// <returns>La funcion unicamente devuelve un numero</returns>
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
