using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTwoPlayer
{
    class Program
    {
        //1. tic tac toe - 2player
        //2. announces when someone wins
        //3. 1 plaayer vs computer (random rows)
        //4. 1p vs al (blocks potential wins)

        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            game.NewGame();
            Console.ReadKey();
        }

    }
}
