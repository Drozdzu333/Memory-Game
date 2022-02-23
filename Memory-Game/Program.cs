using Memory_Game;

namespace MemoryGame
{

    class Program
    {

        static void Main()
        {
            Random random = new Random();

            string[] words = File.ReadAllLines("D:/Motorola/Coding Task Motorola Academy C#/Words.txt");
            bool exit = false;
            while (!exit)
            {
                // Variables
                bool chosenDifficulty = false;
                string difficulty = "";
                int boardLength  = 0;
                int maxLives = 0;


                Console.Clear();

                // 
                while (!chosenDifficulty)
                {
                Console.WriteLine("Write the difficulty level: easy | hard");
                difficulty = Console.ReadLine();
                    if(difficulty == "easy")
                    {
                        chosenDifficulty = true;
                    }else if(difficulty == "hard")
                    {
                        chosenDifficulty = true;

                    };
                };
                Console.WriteLine($"Chosen level {difficulty}");

                // Rules for board creation
                if (difficulty == "easy")
                {
                    boardLength = 5;
                    maxLives = 10;
                }else if (difficulty == "hard")
                {
                    boardLength = 8;
                    maxLives = 15;
                }

                // Filling boards of not duplicated words
                string[] rowA = new string[boardLength];
                
                
                for (int i = 0; i < boardLength; i++)
                {
                    string word = words[random.Next(words.Length)];
                    if (Array.IndexOf(rowA, word) < 0)
                    {
                        rowA[i] = word;
                    }
                    else i--;
                }

                //
                int[] rowB = arrShuffle(boardLength);

                    // shuffle words in row
                int[] arrShuffle(int length)
                {
                    Console.WriteLine("ArrShuffle init: " + length);
                    int[] arr = new int[length];
                    int[] arrShuffled = new int[length];
                    // wypełniacz rosnąco
                    for (int i = 0; i < length; i++)
                    {
                        arr[i] = i;
                    }
                    // randomizer
                    for(int j =  0; j < length; j++)
                    {
                        int rndValOfArr = arr[random.Next(arr.Length -1)];
                        arrShuffled[j] = rndValOfArr;
                        arr = arr.Where(x => x != rndValOfArr).ToArray();
                    }
                    return arrShuffled;
                }
                







                // End of level loop
            
            Board board = new Board(boardLength, words);
                board.PrintBoard();
            exit = Console.ReadLine() == "exit" ? true: false ;
            }
            // end of Main Loop
        }





       
    }
}
