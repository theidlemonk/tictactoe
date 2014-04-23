using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToeTwoPlayer
{
    class Program
    {
        //1. tic tac toe - 2player - done
        //2. announces when someone wins - done
        //3. 1 plaayer vs computer (random rows) 
        //4. 1p vs computer (blocks potential wins)

        static void Main(string[] args)
        {
            Spash();
            TicTacToeGame game = new TicTacToeGame();
            game.NewGame();
            Console.ReadKey();
        }

        private static void Spash()
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
