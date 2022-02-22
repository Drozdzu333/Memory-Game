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
                string[] boardsWords = new string[boardLength];
                for (int i = 0; i < boardLength; i++)
                {
                    string word = words[random.Next(words.Length)];
                    if (Array.IndexOf(boardsWords, word) < 0)
                    {
                        boardsWords[i] = word;
                    }
                    else i--;
                }
                foreach(string el in boardsWords){
                    Console.WriteLine(el);
                }




                Board(5);

                exit = Console.ReadLine() == "exit" ? true: false ;


            }

        }

        private static void forech(int v, object el, string[] boardsWords)
        {
            throw new NotImplementedException();
        }

        static void Board(int col)
        {
            //Header coordinates
            Console.Write("  ");
            for (int i = 1; i <= col; i++)
            {
                Console.Write("  " + i + " ");
            }
            Console.Write("\n");
            //Side coordinates and play-board
            Console.Write("A ");
            for (int i = 0; i < col; i++)
            {
                Console.Write("; X ");
            }
            Console.Write("\n");
            Console.Write("B ");
            for (int i = 0; i < col; i++)
            {
                Console.Write("; X ");
            }
        }
    }
}
//public class Difficulty
//{
//    int boardLength, maxChances;
//    string difficulty = GetDifficulty();

//    string void GetDifficulty()
//    { 
//    };
//             private bool choosed = false;
//            for(choosed; choosed == true)
//            {
//                Console.WriteLine("Choose the difficulty level. easy | hard :");
//                difficulty = Console.ReadLine().ToLower();
//                if (difficulty == "easy")
//                {
//                    boardLength = 5;
//                    maxChances = 10;
//                    choosed = true;
//                }
//                else if (difficulty == "hard")
//                {
//                    boardLength = 8;
//                    maxChances = 15;
//                    choosed = true;
//                }
//            }
//        }
//}
