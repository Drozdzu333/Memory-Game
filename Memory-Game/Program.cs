using Memory_Game;

namespace MemoryGame
{
    public class Program
    {
        static void Main()
        {
            string[] words = File.ReadAllLines("D:/Motorola/Coding Task Motorola Academy C#/Words.txt");
            string input = " ";
            while (input != "exit")
            {
                // Inicial
                string difficulty;
                int boardLength;
                int maxLives;

                // State
                int shootA = -1;
                int shootB = -1;
                string state = "A";


                difficulty = DifficultySelector.Choise();
                maxLives = DifficultySelector.MaxLives(difficulty);
                boardLength = DifficultySelector.BoardLength(difficulty);

                Board playBoard = new(words, boardLength);
                for (int attempt = 0; attempt < maxLives;)
                {
                    Console.Clear();
                    Tools.HeaderBoard(attempt, maxLives);
                    playBoard.PrintBoard(shootA, shootB);


                    Console.WriteLine("Enter column number of row " + state);
                    if (state == "A")
                    {
                        shootA = Tools.Move(boardLength);
                        state = "B";
                    }
                    else
                    {
                       shootB = Tools.Move(boardLength);
                       state = "A";

                       Tools.HeaderBoard(attempt, maxLives);
                       playBoard.PrintBoard(shootA, shootB);
                       
                       playBoard.ShootCompare(shootA, shootB);

                       Tools.PressToContinue();
                       shootA = -1;
                       shootB = -1;
                       attempt++;
                    }
                    if (Array.IndexOf(playBoard.found, -1) == -1)
                    {
                        Console.WriteLine("You won!");
                        Console.ReadLine();
                        attempt = maxLives + 1;
                    }
                }


                Console.WriteLine("Press Enter to continue or write \"exit\" and press Enter to escape.");
                input = Console.ReadLine();
            }
        }
    }
}
