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
                int shootA = -1;
                int shootB = -1;
                string state = "A";
                


                difficulty = DifficultySelector.Choise();
                maxLives = DifficultySelector.MaxLives(difficulty);
                boardLength = DifficultySelector.BoardLength(difficulty);

                Board playBoard = new(words, boardLength);


                
                for (int i = 0; i < maxLives;)
                {
                    Console.Clear();
                    Console.WriteLine($"Try: {i + 1} of {maxLives}");
                    playBoard.PrintBoard(shootA, shootB);

                    Console.WriteLine("Enter column number of row " + state);
                    if (state == "A")
                    {
                        do
                        {
                            try
                            {
                                shootA = Convert.ToInt16(Console.ReadLine()) - 1;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(float.NaN);
                            }
                        }
                        while (shootA < 0 || shootA > boardLength - 1);
                        state = "B";
                        Console.Clear();
                    }
                    else
                    {
                        do
                        {
                            try
                            {
                                shootB = Convert.ToInt16(Console.ReadLine()) - 1;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(float.NaN);
                            }
                        }
                        while (shootB < 0 || shootB > boardLength - 1);

                        state = "A";
                        Console.Clear();
                        Console.WriteLine($"Try: {i + 1} of {maxLives}");
                        playBoard.PrintBoard(shootA, shootB);
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        ShootCompare();
                        shootA = -1;
                        shootB = -1;
                        i++;
                    }
                    if(Array.IndexOf(playBoard.found,-1) == -1)
                    {
                        Console.WriteLine("You won!");
                        Console.ReadLine();
                        i = maxLives +1;
                    }
                }

                        // ------------  COMPARE F    --------------
                void ShootCompare()
                {
                    if (shootA == playBoard.rowBCoordinates[shootB])
                    {
                        playBoard.found[shootA] = 1;
                    }
                }



                Console.WriteLine("Press Enter to continue or write \"exit\" and press Enter to escape.");
                exit = Console.ReadLine() == "exit";
            }
        }
    }
}
