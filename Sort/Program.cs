using System.Linq.Expressions;

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
            
            return occorrenze;
        }
        private static int ContaStringhe(string input)
        {
            string[] stringArray = input.Split(' ');
            int occorrenze = 0;
            foreach (var occurrence in stringArray)
            {
                bool parsabile = double.TryParse(occurrence, out double stringaParsata);
                if (!parsabile)
                {
                    occorrenze++;
                }
            }
            return occorrenze;
        }

            private static double[] Conversione(string input)
            {
            int stringSize = ContaStringhe(input);
            int intSize = ContaNumeri(input);   
            string[] rejectsArray = new string[stringSize];
            double[] doubleArray = new double[intSize];
            string[] stringArray = input.Split(' ');
            int indexNumber = 0;
            int indexString = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                string stringaDaParsare = stringArray[i];
                bool parsabile = double.TryParse(stringaDaParsare, out double stringaParsata);
                if (parsabile)
                {
                    doubleArray[indexNumber] = stringaParsata;
                    indexNumber++;
                    //Console.WriteLine("Stringa parsata correttamente: " + doubleArray[indexNumber]);

                } else
                {
                    rejectsArray[indexString] = stringaDaParsare;
                    indexString++;
                    Console.WriteLine("Stringa non parsata");
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
            //try
            //{ 
                Console.WriteLine("Paolo, hai digitato questi numeri: ");
                for (int i = 0; i < floatArray.Length; i++)
                {
                    Console.WriteLine(floatArray[i]);
                }
                Console.WriteLine("Adesso te li riordino!");
                Sortaggio(floatArray);
           //}
           //catch (Exception)
           // {
           //     Console.WriteLine("ERRORE FATALISSIMO!! Paolo, non mi rompere l'applicazione. Soltanto numeri, per favore");
           // }
        }
       
    }
}