using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Game
{
    public class Tools
    {
        public static void HeaderBoard(int attempt, int maxLives)
        {
        Console.Clear();
        Console.WriteLine($"Try: {attempt + 1} of {maxLives}");
        }
        public static int Move(int maxLength)
        {
            int shoot = -1;
            do
            {
                try
                {
                    shoot = Convert.ToInt16(Console.ReadLine()) - 1;
                }
                catch (Exception)
                {
                    Console.WriteLine(float.NaN);
                }
            }
            while (shoot < 0 || shoot > maxLength - 1);
            return shoot;
        }
        public static void PressToContinue()
        {
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }
}
