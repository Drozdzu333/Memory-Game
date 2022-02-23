using Memory_Game;

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
                // Variables
                string difficulty;
                int boardLength;
                int maxLives;
                 
                difficulty = DifficultySelector.Choise();
                maxLives = DifficultySelector.maxLives(difficulty);
                boardLength = DifficultySelector.boardLength(difficulty);

                Board playBoard = new Board(words, boardLength);
            
                
                Console.Clear();


                string[] boardRowA = { "X", "X", "X", "X", "X", "X", "X", "X" };
                string[] boardRowB = { "X", "X", "X", "X", "X", "X", "X", "X" };

                Board.PrintBoard(boardRowA, boardRowB);


                exit = Console.ReadLine() == "exit" ? true : false;
            }
        }
    }
}
