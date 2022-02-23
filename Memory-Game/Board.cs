

namespace Memory_Game
{
    class Board 
    {
        readonly Random random = new Random();

        public int length;
        public string[] wordsArr;
        public int[] rowBCoordinates;

        public Board(string[] eWords, int eLength)
        {
            length = eLength;
            wordsArr = wordsShuffler(eLength, eWords);
            rowBCoordinates = numbersShuffler(eLength);
        }


        
        // Public Methods
        public static void PrintBoard(string[] rowA, string[] rowB)
        {
            //Header coordinates
            Console.Write("  ");
            for (int i = 1; i <= rowA.Length; i++)
            {
                Console.Write("  " + i + " ");
            }
            Console.Write("\n");

            //Aside coordinates and play-board
            Console.Write("A ");
            for (int i = 0; i < rowA.Length; i++)
            {
                Console.Write($"; {rowA[i]} ");
            }
            Console.Write("\n");
            Console.Write("B ");
            for (int i = 0; i < rowB.Length; i++)
            {
                Console.Write($"; {rowB[i]} ");
            }
            Console.Write("\n");
        }


        // Constructor Methods
        private string[] wordsShuffler(int length, string[] arr)
        {
            string[] result = new string[length];
            for (int i = 0; i < length; i++)
            {
                string word = arr[random.Next(arr.Length)];
                if (Array.IndexOf(result, word) < 0)
                {
                    result[i] = word;
                }
                else i--;
            }
            return result;
        }
        private int[] numbersShuffler(int length)
        {
            int[] arr = new int[length];
            int[] arrShuffled = new int[length];

            for (int i = 0; i < length; i++)
            {
                arr[i] = i;
            }

            for (int j = 0; j < length; j++)
            {
                int rndValOfArr = arr[random.Next(arr.Length - 1)];
                arrShuffled[j] = rndValOfArr;
                arr = arr.Where(x => x != rndValOfArr).ToArray();
            }
            return arrShuffled;
        }
    }
}
