

namespace Memory_Game
{
    static class DifficultySelector
    {
        public static string Choise()
        {
            Console.Clear();
            string choise;
            bool exit;
            do
            {
                Console.WriteLine("Write the difficulty level: easy | hard");
                choise = Console.ReadLine();
                if (choise == "easy")
                {
                    exit = true;
                }
                else if (choise == "hard")
                {
                    exit = true;

                }
                else
                {
                    exit = false;
                }
            }
            while (!exit);
            Console.WriteLine($"Chosen level {choise}");
            return choise;
        }
        public static int BoardLength(string level)
        {
            if (level == "easy")
            {
                return 5;
            }
            else
            {
                return 8;

            }
        }
        public static int MaxLives(string level)
        {
            if (level == "easy")
            {
                return 10;
            }
            else
            {
                return 15;

            }
        }
    }
}
