namespace Memory_Game
{
    class Board 
    {
        readonly Random random = new();

        public int length;
        public string[] wordsArr;
        public int[] rowBCoordinates;
        public int[] found;

        public Board(string[] eWords, int eLength)
        {
            length = eLength;
            wordsArr = WordsShuffler(eLength, eWords);
            rowBCoordinates = NumbersShuffler(eLength);
            found = new int [eLength];


            for(int i = 0; i < eLength; i++)
            {
                found[i] = -1;
            }
        }
        


        



        
        // Public Methods
        public void PrintBoard(int shootA, int shootB)
        {
            //Header coordinates
            Console.Write("  ");
            for (int i = 1; i <= length; i++)
            {
                Console.Write("  " + i + " ");
            }
            Console.Write("\n");

            //Aside coordinates and play-board
            Console.Write("A ");
            string[] arr = new string[length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (found[i] >= 0)
                {
                    arr[i] = "O";
                }
                else if (shootA == i)
                {
                    arr[i] = wordsArr[i];
                }
                else
                {
                    arr[i] = "X";
                }
            }
            foreach (string s in arr)
            {
                Console.Write($"; {s} ");
            }

            Console.Write("\n");

            Console.Write("B ");
            
            string[] arr2 = new string[length];

            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = "X";
            }
            if (shootB >= 0)
            {
                int index = rowBCoordinates[shootB];
                arr2[shootB] = wordsArr[index];
            }

            for(int i = 0; i<arr2.Length; i++)
            {
                int index = rowBCoordinates[i];
                if ( found[index] >= 0)
                {
                    arr2[i] = "O";
                }
            }
            
            foreach (string s in arr2)
            {
                Console.Write($"; {s} ");
            }
            Console.Write("\n");
        }

        






        // Constructor Methods
        private string[] WordsShuffler(int length, string[] arr)
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
        private int[] NumbersShuffler(int length)
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
