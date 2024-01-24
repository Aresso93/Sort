using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sort

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funzione();
        }

        private static int CountOccurrences(string input)
        {
            string[] stringArray = input.Split(' ');
            //devo contare quante cose mi tornano true e quante false
            foreach(var occurrence in stringArray)
            {
                double stringaParsata;
                bool parseEseguito = double.TryParse(occurrence, out stringaParsata);
                if (parseEseguito)
                {
                    Console.WriteLine($"Converted '{occurrence}' to {stringaParsata}.");
                    Console.WriteLine(parseEseguito);
                    
                } else
                {
                    Console.WriteLine($"Attempted conversion of '{occurrence ?? "<null>"}' failed.");
                }
            }
            return stringArray.Length;  
        }
        
        private static double[] Conversione(string input)
        {
            string[] stringArray = input.Split(' ');
            string[] rejectsArray = new string[CountOccurrences(input)];
            double[] doubleArray = new double[stringArray.Length - rejectsArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                double stringaParsata;
                bool parseEseguito = double.TryParse(stringArray[i], out stringaParsata);
                if (parseEseguito)
                {
                    doubleArray[i] = stringaParsata;    
                    Console.WriteLine(doubleArray[i]);  
                } else
                {
                    rejectsArray[i] = stringArray[i];
                    Console.WriteLine(rejectsArray[i]);
                }
            }

            return doubleArray; 

            //double[] doubleArray = new double[stringArray.Length];
            //string[] rejectsArray = new string[stringArray.Length];
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    double stringaParsata;
            //    bool parseEseguito = double.TryParse(stringArray[i], out stringaParsata);
            //    if (parseEseguito)
            //    {
            //        Console.WriteLine($"Stringa convertita: '{stringArray[i]}' in {stringaParsata}.");
            //        doubleArray[i] = stringaParsata;

            //    }
            //    else
            //    {
            //        rejectsArray[i] = stringArray[i];
            //        Console.WriteLine("Stringa non convertita: " + rejectsArray[i]);
            //        doubleArray[i] = stringaParsata;
            //    }
            //}
            //return doubleArray;
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