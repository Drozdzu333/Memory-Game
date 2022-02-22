namespace MemoryGame
{

    class Program
    {

        static void Main()
        {
            string[] words = File.ReadAllLines("D:/Motorola/Coding Task Motorola Academy C#/Words.txt");
            bool exit = false;
            while (!exit)
            {
                bool chosenDifficulty = false;
                string difficulty = "none";
                Console.Clear();

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

                Board(5);

                exit = Console.ReadLine() == "exit" ? true: false ;


            }

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
