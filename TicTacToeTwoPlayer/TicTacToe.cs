using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeTwoPlayer
{
    public class TicTacToeGame
    {
        static string fields;
        static string[] listOfFields;
        static string[,] tictactoe;
		public static bool playerOne;
        static string playerIdentifier;
        static string player;
        UserInterface UI = new UserInterface();
        public void NewGame()
        {
            fields = "1,2,3,4,5,6,7,8,9";
            PopulateBoard();
            UI.PrintBoard(tictactoe);
            playerOne = false;
            while (fields.Any(char.IsDigit) && !IsThereAWinOnBoard())
            {
                SwitchPlayer();
                PlayTurn();
            }

        }

        private void PlayTurn()
        {
            playerIdentifier = IsItPlayerOne() ? "X" : "O";
            player = IsItPlayerOne() ? "1" : "2";
            PlayerMove();
        }

        public bool IsItPlayerOne()
        {
            if (playerOne) return true;
            return false;
        }

        private void PlayerMove()
        {
            Console.WriteLine("Player " + player + " make your move");
            string move = Console.ReadLine().Trim();
            if (IsMoveValid(move))
            {
                fields = fields.Replace(move, playerIdentifier);
            }
            else
            {
                Console.WriteLine("Illegal Move Player" + player+ ". You loose your turn.");
                Console.WriteLine("Please hit anykey to continue.");
                Console.ReadKey();
            }
            PopulateBoard();
            UI.PrintBoard(tictactoe);
        }

        private bool IsMoveValid(string move)
        {
            if (move.Equals(""))
            {
                return false;
            }
            else if (move.Equals("X") || move.Equals("O"))
            {
                return false;
            }
            while (fields.Contains(move))
            {
                return true;
            }
            return false;
        }

        private void SwitchPlayer()
        {
            playerOne = playerOne ? false : true;
        }

        private void PopulateBoard()
        {
            tictactoe = new string[3, 3];
            listOfFields = fields.Split(',');
            int i = 0;
            int j = 0;
            foreach (var field in listOfFields)
            {

                tictactoe[j, i] = field;
                if (i < 2)
                {
                    i++;
                }
                else
                {
                    i = 0;
                    j++;
                }

            }
        }

        public bool IsThereAWinOnBoard()
        {
            listOfFields = fields.Split(',');
            for (int i = 0; i < 3; i++)
            {
                if (listOfFields[i] == listOfFields[i + 3] && listOfFields[i + 3] == listOfFields[i + 6])
                {
                    return true;
                }
            }
            for (int i = 0; i < 9; i = i + 3)
            {
                if (listOfFields[i] == listOfFields[i + 1] && listOfFields[i + 1] == listOfFields[i + 2])
                {
                    return true;
                }
            }
            if (listOfFields[0] == listOfFields[4] && listOfFields[4] == listOfFields[8])
            {
                return true;
            }
            if (listOfFields[2] == listOfFields[4] && listOfFields[4] == listOfFields[6])
            {
                return true;
            }

            return false;
        }
    }
}
