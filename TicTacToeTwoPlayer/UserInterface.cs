using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToeTwoPlayer
{
    public class UserInterface
    {
        
        public void PrintBoard(string[,] tictactoe)
        {
            Console.Clear();
            Console.WriteLine("              ___ ___ ___  ");
            for (int x = 0; x < 3; x++)
            {
                Console.WriteLine("             | " + tictactoe[x, 0] + " | " + tictactoe[x, 1] + " | " + tictactoe[x, 2] + " | ");
                Console.WriteLine("              ---+---+---  ");
            }

        }

        public void EndGame()
        {
            TicTacToeGame game = new TicTacToeGame();
            if (game.IsThereAWinOnBoard())
            {
                if (game.IsItPlayerOne())
                {
                    Console.WriteLine("Player1 WINS!!!");
                }
                else
                { Console.WriteLine("Player2 WINS!!!"); }

            }
            else
            {
                Console.WriteLine("Its A DRAW!!! \n GAME OVER");
            }
        }

        public void Spash()
        {
            Console.WriteLine(@"      ___       ___       ___   ");
            Console.WriteLine(@"     /\  \     /\  \     /\  \  ");
            Console.WriteLine(@"     \:\  \   _\:\  \   /::\  \ ");
            Console.WriteLine(@"     /::\__\ /\/::\__\ /:/\:\__\");
            Console.WriteLine(@"    /:/\/__/ \::/\/__/ \:\ \/__/");
            Console.WriteLine(@"    \/__/     \:\__\    \:\__\  ");
            Console.WriteLine(@"               \/__/     \/__/  ");
            Console.WriteLine(@"              ___       ___       ___  ");
            Console.WriteLine(@"             /\  \     /\  \     /\  \  ");
            Console.WriteLine(@"             \:\  \   /::\  \   /::\  \ ");
            Console.WriteLine(@"             /::\__\ /::\:\__\ /:/\:\__\");
            Console.WriteLine(@"            /:/\/__/ \/\::/  / \:\ \/__/");
            Console.WriteLine(@"            \/__/      /:/  /   \:\__\  ");
            Console.WriteLine(@"                       \/__/     \/__/  ");
            Console.WriteLine(@"                        ___       ___       ___   ");
            Console.WriteLine(@"                       /\  \     /\  \     /\  \  ");
            Console.WriteLine(@"                       \:\  \   /::\  \   /::\  \ ");
            Console.WriteLine(@"                       /::\__\ /:/\:\__\ /::\:\__\");
            Console.WriteLine(@"                      /:/\/__/ \:\/:/  / \:\:\/  /");
            Console.WriteLine(@"                      \/__/     \::/  /   \:\/  / ");
            Console.WriteLine(@"                                 \/__/     \/__/  ");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
