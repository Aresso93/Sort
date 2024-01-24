namespace Sort
            //dato il mio array scrivo una funzione che scambia i due elementi che non sono a posto
            //int a = 1
            //int b = 2
            //per rendere a = b e b = a
            //int c = a
            //int a = b
            //int b = c
{
    internal class Program
    {
            private static int[] Conversione(string input)
            {
                string[] stringArray = input.Split(' ');
                int[] intArray = new int[stringArray.Length];
                for (int i = 0; i < stringArray.Length; i++)
                {
                    intArray[i] = int.Parse(stringArray[i]);
                    //Console.WriteLine(int.Parse(stringArray[i]));
                }
                return intArray;
            }
            static void sortaggio(int[] arraySortevole)
            {
                Console.WriteLine("Eccoli sortati!");
                //int[] arraySortevole = { 400, 10, 25, 6, 43, 0, 3, 1300, 7, 12 };
                for (int i = 0; i < arraySortevole.Length; i++)
                {
                    for (int j = i + 1; j < arraySortevole.Length; j++)
                    {
                        if (arraySortevole[i] > arraySortevole[j])
                        {
                            int sortevole = arraySortevole[j];
                            arraySortevole[j] = arraySortevole[i];
                            arraySortevole[i] = sortevole;
                        }

                    }

                    Console.WriteLine(arraySortevole[i]);

                }

            }
        static void Main(string[] args)
        {

            Console.WriteLine("Dammi 10 numeri interi separati da spazi");
            string input = Console.ReadLine();
            Console.WriteLine("Paolo, hai digitato questi numeri: ");
            var intArray = Conversione(input);
            Console.WriteLine("Adesso te li riordino!");
            
            //conversione(userInput);
            //string[] userInputArray = userInput.Split(' ');

            //for (int i = 0; i < userInputArray.Length; i++)
            //{
            //    Console.WriteLine(Convert.ToInt32(userInputArray[i]));
            //}


            sortaggio(intArray);
        }
    }
}
