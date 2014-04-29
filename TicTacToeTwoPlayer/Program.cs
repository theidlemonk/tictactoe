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
            Console.CursorVisible = true;
            TicTacToeGame game = new TicTacToeGame();
            game.NewGame();
            UI.EndGame();
            Console.ReadKey();
            //ConsoleSpiner spin = new ConsoleSpiner();
            //Console.Write("Working....");
            //while (true)
            //{
            //    spin.Turn();
            //}
        }
    }

    //public class ConsoleSpiner
    //{
    //    int counter;
    //    public ConsoleSpiner()
    //    {
    //        counter = 0;
    //    }
    //    public void Turn()
    //    {
    //        counter++;
    //        switch (counter % 4)
    //        {
    //            case 0: Console.Write("/"); break;
    //            case 1: Console.Write("-"); break;
    //            case 2: Console.Write("\\"); break;
    //            case 3: Console.Write("|"); break;
    //        }
    //        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    //    }
    //}

}
