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
		static bool playerOne;
		static string playerIdentifier;
		static string player;

		public void NewGame ()
		{
			fields = "1,2,3,4,5,6,7,8,9";
			PopulateBoard ();
			PrintBoard ();
			playerOne = true;
			while (fields.Any (char.IsDigit)) {
				PlayTurn ();
			}
		}

		private void PlayTurn ()
		{
			playerIdentifier = playerOne ? "X" : "O";
			player = playerOne ? "1" : "2";
			PlayerMove ();
		}

		private void PlayerMove ()
		{
			Console.WriteLine ("Player " + player + " make your move");
			string move = Console.ReadLine ().Trim();
			if (IsMoveValid(move)) {
				fields = fields.Replace (move, playerIdentifier);
			} else {
				Console.WriteLine ("Illegal Move Player" + player);
				Console.ReadKey ();
			}
			PopulateBoard ();
			PrintBoard ();
			SwitchPlayer ();
		}

		private bool IsMoveValid(string move)
		{ if (move.Equals("")) {
				return false;}
			while (fields.Contains(move)) {
				return true;
			}
			return false;
		}

		private void SwitchPlayer ()
		{
			playerOne = playerOne ? false : true;
		}

		public static void PopulateBoard ()
		{
			tictactoe = new string[3, 3];
			listOfFields = fields.Split (',');
			int i = 0;
			int j = 0;
			foreach (var field in listOfFields) {

				tictactoe [j, i] = field;
				if (i < 2) {
					i++;
				} else {
					i = 0;
					j++;
				}

			}
		}

		public static void PrintBoard ()
		{
			Console.Clear ();
			for (int x = 0; x < 3; x++) {
				Console.WriteLine (tictactoe [x, 0] + " | " + tictactoe [x, 1] + " | " + tictactoe [x, 2]);
			}
		}
	}
}
