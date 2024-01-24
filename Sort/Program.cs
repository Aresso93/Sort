namespace Sort

{
    internal class Program
    {
        private static float[] Conversione(string input)
        {
            string[] stringArray = input.Split(' ');
            float[] floatArray = new float[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                floatArray[i] = float.Parse(stringArray[i]);
            }
            if (floatArray.Length != 10)
            {
                throw new ArithmeticException("10 numeri, per cortesia. Né più né meno!");
            } else
            {
            return floatArray;

            }
        }
        static void Sortaggio(float[] arraySortevole)
        {
            Console.WriteLine("Eccoli sortati!");

            for (int i = 0; i < arraySortevole.Length; i++)
            {
                for (int j = i + 1; j < arraySortevole.Length; j++)
                {
                    if (arraySortevole[i] > arraySortevole[j])
                    {
                        float sortevole = arraySortevole[j];
                        arraySortevole[j] = arraySortevole[i];
                        arraySortevole[i] = sortevole;
                    }
                }
                Console.WriteLine(arraySortevole[i]);
            }
        }
        static void Funzione()
        {
            Console.WriteLine("Dammi 10 numeri (positivi o negativi) separati da spazi");
                string input = Console.ReadLine();
                var floatArray = Conversione(input.Replace(".", ","));
            try
            {
                
                Console.WriteLine("Paolo, hai digitato questi numeri: ");
                for (int i = 0; i < floatArray.Length; i++)
                {
                    Console.WriteLine(floatArray[i]);
                }
                Console.WriteLine("Adesso te li riordino!");
                Sortaggio(floatArray);
            }
           catch (Exception)
            {
                Console.WriteLine("ERRORE FATALISSIMO!! Paolo, non mi rompere l'applicazione. Soltanto numeri, per favore");
            }
        }
        static void Main(string[] args)
        {
            Funzione();
        }
    }
}


//int[] arraySortevole = { 400, 10, 25, 6, 43, 0, 3, 1300, 7, 12 };
//conversione(userInput);
//string[] userInputArray = userInput.Split(' ');

//for (int i = 0; i < userInputArray.Length; i++)
//{
//    Console.WriteLine(Convert.ToInt32(userInputArray[i]));
//}