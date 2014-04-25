using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            UserInterface UI = new UserInterface();
            UI.Spash();
            TicTacToeGame game = new TicTacToeGame();
            game.NewGame();
			UI.EndGame ();
            Console.ReadKey();
        }

        
    }
}
