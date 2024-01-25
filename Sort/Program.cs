namespace Sort

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funzione();
        }

        private static int ContaNumeri(string input)
        {
            string[] stringArray = input.Split(' ');
            int occorrenze = 0;
            foreach(var occurrence in stringArray)
            {
                double stringaParsata;
                bool parsabile = double.TryParse(occurrence, out stringaParsata);
                if (parsabile)
                {
                    occorrenze++;
                } 
            }
            Console.WriteLine("Numero di numeri " + occorrenze);
            return occorrenze;
        }
        private static int ContaStringhe(string input)
        {
            string[] stringArray = input.Split(' ');
            int occorrenze = 0;
            foreach (var occurrence in stringArray)
            {
                double stringaParsata;
                bool parsabile = double.TryParse(occurrence, out stringaParsata);
                if (!parsabile)
                {
                    occorrenze++;
                }
            }
            Console.WriteLine("Numero di stringhe " + occorrenze);
            return occorrenze;
        }

        private static double[] Conversione(string input)
        {
            string[] stringArray = input.Split(' ');
            string[] rejectsArray = new string[ContaStringhe(input)];
            double[] doubleArray = new double[ContaNumeri(input)];

            for (int i = 0; i < doubleArray.Length; i++)
            {
                double stringaParsata;
                bool parsabile = double.TryParse(stringArray[i], out stringaParsata);
                if (parsabile)
                {
                    doubleArray[i] = stringaParsata;    
                    Console.WriteLine(doubleArray[i]);  
                } else
                {
                    
                    Console.WriteLine("AAAA");
                }
            }
            
            return doubleArray; 
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