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
			playerOne = false;
			while (fields.Any (char.IsDigit) && !IsThereAWinOnBoard ()) {
				SwitchPlayer ();
				PlayTurn ();
			}
			if (IsThereAWinOnBoard ()) {
				Console.WriteLine ("Player" + player + " WINS!!!");
			} else {
				Console.WriteLine ("Its A DRAW!!! \n GAME OVER");
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
			string move = Console.ReadLine ().Trim ();
			if (IsMoveValid (move)) {
				fields = fields.Replace (move, playerIdentifier);
			} else {
				Console.WriteLine ("Illegal Move Player" + player);
				Console.ReadKey ();
			}
			PopulateBoard ();
			PrintBoard ();
		}

		private bool IsMoveValid (string move)
		{
			if (move.Equals ("")) {
				return false;
			}
			while (fields.Contains (move)) {
				return true;
			}
			return false;
		}

		private void SwitchPlayer ()
		{
			playerOne = playerOne ? false : true;
		}

		private  void PopulateBoard ()
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

		private void PrintBoard ()
		{
			Console.Clear ();
			for (int x = 0; x < 3; x++) {
				Console.WriteLine (tictactoe [x, 0] + " | " + tictactoe [x, 1] + " | " + tictactoe [x, 2]);
			}
		}

		private bool IsThereAWinOnBoard ()
		{
			listOfFields = fields.Split (',');
			for (int i = 0; i < 3; i++) {
				if (listOfFields [i] == listOfFields [i + 3] && listOfFields [i + 3] == listOfFields [i + 6]) {
					return true;
				}
			}
			for (int i = 0; i < 9; i = i + 3) {
				if (listOfFields [i] == listOfFields [i + 1] && listOfFields [i + 2] == listOfFields [i + 6]) {
					return true;
				}
			}
			if (listOfFields [0] == listOfFields [4] && listOfFields [4] == listOfFields [8]) {
				return true;
			}
			if (listOfFields [2] == listOfFields [4] && listOfFields [4] == listOfFields [6]) {
				return true;
			}

			return false;
		}
	}
}
