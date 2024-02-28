using FluentAssertions;

namespace TicTacToe_Test
{
	public class UnitTest1
	{
		//public void IsKoordinatenValid()
		//{
		//	// A
		//	string xKoordinate = "A";
		//	int yKoordinate = 0;
		//	Player player1 = new();

		//	// Act
		//	SetxKoordinate();


		//	// Assert
		//	player1.xKoordinate.should.Be("A");
		//	player1.yKoordinate.should.Be(0);
		//}

		[Fact]
		public void OnGameStartBoardShouldExist()
		{
			// Assign
			string[][] expectedBoard = { new[] { "A", "B", "C" }, new[] { "0", "1", "2" } };
			Game game = new();

			// Act
			game.Start();
			string[][] board = game.GetBoardValues();

			// Assert
			board.Should().BeEquivalentTo(expectedBoard);
		}

		[Fact]
		public void CanPlayerSetMarkerToA0()
		{
			// A
			Game game = new();
			string coordinates = "A0";

			// A
			game.Start();
			game.SetMarker(coordinates);

			// A
			game.GameBoard[0][0].Should().Be("X");
		}
	}
}