namespace Sort

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funzione();
        }
        private static double[] Conversione(string input)
        {
            string[] stringArray = input.Split(' ');
            double[] floatArray = new double[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                double stringaParsata;
                bool parseEseguito = double.TryParse(stringArray[i], out stringaParsata);
                if (parseEseguito)
                {
                    Console.WriteLine($"Convertito '{stringArray[i]}' in {stringaParsata}.");
                    floatArray[i] = stringaParsata;
                }
                else
                {
                    Console.WriteLine($"Non sono riuscito a convertire '{stringArray[i] ?? "<null>"}', mi dispiace. Dammi solo numeri separati da spazi.");
                }
                //floatArray[i] = float.Parse(stringArray[i]);
            }
            return floatArray;
        }
        static void Sortaggio(double[] arraySortevole)
        {
            Console.WriteLine("Eccoli sortati!");

            for (int i = 0; i < arraySortevole.Length; i++)
            {
                for (int j = i + 1; j < arraySortevole.Length; j++)
                {
                    if (arraySortevole[i] > arraySortevole[j])
                    {
                        double sortevole = arraySortevole[j];
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
                string input = Console.ReadLine()!;
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
       
    }
}