using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory_Game
{
    internal class Board 
    {
        int lenght;
        string[] words;
        public Board(int eLength, string[] eWords)
        {
            lenght = eLength;
            words = eWords;
        }
        public void PrintBoard()
        {
            //Header coordinates
            Console.Write("  ");
            for (int i = 1; i <= lenght; i++)
            {
                Console.Write("  " + i + " ");
            }
            Console.Write("\n");

            //Side coordinates and play-board
            Console.Write("A ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("; X ");
            }
            Console.Write("\n");
            Console.Write("B ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("; X ");
            }
            Console.Write("\n");
            Console.Write("C ");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write($"; {words[i]} ");
            }
        }
    }
}
