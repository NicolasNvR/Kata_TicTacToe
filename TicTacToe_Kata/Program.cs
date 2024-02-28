using TicTacToe_Test;

namespace TicTacToe_Kata
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Game game = new();
			Console.WriteLine(game.GetBoardValues());
		}
	}
}
