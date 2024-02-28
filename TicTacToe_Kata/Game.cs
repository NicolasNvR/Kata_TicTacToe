namespace TicTacToe_Test;

public class Game
{
	public string[][] GameBoard { get; set; }
	public void Start()
	{
		this.GameBoard = new string[][]{ new[] { "A", "B", "C" }, new[] { "0", "1", "2" } };
	}
	
	public string[][] GetBoardValues()
	{
		return this.GameBoard;
	}

	public string? GetPlayerInput()
	{
		return Console.ReadLine();
	}

	public void SetMarker(string coordinate)
	{
		string[] splitedCoordinates = coordinate.Split();
	}
}