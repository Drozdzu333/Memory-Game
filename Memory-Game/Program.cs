namespace MemoryGame
{


    class Program
    {

        static void Main()
        {
            Console.Clear();
            Board(5);
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
